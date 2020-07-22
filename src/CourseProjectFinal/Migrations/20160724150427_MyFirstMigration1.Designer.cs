using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CourseProjectFinal.Entities;

namespace CourseProjectFinal.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160724150427_MyFirstMigration1")]
    partial class MyFirstMigration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CourseProjectFinal.Entities.Address", b =>
                {
                    b.Property<int>("AddressId");

                    b.Property<string>("City");

                    b.Property<int>("PersonId");

                    b.Property<string>("State");

                    b.Property<string>("StreetName");

                    b.Property<string>("ZipCode");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("CourseProjectFinal.Entities.Person", b =>
                {
                    b.Property<int>("PersonId");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");
                });
        }
    }
}
