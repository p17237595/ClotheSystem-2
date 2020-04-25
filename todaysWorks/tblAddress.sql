CREATE TABLE [dbo].[tblAddress] (
	[AddressNo] INT IDENTITY(1,1) NOT NULL,
	[HouseNo] VARCHAR (6) NOT NULL,
	[Street] VARCHAR (50) NOT NULL,
	[Town] VARCHAR (50) NOT NULL,
	[PostCode] VARCHAR (50) NOT NULL,
	[CountyNo] INT NOT NULL,
	[DateAdded] DATE NOT NULL,
	[Active] BIT NULL,
	PRIMARY KEY CLUSTERED ([AddressNo] ASC)
);