using System;

namespace Mews.Fiscalization.Greece.Dto
{
    public class Party
    {
        // TODO: Country code as enum?
        public Party(string vatNumber, string countryCode, int branchNumber = 0)
        {
            if (vatNumber == null)
            {
                throw new ArgumentNullException(nameof(vatNumber));
            }
            // TODO: Pattern check / Create an identifier with pattern and also move null check there

            // TODO: Only Greece?
            if (countryCode == null)
            {
                throw new ArgumentNullException(nameof(countryCode));
            }

            VATNumber = vatNumber;
            CountryCode = countryCode;
            BranchNumber = branchNumber;
        }

        public string VATNumber { get; }

        public string CountryCode { get; }

        public int BranchNumber { get; }
    }
}