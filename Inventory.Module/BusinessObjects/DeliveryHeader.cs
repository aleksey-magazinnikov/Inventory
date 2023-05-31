using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace Inventory.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class DeliveryHeader : CustomBaseObject
    {
        public DeliveryHeader(Session session)
            : base(session)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }


        string _invoiceNumber;
        decimal _deliveryTotal;
        decimal _discount;
        decimal _subTotal;
        Supplier _supplier;
        DateTime _dateDelivered;

        public DateTime DateDelivered
        {
            get => _dateDelivered;
            set => SetPropertyValue(nameof(DateDelivered), ref _dateDelivered, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string InvoiceNumber
        {
            get => _invoiceNumber;
            set => SetPropertyValue(nameof(InvoiceNumber), ref _invoiceNumber, value);
        }

        public Supplier Supplier
        {
            get => _supplier;
            set => SetPropertyValue(nameof(Supplier), ref _supplier, value);
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

        public decimal DeliveryTotal
        {
            get => _deliveryTotal;
            set => SetPropertyValue(nameof(DeliveryTotal), ref _deliveryTotal, value);
        }

        [Association("DeliveryHeader-DeliveryDetails")]
        public XPCollection<DeliveryDetail> DeliveryDetails => GetCollection<DeliveryDetail>(nameof(DeliveryDetails));
    }
}