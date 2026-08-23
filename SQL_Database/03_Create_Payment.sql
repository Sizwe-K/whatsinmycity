USE [whatsinmycity]
GO

/****** Object:  Table [dbo].[Payment]    Script Date: 8/24/2026 12:22:05 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Payment](
	[Payment_ID] [int] IDENTITY(1,1) NOT NULL,
	[User_Id] [int] NOT NULL,
	[Card_Number] [varchar](19) NOT NULL,
	[Card_Type] [varchar](15) NOT NULL,
	[Billing_Address] [varchar](50) NOT NULL,
	[Payment_Status] [varchar](15) NOT NULL,
	[Payment_Amount] [money] NOT NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[Payment_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

