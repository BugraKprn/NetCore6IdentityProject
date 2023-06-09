﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<Student, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-L6R5EQR;database=NetCore6Identity;integrated security=true");
        }

        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<StudentAccount> StudentAccounts { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<LessonSubject> LessonSubjects { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ClassroomLesson>()
                .HasKey(x => new { x.LessonId, x.ClassroomId });
            base.OnModelCreating(builder);
        }
    }
}
