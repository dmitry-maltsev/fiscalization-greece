using Mews.Fiscalization.Greece.Model.Types;
using System;

namespace Mews.Fiscalization.Greece.Model
{
    public class InvoiceRecordHeader
    {
        public InvoiceRecordHeader(LimitedString1to50 invoiceSeries, LimitedString1to50 invoiceSerialNumber, DateTime invoiceIssueDate, bool vatPaymentSuspension, decimal? exchangeRate,
            long? correlatedInvoices, bool selfPricing, DateTime? dispatchDate, DateTime? dispatchTime, string vehicleNumber)
        {
            InvoiceSeries = invoiceSeries ?? throw new ArgumentNullException(nameof(invoiceSeries));
            InvoiceSerialNumber = invoiceSerialNumber ?? throw new ArgumentNullException(nameof(invoiceSerialNumber));
            InvoiceIssueDate = invoiceIssueDate;
            VatPaymentSuspension = vatPaymentSuspension;
            ExchangeRate = exchangeRate;
            CorrelatedInvoices = correlatedInvoices;
            SelfPricing = selfPricing;
            DispatchDate = dispatchDate;
            DispatchTime = dispatchTime;
            VehicleNumber = vehicleNumber;
        }

        public LimitedString1to50 InvoiceSeries { get; }

        public LimitedString1to50 InvoiceSerialNumber { get; }

        public DateTime InvoiceIssueDate { get; }

        public bool VatPaymentSuspension { get; }

        public decimal? ExchangeRate { get; }

        public long? CorrelatedInvoices { get; }

        public bool SelfPricing { get; }

        public DateTime? DispatchDate { get; }

        public DateTime? DispatchTime { get; }

        public string VehicleNumber { get; }
    }
}
