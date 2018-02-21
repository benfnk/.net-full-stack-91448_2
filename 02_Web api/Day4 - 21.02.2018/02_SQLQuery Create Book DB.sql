USE master
GO
CREATE DATABASE BookStore
GO
USE BookStore
GO
CREATE TABLE [dbo].[Authors] (
    [AuthorID]   INT           IDENTITY (1, 1) NOT NULL,
    [AuthorAge] INT  NOT NULL,
    [AuthorName] NVARCHAR (20) NOT  NULL UNIQUE, 
    [AuthorImage] NVARCHAR (MAX) NOT  NULL, 
    CONSTRAINT [PK_Author] PRIMARY KEY ([AuthorID])
);


CREATE TABLE [dbo].[Books] (
    [BookID]     INT           IDENTITY (1, 1) NOT NULL,
    [BookName]   NVARCHAR (15) NOT NULL UNIQUE,
	[BookPrice]  DECIMAL           NOT NULL,
    [AuthorID]   INT           NOT NULL,
    CONSTRAINT [PK_Books] PRIMARY KEY ([BookID]),
    CONSTRAINT [FK_Books_ToTable] FOREIGN KEY ([AuthorID]) REFERENCES [dbo].[Authors]([AuthorID])

);


