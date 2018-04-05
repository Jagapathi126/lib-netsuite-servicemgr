//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class ItemSupplyPlanSearchRowBasic
    {
        private static readonly Lazy<ColumnFactory> columnFactoryLoader = new Lazy<ColumnFactory>(() => new ColumnFactory());

        public override void SetColumns(string[] columnNames)
        {
            var factory = columnFactoryLoader.Value;
            for (int i = 0; i < columnNames.Length; i++)
            {
                factory.BuildColumn(this, columnNames[i]);
            }
        }

        class ColumnFactory:  ColumnFactory<ItemSupplyPlanSearchRowBasic>
        {
            protected override Dictionary<string, Action<ItemSupplyPlanSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<ItemSupplyPlanSearchRowBasic>> {
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "item", r => r.@item = new [] { new SearchColumnSelectField { customLabel = "item" } } },
                    { "lastModifiedDate", r => r.@lastModifiedDate = new [] { new SearchColumnDateField { customLabel = "lastModifiedDate" } } },
                    { "location", r => r.@location = new [] { new SearchColumnSelectField { customLabel = "location" } } },
                    { "memo", r => r.@memo = new [] { new SearchColumnStringField { customLabel = "memo" } } },
                    { "orderCreated", r => r.@orderCreated = new [] { new SearchColumnBooleanField { customLabel = "orderCreated" } } },
                    { "orderDate", r => r.@orderDate = new [] { new SearchColumnDateField { customLabel = "orderDate" } } },
                    { "orderType", r => r.@orderType = new [] { new SearchColumnSelectField { customLabel = "orderType" } } },
                    { "quantity", r => r.@quantity = new [] { new SearchColumnDoubleField { customLabel = "quantity" } } },
                    { "quantityUom", r => r.@quantityUom = new [] { new SearchColumnDoubleField { customLabel = "quantityUom" } } },
                    { "receiptDate", r => r.@receiptDate = new [] { new SearchColumnDateField { customLabel = "receiptDate" } } },
                    { "subsidiary", r => r.@subsidiary = new [] { new SearchColumnSelectField { customLabel = "subsidiary" } } },
                    { "units", r => r.@units = new [] { new SearchColumnSelectField { customLabel = "units" } } },
                };
            }
        }
    }
}