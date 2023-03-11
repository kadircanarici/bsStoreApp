using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book { Id = 1, Title = "Yabancı", Price = 75 },
                new Book { Id = 2, Title = "Beyaz Zambaklar Ülkesinde", Price = 125 },
                new Book { Id = 3, Title = "Suç ve Ceza", Price = 300 });
        }
    }
}
