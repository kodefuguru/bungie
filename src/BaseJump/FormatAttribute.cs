namespace BaseJump
{
    using System;

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    internal partial class FormatAttribute : Attribute
    {
        public string Format { get; private set; }

        public FormatAttribute(string format)
        {
            Format = format;
        }
    }
}
