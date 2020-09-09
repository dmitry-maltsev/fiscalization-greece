using Mews.Fiscalization.Greece.Model.Types;
using System;

namespace Mews.Fiscalization.Greece.Model
{
    public class InvoiceRecordDetail
    {
        public InvoiceRecordDetail(PositiveInt lineNumber, Amount netValue, VatType vatType, Amount vatAmount, InvoiceRecordIncomeClassification invoiceRecordIncomeClassification)
        {
            LineNumber = lineNumber ?? throw new ArgumentNullException(nameof(lineNumber));
            NetValue = netValue ?? throw new ArgumentNullException(nameof(netValue));
            VatType = vatType;
            VatAmount = vatAmount ?? throw new ArgumentNullException(nameof(vatAmount));
            InvoiceRecordIncomeClassification = invoiceRecordIncomeClassification ?? throw new ArgumentNullException(nameof(invoiceRecordIncomeClassification));
        }

        public PositiveInt LineNumber { get; }

        public Amount NetValue { get; }

        public VatType VatType { get; }

        public Amount VatAmount { get; }

        public InvoiceRecordIncomeClassification InvoiceRecordIncomeClassification { get; }
    }
}
