CREATE TABLE [dbo].[UsersFoodTables] (
    [UserID]      INT  NOT NULL,
    [FoodTableID] INT  NOT NULL,
    [Date]        DATE NOT NULL,
    CONSTRAINT [PK_UsersFoodTables] PRIMARY KEY CLUSTERED ([UserID] ASC, [FoodTableID] ASC, [Date] ASC),
    CONSTRAINT [FK_UsersFoodTables_FoodTables] FOREIGN KEY ([FoodTableID]) REFERENCES [dbo].[FoodTables] ([ID]),
    CONSTRAINT [FK_UsersFoodTables_Users] FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([ID])
);

