﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MultiGrain.DAL.DBContext;

namespace MultiGrain.DAL.Migrations
{
    [DbContext(typeof(MultiGrainDbContext))]
    [Migration("20191130120006_v3")]
    partial class v3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.ActionPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action");

                    b.Property<decimal>("Completed")
                        .HasColumnType("decimal(8,4)");

                    b.Property<int?>("InstitutionId");

                    b.HasKey("Id");

                    b.HasIndex("InstitutionId");

                    b.ToTable("ActionPlan");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Catalog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProgramEducationObjectives");

                    b.Property<int?>("ProgrammId");

                    b.HasKey("Id");

                    b.HasIndex("ProgrammId");

                    b.ToTable("Catalog");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Component", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("S01");

                    b.Property<decimal>("S02");

                    b.Property<decimal>("S03");

                    b.Property<decimal>("S04");

                    b.Property<decimal>("S05");

                    b.Property<decimal>("S06");

                    b.Property<decimal>("S07");

                    b.Property<decimal>("S08");

                    b.Property<decimal>("S09");

                    b.Property<decimal>("S10");

                    b.Property<decimal>("S11");

                    b.Property<decimal>("S12");

                    b.Property<decimal>("S13");

                    b.Property<decimal>("S14");

                    b.Property<decimal>("S15");

                    b.Property<decimal>("S16");

                    b.Property<int?>("TeachingUnitId");

                    b.Property<int?>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("TeachingUnitId");

                    b.HasIndex("TypeId");

                    b.ToTable("Component");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Diploma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Code");

                    b.Property<int?>("InstitutionId");

                    b.Property<decimal>("Points");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("InstitutionId");

                    b.ToTable("Diploma");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Evaluation", b =>
                {
                    b.Property<int>("EvaluationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("TeachingUnitId");

                    b.Property<int?>("TypeId");

                    b.Property<decimal>("calculator");

                    b.Property<string>("date");

                    b.Property<decimal>("duration");

                    b.Property<decimal>("notes");

                    b.Property<decimal>("openbook");

                    b.Property<decimal>("weight");

                    b.HasKey("EvaluationId");

                    b.HasIndex("TeachingUnitId");

                    b.HasIndex("TypeId");

                    b.ToTable("Evaluation");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.EvaluationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Code");

                    b.Property<int>("InCalendar");

                    b.Property<int?>("InstitutionId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("InstitutionId");

                    b.ToTable("EvaluationType");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.FileDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action");

                    b.Property<string>("ContentType");

                    b.Property<byte[]>("Data");

                    b.Property<string>("FileName");

                    b.Property<int?>("InstitutionId");

                    b.Property<string>("NameAr");

                    b.Property<string>("NameEn");

                    b.Property<string>("NameFr");

                    b.Property<string>("UploadedBy");

                    b.Property<DateTime>("UploadedOn");

                    b.HasKey("Id");

                    b.HasIndex("InstitutionId");

                    b.ToTable("FileDocument");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CatalogId");

                    b.Property<int?>("ComponentId");

                    b.Property<string>("Desc");

                    b.HasKey("Id");

                    b.HasIndex("CatalogId");

                    b.HasIndex("ComponentId");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Institution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("LectureDuration")
                        .HasColumnType("decimal(8,4)");

                    b.Property<string>("Mission");

                    b.Property<string>("Signature");

                    b.Property<string>("Title");

                    b.Property<string>("Vision");

                    b.HasKey("Id");

                    b.ToTable("Institution");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.KPI", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<int?>("OutcomeId");

                    b.Property<int?>("TeachingUnitId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("OutcomeId");

                    b.HasIndex("TeachingUnitId");

                    b.ToTable("KPI");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Module", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CatalogId");

                    b.Property<string>("IsMandatory");

                    b.Property<decimal>("RequiredCredits");

                    b.Property<int?>("TeachingUnitId");

                    b.HasKey("Id");

                    b.HasIndex("CatalogId");

                    b.HasIndex("TeachingUnitId");

                    b.ToTable("Module");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Outcome", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CatalogId");

                    b.Property<string>("Code");

                    b.Property<int?>("TeachingUnitId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("CatalogId");

                    b.HasIndex("TeachingUnitId");

                    b.ToTable("Outcome");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<int?>("InstitutionId");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Phone");

                    b.Property<string>("Remarks");

                    b.HasKey("Id");

                    b.HasIndex("InstitutionId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Programm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Admission");

                    b.Property<string>("Code");

                    b.Property<decimal>("Credits");

                    b.Property<string>("EtudesSuperieures");

                    b.Property<int?>("InstitutionId");

                    b.Property<string>("ObjectivesEtDebouches");

                    b.Property<string>("Title");

                    b.Property<string>("TitleAr");

                    b.Property<string>("TitleEn");

                    b.HasKey("Id");

                    b.HasIndex("InstitutionId");

                    b.ToTable("Programm");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Rolee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int?>("PersonId");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Rolee");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Rolee");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("InstitutionId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("InstitutionId");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Semester", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Value");

                    b.Property<int?>("YearId");

                    b.HasKey("Id");

                    b.HasIndex("YearId");

                    b.ToTable("Semester");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FromDate");

                    b.Property<int?>("RoomId");

                    b.Property<int?>("TeachingId");

                    b.Property<DateTime>("ToDate");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.HasIndex("TeachingId");

                    b.ToTable("Session");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Teaching", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GroupId");

                    b.Property<decimal>("S01");

                    b.Property<decimal>("S02");

                    b.Property<decimal>("S03");

                    b.Property<decimal>("S04");

                    b.Property<decimal>("S05");

                    b.Property<decimal>("S06");

                    b.Property<decimal>("S07");

                    b.Property<decimal>("S08");

                    b.Property<decimal>("S09");

                    b.Property<decimal>("S10");

                    b.Property<decimal>("S11");

                    b.Property<decimal>("S12");

                    b.Property<decimal>("S13");

                    b.Property<decimal>("S14");

                    b.Property<decimal>("S15");

                    b.Property<decimal>("S16");

                    b.Property<int?>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Teaching");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.TeachingUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bibliographie");

                    b.Property<string>("Code");

                    b.Property<string>("Credits");

                    b.Property<string>("Language");

                    b.Property<string>("Objective");

                    b.Property<int?>("RequiredBy");

                    b.Property<int?>("SemesterId");

                    b.Property<string>("Syllabus");

                    b.Property<string>("TeachingOutcomes");

                    b.Property<int?>("TeachingUnitId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("SemesterId");

                    b.HasIndex("TeachingUnitId");

                    b.ToTable("TeachingUnit");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.TeachingUnitContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contenu");

                    b.Property<int>("Position");

                    b.Property<int?>("TeachingUnitId");

                    b.HasKey("Id");

                    b.HasIndex("TeachingUnitId");

                    b.ToTable("TeachingUnitContent");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Types", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Coefficient");

                    b.Property<int?>("InstitutionId");

                    b.Property<string>("Name");

                    b.Property<string>("Typecode");

                    b.HasKey("Id");

                    b.HasIndex("InstitutionId");

                    b.ToTable("Type");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Year", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CatalogId");

                    b.Property<int?>("InstitutionId");

                    b.Property<int>("Value");

                    b.Property<int>("a");

                    b.HasKey("Id");

                    b.HasIndex("CatalogId");

                    b.HasIndex("InstitutionId");

                    b.ToTable("Year");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Teacher", b =>
                {
                    b.HasBaseType("MultiGrain.DAL.Entities.Rolee");

                    b.Property<int?>("DiplomaId");

                    b.Property<bool>("IsFullTime");

                    b.Property<bool>("IsProfessional");

                    b.Property<DateTime>("StartDate");

                    b.HasIndex("DiplomaId");

                    b.ToTable("Teacher");

                    b.HasDiscriminator().HasValue("Teacher");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.ActionPlan", b =>
                {
                    b.HasOne("MultiGrain.DAL.Entities.Institution", "Institution")
                        .WithMany("ActionPlans")
                        .HasForeignKey("InstitutionId");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Catalog", b =>
                {
                    b.HasOne("MultiGrain.DAL.Entities.Programm", "Programm")
                        .WithMany("Catalogs")
                        .HasForeignKey("ProgrammId");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Component", b =>
                {
                    b.HasOne("MultiGrain.DAL.Entities.TeachingUnit", "TeachingUnit")
                        .WithMany("Components")
                        .HasForeignKey("TeachingUnitId");

                    b.HasOne("MultiGrain.DAL.Entities.Types", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Diploma", b =>
                {
                    b.HasOne("MultiGrain.DAL.Entities.Institution", "Institution")
                        .WithMany("Diplomas")
                        .HasForeignKey("InstitutionId");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Evaluation", b =>
                {
                    b.HasOne("MultiGrain.DAL.Entities.TeachingUnit", "TeachingUnit")
                        .WithMany("Evaluations")
                        .HasForeignKey("TeachingUnitId");

                    b.HasOne("MultiGrain.DAL.Entities.Types", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.EvaluationType", b =>
                {
                    b.HasOne("MultiGrain.DAL.Entities.Institution", "Institution")
                        .WithMany("EvaluationTypes")
                        .HasForeignKey("InstitutionId");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.FileDocument", b =>
                {
                    b.HasOne("MultiGrain.DAL.Entities.Institution", "Institution")
                        .WithMany()
                        .HasForeignKey("InstitutionId");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Group", b =>
                {
                    b.HasOne("MultiGrain.DAL.Entities.Catalog", "Catalog")
                        .WithMany()
                        .HasForeignKey("CatalogId");

                    b.HasOne("MultiGrain.DAL.Entities.Component", "Component")
                        .WithMany("Groups")
                        .HasForeignKey("ComponentId");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.KPI", b =>
                {
                    b.HasOne("MultiGrain.DAL.Entities.Outcome", "Outcome")
                        .WithMany()
                        .HasForeignKey("OutcomeId");

                    b.HasOne("MultiGrain.DAL.Entities.TeachingUnit", "TeachingUnit")
                        .WithMany("Kpis")
                        .HasForeignKey("TeachingUnitId");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Module", b =>
                {
                    b.HasOne("MultiGrain.DAL.Entities.Catalog", "Catalog")
                        .WithMany()
                        .HasForeignKey("CatalogId");

                    b.HasOne("MultiGrain.DAL.Entities.TeachingUnit", "TeachingUnit")
                        .WithMany("Modules")
                        .HasForeignKey("TeachingUnitId");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Outcome", b =>
                {
                    b.HasOne("MultiGrain.DAL.Entities.Catalog", "Catalog")
                        .WithMany()
                        .HasForeignKey("CatalogId");

                    b.HasOne("MultiGrain.DAL.Entities.TeachingUnit", "TeachingUnit")
                        .WithMany()
                        .HasForeignKey("TeachingUnitId");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Person", b =>
                {
                    b.HasOne("MultiGrain.DAL.Entities.Institution", "Institution")
                        .WithMany("Persons")
                        .HasForeignKey("InstitutionId");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Programm", b =>
                {
                    b.HasOne("MultiGrain.DAL.Entities.Institution", "Institution")
                        .WithMany("Programms")
                        .HasForeignKey("InstitutionId");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Rolee", b =>
                {
                    b.HasOne("MultiGrain.DAL.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Room", b =>
                {
                    b.HasOne("MultiGrain.DAL.Entities.Institution", "Institution")
                        .WithMany("Rooms")
                        .HasForeignKey("InstitutionId");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Semester", b =>
                {
                    b.HasOne("MultiGrain.DAL.Entities.Year", "Year")
                        .WithMany("Semesters")
                        .HasForeignKey("YearId");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Session", b =>
                {
                    b.HasOne("MultiGrain.DAL.Entities.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId");

                    b.HasOne("MultiGrain.DAL.Entities.Teaching", "Teaching")
                        .WithMany("Sessions")
                        .HasForeignKey("TeachingId");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Teaching", b =>
                {
                    b.HasOne("MultiGrain.DAL.Entities.Group", "Group")
                        .WithMany("Teachings")
                        .HasForeignKey("GroupId");

                    b.HasOne("MultiGrain.DAL.Entities.Teacher", "Teacher")
                        .WithMany("Teachings")
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.TeachingUnit", b =>
                {
                    b.HasOne("MultiGrain.DAL.Entities.Semester", "Semester")
                        .WithMany("TeachingUnits")
                        .HasForeignKey("SemesterId");

                    b.HasOne("MultiGrain.DAL.Entities.TeachingUnit")
                        .WithMany("Prerequisite")
                        .HasForeignKey("TeachingUnitId");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.TeachingUnitContent", b =>
                {
                    b.HasOne("MultiGrain.DAL.Entities.TeachingUnit", "TeachingUnit")
                        .WithMany("TeachingUnitContents")
                        .HasForeignKey("TeachingUnitId");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Types", b =>
                {
                    b.HasOne("MultiGrain.DAL.Entities.Institution", "Institution")
                        .WithMany("Types")
                        .HasForeignKey("InstitutionId");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Year", b =>
                {
                    b.HasOne("MultiGrain.DAL.Entities.Catalog")
                        .WithMany("Years")
                        .HasForeignKey("CatalogId");

                    b.HasOne("MultiGrain.DAL.Entities.Institution", "Institution")
                        .WithMany("Years")
                        .HasForeignKey("InstitutionId");
                });

            modelBuilder.Entity("MultiGrain.DAL.Entities.Teacher", b =>
                {
                    b.HasOne("MultiGrain.DAL.Entities.Diploma", "Diploma")
                        .WithMany("Teachers")
                        .HasForeignKey("DiplomaId");
                });
#pragma warning restore 612, 618
        }
    }
}