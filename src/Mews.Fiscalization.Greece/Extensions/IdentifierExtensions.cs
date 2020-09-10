using Mews.Fiscalization.Greece.Model.Types;

namespace Mews.Fiscalization.Greece.Extensions
{
    public static class IdentifierExtensions
    {
        public static bool IsDefined<T>(this Identifier<T> value)
        {
            return value != null;
        }

        public static T GetOrDefault<T>(this Identifier<T> value)
        {
            if (!value.IsDefined())
            {
                return default(T);
            }

            return value.Value;
        }
    }
}