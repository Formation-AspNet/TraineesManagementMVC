namespace TraineesManagementMVC.DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using TraineesManagementMVC.Models;

    public class TraineeManagementContext : DbContext
    {
         public TraineeManagementContext()
            : base("name=TraineeManagementContext")
        {
        }

        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Trainee> Trainees { get; set; }
        
    }
}