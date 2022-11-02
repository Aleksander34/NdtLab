using NdtLab.core;
using System.Text.Json.Serialization;

namespace NdtLab.Core.employeesInfo
{
    public class Role : Entity
    {
        public string Name { get; set; }
        public ICollection<Employee> Users { get; set; }

        public override string ToString()
        {
            return $"{{ Роль: {Name}}}";
        }
    }
}
