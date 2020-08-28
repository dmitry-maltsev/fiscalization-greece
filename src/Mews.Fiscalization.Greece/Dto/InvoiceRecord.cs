namespace Mews.Fiscalization.Greece.Dto
{
    public class InvoiceRecord
    {
        public InvoiceRecord(InvoiceParties invoiceParties, InvoiceHeader invoiceHeader, InvoiceRow invoiceRow)
            : this(invoiceParties, invoiceHeader, new[] { invoiceRow })
        {
        }

        public InvoiceRecord(InvoiceParties invoiceParties, InvoiceHeader invoiceHeader, InvoiceRow[] invoicesRow)
        {
            InvoiceParties = invoiceParties;
            InvoiceHeader = invoiceHeader;
            InvoicesRow = invoicesRow;
        }

        public InvoiceParties InvoiceParties { get; }

        public InvoiceHeader InvoiceHeader { get; }

        public InvoiceRow[] InvoicesRow { get; }
    }
}