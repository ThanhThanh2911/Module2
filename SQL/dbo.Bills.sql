CREATE TABLE [dbo].[Bills] (
    [BillId]      INT           IDENTITY (1, 1) NOT NULL,
    [TableId]     NVARCHAR(MAX)           NOT NULL,
    [TimePayment] DATETIME2 (7) NOT NULL,
    [Total]       INT           NOT NULL,
    [Status]      BIT           NOT NULL,
    CONSTRAINT [PK_Bills] PRIMARY KEY CLUSTERED ([BillId] ASC),
    CONSTRAINT [FK_Bills_Tables_TableId] FOREIGN KEY ([TableId]) REFERENCES [dbo].[Tables] ([TableId]) ON DELETE CASCADE
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Bills_TableId]
    ON [dbo].[Bills]([TableId] ASC);

