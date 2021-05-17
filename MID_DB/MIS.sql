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

INSERT INTO dbo._tbl_info (tbl_ID, tbl_name, tbl_colID_name, colID_Prefix)
VALUES ('WC', 'CasesHeader', 'Code', 'WC')
GO

IF OBJECT_ID ('dbo.BlotterDetails') IS NOT NULL
	DROP TABLE dbo.BlotterDetails
GO

CREATE TABLE dbo.BlotterDetails
	(
	CaseCode     NVARCHAR (10) NOT NULL,
	Seq          INT NOT NULL,
	StatusID     INT NOT NULL,
	ScheduleDate DATETIME NULL,
	MeetingDate  DATETIME NULL,
	CreatedDate  DATETIME NULL,
	DeletedDate  DATETIME NULL,
	UpdatedDate  DATETIME NULL,
	UpdatedBy    VARCHAR (20) NULL,
	PRIMARY KEY (CaseCode, Seq)
	)
GO

INSERT INTO dbo.BlotterDetails (CaseCode, Seq, StatusID, ScheduleDate, MeetingDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('B021050001', 1, 1, '2021-05-10', NULL, '2021-05-09 13:37:16', NULL, '2021-05-09 13:37:16.48', '')
GO

INSERT INTO dbo.BlotterDetails (CaseCode, Seq, StatusID, ScheduleDate, MeetingDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('B021050002', 1, 0, NULL, NULL, '2021-05-09 14:23:39.833', NULL, '2021-05-09 14:23:39.833', '')
GO

IF OBJECT_ID ('dbo.CasesDetails') IS NOT NULL
	DROP TABLE dbo.CasesDetails
GO

CREATE TABLE dbo.CasesDetails
	(
	Code           NVARCHAR (10) NOT NULL,
	Seq            INT NOT NULL,
	ResidentCode   NVARCHAR (10) NULL,
	PersonInvolved VARCHAR (50) NULL,
	isResident     BIT NULL,
	Involvement    VARCHAR (20) NULL,
	ContactNo      NVARCHAR (20) NULL,
	Statement      VARCHAR (1000) NOT NULL,
	CreatedDate    DATETIME DEFAULT (getdate()) NULL,
	DeletedDate    DATETIME NULL,
	UpdatedDate    DATETIME NULL,
	UpdatedBy      VARCHAR (20) NULL,
	PRIMARY KEY (Code, Seq)
	)
GO

INSERT INTO dbo.CasesDetails (Code, Seq, ResidentCode, PersonInvolved, isResident, Involvement, ContactNo, Statement, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('B021050001', 0, 'RS21040002', 'Galang, Marjorie Cruz ', 1, 'Witness', '09658965896', 'TESTING', '2021-05-09 13:37:09.093', NULL, '2021-05-09 13:37:09.093', '')
GO

INSERT INTO dbo.CasesDetails (Code, Seq, ResidentCode, PersonInvolved, isResident, Involvement, ContactNo, Statement, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('B021050001', 1, 'RS21040006', 'Lucero, John Monzon ', 1, 'VICTIM', '09970865965', 'TEST', '2021-05-09 13:37:10', NULL, '2021-05-09 13:37:10', '')
GO

INSERT INTO dbo.CasesDetails (Code, Seq, ResidentCode, PersonInvolved, isResident, Involvement, ContactNo, Statement, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('B021050002', 0, 'RS21040002', 'Galang, Marjorie Cruz ', 1, 'Suspect', '09985456854', 'Nagugutom na kasi ako sir, walang pambili ng ulam. kaya nakursunadahan ko yung Malunggay ng kapitbahay.', '2021-05-09 14:23:39.773', NULL, '2021-05-09 14:25:34.607', '')
GO

INSERT INTO dbo.CasesDetails (Code, Seq, ResidentCode, PersonInvolved, isResident, Involvement, ContactNo, Statement, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021040001', 0, 'RS21040002', 'Galang, Marjorie Cruz ', 1, 'Witness', '09658965896', 'TESTING', '2021-04-20 18:05:28.913', NULL, '2021-04-21 11:57:15.947', 'master')
GO

INSERT INTO dbo.CasesDetails (Code, Seq, ResidentCode, PersonInvolved, isResident, Involvement, ContactNo, Statement, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021040001', 1, 'RS21040006', 'Lucero, John Monzon ', 1, 'VICTIM', '09970865965', 'TEST', '2021-04-21 11:57:21.33', NULL, '2021-04-21 11:57:21.33', 'master')
GO

INSERT INTO dbo.CasesDetails (Code, Seq, ResidentCode, PersonInvolved, isResident, Involvement, ContactNo, Statement, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021040002', 0, 'RS21040005', 'Molino, Jessy Faustino ', 1, 'WITNESS', '09658965896', 'Di ba kumanan ako?.. saan ba yung kanan?
Kumanan ako, tapos dumiretso ka..
Mali mo Pre!
Kumanan ako e!', '2021-04-21 02:16:19.487', NULL, '2021-04-21 12:30:03.06', 'master')
GO

INSERT INTO dbo.CasesDetails (Code, Seq, ResidentCode, PersonInvolved, isResident, Involvement, ContactNo, Statement, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021040002', 1, 'RS21040005', 'Molino, Jessy Faustino ', 1, 'SUSPECT', '09978546589', 'test', '2021-04-21 12:07:30.787', NULL, '2021-04-21 12:30:04.85', 'master')
GO

INSERT INTO dbo.CasesDetails (Code, Seq, ResidentCode, PersonInvolved, isResident, Involvement, ContactNo, Statement, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021040002', 2, '', 'TEST', 0, 'TEST', '09978569569', 'TEST', '2021-04-21 12:30:04.89', NULL, '2021-04-21 12:30:04.89', 'master')
GO

IF OBJECT_ID ('dbo.CasesDocuments') IS NOT NULL
	DROP TABLE dbo.CasesDocuments
GO

CREATE TABLE dbo.CasesDocuments
	(
	Code          NVARCHAR (10) NOT NULL,
	Seq           INT NOT NULL,
	DocNo         INT NOT NULL,
	FilePath      VARCHAR (250) NULL,
	SubmittedDate DATETIME NULL,
	CreatedDate   DATETIME DEFAULT (getdate()) NULL,
	DeletedDate   DATETIME NULL,
	UpdatedDate   DATETIME NULL,
	UpdatedBy     VARCHAR (20) NULL,
	PRIMARY KEY (Code, Seq, DocNo)
	)
GO

INSERT INTO dbo.CasesDocuments (Code, Seq, DocNo, FilePath, SubmittedDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('B021050001', 0, 1, 'C:\Users\63997\Desktop\SupportingDocuments\MIS-of-Brgy-36-A-Sap-sap.docx', '2021-04-20', '2021-05-09 13:37:09.987', NULL, '2021-05-09 13:37:09.987', '')
GO

INSERT INTO dbo.CasesDocuments (Code, Seq, DocNo, FilePath, SubmittedDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('B021050001', 1, 1, 'C:\Users\63997\Desktop\SupportingDocuments\pointer.png', '2021-04-21', '2021-05-09 13:37:10.52', NULL, '2021-05-09 13:37:10.52', '')
GO

INSERT INTO dbo.CasesDocuments (Code, Seq, DocNo, FilePath, SubmittedDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('B021050002', -1, 1, 'C:\Users\63997\Desktop\SupportingDocuments\SoloLeveling.png', '2021-05-09', '2021-05-09 14:23:39.803', NULL, '2021-05-09 14:23:39.803', '')
GO

INSERT INTO dbo.CasesDocuments (Code, Seq, DocNo, FilePath, SubmittedDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021040001', 0, 1, 'C:\Users\63997\Desktop\SupportingDocuments\MIS-of-Brgy-36-A-Sap-sap.docx', '2021-04-20', '2021-04-20 18:05:28.957', NULL, '2021-04-21 11:57:21.3', 'master')
GO

INSERT INTO dbo.CasesDocuments (Code, Seq, DocNo, FilePath, SubmittedDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021040001', 1, 1, 'C:\Users\63997\Desktop\SupportingDocuments\pointer.png', '2021-04-21', '2021-04-21 11:57:21.407', NULL, '2021-04-21 11:57:21.407', 'master')
GO

INSERT INTO dbo.CasesDocuments (Code, Seq, DocNo, FilePath, SubmittedDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021040002', 0, 1, 'C:\Users\63997\Desktop\SupportingDocuments\MIS-of-Brgy-36-A-Sap-sap.docx', '2021-04-21', '2021-04-21 02:16:19.517', NULL, '2021-04-21 12:30:04.803', 'master')
GO

INSERT INTO dbo.CasesDocuments (Code, Seq, DocNo, FilePath, SubmittedDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021040002', 2, 1, 'C:\Users\63997\Desktop\SupportingDocuments\SqlDbx.exe', '2021-04-21', '2021-04-21 12:30:04.963', NULL, '2021-04-21 12:30:04.963', 'master')
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
	InchargeID   NVARCHAR (10) NULL,
	InCharge     VARCHAR (50) NOT NULL,
	ReportedByID NVARCHAR (10) NULL,
	ReportedBy   VARCHAR (50) NOT NULL,
	ReportedDate DATETIME NOT NULL,
	IncidentDate DATETIME NOT NULL,
	CreatedDate  DATETIME DEFAULT (getdate()) NULL,
	DeletedDate  DATETIME NULL,
	UpdatedDate  DATETIME NULL,
	UpdatedBy    VARCHAR (20) NULL,
	PRIMARY KEY (Code)
	)
GO

INSERT INTO dbo.CasesHeader (Code, TypeID, StatusID, CaseReport, InchargeID, InCharge, ReportedByID, ReportedBy, ReportedDate, IncidentDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('B021050001', 2, 1, 'blottered complaint', 'OF21040001', 'Galang, Renato Cruz JR', 'RS21040005', 'Molino, Jessy Faustino ', '2021-04-20', '2021-04-20', '2021-05-09 13:37:09.077', NULL, '2021-05-09 13:37:09.077', '')
GO

INSERT INTO dbo.CasesHeader (Code, TypeID, StatusID, CaseReport, InchargeID, InCharge, ReportedByID, ReportedBy, ReportedDate, IncidentDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('B021050002', 2, 0, 'Ninakaw yung malunggay ko!', 'OF21040002', 'Mendoza, Claire Santos ', 'RS21040006', 'Lucero, John Monzon ', '2021-05-09', '2021-05-08', '2021-05-09 14:23:39.757', NULL, '2021-05-09 14:25:34.567', '')
GO

INSERT INTO dbo.CasesHeader (Code, TypeID, StatusID, CaseReport, InchargeID, InCharge, ReportedByID, ReportedBy, ReportedDate, IncidentDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021040001', 0, 4, 'TEST', 'OF21040001', 'Galang, Renato Cruz JR', 'RS21040005', 'Molino, Jessy Faustino ', '2021-04-20', '2021-04-20', '2021-04-20 18:05:26.54', NULL, '2021-04-21 11:57:15.913', 'master')
GO

INSERT INTO dbo.CasesHeader (Code, TypeID, StatusID, CaseReport, InchargeID, InCharge, ReportedByID, ReportedBy, ReportedDate, IncidentDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C021040002', 0, 0, 'MALI MO PRE!', 'OF21040001', 'Galang, Renato Cruz JR', 'RS21040002', 'Galang, Marjorie Cruz ', '2021-04-21', '2021-04-21', '2021-04-21 02:16:19.47', NULL, '2021-04-21 12:30:03.027', 'master')
GO

IF OBJECT_ID ('dbo.CommitteeOfficers') IS NOT NULL
	DROP TABLE dbo.CommitteeOfficers
GO

CREATE TABLE dbo.CommitteeOfficers
	(
	Seq          INT NOT NULL,
	ID           INT NOT NULL,
	ResidentCode NVARCHAR (10) NOT NULL,
	CreatedDate  DATETIME DEFAULT (getdate()) NULL,
	DeletedDate  DATETIME NULL,
	UpdatedDate  DATETIME NULL,
	UpdatedBy    VARCHAR (20) NULL,
	PRIMARY KEY (Seq, ID, ResidentCode)
	)
GO

IF OBJECT_ID ('dbo.Household') IS NOT NULL
	DROP TABLE dbo.Household
GO

CREATE TABLE dbo.Household
	(
	HouseholdNo  INT IDENTITY NOT NULL,
	HouseNo      NVARCHAR (10) NOT NULL,
	Barangay     VARCHAR (50) NOT NULL,
	Street       VARCHAR (50) NOT NULL,
	Municipality VARCHAR (50) NOT NULL,
	Province     VARCHAR (50) NOT NULL,
	ContactNo    NVARCHAR (20) NULL,
	CreatedDate  DATETIME DEFAULT (getdate()) NULL,
	DeletedDate  DATETIME NULL,
	UpdatedDate  DATETIME NULL,
	UpdatedBy    VARCHAR (20) NULL,
	PRIMARY KEY (HouseNo, HouseholdNo)
	)
GO

INSERT INTO dbo.Household (HouseNo, Barangay, Street, Municipality, Province, ContactNo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('1100', 'Brgy 36', 'Savannah', 'Cavite City', 'Cavite', '406-1234', '2021-04-02 23:24:14.297', NULL, '2021-04-02 23:24:14.297', '')
GO

INSERT INTO dbo.Household (HouseNo, Barangay, Street, Municipality, Province, ContactNo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('1111', 'Brgy 36', 'Savannah', 'Cavite City', 'Cavite', '406-4321', '2021-04-02 23:43:55.65', NULL, '2021-04-02 23:43:55.65', '')
GO

INSERT INTO dbo.Household (HouseNo, Barangay, Street, Municipality, Province, ContactNo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('1112', 'Brgy 36', 'Savannah', 'Cavite City', 'Cavite', '406-7896', '2021-04-02 23:47:11.67', NULL, '2021-04-02 23:47:11.67', '')
GO

INSERT INTO dbo.Household (HouseNo, Barangay, Street, Municipality, Province, ContactNo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('1112', 'Brgy 36', 'Savannah', 'Cavite City', 'Cavite', '406-8531', '2021-04-03 13:28:51.763', NULL, '2021-04-03 13:28:51.763', '')
GO

INSERT INTO dbo.Household (HouseNo, Barangay, Street, Municipality, Province, ContactNo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('1115', 'Brgy 36', 'Savannah', 'Cavite City', 'Cavite', '406-8752', '2021-04-04 01:48:16.097', NULL, '2021-04-04 01:48:16.097', '')
GO

IF OBJECT_ID ('dbo.HouseholdMapping') IS NOT NULL
	DROP TABLE dbo.HouseholdMapping
GO

CREATE TABLE dbo.HouseholdMapping
	(
	HouseLot    NVARCHAR (10) NOT NULL,
	HouseNo     NVARCHAR (10) NULL,
	HouseholdNo INT NULL,
	Remarks     VARCHAR (20) NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	UpdatedBy   VARCHAR (20) NULL,
	PRIMARY KEY (HouseLot)
	)
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl1', NULL, NULL, 'AVAILABLE', '2021-04-20 21:11:56.4', NULL, '2021-04-20 21:11:56.4', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl10', NULL, NULL, 'UNAVAILABLE', '2021-04-20 21:12:16.297', NULL, '2021-04-21 00:13:23.297', '')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl11', NULL, NULL, 'AVAILABLE', '2021-04-20 21:12:16.297', NULL, '2021-04-21 00:11:14.167', '')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl12', NULL, NULL, 'UNAVAILABLE', '2021-04-20 21:12:16.297', NULL, '2021-04-21 00:14:06.283', '')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl13', NULL, NULL, 'AVAILABLE', '2021-04-20 21:12:16.297', NULL, '2021-04-20 21:12:16.297', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl14', NULL, NULL, 'AVAILABLE', '2021-04-20 21:12:16.297', NULL, '2021-04-20 21:12:16.297', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl15', NULL, NULL, 'AVAILABLE', '2021-04-20 21:12:16.297', NULL, '2021-04-20 21:12:16.297', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl16', '1111', 2, 'OCCUPIED', '2021-04-20 21:12:16.297', NULL, '2021-04-21 00:10:41.47', '')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl17', '1112', 4, 'OCCUPIED', '2021-04-20 21:12:16.3', NULL, '2021-04-21 00:07:11.32', '')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl18', NULL, NULL, 'AVAILABLE', '2021-04-20 21:12:16.3', NULL, '2021-04-20 21:12:16.3', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl19', '1112', 3, 'OCCUPIED', '2021-04-20 21:12:16.3', NULL, '2021-04-21 02:13:26.52', '')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl2', NULL, NULL, 'AVAILABLE', '2021-04-20 21:11:56.4', NULL, '2021-04-20 21:11:56.4', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl20', NULL, NULL, 'AVAILABLE', '2021-04-20 21:12:34.583', NULL, '2021-04-20 21:12:34.583', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl21', NULL, NULL, 'AVAILABLE', '2021-04-20 21:12:34.587', NULL, '2021-04-20 21:12:34.587', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl22', NULL, NULL, 'AVAILABLE', '2021-04-20 21:12:34.587', NULL, '2021-04-20 21:12:34.587', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl23', NULL, NULL, 'AVAILABLE', '2021-04-20 21:12:34.587', NULL, '2021-04-20 21:12:34.587', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl24', NULL, NULL, 'AVAILABLE', '2021-04-20 21:12:34.59', NULL, '2021-04-20 21:12:34.59', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl25', NULL, NULL, 'AVAILABLE', '2021-04-20 21:12:34.59', NULL, '2021-04-20 21:12:34.59', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl26', NULL, NULL, 'AVAILABLE', '2021-04-20 21:12:34.59', NULL, '2021-04-20 21:12:34.59', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl27', NULL, NULL, 'AVAILABLE', '2021-04-20 21:12:34.59', NULL, '2021-04-20 21:12:34.59', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl28', NULL, NULL, 'AVAILABLE', '2021-04-20 21:12:34.593', NULL, '2021-04-20 21:12:34.593', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl29', NULL, NULL, 'AVAILABLE', '2021-04-20 21:12:34.593', NULL, '2021-04-20 21:12:34.593', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl3', NULL, NULL, 'AVAILABLE', '2021-04-20 21:11:56.4', NULL, '2021-04-20 21:11:56.4', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl30', NULL, NULL, 'AVAILABLE', '2021-04-20 21:12:54.857', NULL, '2021-04-20 21:12:54.857', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl31', NULL, NULL, 'AVAILABLE', '2021-04-20 21:12:54.857', NULL, '2021-04-20 21:12:54.857', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl32', NULL, NULL, 'AVAILABLE', '2021-04-20 21:12:54.857', NULL, '2021-04-20 21:12:54.857', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl33', NULL, NULL, 'AVAILABLE', '2021-04-20 21:12:54.86', NULL, '2021-04-20 21:12:54.86', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl34', NULL, NULL, 'AVAILABLE', '2021-04-20 21:12:54.86', NULL, '2021-04-20 21:12:54.86', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl35', NULL, NULL, 'AVAILABLE', '2021-04-20 21:12:54.86', NULL, '2021-04-20 21:12:54.86', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl36', NULL, NULL, 'AVAILABLE', '2021-04-20 21:12:54.86', NULL, '2021-04-20 21:12:54.86', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl37', NULL, NULL, 'AVAILABLE', '2021-04-20 21:12:54.86', NULL, '2021-04-20 21:12:54.86', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl38', NULL, NULL, 'AVAILABLE', '2021-04-20 21:12:54.86', NULL, '2021-04-20 21:12:54.86', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl39', NULL, NULL, 'AVAILABLE', '2021-04-20 21:12:54.86', NULL, '2021-04-20 21:12:54.86', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl4', '1111', 2, 'OCCUPIED', '2021-04-20 21:11:56.4', NULL, '2021-04-21 00:08:45.577', '')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl40', NULL, NULL, 'AVAILABLE', '2021-04-20 21:13:22.65', NULL, '2021-04-20 21:13:22.65', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl41', NULL, NULL, 'AVAILABLE', '2021-04-20 21:13:22.65', NULL, '2021-04-20 21:13:22.65', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl42', NULL, NULL, 'AVAILABLE', '2021-04-20 21:13:22.65', NULL, '2021-04-20 21:13:22.65', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl43', NULL, NULL, 'AVAILABLE', '2021-04-20 21:13:22.65', NULL, '2021-04-20 21:13:22.65', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl44', NULL, NULL, 'AVAILABLE', '2021-04-20 21:13:22.653', NULL, '2021-04-20 21:13:22.653', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl45', NULL, NULL, 'AVAILABLE', '2021-04-20 21:13:22.657', NULL, '2021-04-20 21:13:22.657', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl46', NULL, NULL, 'AVAILABLE', '2021-04-20 21:13:22.657', NULL, '2021-04-20 21:13:22.657', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl47', '1100', 1, 'OCCUPIED', '2021-04-20 21:13:22.657', NULL, '2021-04-21 00:05:27.007', '')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl5', NULL, NULL, 'AVAILABLE', '2021-04-20 21:11:56.4', NULL, '2021-04-20 21:11:56.4', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl6', NULL, NULL, 'AVAILABLE', '2021-04-20 21:11:56.4', NULL, '2021-04-20 21:11:56.4', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl7', NULL, NULL, 'AVAILABLE', '2021-04-20 21:11:56.403', NULL, '2021-04-20 21:11:56.403', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl8', NULL, NULL, 'AVAILABLE', '2021-04-20 21:11:56.403', NULL, '2021-04-20 21:11:56.403', 'master')
GO

INSERT INTO dbo.HouseholdMapping (HouseLot, HouseNo, HouseholdNo, Remarks, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('lbl9', NULL, NULL, 'AVAILABLE', '2021-04-20 21:11:56.403', NULL, '2021-04-20 21:11:56.403', 'master')
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
	CreatedDate  DATETIME DEFAULT (getdate()) NULL,
	DeletedDate  DATETIME NULL,
	UpdatedDate  DATETIME NULL,
	UpdatedBy    VARCHAR (20) NULL,
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
VALUES ('1111', 2, 'RS21040003', 1, '2021-04-02 23:43:58.727', NULL, '2021-04-02 23:43:58.727', '')
GO

INSERT INTO dbo.HouseholdMember (HouseNo, HouseholdNo, ResidentCode, Role, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('1112', 2, 'RS21040004', 2, '2021-04-02 23:47:11.697', NULL, '2021-04-02 23:47:11.697', '')
GO

INSERT INTO dbo.HouseholdMember (HouseNo, HouseholdNo, ResidentCode, Role, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('1112', 3, 'RS21040006', 1, '2021-04-03 23:18:58.857', NULL, '2021-04-03 23:18:58.857', '')
GO

INSERT INTO dbo.HouseholdMember (HouseNo, HouseholdNo, ResidentCode, Role, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('1112', 4, 'RS21040005', 1, '2021-04-03 13:28:51.79', NULL, '2021-04-03 13:28:51.79', '')
GO

INSERT INTO dbo.HouseholdMember (HouseNo, HouseholdNo, ResidentCode, Role, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('1115', 5, 'RS21040007', 1, '2021-04-04 01:48:16.113', NULL, '2021-04-04 01:48:16.113', '')
GO

IF OBJECT_ID ('dbo.M_BorrowStatus') IS NOT NULL
	DROP TABLE dbo.M_BorrowStatus
GO

CREATE TABLE dbo.M_BorrowStatus
	(
	ID          INT NOT NULL,
	Description VARCHAR (500) NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	DeletedDate DATETIME NULL,
	UpdatedBy   VARCHAR (10) NULL,
	PRIMARY KEY (ID)
	)
GO

INSERT INTO dbo.M_BorrowStatus (ID, Description, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (1, 'Borrow', '2021-03-24 12:35:00.893', '2021-03-24 12:35:00.893', NULL, 'admin')
GO

INSERT INTO dbo.M_BorrowStatus (ID, Description, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (2, 'Overdue', '2021-03-24 12:35:10.7', '2021-03-24 12:35:10.7', NULL, 'admin')
GO

INSERT INTO dbo.M_BorrowStatus (ID, Description, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (3, 'Cancel', '2021-03-24 12:35:20.403', '2021-03-24 12:35:20.403', NULL, 'admin')
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
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	UpdatedBy   VARCHAR (20) NULL,
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
VALUES (0, 4, 'BLOTTERED', '2021-03-15 07:59:52.71', NULL, '2021-03-15 07:59:52.71', 'master')
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

INSERT INTO dbo.M_CaseStatus (TypeID, StatusID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (3, 0, 'NEW', '2021-03-15 07:59:52.707', NULL, '2021-03-15 07:59:52.707', 'master')
GO

INSERT INTO dbo.M_CaseStatus (TypeID, StatusID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (3, 1, 'ON-GOING', '2021-03-15 07:59:52.707', NULL, '2021-03-15 07:59:52.707', 'master')
GO

INSERT INTO dbo.M_CaseStatus (TypeID, StatusID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (3, 2, 'PENDING', '2021-03-15 07:59:52.707', NULL, '2021-03-15 07:59:52.707', 'master')
GO

INSERT INTO dbo.M_CaseStatus (TypeID, StatusID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (3, 3, 'CLOSED', '2021-03-15 07:59:52.71', NULL, '2021-03-15 07:59:52.71', 'master')
GO

IF OBJECT_ID ('dbo.M_CaseType') IS NOT NULL
	DROP TABLE dbo.M_CaseType
GO

CREATE TABLE dbo.M_CaseType
	(
	ID          INT NOT NULL,
	Description VARCHAR (20) NOT NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	UpdatedBy   VARCHAR (20) NULL,
	PRIMARY KEY (ID)
	)
GO

INSERT INTO dbo.M_CaseType (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (0, 'COMPLAINTS', '2021-03-15 08:05:58.977', NULL, '2021-03-15 08:05:58.977', 'master')
GO

INSERT INTO dbo.M_CaseType (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (1, 'INCIDENTS', '2021-03-15 08:05:59.053', NULL, '2021-03-15 08:05:59.053', 'master')
GO

INSERT INTO dbo.M_CaseType (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (2, 'BLOTTERS', '2021-03-15 08:05:59.053', NULL, '2021-03-15 08:05:59.053', 'master')
GO

INSERT INTO dbo.M_CaseType (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (3, 'VAWC', '2021-03-15 08:05:59.053', NULL, '2021-03-15 08:05:59.053', 'master')
GO

IF OBJECT_ID ('dbo.M_CivilStatus') IS NOT NULL
	DROP TABLE dbo.M_CivilStatus
GO

CREATE TABLE dbo.M_CivilStatus
	(
	ID          INT NOT NULL,
	Description VARCHAR (20) NOT NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	UpdatedBy   VARCHAR (20) NULL,
	PRIMARY KEY (ID)
	)
GO

INSERT INTO dbo.M_CivilStatus (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (0, 'Single', '2021-01-19 09:21:12.343', NULL, '2021-01-19 09:21:12.343', 'master')
GO

INSERT INTO dbo.M_CivilStatus (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (1, 'Married', '2021-01-19 09:21:12.343', NULL, '2021-01-19 09:21:12.343', 'master')
GO

INSERT INTO dbo.M_CivilStatus (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (2, 'Separated', '2021-01-19 09:21:12.347', NULL, '2021-01-19 09:21:12.347', 'master')
GO

INSERT INTO dbo.M_CivilStatus (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (3, 'Widowed', '2021-01-19 09:21:12.347', NULL, '2021-01-19 09:21:12.347', 'master')
GO

IF OBJECT_ID ('dbo.M_Committee') IS NOT NULL
	DROP TABLE dbo.M_Committee
GO

CREATE TABLE dbo.M_Committee
	(
	ID          INT NOT NULL,
	Description VARCHAR (20) NOT NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	UpdatedBy   VARCHAR (20) NULL,
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

IF OBJECT_ID ('dbo.M_HouseholdRole') IS NOT NULL
	DROP TABLE dbo.M_HouseholdRole
GO

CREATE TABLE dbo.M_HouseholdRole
	(
	ID          INT NOT NULL,
	Description VARCHAR (20) NOT NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	UpdatedBy   VARCHAR (20) NULL,
	PRIMARY KEY (ID)
	)
GO

INSERT INTO dbo.M_HouseholdRole (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (1, 'Head', '2021-01-19 14:44:35.14', NULL, '2021-01-19 14:44:35.14', 'master')
GO

INSERT INTO dbo.M_HouseholdRole (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (2, 'Member', '2021-01-19 14:44:41.383', NULL, '2021-01-19 14:44:41.383', 'master')
GO

IF OBJECT_ID ('dbo.M_Items') IS NOT NULL
	DROP TABLE dbo.M_Items
GO

CREATE TABLE dbo.M_Items
	(
	ItemID      NVARCHAR (10) NOT NULL,
	ItemTypeID  INT NOT NULL,
	ItemName    VARCHAR (50) NOT NULL,
	Description VARCHAR (500) NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	DeletedDate DATETIME NULL,
	UpdatedBy   VARCHAR (10) NULL,
	PRIMARY KEY (ItemID)
	)
GO

INSERT INTO dbo.M_Items (ItemID, ItemTypeID, ItemName, Description, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('IT21040001', 2, 'Monitor', '22" PC montors', '2021-04-21 14:08:45.31', '2021-05-05 22:03:05.343', NULL, 'master')
GO

INSERT INTO dbo.M_Items (ItemID, ItemTypeID, ItemName, Description, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('IT21040002', 8, 'Basketball ball', 'Molten Basketball ball', '2021-04-21 14:23:09.157', '2021-05-05 22:03:19.657', NULL, 'master')
GO

IF OBJECT_ID ('dbo.M_ItemsInventory') IS NOT NULL
	DROP TABLE dbo.M_ItemsInventory
GO

CREATE TABLE dbo.M_ItemsInventory
	(
	ItemID      NVARCHAR (10) NOT NULL,
	TotalQTY    INT NULL,
	Stocks      INT NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	DeletedDate DATETIME NULL,
	UpdatedBy   VARCHAR (10) NULL,
	PRIMARY KEY (ItemID)
	)
GO

INSERT INTO dbo.M_ItemsInventory (ItemID, TotalQTY, Stocks, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('IT21040001', 10, 10, '2021-04-21 14:08:45.323', '2021-05-05 22:03:05.357', NULL, 'master')
GO

INSERT INTO dbo.M_ItemsInventory (ItemID, TotalQTY, Stocks, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('IT21040002', 5, 5, '2021-04-21 14:23:10.753', '2021-05-05 22:03:19.67', NULL, 'master')
GO

IF OBJECT_ID ('dbo.M_ItemType') IS NOT NULL
	DROP TABLE dbo.M_ItemType
GO

CREATE TABLE dbo.M_ItemType
	(
	ID          INT IDENTITY NOT NULL,
	Description VARCHAR (50) NOT NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	UpdatedBy   VARCHAR (20) NULL,
	PRIMARY KEY (ID)
	)
GO

INSERT INTO dbo.M_ItemType (Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Office Equipment', '2021-04-21 13:07:44.463', NULL, '2021-04-21 13:07:44.463', 'master')
GO

INSERT INTO dbo.M_ItemType (Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('IT Equipment', '2021-04-21 13:07:44.483', NULL, '2021-04-21 13:07:44.483', 'master')
GO

INSERT INTO dbo.M_ItemType (Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Communication Equipment', '2021-04-21 13:07:44.483', NULL, '2021-04-21 13:07:44.483', 'master')
GO

INSERT INTO dbo.M_ItemType (Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Furniture', '2021-04-21 13:07:44.483', NULL, '2021-04-21 13:07:44.483', 'master')
GO

INSERT INTO dbo.M_ItemType (Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Other Machinery', '2021-04-21 13:07:44.483', NULL, '2021-04-21 13:07:44.483', 'master')
GO

INSERT INTO dbo.M_ItemType (Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Medical Equipment', '2021-04-21 13:07:44.483', NULL, '2021-04-21 13:07:44.483', 'master')
GO

INSERT INTO dbo.M_ItemType (Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Other PPE', '2021-04-21 13:07:44.483', NULL, '2021-04-21 13:07:44.483', 'master')
GO

INSERT INTO dbo.M_ItemType (Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Sport Equipment', '2021-04-21 13:07:44.487', NULL, '2021-04-21 13:07:44.487', 'master')
GO

INSERT INTO dbo.M_ItemType (Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Vehicle', '2021-04-21 13:07:44.487', NULL, '2021-04-21 13:07:44.487', 'master')
GO

IF OBJECT_ID ('dbo.M_OfficialPosition') IS NOT NULL
	DROP TABLE dbo.M_OfficialPosition
GO

CREATE TABLE dbo.M_OfficialPosition
	(
	ID          INT IDENTITY NOT NULL,
	Description VARCHAR (255) NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	UpdatedBy   VARCHAR (20) NULL,
	PRIMARY KEY (ID)
	)
GO

INSERT INTO dbo.M_OfficialPosition (Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Barangay Chairman', '2021-01-26 15:22:43.947', NULL, '2021-01-26 15:22:43.947', 'master')
GO

INSERT INTO dbo.M_OfficialPosition (Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Barangay Kagawad', '2021-01-26 15:22:52.633', NULL, '2021-01-26 15:22:52.633', 'master')
GO

INSERT INTO dbo.M_OfficialPosition (Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('SK Chairman', '2021-01-26 15:23:10.44', NULL, '2021-01-26 15:23:10.44', 'master')
GO

INSERT INTO dbo.M_OfficialPosition (Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('SK Kagawad', '2021-01-26 15:23:16.133', NULL, '2021-01-26 15:23:16.133', 'master')
GO

INSERT INTO dbo.M_OfficialPosition (Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Secretary', '2021-01-26 15:23:23.223', NULL, '2021-01-26 15:23:23.223', 'master')
GO

INSERT INTO dbo.M_OfficialPosition (Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Chief Tanod', '2021-01-26 15:23:39.547', NULL, '2021-01-26 15:23:39.547', 'master')
GO

INSERT INTO dbo.M_OfficialPosition (Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Barangay Tanod', '2021-01-26 15:23:43.92', NULL, '2021-01-26 15:23:43.92', 'master')
GO

INSERT INTO dbo.M_OfficialPosition (Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Committee', '2021-01-26 15:23:43.92', NULL, '2021-01-26 15:23:43.92', 'master')
GO

INSERT INTO dbo.M_OfficialPosition (Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Treasurer', '2021-01-26 15:23:43.92', NULL, '2021-01-26 15:23:43.92', 'master')
GO

IF OBJECT_ID ('dbo.M_OfficialsRank') IS NOT NULL
	DROP TABLE dbo.M_OfficialsRank
GO

CREATE TABLE dbo.M_OfficialsRank
	(
	ID          INT NOT NULL,
	Description VARCHAR (20) NOT NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	UpdatedBy   VARCHAR (20) NULL,
	PRIMARY KEY (ID)
	)
GO

INSERT INTO dbo.M_OfficialsRank (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (1, 'RANK 1', '2021-04-07 08:51:31.013', NULL, '2021-04-07 08:51:31.013', 'master')
GO

INSERT INTO dbo.M_OfficialsRank (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (2, 'RANK 2', '2021-04-07 08:51:31.017', NULL, '2021-04-07 08:51:31.017', 'master')
GO

INSERT INTO dbo.M_OfficialsRank (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (3, 'RANK 3', '2021-04-07 08:51:31.017', NULL, '2021-04-07 08:51:31.017', 'master')
GO

INSERT INTO dbo.M_OfficialsRank (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (4, 'RANK 4', '2021-04-07 08:51:31.017', NULL, '2021-04-07 08:51:31.017', 'master')
GO

INSERT INTO dbo.M_OfficialsRank (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (5, 'RANK 5', '2021-04-07 08:51:31.017', NULL, '2021-04-07 08:51:31.017', 'master')
GO

INSERT INTO dbo.M_OfficialsRank (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (6, 'RANK 6', '2021-04-07 08:51:31.017', NULL, '2021-04-07 08:51:31.017', 'master')
GO

INSERT INTO dbo.M_OfficialsRank (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (7, 'RANK 7', '2021-04-07 08:51:31.017', NULL, '2021-04-07 08:51:31.017', 'master')
GO

IF OBJECT_ID ('dbo.M_OfficialsStatus') IS NOT NULL
	DROP TABLE dbo.M_OfficialsStatus
GO

CREATE TABLE dbo.M_OfficialsStatus
	(
	ID          INT NOT NULL,
	Description VARCHAR (20) NOT NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	UpdatedBy   VARCHAR (20) NULL,
	PRIMARY KEY (ID)
	)
GO

INSERT INTO dbo.M_OfficialsStatus (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (1, 'STATUS A', '2021-04-07 08:52:34.687', NULL, '2021-04-07 08:52:34.687', 'master')
GO

INSERT INTO dbo.M_OfficialsStatus (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (2, 'STATUS B', '2021-04-07 08:52:34.687', NULL, '2021-04-07 08:52:34.687', 'master')
GO

INSERT INTO dbo.M_OfficialsStatus (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (3, 'STATUS C', '2021-04-07 08:52:34.687', NULL, '2021-04-07 08:52:34.687', 'master')
GO

INSERT INTO dbo.M_OfficialsStatus (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (4, 'STATUS D', '2021-04-07 08:52:34.687', NULL, '2021-04-07 08:52:34.687', 'master')
GO

INSERT INTO dbo.M_OfficialsStatus (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (5, 'STATUS E', '2021-04-07 08:52:34.69', NULL, '2021-04-07 08:52:34.69', 'master')
GO

IF OBJECT_ID ('dbo.M_ReturnStatus') IS NOT NULL
	DROP TABLE dbo.M_ReturnStatus
GO

CREATE TABLE dbo.M_ReturnStatus
	(
	ID          INT NOT NULL,
	Description VARCHAR (20) NOT NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	UpdatedBy   VARCHAR (20) NULL,
	PRIMARY KEY (ID)
	)
GO

INSERT INTO dbo.M_ReturnStatus (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (1, 'COMPLETE', '2021-04-12 10:08:39.057', NULL, '2021-04-12 10:08:39.057', 'master')
GO

INSERT INTO dbo.M_ReturnStatus (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (2, 'INCOMPLETE', '2021-04-12 10:08:39.057', NULL, '2021-04-12 10:08:39.057', 'master')
GO

INSERT INTO dbo.M_ReturnStatus (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (3, 'LOST', '2021-04-12 10:08:39.06', NULL, '2021-04-12 10:08:39.06', 'master')
GO

IF OBJECT_ID ('dbo.M_Samahan') IS NOT NULL
	DROP TABLE dbo.M_Samahan
GO

CREATE TABLE dbo.M_Samahan
	(
	ID          INT IDENTITY NOT NULL,
	Title       VARCHAR (20) NOT NULL,
	Description VARCHAR (255) NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	UpdatedBy   VARCHAR (20) NULL,
	PRIMARY KEY (ID)
	)
GO

INSERT INTO dbo.M_Samahan (Title, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Mandaragat', 'Samahan ng mga Mangingisda.', '2021-03-26 09:00:44.603', NULL, '2021-03-26 12:17:52.017', '')
GO

INSERT INTO dbo.M_Samahan (Title, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Kababaihan', 'Samahan ng mga Babae.', '2021-03-26 09:09:21.547', NULL, '2021-03-26 12:17:43.373', '')
GO

INSERT INTO dbo.M_Samahan (Title, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Manggagawa', 'Samahan ng mga Construction Worker.', '2021-03-26 12:18:15.267', NULL, '2021-03-26 12:18:15.267', '')
GO

IF OBJECT_ID ('dbo.M_Street') IS NOT NULL
	DROP TABLE dbo.M_Street
GO

CREATE TABLE dbo.M_Street
	(
	ID          INT IDENTITY NOT NULL,
	Name        VARCHAR (20) NOT NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	UpdatedBy   VARCHAR (20) NULL,
	PRIMARY KEY (ID)
	)
GO

INSERT INTO dbo.M_Street (Name, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Aguilar', '2021-05-15 23:37:08.443', NULL, '2021-05-15 23:37:08.443', '')
GO

INSERT INTO dbo.M_Street (Name, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Cabuco Street', '2021-05-15 23:37:49.493', NULL, '2021-05-15 23:37:49.493', '')
GO

IF OBJECT_ID ('dbo.M_UserAccounts') IS NOT NULL
	DROP TABLE dbo.M_UserAccounts
GO

CREATE TABLE dbo.M_UserAccounts
	(
	UserID      VARCHAR (10) NOT NULL,
	UserName    VARCHAR (20) NOT NULL,
	Password    VARCHAR (20) NOT NULL,
	UserLevel   INT NOT NULL,
	isActive    BIT DEFAULT ((1)) NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	UpdatedBy   VARCHAR (20) NULL,
	PRIMARY KEY (UserID)
	)
GO

INSERT INTO dbo.M_UserAccounts (UserID, UserName, Password, UserLevel, isActive, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('A21030001', 'master', 'master', 0, 1, '2021-03-18 14:32:48.96', NULL, '2021-03-18 14:32:48.96', 'user')
GO

IF OBJECT_ID ('dbo.M_UserLevel') IS NOT NULL
	DROP TABLE dbo.M_UserLevel
GO

CREATE TABLE dbo.M_UserLevel
	(
	ID          INT NOT NULL,
	Description VARCHAR (20) NOT NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	UpdatedBy   VARCHAR (20) NULL,
	PRIMARY KEY (ID)
	)
GO

INSERT INTO dbo.M_UserLevel (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (0, 'Admin', '2021-01-18 06:52:16.95', NULL, '2021-01-18 06:52:16.95', 'master')
GO

INSERT INTO dbo.M_UserLevel (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (1, 'User', '2021-01-18 06:52:24.077', NULL, '2021-01-18 06:52:24.077', 'master')
GO

IF OBJECT_ID ('dbo.M_VerificationQuestion') IS NOT NULL
	DROP TABLE dbo.M_VerificationQuestion
GO

CREATE TABLE dbo.M_VerificationQuestion
	(
	ID          INT IDENTITY NOT NULL,
	Question    VARCHAR (50) NOT NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	UpdatedBy   VARCHAR (20) NULL,
	PRIMARY KEY (ID)
	)
GO

INSERT INTO dbo.M_VerificationQuestion (Question, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('A', '2021-03-18 12:16:17.233', NULL, '2021-03-18 12:16:17.233', 'script')
GO

INSERT INTO dbo.M_VerificationQuestion (Question, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('B', '2021-03-18 12:16:17.3', NULL, '2021-03-18 12:16:17.3', 'script')
GO

INSERT INTO dbo.M_VerificationQuestion (Question, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('C', '2021-03-18 12:16:17.3', NULL, '2021-03-18 12:16:17.3', 'script')
GO

INSERT INTO dbo.M_VerificationQuestion (Question, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('D', '2021-03-18 12:16:17.3', NULL, '2021-03-18 12:16:17.3', 'script')
GO

INSERT INTO dbo.M_VerificationQuestion (Question, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('E', '2021-03-18 12:16:17.3', NULL, '2021-03-18 12:16:17.3', 'script')
GO

IF OBJECT_ID ('dbo.Officials') IS NOT NULL
	DROP TABLE dbo.Officials
GO

CREATE TABLE dbo.Officials
	(
	Code         NVARCHAR (10) NOT NULL,
	ResidentCode NVARCHAR (10) NOT NULL,
	PositionID   INT NOT NULL,
	RankID       INT NOT NULL,
	CommitteeID  INT NULL,
	TermStart    DATETIME NOT NULL,
	TermEnd      DATETIME NOT NULL,
	StatusID     INT NOT NULL,
	ContactNo    NVARCHAR (20) NULL,
	CreatedDate  DATETIME DEFAULT (getdate()) NULL,
	DeletedDate  DATETIME NULL,
	UpdatedDate  DATETIME NULL,
	UpdatedBy    VARCHAR (20) NULL,
	PRIMARY KEY (Code, ResidentCode, PositionID)
	)
GO

INSERT INTO dbo.Officials (Code, ResidentCode, PositionID, RankID, CommitteeID, TermStart, TermEnd, StatusID, ContactNo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('OF21040001', 'RS21040001', 1, 1, NULL, '2021-04-07', '2024-04-07', 1, '(+63)923-758-2523', '2021-04-07 12:17:27.19', NULL, '2021-04-07 12:17:27.19', '')
GO

INSERT INTO dbo.Officials (Code, ResidentCode, PositionID, RankID, CommitteeID, TermStart, TermEnd, StatusID, ContactNo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('OF21040002', 'RS21040003', 2, 1, 3, '2021-04-16', '2024-04-16', 1, '(+63)965-235-2354', '2021-04-16 07:07:32.447', NULL, '2021-04-16 07:07:32.447', '')
GO

INSERT INTO dbo.Officials (Code, ResidentCode, PositionID, RankID, CommitteeID, TermStart, TermEnd, StatusID, ContactNo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('OF21040003', 'RS21040004', 3, 1, 5, '2021-04-16', '2024-04-16', 1, '(+63)997-285-7245', '2021-04-16 07:11:13.13', NULL, '2021-04-16 07:11:13.13', '')
GO

IF OBJECT_ID ('dbo.Residents') IS NOT NULL
	DROP TABLE dbo.Residents
GO

CREATE TABLE dbo.Residents
	(
	Code            NVARCHAR (10) NOT NULL,
	FamilyName      VARCHAR (50) NOT NULL,
	GivenName       VARCHAR (50) NOT NULL,
	MiddleName      VARCHAR (50) NULL,
	ExtensionName   VARCHAR (20) NULL,
	Gender          VARCHAR (1) NOT NULL,
	BirthDate       DATETIME NOT NULL,
	BirthPlace      VARCHAR (100) NOT NULL,
	Citizenship     VARCHAR (20) NOT NULL,
	CivilStatus     INT NOT NULL,
	ContactNo       NVARCHAR (20) NULL,
	Occupation      VARCHAR (50) NULL,
	SamahanID       INT NULL,
	isVoter         BIT DEFAULT ((0)) NOT NULL,
	inHabitant      BIT DEFAULT ((1)) NOT NULL,
	Indigent        BIT DEFAULT ((0)) NOT NULL,
	isPWD           BIT DEFAULT ((0)) NOT NULL,
	Disabilities    VARCHAR (100) NULL,
	isPregnant      BIT DEFAULT ((0)) NOT NULL,
	DeliveryDate    DATETIME NULL,
	DateOfCaseStudy DATETIME NULL,
	CreatedDate     DATETIME DEFAULT (getdate()) NULL,
	DeletedDate     DATETIME NULL,
	UpdatedDate     DATETIME NULL,
	UpdatedBy       VARCHAR (20) NULL,
	PRIMARY KEY (Code, FamilyName, GivenName)
	)
GO

INSERT INTO dbo.Residents (Code, FamilyName, GivenName, MiddleName, ExtensionName, Gender, BirthDate, BirthPlace, Citizenship, CivilStatus, ContactNo, Occupation, SamahanID, isVoter, inHabitant, Indigent, isPWD, Disabilities, isPregnant, DeliveryDate, DateOfCaseStudy, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('RS21040001', 'Galang', 'Renato', 'Cruz', 'JR', 'M', '1965-11-02', 'Cavite City', 'Filipino', 1, '(+63)923-758-2523', 'Fisherman', 2, 1, 1, 0, 0, '', 0, NULL, NULL, '2021-04-02 23:23:40.133', NULL, '2021-04-16 07:10:31.35', '')
GO

INSERT INTO dbo.Residents (Code, FamilyName, GivenName, MiddleName, ExtensionName, Gender, BirthDate, BirthPlace, Citizenship, CivilStatus, ContactNo, Occupation, SamahanID, isVoter, inHabitant, Indigent, isPWD, Disabilities, isPregnant, DeliveryDate, DateOfCaseStudy, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('RS21040002', 'Galang', 'Marjorie', 'Cruz', '', 'F', '1995-08-02', 'Cavite City', 'Filipino', 1, '(+63)938-625-5233', 'None', NULL, 1, 1, 0, 1, 'Mute', 0, NULL, '2021-04-02', '2021-04-02 23:28:32.83', NULL, '2021-04-04 13:04:38.057', '')
GO

INSERT INTO dbo.Residents (Code, FamilyName, GivenName, MiddleName, ExtensionName, Gender, BirthDate, BirthPlace, Citizenship, CivilStatus, ContactNo, Occupation, SamahanID, isVoter, inHabitant, Indigent, isPWD, Disabilities, isPregnant, DeliveryDate, DateOfCaseStudy, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('RS21040003', 'Mendoza', 'Claire', 'Santos', '', 'F', '1977-04-02', 'Cavite City', 'Filipino', 3, '(+63)965-235-2354', 'Vendor', 1, 1, 1, 0, 0, '', 0, NULL, '2021-04-03', '2021-04-02 23:43:50.74', NULL, '2021-04-16 06:45:13.653', '')
GO

INSERT INTO dbo.Residents (Code, FamilyName, GivenName, MiddleName, ExtensionName, Gender, BirthDate, BirthPlace, Citizenship, CivilStatus, ContactNo, Occupation, SamahanID, isVoter, inHabitant, Indigent, isPWD, Disabilities, isPregnant, DeliveryDate, DateOfCaseStudy, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('RS21040004', 'Lucero', 'Jayvee', '', '', 'M', '2000-04-02', 'Cavite City', 'Filipino', 0, '(+63)997-285-7245', 'Crew', 3, 1, 1, 0, 0, '', 0, NULL, '2021-04-03', '2021-04-02 23:47:11.62', NULL, '2021-04-16 06:44:35.08', '')
GO

INSERT INTO dbo.Residents (Code, FamilyName, GivenName, MiddleName, ExtensionName, Gender, BirthDate, BirthPlace, Citizenship, CivilStatus, ContactNo, Occupation, SamahanID, isVoter, inHabitant, Indigent, isPWD, Disabilities, isPregnant, DeliveryDate, DateOfCaseStudy, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('RS21040005', 'Molino', 'Jessy', 'Faustino', '', 'F', '1975-04-03', 'Cavite City', 'Filipino', 2, '(+63)965-275-2237', 'Vendor', 1, 1, 1, 1, 0, '', 1, '2021-12-04', '2021-04-03', '2021-04-03 13:28:51.72', NULL, '2021-04-28 18:53:17.82', '')
GO

INSERT INTO dbo.Residents (Code, FamilyName, GivenName, MiddleName, ExtensionName, Gender, BirthDate, BirthPlace, Citizenship, CivilStatus, ContactNo, Occupation, SamahanID, isVoter, inHabitant, Indigent, isPWD, Disabilities, isPregnant, DeliveryDate, DateOfCaseStudy, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('RS21040006', 'Lucero', 'John', 'Monzon', '', 'M', '1963-04-03', 'Cavite City', 'Filipino', 3, '(+63)997-236-5232', 'None', NULL, 1, 1, 0, 1, 'Handicaped', 0, NULL, '2021-04-03', '2021-04-03 23:18:58.67', NULL, '2021-04-03 23:18:58.67', '')
GO

INSERT INTO dbo.Residents (Code, FamilyName, GivenName, MiddleName, ExtensionName, Gender, BirthDate, BirthPlace, Citizenship, CivilStatus, ContactNo, Occupation, SamahanID, isVoter, inHabitant, Indigent, isPWD, Disabilities, isPregnant, DeliveryDate, DateOfCaseStudy, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('RS21040007', 'Madriaga', 'Jason', 'Montano', '', 'M', '1990-09-04', 'Cavite City', 'Filipino', 1, '(+63)997-254-5452', 'Welder', NULL, 1, 1, 0, 0, '', 0, NULL, '2021-04-04', '2021-04-04 01:48:16.05', NULL, '2021-04-04 01:48:16.05', '')
GO

IF OBJECT_ID ('dbo.T_BorrowDetails') IS NOT NULL
	DROP TABLE dbo.T_BorrowDetails
GO

CREATE TABLE dbo.T_BorrowDetails
	(
	BorrowCode  NVARCHAR (10) NOT NULL,
	SeqNo       INT NOT NULL,
	ItemID      NVARCHAR (10) NULL,
	QTY         INT NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	DeletedDate DATETIME NULL,
	UpdatedBy   VARCHAR (10) NULL,
	PRIMARY KEY (BorrowCode, SeqNo)
	)
GO

INSERT INTO dbo.T_BorrowDetails (BorrowCode, SeqNo, ItemID, QTY, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('BW21050001', 1, 'IT21040001', 4, '2021-05-02 02:03:00.81', '2021-05-02 02:03:00.81', NULL, '')
GO

INSERT INTO dbo.T_BorrowDetails (BorrowCode, SeqNo, ItemID, QTY, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('BW21050001', 2, 'IT21040002', 3, '2021-05-02 02:03:00.857', '2021-05-02 02:03:00.857', NULL, '')
GO

INSERT INTO dbo.T_BorrowDetails (BorrowCode, SeqNo, ItemID, QTY, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('BW21050002', 1, 'IT21040001', 1, '2021-05-02 12:39:58.243', '2021-05-02 12:39:58.243', NULL, '')
GO

INSERT INTO dbo.T_BorrowDetails (BorrowCode, SeqNo, ItemID, QTY, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('BW21050002', 2, 'IT21040002', 1, '2021-05-02 12:39:58.27', '2021-05-02 12:39:58.27', NULL, '')
GO

IF OBJECT_ID ('dbo.T_BorrowHeader') IS NOT NULL
	DROP TABLE dbo.T_BorrowHeader
GO

CREATE TABLE dbo.T_BorrowHeader
	(
	BorrowCode   NVARCHAR (10) NOT NULL,
	BorrowerName VARCHAR (200) NULL,
	BorrowerID   NVARCHAR (10) NULL,
	isResidence  BIT NULL,
	inCharge     VARCHAR (200) NULL,
	inChargeID   NVARCHAR (10) NULL,
	StatusID     INT NULL,
	ContactNo    NVARCHAR (20) NULL,
	BorrowedDate DATETIME NULL,
	ReturnDate   DATETIME NULL,
	CreatedDate  DATETIME NULL,
	UpdatedDate  DATETIME NULL,
	DeletedDate  DATETIME NULL,
	UpdatedBy    VARCHAR (10) NULL,
	PRIMARY KEY (BorrowCode)
	)
GO

INSERT INTO dbo.T_BorrowHeader (BorrowCode, BorrowerName, BorrowerID, isResidence, inCharge, inChargeID, StatusID, ContactNo, BorrowedDate, ReturnDate, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('BW21050001', 'Galang, Marjorie Cruz ', 'RS21040002', 1, 'Lucero, Jayvee  ', 'OF21040003', 4, '(+63)997-958-4822', '2021-05-02', '2021-05-05 21:32:15.173', '2021-05-02 02:03:00.767', '2021-05-05 21:32:15.173', NULL, 'master')
GO

INSERT INTO dbo.T_BorrowHeader (BorrowCode, BorrowerName, BorrowerID, isResidence, inCharge, inChargeID, StatusID, ContactNo, BorrowedDate, ReturnDate, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('BW21050002', 'Madriaga, Jason Montano ', 'RS21040007', 1, 'Lucero, Jayvee  ', 'OF21040003', 4, '(+63)997-885-4571', '2021-05-02', '2021-05-05 21:52:35.54', '2021-05-02 12:39:58.23', '2021-05-05 21:52:35.54', NULL, 'master')
GO

IF OBJECT_ID ('dbo.UserQuestion') IS NOT NULL
	DROP TABLE dbo.UserQuestion
GO

CREATE TABLE dbo.UserQuestion
	(
	UserID      VARCHAR (10) NOT NULL,
	QuestionID1 INT NOT NULL,
	Answer1     VARCHAR (100) NULL,
	QuestionID2 INT NOT NULL,
	Answer2     VARCHAR (100) NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	DeletedDate DATETIME NULL,
	UpdatedBy   VARCHAR (10) NULL,
	PRIMARY KEY (UserID)
	)
GO

INSERT INTO dbo.UserQuestion (UserID, QuestionID1, Answer1, QuestionID2, Answer2, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('A21030001', 1, 'a', 2, 'b', '2021-03-18 14:34:55.777', '2021-03-18 14:34:55.777', NULL, 'script')
GO

