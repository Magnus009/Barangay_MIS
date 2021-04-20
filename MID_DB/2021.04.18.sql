
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


IF OBJECT_ID ('dbo.CasesDetails') IS NOT NULL
	DROP TABLE dbo.CasesDetails
GO

CREATE TABLE dbo.CasesDetails
	(
	Code           NVARCHAR (10) NOT NULL,
	Seq            INT NOT NULL,
	ResidentCode NVARCHAR(10),
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


IF OBJECT_ID ('dbo.M_Committee') IS NOT NULL
	DROP TABLE dbo.M_Committee
GO

CREATE TABLE dbo.M_Committee
	(
	ID          INT NOT NULL IDENTITY,
	Description VARCHAR (20) NOT NULL,
	CreatedDate DATETIME DEFAULT (getdate()),
	DeletedDate DATETIME,
	UpdatedDate DATETIME,
	UpdatedBy   VARCHAR (20),
	PRIMARY KEY (ID)
	)
GO


INSERT INTO dbo.M_Committee ( Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ( 'Fishery', '2021-04-07 08:53:35.01', NULL, '2021-04-07 08:53:35.01', 'master')
GO

INSERT INTO dbo.M_Committee ( Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ( 'Finance', '2021-04-07 08:53:35.01', NULL, '2021-04-07 08:53:35.01', 'master')
GO

INSERT INTO dbo.M_Committee ( Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ( 'Disaster', '2021-04-07 08:53:35.01', NULL, '2021-04-07 08:53:35.01', 'master')
GO

INSERT INTO dbo.M_Committee ( Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ( 'Health/Education', '2021-04-07 08:53:35.01', NULL, '2021-04-07 08:53:35.01', 'master')
GO

INSERT INTO dbo.M_Committee ( Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ( 'Peace', '2021-04-07 08:53:35.01', NULL, '2021-04-07 08:53:35.01', 'master')
GO

INSERT INTO dbo.M_Committee ( Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ( 'Cleanliness', '2021-04-07 08:53:35.01', NULL, '2021-04-07 08:53:35.01', 'master')
GO

INSERT INTO dbo.M_Committee ( Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ( 'Public Work', '2021-04-07 08:53:35.01', NULL, '2021-04-07 08:53:35.01', 'master')
GO

