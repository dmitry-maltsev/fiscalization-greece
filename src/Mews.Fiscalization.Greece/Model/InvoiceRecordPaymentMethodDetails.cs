using System;
using System.Collections.Generic;
using System.Text;

namespace Mews.Fiscalization.Greece.Model
{
    public class InvoiceRecordPaymentMethodDetails
    {
        public InvoiceRecordPaymentMethodDetails(decimal amount, PaymentType paymentType)
        {
            Amount = amount;
            PaymentType = paymentType;
        }

        public decimal Amount { get; }

        public PaymentType PaymentType { get; }
    }
}
