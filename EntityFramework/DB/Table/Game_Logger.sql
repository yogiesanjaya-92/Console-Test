USE [Console_Test]
GO
/****** Object:  Table [dbo].[Game_Logger]    Script Date: 2/11/2021 4:09:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Game_Logger](
	[ID] [uniqueidentifier] NOT NULL,
	[First_Name] [nvarchar](50) NOT NULL,
	[Last_Name] [nvarchar](50) NULL,
	[Game] [nvarchar](50) NOT NULL,
	[Hours] [int] NOT NULL,
 CONSTRAINT [PK_Game_Logger] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Game_Logger] ([ID], [First_Name], [Last_Name], [Game], [Hours]) VALUES (N'517aad51-3c6c-eb11-a917-000c2948c3b6', N'Anto', NULL, N'Onimusha', 3)
INSERT [dbo].[Game_Logger] ([ID], [First_Name], [Last_Name], [Game], [Hours]) VALUES (N'f9af7b5d-3c6c-eb11-a917-000c2948c3b6', N'Budi', N'Sucipto', N'Final Fantasy', 8)
INSERT [dbo].[Game_Logger] ([ID], [First_Name], [Last_Name], [Game], [Hours]) VALUES (N'2329376f-3c6c-eb11-a917-000c2948c3b6', N'Chaerul', N'Hikmah', N'PES', 1)
INSERT [dbo].[Game_Logger] ([ID], [First_Name], [Last_Name], [Game], [Hours]) VALUES (N'0dbe3983-3c6c-eb11-a917-000c2948c3b6', N'Dicky', NULL, N'God of War', 3)
INSERT [dbo].[Game_Logger] ([ID], [First_Name], [Last_Name], [Game], [Hours]) VALUES (N'bcaec383-486c-eb11-a917-000c2948c3b6', N'Erick', N'Xavier', N'X-Man', 12)
ALTER TABLE [dbo].[Game_Logger] ADD  CONSTRAINT [DF_Game_Logger_ID]  DEFAULT (newsequentialid()) FOR [ID]
GO
