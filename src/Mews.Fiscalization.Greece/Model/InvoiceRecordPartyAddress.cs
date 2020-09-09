using Mews.Fiscalization.Greece.Model.Types;
using System;

namespace Mews.Fiscalization.Greece.Model
{
    public class InvoiceRecordPartyAddress
    {
        public InvoiceRecordPartyAddress(NotEmptyString street, NotEmptyString number, NotEmptyString postalCode, NotEmptyString city)
        {
            Street = street;
            Number = number;
            PostalCode = postalCode ?? throw new ArgumentNullException(nameof(city));
            City = city ?? throw new ArgumentNullException(nameof(city));
        }

        public NotEmptyString Street { get; }

        public NotEmptyString Number { get; }

        public NotEmptyString PostalCode { get; }

        public NotEmptyString City { get; }
    }
}
