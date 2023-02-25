
CREATE TABLE Products (
	Id INT PRIMARY KEY IDENTITY,
    Name varchar(30)
)

CREATE TABLE Categories (
	Id INT PRIMARY KEY IDENTITY,
    Name varchar(30)
)

CREATE TABLE Products_Classification (
	Id INT PRIMARY KEY IDENTITY,
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id)
)

INSERT INTO Products
VALUES 
	('Product1'), 
	('Product2'), 
	('Product3'),
	('Product4'),
	('Product5'),
	('Product6'),
	('Product7'),
	('Product8'),
	('Product9')

INSERT INTO Categories 
VALUES 
	('Category1'), 
	('Category2'), 
	('Category3')

INSERT INTO Products_Classification
	(ProductId,
	CategoryId)
VALUES 
	(1, 1),
	(2, 1),
	(3, 1),
	(6, 2),
	(8, 2),
	(4, 3),
	(9, 3),
	(5, 3)


SELECT *
FROM Products_Classification RIGHT JOIN Products on Products_Classification.ProductId = Products.Id