using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_StudentSystem.Data
{
    public class StudentSystemContext : DbContext
    { 
        public StudentSystemContext()
        {
        }

        public StudentSystemContext(DbContextOptions<StudentSystemContext> options)
            : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>(build =>
            {
                build.HasKey(ft => new { ft.StudentId, ft.CourseId });

                build.HasOne(ft => ft.Student)
                    .WithMany(t => t.CourseEnrollments)
                    .HasForeignKey(ft => ft.StudentId);

                build.HasOne(ft => ft.Course)
                .WithMany(t => t.StudentsEnrolled)
                .HasForeignKey(ft => ft.CourseId);
                


            });
            modelBuilder.Entity<Student>(build =>
            {
                build.Property(c => c.Name)
                .IsUnicode(true);
                build.Property(c => c.PhoneNumber)
                .HasMaxLength(10)
                .IsFixedLength();
            });

            modelBuilder.Entity<Course>(build =>
            {
                build.Property(c => c.Name)
                .IsUnicode(true);
                build.Property(c => c.Description)
                .IsUnicode(true);
            });

            modelBuilder.Entity<Resource>(build =>
            {
                build.Property(c => c.Name)
                .IsUnicode(true);
                build.Property(c => c.Url)
                .IsUnicode(false);
            });
            modelBuilder.Entity<Homework>(build =>
            {
                build.Property(c => c.Content)
                .IsUnicode(false);
            });

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-EMH9F7E;Database=UniDB;Integrated Security=true");
            }
        }

        public virtual DbSet<Student> Students { get;set; }
        public virtual DbSet<Homework> HomeworkSubmissions { get;set; }
        public virtual DbSet <Course> Courses { get;set; }
        public virtual DbSet <Resource> Resources { get;set; }
        public virtual DbSet<StudentCourse> StudentCourses { get;set; }

      
    }
}
