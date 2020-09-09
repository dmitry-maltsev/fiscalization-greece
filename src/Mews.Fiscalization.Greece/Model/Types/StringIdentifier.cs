using System;
using System.Text.RegularExpressions;

namespace Mews.Fiscalization.Greece.Model.Types
{
    public abstract class StringIdentifier
    {
        protected StringIdentifier(string value, Regex pattern)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            if (pattern == null)
            {
                throw new ArgumentNullException(nameof(pattern));
            }
            if (!pattern.IsMatch(value))
            {
                throw new ArgumentException($"The value '{value}' does not match the pattern '{pattern}'");
            }

            Value = value;
        }

        public string Value { get; }
    }
}
