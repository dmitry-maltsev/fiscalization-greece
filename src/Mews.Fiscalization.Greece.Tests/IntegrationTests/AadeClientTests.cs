using Mews.Fiscalization.Greece.Model;
using Mews.Fiscalization.Greece.Model.Types;
using System;
using System.Collections.Generic;
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
                        new InvoiceRecordParty(new VatIdentifier("000000000"), new NonNegativeInt(0), null, new CountryCode("GR"), null),
                        null,
                        new InvoiceRecordHeader(new LimitedString1to50("0"), new LimitedString1to50("50020"), DateTime.Now, BillType.RetailSalesReceipt, new CurrencyCode("EUR"), null),
                        new List<InvoiceRecordPaymentMethodDetails>
                        {
                            new InvoiceRecordPaymentMethodDetails(new Amount(66.53m), PaymentType.Cash)
                        },
                        new InvoiceRecordDetail(new PositiveInt(1), new Amount(53.65m), VatType.Vat6, new Amount(12.88m),
                            new InvoiceRecordIncomeClassification(ClassificationType.RetailSalesOfGoodsAndServicesPrivateClientele, ClassificationCategory.ProductSaleIncome, new Amount(53.65m))),
                        new InvoiceRecordSummary(new Amount(53.65m),new Amount( 12.88m), new Amount(66.53m),
                            new InvoiceRecordIncomeClassification(ClassificationType.RetailSalesOfGoodsAndServicesPrivateClientele, ClassificationCategory.ProductSaleIncome, new Amount(53.65m)))
                    )
                });
        }
    }
}

