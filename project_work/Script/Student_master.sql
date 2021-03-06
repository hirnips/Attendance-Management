USE [Test1]
GO
/****** Object:  Table [dbo].[STUDENT_MASTER]    Script Date: 02/09/2011 11:49:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STUDENT_MASTER](
	[ROLL_NO] [numeric](18, 0) NOT NULL,
	[F_NAME] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[M_NAME] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[L_NAME] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[STU_EMAIL] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[PER_ADDRESS] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[PHONE_HOME] [numeric](18, 0) NULL,
	[MOBILE_NO] [numeric](18, 0) NULL,
	[SEX] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DOB] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[FA_NAME] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[FA_MNAME] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[FA_LNAME] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[OCCUPATION] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DESIGNATION] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[FA_MOBILE] [numeric](18, 0) NULL,
	[BOARD] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[MEDIUM] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[YEAR] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[PRACTICAL] [numeric](18, 0) NULL,
	[PERC] [numeric](5, 2) NULL,
	[TOTAL] [numeric](18, 0) NULL,
	[ATTAMPT] [numeric](18, 0) NULL,
	[COURSE] [numeric](18, 0) NOT NULL,
	[SUBJECT] [numeric](18, 0) NOT NULL,
	[AREA] [numeric](18, 0) NULL,
	[PHOTO] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_STUDENT_MASTER_1] PRIMARY KEY CLUSTERED 
(
	[ROLL_NO] ASC,
	[COURSE] ASC,
	[SUBJECT] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
