CREATE PROCEDURE sproc_tblAddress_FilterByAddressNo
	@AddressNo int

	AS
	select * from tblAddress where AddressNo=@AddressNo

RETURN 0

CREATE TABLE [dbo].[tblAddress] (
	[AddressNo] INT IDENTITY (1, 1) NOT NULL,
	[HouseNo] VARCHAR (6) NOT NULL,
	[Street] VARCHAR (50) NOT NULL,
	[Town] VARCHAR (50) NOT NULL,
	[PostCode] VARCHAR (9) NOT NULL,
	[CountyNo] INT NOT NULL,
	[DateAdded] DATE NOT NULL,
	[Active] BIT NULL,
	PRIMARY KEY CLUSTERED ([AddressNo] ASC)
);

CREATE PROCEDURE sproc_tblAddress_SelectAll AS
	select * from tblAddress
RETURN 0


CREATE PROCEDURE sproc_tblAddress_Insert
	@HouseNo varchar (6),
	@Street varchar (50),
	@Town varchar (50),
	@PostCode varchar (9),
	@CountyNo int,
	@DateAdded date,
	@Active bit

	AS

	INSERT INTO tblAddress (HouseNo, Street, Town, PostCode, CountyNo, DateAdded, Active)
	values (@HouseNo, @Street, @Town, @PostCode,@CountyNo, @DateAdded, @Active)

	return @@Identity


CREATE PROCEDURE [dbo].sproc_tblAddress_Delete
	@AddressNo int

	AS
	delete from tblAddress where AddressNo = @AddressNo;

CREATE PROCEDURE sproc_tblAddress_Update
	@AddressNo int,
	@HouseNo varchar (6),
	@Street varchar (50),
	@Town varchar (50),
	@PostCode varchar (9),
	@CountyNo int,
	@DateAdded date,
	@Active bit

	AS
	update tblAddress
	set HouseNo=@HouseNo,
		Street=@Street,
		Town=@Town,
		PostCode=@PostCode,
		CountyNo=@CountyNo,
		DateAdded=@DateAdded,
		Active=@Active

	where AddressNo=@AddressNo


CREATE PROCEDURE [dbo].sproc_tblAddress_FilterByPostCode
	@PostCode varchar(9)

	AS
	select * from tblAddress where PostCode like @PostCode+'%';