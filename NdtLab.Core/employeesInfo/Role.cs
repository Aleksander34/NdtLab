using System.Text.Json.Serialization;

namespace NdtLab.Core.employeesInfo
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public ICollection<Employee> Users { get; set; }
    }
}
