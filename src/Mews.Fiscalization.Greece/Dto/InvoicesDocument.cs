namespace Mews.Fiscalization.Greece.Dto
{
    public class InvoicesDocument
    {
        public InvoicesDocument(InvoiceRecord invoiceRecord)
            : this(new[] { invoiceRecord })
        {
        }
        public InvoicesDocument(InvoiceRecord[] invoiceRecords)
        {
            InvoiceRecords = invoiceRecords;
        }

        public InvoiceRecord[] InvoiceRecords { get; }
    }
}
