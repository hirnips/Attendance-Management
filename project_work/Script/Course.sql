USE [Test1]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 02/09/2011 11:46:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[CID] [numeric](18, 0) NOT NULL,
	[CName] [nvarchar](50) COLLATE Latin1_General_CI_AI NULL,
	[CDescription] [nvarchar](50) COLLATE Latin1_General_CI_AI NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[CID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
