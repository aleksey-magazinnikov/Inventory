using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace Inventory.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class BranchStock : CustomBaseObject
    {
        public BranchStock(Session session)
            : base(session)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();

        }

        decimal _cost;
        decimal _price;
        int _quantity;
        Stock _stock;
        Branch _branch;

        [Association("Branch-BranchStocks")]
        public Branch Branch
        {
            get => _branch;
            set => SetPropertyValue(nameof(Branch), ref _branch, value);
        }

        [Association("Stock-BranchStocks")]
        public Stock Stock
        {
            get => _stock;
            set => SetPropertyValue(nameof(Stock), ref _stock, value);
        }

        public int Quantity
        {
            get => _quantity;
            set => SetPropertyValue(nameof(Quantity), ref _quantity, value);
        }

        public decimal Cost
        {
            get => _cost;
            set => SetPropertyValue(nameof(Cost), ref _cost, value);
        }

        public decimal Price
        {
            get => _price;
            set => SetPropertyValue(nameof(Price), ref _price, value);
        }

        [Association("BranchStock-SaleDetails")]
        public XPCollection<SaleDetail> SaleDetails => GetCollection<SaleDetail>(nameof(SaleDetails));
    }
}