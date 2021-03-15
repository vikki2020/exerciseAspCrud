CREATE TABLE [dbo].[UserReg] (
    [UserId]         INT            IDENTITY (1, 1) NOT NULL,
    [UserName]       NVARCHAR (50)  NULL,
    [Age]            INT            NULL,
    [Email]          NVARCHAR (100) NULL,
    [UserPassword]   NVARCHAR (100) NULL,
    [UserRePassword] NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);

