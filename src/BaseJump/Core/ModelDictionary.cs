namespace BaseJump.Core
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    using System.Text;

    internal partial class ModelDictionary : Dictionary<string, object>
    {
        private readonly object model;

        public ModelDictionary(object model)
        {
            this.model = model;
            AddModelItems();
        }

        private void AddModelItems()
        {
            foreach (var property in model.GetType().GetRuntimeProperties())
            {
                Add(property.Name, property.GetValue(model));               
            }
        }
    }
}
