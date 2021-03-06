USE [Test1]
GO
/****** Object:  Table [dbo].[marksInput]    Script Date: 02/09/2011 11:48:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[marksInput](
	[CourseId] [numeric](18, 0) NOT NULL,
	[SubjectId] [numeric](18, 0) NOT NULL,
	[RollNo] [numeric](18, 0) NOT NULL,
	[Marks] [numeric](18, 0) NULL,
	[InputDate] [nvarchar](50) COLLATE Latin1_General_CI_AI NOT NULL,
	[InputMonth] [numeric](18, 0) NULL,
 CONSTRAINT [PK_marksInput] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC,
	[SubjectId] ASC,
	[RollNo] ASC,
	[InputDate] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
