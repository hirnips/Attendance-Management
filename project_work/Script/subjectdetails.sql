USE [Test1]
GO
/****** Object:  Table [dbo].[subjectdetails]    Script Date: 02/09/2011 11:50:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subjectdetails](
	[CId] [numeric](18, 0) NOT NULL,
	[SubjectId] [numeric](18, 0) NOT NULL,
	[SubjectName] [nvarchar](50) COLLATE Latin1_General_CI_AI NULL,
	[Description] [nvarchar](50) COLLATE Latin1_General_CI_AI NULL,
 CONSTRAINT [PK_subjectdetails_1] PRIMARY KEY CLUSTERED 
(
	[CId] ASC,
	[SubjectId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
