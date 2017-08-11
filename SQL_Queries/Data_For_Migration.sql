USE [SonOfCod]
GO
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'c3477b72-ab60-483c-81ff-e34c9b24ffe1', 0, N'3c0c230c-08d6-4472-960b-cd4bcd42dae1', NULL, 0, 1, NULL, NULL, N'CHET', N'AQAAAAEAACcQAAAAEB04Pgs4ljUiu6T5UO4nwDpUJZqaYlTnqtQdK2xEtYb9tMlu9pR5VlwOqVTiIyye9g==', NULL, 0, N'7901619c-c9bc-44e3-95ab-5cbd9cad871a', 0, N'Chet')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170811153825_Initial', N'1.0.0-rtm-21431')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170811162523_AddTwoTables', N'1.0.0-rtm-21431')
SET IDENTITY_INSERT [dbo].[Inventory] ON 

INSERT [dbo].[Inventory] ([Id], [Cost], [Description], [Name]) VALUES (1, CAST(21.99 AS Decimal(18, 2)), N'Vegan Tuna', N'Tewna')
INSERT [dbo].[Inventory] ([Id], [Cost], [Description], [Name]) VALUES (2, CAST(12.99 AS Decimal(18, 2)), N'The squire to Blennies Of Tarth', N'Codrick')
INSERT [dbo].[Inventory] ([Id], [Cost], [Description], [Name]) VALUES (3, CAST(33.99 AS Decimal(18, 2)), N'Lady of the Sapphire Isles', N'Blennie')
INSERT [dbo].[Inventory] ([Id], [Cost], [Description], [Name]) VALUES (5, CAST(18.99 AS Decimal(18, 2)), N'Squalus Clegainus, known grump and personal guard of The LionFish ', N'The Dogfish')
INSERT [dbo].[Inventory] ([Id], [Cost], [Description], [Name]) VALUES (6, CAST(0.00 AS Decimal(18, 2)), N'Cant give this dude away', N'Joffrey the LionFish')
INSERT [dbo].[Inventory] ([Id], [Cost], [Description], [Name]) VALUES (7, CAST(5.99 AS Decimal(18, 2)), N'The Redbelted Anthias, Pseudanthis Rybrizonatus, also known as Red-belted Anthias, Red-girdled Anthias, Redband Anthias, and Tricolor Anthias', N'Redbelt Anthias')
INSERT [dbo].[Inventory] ([Id], [Cost], [Description], [Name]) VALUES (8, CAST(40.99 AS Decimal(18, 2)), N'Bivalves, Sold by the bushel', N'Clams')
INSERT [dbo].[Inventory] ([Id], [Cost], [Description], [Name]) VALUES (9, CAST(7.99 AS Decimal(18, 2)), N'Shrimps! Sold by the lb shells on', N'Shrimps')
INSERT [dbo].[Inventory] ([Id], [Cost], [Description], [Name]) VALUES (10, CAST(7.99 AS Decimal(18, 2)), N'A RED HERRING', N'Herring')
SET IDENTITY_INSERT [dbo].[Inventory] OFF
SET IDENTITY_INSERT [dbo].[MailingList] ON 

INSERT [dbo].[MailingList] ([Id], [Email], [FirstName], [Interests], [LastName]) VALUES (1, N'aslkrj', N'alrj', N'slaetj', N'sldrj')
INSERT [dbo].[MailingList] ([Id], [Email], [FirstName], [Interests], [LastName]) VALUES (2, N'slektja', N'lsketj', N'lsetj', N'a;slek')
SET IDENTITY_INSERT [dbo].[MailingList] OFF
