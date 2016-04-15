CREATE TABLE [dbo].[MenuItems] (
    [ID]           INT             IDENTITY (1, 1) NOT NULL,
    [Title]        NVARCHAR (50)   NOT NULL,
    [Description]  NVARCHAR (250)  NULL,
    [CurrentPrice] DECIMAL (18, 2) NOT NULL,
    [Available]    BIT             NOT NULL,
    CONSTRAINT [PK_MenuItems] PRIMARY KEY CLUSTERED ([ID] ASC)
);

