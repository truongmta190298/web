USE [master]
GO
/****** Object:  Database [TechnologyWeb]    Script Date: 10/24/2019 8:07:59 PM ******/
CREATE DATABASE [TechnologyWeb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TechnologyWeb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\TechnologyWeb.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TechnologyWeb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\TechnologyWeb_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TechnologyWeb] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TechnologyWeb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TechnologyWeb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TechnologyWeb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TechnologyWeb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TechnologyWeb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TechnologyWeb] SET ARITHABORT OFF 
GO
ALTER DATABASE [TechnologyWeb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TechnologyWeb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TechnologyWeb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TechnologyWeb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TechnologyWeb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TechnologyWeb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TechnologyWeb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TechnologyWeb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TechnologyWeb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TechnologyWeb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TechnologyWeb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TechnologyWeb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TechnologyWeb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TechnologyWeb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TechnologyWeb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TechnologyWeb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TechnologyWeb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TechnologyWeb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TechnologyWeb] SET  MULTI_USER 
GO
ALTER DATABASE [TechnologyWeb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TechnologyWeb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TechnologyWeb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TechnologyWeb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [TechnologyWeb] SET DELAYED_DURABILITY = DISABLED 
GO
USE [TechnologyWeb]
GO
/****** Object:  Table [dbo].[Accout]    Script Date: 10/24/2019 8:07:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Accout](
	[UserName] [nvarchar](100) NOT NULL,
	[Pass] [char](20) NULL,
 CONSTRAINT [PK_Accout] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Audio]    Script Date: 10/24/2019 8:07:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Audio](
	[AudioID] [int] IDENTITY(1,1) NOT NULL,
	[HouseID] [int] NULL,
	[URL] [nvarchar](200) NULL,
 CONSTRAINT [PK_Audio] PRIMARY KEY CLUSTERED 
(
	[AudioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 10/24/2019 8:07:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[PhoneNumber] [char](20) NULL,
	[Comment] [nvarchar](max) NULL,
	[HouseID] [int] NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Host]    Script Date: 10/24/2019 8:07:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Host](
	[HostID] [int] IDENTITY(1,1) NOT NULL,
	[HostName] [nvarchar](100) NULL,
	[Avatar] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[PhoneNumber] [char](20) NULL,
	[Address] [nvarchar](100) NULL,
 CONSTRAINT [PK_Host] PRIMARY KEY CLUSTERED 
(
	[HostID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[House]    Script Date: 10/24/2019 8:07:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[House](
	[HouseID] [int] IDENTITY(1,1) NOT NULL,
	[Avatar] [nvarchar](100) NULL,
	[Location] [nvarchar](200) NULL,
	[PropertyType] [nvarchar](50) NULL,
	[_Status] [nvarchar](50) NULL,
	[Area] [int] NULL,
	[Beds] [int] NULL,
	[Baths] [int] NULL,
	[Garage] [int] NULL,
	[PropertyDescription] [nvarchar](max) NULL,
	[DateLine] [date] NULL,
	[Map] [nvarchar](200) NULL,
	[HostID] [int] NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_House] PRIMARY KEY CLUSTERED 
(
	[HouseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Image]    Script Date: 10/24/2019 8:07:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Image](
	[ImageID] [int] IDENTITY(1,1) NOT NULL,
	[HouseID] [int] NULL,
	[URL] [nvarchar](200) NULL,
 CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED 
(
	[ImageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Accout] ([UserName], [Pass]) VALUES (N'DucTruong', N'1998                ')
INSERT [dbo].[Accout] ([UserName], [Pass]) VALUES (N'HuyTra', N'1998                ')
INSERT [dbo].[Accout] ([UserName], [Pass]) VALUES (N'ManhThang', N'1998                ')
INSERT [dbo].[Accout] ([UserName], [Pass]) VALUES (N'QuangDuy', N'1998                ')
SET IDENTITY_INSERT [dbo].[Audio] ON 

INSERT [dbo].[Audio] ([AudioID], [HouseID], [URL]) VALUES (1, 1, N'Video1.mp4')
INSERT [dbo].[Audio] ([AudioID], [HouseID], [URL]) VALUES (2, 2, N'Video.mp4')
INSERT [dbo].[Audio] ([AudioID], [HouseID], [URL]) VALUES (3, 3, N'Video.mp4')
INSERT [dbo].[Audio] ([AudioID], [HouseID], [URL]) VALUES (4, 4, N'Video.mp4')
INSERT [dbo].[Audio] ([AudioID], [HouseID], [URL]) VALUES (5, 5, N'Video.mp4')
INSERT [dbo].[Audio] ([AudioID], [HouseID], [URL]) VALUES (6, 6, N'Video.mp4')
INSERT [dbo].[Audio] ([AudioID], [HouseID], [URL]) VALUES (7, 7, N'Video.mp4')
INSERT [dbo].[Audio] ([AudioID], [HouseID], [URL]) VALUES (8, 8, N'Video.mp4')
INSERT [dbo].[Audio] ([AudioID], [HouseID], [URL]) VALUES (9, 9, N'Video.mp4')
SET IDENTITY_INSERT [dbo].[Audio] OFF
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerID], [Name], [Email], [PhoneNumber], [Comment], [HouseID]) VALUES (1, N'Hoàng Tấn Phát', N'hoangtanphat@gmail.com', N'253242421           ', N'Interested in any of these homes?', 1)
INSERT [dbo].[Customer] ([CustomerID], [Name], [Email], [PhoneNumber], [Comment], [HouseID]) VALUES (2, N'Nguyễn Trọng Long', N'nguyentronglong@gmail.com', N'235324342           ', N'Interested in any of these homes?', 3)
INSERT [dbo].[Customer] ([CustomerID], [Name], [Email], [PhoneNumber], [Comment], [HouseID]) VALUES (3, N'Bùi Mạnh Hoài', N'buimanhhoai@gmail.com', N'235324242           ', N'Interested in any of these homes?', 4)
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Host] ON 

INSERT [dbo].[Host] ([HostID], [HostName], [Avatar], [Email], [PhoneNumber], [Address]) VALUES (1, N'Hoàng Tấn Phát', N'author-1.jpg', N'hoangtanphat@gmail.com', N'355932553           ', NULL)
INSERT [dbo].[Host] ([HostID], [HostName], [Avatar], [Email], [PhoneNumber], [Address]) VALUES (2, N'Phạm Văn Đan', N'author-2.jpg', N'phamvandan@gmail.com', N'452353252           ', NULL)
INSERT [dbo].[Host] ([HostID], [HostName], [Avatar], [Email], [PhoneNumber], [Address]) VALUES (3, N'Trần Mạnh Đạt', N'author-3.jpg', N'tranmanhdat@gmail.com', N'253243422           ', NULL)
INSERT [dbo].[Host] ([HostID], [HostName], [Avatar], [Email], [PhoneNumber], [Address]) VALUES (4, N'Cao Văn Mạnh', N'author-4.jpg', N'caovanmanh@gmail.com', N'135324342           ', NULL)
INSERT [dbo].[Host] ([HostID], [HostName], [Avatar], [Email], [PhoneNumber], [Address]) VALUES (5, N'Nguyễn Minh Hiếu', N'author-5.jpg', N'nguyenminhhieu@gmail.com', N'134124242           ', NULL)
SET IDENTITY_INSERT [dbo].[Host] OFF
SET IDENTITY_INSERT [dbo].[House] ON 

INSERT [dbo].[House] ([HouseID], [Avatar], [Location], [PropertyType], [_Status], [Area], [Beds], [Baths], [Garage], [PropertyDescription], [DateLine], [Map], [HostID], [Price]) VALUES (1, N'AvatarHouse1', N'No. 275 - District 2 - Ho Chi Minh City', N'Apartment', N'Sale', 73, 2, 1, 1, N'
2 bedroom apartment for rent 73 m2 The Sun avenue District 2 New House High floor Clear view Rent 16 million including management fee View house 24/24', CAST(N'2025-12-20' AS Date), N'House1', 1, NULL)
INSERT [dbo].[House] ([HouseID], [Avatar], [Location], [PropertyType], [_Status], [Area], [Beds], [Baths], [Garage], [PropertyDescription], [DateLine], [Map], [HostID], [Price]) VALUES (2, N'AvatarHouse2', N'No. 54 - District 1 - Ho Chi Minh City', N'Apartment', N'Sale', 90, 3, 2, 1, N'
Nice apartment for rent with 3 bedrooms, The Sun Avenue 90M2, with 1 landlord:

New house
Modern interior design
Middle and high floors are available, airy view
The rent includes apartment management fee, Internet, Swimming Pool, Gym, Sauna, Coffee, ... for free.
View home 24/24
 Rent 18.5 Million / Month', CAST(N'2025-12-20' AS Date), N'House2', 2, NULL)
INSERT [dbo].[House] ([HouseID], [Avatar], [Location], [PropertyType], [_Status], [Area], [Beds], [Baths], [Garage], [PropertyDescription], [DateLine], [Map], [HostID], [Price]) VALUES (3, N'AvatarHouse3', N'
No. 221 - Hai Ba Trung - Hai Phong City', N'Apartment', N'Sale', 100, 2, 2, 1, N'
Located about 1.3 km from Hai Phong Opera House, THE FUN APARTMENT offers accommodation with a restaurant, a garden, a bar, views of the garden and courtyard. This apartment is located in a convenient area for guests to engage in activities such as hiking and playing table tennis.

The apartment is located on the ground floor and has 2 bedrooms, a flat-screen cable TV and a fully equipped kitchen with a microwave, fridge, washing machine, oven and stovetop. Guests who do not want to bring lots of luggage can rent towels and sheets here for an extra fee.

FUN APARTMENT features a sun terrace, a children''s playground and a shared lounge.

Vincom Plaza Ngo Quyen is 28 km from the property. The nearest airport is Cat Bi International Airport, 8 km away, and FUN APARTMENT provides airport shuttle service at an additional charge.', CAST(N'2025-12-20' AS Date), N'House3', 3, NULL)
INSERT [dbo].[House] ([HouseID], [Avatar], [Location], [PropertyType], [_Status], [Area], [Beds], [Baths], [Garage], [PropertyDescription], [DateLine], [Map], [HostID], [Price]) VALUES (4, N'AvatarHouse4', N'Lot 20A - Ngo Quyen - Hai Phong City', N'Apartment', N'Sale', 110, 3, 1, 1, N'Located in a prime business district, Somerset Central TD Hai Phong City offers simple and modern rooms with free Wi-Fi and kitchenette facilities. Integrated with the famous TD Plaza complex, guests can easily access the hypermarkets, movie theaters and on-site retail stores.

The elegant apartments feature air conditioning, ironing facilities, a personal safe, a dining area and a living room with a sofa and a flat-screen cable TV. Kitchenettes are outfitted with refrigerators, microwaves, and electric kettles. The private bathroom comes with towels, hairdryer and free toiletries.

At Somerset Central TD Hai Phong City, guests can approach the 24-hour front desk for assistance with services such as airport transfer, luggage storage and dry cleaning. A library, a children''s playroom and a lounge are on site.

The on-site restaurant serves a range of delicious Vietnamese and Western cuisines. Meals can also be served in the private space of your apartment.

Cat Bi International Airport is 5 km away.', CAST(N'2025-12-20' AS Date), N'House4', 4, NULL)
INSERT [dbo].[House] ([HouseID], [Avatar], [Location], [PropertyType], [_Status], [Area], [Beds], [Baths], [Garage], [PropertyDescription], [DateLine], [Map], [HostID], [Price]) VALUES (5, N'AvatarHouse5', N'
No.1 Bach Dang Paris 23-04 Vinhomes Imperia, Hai Phong City', N'Apartment', N'Sale', 80, 1, 2, 1, N'
Located in Hai Phong, 3.2 km from Hai Phong Opera House, Vinhomes Imperia Paris offers accommodations with a garden, free WiFi, a 24-hour front desk, and room service. This air-conditioned accommodation is 3.7 km from Vincom Plaza Ngo Quyen.

The apartment has 1 bedroom, flat-screen TV, fully equipped kitchen, washing machine and 1 bathroom with shower.

The apartment serves a daily buffet breakfast.

Vinhomes Imperia Paris has a terrace.

The nearest airport is Cat Bi International Airport, 10 km away.', CAST(N'2025-12-20' AS Date), N'House5', 5, NULL)
INSERT [dbo].[House] ([HouseID], [Avatar], [Location], [PropertyType], [_Status], [Area], [Beds], [Baths], [Garage], [PropertyDescription], [DateLine], [Map], [HostID], [Price]) VALUES (6, N'AvatarHouse6', N'
Cai Dam B Building Newlife apartment 505, Ha Long', N'Apartment', N'Sale', 75, 2, 1, 1, N'
Apartment 505, Building B, Newlife apartment is located in Bai Chay Ward, Ha Long City, 10 km from Tuan Chau Port, 10 km from Vincom Plaza Ha Long and 11 km from Queen''s Cable Car Station. The property is 3.2 km from Halong Night Market and 3.4 km from Sun World Ha Long Amusement Park.

This apartment is located 11 km from Quang Ninh Museum and 1.2 km from Halong Marine Plaza. The nearest airport is Cat Bi International Airport, 67 km from Apartment 505, Building B, Newlife.', CAST(N'2025-12-20' AS Date), N'House6', 1, NULL)
INSERT [dbo].[House] ([HouseID], [Avatar], [Location], [PropertyType], [_Status], [Area], [Beds], [Baths], [Garage], [PropertyDescription], [DateLine], [Map], [HostID], [Price]) VALUES (7, N'AvatarHouse7', N'
No. 1 Ben Doan, Hon Gai, Ha Long City, Quang Ninh', N'Apartment', N'Sale', 82, 2, 1, 1, N'Located in Ha Long, Luxury Homestay Sapphire has accommodations, a seasonal outdoor pool, bar, shared lounge, garden, terrace and lake views. It is air-conditioned and has a spa bath.

Each room has a patio, a fully equipped kitchen with a dishwasher, a fireplace, a sofa seating area, a flat-screen TV, a washing machine, as well as a private bathroom with a bidet ( bidet) and hair dryer. A microwave, fridge, oven and kettle are also included.

The apartment has a playground for children.

Guests can swim at the indoor pool or bike ride.

Luxury Homestay Sapphire is less than 1 km from Queen''s Cable Car Station and 1.9 km from Vincom Plaza Ha Long. The nearest airport is Cat Bi International Airport, 78 km away.', CAST(N'2025-12-20' AS Date), N'House7', 2, NULL)
INSERT [dbo].[House] ([HouseID], [Avatar], [Location], [PropertyType], [_Status], [Area], [Beds], [Baths], [Garage], [PropertyDescription], [DateLine], [Map], [HostID], [Price]) VALUES (8, N'AvatarHouse8', N'
174/3 Le Lai, District 1, TP. Ho Chi Minh', N'Villa', N'Sale', 200, 4, 2, 2, N'
Located in Ho Chi Minh City, less than 1 km from Ben Thanh Street Food Market, Hemera House offers accommodations with free WiFi, a terrace and views of the city.

This 7-bedroom villa features a living room, a flat-screen satellite TV, a fully equipped kitchen with a microwave and a fridge and 7 bathrooms.

Guests can relax in the shared lounge area.

Tao Dan Park is a 12-minute walk from Hemera House. The nearest airport is Tan Son Nhat International Airport, 12 km away.

District 1 is a great choice for travelers interested in museums, shopping and markets.

This is the area in the city. Ho Chi Minh City guests love, according to independent reviews.', CAST(N'2025-12-20' AS Date), N'House8', 3, NULL)
INSERT [dbo].[House] ([HouseID], [Avatar], [Location], [PropertyType], [_Status], [Area], [Beds], [Baths], [Garage], [PropertyDescription], [DateLine], [Map], [HostID], [Price]) VALUES (9, N'AvatarHouse9', N'
2/30 Cao Thang The Garden building, District 3, TP. Ho Chi Minh', N'Apartment hotel', N'Sale', 80, 1, 1, 1, N'Located in Ho Chi Minh City, 1.1 km from Tao Dan Park, a 16-minute walk from Ba An Temple and an 18-minute walk from War Remnants Museum, The Garden building offers air-conditioned rooms. and free Wi-Fi.

The rooms come with tiled floors, a seating area with a flat-screen TV, a fully equipped kitchen with a microwave, fridge, as well as a kettle and a private bathroom.

This aparthotel has an outdoor pool.

Guests can also use the terrace and shared lounge here.

Ben Thanh Street Food Market is a 19-minute walk from The Garden building. The nearest airport is Tan Son Nhat International Airport, 7 km away.

District 3 is a great choice for travelers interested in local food, restaurants and city walks.', CAST(N'2025-12-20' AS Date), N'House9', 4, NULL)
SET IDENTITY_INSERT [dbo].[House] OFF
SET IDENTITY_INSERT [dbo].[Image] ON 

INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (1, 1, N'House1.1.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (2, 1, N'House1.2.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (3, 1, N'House1.3.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (4, 2, N'House2.1.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (5, 2, N'House2.2.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (6, 2, N'House2.3.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (7, 3, N'House3.1.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (8, 3, N'House3.2.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (9, 3, N'House3.3.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (10, 4, N'House4.1.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (11, 4, N'House4.2.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (12, 4, N'House4.3.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (13, 5, N'House5.1.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (14, 5, N'House5.2.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (15, 5, N'House5.3.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (16, 6, N'House6.1.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (17, 6, N'House6.2.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (18, 6, N'House6.3.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (19, 7, N'House7.1.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (20, 7, N'House7.2.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (21, 7, N'House7.3.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (22, 8, N'House8.1.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (23, 8, N'House8.2.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (24, 8, N'House8.3.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (25, 9, N'House9.1.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (26, 9, N'House9.2.jpg')
INSERT [dbo].[Image] ([ImageID], [HouseID], [URL]) VALUES (27, 9, N'House9.3.jpg')
SET IDENTITY_INSERT [dbo].[Image] OFF
USE [master]
GO
ALTER DATABASE [TechnologyWeb] SET  READ_WRITE 
GO
