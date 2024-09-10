using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Test.Models
{
    public partial class MyCourseDBContext : DbContext
    {
        public MyCourseDBContext()
        {
        }

        public MyCourseDBContext(DbContextOptions<MyCourseDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<Lesson> Lessons { get; set; } = null!;
        public virtual DbSet<LessonDetail> LessonDetails { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<StudentCourse> StudentCourses { get; set; } = null!;
        public virtual DbSet<Teacher> Teachers { get; set; } = null!;
        public virtual DbSet<TeacherCourse> TeacherCourses { get; set; } = null!;
        public virtual DbSet<TeachersLesson> TeachersLessons { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MyCourseDB;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasIndex(e => e.Email, "UQ__Courses__A9D10534004EC70A")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("date");
            });

            modelBuilder.Entity<Lesson>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LessonName).HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("date");
            });

            modelBuilder.Entity<LessonDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateDate).HasColumnType("date");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.LessonDetails)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__LessonDet__Stude__47DBAE45");

                entity.HasOne(d => d.TeacherLesson)
                    .WithMany(p => p.LessonDetails)
                    .HasForeignKey(d => d.TeacherLessonId)
                    .HasConstraintName("FK__LessonDet__Teach__46E78A0C");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Surname).HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("date");
            });

            modelBuilder.Entity<StudentCourse>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateDate).HasColumnType("date");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.StudentCourses)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__StudentCo__Cours__3C69FB99");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentCourses)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__StudentCo__Stude__3B75D760");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Surname).HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("date");
            });

            modelBuilder.Entity<TeacherCourse>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateDate).HasColumnType("date");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.TeacherCourses)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__TeacherCo__Cours__36B12243");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TeacherCourses)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__TeacherCo__Teach__35BCFE0A");
            });

            modelBuilder.Entity<TeachersLesson>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateDate).HasColumnType("date");

                entity.HasOne(d => d.Lesson)
                    .WithMany(p => p.TeachersLessons)
                    .HasForeignKey(d => d.LessonId)
                    .HasConstraintName("FK__TeachersL__Lesso__4222D4EF");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TeachersLessons)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__TeachersL__Teach__412EB0B6");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
