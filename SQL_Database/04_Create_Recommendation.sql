USE [whatsinmycity]
GO

/****** Object:  Table [dbo].[Recommendation]    Script Date: 8/24/2026 12:25:07 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Recommendation](
	[Recommendation_ID] [int] IDENTITY(1,1) NOT NULL,
	[User_ID] [int] NOT NULL,
	[Attraction_ID] [int] NOT NULL,
	[Price_Range] [money] NOT NULL,
	[Safety_Level] [varchar](20) NOT NULL,
	[User_Rating] [int] NOT NULL,
 CONSTRAINT [PK_Recommendation] PRIMARY KEY CLUSTERED 
(
	[Recommendation_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

