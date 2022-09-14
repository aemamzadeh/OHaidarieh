using _0_Framework.Domain;
using Haidarieh.Application.Contracts.Calendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Haidarieh.Domain.CalendarAgg
{
    public interface ICalendarRepository : IRepository<long, Calendar>
    {
        CreateCalendar GetDetail(long Id);
        List<CalendarViewModel> Search(CalendarSearchModel searchModel);
        List<CalendarViewModel> GetCalendars();

    }
}
