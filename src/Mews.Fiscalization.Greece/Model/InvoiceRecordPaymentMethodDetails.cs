using Mews.Fiscalization.Greece.Model.Types;
using System;

namespace Mews.Fiscalization.Greece.Model
{
    public class InvoiceRecordPaymentMethodDetails
    {
        public InvoiceRecordPaymentMethodDetails(Amount amount, string paymentMethodInfo)
        {
            Amount = amount ?? throw new ArgumentNullException(nameof(amount));
            PaymentMethodInfo = paymentMethodInfo;
        }

        public Amount Amount { get; }

        public string PaymentMethodInfo { get; }
    }
}
