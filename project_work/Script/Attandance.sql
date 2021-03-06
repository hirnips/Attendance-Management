USE [Test1]
GO
/****** Object:  Table [dbo].[Attandance]    Script Date: 02/09/2011 11:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attandance](
	[RollNO] [numeric](18, 0) NULL,
	[StudentName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CourseID] [numeric](18, 0) NULL,
	[SubjectID] [numeric](18, 0) NULL,
	[Intime] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[LoginDate] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Outtime] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
