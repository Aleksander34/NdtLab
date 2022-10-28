using NdtLab.core;

namespace NdtLab.Core.employeesInfo
{
    public class Division : Entity
    {
        public string Name { get; set; }
        //public ICollection<Employee> Employees { get; set; }

        public override string ToString()
        {
            return $"{{ Наименование подразделения: {Name}}}";
        }
    }
}
