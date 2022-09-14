using _0_Framework.Application;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haidarieh.Application.Contracts.Calendar
{
    public class CreateCalendar
    {
        public long Id { get; set; }
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
