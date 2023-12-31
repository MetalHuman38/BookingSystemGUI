﻿namespace BookingSystem.MVVM.Model
{
    public class BookingModel
    {
        public int BookingId { get; set; }
        public string GuestName { get; set; }
        public string AccommodationType { get; set; }
        public DateTime? CheckIN { get; set; }
        public DateTime? CheckOut { get; set; }
        public int NumberOfNights { get; set; }
        public decimal TotalPrice { get; set; }
        // Other properties as needed
    }
}

