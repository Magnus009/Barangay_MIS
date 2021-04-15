IF OBJECT_ID ('dbo._tbl_info') IS NOT NULL
	DROP TABLE dbo._tbl_info
GO

CREATE TABLE dbo._tbl_info
	(
	tbl_ID         VARCHAR (2) NOT NULL,
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
VALUES ('BL', 'CasesHeader', 'Code', 'B0')
GO

INSERT INTO dbo._tbl_info (tbl_ID, tbl_name, tbl_colID_name, colID_Prefix)
VALUES ('CP', 'CasesHeader', 'Code', 'C0')
GO

INSERT INTO dbo._tbl_info (tbl_ID, tbl_name, tbl_colID_name, colID_Prefix)
VALUES ('I', 'M_Items', 'ItemID', 'IT')
GO

INSERT INTO dbo._tbl_info (tbl_ID, tbl_name, tbl_colID_name, colID_Prefix)
VALUES ('IN', 'CasesHeader', 'Code', 'I0')
GO

INSERT INTO dbo._tbl_info (tbl_ID, tbl_name, tbl_colID_name, colID_Prefix)
VALUES ('O', 'Officials', 'Code', 'OF')
GO

INSERT INTO dbo._tbl_info (tbl_ID, tbl_name, tbl_colID_name, colID_Prefix)
VALUES ('R', 'Residents', 'Code', 'RS')
GO

IF OBJECT_ID ('dbo.CasesDetails') IS NOT NULL
	DROP TABLE dbo.CasesDetails
GO

CREATE TABLE dbo.CasesDetails
	(
	Code           NVARCHAR (10) NOT NULL,
	Seq            INT NOT NULL,
	PersonInvolved VARCHAR (50),
	isResident     BIT,
	Involvement    VARCHAR (20),
	ContactNo      NVARCHAR (20),
	Statement      VARCHAR (1000) NOT NULL,
	CreatedDate    DATETIME DEFAULT (getdate()),
	DeletedDate    DATETIME,
	UpdatedDate    DATETIME,
	UpdatedBy      VARCHAR (20),
	PRIMARY KEY (Code, Seq)
	)
GO

INSERT INTO dbo.CasesDetails (Code, Seq, PersonInvolved, isResident, Involvement, ContactNo, Statement, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021030001', 0, 'Test', 1, 'Test', 'Test', 'Test', '2021-03-19 14:58:01.88', NULL, '2021-03-19 14:58:01.88', '')
GO

INSERT INTO dbo.CasesDetails (Code, Seq, PersonInvolved, isResident, Involvement, ContactNo, Statement, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021030001', 1, 'Fred', 1, 'V', '0', 'Test', '2021-03-19 14:59:04.813', NULL, '2021-03-19 14:59:04.813', '')
GO

INSERT INTO dbo.CasesDetails (Code, Seq, PersonInvolved, isResident, Involvement, ContactNo, Statement, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021030002', 0, 'Fred', 1, 'Victim', '09970841629', 'Di ba kumanan ako?... saan ba yung kanan?...
Dumiretso ka? Mali mo pre!
Kumanan ako e', '2021-03-19 15:03:35.53', NULL, '2021-03-19 15:03:35.53', '')
GO

INSERT INTO dbo.CasesDetails (Code, Seq, PersonInvolved, isResident, Involvement, ContactNo, Statement, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021030002', 1, 'Wyane', 1, 'Witness', '09659826216', 'Bakit wala kang Helmet?', '2021-03-19 15:03:35.59', NULL, '2021-03-19 15:03:35.59', '')
GO

INSERT INTO dbo.CasesDetails (Code, Seq, PersonInvolved, isResident, Involvement, ContactNo, Statement, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021030003', 0, 'asd', 1, ' asd', ' asd', 'asd', '2021-03-20 15:26:07.563', NULL, '2021-03-20 15:26:07.563', 'master')
GO

INSERT INTO dbo.CasesDetails (Code, Seq, PersonInvolved, isResident, Involvement, ContactNo, Statement, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('I021030001', 0, 'Test', 1, 'Test', 'Test', 'Test', '2021-03-19 15:10:40.233', NULL, '2021-03-19 15:10:40.233', '')
GO

INSERT INTO dbo.CasesDetails (Code, Seq, PersonInvolved, isResident, Involvement, ContactNo, Statement, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('I021030002', 0, 'Test', 1, 'Test', 'Test', 'Test', '2021-03-19 15:11:01.973', NULL, '2021-03-19 15:11:01.973', '')
GO

IF OBJECT_ID ('dbo.CasesDocuments') IS NOT NULL
	DROP TABLE dbo.CasesDocuments
GO

CREATE TABLE dbo.CasesDocuments
	(
	Code          NVARCHAR (10) NOT NULL,
	Seq           INT NOT NULL,
	DocNo         INT NOT NULL,
	FilePath      VARCHAR (250),
	SubmittedDate DATETIME,
	CreatedDate   DATETIME DEFAULT (getdate()),
	DeletedDate   DATETIME,
	UpdatedDate   DATETIME,
	UpdatedBy     VARCHAR (20),
	PRIMARY KEY (Code, Seq, DocNo)
	)
GO

INSERT INTO dbo.CasesDocuments (Code, Seq, DocNo, FilePath, SubmittedDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021030001', 0, 1, 'C:\Users\smd147\Desktop\SupportingDocuments\00.Tiling Packing Management System Flow.xls', '2021-03-19', '2021-03-19 14:58:46.513', NULL, '2021-03-19 14:58:46.513', '')
GO

INSERT INTO dbo.CasesDocuments (Code, Seq, DocNo, FilePath, SubmittedDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021030001', 0, 2, 'C:\Users\smd147\Desktop\SupportingDocuments\3K-logo.png', '2021-03-19', '2021-03-19 14:58:52.4', NULL, '2021-03-19 14:58:52.4', '')
GO

INSERT INTO dbo.CasesDocuments (Code, Seq, DocNo, FilePath, SubmittedDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021030001', 1, 1, 'C:\Users\smd147\Desktop\SupportingDocuments\Book1.xls', '2021-03-19', '2021-03-19 14:59:11.397', NULL, '2021-03-19 14:59:11.397', '')
GO

INSERT INTO dbo.CasesDocuments (Code, Seq, DocNo, FilePath, SubmittedDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021030001', 1, 2, 'C:\Users\smd147\Desktop\SupportingDocuments\git.txt', '2021-03-19', '2021-03-19 14:59:18.283', NULL, '2021-03-19 14:59:18.283', '')
GO

INSERT INTO dbo.CasesDocuments (Code, Seq, DocNo, FilePath, SubmittedDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021030002', 0, 1, 'C:\Users\smd147\Desktop\SupportingDocuments\00.Tiling Packing Management System Flow.xls', '2021-03-19', '2021-03-19 15:03:35.553', NULL, '2021-03-19 15:03:35.553', '')
GO

INSERT INTO dbo.CasesDocuments (Code, Seq, DocNo, FilePath, SubmittedDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021030002', 0, 2, 'C:\Users\smd147\Desktop\SupportingDocuments\3K-logo.png', '2021-03-19', '2021-03-19 15:03:35.57', NULL, '2021-03-19 15:03:35.57', '')
GO

INSERT INTO dbo.CasesDocuments (Code, Seq, DocNo, FilePath, SubmittedDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021030002', 1, 1, 'C:\Users\smd147\Desktop\SupportingDocuments\git.txt', '2021-03-19', '2021-03-19 15:03:35.607', NULL, '2021-03-19 15:03:35.607', '')
GO

INSERT INTO dbo.CasesDocuments (Code, Seq, DocNo, FilePath, SubmittedDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021030003', 0, 1, 'C:\Users\smd147\Desktop\SupportingDocuments\00.Tiling Packing Management System Flow.xls', '2021-03-20', '2021-03-20 15:26:07.593', NULL, '2021-03-20 15:26:07.593', 'master')
GO

INSERT INTO dbo.CasesDocuments (Code, Seq, DocNo, FilePath, SubmittedDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('I021030001', -1, 1, 'C:\Users\smd147\Desktop\SupportingDocuments\00.Tiling Packing Management System Flow.xls', '2021-03-19', '2021-03-19 15:10:40.27', NULL, '2021-03-19 15:10:40.27', '')
GO

INSERT INTO dbo.CasesDocuments (Code, Seq, DocNo, FilePath, SubmittedDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('I021030001', 0, 1, 'C:\Users\smd147\Desktop\SupportingDocuments\Book1.xls', '2021-03-19', '2021-03-19 15:10:40.25', NULL, '2021-03-19 15:10:40.25', '')
GO

INSERT INTO dbo.CasesDocuments (Code, Seq, DocNo, FilePath, SubmittedDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('I021030002', -1, 1, 'C:\Users\smd147\Desktop\SupportingDocuments\00.Tiling Packing Management System Flow.xls', '2021-03-19', '2021-03-19 15:11:02.027', NULL, '2021-03-19 15:11:02.027', '')
GO

INSERT INTO dbo.CasesDocuments (Code, Seq, DocNo, FilePath, SubmittedDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('I021030002', 0, 1, 'C:\Users\smd147\Desktop\SupportingDocuments\Book1.xls', '2021-03-19', '2021-03-19 15:11:02.003', NULL, '2021-03-19 15:11:02.003', '')
GO

IF OBJECT_ID ('dbo.CasesHeader') IS NOT NULL
	DROP TABLE dbo.CasesHeader
GO

CREATE TABLE dbo.CasesHeader
	(
	Code         NVARCHAR (10) NOT NULL,
	TypeID       INT NOT NULL,
	StatusID     INT NOT NULL,
	CaseReport   VARCHAR (1000) NOT NULL,
	InCharge     VARCHAR (50) NOT NULL,
	ReportedBy   VARCHAR (50) NOT NULL,
	ReportedDate DATETIME NOT NULL,
	IncidentDate DATETIME NOT NULL,
	CreatedDate  DATETIME DEFAULT (getdate()),
	DeletedDate  DATETIME,
	UpdatedDate  DATETIME,
	UpdatedBy    VARCHAR (20),
	PRIMARY KEY (Code)
	)
GO

INSERT INTO dbo.CasesHeader (Code, TypeID, StatusID, CaseReport, InCharge, ReportedBy, ReportedDate, IncidentDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021030001', 0, 0, 'Test', 'Fred', 'Fred', '2021-03-19 14:57:06', '2021-03-19 14:57:06', '2021-03-19 14:57:56.29', NULL, '2021-03-19 14:57:56.29', '')
GO

INSERT INTO dbo.CasesHeader (Code, TypeID, StatusID, CaseReport, InCharge, ReportedBy, ReportedDate, IncidentDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021030002', 0, 0, 'Mali mo Pre!', 'Berna', 'Fred', '2021-03-19 15:02:00', '2021-03-19 15:02:00', '2021-03-19 15:03:35.513', NULL, '2021-03-19 15:03:35.513', '')
GO

INSERT INTO dbo.CasesHeader (Code, TypeID, StatusID, CaseReport, InCharge, ReportedBy, ReportedDate, IncidentDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021030003', 0, 0, 'asd', 'asd', 'asd', '2021-03-20 15:25:42', '2021-03-20 15:25:42', '2021-03-20 15:26:07.547', NULL, '2021-03-20 15:26:07.547', 'master')
GO

INSERT INTO dbo.CasesHeader (Code, TypeID, StatusID, CaseReport, InCharge, ReportedBy, ReportedDate, IncidentDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('I021030001', 1, 0, 'Test', 'Fred', 'Fred', '2021-03-19 15:10:10', '2021-03-19 15:10:10', '2021-03-19 15:10:40.14', NULL, '2021-03-19 15:10:40.14', '')
GO

INSERT INTO dbo.CasesHeader (Code, TypeID, StatusID, CaseReport, InCharge, ReportedBy, ReportedDate, IncidentDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('I021030002', 1, 0, 'Test', 'Fred', 'Fred', '2021-03-19 15:10:10', '2021-03-19 15:10:10', '2021-03-19 15:11:01.89', NULL, '2021-03-19 15:11:01.89', '')
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

IF OBJECT_ID ('dbo.M_BorrowStatus') IS NOT NULL
	DROP TABLE dbo.M_BorrowStatus
GO

CREATE TABLE dbo.M_BorrowStatus
	(
	ID          INT NOT NULL,
	Description VARCHAR (500),
	CreatedDate DATETIME,
	UpdatedDate DATETIME,
	DeletedDate DATETIME,
	UpdatedBy   VARCHAR (10),
	PRIMARY KEY (ID)
	)
GO

INSERT INTO dbo.M_BorrowStatus (ID, Description, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (1, 'Borrow', '2021-03-24 12:35:00.893', '2021-03-24 12:35:00.893', NULL, 'admin')
GO

INSERT INTO dbo.M_BorrowStatus (ID, Description, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (2, 'Cancel', '2021-03-24 12:35:10.7', '2021-03-24 12:35:10.7', NULL, 'admin')
GO

INSERT INTO dbo.M_BorrowStatus (ID, Description, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (3, 'Overdue', '2021-03-24 12:35:20.403', '2021-03-24 12:35:20.403', NULL, 'admin')
GO

INSERT INTO dbo.M_BorrowStatus (ID, Description, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (4, 'Returned', '2021-03-24 12:35:20.403', '2021-03-24 12:35:20.403', NULL, 'admin')
GO

IF OBJECT_ID ('dbo.M_CaseStatus') IS NOT NULL
	DROP TABLE dbo.M_CaseStatus
GO

CREATE TABLE dbo.M_CaseStatus
	(
	TypeID      INT NOT NULL,
	StatusID    INT NOT NULL,
	Description VARCHAR (20) NOT NULL,
	CreatedDate DATETIME DEFAULT (getdate()),
	DeletedDate DATETIME,
	UpdatedDate DATETIME,
	UpdatedBy   VARCHAR (20),
	PRIMARY KEY (TypeID, StatusID)
	)
GO

INSERT INTO dbo.M_CaseStatus (TypeID, StatusID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (0, 0, 'NEW', '2021-03-15 07:59:52.707', NULL, '2021-03-15 07:59:52.707', 'master')
GO

INSERT INTO dbo.M_CaseStatus (TypeID, StatusID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (0, 1, 'ON-GOING', '2021-03-15 07:59:52.707', NULL, '2021-03-15 07:59:52.707', 'master')
GO

INSERT INTO dbo.M_CaseStatus (TypeID, StatusID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (0, 2, 'PENDING', '2021-03-15 07:59:52.707', NULL, '2021-03-15 07:59:52.707', 'master')
GO

INSERT INTO dbo.M_CaseStatus (TypeID, StatusID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (0, 3, 'CLOSED', '2021-03-15 07:59:52.71', NULL, '2021-03-15 07:59:52.71', 'master')
GO

INSERT INTO dbo.M_CaseStatus (TypeID, StatusID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (1, 0, 'NEW', '2021-03-15 07:59:52.707', NULL, '2021-03-15 07:59:52.707', 'master')
GO

INSERT INTO dbo.M_CaseStatus (TypeID, StatusID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (1, 1, 'ON-GOING', '2021-03-15 07:59:52.707', NULL, '2021-03-15 07:59:52.707', 'master')
GO

INSERT INTO dbo.M_CaseStatus (TypeID, StatusID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (1, 2, 'PENDING', '2021-03-15 07:59:52.707', NULL, '2021-03-15 07:59:52.707', 'master')
GO

INSERT INTO dbo.M_CaseStatus (TypeID, StatusID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (1, 3, 'CLOSED', '2021-03-15 07:59:52.71', NULL, '2021-03-15 07:59:52.71', 'master')
GO

INSERT INTO dbo.M_CaseStatus (TypeID, StatusID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (2, 0, 'SETTLED', '2021-03-15 07:59:52.707', NULL, '2021-03-15 07:59:52.707', 'master')
GO

INSERT INTO dbo.M_CaseStatus (TypeID, StatusID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (2, 1, 'UNSETTLED', '2021-03-15 07:59:52.707', NULL, '2021-03-15 07:59:52.707', 'master')
GO

IF OBJECT_ID ('dbo.M_CaseType') IS NOT NULL
	DROP TABLE dbo.M_CaseType
GO

CREATE TABLE dbo.M_CaseType
	(
	ID          INT NOT NULL,
	Prefix      VARCHAR (2),
	Description VARCHAR (20) NOT NULL,
	CreatedDate DATETIME DEFAULT (getdate()),
	DeletedDate DATETIME,
	UpdatedDate DATETIME,
	UpdatedBy   VARCHAR (20),
	PRIMARY KEY (ID)
	)
GO

INSERT INTO dbo.M_CaseType (ID, Prefix, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (0, 'CP', 'COMPLAINTS', '2021-03-15 08:05:58.977', NULL, '2021-03-15 08:05:58.977', 'master')
GO

INSERT INTO dbo.M_CaseType (ID, Prefix, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (1, 'IN', 'INCIDENTS', '2021-03-15 08:05:59.053', NULL, '2021-03-15 08:05:59.053', 'master')
GO

INSERT INTO dbo.M_CaseType (ID, Prefix, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (2, 'BL', 'BLOTTERS', '2021-03-15 08:05:59.053', NULL, '2021-03-15 08:05:59.053', 'master')
GO

IF OBJECT_ID ('dbo.M_Committee') IS NOT NULL
	DROP TABLE dbo.M_Committee
GO

CREATE TABLE dbo.M_Committee
	(
	ID          INT NOT NULL,
	Description VARCHAR (20) NOT NULL,
	CreatedDate DATETIME DEFAULT (getdate()),
	DeletedDate DATETIME,
	UpdatedDate DATETIME,
	UpdatedBy   VARCHAR (20),
	PRIMARY KEY (ID)
	)
GO

INSERT INTO dbo.M_Committee (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (1, 'Fishery', '2021-04-07 08:53:35.01', NULL, '2021-04-07 08:53:35.01', 'master')
GO

INSERT INTO dbo.M_Committee (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (2, 'Finance', '2021-04-07 08:53:35.01', NULL, '2021-04-07 08:53:35.01', 'master')
GO

INSERT INTO dbo.M_Committee (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (3, 'Disaster', '2021-04-07 08:53:35.01', NULL, '2021-04-07 08:53:35.01', 'master')
GO

INSERT INTO dbo.M_Committee (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (4, 'Health/Education', '2021-04-07 08:53:35.01', NULL, '2021-04-07 08:53:35.01', 'master')
GO

INSERT INTO dbo.M_Committee (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (5, 'Peace', '2021-04-07 08:53:35.01', NULL, '2021-04-07 08:53:35.01', 'master')
GO

INSERT INTO dbo.M_Committee (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (6, 'Cleanliness', '2021-04-07 08:53:35.01', NULL, '2021-04-07 08:53:35.01', 'master')
GO

INSERT INTO dbo.M_Committee (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (7, 'Public Work', '2021-04-07 08:53:35.01', NULL, '2021-04-07 08:53:35.01', 'master')
GO


IF OBJECT_ID ('dbo.M_Items') IS NOT NULL
	DROP TABLE dbo.M_Items
GO

CREATE TABLE dbo.M_Items
	(
	ItemID      NVARCHAR (10) NOT NULL,
	Description VARCHAR (500),
	CreatedDate DATETIME,
	UpdatedDate DATETIME,
	DeletedDate DATETIME,
	UpdatedBy   VARCHAR (10),
	PRIMARY KEY (ItemID)
	)
GO

INSERT INTO dbo.M_Items (ItemID, Description, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('I21030001', 'Chairs', '2021-03-24 09:48:55.69', '2021-03-24 12:25:59.013', NULL, 'admin')
GO

INSERT INTO dbo.M_Items (ItemID, Description, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('I21030002', 'Tables', '2021-03-24 09:58:12.46', '2021-03-24 09:58:12.46', NULL, 'admin')
GO

INSERT INTO dbo.M_Items (ItemID, Description, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('I21030003', 'Tent', '2021-03-24 12:26:38.293', '2021-03-24 12:26:38.293', NULL, 'admin')
GO


ALTER FUNCTION fn_colID(
	@type VARCHAR(2)
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
	WHEN @type = 'CP' THEN 
	   CASE WHEN (SELECT count(*) FROM CasesHeader
		WHERE LEFT(CODE,6) = @code
		AND TypeID = 0 ) <> 0 THEN 
				(SELECT RIGHT(max(CODE), 4) + 1  FROM CasesHeader
				WHERE LEFT(CODE,6) = @code
				AND TypeID = 0) 
		ELSE 
			'0001'
		END
	WHEN @type = 'IN' THEN 
	   CASE WHEN (SELECT count(*) FROM CasesHeader
		WHERE LEFT(CODE,6) = @code
		AND TypeID = 1 ) <> 0 THEN 
				(SELECT RIGHT(max(CODE), 4) + 1  FROM CasesHeader
				WHERE LEFT(CODE,6) = @code
				AND TypeID = 1) 
		ELSE 
			'0001'
		END
	WHEN @type = 'BL' THEN 
	   CASE WHEN (SELECT count(*) FROM CasesHeader
		WHERE LEFT(CODE,6) = @code
		AND TypeID = 2) <> 0 THEN 
				(SELECT RIGHT(max(CODE), 4) + 1  FROM CasesHeader
				WHERE LEFT(CODE,6) = @code
				AND TypeID = 2) 
		ELSE 
			'0001'
		END
	END AS NVARCHAR(4)), 4)
	)
	
	SET @id = @code + @seq
	RETURN @id
END
GO

