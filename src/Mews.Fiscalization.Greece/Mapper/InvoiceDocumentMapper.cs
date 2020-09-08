using Mews.Fiscalization.Greece.Dto.Xsd;
using Mews.Fiscalization.Greece.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Mews.Fiscalization.Greece.Mapper
{
    public class InvoiceDocumentMapper
    {
        public InvoiceDocumentMapper(InvoiceDocument invoiceDocument)
        {
            InvoiceDocument = invoiceDocument;
        }

        private InvoiceDocument InvoiceDocument { get; }

        public InvoicesDoc GetInvoiceDoc()
        {
            return new InvoicesDoc
            {
                Invoices = GetInvoices()
            };
        }

        private Invoice[] GetInvoices()
        {
            var invoices = new List<Invoice>();

            foreach (var invoiceRecord in InvoiceDocument.InvoiceRecords)
            {
                invoices.Add(GetInvoice(invoiceRecord));
            }

            return invoices.ToArray();
        }

        private Invoice GetInvoice(InvoiceRecord invoiceRecord)
        {
            return new Invoice
            {
                //ToDo: add invoice mark
                InvoiceId = invoiceRecord.InvoiceIdentifier,
                InvoiceIssuer = GetInvoiceParty(invoiceRecord.Issuer),
                InvoiceCounterpart = GetInvoiceParty(invoiceRecord.Counterpart),
                PaymentMethods = GetInvoicePaymentMethods(invoiceRecord.PaymentMethods),
                InvoiceSummary = GetInvoiceSummary(invoiceRecord),
                InvoiceDetail = GetInvoiceDetail(invoiceRecord),
                InvoiceHeader = GetInvoiceHeader(invoiceRecord)
            };
        }

        private PaymentMethod[] GetInvoicePaymentMethods(IEnumerable<InvoiceRecordPaymentMethodDetails> paymentMethods)
        {
            var result = new List<PaymentMethod>();

            foreach (var paymentMethod in paymentMethods)
            {
                result.Add(new PaymentMethod
                {
                    Amount = paymentMethod.Amount,
                    PaymentMethodType = (PaymentMethodType)Enum.Parse(typeof(PaymentMethodType), paymentMethod.PaymentType.ToString(), true)
                });
            }

            return result.ToArray();
        }

        private InvoiceParty GetInvoiceParty(InvoiceRecordParty invoiceRecordParty)
        {
            if (invoiceRecordParty != null)
            {
                return new InvoiceParty
                {
                    Country = (Country)Enum.Parse(typeof(Country), invoiceRecordParty.CountryCode, true),
                    Branch = invoiceRecordParty.Branch,
                    Name = invoiceRecordParty.Name,
                    VatNumber = invoiceRecordParty.VatNumber,
                    Address = GetAddress(invoiceRecordParty.Address)
                };
            }

            return null;
        }

        private Address GetAddress(InvoiceRecordPartyAddress invoiceRecordPartyAddress)
        {
            if (invoiceRecordPartyAddress != null)
            {
                return new Address
                {
                    City = invoiceRecordPartyAddress.City,
                    Number = invoiceRecordPartyAddress.Number,
                    PostalCode = invoiceRecordPartyAddress.PostalCode,
                    Street = invoiceRecordPartyAddress.Street
                };
            }

            return null;
        }

        private InvoiceHeader GetInvoiceHeader(InvoiceRecord invoiceRecord)
        {
            return new InvoiceHeader
            {
                InvoiceType = (InvoiceType)Enum.Parse(typeof(InvoiceType), invoiceRecord.InvoiceHeader.BillType.ToString(), true),
                IssueDate = invoiceRecord.InvoiceHeader.InvoiceIssueDate,
                SerialNumber = invoiceRecord.InvoiceHeader.InvoiceSerialNumber,
                Series = invoiceRecord.InvoiceHeader.InvoiceSeries,
                Currency = (Currency)Enum.Parse(typeof(Currency), invoiceRecord.InvoiceHeader.CurrencyCode, true),
                CurrencySpecified = true
                //ToDo: add exchange rate
            };
        }

        private InvoiceDetail GetInvoiceDetail(InvoiceRecord invoiceRecord)
        {
            return new InvoiceDetail
            {
                LineNumber = invoiceRecord.InvoiceDetail.LineNumber,
                NetValue = invoiceRecord.InvoiceDetail.NetValue,
                VatAmount = invoiceRecord.InvoiceDetail.VatAmount,
                VatCategory = (VatCategory)Enum.Parse(typeof(VatCategory), invoiceRecord.InvoiceDetail.VatType.ToString(), true),
                IncomeClassification = GetIncomeClassification(invoiceRecord.InvoiceDetail.InvoiceRecordIncomeClassification)
            };
        }

        private InvoiceSummary GetInvoiceSummary(InvoiceRecord invoiceRecord)
        {
            return new InvoiceSummary
            {
                TotalNetValue = invoiceRecord.InvoiceSummary.TotalNetValue,
                TotalVatAmount = invoiceRecord.InvoiceSummary.TotalVatAmount,
                TotalGrossValue = invoiceRecord.InvoiceSummary.TotalGrossValue,
                IncomeClassification = GetIncomeClassification(invoiceRecord.InvoiceSummary.InvoiceRecordIncomeClassification)
            };
        }

        private IncomeClassification GetIncomeClassification(InvoiceRecordIncomeClassification invoiceRecordIncomeClassification)
        {
            return new IncomeClassification
            {
                Amount = invoiceRecordIncomeClassification.Amount,
                ClassificationCategory = (IncomeClassificationCategory)Enum.Parse(typeof(IncomeClassificationCategory), invoiceRecordIncomeClassification.ClassificationCategory.ToString(), true),
                ClassificationType = (IncomeClassificationType)Enum.Parse(typeof(IncomeClassificationType), invoiceRecordIncomeClassification.ClassificationType.ToString(), true)
            };
        }
    }
}
