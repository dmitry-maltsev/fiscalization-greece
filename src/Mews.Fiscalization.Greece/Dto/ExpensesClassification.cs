using System;

namespace Mews.Fiscalization.Greece.Dto
{
    public class ExpensesClassification
    {
        public ExpensesClassification(string classificationType, string classificationCategory, decimal amount)
        {
            // TODO: Do we need a special check here for some subset of categories or we should check all of them?
            if (classificationType == null)
            {
                throw new ArgumentNullException(nameof(classificationType));
            }

            if (classificationCategory == null)
            {
                throw new ArgumentNullException(nameof(classificationCategory));
            }

            ClassificationType = classificationType;
            ClassificationCategory = classificationCategory;
            Amount = amount;
        }

        public string ClassificationType { get; }

        public string ClassificationCategory { get; }

        public decimal Amount { get; }
    }
}
