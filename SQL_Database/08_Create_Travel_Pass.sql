USE [whatsinmycity]
GO

/****** Object:  Table [dbo].[Travel_Pass]    Script Date: 8/24/2026 12:37:50 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Travel_Pass](
	[Travel_Pass_Id] [int] IDENTITY(1,1) NOT NULL,
	[User_ID] [int] NOT NULL,
	[Pass_Type] [varchar](35) NOT NULL,
	[QR_Code] [varchar](15) NOT NULL,
	[Expiry_Date] [date] NOT NULL,
 CONSTRAINT [PK_Travel_Pass] PRIMARY KEY CLUSTERED 
(
	[Travel_Pass_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

