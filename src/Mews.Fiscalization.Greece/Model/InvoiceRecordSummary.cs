using System;
using System.Collections.Generic;
using System.Text;

namespace Mews.Fiscalization.Greece.Model
{
    public class InvoiceRecordSummary
    {
        public InvoiceRecordSummary(decimal totalNetValue, decimal totalVatAmount, decimal totalGrossValue, InvoiceRecordIncomeClassification invoiceRecordIncomeClassification)
        {
            TotalNetValue = totalNetValue;
            TotalVatAmount = totalVatAmount;
            TotalGrossValue = totalGrossValue;
            InvoiceRecordIncomeClassification = invoiceRecordIncomeClassification;
        }

        public decimal TotalNetValue { get; }

        public decimal TotalVatAmount { get; }

        public decimal TotalGrossValue { get; }

        public InvoiceRecordIncomeClassification InvoiceRecordIncomeClassification { get; } 
    }
}
