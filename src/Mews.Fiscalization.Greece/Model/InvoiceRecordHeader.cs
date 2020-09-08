using System;
using System.Collections.Generic;
using System.Text;

namespace Mews.Fiscalization.Greece.Model
{
    public class InvoiceRecordHeader
    {
        public InvoiceRecordHeader(string invoiceSeries, string invoiceSerialNumber, DateTime invoiceIssueDate, BillType billType, string currencyCode, decimal? exchangeRate)
        {
            InvoiceSeries = invoiceSeries;
            InvoiceSerialNumber = invoiceSerialNumber;
            InvoiceIssueDate = invoiceIssueDate;
            BillType = billType;
            CurrencyCode = currencyCode;
            ExchangeRate = exchangeRate;
        }

        public string InvoiceSeries { get; }

        public string InvoiceSerialNumber { get; }

        public DateTime InvoiceIssueDate { get; }

        public BillType BillType { get; }

        public string CurrencyCode { get; }

        public decimal? ExchangeRate { get; }
    }
}
