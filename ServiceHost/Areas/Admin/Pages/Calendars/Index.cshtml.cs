using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _0_Framework.Infrastructure;
using Haidarieh.Application.Contracts.Calendar;
using Haidarieh.Configuration.Permissions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Admin.Pages.Calendars
{
    public class IndexModel : PageModel
    {
        private readonly ICalendarApplication _calendarApplication;
        public List<CalendarViewModel> Calendars;


        public IndexModel(ICalendarApplication calendarApplication)
        {
            _calendarApplication = calendarApplication;
        }

        [NeedPermission(HPermissions.ListCalendar)]
        public void OnGet(CalendarSearchModel searchModel)
        {
            Calendars = _calendarApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            return Partial("./Create", new CreateCalendar());
        }

        [NeedPermission(HPermissions.CreateCalendar)]
        public JsonResult OnPostCreate(CreateCalendar command)
        {
            var result = _calendarApplication.Create(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetEdit(long id)
        {
            var calendar = _calendarApplication.GetDetail(id);
            return Partial("Edit", calendar);
        }
        [NeedPermission(HPermissions.EditCalendar)]
        public JsonResult OnPostEdit(CreateCalendar command)
        {
            var result = _calendarApplication.Edit(command);
            return new JsonResult(result);
        }

    }
}
