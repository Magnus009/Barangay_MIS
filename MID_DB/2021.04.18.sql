
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

