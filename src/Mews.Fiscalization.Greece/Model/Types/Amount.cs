using Mews.Fiscalization.Greece.Extensions;
using System;

namespace Mews.Fiscalization.Greece.Model.Types
{
    public class Amount
    {
        public Amount(decimal value)
        {
            var isValidAmount = value >= 0 && value.GetDecimalPlaces() <= 2;
            if (!isValidAmount)
            {
                throw new ArgumentException($"{nameof(value)} is not valid amount number.");
            }

            Value = value;
        }

        public decimal Value { get; }
    }
}
