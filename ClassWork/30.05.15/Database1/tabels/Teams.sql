﻿CREATE TABLE [dbo].[Teams]
(
	[Id] UNIQUEIDENTIFIER NOT NULL  DEFAULT NEWID(), 
    [Name] NVARCHAR(50) NOT NULL, 
    [Wins] SMALLINT NOT NULL DEFAULT 0, 
    [Losses] SMALLINT NOT NULL DEFAULT 0, 
    [Draws] SMALLINT NOT NULL DEFAULT 0,
	[PictureUrl] NVARCHAR(MAX) NULL, 
    CONSTRAINT [PK_Teams] PRIMARY KEY ([Id]), 
    CONSTRAINT [CK_Teams_Wins] CHECK (Wins >= 0), 
    CONSTRAINT [CK_Teams_Loses] CHECK ([Losses] >= 0), 
    CONSTRAINT [CK_Teams_Draws] CHECK (Draws >= 0)
)
