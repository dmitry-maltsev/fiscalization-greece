using Mews.Fiscalization.Greece.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mews.Fiscalization.Greece.Tests.IntegrationTests
{
    public class AadeClientTests
    {
        private static readonly string UserId = "";
        private static readonly string SubscriptionKey = "";

        [Fact (Skip = "not ready yet")]
        public async void ValidInvoiceDocumentSendInvoicesWorks()
        {
            var client = new AadeClient(UserId, SubscriptionKey, AadeEnvironment.Sandbox);

            var response = await client.SendInvoicesAsync(GetValidTestInvoiceDocument());
        }

        private InvoiceDocument GetValidTestInvoiceDocument()
        {
            return new InvoiceDocument(
                new List<InvoiceRecord>()
                {
                    new InvoiceRecord(null, null, null,
                        new InvoiceRecordParty("000000000", 0, null, "GR", null),
                        null,
                        new InvoiceRecordHeader("0", "50020", DateTime.Now, BillType.RetailSalesReceipt, "EUR", null),
                        new List<InvoiceRecordPaymentMethodDetails>
                        {
                            new InvoiceRecordPaymentMethodDetails(66.53m, PaymentType.Cash)
                        },
                        new InvoiceRecordDetail(1, 53.65m, VatType.Vat6, 12.88m,
                            new InvoiceRecordIncomeClassification(ClassificationType.RetailSalesOfGoodsAndServicesPrivateClientele, ClassificationCategory.ProductSaleIncome, 53.65m)),
                        new InvoiceRecordSummary(53.65m, 12.88m, 66.53m,
                            new InvoiceRecordIncomeClassification(ClassificationType.RetailSalesOfGoodsAndServicesPrivateClientele, ClassificationCategory.ProductSaleIncome, 53.65m))
                    )
                });
        }
    }
}

