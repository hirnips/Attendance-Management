USE [Test1]
GO
/****** Object:  Table [dbo].[Student_Fees]    Script Date: 02/09/2011 11:49:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Fees](
	[CId] [numeric](18, 0) NULL,
	[SId] [numeric](18, 0) NULL,
	[Roll_No] [numeric](18, 0) NULL,
	[Total] [numeric](18, 0) NULL,
	[PaidAmount] [numeric](18, 0) NULL,
	[DueAmount] [numeric](18, 0) NULL
) ON [PRIMARY]
