
Create database Restaurant_POS_system;

Use Restaurant_POS_system;


-- Tables creations
CREATE TABLE customers (
	id INT PRIMARY KEY IDENTITY,
	first_name VARCHAR(30),
	last_name VARCHAR(30),
	username VARCHAR(40),
	pwd VARCHAR(50),
	email VARCHAR(50)
);

CREATE TABLE administrators (
	id INT PRIMARY KEY IDENTITY,
	username VARCHAR(40),
	pwd VARCHAR(50)
);

DROP TABLE table_types;
CREATE TABLE [table_types](
	id INT PRIMARY KEY,
	category VARCHAR(50)
);

DROP TABLE tables;
CREATE TABLE [tables](
	id INT PRIMARY KEY,
	description text,
	[table_types] INT,
	CONSTRAINT FK_tables_tableTypeId
	FOREIGN KEY([table_types]) REFERENCES [table_types](id) 
	ON DELETE CASCADE
);

DROP TABLE bookings;
CREATE TABLE bookings(
	id INT PRIMARY KEY,
	customer_id INT,
	table_id INT,
	booked_date DATE,
	check_in TIME,
	check_out TIME,
	CONSTRAINT FK_bookings_cusId
	FOREIGN KEY(customer_id)
	REFERENCES customers(id)
	ON DELETE CASCADE,
	CONSTRAINT FK_bookings_tableId
	FOREIGN KEY(table_id)
	REFERENCES tables(id)
	ON DELETE CASCADE
);

ALTER TABLE bookings ADD ph_number VARCHAR(25);

-- Data insertions
INSERT INTO administrators(username,pwd) VALUES('admin','admin123');

INSERT INTO [table_types](id,category) VALUES(1,'Family table');
INSERT INTO [table_types](id,category) VALUES(2,'Couple table');
INSERT INTO [tables](id,table_types,description) VALUES(1,1,'Really large table for family :)');
INSERT INTO [tables](id,table_types,description) VALUES(2,2,'SO romantic...');

INSERT INTO bookings(id,customer_id,table_id,check_in,check_out,booked_date) 
VALUES(1,2,1,'17:00:00','19:00:00','2022-06-21');

SELECT * FROM bookings;

SELECT * FROM bookings
WHERE CAST(check_in as time) BETWEEN '17:00:00' and '18:00:00';



-- Data queries
SELECT * FROM administrators;
SELECT * FROM customers;

SELECT * FROM tables;
SELECT * FROM table_types;

TRUNCATE TABLE bookings;
TRUNCATE TABLE tables;
DROP TABLE tables;

CREATE TABLE bookings(
	id INT PRIMARY KEY,
	customer_id INT,
	table_id INT,
	booked_date DATE,
	check_in TIME,
	check_out TIME,
	CONSTRAINT FK_bookings_cusId
	FOREIGN KEY(customer_id)
	REFERENCES customers(id)
	ON DELETE CASCADE,
	CONSTRAINT FK_bookings_tableId
	FOREIGN KEY(table_id)
	REFERENCES tables(id)
	ON DELETE CASCADE
);

ALTER TABLE bookings ADD ph_number VARCHAR(25);

INSERT INTO bookings(id,customer_id,table_id,booked_date,check_in,check_out)
VALUES(1,1,1,'2022-06-21','17:00:00','19:00:00');

INSERT INTO bookings(id,customer_id,table_id,booked_date,check_in,check_out)
VALUES(2,3,2,'2022-07-05','16:00:00','18:00:00');

SELECT * FROM bookings;