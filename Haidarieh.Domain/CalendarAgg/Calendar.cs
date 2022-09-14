using _0_Framework.Domain;
using Haidarieh.Domain.CeremonyAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haidarieh.Domain.CalendarAgg
{
    public class Calendar: EntityBase
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public List<Ceremony> Ceremonies { get; private set; }
        public bool Status { get; private set; }

        public Calendar(string title, string description)
        {
            Title = title;
            Description = description;
            Status = true;
        }
        public void Edit(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
