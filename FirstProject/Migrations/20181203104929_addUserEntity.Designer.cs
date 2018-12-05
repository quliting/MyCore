﻿// <auto-generated />
using System;
using FirstProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FirstProject.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20181203104929_addUserEntity")]
    partial class addUserEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FirstProject.Model.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Avator");

                    b.Property<string>("City");

                    b.Property<int>("CityId");

                    b.Property<string>("Company");

                    b.Property<string>("Email");

                    b.Property<byte>("Gender");

                    b.Property<string>("Name");

                    b.Property<string>("NameCard");

                    b.Property<string>("Phone");

                    b.Property<int>("ProvinceId");

                    b.Property<string>("Tel");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FirstProject.Model.BPFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("FileName");

                    b.Property<string>("FromatFilePath");

                    b.Property<string>("OriginFilePath");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("UserBPFiles");
                });

            modelBuilder.Entity("FirstProject.Model.UserProperty", b =>
                {
                    b.Property<int>("AppUserId");

                    b.Property<string>("Key");

                    b.Property<string>("Value");

                    b.Property<string>("Text");

                    b.HasKey("AppUserId", "Key", "Value");

                    b.ToTable("UserProperties");
                });

            modelBuilder.Entity("FirstProject.Model.UserTag", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Tag")
                        .HasMaxLength(100);

                    b.HasKey("UserId");

                    b.ToTable("UserTag");
                });

            modelBuilder.Entity("FirstProject.Model.UserProperty", b =>
                {
                    b.HasOne("FirstProject.Model.AppUser")
                        .WithMany("Properties")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
