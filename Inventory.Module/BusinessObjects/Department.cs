using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace Inventory.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Department : CustomBaseObject
    {
        public Department(Session session)
            : base(session)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        Branch _branch;
        string _departmentName;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string DepartmentName
        {
            get => _departmentName;
            set => SetPropertyValue(nameof(DepartmentName), ref _departmentName, value);
        }

        [Association("Branch-Departments")]
        public Branch Branch
        {
            get => _branch;
            set => SetPropertyValue(nameof(Branch), ref _branch, value);
        }
    }
}