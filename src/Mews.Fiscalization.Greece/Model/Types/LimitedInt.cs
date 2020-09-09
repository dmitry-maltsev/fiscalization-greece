using System;

namespace Mews.Fiscalization.Greece.Model.Types
{
    public class LimitedInt
    {
        public LimitedInt(int value, int minValue, int? maxValue = null)
        {
            if (maxValue != null && value > maxValue.Value)
            {
                throw new ArgumentException($"Max value of int is {maxValue.Value}.");
            }

            if (value < minValue)
            {
                throw new ArgumentException($"Min value of int is {minValue}.");
            }

            Value = value;
        }

        public int Value { get; }
    }
}
