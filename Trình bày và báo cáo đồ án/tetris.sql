CREATE DATABASE TetrisDataBase

GO
USE TetrisDataBase
GO

CREATE TABLE GameAccount
(
    AccountId TINYINT PRIMARY KEY IDENTITY(1,1),
    UserName VARCHAR(30) UNIQUE NOT NULL,
    PassWord VARCHAR(30) NOT NULL,
	PlayerName VARCHAR(15) UNIQUE NOT NULL,
);

CREATE TABLE GameSession
(
    SessionId SMALLINT PRIMARY KEY IDENTITY(1,1),
    AccountId TINYINT,
    Scores INT,
    TotalTime CHAR(8),
    Initials VARCHAR(15),
    Level TINYINT,
    FOREIGN KEY (AccountId) REFERENCES GameAccount(AccountId)
);

INSERT INTO GameSession(AccountId, Scores, TotalTime, Initials, Level) VALUES (NULL, 0, '00:00:00', '', 1) SELECT SCOPE_IDENTITY();
