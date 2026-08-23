USE [whatsinmycity]
GO

/****** Object:  Table [dbo].[Booking]    Script Date: 8/24/2026 12:35:37 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Booking](
	[Booking_ID] [int] IDENTITY(1,1) NOT NULL,
	[User_ID] [int] NOT NULL,
	[Attraction_ID] [int] NOT NULL,
	[Transport_ID] [int] NOT NULL,
	[Booking_Date] [date] NOT NULL,
	[Booking_Status] [varchar](15) NOT NULL,
	[Number_Of_People] [int] NOT NULL,
 CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED 
(
	[Booking_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

