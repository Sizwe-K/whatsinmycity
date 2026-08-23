USE [whatsinmycity]
GO

/****** Object:  Table [dbo].[Transport_Service]    Script Date: 8/24/2026 12:32:35 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Transport_Service](
	[Transport_ID] [int] IDENTITY(1,1) NOT NULL,
	[Attraction_ID] [int] NOT NULL,
	[Transport_Type] [varchar](30) NOT NULL,
	[Route] [varchar](100) NOT NULL,
	[Ticket_Price] [money] NOT NULL,
	[Availability] [varchar](20) NOT NULL,
	[Schedule] [datetime] NOT NULL,
 CONSTRAINT [PK_Transport_Service] PRIMARY KEY CLUSTERED 
(
	[Transport_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

