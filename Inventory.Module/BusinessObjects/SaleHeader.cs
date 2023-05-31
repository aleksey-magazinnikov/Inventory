using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace Inventory.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class SaleHeader : CustomBaseObject
    {

        public SaleHeader(Session session)
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
        string _invoiceNumber;
        DateTime _soldDate;
        Customer _customer;

        public Customer Customer
        {
            get => _customer;
            set => SetPropertyValue(nameof(Customer), ref _customer, value);
        }

        public DateTime SoldDate
        {
            get => _soldDate;
            set => SetPropertyValue(nameof(SoldDate), ref _soldDate, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string InvoiceNumber
        {
            get => _invoiceNumber;
            set => SetPropertyValue(nameof(InvoiceNumber), ref _invoiceNumber, value);
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

        [Association("SaleHeader-SaleDetails")]
        public XPCollection<SaleDetail> SaleDetails => GetCollection<SaleDetail>(nameof(SaleDetails));
    }
}