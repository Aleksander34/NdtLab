using NdtLab.core;
using NdtLab.Core.Requests;

namespace NdtLab.Core.employeesInfo
{
    public class Division : Entity
    {
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Request> Requests { get; set; } // добавил

        public override string ToString()
        {
            return $"{{ наименование подразделения: {Name}}}";
        }
    }
}
