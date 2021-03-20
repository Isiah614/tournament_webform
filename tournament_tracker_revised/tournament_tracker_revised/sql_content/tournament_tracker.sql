USE master
GO

IF DB_ID('generictournamenttemplate') IS NOT NULL DROP DATABASE 'generictournamenttemplate';

CREATE DATABASE generictournamenttemplate;
GO

USE generictournamenttemplate;
GO

BEGIN TRANSACTION

CREATE TABLE Tournaments(
id int IDENTITY(1000, 1) NOT NULL, 
TournamentName nvarchar(100) NOT NULL,
EntryFee int NOT NULL,
CONSTRAINT PK_tournaments PRIMARY KEY (id)
)

CREATE TABLE TournamentEntries (
id int IDENTITY (1000, 1) NOT NULL,
TournamentID int NOT NULL,
TeamID int NOT NULL,
CONSTRAINT PK_tournamententries PRIMARY KEY (id),
CONSTRAINT FK_tournamentid FOREIGN KEY (TournamentID) references Tournaments (id)
)

CREATE TABLE TournamentPrizes(
id int IDENTITY (1000,1) NOT NULL,
TournamentID int NOT NULL,
PrizeID int NOT NULL,
CONSTRAINT PK_tournamentprizes PRIMARY KEY (id),
CONSTRAINT FK_tournamentprizesid FOREIGN KEY (TournamentID) references Tournaments (id)
)

CREATE TABLE Prizes(
id int IDENTITY (1000,1) NOT NULL,
PlaceNumber int NOT NULL,
PlaceName nvarchar(50) NOT NULL,
PrizeAmount money NOT NULL,
PrizePercentage float NOT NULL,
CONSTRAINT PK_prizes PRIMARY KEY CLUSTERED
(
[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON))
GO

ALTER TABLE [dbo].[Prizes] ADD CONSTRAINT [DF_Prizes_PrizesAmount] DEFAULT ((0)) FOR [PrizeAmount]
GO

ALTER TABLE [dbo].[Prizes] ADD CONSTRAINT [DF_Prizes_PrizePercentage] DEFAULT ((0)) FOR [PrizePercentage]
GO


CREATE TABLE Teams(
id int IDENTITY (2000,1) NOT NULL,
TeamName nvarchar(100) NOT NULL,
CONSTRAINT PK_teamsid PRIMARY KEY (id)
)

CREATE TABLE TeamMembers(
id int IDENTITY (2000,1) NOT NULL,
TeamID int NOT NULL,
PersonID int NOT NULL,
CONSTRAINT PK_teammembersid PRIMARY KEY (id),
CONSTRAINT FK_teammembersteamid FOREIGN KEY (TeamID) references Teams (id)
)

CREATE TABLE People(
id int IDENTITY (2000,1) NOT NULL,
UserName varchar(20) NOT NULL,
FirstName nvarchar(100) NOT NULL,
LastName nvarchar(100) NOT NULL,
EmailAddress nvarchar(100) NOT NULL,
CellPhoneNumber nvarchar(10) NOT NULL,
CONSTRAINT PK_peopleid PRIMARY KEY (id)
)

CREATE TABLE Matchups(
id int IDENTITY(3000,1) NOT NULL,
WinnerId int NOT NULL,
MatchupRound nvarchar(10),
CONSTRAINT PK_matchupsid PRIMARY KEY(id)
)

CREATE TABLE MatchupEntries(
id int IDENTITY(3000,1) NOT NULL,
MatchupID int NOT NULL,
ParentMatchUpId int NOT NULL,
TeamsCompetingId int NOT NULL,
Score int NOT NULL,
CONSTRAINT PK_matchupentriesid PRIMARY KEY (id),
CONSTRAINT FK_parentmatchupid FOREIGN KEY (ParentMatchUpId) references Matchups(id),
CONSTRAINT FK_teamscompetingid FOREIGN KEY (TeamsCompetingId) references Teams(id)
)

COMMIT TRANSACTION





