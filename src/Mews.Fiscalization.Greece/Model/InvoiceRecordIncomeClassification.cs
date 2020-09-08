using System;
using System.Collections.Generic;
using System.Text;

namespace Mews.Fiscalization.Greece.Model
{
    public class InvoiceRecordIncomeClassification
    {
        public InvoiceRecordIncomeClassification(ClassificationType classificationType, ClassificationCategory classificationCategory, decimal amount)
        {
            ClassificationType = classificationType;
            ClassificationCategory = classificationCategory;
            Amount = amount;
        }

        public ClassificationType ClassificationType { get; set; }

        public ClassificationCategory ClassificationCategory { get; set; }

        public decimal Amount { get; set; }
    }
}
