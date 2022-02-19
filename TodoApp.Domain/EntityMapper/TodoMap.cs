using TodoApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TodoApp.Domain.EntityMapper
{
    public class TodoMap : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.HasKey(c => c.Id)
                 .HasName("PK_TODO_ID");

            builder.Property(c => c.Id)
                .HasColumnName("ID")
                .HasColumnType("NVARCHAR(50)")
                .IsRequired();

            builder.Property(t => t.Title)
                .HasColumnName("TODO_TITLE")
                .HasColumnType("NVARCHAR(50)")
                .IsRequired();

            builder.Property(t => t.CreatedAt)
                .HasColumnName("CREATED_AT")
                .HasColumnType("DATETIME")
                .IsRequired();

            builder.Property(t => t.UpdatedAt)
                .HasColumnName("UPDATED_AT")
                .HasColumnType("DATETIME")
                .IsRequired();

            builder.Property(t => t.Done)
                .HasColumnName("DONE")
                .HasColumnType("BIT")
                .IsRequired();

        }
    }
}