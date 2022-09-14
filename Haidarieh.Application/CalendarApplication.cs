using _0_Framework.Application;
using Haidarieh.Application.Contracts.Calendar;
using Haidarieh.Domain.CalendarAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haidarieh.Application
{
    public class CalendarApplication : ICalendarApplication
    {
        private readonly ICalendarRepository _calendarRepository;
        public Calendar calendar { get; set; }

        public CalendarApplication(ICalendarRepository calendarRepository)
        {
            _calendarRepository = calendarRepository;
        }

        public OperationResult Create(CreateCalendar command)
        {
            var operation = new OperationResult();

            if (_calendarRepository.Exist(x => x.Title == command.Title))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            calendar = new Calendar(command.Title, command.Description);
            _calendarRepository.Create(calendar);
            _calendarRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Edit(CreateCalendar command)
        {
            var operation = new OperationResult();
            operation.IsSuccedded = false;
            var editItem = _calendarRepository.Get(command.Id);
            if (editItem == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            if (_calendarRepository.Exist(x => x.Title == command.Title && x.Id != command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);
            editItem.Edit(command.Title, command.Description);
            _calendarRepository.SaveChanges();
            return operation.Succedded();
        }

        public CreateCalendar GetDetail(long Id)
        {
            return _calendarRepository.GetDetail(Id);

        }

        public List<CalendarViewModel> Search(CalendarSearchModel searchModel)
        {
            return _calendarRepository.Search(searchModel);
        }

        public List<CalendarViewModel> GetCalendars()
        {
            return _calendarRepository.GetCalendars();
        }
    }
}
