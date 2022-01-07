using System;

namespace Common.Core.Extension
{
    public static class ExceptionExtensions
    {
        public static string GetFullMessage(this Exception ex)
        {
            return ex.InnerException == null
                 ? $"-{ex.Message}"
                 : $"-{ex.Message}{Environment.NewLine}{ex.InnerException.GetFullMessage()}";
        }
    }
}
