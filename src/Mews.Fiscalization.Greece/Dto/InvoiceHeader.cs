using System;

namespace Mews.Fiscalization.Greece.Dto
{
    public class InvoiceHeader
    {
        public InvoiceHeader(
            string invoiceSeries,
            string invoiceSerialNumber,
            string invoiceType,
            DateTime issueDateTime)
        {
            // TODO: Do we need to add some patterns and valid values check here?
            if (invoiceSeries == null)
            {
                throw new ArgumentNullException(nameof(invoiceSeries));
            }

            if (invoiceSerialNumber == null)
            {
                throw new ArgumentNullException(nameof(invoiceSerialNumber));
            }

            //TODO: InvoiceType as enum?
            if (invoiceType == null)
            {
                throw new ArgumentNullException(nameof(invoiceType));
            }

            InvoiceSeries = invoiceSeries;
            InvoiceSerialNumber = invoiceSerialNumber;
            InvoiceType = invoiceType;

            // TODO: Should we setup it here with DateTime.Now with timezone time?
            IssueDateTime = issueDateTime;
        }

        public string InvoiceSeries { get; }

        public string InvoiceSerialNumber { get; }

        public string InvoiceType { get; }

        public DateTime IssueDateTime { get; }

        // TODO: Do we always have EUR currency code and can set this value in constructor with default EUR?

        public string CurrencyCode { get; }

        // The exchangeRate field is the currency exchange rate against euro. It should be completed only when the currency is not EUR.
        public decimal? ExchangeRate { get; } // exchangeRate xs:decimal | Can be null | Exchange rate | Min value = 0 Decimal digits = 5
    }
}
}
