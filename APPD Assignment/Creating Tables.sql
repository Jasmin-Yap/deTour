-- TO DROP TABLES (IF NEEDED)
Drop Table Booking
Drop Table Cart
Drop Table Wishlist
Drop Table UserGuests
Drop Table Tour
Drop Table PaymentPremium
Drop Table Users

-- Viewing
Select * from Users
Select * from PaymentPremium
Select * from Tour
Select * from Booking
Select * from Cart
select * from users

-- Create User Table
Create Table Users
(	AccountType		char(1)			NOT NULL, -- P for Premium, F for Free, A for Admin
	Salution		varchar(4)		NOT NULL,
	Name			varchar(70)		NOT NULL,
	UserName		varchar(50)		NOT NULL, -- Primary Key
	UserPassword	varchar(30)		NOT NULL,
	UserAddress		varchar(30)		NOT NULL,
	ZipCode			integer			NOT NULL,
	PassPortNo		varchar(9)		NOT NULL,
	PassPortExpiry	date			NOT NULL,
	PhoneNo			integer			NOT NULL,
	Email			varchar(30)		NOT NULL,
	Discount		decimal(2,1)		NULL,
	PRIMARY KEY (UserName)
)

-- Populate User Table
INSERT INTO Users
VALUES
('P', 'Mrs','John O''Mary', 'a', 'a', 'Dover Road', 128800, 'K0000000E', '2020-11-11', 99966611, 'Ducky@duckbuttmail.com', 0.1),   --Premium
('F', 'Mr', 'Ian McCall', 'b', 'b', 'Ang Mo Kio', 560101, 'J0000000A', '2018-01-30', 87867444, 'UncleCreepy@paperweight.com', null) --Fremium

--Create Premium User Payment Info Table
Create Table PaymentPremium
(	UserName		varchar(50)	NOT NULL,	-- Primary Key
	CardNo			varchar(16)		NOT NULL,
	CardName		varchar(50) NOT NULL,	-- Name on Card
	CardED			date		NOT NULL,
	PRIMARY KEY (UserName),
	FOREIGN KEY (UserName) REFERENCES Users(UserName)
)

-- Populate User Table
INSERT INTO PaymentPremium
(UserName, CardNo, CardName, CardED)
VALUES
('a', '1234123412341234', 'John O''Mary', '2022-12-01') -- DD is auto

-- Create Tour Table
Create Table Tour
(	TourID			char(4)			NOT NULL,
	TourName		varchar(30)		NOT NULL,
	TourState		varchar(20)		NOT NULL,
	Country			varchar(30)		NOT NULL,
	Region			varchar(20)		NOT NULL,
	Summary			varchar(100)	NOT NULL,
	Itinerary		varchar(30)		NOT NULL, -- just store the itinerary file location here
	Price			decimal(15,2)	NOT NULL,
	StartDate		date			NOT NULL,
	EndDate			date			NOT NULL,
	Duration		char(16)		NOT NULL,
	Quantity		integer			NULL, -- if availability is null = tour is no longer available
	PRIMARY KEY (TourID)
)

-- Populate Tour Table
INSERT INTO Tour
VALUES
('T001', 'JB''s Local Delights 4D3N', 'Johor Bahru', 'Malaysia', 'South-East Asia', 'An unforgettable trip to a city that centers Malaysia and Singapore.', 'JBtourDetails', 500, '2018-02-12', '2018-02-16', '4 Days, 3 Nights', 20),
('T002','Malaysia''s Hottest 7D6N', 'Kuala Lumpur', 'Malaysia', 'South-East Asia', 'Capital of Malaysia, home to the Twin-Towers and its modern culture.', 'KLtourDetails', 500, '2018-04-04', '2018-04-11', '7 Days, 6 Nights', NULL),
('T003','The Metropolitan Port 5D4N', 'Surabaya', 'Indonesia', 'South-East Asia', 'Come along and enjoy the rich history and culture-filled Metropolis.', 'SurabayatourDetails',500, '2018-06-03', '2018-06-08', '5 Days, 4 Nights', 15),
('T004','Historical Capital 3D2N', 'Jakarta', 'Indonesia', 'South-East Asia', 'Be enlighten about the rich history and culture of Indonesia''s capital.', 'jakatatourDetails',500, '2018-07-04', '2018-07-07', '3 Days, 2 Nights', 20),
('T005','Busy Busan 6D5N', 'Busan', 'South Korea', 'East Asia', 'Enjoy the sunny beaches of Busan with a taste of Korean''s culture.', 'BusantourDetails',700, '2018-07-18', '2018-07-24', '6Days, 5 Nights', 25),
('T006','Modern Metropolis 7D6N', 'Seoul', 'South Korea', 'East Asia', 'Home to K-pop and a rich fashion industry, enter the land of Korea.', 'SeoultourDetails',700, '2018-08-01', '2018-08-08', '7 Days, 6 Nights', 5),
('T007','The Old Capital 3D2N', 'Kyoto', 'Japan', 'East Asia', 'Discover Kyoto, former-capital of the rich cultured country, Japan.', 'KyototourDetails',700, '2018-08-11', '2018-08-14', '3 Days, 2 Nights', NULL),
('T008','Modern but Traditional 4D3N', 'Tokyo', 'Japan', 'East Asia', 'Experience the tradional roots and modernisation of Japan.', 'tokyotourDetails',700, '2018-08-24', '2018-08-28', '4 Days, 3 Nights', 10),
('T009','The Presidential Palace 7D6N', 'Washington D.C.', 'USA', 'North America', 'Home to the current President of the United States, Donald J. Trump.', 'washington-dcTourDetails',900, '2018-09-02', '2018-09-09', '7 Days, 6 Nights', 10),
('T010','Surfs-Up in Hollywood 5D4N', 'California', 'USA', 'North America', 'Discover glam, glitz and fashion of the most happening state in USA.', 'HollywoodtourDetails',900, '2018-11-11', '2018-11-16', '5 Days, 4 Nights', 1), 
('T011','Fine-Artisan 6D5N', 'Montreal, Quebec', 'Canada', 'North America', 'Indulge yourself in the UNESCO-listed Old Quebec and Place Royale.', 'MontrealtourDetails',900, '2018-11-18', '2018-11-24', '6 Days, 5 Nights', 7),
('T012','Winter Wonderland 5D4N', 'Ottawa','Canada','North America','Rock the powdery white snow slopes through Winter Wonderland.','ottawatourDetails',900,'2018-12-01','2018-12-06','5 Days, 4 Nights', NULL),
('T013','The Kingdom Awakens 4D3N','Dublin','Ireland','Europe','Home to MMA legend Conor McGregor, discover his past.','DublintourDetails',800,'2018-12-11','2018-12-15','4 Days, 3 Nights', 30),
('T014','Culture of the Capital 3D2N','Dublin','Ireland','Europe','Discover Dublin''s culture in 4 different top tourists attractions.','Dublin2tourDetails',800,'2018-12-18','2018-12-21','3 Days, 2 Nights', 18),
('T015','The Sinking City 6D5N','Venice','Italy','Europe','Enlighten yourself about the rich heritage of a sinking land, Venice.','venicetourDetails',800,'2019-01-01','2019-01-07','6 Days, 5 Nights', 5),
('T016','For the Romantics 7D6N','Paris','France','Europe','Live the dream of romantics, explore it''s beautiful vintage awe.','paristourDetails',800,'2019-02-22','2019-03-01','7 Days, 6 Nights', 20)

-- format for date in SQL is YYYY-MM-DD, the one in the textfile is DD/MM/YYYY
-- Some of the tours have less than 10 - NULL availibilty to mimic less space of no space and showcase schduele handling.

-- Create Booking Table (To store bookings after payment)
Create Table Booking
(	BookingID		Integer			NOT NULL identity,		
	UserName		varchar(50)		NOT NULL,
	TransactionTime	Date			NOT NULL,
	CardNo			varchar(16)		NOT NULL,
	TourID			char(4)			NOT NULL,
	HotelStars		integer			NOT NULL,
	PricePaid		decimal(15,2)	NOT NULL,
	Quantity		integer			NOT NULL,
	PRIMARY KEY (BookingID),
	FOREIGN KEY (UserName) REFERENCES Users(UserName),
	FOREIGN KEY (TourID) REFERENCES Tour(TourID)
)
-- DateTime format -> YYYY-MM-DD

-- Populate Booking Table (EXAMPLES)
INSERT INTO Booking
(UserName, TourID, HotelStars, PricePaid, Quantity, TransactionTime, CardNo)
VALUES
('a', 'T001', 5, 1350, 5, '2018-01-30 10:31:00', '123123123')

-- Create Cart Table (Store bookings before payment - subjected to change in information)
Create Table Cart
(	UserName		varchar(50)		NOT NULL,	-- Primary Key
	CartID			integer			NOT NULL identity,	-- Primary Key
	TourID			char(4)			NOT NULL,
	HotelStars		integer			NOT NULL,
	Price			decimal(15,2)	NOT NULL,
	Quantity		integer			NOT NULL,
	PRIMARY KEY (UserName, CartID),
	FOREIGN KEY (UserName) REFERENCES Users(UserName),
	FOREIGN KEY (TourID) REFERENCES Tour(TourID)
)

-- Populate Cart Table (EXAMPLES)
INSERT INTO Cart
(UserName, TourID, HotelStars, Price, Quantity)
VALUES
('a', 'T001', 5, 1350, 5)

-- Create Wishlist Table
Create Table Wishlist
(	UserName		varchar(50)		NOT NULL,
	TourID			char(4)			NOT NULL,
	PRIMARY KEY (UserName, TourID),
	FOREIGN KEY (UserName) REFERENCES Users(UserName),
	FOREIGN KEY (TourID) REFERENCES Tour(TourID)
)

--Populating Wishlist Table
INSERT INTO Wishlist
VALUES
('a', 'T002')