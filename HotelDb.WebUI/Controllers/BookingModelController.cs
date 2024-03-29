﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HotelDb.Logic;
using HotelDb.Logic.Entities;
using HotelDb.WebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HotelDb.WebUI.Controllers
{
    public class BookingModelController : Controller
    {
        private readonly IMapper mapper;
        public BookingModelController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public ActionResult ShowAll() //ShowAllPage
        {
            List<BookingModel> allBookings;

            using (var database = new LogicLL())
            {
                allBookings = mapper.Map<List<BookingModel>>(database.GetAllBookings()).ToList();
            }

            return View(allBookings);
        }

        public ActionResult CreatePageName()
        {
            List<ClientModel> allClients;
            using (var database = new LogicLL())
                allClients = mapper.Map<List<ClientModel>>(database.GetAllClients());

            ViewData["AllClients"] = allClients;
            return View(allClients);          
        }
  
        public ActionResult CreatePage(string id)
        {
            BookingModel booking;

            using (var database = new LogicLL())
            {
                database.AddBooking(mapper.Map<BookingLL>(new BookingModel()));
                booking = mapper.Map<BookingModel>(database.GetAllBookings().Last());
            }



                //clients = mapper.Map<List<ClientModel>>(database.GetAllClients());

            //List<string> clientNames = new List<string>();

            //foreach (var cl in clients)
            //    clientNames.Add(cl.ClientFullName);

            //ViewData["ClientList"] = clientNames;

            return View();
        }


        // ????
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(string bookingButton, BookingViewModel bookingPost)
        //{

        //    List<ClientModel> allClients;
        //    List<RoomModel> allRooms;
        //    List<ClientModel> allGuests;
        //    List<HolidayListModel> allHolidays;
        //    List<RoomPriceModel> allRoomPrices;
        //    List<InvoiceModel> allInvoices;

        //    using (var database = new LogicLL())
        //    {
        //        allClients = mapper.Map<List<ClientModel>>(database.GetAllClients());

        //        allRooms = (mapper.Map<List<RoomModel>>(database.GetAllRooms()))
        //            .Where(x => x.Ready == true).ToList();

        //        allGuests = mapper.Map<List<ClientModel>>(database.GetAllClients());

        //        allHolidays = mapper.Map<List<HolidayListModel>>(database.GetAllHolidayList());

        //        allRoomPrices = mapper.Map<List<RoomPriceModel>>(database.GetAllRoomPrice());

        //        allInvoices = mapper.Map<List<InvoiceModel>>(database.GetAllInvoices());
        //    }

        //    bookingPost.SelectListClient = allClients
        //            .Select(x => new SelectListItem { Text = x.ClientFullName, Value = x.Id.ToString() })
        //            .ToList();

        //    bookingPost.SelectListRoom = allRooms
        //            .Select(x => new SelectListItem { Text = x.RoomNumber, Value = x.Id.ToString() })
        //            .ToList();

        //    bookingPost.SelectListGuest = allGuests
        //            .Select(x => new SelectListItem { Text = x.ClientFullName, Value = x.Id.ToString() })
        //            .ToList();

        //    switch (bookingButton)
        //    {
        //        case "AddRoom":
        //            bookingPost.RoomList.Add( new RoomListModel()
        //            { RoomId = bookingPost.RoomId });
        //            bookingPost.Invoice.TotalPrice = 0;
        //            break;

        //        case "AddGuest":
        //            bookingPost.GuestList.Add( new GuestListModel() 
        //            { ClientId = bookingPost.GuestId });
        //            break;

        //        case "Invoice":

        //            RoomPriceModel roomPrice;
        //            decimal totalPrice = 0;

        //            foreach (var room in bookingPost.RoomList)
        //            {
        //                roomPrice = (allRoomPrices.Where(x => x.Id ==
        //                                (
        //                                    (allRooms.Where(x => x.Id == room.RoomId))
        //                                    .Select(x => x.RoomPriceId).First()
        //                                ))).First();
                   
        //                for (DateTime day = bookingPost.Booking.DayFrom; day <= bookingPost.Booking.DayTill; day = day.AddDays(1))
        //                {
        //                    if ((allHolidays.Select(x => x.HolidayDay))
        //                        .Where(x => x == day).Count() > 0)
        //                    {
        //                        totalPrice += roomPrice.HolidayPrice;
        //                    }
        //                    else if ((day.DayOfWeek == DayOfWeek.Friday) ||
        //                             (day.DayOfWeek == DayOfWeek.Saturday) ||
        //                             (day.DayOfWeek == DayOfWeek.Sunday))
        //                    {
        //                        totalPrice += roomPrice.WeekendPrice;
        //                    }
        //                    else
        //                    {
        //                        totalPrice += roomPrice.AveragePrice;
        //                    }
        //                }
        //            }

        //            bookingPost.Invoice.TotalPrice = totalPrice;
        //            break;

        //        case "Save":
        //            {
        //                try
        //                {
        //                    long bookingId;
        //                    long invoiceId;
                                                    
        //                    BookingModel booking = new BookingModel()
        //                    {
        //                        //bookingId
        //                        ClientId = bookingPost.Booking.ClientId,
        //                        OrderDate = bookingPost.Booking.OrderDate,
        //                        DayFrom = bookingPost.Booking.DayFrom,
        //                        DayTill = bookingPost.Booking.DayTill,
        //                        WithKids = bookingPost.Booking.WithKids,
        //                        Status = bookingPost.Booking.Status,
        //                        Info = bookingPost.Booking.Info
        //                        //InvoiceId
        //                    };

        //                    BookingModel bookingUpdated;

        //                    InvoiceModel invoice = new InvoiceModel()
        //                    {
        //                        //InvoiceId
        //                        ClientId = bookingPost.Booking.ClientId,
        //                        //BookingId
        //                        TotalPrice = bookingPost.Invoice.TotalPrice
        //                    };

        //                    List<RoomListModel> roomList = bookingPost.RoomList;
        //                    List<GuestListModel> guestList = bookingPost.GuestList;
                            
        //                    using (var database = new LogicLL())
        //                    {
        //                        database.AddBooking(mapper.Map<BookingLL>(booking));
        //                        bookingId = 
        //                            (mapper.Map<List<BookingModel>>(database.GetAllBookings())).Last().BookingId;
        //                        bookingPost.Booking.BookingId = bookingId;
        //                        bookingPost.Invoice.BookingId = bookingId;
        //                        invoice.BookingId = bookingId;

        //                        database.AddInvoice(mapper.Map<InvoiceLL>(invoice));
        //                        invoiceId =
        //                            (mapper.Map<List<InvoiceModel>>(database.GetAllInvoices())).Last().InvoiceId;
        //                        bookingPost.Booking.InvoiceId = invoiceId;
        //                        bookingPost.Invoice.InvoiceId = invoiceId;

        //                        foreach(var room in roomList)
        //                        {
        //                            room.BookingId = bookingId;
        //                            database.AddRoomList(mapper.Map<RoomListLL>(room));
        //                        }

        //                        foreach(var guest in guestList)
        //                        {
        //                            guest.BookingId = bookingId;
        //                            database.AddGuestList(mapper.Map<GuestListLL>(guest));
        //                        }
        //                    }

        //                    using (var database = new LogicLL())
        //                        database.UpdateBooking(mapper.Map<BookingLL>(bookingPost.Booking));

        //                    return RedirectToAction(nameof(ShowAll));
        //                }
        //                catch (Exception ex)
        //                {
        //                    return View();
        //                }
        //            }
        //    }

        //    foreach (var room in bookingPost.RoomList)
        //        bookingPost.ShowSelectedRooms.Add(
        //           allRooms.Where(x => x.RoomId == room.RoomId)
        //            .Select(x => x.RoomNumber)
        //            .First()
        //            .ToString());

        //    foreach (var guest in bookingPost.GuestList)
        //        bookingPost.ShowSelectedGuests.Add(
        //           allGuests.Where(x => x.ClientId == guest.ClientId)
        //            .Select(x => x.ClientFullName)
        //            .First()
        //            .ToString());

        //    return View(bookingPost);
        //}

        //public ActionResult Search()
        //{
        //    return View(new List<BookingViewModel>());
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Search(string searchString)
        //{
        //    List<BookingViewModel> input = new List<BookingViewModel>();
        //    List<BookingViewModel> output = null;

        //    List<BookingModel> allBookings = new List<BookingModel>();
        //    List<ClientModel> allClients = new List<ClientModel>();
        //    List<GuestListModel> allGuestList = new List<GuestListModel>();
        //    List<HolidayListModel> allHolidays = new List<HolidayListModel>();
        //    List<InvoiceModel> allInvoices = new List<InvoiceModel>();
        //    List<RoomListModel> allRoomList = new List<RoomListModel>();
        //    List<RoomModel> allRooms = new List<RoomModel>();
        //    List<RoomPriceModel> allRoomPrice = new List<RoomPriceModel>();

        //    using (var database = new LogicLL())
        //    {
        //        allBookings = mapper.Map<List<BookingModel>>(database.GetAllBookings());
        //        allClients = mapper.Map<List<ClientModel>>(database.GetAllClients());
        //        allGuestList = mapper.Map<List<GuestListModel>>(database.GetAllGuestList());
        //        allHolidays = mapper.Map<List<HolidayListModel>>(database.GetAllHolidayList());
        //        allInvoices = mapper.Map<List<InvoiceModel>>(database.GetAllInvoices());
        //        allRoomList = mapper.Map<List<RoomListModel>>(database.GetAllRoomList());
        //        allRooms = mapper.Map<List<RoomModel>>(database.GetAllRooms());
        //        allRoomPrice = mapper.Map<List<RoomPriceModel>>(database.GetAllRoomPrice());
        //    }

        //    foreach (var b in allBookings)
        //    {
        //        input.Add(new BookingViewModel
        //        {
        //            Booking = b,
        //            Client = allClients.Where(x => x.ClientId == b.ClientId).First(),
        //            Invoice = allInvoices.Where(x => x.BookingId == b.BookingId).First(),
        //            SelectListClient = null,
        //            GuestList = null,
        //            SelectListGuest = null,
        //            ShowSelectedGuests = null,
        //            GuestId = 0,
        //            RoomList = null,
        //            SelectListRoom = null,
        //            ShowSelectedRooms = null,
        //            RoomId = 0
        //        });
        //    }

        //    foreach (var b in input)
        //        output = input.Where(x =>
        //                           (x.Client.FirstName.Contains(searchString)) ||
        //                           (x.Client.LastName.Contains(searchString)) ||
        //                           (x.Client.Email.Contains(searchString)) ||
        //                           (x.Client.Tel.Contains(searchString))).ToList();

        //    return View(output);

        //}

        //public ActionResult Edit(int id)
        //{
        //    BookingModel booking = new BookingModel();

        //    using (var database = new LogicLL())
        //        booking = (mapper.Map<List<BookingModel>>(database.GetAllBookings()))
        //            .Where(x => x.BookingId == id)
        //            .First();

        //    return View(booking);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, BookingModel booking)
        //{
        //    try
        //    {
        //        using (var database = new LogicLL())
        //            database.UpdateBooking(mapper.Map<BookingLL>(booking));

        //        return RedirectToAction("ShowAll");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

    }
}