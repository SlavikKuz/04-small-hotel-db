Hi!

This is a project for a hypothetical small hotel. 
The hotel needs a database that will help in managing its everyday activities.
Keywords: C#, SQL, MVC, VS2017, SSMS2017. 
The project does not use stored procedures, only c# code with SQL statements.

1. Database description

- entity Client
	*id, int
	client_full_name, varchar
	email, varchar
	tel, varchar
	address, varchar
	notes, text //any kind of additional information

- entity Order
	*id, id
	client_id, id  
	order_date, datetime
	day_from, date
	day_till, date
	adults, int //number of
	kids, int
	status, varchar //paid, canceled, etc
	info, text
 
- entity Calendar
	*day, date // not int, date type
	weekend, bool //for pricing policy
	holiday, bool //for pricing policy	

- entity Room
	*id, id
	room, varchar //room number with letters
	beds, int //places in the room
	floor, varchar //incuding attic, basement, etc
	info, text
	step // int, equal to id, for ORDER BY purpose if any change in room number happens 

- entity HotelPlan
	*room_id, int //ocupied room
	*order_id, int //ocupied after order
	*calendar_day, date //ocupied till
	status, varchar //ocupied, paid, reserved, etc
	adults, int
	kids, int //for group orders after single resevation, placement info

2. Please see DBdiagram.PNG for database diagram.

3. Model of database (from MVC).
Tasks (with sample SQL queries):


ModelClient.InsertClient()
// register a new client
	INSERT INTO Client 
	VALUES ( 0, 
		'Slavik Kuz', 
		'mymail@email.com', 
		'123445678', 
		'Follumsvei 11B, Nordfjord, 9611', 
		'loyal client, traveling with a bike');


ModelClient.SelectClients()
// get a list of clients;
	SELECT * FROM Client;


ModelClient.SelectClient(string fing)
// get a list of clients (filter);
	SELECT * FROM Client 
	WHERE client_full_name LIKE '%k%'
		OR email   LIKE '%k%'
		OR tel     LIKE '%k%'
		OR address LIKE '%k%'
		OR notes   LIKE '%k%'
		OR id = 'g';


ModelClient.SelectClient(int client_id)
// get data for selected client;
	SELECT client_full_name, email, tel, address, notes 
	FROM Client
	WHERE id = '5';


ModelClient.UpdateClient(int client_id)
// change client's data;
	UPDATE Client
	SET client_full_name = 'John Doe', 
		email = 'newmail@smthmail.com',
		tel = '987654321',
		address = 'Tr�nevegen 32, S�rfjord, 3215',
		notes = 'test'
	WHERE id = 1
	LIMIT 1; //control safety


ModelCalendar.InsertDays(int year)
// create a calendar for selected year;
	INSERT INTO Calendar
	SET day = '2019-01-01',
	weekend = 1,
	holiday = 0;


ModelCalendar.SetHolidays(string day) 
ModelCalendar.OffHolidays(string day) 
// mark some days as holiday/days off;
	UPDATE Calender
	SET holiday = 1
	WHERE day = '2019-01-01';


ModelRoom.SelectRoom()
// get a list of rooms;
	SELECT * FROM Room
	ORDER BY step; 


ModelRoom.InsertRoom()
// add a new room;
	INSERT INTO Room
	SET room = 'Twin 105',
		beds = 2,
		floor = 1,
		info = 'Sweet twin for a couple';
	UPDATE Room
	SET step = 2
	WHERE id = 2;


ModelRoom.SelectRoom(int room_id)
// get info on selected room;
	SELECT * FROM Room
	WHERE id = 1;


ModelRoom.UpdateRoom(int room_id)
// change data for selected room;
	UPDATE Room
	SET room = 'Single 105',
		beds = 1,
		floor = 1,
		info = 'Nice single'
	WHERE id = 2;


ModelBook.InsertBook()
// add a new registration;
	INSERT INTO Order
	SET client_id = 1,  
		order_date = NOW(),
		day_from = '2016-01-01',
		day_till = '2016-01-01',
		adults = 1,
		kids = 0,
		status = 'paid',
		info = 'test of the field';


ModelBook.UpdateStatus (int book_id, string status)
// change registarion's status (canceled, confirmed, waiting confirmation);
	UPDATE Order
	SET status = 'confirmed'
	WHERE id = 1;


ModelBook.UpdateBook(int book_id)
// edit registration;
	UPDATE Order
	SET adults = 1,
	kids = 1,
	info = 'not specified'
	WHERE id = 1;


ModelBook.UpdateFromDay (int book_id, string day_from)
ModelBook.UpdateTillDay (int book_id, string day_till)
// edit registration period;
	UPDATE Order
	SET day_from = '2016-01-02',
	    day_till = '2016-01-02',
	WHERE id = 1;


ModelBook.SelectBooks()
// get a list of registrations;
	SELECT client_id, 
		client, 
		order_date, 
		day_from, 
		day_till, 
		adults, 
		kids, 
		status, 
		o.info 
	FROM Order o
	LEFT JOIN Client c
	ON o.client_id = c.id
	WHERE o.id = 1;


ModelBook.SelectBooks(string find)
// get a list of registrations (filter);
	SELECT client_id, 
		client, 
		order_date, 
		day_from, 
		day_till, 
		adults, 
		kids, 
		status, 
		o.info 
	FROM Order o
	LEFT JOIN Client c
	ON o.client_id = c.id
	WHERE client LIKE '%g%'
	OR order_date LIKE 'g%'
	OR day_from LIKE 'g%'
	OR day_till LIKE 'g%'
	OR adults = 'g'
	OR kids = 'g'
	OR status = 'g'
	OR o.info LIKE '%g%';


ModelPlan.SelectPlan(string day_from, string day_till)
// get a list of booked rooms on a selected month;
	SELECT room_id, order_id, calendar_day, status, adults, kids
	FROM HotelPlan
	WHERE calendar_day BETWEEN '2019-05-01' AND '2019-05-31';


ModelPlan.InsertPlan()
// add a reservation to HotelPlan;
	INSERT INTO HotelPlan
	set room_id = 1,
		order_id = 1,
		calendar_day = '2019-05-20', 
		status = 'confirmed', 
		adults = 1, 
		kids = 1;

ModelPlan.ModelPlan(int room_id, init book_id, string calendar_day)
ModelPlan.UpdatePlan()
// change/delete this reservation;
	UPDATE HotelPlan
	SET status = 'cancelled',
		adults = 1,
		kids = 0,
	WHERE room_id = 1,
		book_id=1,
		calendar_day = '2019-05-20';


ModelPlan.DeletePlan()
// delete this reservation;
	DELETE FROM HotelPlan
	WHERE room_id = 1,
		book_id=1,
		calendar_day = '2019-05-20';
	


ModelRoom.SelectFreeRooms()
// get a list og empty rooms on selected date;
	SELECT * FROM room
	WHERE id NOT IN 
		(SELECT room_id 
		FROM HotelPlan 
		WHERE calendar_day = '2019-05-20');
	
NB! No client's data is planned to be deleted from a database.

4. Models
4.1. Client.cs //work with clients

