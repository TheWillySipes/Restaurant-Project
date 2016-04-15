CREATE TABLE [dbo].[TicketsMenuItems] (
    [TicketID]       INT             NOT NULL,
    [MenuItemID]     INT             NOT NULL,
    [PricePaid]      DECIMAL (18, 2) NOT NULL,
    [Returned]       BIT             CONSTRAINT [DF_TicketsMenuItems_Returned] DEFAULT ((0)) NOT NULL,
    [ReturnReason]   NVARCHAR (250)  NULL,
    [ManagerComped]  BIT             CONSTRAINT [DF_TicketsMenuItems_ManagerComped] DEFAULT ((0)) NOT NULL,
    [CompedByUserID] INT             NULL,
    [ID]             INT             IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_TicketsMenuItems] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_TicketsMenuItems_MenuItems] FOREIGN KEY ([MenuItemID]) REFERENCES [dbo].[MenuItems] ([ID]),
    CONSTRAINT [FK_TicketsMenuItems_Tickets] FOREIGN KEY ([TicketID]) REFERENCES [dbo].[Tickets] ([ID]),
    CONSTRAINT [FK_TicketsMenuItems_Users] FOREIGN KEY ([CompedByUserID]) REFERENCES [dbo].[Users] ([ID])
);

