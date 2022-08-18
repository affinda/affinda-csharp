// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class InvoiceData
    {
        internal static InvoiceData DeserializeInvoiceData(JsonElement element)
        {
            Optional<IReadOnlyList<InvoiceDataTablesItem>> tables = default;
            Optional<DateAnnotation> invoiceDate = default;
            Optional<DateAnnotation> invoiceOrderDate = default;
            Optional<DateAnnotation> paymentDateDue = default;
            Optional<InvoiceDataPaymentAmountBase> paymentAmountBase = default;
            Optional<InvoiceDataPaymentAmountTax> paymentAmountTax = default;
            Optional<InvoiceDataPaymentAmountTotal> paymentAmountTotal = default;
            Optional<InvoiceDataPaymentAmountPaid> paymentAmountPaid = default;
            Optional<InvoiceDataPaymentAmountDue> paymentAmountDue = default;
            Optional<InvoiceDataInvoiceNumber> invoiceNumber = default;
            Optional<InvoiceDataInvoicePurchaseOrderNumber> invoicePurchaseOrderNumber = default;
            Optional<InvoiceDataSupplierBusinessNumber> supplierBusinessNumber = default;
            Optional<InvoiceDataCustomerNumber> customerNumber = default;
            Optional<InvoiceDataCustomerBusinessNumber> customerBusinessNumber = default;
            Optional<InvoiceDataPaymentReference> paymentReference = default;
            Optional<InvoiceDataBankAccountNumber> bankAccountNumber = default;
            Optional<InvoiceDataSupplierVAT> supplierVAT = default;
            Optional<InvoiceDataCustomerVAT> customerVAT = default;
            Optional<InvoiceDataBpayBillerCode> bpayBillerCode = default;
            Optional<InvoiceDataBpayReference> bpayReference = default;
            Optional<InvoiceDataBankSortCode> bankSortCode = default;
            Optional<InvoiceDataBankIban> bankIBAN = default;
            Optional<InvoiceDataBankSwift> bankSwift = default;
            Optional<InvoiceDataBankBSB> bankBSB = default;
            Optional<InvoiceDataCustomerContactName> customerContactName = default;
            Optional<InvoiceDataCustomerCompanyName> customerCompanyName = default;
            Optional<InvoiceDataSupplierCompanyName> supplierCompanyName = default;
            Optional<LocationAnnotation> customerBillingAddress = default;
            Optional<LocationAnnotation> customerDeliveryAddress = default;
            Optional<LocationAnnotation> supplierAddress = default;
            Optional<InvoiceDataCustomerPhoneNumber> customerPhoneNumber = default;
            Optional<InvoiceDataSupplierPhoneNumber> supplierPhoneNumber = default;
            Optional<InvoiceDataSupplierFax> supplierFax = default;
            Optional<InvoiceDataCustomerEmail> customerEmail = default;
            Optional<InvoiceDataSupplierEmail> supplierEmail = default;
            Optional<InvoiceDataSupplierWebsite> supplierWebsite = default;
            Optional<EnumAnnotationSerializer> currencyCode = default;
            Optional<IReadOnlyDictionary<string, object>> customFields = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tables"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<InvoiceDataTablesItem> array = new List<InvoiceDataTablesItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InvoiceDataTablesItem.DeserializeInvoiceDataTablesItem(item));
                    }
                    tables = array;
                    continue;
                }
                if (property.NameEquals("invoiceDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    invoiceDate = DateAnnotation.DeserializeDateAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("invoiceOrderDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    invoiceOrderDate = DateAnnotation.DeserializeDateAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("paymentDateDue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    paymentDateDue = DateAnnotation.DeserializeDateAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("paymentAmountBase"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    paymentAmountBase = InvoiceDataPaymentAmountBase.DeserializeInvoiceDataPaymentAmountBase(property.Value);
                    continue;
                }
                if (property.NameEquals("paymentAmountTax"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    paymentAmountTax = InvoiceDataPaymentAmountTax.DeserializeInvoiceDataPaymentAmountTax(property.Value);
                    continue;
                }
                if (property.NameEquals("paymentAmountTotal"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    paymentAmountTotal = InvoiceDataPaymentAmountTotal.DeserializeInvoiceDataPaymentAmountTotal(property.Value);
                    continue;
                }
                if (property.NameEquals("paymentAmountPaid"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    paymentAmountPaid = InvoiceDataPaymentAmountPaid.DeserializeInvoiceDataPaymentAmountPaid(property.Value);
                    continue;
                }
                if (property.NameEquals("paymentAmountDue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    paymentAmountDue = InvoiceDataPaymentAmountDue.DeserializeInvoiceDataPaymentAmountDue(property.Value);
                    continue;
                }
                if (property.NameEquals("invoiceNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    invoiceNumber = InvoiceDataInvoiceNumber.DeserializeInvoiceDataInvoiceNumber(property.Value);
                    continue;
                }
                if (property.NameEquals("invoicePurchaseOrderNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    invoicePurchaseOrderNumber = InvoiceDataInvoicePurchaseOrderNumber.DeserializeInvoiceDataInvoicePurchaseOrderNumber(property.Value);
                    continue;
                }
                if (property.NameEquals("supplierBusinessNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    supplierBusinessNumber = InvoiceDataSupplierBusinessNumber.DeserializeInvoiceDataSupplierBusinessNumber(property.Value);
                    continue;
                }
                if (property.NameEquals("customerNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    customerNumber = InvoiceDataCustomerNumber.DeserializeInvoiceDataCustomerNumber(property.Value);
                    continue;
                }
                if (property.NameEquals("customerBusinessNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    customerBusinessNumber = InvoiceDataCustomerBusinessNumber.DeserializeInvoiceDataCustomerBusinessNumber(property.Value);
                    continue;
                }
                if (property.NameEquals("paymentReference"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    paymentReference = InvoiceDataPaymentReference.DeserializeInvoiceDataPaymentReference(property.Value);
                    continue;
                }
                if (property.NameEquals("bankAccountNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    bankAccountNumber = InvoiceDataBankAccountNumber.DeserializeInvoiceDataBankAccountNumber(property.Value);
                    continue;
                }
                if (property.NameEquals("supplierVAT"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    supplierVAT = InvoiceDataSupplierVAT.DeserializeInvoiceDataSupplierVAT(property.Value);
                    continue;
                }
                if (property.NameEquals("customerVAT"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    customerVAT = InvoiceDataCustomerVAT.DeserializeInvoiceDataCustomerVAT(property.Value);
                    continue;
                }
                if (property.NameEquals("bpayBillerCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    bpayBillerCode = InvoiceDataBpayBillerCode.DeserializeInvoiceDataBpayBillerCode(property.Value);
                    continue;
                }
                if (property.NameEquals("bpayReference"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    bpayReference = InvoiceDataBpayReference.DeserializeInvoiceDataBpayReference(property.Value);
                    continue;
                }
                if (property.NameEquals("bankSortCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    bankSortCode = InvoiceDataBankSortCode.DeserializeInvoiceDataBankSortCode(property.Value);
                    continue;
                }
                if (property.NameEquals("bankIBAN"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    bankIBAN = InvoiceDataBankIban.DeserializeInvoiceDataBankIban(property.Value);
                    continue;
                }
                if (property.NameEquals("bankSwift"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    bankSwift = InvoiceDataBankSwift.DeserializeInvoiceDataBankSwift(property.Value);
                    continue;
                }
                if (property.NameEquals("bankBSB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    bankBSB = InvoiceDataBankBSB.DeserializeInvoiceDataBankBSB(property.Value);
                    continue;
                }
                if (property.NameEquals("customerContactName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    customerContactName = InvoiceDataCustomerContactName.DeserializeInvoiceDataCustomerContactName(property.Value);
                    continue;
                }
                if (property.NameEquals("customerCompanyName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    customerCompanyName = InvoiceDataCustomerCompanyName.DeserializeInvoiceDataCustomerCompanyName(property.Value);
                    continue;
                }
                if (property.NameEquals("supplierCompanyName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    supplierCompanyName = InvoiceDataSupplierCompanyName.DeserializeInvoiceDataSupplierCompanyName(property.Value);
                    continue;
                }
                if (property.NameEquals("customerBillingAddress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    customerBillingAddress = LocationAnnotation.DeserializeLocationAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("customerDeliveryAddress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    customerDeliveryAddress = LocationAnnotation.DeserializeLocationAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("supplierAddress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    supplierAddress = LocationAnnotation.DeserializeLocationAnnotation(property.Value);
                    continue;
                }
                if (property.NameEquals("customerPhoneNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    customerPhoneNumber = InvoiceDataCustomerPhoneNumber.DeserializeInvoiceDataCustomerPhoneNumber(property.Value);
                    continue;
                }
                if (property.NameEquals("supplierPhoneNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    supplierPhoneNumber = InvoiceDataSupplierPhoneNumber.DeserializeInvoiceDataSupplierPhoneNumber(property.Value);
                    continue;
                }
                if (property.NameEquals("supplierFax"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    supplierFax = InvoiceDataSupplierFax.DeserializeInvoiceDataSupplierFax(property.Value);
                    continue;
                }
                if (property.NameEquals("customerEmail"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    customerEmail = InvoiceDataCustomerEmail.DeserializeInvoiceDataCustomerEmail(property.Value);
                    continue;
                }
                if (property.NameEquals("supplierEmail"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    supplierEmail = InvoiceDataSupplierEmail.DeserializeInvoiceDataSupplierEmail(property.Value);
                    continue;
                }
                if (property.NameEquals("supplierWebsite"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    supplierWebsite = InvoiceDataSupplierWebsite.DeserializeInvoiceDataSupplierWebsite(property.Value);
                    continue;
                }
                if (property.NameEquals("currencyCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    currencyCode = EnumAnnotationSerializer.DeserializeEnumAnnotationSerializer(property.Value);
                    continue;
                }
                if (property.NameEquals("customFields"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetObject());
                    }
                    customFields = dictionary;
                    continue;
                }
            }
            return new InvoiceData(Optional.ToList(tables), invoiceDate.Value, invoiceOrderDate.Value, paymentDateDue.Value, paymentAmountBase.Value, paymentAmountTax.Value, paymentAmountTotal.Value, paymentAmountPaid.Value, paymentAmountDue.Value, invoiceNumber.Value, invoicePurchaseOrderNumber.Value, supplierBusinessNumber.Value, customerNumber.Value, customerBusinessNumber.Value, paymentReference.Value, bankAccountNumber.Value, supplierVAT.Value, customerVAT.Value, bpayBillerCode.Value, bpayReference.Value, bankSortCode.Value, bankIBAN.Value, bankSwift.Value, bankBSB.Value, customerContactName.Value, customerCompanyName.Value, supplierCompanyName.Value, customerBillingAddress.Value, customerDeliveryAddress.Value, supplierAddress.Value, customerPhoneNumber.Value, supplierPhoneNumber.Value, supplierFax.Value, customerEmail.Value, supplierEmail.Value, supplierWebsite.Value, currencyCode.Value, Optional.ToDictionary(customFields));
        }
    }
}
