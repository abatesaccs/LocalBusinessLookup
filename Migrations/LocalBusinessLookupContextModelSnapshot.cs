﻿// <auto-generated />
using LocalBusinessLookup.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocalBusinessLookup.Migrations
{
    [DbContext(typeof(LocalBusinessLookupContext))]
    partial class LocalBusinessLookupContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LocalBusinessLookup.Models.Business", b =>
                {
                    b.Property<int>("BusinessId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Website");

                    b.HasKey("BusinessId");

                    b.ToTable("Businesses");

                    b.HasData(
                        new
                        {
                            BusinessId = 1,
                            Address = "123 N Street St",
                            Name = "Dave's Music",
                            PhoneNumber = "7",
                            Website = "Example.com"
                        },
                        new
                        {
                            BusinessId = 2,
                            Address = "456 N Way Rd",
                            Name = "John's Sounds",
                            PhoneNumber = "867-5309",
                            Website = "Example.com"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
