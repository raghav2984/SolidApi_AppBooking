using src.Entities;
using Microsoft.EntityFrameworkCore;
using src.Controller.Dtos;

namespace src.Database
{
    public class Appt_EF_DataContext :DbContext
    {
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        public Appt_EF_DataContext(DbContextOptions<Appt_EF_DataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=admin;Host=localhost;Port=5432;Database=Appt_Db;Pooling=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.HasDefaultSchema("Appt_Db");
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            //Can be implemented if ONLY 1 doctor needs to be in the system rather than creating each time
            //modelBuilder.Entity<Doctor>().HasData(new Doctor { DoctorId = Guid.NewGuid(), DoctorName = "ARTC" });
        }
    }

    public static class DbExtension
    {
        public static IServiceCollection AddApptDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Appt_EF_DataContext>(options =>
            {
                // options.UseNpgsql(configuration.GetConnectionString("Appt_Db"));
                options.UseNpgsql(configuration.GetConnectionString("Appt_Db"));

            });
            return services;
        }
    }
}
