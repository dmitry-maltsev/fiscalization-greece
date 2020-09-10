using System;
using System.Collections.Generic;
using System.Text;

namespace Mews.Fiscalization.Greece.Extensions
{
    internal static class EnumExtensions
    {
        internal static T ConvertToEnum<T>(this Enum source) where T : Enum
        {
            return (T)Enum.Parse(typeof(T), source.ToString(), true);
        }
    }
}
