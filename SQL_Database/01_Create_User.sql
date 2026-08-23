USE [whatsinmycity]
GO

/****** Object:  Table [dbo].[UserAccount]    Script Date: 8/24/2026 12:01:22 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserAccount](
	[User_ID] [int] IDENTITY(1,1) NOT NULL,
	[Full_Name] [varchar](35) NOT NULL,
	[Email_Address] [varchar](35) NOT NULL,
	[Phone_Number] [char](10) NOT NULL,
	[Password] [varchar](12) NOT NULL,
 CONSTRAINT [PK_UserAccount] PRIMARY KEY CLUSTERED 
(
	[User_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

