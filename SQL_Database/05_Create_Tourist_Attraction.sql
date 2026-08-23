USE [whatsinmycity]
GO

/****** Object:  Table [dbo].[Tourist_Attraction]    Script Date: 8/24/2026 12:29:27 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tourist_Attraction](
	[Attraction_ID] [int] IDENTITY(1,1) NOT NULL,
	[Attraction_Name] [varchar](50) NOT NULL,
	[Location] [nchar](35) NOT NULL,
	[Price] [money] NOT NULL,
	[Operating_Hours] [time](7) NOT NULL,
	[Safety_Rating] [int] NOT NULL,
 CONSTRAINT [PK_Tourist_Attraction] PRIMARY KEY CLUSTERED 
(
	[Attraction_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

