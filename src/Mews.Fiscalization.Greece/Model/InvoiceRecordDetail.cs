using System;
using System.Collections.Generic;
using System.Text;

namespace Mews.Fiscalization.Greece.Model
{
    public class InvoiceRecordDetail
    {
        public InvoiceRecordDetail(int lineNumber, decimal netValue, VatType vatType, decimal vatAmount, InvoiceRecordIncomeClassification invoiceRecordIncomeClassification)
        {
            LineNumber = lineNumber;
            NetValue = netValue;
            VatType = vatType;
            VatAmount = vatAmount;
            InvoiceRecordIncomeClassification = invoiceRecordIncomeClassification;
        }

        public int LineNumber { get; }

        public decimal NetValue { get; }

        public VatType VatType { get; }

        public decimal VatAmount { get; }

        public InvoiceRecordIncomeClassification InvoiceRecordIncomeClassification { get; }
    }
}
