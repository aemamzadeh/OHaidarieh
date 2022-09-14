using Haidarieh.Domain.CalendarAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haidarieh.Infrastructure.EFCore.Mapping
{
    public class CalendarMapping : IEntityTypeConfiguration<Calendar>
    {
        public void Configure(EntityTypeBuilder<Calendar> builder)
        {
            builder.ToTable("Tbl_Calendar");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title);
            builder.Property(x => x.Description);

            builder.HasMany(x => x.Ceremonies).WithOne(x => x.Calendar).HasForeignKey(x => x.CalendarId);
        }
    }
}

