--USE [UKZNISTN3ISTest] --Name of DB USED 

CREATE TABLE [dbo].[Customer](
	[Cust_ID] [int] IDENTITY(500,1) NOT NULL,
	[Cust_F_Name] [nvarchar](50) NULL,
	[Cust_L_Name] [nvarchar](50) NULL,
	[Cust_Phone_No] [nvarchar](50) NULL,
	[Cust_Email] [nvarchar](50) NULL,
	[Cust_Gender] [nchar](10) NULL,
	[Cust_Address] [nvarchar](50) NULL,
	[Cust_City] [nvarchar](50) NULL,
	[Cust_Street] [nvarchar](50) NULL,
	[Cust_Postal_Code] [smallint] NULL,
	[Cust_Password] [nvarchar](50) NULL,
	PRIMARY KEY CLUSTERED(Cust_ID));

SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([Cust_ID], [Cust_F_Name], [Cust_L_Name], [Cust_Phone_No], [Cust_Email], [Cust_Gender], [Cust_Address], [Cust_City], [Cust_Street], [Cust_Postal_Code], [Cust_Password]) VALUES (500, N'Bruce', N'Makhoba', N'0823654787', N'bruce@mail.com', N'Male      ', N'Building 142', N'NY', N'Blv street', 1235, NULL)
INSERT [dbo].[Customer] ([Cust_ID], [Cust_F_Name], [Cust_L_Name], [Cust_Phone_No], [Cust_Email], [Cust_Gender], [Cust_Address], [Cust_City], [Cust_Street], [Cust_Postal_Code], [Cust_Password]) VALUES (501, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Customer] ([Cust_ID], [Cust_F_Name], [Cust_L_Name], [Cust_Phone_No], [Cust_Email], [Cust_Gender], [Cust_Address], [Cust_City], [Cust_Street], [Cust_Postal_Code], [Cust_Password]) VALUES (502, N'Siphephelo', N'Anele', N'0711069658', N'217014127@stu.ukzn.ac.za', N'Male      ', N'Glenwood', N'Durban', N'277 Francois RD', 4001, NULL)
INSERT [dbo].[Customer] ([Cust_ID], [Cust_F_Name], [Cust_L_Name], [Cust_Phone_No], [Cust_Email], [Cust_Gender], [Cust_Address], [Cust_City], [Cust_Street], [Cust_Postal_Code], [Cust_Password]) VALUES (503, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Customer] ([Cust_ID], [Cust_F_Name], [Cust_L_Name], [Cust_Phone_No], [Cust_Email], [Cust_Gender], [Cust_Address], [Cust_City], [Cust_Street], [Cust_Postal_Code], [Cust_Password]) VALUES (504, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Customer] ([Cust_ID], [Cust_F_Name], [Cust_L_Name], [Cust_Phone_No], [Cust_Email], [Cust_Gender], [Cust_Address], [Cust_City], [Cust_Street], [Cust_Postal_Code], [Cust_Password]) VALUES (505, N'Loui', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Customer] ([Cust_ID], [Cust_F_Name], [Cust_L_Name], [Cust_Phone_No], [Cust_Email], [Cust_Gender], [Cust_Address], [Cust_City], [Cust_Street], [Cust_Postal_Code], [Cust_Password]) VALUES (507, N'Nqubeko', N'Myeni', N'0762332477', N'nqubeko@icloud.com', N'male      ', N'Bhambanana', N'Jozini', N'Ingwavuma', 3969, NULL)
INSERT [dbo].[Customer] ([Cust_ID], [Cust_F_Name], [Cust_L_Name], [Cust_Phone_No], [Cust_Email], [Cust_Gender], [Cust_Address], [Cust_City], [Cust_Street], [Cust_Postal_Code], [Cust_Password]) VALUES (508, N'Fakazi', N'Khumalo', N'0764949058', N'chen@gmail.com', N'female    ', N'Jozini', N'Jozini', N'Ingwavuma', 3968, NULL)
INSERT [dbo].[Customer] ([Cust_ID], [Cust_F_Name], [Cust_L_Name], [Cust_Phone_No], [Cust_Email], [Cust_Gender], [Cust_Address], [Cust_City], [Cust_Street], [Cust_Postal_Code], [Cust_Password]) VALUES (514, N'ksjkkjs', N'hjsamns ', N'0766666666', N'dsan@gmail.com', N'Male      ', N'cbsan', N'cbasn', N'cshabc', 6999, NULL)
INSERT [dbo].[Customer] ([Cust_ID], [Cust_F_Name], [Cust_L_Name], [Cust_Phone_No], [Cust_Email], [Cust_Gender], [Cust_Address], [Cust_City], [Cust_Street], [Cust_Postal_Code], [Cust_Password]) VALUES (515, N'Thabo', N'Myende', N'0735855888', N'Tn@gmail.com', N'other     ', N'Malangeni', N'Mzinto Town', N'Mzinto Rd', 7895, N'Tn@mhleni')
INSERT [dbo].[Customer] ([Cust_ID], [Cust_F_Name], [Cust_L_Name], [Cust_Phone_No], [Cust_Email], [Cust_Gender], [Cust_Address], [Cust_City], [Cust_Street], [Cust_Postal_Code], [Cust_Password]) VALUES (516, NULL, NULL, NULL, N'ceepyy@yahoo.com', NULL, NULL, NULL, NULL, NULL, N'Myeni@10')
INSERT [dbo].[Customer] ([Cust_ID], [Cust_F_Name], [Cust_L_Name], [Cust_Phone_No], [Cust_Email], [Cust_Gender], [Cust_Address], [Cust_City], [Cust_Street], [Cust_Postal_Code], [Cust_Password]) VALUES (517, NULL, NULL, NULL, N'siphehhh@yahoo.com', NULL, NULL, NULL, NULL, NULL, N'kaygee10M@')
INSERT [dbo].[Customer] ([Cust_ID], [Cust_F_Name], [Cust_L_Name], [Cust_Phone_No], [Cust_Email], [Cust_Gender], [Cust_Address], [Cust_City], [Cust_Street], [Cust_Postal_Code], [Cust_Password]) VALUES (518, N'Gladiator', N'Westville', N'0762332477', N'lulooo@icloud.com', N'Male      ', N'Ingwavuma', N'Jozini', N'277 Francois RD', 5899, N'WestG10@')

