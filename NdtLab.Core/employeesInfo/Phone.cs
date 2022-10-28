using NdtLab.core;
using System.ComponentModel.DataAnnotations.Schema;

namespace NdtLab.Core.employeesInfo
{
    public class Phone: Entity
    {
        public string Number { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public Employee User { get; set; }

        public override string ToString()
        {
            return $"{{ Номер: {Number}, IdПользователя: {UserId}}}";
        }
    }
}
