using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace Inventory.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Stock : BaseObject
    {
        public Stock(Session session)
            : base(session)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        decimal _cost;
        string _itemCode;
        string _stockDescription;
        string _itemName;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string ItemCode
        {
            get => _itemCode;
            set => SetPropertyValue(nameof(ItemCode), ref _itemCode, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string ItemName
        {
            get => _itemName;
            set => SetPropertyValue(nameof(ItemName), ref _itemName, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string StockDescription
        {
            get => _stockDescription;
            set => SetPropertyValue(nameof(StockDescription), ref _stockDescription, value);
        }

        [Association("Stock-BranchStocks")]
        public XPCollection<BranchStock> BranchStocks => GetCollection<BranchStock>(nameof(BranchStocks));

        public decimal Cost
        {
            get => _cost;
            set => SetPropertyValue(nameof(Cost), ref _cost, value);
        }
    }
}