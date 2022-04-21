﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookTrackingApp.Migrations
{
    [DbContext(typeof(Context_Book))]
    [Migration("20220421214338_initialcreate")]
    partial class initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("BookTrackingApp.Models.Book", b =>
                {
                    b.Property<string>("ISBN")
                        .HasColumnType("TEXT");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("ISBN");

                    b.HasIndex("CategoryID");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("BookTrackingApp.Models.Category", b =>
                {
                    b.Property<string>("NameToken")
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryTypeType")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("TypeID")
                        .HasColumnType("TEXT");

                    b.HasKey("NameToken");

                    b.HasIndex("CategoryTypeType");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("BookTrackingApp.Models.CategoryType", b =>
                {
                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Type");

                    b.ToTable("CategoryType");
                });

            modelBuilder.Entity("BookTrackingApp.Models.Book", b =>
                {
                    b.HasOne("BookTrackingApp.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BookTrackingApp.Models.Category", b =>
                {
                    b.HasOne("BookTrackingApp.Models.CategoryType", "CategoryType")
                        .WithMany()
                        .HasForeignKey("CategoryTypeType");

                    b.Navigation("CategoryType");
                });
#pragma warning restore 612, 618
        }
    }
}