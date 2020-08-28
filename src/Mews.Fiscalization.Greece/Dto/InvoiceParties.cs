using System;

namespace Mews.Fiscalization.Greece.Dto
{
    public class InvoiceParties
    {
        public InvoiceParties(Party issuer, Party counterpart)
        {
            if (issuer == null)
            {
                throw new ArgumentNullException(nameof(issuer));
            }

            Issuer = issuer;
            Counterpart = counterpart;
        }

        // TODO: Do we need counterpart at all?
        public InvoiceParties(Party issuer)
            : this(issuer, null)
        {
        }

        public Party Issuer { get; }

        public Party Counterpart { get; }
    }
}