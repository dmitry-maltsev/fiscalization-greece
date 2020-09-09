using Mews.Fiscalization.Greece.Model.Types;
using System;

namespace Mews.Fiscalization.Greece.Model
{
    public class InvoiceRecordParty
    {
        public InvoiceRecordParty(VatIdentifier vatNumber, int branch, string name, string countryCode, InvoiceRecordPartyAddress invoiceRecordPartyAddress)
        {
            if (branch < 0)
            {
                throw new ArgumentException($"Minimal value of {nameof(branch)} number is 0.");
            }
            
            VatNumber = vatNumber ?? throw new ArgumentNullException(nameof(vatNumber));
            Branch = branch;
            Name = name;
            CountryCode = countryCode;
            Address = invoiceRecordPartyAddress;
        }

        public VatIdentifier VatNumber { get; }

        public int Branch { get; }

        public string Name { get; }

        public string CountryCode { get; }

        public InvoiceRecordPartyAddress Address { get; }
    }
}
