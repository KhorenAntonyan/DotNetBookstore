using DotNetBookstore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBookstore.Infrastructure.Data.Config
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(b => b.BookId).IsRequired();
            builder.Property(b => b.Title).IsRequired().HasMaxLength(150);
            builder.Property(b => b.Description).IsRequired().HasMaxLength(1000);
            builder.Property(b => b.PictureUrl).IsRequired().HasMaxLength(350);
            builder.Property(b => b.EditionLanguage).IsRequired().HasMaxLength(50);
            builder.Property(b => b.NumberOfPages).HasColumnType("int");
            builder.Property(b => b.YearOfIssue).HasColumnType("int");
            builder.Property(b => b.Price).HasColumnType("decimal(18,2)");
            builder.HasOne(a => a.Author).WithMany()
                .HasForeignKey(b => b.AuthorId);
        }
    }
}
