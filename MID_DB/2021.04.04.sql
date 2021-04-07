IF OBJECT_ID ('dbo.Officials') IS NOT NULL
	DROP TABLE dbo.Officials
GO

CREATE TABLE dbo.Officials
	(
	Code         NVARCHAR (10) NOT NULL,
	ResidentCode NVARCHAR (10) NOT NULL,
	Position     VARCHAR (50) NOT NULL,
	RankID       INT NOT NULL,
	CommitteeID  INT NOT NULL,
	TermStart    DATETIME NOT NULL,
	TermEnd      DATETIME NOT NULL,
	StatusID     INT NOT NULL,
	CreatedDate  DATETIME DEFAULT (getdate()),
	DeletedDate  DATETIME,
	UpdatedDate  DATETIME,
	UpdatedBy    VARCHAR (20),
	PRIMARY KEY (Code, ResidentCode, Position)
	)
GO


ALTER TABLE Officials
ALTER COLUMN CommitteeID INT
