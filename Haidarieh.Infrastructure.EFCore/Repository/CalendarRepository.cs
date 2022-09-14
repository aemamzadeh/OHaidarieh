using _0_Framework.Infrastructure;
using Haidarieh.Application.Contracts.Calendar;
using Haidarieh.Domain.CalendarAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Haidarieh.Infrastructure.EFCore.Repository
{
    public class CalendarRepository : RepositoryBase<long, Calendar>, ICalendarRepository
    {
        private readonly HContext _hContext;
        public CalendarRepository(HContext hContext) : base(hContext)
        {
            _hContext = hContext;
        }
        public CreateCalendar GetDetail(long Id)
        {
            return _hContext.Calendars.Select(x => new CreateCalendar()
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description

            }).FirstOrDefault(x => x.Id == Id);
        }

        public List<CalendarViewModel> Search(CalendarSearchModel searchModel)
        {
            var query = _hContext.Calendars.Select(x => new CalendarViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description
            });

            if (!string.IsNullOrWhiteSpace(searchModel.Title))
                query = query.Where(x => x.Title.Contains(searchModel.Title));

            return query.ToList();
        }
        public List<CalendarViewModel> GetCalendars()
        {
            return _hContext.Calendars.Select(x => new CalendarViewModel()
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description

            }).ToList();
        }
    }
}
