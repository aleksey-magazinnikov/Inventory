using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace Inventory.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Supplier : CustomBaseObject
    {
        public Supplier(Session session)
            : base(session)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        string _address;
        string _supplierName;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string SupplierName
        {
            get => _supplierName;
            set => SetPropertyValue(nameof(SupplierName), ref _supplierName, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Address
        {
            get => _address;
            set => SetPropertyValue(nameof(Address), ref _address, value);
        }
    }
}