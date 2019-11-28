CREATE TABLE [dbo].[Tables] (
    [TableId]   NVARCHAR(MAX)            IDENTITY (1, 1) NOT NULL,
    [TableName] NVARCHAR (MAX) NULL,
    [Status]    BIT            NOT NULL,
    CONSTRAINT [PK_Tables] PRIMARY KEY CLUSTERED ([TableId] ASC)
);

