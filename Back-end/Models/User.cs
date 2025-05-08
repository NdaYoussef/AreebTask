﻿using EventManagmentTask.Helpers;
using Microsoft.AspNetCore.Identity;

namespace EventManagmentTask.Models
{
    public class User :IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public DateTime RegisterdAt { get; set; } = DateTime.UtcNow;

        public ICollection<Event>? Events { get; set; } = new List<Event>();
        public ICollection<Booking>? Bookings { get; set; } = new List<Booking>();
    }
}
