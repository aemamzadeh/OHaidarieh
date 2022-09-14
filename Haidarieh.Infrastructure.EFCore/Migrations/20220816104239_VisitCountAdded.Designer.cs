﻿// <auto-generated />
using System;
using Haidarieh.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Haidarieh.Infrastructure.EFCore.Migrations
{
    [DbContext(typeof(HContext))]
    [Migration("20220816104239_VisitCountAdded")]
    partial class VisitCountAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Haidarieh.Domain.CeremonyAgg.Ceremony", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("BannerFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CeremonyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageAlt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsLive")
                        .HasColumnType("bit");

                    b.Property<string>("Keywords")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetaDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Ceremony");
                });

            modelBuilder.Entity("Haidarieh.Domain.CeremonyGuestAgg.CeremonyGuest", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("CeremonyId")
                        .HasColumnType("bigint");

                    b.Property<long>("GuestId")
                        .HasColumnType("bigint");

                    b.Property<int>("Satisfication")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CeremonyId");

                    b.HasIndex("GuestId");

                    b.ToTable("Tbl_CeremonyGuest");
                });

            modelBuilder.Entity("Haidarieh.Domain.GuestAgg.Guest", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Coordinator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("GuestType")
                        .HasColumnType("bigint");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageAlt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Tel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Guest");
                });

            modelBuilder.Entity("Haidarieh.Domain.MemberAgg.Member", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Member");
                });

            modelBuilder.Entity("Haidarieh.Domain.MultimediaAgg.Multimedia", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("CeremonyId")
                        .HasColumnType("bigint");

                    b.Property<string>("FileAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileAlt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("VisitCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CeremonyId");

                    b.ToTable("Tbl_Multimedia");
                });

            modelBuilder.Entity("Haidarieh.Domain.SponsorAgg.Sponsor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageAlt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Tel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Sponsor");
                });

            modelBuilder.Entity("Haidarieh.Domain.CeremonyAgg.Ceremony", b =>
                {
                    b.OwnsMany("Haidarieh.Domain.CeremonyAgg.CeremonyOperation", "CeremonyOperations", b1 =>
                        {
                            b1.Property<long>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("bigint")
                                .UseIdentityColumn();

                            b1.Property<long>("CeremonyId")
                                .HasColumnType("bigint");

                            b1.Property<string>("Description")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("Operation")
                                .HasColumnType("int");

                            b1.Property<DateTime>("OperationDate")
                                .HasColumnType("datetime2");

                            b1.Property<long>("OperatorId")
                                .HasColumnType("bigint");

                            b1.HasKey("Id");

                            b1.HasIndex("CeremonyId");

                            b1.ToTable("Tbl_CeremonyOperation");

                            b1.WithOwner("Ceremony")
                                .HasForeignKey("CeremonyId");

                            b1.Navigation("Ceremony");
                        });

                    b.Navigation("CeremonyOperations");
                });

            modelBuilder.Entity("Haidarieh.Domain.CeremonyGuestAgg.CeremonyGuest", b =>
                {
                    b.HasOne("Haidarieh.Domain.CeremonyAgg.Ceremony", "Ceremony")
                        .WithMany("CeremonyGuests")
                        .HasForeignKey("CeremonyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Haidarieh.Domain.GuestAgg.Guest", "Guest")
                        .WithMany("CeremonyGuests")
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ceremony");

                    b.Navigation("Guest");
                });

            modelBuilder.Entity("Haidarieh.Domain.MultimediaAgg.Multimedia", b =>
                {
                    b.HasOne("Haidarieh.Domain.CeremonyAgg.Ceremony", "Ceremony")
                        .WithMany("Multimedias")
                        .HasForeignKey("CeremonyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ceremony");
                });

            modelBuilder.Entity("Haidarieh.Domain.CeremonyAgg.Ceremony", b =>
                {
                    b.Navigation("CeremonyGuests");

                    b.Navigation("Multimedias");
                });

            modelBuilder.Entity("Haidarieh.Domain.GuestAgg.Guest", b =>
                {
                    b.Navigation("CeremonyGuests");
                });
#pragma warning restore 612, 618
        }
    }
}
