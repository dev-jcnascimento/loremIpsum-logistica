USE [LoremIpsumLogisticaApi]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 01/03/2022 10:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 01/03/2022 10:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[Id] [uniqueidentifier] NOT NULL,
	[TypeAddress] [nvarchar](max) NOT NULL,
	[ZipCode] [int] NOT NULL,
	[Place] [varchar](150) NOT NULL,
	[Number] [int] NOT NULL,
	[Complement] [varchar](150) NULL,
	[District] [varchar](80) NULL,
	[State] [varchar](2) NULL,
	[ClientId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 01/03/2022 10:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[Id] [uniqueidentifier] NOT NULL,
	[FirstName] [varchar](60) NOT NULL,
	[LastName] [varchar](60) NOT NULL,
	[BirthDate] [datetime2](7) NOT NULL,
	[Genre] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220225194526_InitialCreate', N'6.0.2')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220225213246_Refactoring_Client', N'6.0.2')
GO
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'cd9d83c4-7201-463e-ba6f-014e2179fe17', N'Residential', 23441568, N'Riverside', 98, N'D', N'California', N'RO', N'ca30b775-d893-40c3-90f5-f891b484774f')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'e1f9e5aa-7fc6-42d7-a1dd-0f2237124fa0', N'Residential', 58540696, N'Forest', 935, N'Perto da Escola', N'Florida', N'AM', N'441dcee2-15a8-49f0-afa3-cd06dbe180a0')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'35cb589a-cfa4-4d07-a28b-10f34ae79465', N'Commercial', 60713107, N'Arapahoe', 77, N'C', N'Florida', N'MS', N'35819e0b-84e0-457e-810d-63c487051eee')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'01d66490-c507-4efb-95d9-183b4707cbbd', N'Commercial', 84225071, N'Forest Run', 571, N'Frente', N'Ilha de SÃ£o Miguel', N'PI', N'a3aeb369-f55a-4cb1-bb3f-c4691c1cdbca')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'a033b376-30f6-417e-9ce5-1aadce57e6f0', N'Commercial', 11814607, N'Swallow', 7629, N'Perto da Escola', N'Florida', N'MG', N'2f47d5a8-ce19-4182-adb1-58a3fb60be84')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'b3ea7e9a-d666-423a-9756-1dc82964890c', N'Residential', 59183200, N'Gateway', 84, N'G', N'California', N'RO', N'8c9c34ca-5595-45d0-853e-5f35301d8acf')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'2ef093dd-0f93-46c6-a19a-233d459427d8', N'Residential', 82285855, N'Paget', 7617, N'', N'Florida', N'RR', N'35819e0b-84e0-457e-810d-63c487051eee')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'e0fcc29e-255a-4558-83fe-425cef471fe6', N'Commercial', 94647017, N'Ronald Regan', 85, N'G', N'California', N'PI', N'501acc99-252e-481d-8a8b-dfcdd8104635')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'79cca9f9-2379-4115-8391-43b1df458f79', N'Residential', 73177423, N'Gerald', 85079, N'G', N'Florida', N'MG', N'4acb6686-0a09-45ae-bed7-b6b7ccac0028')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'718776c8-edaa-4e8c-b9b0-630a6fb76e60', N'Residential', 82436507, N'Loomis', 36388, N'Perto do Mercado', N'Arkansas', N'SP', N'501acc99-252e-481d-8a8b-dfcdd8104635')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'abd14aee-0fe4-4522-a38e-7218b9aaec2c', N'Residential', 47309984, N'Little Fleur', 5362, N'b', N'Castilla - Leon', N'AM', N'4acb6686-0a09-45ae-bed7-b6b7ccac0028')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'bef35c51-96c9-436f-8f47-7bfe044d08f2', N'Commercial', 31390795, N'Cambridge', 3383, N'Perto da Escola', N'Arkansas', N'SP', N'55326aa4-1146-4652-87af-48e98c9341a4')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'625f597c-e242-4aff-91f6-7e991802fce8', N'Residential', 48030749, N'Goodland', 957, N'Perto do Mercado', N'California', N'PE', N'2f47d5a8-ce19-4182-adb1-58a3fb60be84')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'fa8ee736-fb1a-44ca-ad24-7f93149791c9', N'Residential', 5807597, N'Morrow', 42663, N'C', N'California', N'MG', N'501acc99-252e-481d-8a8b-dfcdd8104635')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'bcce6709-3ef4-43c9-a506-80e7f2560c9d', N'Commercial', 78711252, N'Lien', 8429, N'G', N'Ilha de SÃ£o Miguel', N'AL', N'ca30b775-d893-40c3-90f5-f891b484774f')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'ffc97bd9-996c-4f4c-94dd-8261b1f9ec21', N'Residential', 98837035, N'Oriole', 740, N'Frente', N'Alabama', N'PE', N'a3aeb369-f55a-4cb1-bb3f-c4691c1cdbca')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'8e2bcff8-47ac-4d60-a956-862b328122b2', N'Residential', 5066259, N'Algoma', 465, N'G', N'California', N'PI', N'441dcee2-15a8-49f0-afa3-cd06dbe180a0')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'ab83a35a-6492-457a-88d0-868f3f053065', N'Commercial', 49222793, N'Hollow Ridge', 0, N'D', N'California', N'MG', N'35819e0b-84e0-457e-810d-63c487051eee')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'da1a3c4c-42e1-48fc-9003-877fe1744fbe', N'Commercial', 23859422, N'Golf View', 1, N'G', N'California', N'PE', N'0fc7f06b-2e20-4b95-b981-809a7494d20b')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'e1efde04-c291-46f3-bdb4-89f1a7f8c0a5', N'Residential', 18339175, N'Rutledge', 590, N'Perto do Mercado', N'California', N'AL', N'8abd53f1-94b5-4be1-b78d-783a2400514a')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'afc8d801-9e9d-4bef-9c18-8b8ed8d3a60f', N'Residential', 55554888, N'Butterfield', 7, N'', N'Colorado', N'AM', N'2f47d5a8-ce19-4182-adb1-58a3fb60be84')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'e78112c3-939d-40d1-87c4-90a6ac4ff130', N'Commercial', 40651828, N'Veith', 82, N'', N'Florida', N'RJ', N'8abd53f1-94b5-4be1-b78d-783a2400514a')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'88cb4227-fff0-41c8-993e-975adb57778a', N'Residential', 51592467, N'Little Fleur', 2, N'Perto da Escola', N'Colorado', N'PE', N'35819e0b-84e0-457e-810d-63c487051eee')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'25667519-0799-4274-85e8-9a2daa02c52e', N'Commercial', 19975036, N'Karstens', 9498, N'Fundos', N'Arkansas', N'MG', N'441dcee2-15a8-49f0-afa3-cd06dbe180a0')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'f43095ad-7f13-46db-bb0b-9eb7306a4e6b', N'Commercial', 53975593, N'Oakridge', 4, N'Fundos', N'Florida', N'MG', N'a3aeb369-f55a-4cb1-bb3f-c4691c1cdbca')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'4abcc5df-b087-4b8f-a56f-a2cb519b04ae', N'Commercial', 13667335, N'Thierer', 1103, N'A', N'California', N'MG', N'a3aeb369-f55a-4cb1-bb3f-c4691c1cdbca')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'e9265dca-7461-4029-a99c-aa94788fce1d', N'Commercial', 60274743, N'Spohn', 634, N'b', N'Ilha de SÃ£o Miguel', N'MS', N'8c9c34ca-5595-45d0-853e-5f35301d8acf')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'3d5666ca-5694-4c52-a8c0-b1deb34e4f41', N'Commercial', 76914601, N'Hollow Ridge', 189, N'Fundos', N'Washington', N'AM', N'2f47d5a8-ce19-4182-adb1-58a3fb60be84')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'9d4bbfae-392a-41d8-bd27-c4cf7559371a', N'Commercial', 65144799, N'Dexter', 89, N'D', N'Alabama', N'SP', N'2f47d5a8-ce19-4182-adb1-58a3fb60be84')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'd3eeca13-d082-4027-86d2-c52792537392', N'Residential', 92690664, N'Starling', 4, N'b', N'Florida', N'AM', N'0fc7f06b-2e20-4b95-b981-809a7494d20b')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'87f8ef90-2cbc-411e-887f-cee5eb447310', N'Residential', 72893018, N'Meadow Vale', 619, N'D', N'Ilha de SÃ£o Miguel', N'AM', N'4acb6686-0a09-45ae-bed7-b6b7ccac0028')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'2bc79de3-96cb-4e2a-8913-d04560d2a721', N'Commercial', 93636243, N'Sutteridge', 8, N'D', N'California', N'GO', N'ca30b775-d893-40c3-90f5-f891b484774f')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'5b83eff9-72e9-4673-8164-e60993e86da7', N'Commercial', 32902150, N'Miller', 802, N'Perto da Escola', N'California', N'RO', N'0fc7f06b-2e20-4b95-b981-809a7494d20b')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'774a0740-9816-4b7d-a461-e6d937f3acdc', N'Residential', 49905394, N'Valley Edge', 3418, N'G', N'Florida', N'AM', N'35819e0b-84e0-457e-810d-63c487051eee')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'5aa1d56b-5d86-45ce-ae28-e736d9105b2a', N'Commercial', 78229228, N'Quincy', 69160, N'Perto da Escola', N'California', N'AM', N'0fc7f06b-2e20-4b95-b981-809a7494d20b')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'f95f7c07-ff9d-421d-a5b3-ef03e2da82ef', N'Residential', 3786473, N'Oak', 51407, N'G', N'Alabama', N'PI', N'4acb6686-0a09-45ae-bed7-b6b7ccac0028')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'4b50becf-391a-436b-90ef-f71e5fec6599', N'Residential', 49227595, N'Glendale', 2, N'b', N'California', N'PI', N'55326aa4-1146-4652-87af-48e98c9341a4')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'eb0324d9-ff9b-423c-aec9-fb4b15335e0b', N'Commercial', 36908065, N'Susan', 4870, N'b', N'California', N'RO', N'501acc99-252e-481d-8a8b-dfcdd8104635')
INSERT [dbo].[Address] ([Id], [TypeAddress], [ZipCode], [Place], [Number], [Complement], [District], [State], [ClientId]) VALUES (N'229e10ee-109b-461c-8370-fd776e0a91d9', N'Commercial', 93170405, N'Oak Valley', 82, N'Fundos', N'Florida', N'AM', N'35819e0b-84e0-457e-810d-63c487051eee')
GO
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [BirthDate], [Genre]) VALUES (N'55326aa4-1146-4652-87af-48e98c9341a4', N'Grove', N'Marsham', CAST(N'1980-08-30T00:00:00.0000000' AS DateTime2), N'Female')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [BirthDate], [Genre]) VALUES (N'2f47d5a8-ce19-4182-adb1-58a3fb60be84', N'Merrielle', N'Hullock', CAST(N'1975-07-19T00:00:00.0000000' AS DateTime2), N'Male')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [BirthDate], [Genre]) VALUES (N'8c9c34ca-5595-45d0-853e-5f35301d8acf', N'Lem', N'Fearick', CAST(N'1984-02-20T00:00:00.0000000' AS DateTime2), N'Female')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [BirthDate], [Genre]) VALUES (N'35819e0b-84e0-457e-810d-63c487051eee', N'Roana', N'Redborn', CAST(N'1986-01-29T00:00:00.0000000' AS DateTime2), N'Female')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [BirthDate], [Genre]) VALUES (N'1962cf2d-d90c-4a52-b7cf-6775aefac441', N'Zelma', N'Archibould', CAST(N'1983-05-29T00:00:00.0000000' AS DateTime2), N'Male')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [BirthDate], [Genre]) VALUES (N'98c83294-379b-44e1-a0be-7184ccb4aced', N'Chancey', N'Bryning', CAST(N'1977-11-11T00:00:00.0000000' AS DateTime2), N'Female')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [BirthDate], [Genre]) VALUES (N'8abd53f1-94b5-4be1-b78d-783a2400514a', N'Thadeus', N'Abrahmson', CAST(N'1989-09-06T00:00:00.0000000' AS DateTime2), N'Male')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [BirthDate], [Genre]) VALUES (N'0fc7f06b-2e20-4b95-b981-809a7494d20b', N'Pepita', N'Svanetti', CAST(N'1981-10-08T00:00:00.0000000' AS DateTime2), N'Female')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [BirthDate], [Genre]) VALUES (N'f24fc0b5-e55f-46a6-aa8c-8b696e80ee2a', N'Oswald', N'Foort', CAST(N'1990-09-27T00:00:00.0000000' AS DateTime2), N'Female')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [BirthDate], [Genre]) VALUES (N'0a42f676-f654-4ac4-8afb-8e7d1dfc7bf3', N'Erin', N'Swapp', CAST(N'1972-09-06T00:00:00.0000000' AS DateTime2), N'Female')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [BirthDate], [Genre]) VALUES (N'7fa3623e-1ea3-4a57-b5b4-9572cdf1acf6', N'Marilee', N'Argente', CAST(N'1996-09-20T00:00:00.0000000' AS DateTime2), N'Female')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [BirthDate], [Genre]) VALUES (N'75724a5b-d1c9-44ba-abfa-a1ecb4d36828', N'Essy', N'O''Brian', CAST(N'1983-11-09T00:00:00.0000000' AS DateTime2), N'Female')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [BirthDate], [Genre]) VALUES (N'752d7bb1-deb6-4008-a773-a61678217885', N'Pansie', N'Shouler', CAST(N'1998-06-11T00:00:00.0000000' AS DateTime2), N'Male')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [BirthDate], [Genre]) VALUES (N'ba139576-440a-497a-8347-a9f900720f14', N'Oneida', N'Bayliss', CAST(N'1985-04-28T00:00:00.0000000' AS DateTime2), N'Male')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [BirthDate], [Genre]) VALUES (N'2ae2efd8-982a-4b50-bdd0-b5fac206626b', N'Merci', N'Hanretty', CAST(N'1975-12-23T00:00:00.0000000' AS DateTime2), N'Male')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [BirthDate], [Genre]) VALUES (N'4acb6686-0a09-45ae-bed7-b6b7ccac0028', N'Lorain', N'Cohr', CAST(N'1998-01-09T00:00:00.0000000' AS DateTime2), N'Male')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [BirthDate], [Genre]) VALUES (N'a3aeb369-f55a-4cb1-bb3f-c4691c1cdbca', N'Malcolm', N'Troppmann', CAST(N'1992-03-09T00:00:00.0000000' AS DateTime2), N'Male')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [BirthDate], [Genre]) VALUES (N'441dcee2-15a8-49f0-afa3-cd06dbe180a0', N'Quentin', N'Shorrock', CAST(N'1999-02-18T00:00:00.0000000' AS DateTime2), N'Female')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [BirthDate], [Genre]) VALUES (N'501acc99-252e-481d-8a8b-dfcdd8104635', N'Marcellus', N'Lanktree', CAST(N'1990-01-05T00:00:00.0000000' AS DateTime2), N'Male')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [BirthDate], [Genre]) VALUES (N'ca30b775-d893-40c3-90f5-f891b484774f', N'Dyana', N'Pyer', CAST(N'1996-02-18T00:00:00.0000000' AS DateTime2), N'Male')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [BirthDate], [Genre]) VALUES (N'd3922cb7-5127-4fcb-b3fb-f93ec9bb3ea5', N'Caryl', N'Hellen', CAST(N'1975-10-17T00:00:00.0000000' AS DateTime2), N'Female')
GO
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_Client_ClientId] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Client] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_Client_ClientId]
GO
