/*
Deployment script for WishlistDB
*/

CREATE TABLE [dbo].[myUser] (
    [Id]       INT           NOT NULL,
    [Username] NVARCHAR (50) NOT NULL,
    [Password] NVARCHAR (50) NOT NULL,
    [Role]     NCHAR (10)    NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
