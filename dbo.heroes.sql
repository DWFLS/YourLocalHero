32CREATE TABLE [dbo].[heroes] (
    [Id]             INT           IDENTITY (0,1) NOT NULL,
    [Name]           NVARCHAR (50) NOT NULL,
    [Class]          NVARCHAR (15) NOT NULL,
    [Alignment]      NVARCHAR (15) NOT NULL,
    [Hiring Fee]     INT           NOT NULL,
    [About]          NTEXT         NOT NULL,
    [Strength]       DECIMAL (18)  NOT NULL,
    [Dexterity]      INT           NOT NULL,
    [Condition]      INT           NOT NULL,
    [Intelligence]   INT           NOT NULL,
    [Wisdom]         INT           NOT NULL,
    [Charisma]       INT           NOT NULL,
    [Total Score]    INT           NOT NULL,
    [Special Traits] NTEXT         NULL,
    [ClassSub1]      NVARCHAR (15) NULL,
    [ClassSub2]      NVARCHAR (15) NULL,
    [ClassSub3]      NVARCHAR (15) NULL,
    [AlignmentSub1]  NVARCHAR (15) NULL,
    [AlignmentSub2]  NVARCHAR (15) NULL,
    [Portrait] IMAGE NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

