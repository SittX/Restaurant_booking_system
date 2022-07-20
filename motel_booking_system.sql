CREATE DATABASE motel_booking_db;
USE motel_booking_db;

DROP table customers;
DROP table administrators;
DROP table room_types;
DROP table rooms;
DROP table bookings;


select * FROm customers;
CREATE TABLE customers(
	id VARCHAR(40) PRIMARY KEY,
	username VARCHAR(30) UNIQUE NOT NULL,
	acc_password VARCHAR(255) UNIQUE NOT NULL,
	email VARCHAR(50) UNIQUE NOT NULL,
	NRC VARCHAR(80) UNIQUE NOT NULL,
	ph_number VARCHAR(40) UNIQUE
);
INSERT INTO customers(id,username,acc_password,email,NRC,ph_number) 
VALUES('U_001','kevn','sdkfwer','kdf@gmail.com','asdf','093323241');

INSERT INTO customers(id,username,acc_password,email,NRC,ph_number) 
VALUES('U_002','David','adfawer','sdtbwaetrf@gmail.com','adfawecasdf','325423534');

INSERT INTO customers(id,username,acc_password,email,NRC,ph_number) 
VALUES('U_003','Nicole','sdkfdsdafwer','adfwer@gmail.com','asasdf3aerdf','082132143');


select * FROM administrators;

INSERT INTO administrators(id,username,acc_password,permission) VALUES('A_001','admin','admin123','CanReadnWrite');
DROP TABLE administrators;
CREATE TABLE administrators(
	id VARCHAR(40) NOT NULL PRIMARY KEY,
	username VARCHAR(30) UNIQUE NOT NULL,
	acc_password VARCHAR(255) UNIQUE NOT NULL,
	permission VARCHAR(25) NOT NULL DEFAULT 'ReadOnly'
);



CREATE TABLE room_types(
	id int PRIMARY KEY IDENTITY,
	type_description VARCHAR(40) UNIQUE NOT NULL
);
INSERT INTO room_types(type_description) VALUES('Single badroom');
INSERT INTO room_types(type_description) VALUES('Double badroom');
INSERT INTO room_types(type_description) VALUES('Deluxe room');
INSERT INTO room_types(type_description) VALUES('Family room');

SELECT * FROM room_types;
SELECT * FROM rooms;


INSERT INTO rooms(id,room_type,room_description,price) VALUES(102,1,'hello world',100000);
INSERT INTO rooms(id,room_type,room_description,price) VALUES(103,3,'Stupid dateTime object',30000);
INSERT INTO rooms(id,room_type,room_description,price) VALUES(104,2,'Deez Nuts',5000);


CREATE TABLE rooms(
	id int PRIMARY KEY,
	room_type INT,
	room_description TEXT,
	price INT,
	CONSTRAINT FK_rooms_roomType 
		FOREIGN KEY(room_type) 
		REFERENCES room_types(id) 
		ON DELETE CASCADE
);
SELECT * FROM rooms;

ALTER TABLE rooms
ADD CONSTRAINT df_rooms_img
DEFAULT null FOR img;


SELECT * FROM bookings;


INSERT INTO bookings(room_id,cus_id,check_in,check_out) 
VALUES(102,'U_001','07/14/2022','07/18/2022');


INSERT INTO bookings(room_id,cus_id,check_in,check_out) 
VALUES(103,'U_002','07/10/2022','07/19/2022');

INSERT INTO bookings(room_id,cus_id,check_in,check_out) 
VALUES(104,'U_003','07/06/2022','07/15/2022');

INSERT INTO bookings(room_id,cus_id,check_in,check_out) 
VALUES(104,'U_003','07/16/2022','07/17/2022');


INSERT INTO bookings(room_id,cus_id,check_in,check_out) 
VALUES(102,'U_003','07/05/2022','07/10/2022');

INSERT INTO bookings(room_id,cus_id,check_in,check_out) 
VALUES(103,'U_003','20220715','20220717');

CREATE TABLE bookings(
	id int PRIMARY KEY IDENTITY,
	room_id INT,
	cus_id VARCHAR(40),
	check_in DATE,
	check_out DATE,
	CONSTRAINT FK_bookings_roomId 
		FOREIGN KEY(room_id)
		REFERENCES rooms(id)  
		ON DELETE CASCADE,
	CONSTRAINT FK_bookings_cusId 
		FOREIGN KEY(cus_id) 
		REFERENCES customers(id)  
		ON DELETE CASCADE
);


CREATE TABLE reviews(
	id int NOT NULL PRIMARY KEY IDENTITY,
	cus_id VARCHAR(40),
	reviewed_date DATETIME,
	review TEXT
	CONSTRAINT FK_reviews_cusId 
		FOREIGN KEY(cus_id)
		REFERENCES customers(id)
		ON DELETE CASCADE
);

SELECT * FROM bookings;

--DECLARE @checkIn DATE = '2022/07/25';
--DECLARE @checkOut DATE = '2022/07/30';
	SELECT DISTINCT room_id 
	FROM bookings
	WHERE (
			
				( 
					(check_in BETWEEN @checkIn AND @checkOut) 
						OR 
					(check_out BETWEEN @checkIn AND @checkOut)
				)
				OR
				(
					(check_in < @checkIn)
					AND 
					(check_out > @checkOut) 
				)

	)




SELECT * 
FROM rooms 
WHERE id  NOT IN (
	SELECT DISTINCT bookings.room_id 
	FROM bookings
	WHERE (
			
				(check_in BETWEEN @checkIn AND @checkOut) 
				OR 
				(check_out BETWEEN @checkIn AND @checkOut)
				OR
				(
					(check_in < @checkIn)
					AND 
					(check_out > @checkOut) 
				)
	)
)

DECLARE @checkIn VARCHAR(20) = '20220711';
DECLARE @checkOut VARCHAR(20) = '20220712';

-- Simplified version
SELECT *
FROM rooms AS  r
WHERE NOT EXISTS 
    (
        SELECT 1
        FROM bookings AS b
        WHERE b.check_in <= @checkOut 
        AND b.check_out >= @checkin
        AND b.room_id = r.id
    )  

SELECT * 
FROM rooms 
WHERE id  NOT IN (
	SELECT DISTINCT bookings.room_id 
	FROM bookings
	WHERE (
			
				(check_in BETWEEN CAST(@checkIn as DATE) AND CAST(@checkOut as DATE)) 
				OR 
				(check_out BETWEEN CAST(@checkIn as DATE) AND  CAST(@checkOut as DATE))
				OR
				(
					(check_in < CAST(@checkIn as DATE))
					AND 
					(check_out >  CAST(@checkOut as DATE)) 
				)
	)
)


   

SELECT * FROM rooms;

SELECT * FROM bookings;



