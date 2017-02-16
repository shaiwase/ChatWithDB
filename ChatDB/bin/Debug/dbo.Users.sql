CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [NickName] NCHAR(10) NOT NULL, 
    [LastConnectionDate] DATETIME NOT NULL, 
    [IsConnected] BIT NOT NULL
)
