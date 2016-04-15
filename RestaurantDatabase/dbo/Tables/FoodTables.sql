CREATE TABLE [dbo].[FoodTables] (
    [ID]     INT            IDENTITY (1, 1) NOT NULL,
    [Status] INT            NOT NULL,
    [Info]   NVARCHAR (100) NULL,
    CONSTRAINT [PK_FoodTables] PRIMARY KEY CLUSTERED ([ID] ASC)
);

