namespace BaseJump.Core.Metadata
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    internal partial class ModelMetadataProvider : IModelMetadataProvider
    {
        private IDictionary<Type, CustomAttributeData> attributes;
        private PropertyInfo propertyInfo;
        private ModelMetadata metadata;

        public IModelMetadata GetMetadataFor(object model, string propertyName)
        {
            metadata = new ModelMetadata
            {
                Model = model,
                ModelType = model.GetType(),
                PropertyName = propertyName,     
            };

            SetOrderedProperties();

            return metadata;
        }

        private void SetOrderedProperties()
        {
            propertyInfo = metadata.ModelType.GetRuntimeProperty(metadata.PropertyName);
            if (propertyInfo == null)
            {
                throw new Exception("Invalid model property.");
            }
            metadata.PropertyType = propertyInfo.PropertyType;

            metadata.ClassName = metadata.ModelType.Name;
            attributes = GetAttributeMap();
            metadata.Name = GetName();
            metadata.Format = GetFormat();
            metadata.Ignore = GetIgnore();
        }

        private string GetName()
        {
            if (attributes.ContainsKey(typeof(NameAttribute)))
            {
                var attribute = attributes[typeof(NameAttribute)].CreateAttribute() as NameAttribute;
                return attribute.Name;
            }
            return metadata.PropertyName;
        }

        private string GetFormat()
        {
            if (attributes.ContainsKey(typeof(FormatAttribute)))
            {
                var attribute = attributes[typeof(FormatAttribute)].CreateAttribute() as FormatAttribute;
                return attribute.Format;
            }
            return null;
        }

        private bool GetIgnore()
        {
            return attributes.ContainsKey(typeof(IgnoreAttribute));
        }

        private IDictionary<Type, CustomAttributeData> GetAttributeMap()
        {
            return GetAttributes()
                    .Select(a => new { Key = GetFirstLevelAttributeType(a.AttributeType), Value = a  })
                    .Where(x => x.Key != null)
                    .ToDictionary(x => x.Key, x => x.Value);
        }

        private IEnumerable<CustomAttributeData> GetAttributes()
        {
            var info = UnwrapNullable(metadata.PropertyType.GetTypeInfo());

            foreach (var attribute in info.CustomAttributes)
            {
                yield return attribute;
            }

            foreach (var attribute in propertyInfo.CustomAttributes)
            {
                yield return attribute;
            }
        }

        private TypeInfo UnwrapNullable(TypeInfo info)
        {
            if (info.IsGenericType && info.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                return info.GenericTypeArguments[0].GetTypeInfo();
            }
            return info;
        }

        private Type GetFirstLevelAttributeType(Type attributeType)
        {
            var next = attributeType;
            while (next != typeof(Attribute) && next != typeof(Object) && next != null)
            {
                attributeType = next;
                next = next.GetTypeInfo().BaseType;
            }
            return attributeType;
        }
    }

}
