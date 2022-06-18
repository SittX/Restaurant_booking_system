Create database Restaurant_POS_system;

Use Restaurant_POS_system;

Create TABLE customer (
	id INT PRIMARY KEY IDENTITY,
	first_name VARCHAR(30),
	last_name VARCHAR(30),
	username VARCHAR(40),
	pwd VARCHAR(50),
	email VARCHAR(50)
);

SELECT * FROM customer;

