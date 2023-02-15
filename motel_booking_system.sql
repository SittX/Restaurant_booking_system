CREATE DATABASE motel_bookings_system_db;
USE motel_bookings_system_db;


-- Database table schemas
CREATE TABLE customers(
	id VARCHAR(40) PRIMARY KEY,
	username VARCHAR(30) UNIQUE NOT NULL,
	acc_password VARCHAR(255) UNIQUE NOT NULL,
	email VARCHAR(50) UNIQUE NOT NULL,
	ph_number VARCHAR(40) UNIQUE
);

CREATE TABLE administrators(
	id VARCHAR(40) NOT NULL PRIMARY KEY,
	username VARCHAR(30) UNIQUE NOT NULL,
	acc_password VARCHAR(255) UNIQUE NOT NULL,
	permission VARCHAR(25) NOT NULL DEFAULT 'ReadOnly'
);


CREATE TABLE room_types(
	id int PRIMARY KEY IDENTITY,
	type_description VARCHAR(40) UNIQUE NOT NULL,
	price INT
);

CREATE TABLE rooms(
	id int PRIMARY KEY,
	room_type INT,
	room_description TEXT,
	img TEXT DEFAULT null,
	CONSTRAINT FK_rooms_roomType 
		FOREIGN KEY(room_type) 
		REFERENCES room_types(id) 
		ON DELETE CASCADE
);

CREATE TABLE bookings(
	id int PRIMARY KEY IDENTITY,
	room_id INT,
	cus_id VARCHAR(40),
	check_in DATE,
	check_out DATE,
	total_price INT,
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
	review TEXT
	CONSTRAINT FK_reviews_cusId 
		FOREIGN KEY(cus_id)
		REFERENCES customers(id)
		ON DELETE CASCADE
);


-- Database queries

DECLARE @checkIn VARCHAR(20) = '20220711';
DECLARE @checkOut VARCHAR(20) = '20220712';
DECLARE @roomType INT = 4;

-- Available room query
	SELECT DISTINCT room_type
	FROM rooms AS  r
	WHERE NOT EXISTS 
		(
			SELECT 1
			FROM bookings AS b
			WHERE b.check_in <= @checkOut 
			AND b.check_out >= @checkin
			AND b.room_id = r.id
		) AND room_type = @roomType
	GROUP BY room_type


SELECT rooms.room_description,room_types.price
FROM room_types
INNER JOIN rooms
ON rooms.room_type = (
	SELECT DISTINCT room_type
	FROM rooms AS  r
	WHERE NOT EXISTS 
		(
			SELECT 1
			FROM bookings AS b
			WHERE b.check_in <= @checkOut 
			AND b.check_out >= @checkin
			AND b.room_id = r.id
		)
			AND room_type = @roomType
) AND room_types.id = (
	SELECT DISTINCT room_type
	FROM rooms AS  r
	WHERE NOT EXISTS 
		(
			SELECT 1
			FROM bookings AS b
			WHERE b.check_in <= @checkOut 
			AND b.check_out >= @checkin
			AND b.room_id = r.id
		)
			AND room_type = @roomType
)

SELECT * FROM room_types
LEFT JOIN rooms 
ON room_types.id = (
	SELECT DISTINCT room_type
	FROM rooms AS  r
	WHERE NOT EXISTS 
		(
			SELECT 1
			FROM bookings AS b
			WHERE b.check_in <= @checkOut 
			AND b.check_out >= @checkin
			AND b.room_id = r.id
		) AND room_type = @roomType
	);






