namespace Mews.Fiscalization.Greece.Dto
{
    public class InvoiceRow
    {
        public InvoiceRow(decimal netValue, decimal vatAmount, IncomeClassification incomeClassification)
            : this(netValue, vatAmount, vatCategory: 1, incomeClassifications: new[] { incomeClassification }, expensesClassifications: null)
        {
        }
        public InvoiceRow(decimal netValue, decimal vatAmount, int vatCategory, IncomeClassification incomeClassification)
            : this(netValue, vatAmount, vatCategory, incomeClassifications: new[] { incomeClassification }, expensesClassifications: null)
        {
        }

        public InvoiceRow(decimal netValue, decimal vatAmount, IncomeClassification[] incomeClassifications)
            : this(netValue, vatAmount, vatCategory: 1, incomeClassifications: incomeClassifications, expensesClassifications: null)
        {
        }

        public InvoiceRow(decimal netValue, decimal vatAmount, int vatCategory, IncomeClassification[] incomeClassifications)
            : this(netValue, vatAmount, vatCategory, incomeClassifications: incomeClassifications, expensesClassifications: null)
        {
        }

        public InvoiceRow(decimal netValue, decimal vatAmount, IncomeClassification[] incomeClassifications, ExpensesClassification[] expensesClassifications)
            : this(netValue, vatAmount, vatCategory: 1, incomeClassifications: incomeClassifications, expensesClassifications: null)
        {
        }

        // TODO: Vat category as enum of valid values or it should be passed as int?
        // Simplified constructor with net and vat values only
        public InvoiceRow(decimal netValue, decimal vatAmount, int vatCategory, IncomeClassification[] incomeClassifications, ExpensesClassification[] expensesClassifications)
        {
            NetValue = netValue;
            VatCategory = vatCategory;
            VatAmount = vatAmount;
            IncomeClassifications = incomeClassifications;
            ExpensesClassifications = expensesClassifications;
        }

        // TODO: Taxes and fees category as enum of valid values? Do we need all values or only some of them? Can we set default values? Do we need all these taxes?
        public InvoiceRow(
            decimal netValue,
            decimal vatAmount,
            int vatCategory,
            decimal withheldAmount,
            int withheldCategory,
            decimal stampDutyAmount,
            int stampDutyCategory,
            decimal feesAmount,
            int feesCategory,
            decimal otherTaxesAmount,
            int otherTaxesCategory,
            IncomeClassification[] incomeClassifications,
            ExpensesClassification[] expensesClassifications)
        {
            NetValue = netValue;
            VatAmount = vatAmount;
            VatCategory = vatCategory;
            WithheldAmount = withheldAmount;
            WithheldCategory = withheldCategory;
            StampDutyAmount = stampDutyAmount;
            StampDutyCategory = stampDutyCategory;
            FeesAmount = feesAmount;
            FeesCategory = feesCategory;
            OtherTaxesAmount = otherTaxesAmount;
            OtherTaxesCategory = otherTaxesCategory;
            IncomeClassifications = incomeClassifications;
            ExpensesClassifications = expensesClassifications;
        }

        public decimal NetValue { get; }

        public decimal VatAmount { get; }

        public int VatCategory { get; }

        public decimal WithheldAmount { get; }

        public int WithheldCategory { get; }

        public decimal StampDutyAmount { get; }

        public int StampDutyCategory { get; }

        public decimal FeesAmount { get; }

        public int FeesCategory { get; }

        public decimal OtherTaxesAmount { get; }

        public int OtherTaxesCategory { get; }

        public IncomeClassification[] IncomeClassifications { get; }

        public ExpensesClassification[] ExpensesClassifications { get; }
    }
}
