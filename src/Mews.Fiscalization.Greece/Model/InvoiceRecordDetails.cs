using Mews.Fiscalization.Greece.Extensions;
using Mews.Fiscalization.Greece.Model.Types;
using System;

namespace Mews.Fiscalization.Greece.Model
{
    public class InvoiceRecordDetails
    {
        public InvoiceRecordDetails(int lineNumber, Amount netValue, Amount vatAmount)
        {
            if (lineNumber < 1)
            {
                throw new ArgumentException($"Minimal {nameof(lineNumber)} value is 1.");
            }

            LineNumber = lineNumber;
            NetValue = netValue ?? throw new ArgumentNullException(nameof(netValue));
            VatAmount = vatAmount ?? throw new ArgumentNullException(nameof(vatAmount));
        }

        public int LineNumber { get; }

        public Amount NetValue { get; }

        public Amount VatAmount { get; }
    }
}
