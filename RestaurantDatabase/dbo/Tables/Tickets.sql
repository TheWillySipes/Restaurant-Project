CREATE TABLE [dbo].[Tickets] (
    [ID]            INT      IDENTITY (1, 1) NOT NULL,
    [TableID]       INT      NOT NULL,
    [TimePlaced]    DATETIME NOT NULL,
    [TimeCompleted] DATETIME NULL,
    CONSTRAINT [PK_Tickets] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Tickets_FoodTables] FOREIGN KEY ([TableID]) REFERENCES [dbo].[FoodTables] ([ID])
);

