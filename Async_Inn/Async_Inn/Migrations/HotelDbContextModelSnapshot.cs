﻿// <auto-generated />
using System;
using Async_Inn.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Async_Inn.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    partial class HotelDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Name");

                    b.Property<int?>("RoomAmenitiesAmenitiesID");

                    b.Property<int?>("RoomAmenitiesRoomID");

                    b.HasKey("ID");

                    b.HasIndex("RoomAmenitiesAmenitiesID", "RoomAmenitiesRoomID");

                    b.ToTable("Amenities");
                });

            modelBuilder.Entity("Async_Inn.Models.Hotel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("HotelName");

                    b.Property<string>("State");

                    b.Property<int>("Zip");

                    b.HasKey("ID");

                    b.ToTable("Hotel");
                });

            modelBuilder.Entity("Async_Inn.Models.HotelRoom", b =>
                {
                    b.Property<int>("HotelID");

                    b.Property<int>("RoomNumber");

                    b.Property<bool>("PetFriendly");

                    b.Property<int>("RoomID");

                    b.Property<string>("RoomName");

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

                    b.Property<string>("Name");

                    b.Property<int?>("RoomAmenityAmenitiesID");

                    b.Property<int?>("RoomAmenityRoomID");

                    b.HasKey("ID");

                    b.HasIndex("RoomAmenityAmenitiesID", "RoomAmenityRoomID");

                    b.ToTable("Rooms");
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
                    b.HasOne("Async_Inn.Models.RoomAmenity", "RoomAmenities")
                        .WithMany("Amenities")
                        .HasForeignKey("RoomAmenitiesAmenitiesID", "RoomAmenitiesRoomID");
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
