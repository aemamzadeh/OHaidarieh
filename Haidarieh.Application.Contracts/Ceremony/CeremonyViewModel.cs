﻿using Haidarieh.Application.Contracts.CeremonyGuest;
using Haidarieh.Application.Contracts.Multimedia;
using System;
using System.Collections.Generic;

namespace Haidarieh.Application.Contracts.Ceremony
{
    public class CeremonyViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public DateTime CeremonyDate { get; set; }
        public string CeremonyDateFA { get; set; }
        public bool IsLive { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }
        public List<CeremonyOperationViewModel> CeremonyOperations { get; set; }
        public List<CeremonyGuestViewModel> CeremonyGuests { get; set; }
        public List<MultimediaViewModel> Multimedias { get; set; }






    }
}
