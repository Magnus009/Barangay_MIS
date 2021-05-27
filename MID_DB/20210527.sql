IF OBJECT_ID ('dbo.LotPosition') IS NOT NULL
	DROP TABLE dbo.LotPosition
GO

CREATE TABLE dbo.LotPosition
	(
	LotID       INT NOT NULL,
	LotNo       INT NOT NULL,
	X           NVARCHAR (12),
	Y           NVARCHAR (12),
	Width       NVARCHAR (12),
	Height      NVARCHAR (12),
	CreatedDate DATETIME,
	UpdatedDate DATETIME,
	DeletedDate DATETIME,
	UpdatedBy   VARCHAR (10),
	PRIMARY KEY (LotID, LotNo)
	)
GO


INSERT INTO dbo.LotPosition (LotID, LotNo, X, Y, Width, Height, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (1, 1, '358', '60', '35', '48', '2021-05-27 14:08:42.89', '2021-05-27 14:08:42.89', NULL, '')
GO

INSERT INTO dbo.LotPosition (LotID, LotNo, X, Y, Width, Height, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (2, 1, '358', '111', '81', '19', '2021-05-27 14:09:04.3', '2021-05-27 14:09:04.3', NULL, '')
GO

INSERT INTO dbo.LotPosition (LotID, LotNo, X, Y, Width, Height, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (3, 1, '345', '133', '31', '31', '2021-05-27 14:18:45.02', '2021-05-27 14:18:45.02', NULL, '')
GO

INSERT INTO dbo.LotPosition (LotID, LotNo, X, Y, Width, Height, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (4, 1, '379', '133', '42', '22', '2021-05-27 14:19:26.937', '2021-05-27 14:19:26.937', NULL, '')
GO

INSERT INTO dbo.LotPosition (LotID, LotNo, X, Y, Width, Height, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (5, 1, '379', '157', '45', '28', '2021-05-27 14:20:02.903', '2021-05-27 14:20:02.903', NULL, '')
GO

INSERT INTO dbo.LotPosition (LotID, LotNo, X, Y, Width, Height, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (6, 1, '395', '74', '35', '33', '2021-05-27 14:20:31.123', '2021-05-27 14:20:31.123', NULL, '')
GO

INSERT INTO dbo.LotPosition (LotID, LotNo, X, Y, Width, Height, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (7, 1, '428', '133', '21', '22', '2021-05-27 14:20:55.673', '2021-05-27 14:24:27.46', NULL, '')
GO

INSERT INTO dbo.LotPosition (LotID, LotNo, X, Y, Width, Height, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (7, 2, '428', '155', '21', '22', '2021-05-27 14:24:27.54', '2021-05-27 14:24:27.54', NULL, '')
GO

INSERT INTO dbo.LotPosition (LotID, LotNo, X, Y, Width, Height, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (8, 1, '333', '167', '42', '33', '2021-05-27 14:23:08.713', '2021-05-27 14:23:08.713', NULL, '')
GO



IF OBJECT_ID ('dbo.Mapping') IS NOT NULL
	DROP TABLE dbo.Mapping
GO

CREATE TABLE dbo.Mapping
	(
	LotID       INT NOT NULL,
	LotNo       INT NOT NULL,
	HouseNo     NVARCHAR (10) NOT NULL,
	HouseholdNo INT NOT NULL,
	CreatedDate DATETIME DEFAULT (getdate()),
	DeletedDate DATETIME,
	UpdatedDate DATETIME,
	UpdatedBy   VARCHAR (20),
	PRIMARY KEY (LotID, LotNo, HouseNo, HouseholdNo)
	)
GO

INSERT INTO dbo.Mapping (LotID, LotNo, HouseNo, HouseholdNo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (1, 1, '1100', 1, '2021-05-27 14:08:49.617', NULL, '2021-05-27 14:08:49.617', '')
GO

INSERT INTO dbo.Mapping (LotID, LotNo, HouseNo, HouseholdNo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (2, 1, '1111', 2, '2021-05-27 14:09:10.04', NULL, '2021-05-27 14:09:10.04', '')
GO

INSERT INTO dbo.Mapping (LotID, LotNo, HouseNo, HouseholdNo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (3, 1, '1112', 3, '2021-05-27 14:18:50.843', NULL, '2021-05-27 14:18:50.843', '')
GO

INSERT INTO dbo.Mapping (LotID, LotNo, HouseNo, HouseholdNo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (4, 1, '1112', 4, '2021-05-27 14:19:32.51', NULL, '2021-05-27 14:19:32.51', '')
GO

INSERT INTO dbo.Mapping (LotID, LotNo, HouseNo, HouseholdNo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (5, 1, '1115', 5, '2021-05-27 14:20:08.127', NULL, '2021-05-27 14:20:08.127', '')
GO

INSERT INTO dbo.Mapping (LotID, LotNo, HouseNo, HouseholdNo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (6, 1, '1100', 1, '2021-05-27 14:20:37.137', NULL, '2021-05-27 14:20:37.137', '')
GO

INSERT INTO dbo.Mapping (LotID, LotNo, HouseNo, HouseholdNo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (7, 1, '1111', 2, '2021-05-27 14:21:34.17', NULL, '2021-05-27 14:21:34.17', '')
GO

INSERT INTO dbo.Mapping (LotID, LotNo, HouseNo, HouseholdNo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (7, 2, '1115', 5, '2021-05-27 14:24:33.793', NULL, '2021-05-27 14:24:33.793', '')
GO

INSERT INTO dbo.Mapping (LotID, LotNo, HouseNo, HouseholdNo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (8, 1, '1112', 4, '2021-05-27 14:23:14.423', NULL, '2021-05-27 14:23:14.423', '')
GO

