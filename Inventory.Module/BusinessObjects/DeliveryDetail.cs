using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace Inventory.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class DeliveryDetail : BaseObject
    {
        public DeliveryDetail(Session session)
            : base(session)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        decimal _amount;
        decimal _discount;
        decimal _subTotal;
        decimal _cost;
        BranchStock _branchStock;
        DeliveryHeader _deliveryHeader;

        [Association("DeliveryHeader-DeliveryDetails")]
        public DeliveryHeader DeliveryHeader
        {
            get => _deliveryHeader;
            set => SetPropertyValue(nameof(DeliveryHeader), ref _deliveryHeader, value);
        }

        public BranchStock BranchStock
        {
            get => _branchStock;
            set => SetPropertyValue(nameof(BranchStock), ref _branchStock, value);
        }
        
        public decimal Cost
        {
            get => _cost;
            set => SetPropertyValue(nameof(Cost), ref _cost, value);
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
        
        public decimal Amount
        {
            get => _amount;
            set => SetPropertyValue(nameof(Amount), ref _amount, value);
        }
    }
}