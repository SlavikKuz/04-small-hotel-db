﻿using System;
using System.Collections.Generic;

namespace HotelDb.DataLayer.Entities
{
    public class BookingDL
    {
        public long Id { get; set; }
        public ClientDL Client { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DayFrom { get; set; }
        public DateTime DayTill { get; set; }
        public List<GuestDL> GuestsNames { get; set; } = new List<GuestDL>();
        public bool WithKids { get; set; }
        public Status Status { get; set; }
        public string Info { get; set; }
        public List<RoomDL> BookedRooms { get; set; } = new List<RoomDL>();
        public List<DayDL> Holidays { get; set; } = new List<DayDL>();
    }

    public enum Status
    {
        Comming, Ongoing, Cancelled
    }
}