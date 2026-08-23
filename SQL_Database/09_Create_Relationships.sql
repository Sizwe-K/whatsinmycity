USE [whatsinmycity]
GO

ALTER TABLE [dbo].[Government_Document]  WITH CHECK ADD  CONSTRAINT [FK_Government_Document_UserAccount] FOREIGN KEY([User_ID])
REFERENCES [dbo].[UserAccount] ([User_ID])
GO

ALTER TABLE [dbo].[Government_Document] CHECK CONSTRAINT [FK_Government_Document_UserAccount]
GO

GO

ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_UserAccount] FOREIGN KEY([User_Id])
REFERENCES [dbo].[UserAccount] ([User_ID])
GO

ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_UserAccount]
GO

GO

ALTER TABLE [dbo].[Recommendation]  WITH CHECK ADD  CONSTRAINT [FK_Recommendation_Tourist_Attraction] FOREIGN KEY([Attraction_ID])
REFERENCES [dbo].[Tourist_Attraction] ([Attraction_ID])
GO

ALTER TABLE [dbo].[Recommendation] CHECK CONSTRAINT [FK_Recommendation_Tourist_Attraction]
GO

GO

ALTER TABLE [dbo].[Recommendation]  WITH CHECK ADD  CONSTRAINT [FK_Recommendation_UserAccount] FOREIGN KEY([User_ID])
REFERENCES [dbo].[UserAccount] ([User_ID])
GO

ALTER TABLE [dbo].[Recommendation] CHECK CONSTRAINT [FK_Recommendation_UserAccount]
GO

GO

ALTER TABLE [dbo].[Transport_Service]  WITH CHECK ADD  CONSTRAINT [FK_Transport_Service_Tourist_Attraction] FOREIGN KEY([Attraction_ID])
REFERENCES [dbo].[Tourist_Attraction] ([Attraction_ID])
GO

ALTER TABLE [dbo].[Transport_Service] CHECK CONSTRAINT [FK_Transport_Service_Tourist_Attraction]
GO

GO

ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Tourist_Attraction] FOREIGN KEY([Attraction_ID])
REFERENCES [dbo].[Tourist_Attraction] ([Attraction_ID])
GO

ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Tourist_Attraction]
GO

GO

ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Transport_Service] FOREIGN KEY([Transport_ID])
REFERENCES [dbo].[Transport_Service] ([Transport_ID])
GO

ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Transport_Service]
GO

GO

ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_UserAccount] FOREIGN KEY([User_ID])
REFERENCES [dbo].[UserAccount] ([User_ID])
GO

ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_UserAccount]
GO

GO

ALTER TABLE [dbo].[Travel_Pass]  WITH CHECK ADD  CONSTRAINT [FK_Travel_Pass_UserAccount] FOREIGN KEY([User_ID])
REFERENCES [dbo].[UserAccount] ([User_ID])
GO

ALTER TABLE [dbo].[Travel_Pass] CHECK CONSTRAINT [FK_Travel_Pass_UserAccount]
GO