using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace Inventory.Module.BusinessObjects
{

    [DefaultClassOptions]
    public class SaleDetail : CustomBaseObject
    {

        public SaleDetail(Session session)
            : base(session)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }


        decimal _total;
        decimal _discount;
        decimal _subTotal;
        int _qty;
        decimal _price;
        BranchStock _branchStock;
        SaleHeader _saleHeader;

        [Association("SaleHeader-SaleDetails")]
        public SaleHeader SaleHeader
        {
            get => _saleHeader;
            set => SetPropertyValue(nameof(SaleHeader), ref _saleHeader, value);
        }

        [Association("BranchStock-SaleDetails")]
        public BranchStock BranchStock
        {
            get => _branchStock;
            set => SetPropertyValue(nameof(BranchStock), ref _branchStock, value);
        }

        public decimal Price
        {
            get => _price;
            set => SetPropertyValue(nameof(Price), ref _price, value);
        }

        public int Qty
        {
            get => _qty;
            set => SetPropertyValue(nameof(Qty), ref _qty, value);
        }

        public decimal SubTotal
        {
            get => _subTotal;
            set => SetPropertyValue(nameof(SubTotal), ref _subTotal, value);
        }

        public decimal Discount
        {
            get => _discount;
            set => SetPropertyValue(nameof(Discount), ref _discount, value);
        }

        public decimal Total
        {
            get => _total;
            set => SetPropertyValue(nameof(Total), ref _total, value);
        }
    }
}