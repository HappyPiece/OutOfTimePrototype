using Microsoft.EntityFrameworkCore;
using OutOfTimePrototype.DAL.Models;

namespace OutOfTimePrototype.DAL
{
    public class OutOfTimeDbContext : DbContext
    {
        public DbSet<ClassType> ClassTypes { get; set; }

        public DbSet<TimeSlot> TimeSlots { get; set; }

        public DbSet<Class> Classes { get; set; }

        public DbSet<Educator> Educators { get; set; }

        public DbSet<LectureHall> LectureHalls { get; set; }

        public DbSet<CampusBuilding> CampusBuildings { get; set; }

        public DbSet<Cluster> Clusters { get; set; }

        public OutOfTimeDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassType>().HasKey(x => x.Name);
            modelBuilder.Entity<TimeSlot>().HasKey(x => x.Number);
            modelBuilder.Entity<Cluster>().HasKey(x => x.Number);

            modelBuilder.Entity<LectureHall>().HasOne(x => x.HostBuilding).WithMany(x => x.LectureHalls);

            //modelBuilder.Entity<Class>().HasOne(x => new { x.TimeSlot, x.Cluster });

            // Data seeding

            modelBuilder.Entity<TimeSlot>().HasData(
                new TimeSlot { Number = 1, StartTime = DateTime.ParseExact("08:45", "HH:mm", null).ToUniversalTime(), EndTime = DateTime.ParseExact("10:20", "HH:mm", null).ToUniversalTime() },
                new TimeSlot { Number = 2, StartTime = DateTime.ParseExact("10:35", "HH:mm", null).ToUniversalTime(), EndTime = DateTime.ParseExact("12:10", "HH:mm", null).ToUniversalTime() },
                new TimeSlot { Number = 3, StartTime = DateTime.ParseExact("12:25", "HH:mm", null).ToUniversalTime(), EndTime = DateTime.ParseExact("14:00", "HH:mm", null).ToUniversalTime() },
                new TimeSlot { Number = 4, StartTime = DateTime.ParseExact("14:45", "HH:mm", null).ToUniversalTime(), EndTime = DateTime.ParseExact("16:20", "HH:mm", null).ToUniversalTime() },
                new TimeSlot { Number = 5, StartTime = DateTime.ParseExact("16:35", "HH:mm", null).ToUniversalTime(), EndTime = DateTime.ParseExact("18:10", "HH:mm", null).ToUniversalTime() },
                new TimeSlot { Number = 6, StartTime = DateTime.ParseExact("18:25", "HH:mm", null).ToUniversalTime(), EndTime = DateTime.ParseExact("20:00", "HH:mm", null).ToUniversalTime() },
                new TimeSlot { Number = 7, StartTime = DateTime.ParseExact("20:15", "HH:mm", null).ToUniversalTime(), EndTime = DateTime.ParseExact("21:50", "HH:mm", null).ToUniversalTime() }
            );

            modelBuilder.Entity<ClassType>().HasData(
                new ClassType { Name = "Practice"},
                new ClassType { Name = "Lecture" },
                new ClassType { Name = "Seminar" },
                new ClassType { Name = "Laboratory" },
                new ClassType { Name = "Exam" }
            );
        }
    }
}
