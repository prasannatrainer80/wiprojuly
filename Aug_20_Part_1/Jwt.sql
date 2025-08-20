CREATE DATABASE AuthDb
GO

USE AuthDb
GO

CREATE TABLE Users
(
    Id INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(255) NOT NULL
)
GO

INSERT INTO Users (Username, Password)
VALUES ('testuser', 'password123')
GO

