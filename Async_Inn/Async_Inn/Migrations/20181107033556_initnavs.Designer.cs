﻿// <auto-generated />
using System;
using Async_Inn.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Async_Inn.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20181107033556_initnavs")]
    partial class initnavs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Async_Inn.Models.Amenity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<int?>("RoomAmenityAmenitiesID");

                    b.Property<int?>("RoomAmenityRoomID");

                    b.HasKey("ID");

                    b.HasIndex("RoomAmenityAmenitiesID", "RoomAmenityRoomID");

                    b.ToTable("Amenities");

                    b.HasData(
                        new { ID = 1, Name = "Coffee Maker" },
                        new { ID = 2, Name = "Tea Maker" },
                        new { ID = 3, Name = "Craft Cocktail Mini Bar" },
                        new { ID = 4, Name = "Free WiFi" },
                        new { ID = 5, Name = "Fog Free Mirror" }
                    );
                });

            modelBuilder.Entity("Async_Inn.Models.Hotel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("HotelName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<int>("Zip");

                    b.HasKey("ID");

                    b.ToTable("Hotel");

                    b.HasData(
                        new { ID = 1, Address = "2901 3rd Ave #300", City = "Seattle", HotelName = "Async Inn", State = "WA", Zip = 98121 },
                        new { ID = 2, Address = "123 Elm Street", City = "Nightmare", HotelName = "Hotel Babylon", State = "WA", Zip = 98121 },
                        new { ID = 3, Address = "1000 Shenanigans Lane", City = "Seattle", HotelName = "Polymorphism Manor", State = "WA", Zip = 98101 },
                        new { ID = 4, Address = "2000000 Trust Fund St", City = "Medina", HotelName = "Inheritance Inn", State = "WA", Zip = 98039 },
                        new { ID = 5, Address = "1 Shadow of the Space Needle", City = "Seattle", HotelName = "Object Instance Class Inn", State = "WA", Zip = 98101 }
                    );
                });

            modelBuilder.Entity("Async_Inn.Models.HotelRoom", b =>
                {
                    b.Property<int>("HotelID");

                    b.Property<int>("RoomNumber");

                    b.Property<bool>("PetFriendly");

                    b.Property<int>("RoomID");

                    b.Property<string>("RoomName")
                        .IsRequired();

                    b.Property<decimal>("RoomRate");

                    b.HasKey("HotelID", "RoomNumber");

                    b.HasIndex("RoomID");

                    b.ToTable("HotelRooms");
                });

            modelBuilder.Entity("Async_Inn.Models.Room", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Layout");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("RoomAmenityAmenitiesID");

                    b.Property<int?>("RoomAmenityRoomID");

                    b.HasKey("ID");

                    b.HasIndex("RoomAmenityAmenitiesID", "RoomAmenityRoomID");

                    b.ToTable("Rooms");

                    b.HasData(
                        new { ID = 1, Layout = 2, Name = "The Million Dollar View" },
                        new { ID = 2, Layout = 1, Name = "Freddie's Dreamspace" },
                        new { ID = 3, Layout = 1, Name = "Mesopotamia Suite" },
                        new { ID = 4, Layout = 0, Name = "The Four OOPs" },
                        new { ID = 5, Layout = 2, Name = "All Property Behaviors" },
                        new { ID = 6, Layout = 1, Name = "Seattle Sklyline" }
                    );
                });

            modelBuilder.Entity("Async_Inn.Models.RoomAmenity", b =>
                {
                    b.Property<int>("AmenitiesID");

                    b.Property<int>("RoomID");

                    b.HasKey("AmenitiesID", "RoomID");

                    b.ToTable("RoomAmenities");
                });

            modelBuilder.Entity("Async_Inn.Models.Amenity", b =>
                {
                    b.HasOne("Async_Inn.Models.RoomAmenity", "RoomAmenity")
                        .WithMany("Amenities")
                        .HasForeignKey("RoomAmenityAmenitiesID", "RoomAmenityRoomID");
                });

            modelBuilder.Entity("Async_Inn.Models.HotelRoom", b =>
                {
                    b.HasOne("Async_Inn.Models.Hotel", "Hotel")
                        .WithMany("HotelRooms")
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Async_Inn.Models.Room", "Room")
                        .WithMany("HotelRoom")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Async_Inn.Models.Room", b =>
                {
                    b.HasOne("Async_Inn.Models.RoomAmenity", "RoomAmenity")
                        .WithMany("Room")
                        .HasForeignKey("RoomAmenityAmenitiesID", "RoomAmenityRoomID");
                });
#pragma warning restore 612, 618
        }
    }
}
