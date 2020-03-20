CREATE TABLE [dbo].[Students] (
    [StudentId]   INT        IDENTITY (1, 1) NOT NULL,
    [StudentName] NCHAR (25) NULL,
    [Gruppa]      NCHAR (25) NULL,
    [Course]      NCHAR (25) NULL,
    [Speciality]  NCHAR (25) NULL,
    PRIMARY KEY CLUSTERED ([StudentId] ASC) 
);

