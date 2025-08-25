create database carrental
go

use carrental
go

Create Table Vehicle
(
   vehicleID INT Primary Key IDENTITY(1,1),
   make varchar(30),
   model varchar(30),
   year int, 
   dailyRate numeric(9,2),
   status varchar(30) default 'AVAILABLE',
   passengerCapacity INT,
   engineCapacity varchar(30)
)
Go

insert into Vehicle values('Tata','Zxi',2022,1900,'AVAILABLE',4,'330cc')
GO

CREATE TABLE Users
(
    Id INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(255) NOT NULL
);

INSERT INTO Users (Username, Password)
VALUES ('testuser', 'password123');  

