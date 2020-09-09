using System;
using System.Collections.Generic;

namespace Mews.Fiscalization.Greece.Model
{
    public class InvoiceRecord
    {
		public InvoiceRecord(string invoiceIdentifier, long? invoiceRegistrationNumber, long? cancelledByInvoiceRegistrationNumber, InvoiceRecordParty issuer, InvoiceRecordParty counterpart, 
			InvoiceRecordHeader invoiceHeader, IEnumerable<InvoiceRecordPaymentMethodDetails> paymentMethods, InvoiceRecordDetail invoiceDetail, InvoiceRecordSummary invoiceSummary)
		{
			InvoiceIdentifier = invoiceIdentifier;
			InvoiceRegistrationNumber = invoiceRegistrationNumber;
			CancelledByInvoiceRegistrationNumber = cancelledByInvoiceRegistrationNumber;
			Issuer = issuer;
			Counterpart = counterpart;
			InvoiceHeader = invoiceHeader ?? throw new ArgumentNullException(nameof(invoiceHeader));
			PaymentMethods = paymentMethods;
			InvoiceDetail = invoiceDetail ?? throw new ArgumentNullException(nameof(invoiceDetail));
			InvoiceSummary = invoiceSummary ?? throw new ArgumentNullException(nameof(invoiceSummary));
		}

		public string InvoiceIdentifier { get; }

		public long? InvoiceRegistrationNumber { get; }

		public long? CancelledByInvoiceRegistrationNumber { get; }

		public InvoiceRecordParty Issuer { get; }

		public InvoiceRecordParty Counterpart { get; }

		public InvoiceRecordHeader InvoiceHeader { get; set; }

		public IEnumerable<InvoiceRecordPaymentMethodDetails> PaymentMethods { get; set; }

		public InvoiceRecordDetail InvoiceDetail { get; }

		public InvoiceRecordSummary InvoiceSummary { get; }
	}
}
