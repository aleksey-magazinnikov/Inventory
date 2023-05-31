using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace Inventory.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Branch : CustomBaseObject
    {
        public Branch(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        string contactNo;
        string address;
        string branchName;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string BranchName
        {
            get => branchName;
            set => SetPropertyValue(nameof(BranchName), ref branchName, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Address
        {
            get => address;
            set => SetPropertyValue(nameof(Address), ref address, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string ContactNo
        {
            get => contactNo;
            set => SetPropertyValue(nameof(ContactNo), ref contactNo, value);
        }

        [Association("Branch-Departments")]
        public XPCollection<Department> Departments => GetCollection<Department>(nameof(Departments));

        [Association("Branch-Employees")]
        public XPCollection<Employee> Employees => GetCollection<Employee>(nameof(Employees));


        [Association("Branch-BranchStocks")]
        public XPCollection<BranchStock> BranchStocks => GetCollection<BranchStock>(nameof(BranchStocks));
    }
}