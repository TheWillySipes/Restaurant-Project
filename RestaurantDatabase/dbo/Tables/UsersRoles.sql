CREATE TABLE [dbo].[UsersRoles] (
    [UserID] INT NOT NULL,
    [RoleID] INT NOT NULL,
    [ID]     INT IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_UsersRoles] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_UsersRoles_Roles] FOREIGN KEY ([RoleID]) REFERENCES [dbo].[Roles] ([ID]),
    CONSTRAINT [FK_UsersRoles_Users] FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([ID])
);

