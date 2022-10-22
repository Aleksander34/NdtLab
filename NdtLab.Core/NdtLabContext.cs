using Microsoft.EntityFrameworkCore;
using NdtLab.core.Inspections;
using NdtLab.core.Joints;
using NdtLab.core.Welders;
using NdtLab.Core.employeesInfo;
using NdtLab.Core.Joints;
using NdtLab.Core.Requests;

namespace NdtLab.Core
{
    public class NdtLabContext : DbContext
    {
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<PipeLine> PipeLines { get; set; }
        public DbSet<Piping> Pipings { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<ReferencesDoc> ReferencesDocs { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<SteelStructure> SteelStructures { get; set; }
        public DbSet<Tank> Tanks { get; set; }
        public DbSet<Welder> Welders { get; set; }
        public DbSet<WelderJoint> WelderJoints { get; set; }
        public DbSet<Difficult> Difficults { get; set; }
        public DbSet<DifficultJoint> DifficultJoints { get; set; }
        public DbSet<Joint> Joints { get; set; }
        public DbSet<Reestr> Reestrs { get; set; }
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<InspectionEmployee> InspectionEmployees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=NdtLab;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DifficultJoint>().HasKey(x => new { x.JointId, x.DifficultId });
            modelBuilder.Entity<DifficultJoint>().HasOne(x => x.Difficult).WithMany(x=>x.DifficultJoints).HasForeignKey(x=>x.DifficultId);
            modelBuilder.Entity<DifficultJoint>().HasOne(x => x.Joint).WithMany(x => x.DifficultJoints).HasForeignKey(x => x.JointId);

            modelBuilder.Entity<InspectionEmployee>().HasKey(x => new { x.EmployeeId, x.InspectionId });
            modelBuilder.Entity<InspectionEmployee>().HasOne(x => x.Inspection).WithMany(x => x.InspectionEmployees).HasForeignKey(x => x.InspectionId);
            modelBuilder.Entity<InspectionEmployee>().HasOne(x => x.Employee).WithMany(x => x.InspectionEmployees).HasForeignKey(x => x.EmployeeId);

            modelBuilder.Entity<WelderJoint>().HasKey(x => new { x.WelderId, x.JointId });
            modelBuilder.Entity<WelderJoint>().HasOne(x => x.Welder).WithMany(x => x.WelderJoints).HasForeignKey(x => x.WelderId);
            modelBuilder.Entity<WelderJoint>().HasOne(x => x.Joint).WithMany(x => x.WelderJoints).HasForeignKey(x => x.JointId);
        }
    }
}
