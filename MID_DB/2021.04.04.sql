IF OBJECT_ID ('dbo._tbl_info') IS NOT NULL
	DROP TABLE dbo._tbl_info
GO

CREATE TABLE dbo._tbl_info
	(
	tbl_ID         VARCHAR (1) NOT NULL,
	tbl_name       VARCHAR (50) NOT NULL,
	tbl_colID_name VARCHAR (50) NOT NULL,
	colID_Prefix   VARCHAR (2) NOT NULL,
	PRIMARY KEY (tbl_ID)
	)
GO

INSERT INTO dbo._tbl_info (tbl_ID, tbl_name, tbl_colID_name, colID_Prefix)
VALUES ('A', 'M_UserAccounts', 'UserID', 'AC')
GO

INSERT INTO dbo._tbl_info (tbl_ID, tbl_name, tbl_colID_name, colID_Prefix)
VALUES ('B', 'T_BorrowHistory', 'ID', 'BW')
GO

INSERT INTO dbo._tbl_info (tbl_ID, tbl_name, tbl_colID_name, colID_Prefix)
VALUES ('I', 'M_Items', 'ItemID', 'IT')
GO

INSERT INTO dbo._tbl_info (tbl_ID, tbl_name, tbl_colID_name, colID_Prefix)
VALUES ('O', 'Officials', 'Code', 'OF')
GO

INSERT INTO dbo._tbl_info (tbl_ID, tbl_name, tbl_colID_name, colID_Prefix)
VALUES ('R', 'Residents', 'Code', 'RS')
GO




IF OBJECT_ID ('dbo.Household') IS NOT NULL
	DROP TABLE dbo.Household
GO

CREATE TABLE dbo.Household
	(
	HouseNo      NVARCHAR (10) NOT NULL,
	HouseholdNo  INT NOT NULL,
	Barangay     VARCHAR (50) NOT NULL,
	Street       VARCHAR (50) NOT NULL,
	Municipality VARCHAR (50) NOT NULL,
	Province     VARCHAR (50) NOT NULL,
	ContactNo    NVARCHAR (20),
	CreatedDate  DATETIME DEFAULT (getdate()),
	DeletedDate  DATETIME,
	UpdatedDate  DATETIME,
	UpdatedBy    VARCHAR (20),
	PRIMARY KEY (HouseNo, HouseholdNo)
	)
GO

INSERT INTO dbo.Household (HouseNo, HouseholdNo, Barangay, Street, Municipality, Province, ContactNo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('1100', 1, 'Brgy 36', 'Savannah', 'Cavite City', 'Cavite', '406-1234', '2021-04-02 23:24:14.297', NULL, '2021-04-02 23:24:14.297', '')
GO

INSERT INTO dbo.Household (HouseNo, HouseholdNo, Barangay, Street, Municipality, Province, ContactNo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('1111', 1, 'Brgy 36', 'Savannah', 'Cavite City', 'Cavite', '406-4321', '2021-04-02 23:43:55.65', NULL, '2021-04-02 23:43:55.65', '')
GO

INSERT INTO dbo.Household (HouseNo, HouseholdNo, Barangay, Street, Municipality, Province, ContactNo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('1112', 1, 'Brgy 36', 'Savannah', 'Cavite City', 'Cavite', '406-7896', '2021-04-02 23:47:11.67', NULL, '2021-04-02 23:47:11.67', '')
GO

INSERT INTO dbo.Household (HouseNo, HouseholdNo, Barangay, Street, Municipality, Province, ContactNo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('1112', 2, 'Brgy 36', 'Savannah', 'Cavite City', 'Cavite', '406-7896', '2021-04-03 13:28:51.763', NULL, '2021-04-03 13:28:51.763', '')
GO

INSERT INTO dbo.Household (HouseNo, HouseholdNo, Barangay, Street, Municipality, Province, ContactNo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('1115', 1, 'Brgy 36', 'Savannah', 'Cavite City', 'Cavite', '406-8752', '2021-04-04 01:48:16.097', NULL, '2021-04-04 01:48:16.097', '')
GO




IF OBJECT_ID ('dbo.HouseholdMember') IS NOT NULL
	DROP TABLE dbo.HouseholdMember
GO

CREATE TABLE dbo.HouseholdMember
	(
	HouseNo      NVARCHAR (10) NOT NULL,
	HouseholdNo  INT NOT NULL,
	ResidentCode NVARCHAR (10) NOT NULL,
	Role         INT NOT NULL,
	CreatedDate  DATETIME DEFAULT (getdate()),
	DeletedDate  DATETIME,
	UpdatedDate  DATETIME,
	UpdatedBy    VARCHAR (20),
	PRIMARY KEY (HouseNo, HouseholdNo, ResidentCode)
	)
GO

INSERT INTO dbo.HouseholdMember (HouseNo, HouseholdNo, ResidentCode, Role, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('1100', 1, 'RS21040001', 1, '2021-04-02 23:24:25.09', NULL, '2021-04-02 23:24:25.09', '')
GO

INSERT INTO dbo.HouseholdMember (HouseNo, HouseholdNo, ResidentCode, Role, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('1100', 1, 'RS21040002', 2, '2021-04-02 23:24:25.09', NULL, '2021-04-02 23:24:25.09', '')
GO

INSERT INTO dbo.HouseholdMember (HouseNo, HouseholdNo, ResidentCode, Role, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('1111', 1, 'RS21040003', 1, '2021-04-02 23:43:58.727', NULL, '2021-04-02 23:43:58.727', '')
GO

INSERT INTO dbo.HouseholdMember (HouseNo, HouseholdNo, ResidentCode, Role, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('1112', 1, 'RS21040004', 2, '2021-04-02 23:47:11.697', NULL, '2021-04-02 23:47:11.697', '')
GO

INSERT INTO dbo.HouseholdMember (HouseNo, HouseholdNo, ResidentCode, Role, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('1112', 1, 'RS21040006', 1, '2021-04-03 23:18:58.857', NULL, '2021-04-03 23:18:58.857', '')
GO

INSERT INTO dbo.HouseholdMember (HouseNo, HouseholdNo, ResidentCode, Role, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('1112', 2, 'RS21040005', 1, '2021-04-03 13:28:51.79', NULL, '2021-04-03 13:28:51.79', '')
GO

INSERT INTO dbo.HouseholdMember (HouseNo, HouseholdNo, ResidentCode, Role, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('1115', 1, 'RS21040007', 1, '2021-04-04 01:48:16.113', NULL, '2021-04-04 01:48:16.113', '')
GO




IF OBJECT_ID ('dbo.Residents') IS NOT NULL
	DROP TABLE dbo.Residents
GO

CREATE TABLE dbo.Residents
	(
	Code            NVARCHAR (10) NOT NULL,
	FamilyName      VARCHAR (50) NOT NULL,
	GivenName       VARCHAR (50) NOT NULL,
	MiddleName      VARCHAR (50),
	ExtensionName   VARCHAR (20),
	Gender          VARCHAR (1) NOT NULL,
	BirthDate       DATETIME NOT NULL,
	BirthPlace      VARCHAR (100) NOT NULL,
	Citizenship     VARCHAR (20) NOT NULL,
	CivilStatus     INT NOT NULL,
	ContactNo       NVARCHAR (20),
	Occupation      VARCHAR (50),
	SamahanID       INT,
	isVoter         BIT DEFAULT ((0)) NOT NULL,
	inHabitant      BIT DEFAULT ((1)) NOT NULL,
	Indigent        BIT DEFAULT ((0)) NOT NULL,
	isPWD           BIT DEFAULT ((0)) NOT NULL,
	Disabilities    VARCHAR (100),
	isPregnant      BIT DEFAULT ((0)) NOT NULL,
	DeliveryDate    DATETIME,
	DateOfCaseStudy DATETIME,
	CreatedDate     DATETIME DEFAULT (getdate()),
	DeletedDate     DATETIME,
	UpdatedDate     DATETIME,
	UpdatedBy       VARCHAR (20),
	PRIMARY KEY (Code, FamilyName, GivenName)
	)
GO

INSERT INTO dbo.Residents (Code, FamilyName, GivenName, MiddleName, ExtensionName, Gender, BirthDate, BirthPlace, Citizenship, CivilStatus, ContactNo, Occupation, SamahanID, isVoter, inHabitant, Indigent, isPWD, Disabilities, isPregnant, DeliveryDate, DateOfCaseStudy, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('RS21040001', 'Galang', 'Renato', 'Cruz', 'JR', 'M', '1965-11-02', 'Cavite City', 'Filipino', 1, '(+63)923-758-2523', 'Fisherman', 2, 1, 1, 0, 0, '', 0, NULL, NULL, '2021-04-02 23:23:40.133', NULL, '2021-04-02 23:23:40.133', '')
GO

INSERT INTO dbo.Residents (Code, FamilyName, GivenName, MiddleName, ExtensionName, Gender, BirthDate, BirthPlace, Citizenship, CivilStatus, ContactNo, Occupation, SamahanID, isVoter, inHabitant, Indigent, isPWD, Disabilities, isPregnant, DeliveryDate, DateOfCaseStudy, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('RS21040002', 'Galang', 'Marjorie', 'Cruz', '', 'F', '1995-08-02', 'Cavite City', 'Filipino', 1, '(+63)938-625-5233', 'None', NULL, 1, 1, 0, 1, 'Mute', 0, NULL, '2021-04-02', '2021-04-02 23:28:32.83', NULL, '2021-04-04 13:04:38.057', '')
GO

INSERT INTO dbo.Residents (Code, FamilyName, GivenName, MiddleName, ExtensionName, Gender, BirthDate, BirthPlace, Citizenship, CivilStatus, ContactNo, Occupation, SamahanID, isVoter, inHabitant, Indigent, isPWD, Disabilities, isPregnant, DeliveryDate, DateOfCaseStudy, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('RS21040003', 'Mendoza', 'Claire', 'Santos', '', 'F', '1978-04-02', 'Cavite City', 'Filipino', 3, '(+63)965-235-2354', 'Vendor', 1, 1, 1, 0, 0, '', 0, NULL, '2021-04-03', '2021-04-02 23:43:50.74', NULL, '2021-04-02 23:43:50.74', '')
GO

INSERT INTO dbo.Residents (Code, FamilyName, GivenName, MiddleName, ExtensionName, Gender, BirthDate, BirthPlace, Citizenship, CivilStatus, ContactNo, Occupation, SamahanID, isVoter, inHabitant, Indigent, isPWD, Disabilities, isPregnant, DeliveryDate, DateOfCaseStudy, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('RS21040004', 'Lucero', 'Jayvee', '', '', 'M', '2000-04-02', 'Cavite City', 'Filipino', 0, '(+63)997-285-7245', 'Crew', NULL, 1, 1, 0, 0, '', 0, NULL, '2021-04-03', '2021-04-02 23:47:11.62', NULL, '2021-04-02 23:47:11.62', '')
GO

INSERT INTO dbo.Residents (Code, FamilyName, GivenName, MiddleName, ExtensionName, Gender, BirthDate, BirthPlace, Citizenship, CivilStatus, ContactNo, Occupation, SamahanID, isVoter, inHabitant, Indigent, isPWD, Disabilities, isPregnant, DeliveryDate, DateOfCaseStudy, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('RS21040005', 'Molino', 'Jessy', 'Faustino', '', 'F', '1975-04-03', 'Cavite City', 'Filipino', 2, '(+63)965-275-2237', 'Vendor', 1, 1, 1, 1, 0, '', 1, '2021-12-04', '2021-04-03', '2021-04-03 13:28:51.72', NULL, '2021-04-04 02:50:15.78', '')
GO

INSERT INTO dbo.Residents (Code, FamilyName, GivenName, MiddleName, ExtensionName, Gender, BirthDate, BirthPlace, Citizenship, CivilStatus, ContactNo, Occupation, SamahanID, isVoter, inHabitant, Indigent, isPWD, Disabilities, isPregnant, DeliveryDate, DateOfCaseStudy, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('RS21040006', 'Lucero', 'John', 'Monzon', '', 'M', '1963-04-03', 'Cavite City', 'Filipino', 3, '(+63)997-236-5232', 'None', NULL, 1, 1, 0, 1, 'Handicaped', 0, NULL, '2021-04-03', '2021-04-03 23:18:58.67', NULL, '2021-04-03 23:18:58.67', '')
GO

INSERT INTO dbo.Residents (Code, FamilyName, GivenName, MiddleName, ExtensionName, Gender, BirthDate, BirthPlace, Citizenship, CivilStatus, ContactNo, Occupation, SamahanID, isVoter, inHabitant, Indigent, isPWD, Disabilities, isPregnant, DeliveryDate, DateOfCaseStudy, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('RS21040007', 'Madriaga', 'Jason', 'Montano', '', 'M', '1990-09-04', 'Cavite City', 'Filipino', 1, '(+63)997-254-5452', 'Welder', NULL, 1, 1, 0, 0, '', 0, NULL, '2021-04-04', '2021-04-04 01:48:16.05', NULL, '2021-04-04 01:48:16.05', '')
GO

ALTER FUNCTION fn_colID(
	@type VARCHAR(1)
)
RETURNS NVARCHAR(10)
BEGIN

DECLARE @seq AS NVARCHAR(4)
DECLARE @code AS NVARCHAR(6)
DECLARE @id AS NVARCHAR(10)

SET @code = (SELECT colID_Prefix + RIGHT(year(getdate()),2) + RIGHT('0' + CAST(month(getdate()) AS NVARCHAR(2)),2) FROM _tbl_info WHERE tbl_ID = @type)
SET @seq = (
	RIGHT('000' + CAST(CASE WHEN @type = 'A' THEN
		CASE WHEN (SELECT count(*) FROM M_UserAccounts 
		WHERE LEFT(UserID,6) = @code) <> 0 THEN 
				(SELECT RIGHT(max(UserID), 4) + 1  FROM M_UserAccounts 
				WHERE LEFT(UserID,6) = @code) 
		ELSE 
			'0001'
		END
	WHEN @type = 'I' THEN 
	   CASE WHEN (SELECT count(*) FROM M_Items
		WHERE LEFT(ItemID,6) = @code) <> 0 THEN 
				(SELECT RIGHT(max(ItemID), 4) + 1  FROM M_Items 
				WHERE LEFT(ItemID,6) = @code) 
		ELSE 
			'0001'
		END
	WHEN @type = 'B' THEN 
	   CASE WHEN (SELECT count(*) FROM M_BorrowStatus
		WHERE LEFT(ID,6) = @code) <> 0 THEN 
				(SELECT RIGHT(max(ID), 4) + 1  FROM M_BorrowStatus 
				WHERE LEFT(ID,6) = @code) 
		ELSE 
			'0001'
		END
	WHEN @type = 'R' THEN 
	   CASE WHEN (SELECT count(*) FROM Residents
		WHERE LEFT(CODE,6) = @code) <> 0 THEN 
				(SELECT RIGHT(max(CODE), 4) + 1  FROM Residents 
				WHERE LEFT(CODE,6) = @code) 
		ELSE 
			'0001'
		END
	WHEN @type = 'O' THEN 
	   CASE WHEN (SELECT count(*) FROM Officials
		WHERE LEFT(CODE,6) = @code) <> 0 THEN 
				(SELECT RIGHT(max(CODE), 4) + 1  FROM Officials 
				WHERE LEFT(CODE,6) = @code) 
		ELSE 
			'0001'
		END
	END AS NVARCHAR(4)), 4)
	)
	
	SET @id = @code + @seq
	RETURN @id
END
GO


