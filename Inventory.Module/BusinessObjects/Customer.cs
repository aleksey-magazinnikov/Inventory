using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace Inventory.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Customer : CustomBaseObject
    {
        public Customer(Session session)
            : base(session)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }


        decimal _balance;
        string _email;
        string _contactNumber;
        string _address;
        string _name;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Name
        {
            get => _name;
            set => SetPropertyValue(nameof(Name), ref _name, value);
        }



        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Address
        {
            get => _address;
            set => SetPropertyValue(nameof(Address), ref _address, value);
        }



        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string ContactNumber
        {
            get => _contactNumber;
            set => SetPropertyValue(nameof(ContactNumber), ref _contactNumber, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Email
        {
            get => _email;
            set => SetPropertyValue(nameof(Email), ref _email, value);
        }


        public decimal Balance
        {
            get => _balance;
            set => SetPropertyValue(nameof(Balance), ref _balance, value);
        }
    }
}