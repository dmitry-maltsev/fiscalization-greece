using System;

namespace Mews.Fiscalization.Greece.Model.Types
{
    public abstract class LimitedString
    {
        public LimitedString(string value, int minLength, int? maxLength)
        {
            if (maxLength != null && value.Length > maxLength.Value)
            {
                throw new ArgumentException($"Max length of string is {maxLength.Value}.");
            }

            if (value.Length < minLength)
            {
                throw new ArgumentException($"Min length of string is {minLength}.");
            }

            Value = value;
        }

        public string Value { get; }
    }
}
