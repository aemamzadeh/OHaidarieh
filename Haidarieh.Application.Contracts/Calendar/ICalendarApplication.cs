using _0_Framework.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haidarieh.Application.Contracts.Calendar
{
    public interface ICalendarApplication
    {
        List<CalendarViewModel> Search(CalendarSearchModel searchModel);
        OperationResult Create(CreateCalendar command);
        OperationResult Edit(CreateCalendar command);
        CreateCalendar GetDetail(long Id);
        List<CalendarViewModel> GetCalendars();


    }
}
