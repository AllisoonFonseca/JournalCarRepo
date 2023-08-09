using JournalCar.API.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace JournalCar.API.Data
{
    public class JournalCarDbContext : DbContext
    {
        public JournalCarDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public JournalCarDbContext() : base()
        {

        }
        public virtual DbSet<TypeDoc> TypeDoc { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<CategoryActivity> CategoryActivity { get; set; }
        public virtual DbSet<Users> User { get; set; }
        public virtual DbSet<TypeVehicle> TypeVehicle { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<Activity> Activity { get; set; }

        // Data Seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Types of vehicle
            var typesVehicle = new List<TypeVehicle>()
            {
                new TypeVehicle() { Id = Guid.NewGuid(), Name = "Moto", IconUrl = null},
                new TypeVehicle() { Id = Guid.NewGuid(), Name = "Carro", IconUrl= null}
            };
            modelBuilder.Entity<TypeVehicle>().HasData(typesVehicle);

            // Types of user document 
            var typesDocument = new List<TypeDoc>()
            {
                new TypeDoc() {Id = Guid.NewGuid(), Name = "Cédula de ciudadania", Code = "CC"},
                new TypeDoc() {Id = Guid.NewGuid(), Name = "Cedula de extranjeria", Code = "CE"}
            };
            modelBuilder.Entity<TypeDoc>().HasData(typesDocument);

            //Status of activity
            var statuses = new List<Status>()
            {
                new Status() { Id = Guid.NewGuid(), Name = "Complete"},
                new Status() { Id = Guid.NewGuid(), Name = "Pending"}
            };
            modelBuilder.Entity<Status>().HasData(statuses);

            //Category of activity
            var categories = new List<CategoryActivity>()
            {

                new CategoryActivity() { Id = Guid.NewGuid(), Name= "Maintenance", Description = "Actions that involve keep your vehicles 'healthy'."},
                new CategoryActivity() { Id = Guid.NewGuid(), Name= "Legal", Description = "Mandatory activities from your goverment laws."}
            };
            modelBuilder.Entity<CategoryActivity>().HasData(categories);
        }
    }
}
