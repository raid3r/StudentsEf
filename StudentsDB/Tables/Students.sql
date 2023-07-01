﻿CREATE TABLE [dbo].[Students]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[FirstName] NVARCHAR(100) NOT NULL,
	[LastName]  NVARCHAR(100) NOT NULL,
	[Birthday] DATE NULL,
	[Course] INT NOT NULL,
	[GroupId] INT NOT NULL FOREIGN KEY (GroupId) REFERENCES Groups(Id)
)
