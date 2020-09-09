using Mews.Fiscalization.Greece.Model.Types;
using System;

namespace Mews.Fiscalization.Greece.Model
{
    public class InvoiceRecordSummary
    {
        public InvoiceRecordSummary(Amount totalNetValue, Amount totalVatAmount, Amount totalWithheldAmount, Amount totalFeesAmount,
            Amount totalStampDutyAmount, Amount totalOtherTaxesAmount, Amount totalDeductionsAmount, Amount totalGrossValue)
        {
            TotalNetValue = totalNetValue ?? throw new ArgumentNullException(nameof(totalNetValue));
            TotalVatAmount = totalVatAmount ?? throw new ArgumentNullException(nameof(totalVatAmount));
            TotalWithheldAmount = totalWithheldAmount ?? throw new ArgumentNullException(nameof(totalWithheldAmount));
            TotalFeesAmount = totalFeesAmount ?? throw new ArgumentNullException(nameof(totalFeesAmount));
            TotalStampDutyAmount = totalStampDutyAmount ?? throw new ArgumentNullException(nameof(totalStampDutyAmount));
            TotalOtherTaxesAmount = totalOtherTaxesAmount ?? throw new ArgumentNullException(nameof(totalOtherTaxesAmount));
            TotalDeductionsAmount = totalDeductionsAmount ?? throw new ArgumentNullException(nameof(totalDeductionsAmount));
            TotalGrossValue = totalGrossValue ?? throw new ArgumentNullException(nameof(totalGrossValue));
        }

        public Amount TotalNetValue { get; }

        public Amount TotalVatAmount { get; }

        public Amount TotalWithheldAmount { get; }

        public Amount TotalFeesAmount { get; }

        public Amount TotalStampDutyAmount { get; }

        public Amount TotalOtherTaxesAmount { get; }

        public Amount TotalDeductionsAmount { get; }

        public Amount TotalGrossValue { get; }
    }
}
