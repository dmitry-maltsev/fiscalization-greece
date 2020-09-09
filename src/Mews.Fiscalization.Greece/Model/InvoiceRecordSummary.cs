using Mews.Fiscalization.Greece.Model.Types;
using System;

namespace Mews.Fiscalization.Greece.Model
{
    public class InvoiceRecordSummary
    {
        public InvoiceRecordSummary(Amount totalNetValue, Amount totalVatAmount, Amount totalGrossValue, InvoiceRecordIncomeClassification invoiceRecordIncomeClassification)
        {
            TotalNetValue = totalNetValue ?? throw new ArgumentNullException(nameof(totalNetValue));
            TotalVatAmount = totalVatAmount ?? throw new ArgumentNullException(nameof(totalVatAmount));
            TotalGrossValue = totalGrossValue ?? throw new ArgumentNullException(nameof(totalGrossValue));
            InvoiceRecordIncomeClassification = invoiceRecordIncomeClassification ?? throw new ArgumentNullException(nameof(invoiceRecordIncomeClassification));
        }

        public Amount TotalNetValue { get; }

        public Amount TotalVatAmount { get; }

        public Amount TotalGrossValue { get; }

        public InvoiceRecordIncomeClassification InvoiceRecordIncomeClassification { get; }
    }
}
