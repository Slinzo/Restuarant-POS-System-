--USE [UKZNISTN3ISTest]

CREATE TABLE [dbo].[Staff](
	[Staff_ID] [int] IDENTITY(1000,1) NOT NULL,
	[Staff_F_Name] [nvarchar](50) NULL,
	[Staff_L_Name] [nvarchar](50) NULL,
	[Staff_Phone_No] [nvarchar](50) NULL,
	[Staff_Title] [int] NULL,
	[Staff_Email] [nvarchar](50) NULL,
	[Staff_Gender] [nchar](10) NULL,
	[Staff_Username] [nvarchar](50) NULL,
	[Staff_Password] [nvarchar](50) NULL,
	[Staff_Active] [int] NULL,
	PRIMARY KEY CLUSTERED(Staff_ID));

SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([Staff_ID], [Staff_F_Name], [Staff_L_Name], [Staff_Phone_No], [Staff_Title], [Staff_Email], [Staff_Gender], [Staff_Username], [Staff_Password], [Staff_Active]) VALUES (1000, N'Siphephelo', N'Myeni', N'0774293744', 0, N'Smyeni@gmail.com', N'Male      ', N'Siphephelo', N'123', 1)
INSERT [dbo].[Staff] ([Staff_ID], [Staff_F_Name], [Staff_L_Name], [Staff_Phone_No], [Staff_Title], [Staff_Email], [Staff_Gender], [Staff_Username], [Staff_Password], [Staff_Active]) VALUES (1001, N'Thando', N'Mlungwana', N'0714829789', 1, N'Tmlungwana@gmail.com', N'Female    ', N'Thando', N'456', 0)
INSERT [dbo].[Staff] ([Staff_ID], [Staff_F_Name], [Staff_L_Name], [Staff_Phone_No], [Staff_Title], [Staff_Email], [Staff_Gender], [Staff_Username], [Staff_Password], [Staff_Active]) VALUES (1002, N'Lindani', N'Mashwama', N'0826478952', 1, N'lmashwama@gmail.com', N'Male      ', N'Lindani', N'789', 1)
INSERT [dbo].[Staff] ([Staff_ID], [Staff_F_Name], [Staff_L_Name], [Staff_Phone_No], [Staff_Title], [Staff_Email], [Staff_Gender], [Staff_Username], [Staff_Password], [Staff_Active]) VALUES (1003, N'Mondli', N'Masondo', N'0625148145', 0, N'Mmasondo@gmail.com', N'Male      ', N'Mondli', N'000', 1)
INSERT [dbo].[Staff] ([Staff_ID], [Staff_F_Name], [Staff_L_Name], [Staff_Phone_No], [Staff_Title], [Staff_Email], [Staff_Gender], [Staff_Username], [Staff_Password], [Staff_Active]) VALUES (1004, N'Anele', N'Mnguni', N'0711069658', 1, N'sipheanele@gmail.com', N'Male      ', N'AneMng103', N'vgjh', 0)
INSERT [dbo].[Staff] ([Staff_ID], [Staff_F_Name], [Staff_L_Name], [Staff_Phone_No], [Staff_Title], [Staff_Email], [Staff_Gender], [Staff_Username], [Staff_Password], [Staff_Active]) VALUES (1005, N'Bruce', N'Makhoba', N'0875698525', 1, N'mac107@gmail.com', N'Male      ', N'BruMak178', N'myPw100', 0)
INSERT [dbo].[Staff] ([Staff_ID], [Staff_F_Name], [Staff_L_Name], [Staff_Phone_No], [Staff_Title], [Staff_Email], [Staff_Gender], [Staff_Username], [Staff_Password], [Staff_Active]) VALUES (1006, NULL, NULL, NULL, NULL, N'sipheh@yahoo.com', NULL, NULL, N'aneleMY@10', NULL)

