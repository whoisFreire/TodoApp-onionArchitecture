// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoApp.Infrastructure.Context;

namespace TodoApp.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.14");

            modelBuilder.Entity("TodoApp.Domain.Models.Todo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR(50)")
                        .HasColumnName("ID");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("DATETIME")
                        .HasColumnName("CREATED_AT");

                    b.Property<bool>("Done")
                        .HasColumnType("BIT")
                        .HasColumnName("DONE");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)")
                        .HasColumnName("TODO_TITLE");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("DATETIME")
                        .HasColumnName("UPDATED_AT");

                    b.HasKey("Id")
                        .HasName("PK_TODO_ID");

                    b.ToTable("Todo");
                });
#pragma warning restore 612, 618
        }
    }
}
