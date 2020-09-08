using System;
using System.Collections.Generic;
using System.Text;

namespace Mews.Fiscalization.Greece.Model
{
    public class InvoiceRecordParty
    {
        public InvoiceRecordParty(string vatNumber, int branch, string name, string countryCode, InvoiceRecordPartyAddress invoiceRecordPartyAddress)
        {
            VatNumber = vatNumber;
            Branch = branch;
            Name = name;
            CountryCode = countryCode;
            Address = invoiceRecordPartyAddress;
        }

        public string VatNumber { get; }

        public int Branch { get; }

        public string Name { get; }

        public string CountryCode { get; }

        public InvoiceRecordPartyAddress Address { get; }
    }
}
