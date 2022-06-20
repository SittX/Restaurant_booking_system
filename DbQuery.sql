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


CREATE TABLE tableType(
	id INT PRIMARY KEY,
	category VARCHAR(50)
);

CREATE TABLE tables(
	id INT PRIMARY KEY,
	description text,
	tableType_Id INT,
	CONSTRAINT FK_tables_categoryId
	FOREIGN KEY(tableType_Id) REFERENCES tableType(id)
);


-- Data insertions
INSERT INTO administrators(username,pwd) VALUES('admin','admin123');


-- Data queries
SELECT * FROM administrators;
SELECT * FROM customers;



