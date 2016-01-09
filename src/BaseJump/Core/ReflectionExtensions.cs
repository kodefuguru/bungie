namespace BaseJump.Core
{
    using System;
    using System.Linq;
    using System.Reflection;

    internal static class ReflectionExtensions
    {
        public static Attribute CreateAttribute(this CustomAttributeData data)
        {            
            var arguments = data.ConstructorArguments.Select(a=> a.Value).ToArray();

            var attribute = Activator.CreateInstance(data.AttributeType, arguments) as Attribute;

            foreach (var namedArgument in data.NamedArguments)
            {
                if (namedArgument.IsField)
                {
                    var fieldInfo = attribute.GetType().GetRuntimeField(namedArgument.MemberName);
                    if (fieldInfo != null)
                    {
                        fieldInfo.SetValue(attribute, namedArgument.TypedValue.Value);
                    } 
                }
                else
                {
                    var propertyInfo = attribute.GetType().GetRuntimeProperty(namedArgument.MemberName);
                    if (propertyInfo != null)
                    {
                        propertyInfo.SetValue(attribute, namedArgument.TypedValue.Value, null);
                    }
                }
            }
            return attribute;
        }

    }
}
