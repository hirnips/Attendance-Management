USE [Test1]
GO
/****** Object:  Table [dbo].[UserDetails]    Script Date: 02/09/2011 11:50:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserDetails](
	[Id] [numeric](18, 0) NOT NULL,
	[UserId] [nvarchar](50) COLLATE Latin1_General_CI_AI NULL,
	[Password] [nvarchar](50) COLLATE Latin1_General_CI_AI NULL,
	[UserType] [nvarchar](50) COLLATE Latin1_General_CI_AI NULL,
 CONSTRAINT [PK_UserDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
