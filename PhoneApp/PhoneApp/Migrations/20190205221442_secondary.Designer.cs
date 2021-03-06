﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PhoneApp.Models;
using System;

namespace PhoneApp.Migrations
{
    [DbContext(typeof(PhoneAppContext))]
    [Migration("20190205221442_secondary")]
    partial class secondary
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PhoneApp.Models.Phone", b =>
                {
                    b.Property<int>("iD")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("LaunchDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<decimal>("batteryLife");

                    b.Property<string>("phoneCPU")
                        .IsRequired();

                    b.Property<string>("phoneDisplay");

                    b.Property<string>("phoneImage");

                    b.Property<string>("phoneOS")
                        .IsRequired();

                    b.Property<decimal>("phoneRating");

                    b.Property<decimal>("phoneWeight");

                    b.HasKey("iD");

                    b.ToTable("Phone");
                });
#pragma warning restore 612, 618
        }
    }
}
