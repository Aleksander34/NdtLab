namespace NdtLab.Core.employeesInfo
{
    /// <summary>
    /// Позиция/Должность
    /// </summary>
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Users { get; set; }
    }
}
