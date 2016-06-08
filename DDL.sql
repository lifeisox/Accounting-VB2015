-- Create Database -----------------------------------------------------------------
IF NOT EXISTS ( SELECT * FROM sys.databases WHERE name = 'Church' )		CREATE DATABASE Church
	COLLATE Korean_Wansung_CI_AS
GO

USE Church;
GO

-- Drop Tables ---------------------------------------------------------------------
IF EXISTS ( SELECT * FROM sys.tables WHERE name = 'Tbl_SlipItem' )		DROP TABLE Tbl_SlipItem
IF EXISTS ( SELECT * FROM sys.tables WHERE name = 'Tbl_Slip' )			DROP TABLE Tbl_Slip
IF EXISTS ( SELECT * FROM sys.tables WHERE name = 'Tbl_Total' )			DROP TABLE Tbl_Total
IF EXISTS ( SELECT * FROM sys.tables WHERE name = 'Tbl_Account' )		DROP TABLE Tbl_Account
IF EXISTS ( SELECT * FROM sys.tables WHERE name = 'Tbl_Book' )			DROP TABLE Tbl_Book
IF EXISTS ( SELECT * FROM sys.tables WHERE name = 'Tbl_Dedicator' )		DROP TABLE Tbl_Dedicator
IF EXISTS ( SELECT * FROM sys.tables WHERE name = 'Tbl_Member' )		DROP TABLE Tbl_Member
IF EXISTS ( SELECT * FROM sys.tables WHERE name = 'Tbl_PostalArea' )	DROP TABLE Tbl_PostalArea
IF EXISTS ( SELECT * FROM sys.tables WHERE name = 'Tbl_Duty' )			DROP TABLE Tbl_Duty
IF EXISTS ( SELECT * FROM sys.tables WHERE name = 'Tbl_Education' )		DROP TABLE Tbl_Education
IF EXISTS ( SELECT * FROM sys.tables WHERE name = 'Tbl_Province' )		DROP TABLE Tbl_Province
GO

-- Create PostalCode Table ---------------------------------------------------------------
/* CREATE TABLE IF NOT EXISTS PostalTbl (
 	PostalID			Int				NOT NULL AUTO_INCREMENT, 
 	PostalCode			Char(6)			NOT NULL, INDEX IX_PostalID ( PostalCode ),
    LotNumber			Int				NOT NULL DEFAULT 0, 
    Street				VarChar(70)		NULL,
    City				VarChar(50)		NOT NULL,
    ProvinceCode		Char(2)			NOT NULL,
    Latitude			Double			NOT NULL DEFAULT 0,
    Longitude			Double			NOT NULL DEFAULT 0,
    Filler1				VarChar(100)	NULL,
    Filler2				VarChar(100)	NULL,
    Filler3				VarChar(100)	NULL,
    CONSTRAINT			PK_PostalID		PRIMARY KEY	( PostalID )
);

ALTER TABLE PostalTbl ADD INDEX IX_LotNumber ( LotNumber );
ALTER TABLE PostalTbl ADD INDEX IX_City ( City );
ALTER TABLE PostalTbl ADD INDEX IX_Street ( Street );
ALTER TABLE PostalTbl ADD CONSTRAINT FK_Province_ FOREIGN KEY ( ProvinceCode ) REFERENCES ProvinceTbl ( ProvinceCode );
*/
-- Create ProvinceTbl Table -----------------------------------------------------------
IF NOT EXISTS ( SELECT [name] FROM sys.tables WHERE [name] = 'Tbl_Province' )	CREATE TABLE Tbl_Province (
	ProvinceCode		Char(2)			NOT NULL UNIQUE,
    ProvinceName		Varchar(25)		NOT NULL,
    Capital				Varchar(15)		NOT NULL,
    CONSTRAINT	PK_Province		PRIMARY KEY CLUSTERED ( ProvinceCode )
)
GO

INSERT INTO Tbl_Province ( ProvinceCode, ProvinceName, Capital ) VALUES 
	( 'ON', 'Ontario', 'Toronto' ),			( 'QC', 'Quebec', 'Quebec City' ),
    ( 'NS', 'Nova Scotia', 'Halifax' ),		( 'NB', 'New Brunswick', 'Fredericton' ),
    ( 'MB', 'Manitoba', 'Winnipeg' ),		( 'BC', 'British Columbia', 'Victoria' ),
    ( 'SK', 'Saskatchewan', 'Regina' ),		( 'PE', 'Prince Edward Island', 'Charlottetown' ),			
    ( 'AB', 'Alberta', 'Admonton' ),		( 'NL', 'Newfoundland and Labrador', 'St. John''s' ),
    ( 'YT', 'Yukon', '	Whitehorse' ),		( 'NT', 'Northwest Territories', 'Yellowknife' ),
    ( 'NU', 'Nunavut', 'Iqaluit' )
GO

-- Create PostalAreaTbl Table ---------------------------------------------------------------
IF NOT EXISTS ( SELECT [name] FROM sys.tables WHERE [name] = 'Tbl_PostalArea' )	CREATE TABLE Tbl_PostalArea (
	PostalAreaCode		Char(3)			NOT NULL UNIQUE,
    PlaceName			Varchar(162)	NOT NULL,
    ProvinceCode		Char(2)			NOT NULL,
    Latitude			Float(53)		NOT NULL DEFAULT 0,		-- The synonym for double precision is float(53) 
    Longitude			Float(53)		NOT NULL DEFAULT 0,		-- Where 53 is the number of bits that are used to store the mantissa of the float number in scientific notation
    CONSTRAINT	PK_PostalArea	PRIMARY KEY CLUSTERED ( PostalAreaCode ),
    CONSTRAINT	FK_Province_PA	FOREIGN KEY ( ProvinceCode )	REFERENCES	Tbl_Province	( ProvinceCode )
)
GO

BULK INSERT Tbl_PostalArea FROM 'D:\ca_postal_codes.csv' WITH
(
	FIELDTERMINATOR = '","',
	FIRSTROW = 2,
	ROWTERMINATOR = '\n'
)
GO
    
-- Create DutyTbl Table ---------------------------------------------------------------
IF NOT EXISTS ( SELECT [name] FROM sys.tables WHERE [name] = 'Tbl_Duty' )	CREATE TABLE Tbl_Duty (
	DutyCode			Char(2)			NOT NULL UNIQUE,
    DutyName			Varchar(30)		NOT NULL,
    LastUpdate			SmallDateTime	NOT NULL DEFAULT GETDATE(),
    CONSTRAINT			PK_Duty			PRIMARY KEY CLUSTERED ( DutyCode )
)
GO

CREATE TRIGGER Tg_Duty_Update ON Tbl_Duty
AFTER UPDATE 
AS
  UPDATE Tbl_Duty SET LastUpdate = GETDATE()
	FROM Inserted i
	WHERE Tbl_Duty.DutyCode = i.DutyCode
GO

INSERT INTO Tbl_Duty ( DutyCode, DutyName ) VALUES 
	( '01', 'Senior Pastor' ),		( '02', 'Assistant Pastor' ),		( '03', 'Educatonal Pastor' ),    	
    ( '05', 'Pastor' ),			    ( '06', 'License Pastor' ),			( '07', 'Evangelist' ),				
    ( '09', 'Missionary' ),
    ( '11', 'Elder' ),				( '12', 'Senior Deacon' ),	    	( '21', 'Deacon(Deaconess)' ),
    ( '99', 'Layman' )
GO
    
-- Create Tbl_Education Table ---------------------------------------------------------------
IF NOT EXISTS ( SELECT [name] FROM sys.tables WHERE [name] = 'Tbl_Education' )	CREATE TABLE Tbl_Education (
	EducationCode		Char(2)			NOT NULL UNIQUE,
    EducationName		Varchar(50)		NOT NULL,
    LastUpdate			SmallDateTime	NOT NULL DEFAULT GETDATE(),
    CONSTRAINT			PK_Education	PRIMARY KEY		( EducationCode )
)
GO

CREATE TRIGGER Tg_Education_Update ON Tbl_Education
AFTER UPDATE 
AS
  UPDATE Tbl_Education SET LastUpdate = GETDATE()
	FROM Inserted i
	WHERE Tbl_Education.EducationCode = i.EducationCode
GO

INSERT INTO Tbl_Education ( EducationCode, EducationName ) VALUES 
	( '01', 'Adult School' ),						( '11', 'English Adult Ministry (Mosaic)' ),		
    ( '21', 'Young Adult Ministry (Bahurim)' ),    	( '31', 'Youth Ministry' ),			    
    ( '91', 'Sunday School (Philoi)' ),				( '92', 'Sunday School (Ainos)' )
GO
    
-- Create Tbl_Member Table -------------------------------------------------------------
IF NOT EXISTS ( SELECT [name] FROM sys.tables WHERE [name] = 'Tbl_Member' )	CREATE TABLE Tbl_Member (
	MemberCode			Char(5)			NOT NULL UNIQUE,
	KoreanName 			Varchar(20) 	NULL,
    EnglishName			Varchar(40)		NOT NULL,
    Sex					Char(1)			NOT NULL DEFAULT 'M', 	-- M: Male, F: Female
    EducationCode		Char(2)			NOT NULL,
    HouseHolderCode		Char(5)			NOT NULL,				-- MemberCode
    Phone1Kind			Varchar(20)		NULL,
    Phone1No			Varchar(20)		NULL,
    Phone2Kind			Varchar(20)		NULL,
    Phone2No			Varchar(20)		NULL,
    Phone3Kind			Varchar(20)		NULL,
    Phone3No			Varchar(20)		NULL,
    Email				Varchar(70)		NULL,
    PostalCode			Char(6)			NOT NULL,
    Address				Varchar(70)		NULL,
    City				Varchar(30)		NULL,
    ProvinceCode		Char(2)			NOT NULL DEFAULT 'ON',
    DutyCode			Char(2)			NOT NULL,
    IsDeleted			Char(1)			NOT NULL DEFAULT 'N',	-- Y: Deleted
    Remark				Varchar(255)	NULL,
    LastUpdate			SmallDateTime	NOT NULL DEFAULT GETDATE(),
	CONSTRAINT 	PK_Member 		PRIMARY KEY ( MemberCode ),
    CONSTRAINT	FK_Education	FOREIGN KEY	( EducationCode )	REFERENCES	Tbl_Education ( EducationCode ),
    CONSTRAINT	FK_HouseHolder	FOREIGN	KEY	( HouseHolderCode )		REFERENCES	Tbl_Member ( MemberCode ),
    CONSTRAINT	FK_Province		FOREIGN KEY	( ProvinceCode )	REFERENCES	Tbl_Province ( ProvinceCode ),
    CONSTRAINT	FK_Duty			FOREIGN KEY ( DutyCode )		REFERENCES	Tbl_Duty ( DutyCode )    
)
GO

CREATE TRIGGER Tg_Member_Update ON Tbl_Member
AFTER UPDATE 
AS
BEGIN
  UPDATE Tbl_Member SET LastUpdate = GETDATE()
	FROM Inserted i
	WHERE Tbl_Member.MemberCode = i.MemberCode
END
GO

-- Create Tbl_Dedicator Table ----------------------------------------------------------
IF NOT EXISTS ( SELECT [name] FROM sys.tables WHERE [name] = 'Tbl_Dedicator' )	CREATE TABLE Tbl_Dedicator (
	DedicatorYear		Char(4)			NOT NULL,
	DedicatorCode		Char(3)			NOT NULL,
	MemberCode 			Char(5)			NOT NULL,
    LastUpdate			SmallDateTime	NOT NULL DEFAULT GETDATE(),
	CONSTRAINT 	PK_Dedicator	PRIMARY KEY ( DedicatorYear, DedicatorCode ),
    CONSTRAINT	FK_MemberDedi	FOREIGN KEY ( MemberCode )		REFERENCES	Tbl_Member ( MemberCode )
)
GO

CREATE TRIGGER Tg_Dedicator_Update ON Tbl_Dedicator
AFTER UPDATE 
AS
  UPDATE Tbl_Dedicator SET LastUpdate = GETDATE()
	FROM Inserted i
	WHERE Tbl_Dedicator.DedicatorYear = i.DedicatorYear AND Tbl_Dedicator.DedicatorCode = i.DedicatorCode
GO

-- Create Tbl_Book Table ------------------------------------------------------------
IF NOT EXISTS ( SELECT [name] FROM sys.tables WHERE [name] = 'Tbl_Book' )	CREATE TABLE Tbl_Book (
	BookYear			Char(4)			NOT NULL,
	BookCode			Char(4)			NOT NULL,	-- [9999] Cash Book
    BookName			Varchar(50)		NOT NULL,
    BookNameKr			Varchar(50)		NOT NULL,
    ForwardAmount		Decimal(12, 2)	NOT NULL DEFAULT 0,
    LastUpdate			SmallDateTime	NOT NULL DEFAULT GETDATE(),
	CONSTRAINT 	PK_Book			PRIMARY KEY ( BookYear, BookCode )
)
GO

CREATE TRIGGER Tg_Book_Update ON Tbl_Book
AFTER UPDATE 
AS
  UPDATE Tbl_Book SET LastUpdate = GETDATE()
	FROM Inserted i
	WHERE Tbl_Book.BookYear = i.BookYear AND Tbl_Book.BookCode = i.BookCode
GO

INSERT INTO Tbl_Book ( BookYear, BookCode, BookName, BookNameKr, ForwardAmount ) VALUES 
	( '2016', '0001', 'Cash Book', '현금출납장', 0 );
    
-- Create Tbl_Account Table ------------------------------------------------------------
IF NOT EXISTS ( SELECT [name] FROM sys.tables WHERE [name] = 'Tbl_Account' )	CREATE TABLE Tbl_Account (
	AccountYear			Char(4)			NOT NULL,
	AccountCode			Char(4)			NOT NULL,
	LastYearCode 		Char(4)			NOT NULL,
    Division			Char(1)			NOT NULL DEFAULT 'E',	-- [E]xpenditure, [I]ncome
    AccountName			Varchar(50)		NOT NULL,
    AccountNameKr		Varchar(50)		NOT NULL,
	Budget				Decimal(12, 2)	NOT NULL DEFAULT 0,
	Amount				Decimal(12, 2)	NOT NULL DEFAULT 0,
    IsComputed			Char(1)			NOT NULL DEFAULT 'N',	-- [Y]es, [N]o - Input Field
    ParentCode			Char(4)			NULL,	-- If this field exist, trigger computes automatically
    BookCode			Char(4)			NULL,	-- If this field no exist, there is not Book
    Remark				Varchar(80)		NULL,
    LastUpdate			SmallDateTime	NOT NULL DEFAULT GETDATE(),
	CONSTRAINT 	PK_Account	PRIMARY KEY ( AccountYear, AccountCode ),
    CONSTRAINT	FK_Book		FOREIGN KEY ( AccountYear, BookCode )	REFERENCES	Tbl_Book ( BookYear, BookCode )
)
GO

CREATE TRIGGER Tg_Account_All ON Tbl_Account
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
	DECLARE @accountYear Char(4), @accountCode Char(4), @parentCode Char(4) 
	DECLARE @budget Decimal(12, 2), @amount Decimal(12, 2)
	SET NOCOUNT ON;
	IF EXISTS(SELECT * FROM DELETED)
	BEGIN
		SELECT @accountYear = d.AccountYear, @accountCode = d.AccountCode, @parentCode = d.ParentCode
			FROM DELETED d;
		IF @parentCode IS NOT NULL  AND @parentCode <> ''
		BEGIN
			SELECT @budget = SUM(Budget), @amount = SUM(Amount)
				FROM Tbl_Account WHERE AccountYear = @accountYear AND ParentCode = @parentCode;
			UPDATE Tbl_Account SET Budget = @budget, Amount = @amount
			WHERE Tbl_Account.AccountYear = @accountYear AND Tbl_Account.AccountCode = @accountCode;
		END
	END

	IF EXISTS(SELECT * FROM INSERTED)
	BEGIN
		SELECT @accountYear = i.AccountYear, @accountCode = i.AccountCode, @parentCode = i.ParentCode
			FROM INSERTED i;
		IF @parentCode IS NOT NULL AND @parentCode <> ''
		BEGIN
			SELECT @budget = SUM(Budget), @amount = SUM(Amount)
				FROM Tbl_Account WHERE AccountYear = @accountYear AND ParentCode = @parentCode;
			UPDATE Tbl_Account SET Budget = @budget, Amount = @amount
			WHERE Tbl_Account.AccountYear = @accountYear AND Tbl_Account.AccountCode = @accountCode;
		END
	END
END
GO

CREATE TRIGGER Tg_Account_UpdateLastUpdate ON Tbl_Account
AFTER UPDATE 
AS
  UPDATE Tbl_Account SET LastUpdate = GETDATE()
	FROM Inserted i
	WHERE Tbl_Account.AccountYear = i.AccountYear AND Tbl_Account.AccountCode = i.AccountCode
GO

-- Create Tbl_Total Table --------------------------------------------------------------
IF NOT EXISTS ( SELECT [name] FROM sys.tables WHERE [name] = 'Tbl_Total' )	CREATE TABLE Tbl_Total (
	AccountYear			Char(4)			NOT NULL,
    AccountCode			Char(4)			NOT NULL,
    AccountMonth		Char(2)			NOT NULL,
    MemberCode			Char(5)			NOT NULL,
	CheckAmount			Decimal(12, 2)	NOT NULL DEFAULT 0,
    CashAmount			Decimal(12, 2)	NOT NULL DEFAULT 0,
    LastUpdate			SmallDateTime	NOT NULL DEFAULT GETDATE(),
	CONSTRAINT 	PK_Total	PRIMARY KEY ( AccountYear, AccountCode, AccountMonth, MemberCode ),
    CONSTRAINT	FK_Account	FOREIGN KEY ( AccountYear, AccountCode )	
							REFERENCES	Tbl_Account ( AccountYear, AccountCode ),
	CONSTRAINT	FK_MemTotal	FOREIGN KEY ( MemberCode )	REFERENCES	Tbl_Member ( MemberCode ),
    INDEX 		IX_MemTotal ( AccountYear, MemberCode, AccountCode, AccountMonth )
)
GO

CREATE TRIGGER Tg_Total_Update ON Tbl_Total
AFTER UPDATE 
AS
  UPDATE Tbl_Total SET LastUpdate = GETDATE()
	FROM Inserted i
	WHERE Tbl_Total.AccountYear = i.AccountYear AND Tbl_Total.AccountCode = i.AccountCode
		 AND Tbl_Total.AccountMonth = i.AccountMonth AND Tbl_Total.MemberCode = i.MemberCode
GO

-- Create Tbl_Slip Table ----------------------------------------------------------------
IF NOT EXISTS ( SELECT [name] FROM sys.tables WHERE [name] = 'Tbl_Slip' )	CREATE TABLE Tbl_Slip (
	SlipYear			Char(4)			NOT NULL,
    SlipMonth			Char(2)			NOT NULL,
    SlipDay				Char(2)			NOT NULL,
    SlipNo				Int				NOT NULL DEFAULT 1,
    MemberCode			Char(5)				NOT NULL,
    Division			Char(1)			NOT NULL DEFAULT 'E',	-- [E]xpenditure, [I]ncome
    CheckNo				Int				NULL,
    CheckImage			VarBinary(MAX)	NULL,
    CheckAmount			Decimal(12, 2)	NOT NULL DEFAULT 0,
    EncashedDate		Date			NULL,
    CashAmount			Decimal(12, 2)	NOT NULL DEFAULT 0,
    Remark				Varchar(100)	NULL,
    LastUpdate			SmallDateTime	NOT NULL DEFAULT GETDATE(),
	CONSTRAINT 	PK_Slip		PRIMARY KEY ( SlipYear, SlipMonth, SlipDay, SlipNo ),
    CONSTRAINT	FK_Member	FOREIGN KEY ( MemberCode )	REFERENCES	Tbl_Member ( MemberCode )
)
GO

CREATE TRIGGER Tg_Slip_Update ON Tbl_Slip
AFTER UPDATE 
AS
  UPDATE Tbl_Slip SET LastUpdate = GETDATE()
	FROM Inserted i
	WHERE Tbl_Slip.SlipYear = i.SlipYear AND Tbl_Slip.SlipMonth = i.SlipMonth
		 AND Tbl_Slip.SlipDay = i.SlipDay AND Tbl_Slip.SlipNo = i.SlipNo 
GO

-- Create Tbl_SlipItem Table ------------------------------------------------------------
IF NOT EXISTS ( SELECT [name] FROM sys.tables WHERE [name] = 'Tbl_SlipItem' )	CREATE TABLE Tbl_SlipItem (
	SlipYear			Char(4)			NOT NULL,
    SlipMonth			Char(2)			NOT NULL,
    SlipDay				Char(2)			NOT NULL,
    SlipNo				Int				NOT NULL,
    SlipSeq				Int				NOT NULL DEFAULT 1,
    AccountCode			Char(4)			NOT NULL,
    MemberCode			Char(5)			NOT NULL,
    Amount				Decimal(12, 2)	NOT NULL DEFAULT 0,
    Remark				Varchar(70)		NULL,
    LastUpdate			SmallDateTime	NOT NULL DEFAULT GETDATE(),
	CONSTRAINT 	PK_SlipItem	PRIMARY KEY ( SlipYear, SlipMonth, SlipDay, SlipNo, SlipSeq ),
    CONSTRAINT	FK_Slip		FOREIGN KEY ( SlipYear, SlipMonth, SlipDay, SlipNo )	
							REFERENCES	Tbl_Slip ( SlipYear, SlipMonth, SlipDay, SlipNo ),
    CONSTRAINT	FK_Total	FOREIGN KEY ( SlipYear, AccountCode, SlipMonth, MemberCode )	
							REFERENCES	Tbl_Total ( AccountYear, AccountCode, AccountMonth, MemberCode )
)
GO

CREATE TRIGGER Tg_SlipItem_Update ON Tbl_SlipItem
AFTER UPDATE 
AS
  UPDATE Tbl_SlipItem SET LastUpdate = GETDATE()
	FROM Inserted i
	WHERE Tbl_SlipItem.SlipYear = i.SlipYear AND Tbl_SlipItem.SlipMonth = i.SlipMonth
		 AND Tbl_SlipItem.SlipDay = i.SlipDay AND Tbl_SlipItem.SlipNo = i.SlipNo 
		 AND Tbl_SlipItem.SlipSeq = i.SlipSeq
