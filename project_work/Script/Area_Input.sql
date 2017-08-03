USE [Test1]
GO
/****** Object:  Table [dbo].[Area_Input]    Script Date: 02/09/2011 11:45:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Area_Input](
	[areaid] [numeric](18, 0) NULL,
	[areaName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[areadescription] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
