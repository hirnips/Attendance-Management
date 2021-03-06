USE [Test1]
GO
/****** Object:  Table [dbo].[Fees_master]    Script Date: 02/09/2011 11:47:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fees_master](
	[CId] [numeric](18, 0) NOT NULL,
	[SId] [numeric](18, 0) NOT NULL,
	[Amount] [numeric](18, 0) NULL,
 CONSTRAINT [PK_Fees_master] PRIMARY KEY CLUSTERED 
(
	[CId] ASC,
	[SId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
