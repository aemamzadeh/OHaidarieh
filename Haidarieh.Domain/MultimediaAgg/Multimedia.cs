using _0_Framework.Domain;
using Haidarieh.Domain.CeremonyAgg;
using Haidarieh.Domain.CeremonyGuestAgg;
using Haidarieh.Domain.GuestAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haidarieh.Domain.MultimediaAgg
{
    public class Multimedia : EntityBase
    {
        public string Title { get; private set; }
        public string FileAddress { get; private set; }
        public string FileTitle { get; private set; }
        public string FileAlt { get; private set; }
        public bool Status { get; private set; }
        public long CeremonyId { get; private set; }
        public long? GuestId { get; private set; }
        public Ceremony Ceremony { get; private set; }
        public Guest Guest { get; private set; }
        public int VisitCount { get; private set; }

        public Multimedia(string title, string fileAddress, string fileTitle, string fileAlt, long ceremonyId, int visitCount, long? guestId)
        {
            Title = title;
            FileAddress = fileAddress;
            FileTitle = fileTitle;
            FileAlt = fileAlt;
            CeremonyId = ceremonyId;
            Status = true;
            if (visitCount != 0)
            {
                VisitCount = visitCount;
            }
            else
                VisitCount = 0;
            GuestId = guestId;
        }
        public void Edit(string title, string fileAddress, string fileTitle, string fileAlt, long ceremonyId,int visitCount, long? guestId)
        {
            Title = title;
            if(!string.IsNullOrWhiteSpace(fileAddress))
                FileAddress = fileAddress;
            FileTitle = fileTitle;
            FileAlt = fileAlt;
            CeremonyId = ceremonyId;
            Status = true;
            VisitCount = visitCount;
            GuestId = guestId;
        }

        public void EditMetadata(string title , string fileTitle, string fileAlt, long ceremonyId)
        {
            Title = title;
            FileTitle = fileTitle;
            FileAlt = fileAlt;
            CeremonyId = ceremonyId;
            Status = true;
        }
        public void EditAlbum(string fileAddress,long ceremonyId, long? guestId, string imageTitle, string imageAlt)
        {
            FileAddress = fileAddress;
            CeremonyId = ceremonyId;
            GuestId = guestId;
            FileTitle = imageTitle;
            FileAlt = imageAlt;
            Status = true;
        }
        public void Delete()
        {
            Status = false;
        }
    }
}
