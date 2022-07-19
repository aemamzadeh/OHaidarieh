﻿using _0_Framework.Application;
using Haidarieh.Application.Contracts.Ceremony;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Haidarieh.Application.Contracts.CeremonyGuest
{
    public class EditCeremonyGuest //: CreateCeremonyGuest
    {
        public long Id { get; set; }
        [Range(1, long.MaxValue, ErrorMessage = ValidationMessages.IsRequired)]
        public long GuestId { get; set; }
        [Range(1, long.MaxValue, ErrorMessage = ValidationMessages.IsRequired)]
        public long CeremonyId { get; set; }
        public string GuestType { get; set; }
        public string CeremonyDate { get; set; }
        public string Title { get; set; }
        public int Satisfication { get; set; }
        public string GuestName { get; set; }
        public List<CeremonyViewModel> Ceremonies { get; set; }
        public List<CeremonyGuestViewModel> Guests { get; set; }
    }
}