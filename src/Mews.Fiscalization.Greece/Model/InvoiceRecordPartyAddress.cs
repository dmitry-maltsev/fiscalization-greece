using Mews.Fiscalization.Greece.Extensions;
using System;

namespace Mews.Fiscalization.Greece.Model
{
    public class InvoiceRecordPartyAddress
    {
        public InvoiceRecordPartyAddress(string street, string number, string postalCode, string city)
        {
            if (postalCode.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(postalCode));
            }

            if (city.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(city));
            }

            Street = street;
            Number = number;
            PostalCode = postalCode;
            City = city;
        }

        public string Street { get; }

        public string Number { get; }

        public string PostalCode { get; }

        public string City { get; }
    }
}
