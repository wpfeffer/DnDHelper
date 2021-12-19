CREATE TABLE [DMG].[DawnWarDeities]
(
	[DawnWarDeityID] INT NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Domain] NVARCHAR(100) NOT NULL, 
    [Alignment] NVARCHAR(2) NOT NULL, 
    [SuggestedDomains] NVARCHAR(50) NOT NULL, 
    [Symbol] NVARCHAR(100) NOT NULL
)
