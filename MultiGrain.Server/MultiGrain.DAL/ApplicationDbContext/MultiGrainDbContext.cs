using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MultiGrain.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiGrain.DAL.DBContext
{
    public class MultiGrainDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<ActionPlan> ActionPlans { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Diploma> Diplomas { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<EvaluationType> EvaluationTypes { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<KPI> KPIs { get; set; }
        public DbSet<Module> Modules { get; set; }
        
        public DbSet<Outcome> Outcomes { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Programm> Programms { get; set; }
        public DbSet<Rolee> Rolees { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Teaching> Teachings { get; set; }
        public DbSet<TeachingUnit> TeachingUnits { get; set; }
        public DbSet<TeachingUnitContent> TeachingUnitContents { get; set; }
        public DbSet<Types> Types { get; set; }
        public DbSet<Year> Years { get; set; }
        public DbSet<FileDocument> FileDocuments { get; set; }
        public MultiGrainDbContext(DbContextOptions<MultiGrainDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            // seed the database with dummy data

            builder.Entity<Institution>()
                .Property(p => p.LectureDuration)
                .HasColumnType("decimal(8,4)");

            builder.Entity<ActionPlan>()
              .Property(p => p.Completed)
              .HasColumnType("decimal(8,4)");

            base.OnModelCreating(builder);
        }
    }
}
