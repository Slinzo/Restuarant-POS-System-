--USE [UKZNISTN3ISTest]

CREATE TABLE [dbo].[Stock](
	[stock_ID] [int] IDENTITY(100,1) NOT NULL,
	[stock_Name] [varchar](50) NULL,
	[stock_Discription] [varchar](50) NULL,
	[stock_Purchase_Price] [decimal](18, 2) NULL,
	[stock_Selling_Price] [decimal](18, 2) NULL,
	[stock_Quantity] [int] NULL,
	[stock_Active] [int] NULL,
	PRIMARY KEY CLUSTERED(Stock_ID));

SET IDENTITY_INSERT [dbo].[Stock] ON 

INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (100, N'The Popolare', N'Pizza', CAST(90.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 100, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (101, N'Spago', N'Pizza', CAST(90.00 AS Decimal(18, 2)), CAST(139.00 AS Decimal(18, 2)), 100, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (102, N'Meat Lovers', N'Pizza', CAST(90.00 AS Decimal(18, 2)), CAST(145.00 AS Decimal(18, 2)), 100, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (103, N'Coke', N'Drink', CAST(12.00 AS Decimal(18, 2)), CAST(28.00 AS Decimal(18, 2)), 270, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (104, N'Grapetizer', N'Drink', CAST(13.00 AS Decimal(18, 2)), CAST(30.00 AS Decimal(18, 2)), 50, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (105, N'Fried', N'Pasta', CAST(23.00 AS Decimal(18, 2)), CAST(27.00 AS Decimal(18, 2)), 100, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (106, N'Orange Juice', N'Drink', CAST(10.00 AS Decimal(18, 2)), CAST(24.00 AS Decimal(18, 2)), 48, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (107, N'Calamari  Spicy', N'Pizza', CAST(30.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), 76, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (108, N'Granadila', N'Drink', CAST(15.00 AS Decimal(18, 2)), CAST(18.00 AS Decimal(18, 2)), 20, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (109, N'Lupa Blushing Cosmo', N'Cocktail', CAST(60.00 AS Decimal(18, 2)), CAST(65.00 AS Decimal(18, 2)), 90, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (110, N'Summer Fling', N'Mocktail', CAST(50.00 AS Decimal(18, 2)), CAST(55.00 AS Decimal(18, 2)), 82, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (111, N'Fair View La Carpa', N'Wine', CAST(38.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)), 90, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (112, N'Tomato & Basil Soup', N'Antipasti', CAST(55.00 AS Decimal(18, 2)), CAST(60.00 AS Decimal(18, 2)), 85, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (113, N'The Green Burger', N'Secondi', CAST(140.00 AS Decimal(18, 2)), CAST(145.00 AS Decimal(18, 2)), 91, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (114, N'Gelato Per Scoop', N'Dolce', CAST(25.00 AS Decimal(18, 2)), CAST(30.00 AS Decimal(18, 2)), 87, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (115, N'Tomato & Basil', N'Pasta', CAST(70.00 AS Decimal(18, 2)), CAST(80.00 AS Decimal(18, 2)), 100, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (116, N'Chicken Dust', N'Dolce', CAST(100.00 AS Decimal(18, 2)), CAST(150.00 AS Decimal(18, 2)), 200, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (117, N'Cranberry Juice', N'Drink', CAST(20.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), 80, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (118, N'Red Wine', N'Wine', CAST(56.00 AS Decimal(18, 2)), CAST(65.00 AS Decimal(18, 2)), 6, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (119, N'Veggie Pizza', N'Pizza', CAST(100.00 AS Decimal(18, 2)), CAST(120.00 AS Decimal(18, 2)), 100, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (120, N'Carrot Juice', N'Drink', CAST(20.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), 0, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (121, N'Fanta', N'Drink', CAST(15.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), 0, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (122, N'Gwinya', N'Food', CAST(7.00 AS Decimal(18, 2)), CAST(25.30 AS Decimal(18, 2)), 5, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (123, N'Coke Gladiators', N'Drink', CAST(54.00 AS Decimal(18, 2)), CAST(656.00 AS Decimal(18, 2)), 10, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (124, N'Fried', N'Pasta', CAST(23.00 AS Decimal(18, 2)), CAST(27.00 AS Decimal(18, 2)), 8, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (125, N'Fried', N'Pasta', CAST(23.00 AS Decimal(18, 2)), CAST(27.00 AS Decimal(18, 2)), 8, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (126, N'Fried', N'Pasta', CAST(23.00 AS Decimal(18, 2)), CAST(27.00 AS Decimal(18, 2)), 8, 1)
INSERT [dbo].[Stock] ([stock_ID], [stock_Name], [stock_Discription], [stock_Purchase_Price], [stock_Selling_Price], [stock_Quantity], [stock_Active]) VALUES (127, N'Pie', N'Pasta', CAST(23.00 AS Decimal(18, 2)), CAST(30.00 AS Decimal(18, 2)), 15, 1)

