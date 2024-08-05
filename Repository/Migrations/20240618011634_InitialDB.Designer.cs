﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Models;

#nullable disable

namespace Repository.Migrations
{
    [DbContext(typeof(Prn212AssignmentContext))]
    [Migration("20240618011634_InitialDB")]
    partial class InitialDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Repository.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int")
                        .HasColumnName("BookID");

                    b.Property<string>("Author")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Genre")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("PublicationYear")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Title")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("BookId")
                        .HasName("PK__Books__3DE0C2277150F7C5");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Repository.Models.Borrowing", b =>
                {
                    b.Property<int>("BorrowId")
                        .HasColumnType("int")
                        .HasColumnName("BorrowID");

                    b.Property<int?>("BookId")
                        .HasColumnType("int")
                        .HasColumnName("BookID");

                    b.Property<DateOnly?>("BorrowDate")
                        .HasColumnType("date");

                    b.Property<int?>("MemberId")
                        .HasColumnType("int")
                        .HasColumnName("MemberID");

                    b.Property<DateOnly?>("ReturnDate")
                        .HasColumnType("date");

                    b.HasKey("BorrowId")
                        .HasName("PK__Borrowin__4295F85F4C138B18");

                    b.HasIndex("BookId");

                    b.HasIndex("MemberId");

                    b.ToTable("Borrowing", (string)null);
                });

            modelBuilder.Entity("Repository.Models.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .HasColumnType("int")
                        .HasColumnName("MemberID");

                    b.Property<string>("ContactInformation")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("MemberId")
                        .HasName("PK__Members__0CF04B38E3296A82");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("Repository.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .HasColumnType("int")
                        .HasColumnName("ReservationID");

                    b.Property<int?>("BookId")
                        .HasColumnType("int")
                        .HasColumnName("BookID");

                    b.Property<int?>("MemberId")
                        .HasColumnType("int")
                        .HasColumnName("MemberID");

                    b.Property<DateOnly?>("ReservationDate")
                        .HasColumnType("date");

                    b.HasKey("ReservationId")
                        .HasName("PK__Reservat__B7EE5F04C8EC28DA");

                    b.HasIndex("BookId");

                    b.HasIndex("MemberId");

                    b.ToTable("Reservation", (string)null);
                });

            modelBuilder.Entity("Repository.Models.Staff", b =>
                {
                    b.Property<int>("StaffId")
                        .HasColumnType("int")
                        .HasColumnName("StaffID");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PasswordHash")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Role")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Username")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("StaffId")
                        .HasName("PK__Staff__96D4AAF789F0B10A");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("Repository.Models.Borrowing", b =>
                {
                    b.HasOne("Repository.Models.Book", "Book")
                        .WithMany("Borrowings")
                        .HasForeignKey("BookId")
                        .HasConstraintName("FK__Borrowing__BookI__3B75D760");

                    b.HasOne("Repository.Models.Member", "Member")
                        .WithMany("Borrowings")
                        .HasForeignKey("MemberId")
                        .HasConstraintName("FK__Borrowing__Membe__3C69FB99");

                    b.Navigation("Book");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Repository.Models.Reservation", b =>
                {
                    b.HasOne("Repository.Models.Book", "Book")
                        .WithMany("Reservations")
                        .HasForeignKey("BookId")
                        .HasConstraintName("FK__Reservati__BookI__3F466844");

                    b.HasOne("Repository.Models.Member", "Member")
                        .WithMany("Reservations")
                        .HasForeignKey("MemberId")
                        .HasConstraintName("FK__Reservati__Membe__403A8C7D");

                    b.Navigation("Book");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Repository.Models.Book", b =>
                {
                    b.Navigation("Borrowings");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Repository.Models.Member", b =>
                {
                    b.Navigation("Borrowings");

                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
