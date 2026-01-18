using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TPStudentTracking.Entities.Entities;

namespace TPStudentTracking.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<ExamDate> ExamDates { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Language> Languages { get; set; }
    }
}
