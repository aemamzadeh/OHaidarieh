using Haidarieh.Application.Contracts.Ceremony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haidarieh.Application.Contracts.Calendar
{
    public class CalendarViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<CeremonyViewModel> Ceremonies { get; set; }
    }
}
