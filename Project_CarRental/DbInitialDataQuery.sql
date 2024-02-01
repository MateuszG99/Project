use Project_CarRental
GO

--Default users:
INSERT INTO [AspNetUsers] VALUES
('a12ba6d6-a6fd-47e2-a3bb-d7f5d540e37a', 'admin@car2go.pl', 'ADMIN@CAR2GO.PL', 'admin@car2go.pl', 'ADMIN@CAR2GO.PL', 1, 'AQAAAAEAACcQAAAAEGE7VxdER5Ks/m6QZfji33FnT1y+rkeKJPwsSUt6pxymTj/k9VbKW5cbUjbPtLpD2A==', '3DNSJVSJRHH6LW4LGX77A4UBDBKCPYQR', '32d0d74b-3999-4375-8551-c844c709cf55', NULL, 0, 0, NULL, 1, 0),
('d2e27562-c84e-4d9b-b731-400926af8fa3', 'user@car2go.pl', 'USER@CAR2GO.PL', 'user@car2go.pl', 'USER@CAR2GO.PL', 0, 'AQAAAAEAACcQAAAAEDx+zB3dMXOehlTgBciUEGJ6sh2rnIrMPwxXOnxljhZPhryzN9BNYu391Zw32uarTA==', 'KHYBAYR6BRZQGKY5XAD3ZHYHOW7OCIWS', '3d305de8-1c06-4052-85b1-0d58ecaeb85c', NULL, 0, 0, NULL, 1, 0 )
GO

--Admin role:
INSERT INTO AspNetRoles VALUES 
('21c2ab38-492e-47d6-8229-45ab5507ea53', 'Admin', 'ADMIN', NULL)
GO

--Assign Admin to a role:
INSERT INTO AspNetUserRoles VALUES 
('a12ba6d6-a6fd-47e2-a3bb-d7f5d540e37a','21c2ab38-492e-47d6-8229-45ab5507ea53')
GO

--Initial CarModels:
SET IDENTITY_INSERT CarModels ON
INSERT INTO CarModels (CarModelId, Make, Model, FuelType) VALUES
(1, 'BMW', 'E90', 'Diesel'),
(2, 'Audi', 'A3', 'LPG'),
(3, 'Mercedes-Benz', 'C63 AMG', 'Benzyna'),
(4, 'Toyota', 'Corolla', 'LPG')
GO
SET IDENTITY_INSERT CarModels OFF

--Initial Locations
SET IDENTITY_INSERT Locations ON
INSERT INTO Locations (LocationId, City, Adress, TelephoneNumber) VALUES
(1, 'Wroc³aw', 'Górników 4', '123-456-789'),
(2, 'Opole', 'Kosynierów 14', '123-456-789'),
(3, 'Kraków', 'Go³ebia 2', '123-456-789'),
(4, 'Gdañsk', 'Stoczniowców 4', '123-456-789')
GO
SET IDENTITY_INSERT Locations OFF


--initial Customers
SET IDENTITY_INSERT Customers ON
INSERT INTO Customers (CustomerId, FirstName, LastName, PESEL) VALUES
(1, 'Jan', 'Nowak', '12345678901'),
(2, 'Kamil', 'Zdun', '72957385937'),
(3, 'Pawe³', 'Kawalec', '99629573357'),
(4, 'Janusz', 'Nosacz', '91629574357')
GO
SET IDENTITY_INSERT Customers OFF


--initial Cars
SET IDENTITY_INSERT Cars ON
INSERT INTO Cars (CarId, RegisterNumber, CarModelId, LocationId, CustomerId) VALUES
(1, 'KR12345', 3, 2, NULL),
(2, 'W0BEEMA', 1, 1, 3),
(3, 'WR98765', 3, 2, NULL),
(4, 'KRA44654', 2, 3, 1),
(5, 'WR57284', 4, 4, 4)
GO
SET IDENTITY_INSERT Cars OFF

GO