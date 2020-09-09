namespace Mews.Fiscalization.Greece.Model.Types
{
    public class VatIdentifier : StringIdentifier
    {
        public VatIdentifier(string value)
            : base(value, Patterns.VatIdentifier)
        {
        }
    }
}
