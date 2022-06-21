using _0_Framework.Domain;
using Haidarieh.Domain.CeremonyAgg;
using Haidarieh.Domain.GuestAgg;


namespace Haidarieh.Domain.CeremonyGuestAgg 
{

    public class CeremonyGuestDropDownList : EntityBase
    {
        public long GuestId { get; set; }
        public string Guest { get;  set; }

    }
}
