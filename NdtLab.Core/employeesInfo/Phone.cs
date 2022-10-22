using System.ComponentModel.DataAnnotations.Schema;

namespace NdtLab.Core.employeesInfo
{
    public class Phone
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public Employee User { get; set; }
    }
}
