using NdtLab.core;

namespace NdtLab.Core.employeesInfo
{
    /// <summary>
    /// Позиция/Должность
    /// </summary>
    public class Position : Entity
    {
        public string Name { get; set; }
        public ICollection<Employee> Users { get; set; }

        public override string ToString()
        {
            return $"{{ Должность: {Name}}}";
        }
    }
}
