//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class CustomerSearchRowBasic
    {
        // TODO: Make this Lazy and Weak referenced so that it can be garbaged collected
        private static readonly Lazy<ColumnFactory> columnFactoryLoader = new Lazy<ColumnFactory>(() => new ColumnFactory());

        public override void SetColumns(string[] columnNames)
        {
            var factory = columnFactoryLoader.Value;
            for (int i = 0; i < columnNames.Length; i++)
            {
                factory.BuildColumn(this, columnNames[i]);
            }
        }

        class ColumnFactory:  ColumnFactory<CustomerSearchRowBasic>
        {
            protected override Dictionary<string, Action<CustomerSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<CustomerSearchRowBasic>> {
                    { "accountNumber", r => r.@accountNumber = new [] { new SearchColumnStringField { customLabel = "accountNumber" } } },
                    { "address", r => r.@address = new [] { new SearchColumnStringField { customLabel = "address" } } },
                    { "address1", r => r.@address1 = new [] { new SearchColumnStringField { customLabel = "address1" } } },
                    { "address2", r => r.@address2 = new [] { new SearchColumnStringField { customLabel = "address2" } } },
                    { "address3", r => r.@address3 = new [] { new SearchColumnStringField { customLabel = "address3" } } },
                    { "addressee", r => r.@addressee = new [] { new SearchColumnStringField { customLabel = "addressee" } } },
                    { "addressInternalId", r => r.@addressInternalId = new [] { new SearchColumnStringField { customLabel = "addressInternalId" } } },
                    { "addressLabel", r => r.@addressLabel = new [] { new SearchColumnStringField { customLabel = "addressLabel" } } },
                    { "addressPhone", r => r.@addressPhone = new [] { new SearchColumnStringField { customLabel = "addressPhone" } } },
                    { "altContact", r => r.@altContact = new [] { new SearchColumnStringField { customLabel = "altContact" } } },
                    { "altEmail", r => r.@altEmail = new [] { new SearchColumnStringField { customLabel = "altEmail" } } },
                    { "altName", r => r.@altName = new [] { new SearchColumnStringField { customLabel = "altName" } } },
                    { "altPhone", r => r.@altPhone = new [] { new SearchColumnStringField { customLabel = "altPhone" } } },
                    { "assignedSite", r => r.@assignedSite = new [] { new SearchColumnSelectField { customLabel = "assignedSite" } } },
                    { "assignedSiteId", r => r.@assignedSiteId = new [] { new SearchColumnLongField { customLabel = "assignedSiteId" } } },
                    { "attention", r => r.@attention = new [] { new SearchColumnStringField { customLabel = "attention" } } },
                    { "availableOffline", r => r.@availableOffline = new [] { new SearchColumnBooleanField { customLabel = "availableOffline" } } },
                    { "balance", r => r.@balance = new [] { new SearchColumnDoubleField { customLabel = "balance" } } },
                    { "billAddress", r => r.@billAddress = new [] { new SearchColumnStringField { customLabel = "billAddress" } } },
                    { "billAddress1", r => r.@billAddress1 = new [] { new SearchColumnStringField { customLabel = "billAddress1" } } },
                    { "billAddress2", r => r.@billAddress2 = new [] { new SearchColumnStringField { customLabel = "billAddress2" } } },
                    { "billAddress3", r => r.@billAddress3 = new [] { new SearchColumnStringField { customLabel = "billAddress3" } } },
                    { "billAddressee", r => r.@billAddressee = new [] { new SearchColumnStringField { customLabel = "billAddressee" } } },
                    { "billAttention", r => r.@billAttention = new [] { new SearchColumnStringField { customLabel = "billAttention" } } },
                    { "billCity", r => r.@billCity = new [] { new SearchColumnStringField { customLabel = "billCity" } } },
                    { "billCountry", r => r.@billCountry = new [] { new SearchColumnEnumSelectField { customLabel = "billCountry" } } },
                    { "billCountryCode", r => r.@billCountryCode = new [] { new SearchColumnStringField { customLabel = "billCountryCode" } } },
                    { "billPhone", r => r.@billPhone = new [] { new SearchColumnStringField { customLabel = "billPhone" } } },
                    { "billState", r => r.@billState = new [] { new SearchColumnStringField { customLabel = "billState" } } },
                    { "billZipCode", r => r.@billZipCode = new [] { new SearchColumnStringField { customLabel = "billZipCode" } } },
                    { "buyingReason", r => r.@buyingReason = new [] { new SearchColumnStringField { customLabel = "buyingReason" } } },
                    { "buyingTimeFrame", r => r.@buyingTimeFrame = new [] { new SearchColumnStringField { customLabel = "buyingTimeFrame" } } },
                    { "category", r => r.@category = new [] { new SearchColumnSelectField { customLabel = "category" } } },
                    { "ccCustomerCode", r => r.@ccCustomerCode = new [] { new SearchColumnStringField { customLabel = "ccCustomerCode" } } },
                    { "ccDefault", r => r.@ccDefault = new [] { new SearchColumnBooleanField { customLabel = "ccDefault" } } },
                    { "ccExpDate", r => r.@ccExpDate = new [] { new SearchColumnDateField { customLabel = "ccExpDate" } } },
                    { "ccHolderName", r => r.@ccHolderName = new [] { new SearchColumnStringField { customLabel = "ccHolderName" } } },
                    { "ccInternalId", r => r.@ccInternalId = new [] { new SearchColumnStringField { customLabel = "ccInternalId" } } },
                    { "ccNumber", r => r.@ccNumber = new [] { new SearchColumnStringField { customLabel = "ccNumber" } } },
                    { "ccState", r => r.@ccState = new [] { new SearchColumnSelectField { customLabel = "ccState" } } },
                    { "ccStateFrom", r => r.@ccStateFrom = new [] { new SearchColumnDateField { customLabel = "ccStateFrom" } } },
                    { "ccType", r => r.@ccType = new [] { new SearchColumnSelectField { customLabel = "ccType" } } },
                    { "city", r => r.@city = new [] { new SearchColumnStringField { customLabel = "city" } } },
                    { "comments", r => r.@comments = new [] { new SearchColumnStringField { customLabel = "comments" } } },
                    { "companyName", r => r.@companyName = new [] { new SearchColumnStringField { customLabel = "companyName" } } },
                    { "consolBalance", r => r.@consolBalance = new [] { new SearchColumnDoubleField { customLabel = "consolBalance" } } },
                    { "consolDaysOverdue", r => r.@consolDaysOverdue = new [] { new SearchColumnLongField { customLabel = "consolDaysOverdue" } } },
                    { "consolDepositBalance", r => r.@consolDepositBalance = new [] { new SearchColumnDoubleField { customLabel = "consolDepositBalance" } } },
                    { "consolOverdueBalance", r => r.@consolOverdueBalance = new [] { new SearchColumnDoubleField { customLabel = "consolOverdueBalance" } } },
                    { "consolUnbilledOrders", r => r.@consolUnbilledOrders = new [] { new SearchColumnDoubleField { customLabel = "consolUnbilledOrders" } } },
                    { "contact", r => r.@contact = new [] { new SearchColumnStringField { customLabel = "contact" } } },
                    { "contribution", r => r.@contribution = new [] { new SearchColumnDoubleField { customLabel = "contribution" } } },
                    { "contributionPrimary", r => r.@contributionPrimary = new [] { new SearchColumnDoubleField { customLabel = "contributionPrimary" } } },
                    { "conversionDate", r => r.@conversionDate = new [] { new SearchColumnDateField { customLabel = "conversionDate" } } },
                    { "country", r => r.@country = new [] { new SearchColumnEnumSelectField { customLabel = "country" } } },
                    { "countryCode", r => r.@countryCode = new [] { new SearchColumnStringField { customLabel = "countryCode" } } },
                    { "creditHold", r => r.@creditHold = new [] { new SearchColumnEnumSelectField { customLabel = "creditHold" } } },
                    { "creditHoldOverride", r => r.@creditHoldOverride = new [] { new SearchColumnBooleanField { customLabel = "creditHoldOverride" } } },
                    { "creditLimit", r => r.@creditLimit = new [] { new SearchColumnDoubleField { customLabel = "creditLimit" } } },
                    { "currency", r => r.@currency = new [] { new SearchColumnSelectField { customLabel = "currency" } } },
                    { "dateClosed", r => r.@dateClosed = new [] { new SearchColumnDateField { customLabel = "dateClosed" } } },
                    { "dateCreated", r => r.@dateCreated = new [] { new SearchColumnDateField { customLabel = "dateCreated" } } },
                    { "daysOverdue", r => r.@daysOverdue = new [] { new SearchColumnLongField { customLabel = "daysOverdue" } } },
                    { "defaultOrderPriority", r => r.@defaultOrderPriority = new [] { new SearchColumnDoubleField { customLabel = "defaultOrderPriority" } } },
                    { "defaultTaxReg", r => r.@defaultTaxReg = new [] { new SearchColumnStringField { customLabel = "defaultTaxReg" } } },
                    { "depositBalance", r => r.@depositBalance = new [] { new SearchColumnDoubleField { customLabel = "depositBalance" } } },
                    { "drAccount", r => r.@drAccount = new [] { new SearchColumnStringField { customLabel = "drAccount" } } },
                    { "email", r => r.@email = new [] { new SearchColumnStringField { customLabel = "email" } } },
                    { "emailPreference", r => r.@emailPreference = new [] { new SearchColumnEnumSelectField { customLabel = "emailPreference" } } },
                    { "emailTransactions", r => r.@emailTransactions = new [] { new SearchColumnBooleanField { customLabel = "emailTransactions" } } },
                    { "endDate", r => r.@endDate = new [] { new SearchColumnDateField { customLabel = "endDate" } } },
                    { "entityId", r => r.@entityId = new [] { new SearchColumnStringField { customLabel = "entityId" } } },
                    { "entityNumber", r => r.@entityNumber = new [] { new SearchColumnLongField { customLabel = "entityNumber" } } },
                    { "entityStatus", r => r.@entityStatus = new [] { new SearchColumnSelectField { customLabel = "entityStatus" } } },
                    { "estimatedBudget", r => r.@estimatedBudget = new [] { new SearchColumnDoubleField { customLabel = "estimatedBudget" } } },
                    { "explicitConversion", r => r.@explicitConversion = new [] { new SearchColumnBooleanField { customLabel = "explicitConversion" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "fax", r => r.@fax = new [] { new SearchColumnStringField { customLabel = "fax" } } },
                    { "faxTransactions", r => r.@faxTransactions = new [] { new SearchColumnBooleanField { customLabel = "faxTransactions" } } },
                    { "firstName", r => r.@firstName = new [] { new SearchColumnStringField { customLabel = "firstName" } } },
                    { "firstOrderDate", r => r.@firstOrderDate = new [] { new SearchColumnDateField { customLabel = "firstOrderDate" } } },
                    { "firstSaleDate", r => r.@firstSaleDate = new [] { new SearchColumnDateField { customLabel = "firstSaleDate" } } },
                    { "fxAccount", r => r.@fxAccount = new [] { new SearchColumnStringField { customLabel = "fxAccount" } } },
                    { "fxBalance", r => r.@fxBalance = new [] { new SearchColumnDoubleField { customLabel = "fxBalance" } } },
                    { "fxConsolBalance", r => r.@fxConsolBalance = new [] { new SearchColumnDoubleField { customLabel = "fxConsolBalance" } } },
                    { "fxConsolUnbilledOrders", r => r.@fxConsolUnbilledOrders = new [] { new SearchColumnDoubleField { customLabel = "fxConsolUnbilledOrders" } } },
                    { "fxUnbilledOrders", r => r.@fxUnbilledOrders = new [] { new SearchColumnDoubleField { customLabel = "fxUnbilledOrders" } } },
                    { "giveAccess", r => r.@giveAccess = new [] { new SearchColumnBooleanField { customLabel = "giveAccess" } } },
                    { "globalSubscriptionStatus", r => r.@globalSubscriptionStatus = new [] { new SearchColumnEnumSelectField { customLabel = "globalSubscriptionStatus" } } },
                    { "groupPricingLevel", r => r.@groupPricingLevel = new [] { new SearchColumnStringField { customLabel = "groupPricingLevel" } } },
                    { "hasDuplicates", r => r.@hasDuplicates = new [] { new SearchColumnBooleanField { customLabel = "hasDuplicates" } } },
                    { "homePhone", r => r.@homePhone = new [] { new SearchColumnStringField { customLabel = "homePhone" } } },
                    { "image", r => r.@image = new [] { new SearchColumnSelectField { customLabel = "image" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "isBudgetApproved", r => r.@isBudgetApproved = new [] { new SearchColumnBooleanField { customLabel = "isBudgetApproved" } } },
                    { "isDefaultBilling", r => r.@isDefaultBilling = new [] { new SearchColumnBooleanField { customLabel = "isDefaultBilling" } } },
                    { "isDefaultShipping", r => r.@isDefaultShipping = new [] { new SearchColumnBooleanField { customLabel = "isDefaultShipping" } } },
                    { "isInactive", r => r.@isInactive = new [] { new SearchColumnBooleanField { customLabel = "isInactive" } } },
                    { "isPerson", r => r.@isPerson = new [] { new SearchColumnBooleanField { customLabel = "isPerson" } } },
                    { "isShipAddress", r => r.@isShipAddress = new [] { new SearchColumnBooleanField { customLabel = "isShipAddress" } } },
                    { "itemPricingLevel", r => r.@itemPricingLevel = new [] { new SearchColumnStringField { customLabel = "itemPricingLevel" } } },
                    { "itemPricingUnitPrice", r => r.@itemPricingUnitPrice = new [] { new SearchColumnDoubleField { customLabel = "itemPricingUnitPrice" } } },
                    { "jobEndDate", r => r.@jobEndDate = new [] { new SearchColumnDateField { customLabel = "jobEndDate" } } },
                    { "jobProjectedEnd", r => r.@jobProjectedEnd = new [] { new SearchColumnDateField { customLabel = "jobProjectedEnd" } } },
                    { "jobStartDate", r => r.@jobStartDate = new [] { new SearchColumnDateField { customLabel = "jobStartDate" } } },
                    { "jobType", r => r.@jobType = new [] { new SearchColumnSelectField { customLabel = "jobType" } } },
                    { "language", r => r.@language = new [] { new SearchColumnEnumSelectField { customLabel = "language" } } },
                    { "lastModifiedDate", r => r.@lastModifiedDate = new [] { new SearchColumnDateField { customLabel = "lastModifiedDate" } } },
                    { "lastName", r => r.@lastName = new [] { new SearchColumnStringField { customLabel = "lastName" } } },
                    { "lastOrderDate", r => r.@lastOrderDate = new [] { new SearchColumnDateField { customLabel = "lastOrderDate" } } },
                    { "lastSaleDate", r => r.@lastSaleDate = new [] { new SearchColumnDateField { customLabel = "lastSaleDate" } } },
                    { "leadDate", r => r.@leadDate = new [] { new SearchColumnDateField { customLabel = "leadDate" } } },
                    { "leadSource", r => r.@leadSource = new [] { new SearchColumnSelectField { customLabel = "leadSource" } } },
                    { "level", r => r.@level = new [] { new SearchColumnEnumSelectField { customLabel = "level" } } },
                    { "manualCreditHold", r => r.@manualCreditHold = new [] { new SearchColumnBooleanField { customLabel = "manualCreditHold" } } },
                    { "middleName", r => r.@middleName = new [] { new SearchColumnStringField { customLabel = "middleName" } } },
                    { "mobilePhone", r => r.@mobilePhone = new [] { new SearchColumnStringField { customLabel = "mobilePhone" } } },
                    { "monthlyClosing", r => r.@monthlyClosing = new [] { new SearchColumnEnumSelectField { customLabel = "monthlyClosing" } } },
                    { "onCreditHold", r => r.@onCreditHold = new [] { new SearchColumnBooleanField { customLabel = "onCreditHold" } } },
                    { "overdueBalance", r => r.@overdueBalance = new [] { new SearchColumnDoubleField { customLabel = "overdueBalance" } } },
                    { "parent", r => r.@parent = new [] { new SearchColumnSelectField { customLabel = "parent" } } },
                    { "partner", r => r.@partner = new [] { new SearchColumnSelectField { customLabel = "partner" } } },
                    { "partnerContribution", r => r.@partnerContribution = new [] { new SearchColumnDoubleField { customLabel = "partnerContribution" } } },
                    { "partnerRole", r => r.@partnerRole = new [] { new SearchColumnStringField { customLabel = "partnerRole" } } },
                    { "partnerTeamMember", r => r.@partnerTeamMember = new [] { new SearchColumnSelectField { customLabel = "partnerTeamMember" } } },
                    { "pec", r => r.@pec = new [] { new SearchColumnStringField { customLabel = "pec" } } },
                    { "permission", r => r.@permission = new [] { new SearchColumnEnumSelectField { customLabel = "permission" } } },
                    { "phone", r => r.@phone = new [] { new SearchColumnStringField { customLabel = "phone" } } },
                    { "phoneticName", r => r.@phoneticName = new [] { new SearchColumnStringField { customLabel = "phoneticName" } } },
                    { "prefCCProcessor", r => r.@prefCCProcessor = new [] { new SearchColumnSelectField { customLabel = "prefCCProcessor" } } },
                    { "priceLevel", r => r.@priceLevel = new [] { new SearchColumnSelectField { customLabel = "priceLevel" } } },
                    { "pricingGroup", r => r.@pricingGroup = new [] { new SearchColumnStringField { customLabel = "pricingGroup" } } },
                    { "pricingItem", r => r.@pricingItem = new [] { new SearchColumnStringField { customLabel = "pricingItem" } } },
                    { "printTransactions", r => r.@printTransactions = new [] { new SearchColumnBooleanField { customLabel = "printTransactions" } } },
                    { "prospectDate", r => r.@prospectDate = new [] { new SearchColumnDateField { customLabel = "prospectDate" } } },
                    { "receivablesAccount", r => r.@receivablesAccount = new [] { new SearchColumnStringField { customLabel = "receivablesAccount" } } },
                    { "reminderDays", r => r.@reminderDays = new [] { new SearchColumnLongField { customLabel = "reminderDays" } } },
                    { "resaleNumber", r => r.@resaleNumber = new [] { new SearchColumnStringField { customLabel = "resaleNumber" } } },
                    { "role", r => r.@role = new [] { new SearchColumnStringField { customLabel = "role" } } },
                    { "salesReadiness", r => r.@salesReadiness = new [] { new SearchColumnStringField { customLabel = "salesReadiness" } } },
                    { "salesRep", r => r.@salesRep = new [] { new SearchColumnSelectField { customLabel = "salesRep" } } },
                    { "salesTeamMember", r => r.@salesTeamMember = new [] { new SearchColumnSelectField { customLabel = "salesTeamMember" } } },
                    { "salesTeamRole", r => r.@salesTeamRole = new [] { new SearchColumnSelectField { customLabel = "salesTeamRole" } } },
                    { "salutation", r => r.@salutation = new [] { new SearchColumnStringField { customLabel = "salutation" } } },
                    { "shipAddress", r => r.@shipAddress = new [] { new SearchColumnStringField { customLabel = "shipAddress" } } },
                    { "shipAddress1", r => r.@shipAddress1 = new [] { new SearchColumnStringField { customLabel = "shipAddress1" } } },
                    { "shipAddress2", r => r.@shipAddress2 = new [] { new SearchColumnStringField { customLabel = "shipAddress2" } } },
                    { "shipAddress3", r => r.@shipAddress3 = new [] { new SearchColumnStringField { customLabel = "shipAddress3" } } },
                    { "shipAddressee", r => r.@shipAddressee = new [] { new SearchColumnStringField { customLabel = "shipAddressee" } } },
                    { "shipAttention", r => r.@shipAttention = new [] { new SearchColumnStringField { customLabel = "shipAttention" } } },
                    { "shipCity", r => r.@shipCity = new [] { new SearchColumnStringField { customLabel = "shipCity" } } },
                    { "shipComplete", r => r.@shipComplete = new [] { new SearchColumnBooleanField { customLabel = "shipComplete" } } },
                    { "shipCountry", r => r.@shipCountry = new [] { new SearchColumnEnumSelectField { customLabel = "shipCountry" } } },
                    { "shipCountryCode", r => r.@shipCountryCode = new [] { new SearchColumnStringField { customLabel = "shipCountryCode" } } },
                    { "shipPhone", r => r.@shipPhone = new [] { new SearchColumnStringField { customLabel = "shipPhone" } } },
                    { "shippingItem", r => r.@shippingItem = new [] { new SearchColumnSelectField { customLabel = "shippingItem" } } },
                    { "shipState", r => r.@shipState = new [] { new SearchColumnStringField { customLabel = "shipState" } } },
                    { "shipZip", r => r.@shipZip = new [] { new SearchColumnStringField { customLabel = "shipZip" } } },
                    { "sourceSite", r => r.@sourceSite = new [] { new SearchColumnSelectField { customLabel = "sourceSite" } } },
                    { "sourceSiteId", r => r.@sourceSiteId = new [] { new SearchColumnLongField { customLabel = "sourceSiteId" } } },
                    { "stage", r => r.@stage = new [] { new SearchColumnEnumSelectField { customLabel = "stage" } } },
                    { "startDate", r => r.@startDate = new [] { new SearchColumnDateField { customLabel = "startDate" } } },
                    { "state", r => r.@state = new [] { new SearchColumnStringField { customLabel = "state" } } },
                    { "subscription", r => r.@subscription = new [] { new SearchColumnSelectField { customLabel = "subscription" } } },
                    { "subscriptionDate", r => r.@subscriptionDate = new [] { new SearchColumnDateField { customLabel = "subscriptionDate" } } },
                    { "subscriptionStatus", r => r.@subscriptionStatus = new [] { new SearchColumnBooleanField { customLabel = "subscriptionStatus" } } },
                    { "subsidiary", r => r.@subsidiary = new [] { new SearchColumnSelectField { customLabel = "subsidiary" } } },
                    { "taxable", r => r.@taxable = new [] { new SearchColumnBooleanField { customLabel = "taxable" } } },
                    { "taxItem", r => r.@taxItem = new [] { new SearchColumnSelectField { customLabel = "taxItem" } } },
                    { "terms", r => r.@terms = new [] { new SearchColumnSelectField { customLabel = "terms" } } },
                    { "territory", r => r.@territory = new [] { new SearchColumnSelectField { customLabel = "territory" } } },
                    { "title", r => r.@title = new [] { new SearchColumnStringField { customLabel = "title" } } },
                    { "unbilledOrders", r => r.@unbilledOrders = new [] { new SearchColumnDoubleField { customLabel = "unbilledOrders" } } },
                    { "url", r => r.@url = new [] { new SearchColumnStringField { customLabel = "url" } } },
                    { "vatRegNumber", r => r.@vatRegNumber = new [] { new SearchColumnStringField { customLabel = "vatRegNumber" } } },
                    { "webLead", r => r.@webLead = new [] { new SearchColumnBooleanField { customLabel = "webLead" } } },
                    { "zipCode", r => r.@zipCode = new [] { new SearchColumnStringField { customLabel = "zipCode" } } },
                };
            }
        }
    }
}