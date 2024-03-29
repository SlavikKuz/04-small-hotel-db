﻿using AutoMapper;
using HotelDb.DataLayer;
using HotelDb.DataLayer.Entities;
using HotelDb.DataLayer.Interfaces;
using HotelDb.DataLogic;
using HotelDb.Logic.Entities;
using System;
using System.Collections.Generic;

namespace HotelDb.Logic
{
    public class LogicLL : IDisposable
    {             
        private UnitOfWork DataBase { get; } = new UnitOfWork();
        private IMapper mapper = ObjectMapper.Mapper;

        
        public IEnumerable<BookingLL> GetAllBookings()
        {
            List<BookingLL> result = new List<BookingLL>();

            foreach (BookingDL booking in DataBase.Bookings.ReadAll())
                result.Add(mapper.Map<BookingLL>(booking));
            return result;
        }       
        
        public IEnumerable<ClientLL> GetAllClients()
        {
            List<ClientLL> result = new List<ClientLL>();

            foreach (ClientDL client in DataBase.Clients.ReadAll())
                result.Add(mapper.Map<ClientLL>(client));
            return result;
        }        
        
        //public IEnumerable<GuestListLL> GetAllGuestList()
        //{
        //    List<GuestListLL> result = new List<GuestListLL>();
            
        //    foreach (GuestListDL guest in DataBase.GuestList.ReadAll())
        //        result.Add(mapper.Map<GuestListLL>(guest));
        //    return result;
        //}        
        
        public IEnumerable<HolidayListLL> GetAllHolidayList()
        {
            List<HolidayListLL> result = new List<HolidayListLL>();

            foreach (HolidayListDL day in DataBase.HolidayList.ReadAll())
                result.Add(mapper.Map<HolidayListLL>(day));
            return result;
        }  
        
        public IEnumerable<InvoiceLL> GetAllInvoices()
        {
            List<InvoiceLL> result = new List<InvoiceLL>();

            foreach (InvoiceDL invoice in DataBase.Invoices.ReadAll())
                result.Add(mapper.Map<InvoiceLL>(invoice));
            return result;
        }

        //public IEnumerable<RoomListLL> GetAllRoomList()
        //{
        //    List<RoomListLL> result = new List<RoomListLL>();

        //    foreach (RoomListDL roomList in DataBase.RoomList.ReadAll())
        //        result.Add(mapper.Map<RoomListLL>(roomList));
        //    return result;
        //}

        public IEnumerable<RoomLL> GetAllRooms()
        {
            List<RoomLL> result = new List<RoomLL>();

            foreach (RoomDL room in DataBase.Rooms.ReadAll())
                result.Add(mapper.Map<RoomLL>(room));
            return result;
        }

        public IEnumerable<RoomPriceLL> GetAllRoomPrice()
        {
            List<RoomPriceLL> result = new List<RoomPriceLL>();

            foreach (RoomPriceDL room in DataBase.RoomPrice.ReadAll())
                result.Add(mapper.Map<RoomPriceLL>(room));
            return result;
        }



        public void AddBooking(BookingLL booking)
        {
            DataBase.Bookings.Create(mapper.Map<BookingDL>(booking));
            DataBase.Save();
        }

        public void AddClient(ClientLL client)
        {
            DataBase.Clients.Create(mapper.Map<ClientDL>(client));
            DataBase.Save();
        }

        //public void AddGuestList(GuestListLL guestList)
        //{
        //    DataBase.GuestList.Create(mapper.Map<GuestListDL>(guestList));
        //    DataBase.Save();
        //}

        public void AddHoliday(HolidayListLL day)
        {
            DataBase.HolidayList.Create(mapper.Map<HolidayListDL>(day));
            DataBase.Save();
        }

        public void AddInvoice(InvoiceLL invoice)
        {
            DataBase.Invoices.Create(mapper.Map<InvoiceDL>(invoice));
            DataBase.Save();
        }

        //public void AddRoomList(RoomListLL roomList)
        //{
        //    DataBase.RoomList.Create(mapper.Map<RoomListDL>(roomList));
        //    DataBase.Save();
        //}

        public void AddRoom(RoomLL room)
        {
            DataBase.Rooms.Create(mapper.Map<RoomDL>(room));
            DataBase.Save();
        }

        public void AddRoomPrice(RoomPriceLL roomPrice)
        {
            DataBase.RoomPrice.Create(mapper.Map<RoomPriceDL>(roomPrice));
            DataBase.Save();
        }



        public void UpdateBooking(BookingLL booking)
        {
            DataBase.Bookings.Update(mapper.Map<BookingDL>(booking));
            DataBase.Save();
        }        

        public void UpdateClient(ClientLL client)
        {
            DataBase.Clients.Update(mapper.Map<ClientDL>(client));
            DataBase.Save();
        }

        public void UpdateRoomList(RoomPriceLL roomPrice)
        {
            DataBase.RoomPrice.Update(mapper.Map<RoomPriceDL>(roomPrice));
            DataBase.Save();
        }

        public void UpdateRoom(RoomLL room)
        {
            DataBase.Rooms.Update(mapper.Map<RoomDL>(room));
            DataBase.Save();
        }

        public void UpdateRoomPrice(RoomPriceLL roomPrice)
        {
            DataBase.RoomPrice.Update(mapper.Map<RoomPriceDL>(roomPrice));
            DataBase.Save();
        }
    


        public void RemoveHoliday(Guid id)
        {
            DataBase.HolidayList.Delete(id);
            DataBase.Save();
        }
        


        public void Dispose()
        {
            DataBase.Dispose();
        }
    }
}
