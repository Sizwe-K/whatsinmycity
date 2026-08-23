USE [whatsinmycity]
GO

/****** Object:  Table [dbo].[Government_Document]    Script Date: 8/24/2026 12:12:19 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Government_Document](
	[Government_ID] [int] IDENTITY(1,1) NOT NULL,
	[User_ID] [int] NOT NULL,
	[Passport_Copy] [nchar](25) NOT NULL,
	[ID_Copy] [varchar](255) NOT NULL,
	[Visa_Details] [varchar](100) NOT NULL,
	[OCR_Verification_Status] [varchar](20) NOT NULL,
	[Expiry_Date] [date] NOT NULL,
	[Passport_Number] [varbinary](20) NOT NULL,
	[ID_Number] [varchar](13) NULL,
 CONSTRAINT [PK_Government_Document] PRIMARY KEY CLUSTERED 
(
	[Government_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

