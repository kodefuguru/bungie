namespace BaseJump.Core
{
    using System;
    using System.Reflection;

    internal static class ModelValueFormatter
    {
        public static string Format(object value, string format = null)
        {
            if (value == null)
                return String.Empty;

            if (format != null)
            {
                var method = value.GetType().GetRuntimeMethod("ToString", new[] { typeof(string) });
                if (method != null)
                {
                    return method.Invoke(value, new[] { format }) as string;
                }
            }
            return value.ToString();
        }
    }
}
