using System.ComponentModel.DataAnnotations;

namespace Haidarieh.Application.Contracts.Multimedia
{
    public class MultimediaViewModel
    {
        public long Id { get; set; }
        public string Title { get;  set; }
        public string FileAddress { get;  set; }
        public long CeremonyId { get;  set; }
        public string Ceremony { get; set; }
        public string ContentType { get; set; }
        public int VisitCount { get; set; }
        public string Guest { get; set; }
        public long GuestId { get; set; }

    }
}