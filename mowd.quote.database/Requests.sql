CREATE TABLE [dbo].[Requests]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newid(), 
    [Address] NVARCHAR(255) NOT NULL, 
    [City] NVARCHAR(255) NOT NULL, 
    [State] NVARCHAR(255) NOT NULL, 
    [PostalCode] NVARCHAR(50) NOT NULL, 
    [Phone] NVARCHAR(50) NOT NULL, 
    [Mow] BIT NOT NULL, 
    [Edge] BIT NOT NULL, 
    [Blow] BIT NOT NULL, 
    [Pets] BIT NOT NULL, 
    [SpecialInstructions] NVARCHAR(255) NULL, 
    [NeedBy] DATE NULL, 
    [NoEarlierThan] TIME NULL, 
    [NoLaterThan] TIME NULL, 
    [FK_CreatedByUserId] UNIQUEIDENTIFIER NOT NULL
)
