﻿using HotelDb.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HotelDb.DataLayer.Context
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext() { }
       
        public HotelDbContext(DbContextOptions<HotelDbContext> options)
            : base(options) { }

        public DbSet<BookingDL> Bookings { get; set; }
        public DbSet<BookingRoomListDL> BookingRoomList { get; set; }
        public DbSet<ClientDL> Clients { get; set; }        
        public DbSet<GuestListDL> GuestList { get; set; }
        public DbSet<HolidayListDL> HolidayList { get; set; }
        public DbSet<InvoiceDL> Invoices { get; set; }
        public DbSet<RoomDL> Rooms { get; set; }
        public DbSet<RoomPriceDL> RoomPrice { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookingRoomListDL>()
                .HasKey(x => new { x.BookingId, x.RoomId });
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ht_localdb;Trusted_Connection=True;");
        }
    }
}
