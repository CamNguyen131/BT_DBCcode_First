CREATE DATABASE DBCodeFirst
GO

USE DBCodeFirst
GO

CREATE TABLE Students (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Age INT
)
GO

INSERT INTO Students(Name, Age)
VALUES 
(N'Nguyen Van A', 20),
(N'Tran Thi B', 21)