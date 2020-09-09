using Mews.Fiscalization.Greece.Extensions;
using System;

namespace Mews.Fiscalization.Greece.Model.Types
{
    public class LimitedDecimal
    {
        public LimitedDecimal(decimal value, decimal minValue, int maxDecimalPlaces)
        {
            var isValidAmount = value >= minValue && value.GetDecimalPlaces() <= maxDecimalPlaces;
            if (!isValidAmount)
            {
                throw new ArgumentException($"{nameof(value)} is not valid decimal.");
            }

            Value = value;
        }

        public decimal Value { get; }
    }
}
