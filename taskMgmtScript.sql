USE [master]
GO
/****** Object:  Database [taskMgmt]    Script Date: 12-Mar-23 6:16:39 PM ******/
CREATE DATABASE [taskMgmt]

GO
ALTER DATABASE [taskMgmt] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [taskMgmt] SET ANSI_NULLS ON 
GO
ALTER DATABASE [taskMgmt] SET ANSI_PADDING ON 
GO
ALTER DATABASE [taskMgmt] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [taskMgmt] SET ARITHABORT ON 
GO
ALTER DATABASE [taskMgmt] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [taskMgmt] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [taskMgmt] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [taskMgmt] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [taskMgmt] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [taskMgmt] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [taskMgmt] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [taskMgmt] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [taskMgmt] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [taskMgmt] SET  DISABLE_BROKER 
GO
ALTER DATABASE [taskMgmt] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [taskMgmt] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [taskMgmt] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [taskMgmt] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [taskMgmt] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [taskMgmt] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [taskMgmt] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [taskMgmt] SET RECOVERY FULL 
GO
ALTER DATABASE [taskMgmt] SET  MULTI_USER 
GO
ALTER DATABASE [taskMgmt] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [taskMgmt] SET DB_CHAINING OFF 
GO
ALTER DATABASE [taskMgmt] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [taskMgmt] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [taskMgmt] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [taskMgmt] SET QUERY_STORE = OFF
GO
USE [taskMgmt]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [taskMgmt]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 12-Mar-23 6:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[full_name] [varchar](50) NOT NULL,
	[email] [varchar](50) NULL,
	[phone] [varchar](50) NULL,
	[date_of_birth] [date] NULL,
	[salary] [int] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Project]    Script Date: 12-Mar-23 6:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](200) NOT NULL,
	[description] [varchar](1000) NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Task]    Script Date: 12-Mar-23 6:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Task](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](200) NOT NULL,
	[description] [varchar](1000) NOT NULL,
	[assignee] [int] NOT NULL,
	[project_id] [int] NOT NULL,
	[due_date] [date] NOT NULL,
	[status] [int] NOT NULL,
	[created_at] [date] NULL,
	[updated_at] [date] NULL,
	[resolved] [date] NULL,
 CONSTRAINT [PK_Task] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[project_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (1, N'Tom Selleck', N'tom.selleck@gmail.com', N'+381695533684', CAST(N'1966-07-14' AS Date), 2300)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (3, N'Victoria Hernandez', N'victoria.hernandez89@example.com', N'(555) 123-4567', CAST(N'2001-03-08' AS Date), 2600)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (1002, N'Matthew Garcia', N'matthew.garcia92@example.com', N'+381695588556', CAST(N'1994-06-14' AS Date), 1900)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2002, N'Ava Phillips', N'ava.phillips95@example.com', N'(555) 901-2345', CAST(N'1999-06-16' AS Date), 1500)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2003, N'Christopher Davis', N'christopher.davis87@example.com', N'(555) 012-3456', CAST(N'1999-06-25' AS Date), 1550)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2004, N'Elizabeth Cooper', N'elizabeth.cooper84@example.com', N'(555) 345-6789', CAST(N'2000-06-12' AS Date), 2000)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2005, N'Michael Johnson', N'michael.johnson91@example.com', N'(555) 456-7890', CAST(N'1989-06-21' AS Date), 2000)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2006, N'Charlotte Kim', N'charlotte.kim86@example.com', N'(555) 567-8901', CAST(N'1979-05-29' AS Date), 2100)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2007, N'Olivia Taylor', N'olivia.taylor94@example.com', N'(555) 123-4567', CAST(N'1969-07-24' AS Date), 3500)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2008, N'Ethan Hunt', N'ethan.hunt82@example.com', N'(555) 234-5678', CAST(N'1980-07-24' AS Date), 3500)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2009, N'Emma Watson', N'emma.watson88@example.com', N'(555) 345-6789', CAST(N'1990-07-11' AS Date), 2200)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2010, N'Alexander Greene', N'alexander.greene77@example.com', N'(555) 456-7890', CAST(N'1990-07-18' AS Date), 1600)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2011, N'Isabella Rodriguez', N'isabella.rodriguez96@example.com', N'(555) 567-890', CAST(N'1999-07-29' AS Date), 900)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2012, N'Aleksandra Kalimancevic', N'kalimancevic66@example.com', N'(555) 567-890', CAST(N'1999-04-30' AS Date), 400)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2013, N'Benjamin Lee', N'benjamin.lee85@example.com', N'(555) 678-9012', CAST(N'1984-08-24' AS Date), 1400)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2014, N'Sophia Baker', N'sophia.baker93@example.com', N'(555) 789-0123', CAST(N'1990-08-24' AS Date), 400)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2015, N'William Chen', N'william.chen81@example.com', N'(555) 890-1234', CAST(N'1997-05-28' AS Date), 400)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2016, N'Ethan Wright', N'ethan.wright87@example.com', N'(555) 901-3456', CAST(N'2004-06-08' AS Date), 1200)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2017, N'Isabella Martin', N'isabella.martin92@example.com', N'(555) 012-4567', CAST(N'1999-06-18' AS Date), 1200)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2018, N'Alexander Baker', N'alexander.baker81@example.com', N'(555) 012-3529', CAST(N'1995-07-14' AS Date), 1200)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2019, N'Olivia Ramirez', N'olivia.ramirez89@example.com', N'(555) 234-6789', CAST(N'1993-06-23' AS Date), 1500)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2020, N'William Hernandez', N'william.hernandez95@example.com', N'(555) 234-6783', CAST(N'1993-06-19' AS Date), 1500)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2021, N'Lucas Parker', N'lucas.parker80@example.com', N'(555) 678-1234', CAST(N'1990-01-31' AS Date), 2500)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2022, N'Lily Collins', N'lily.collins99@example.com', N'(555) 789-2345', CAST(N'1990-04-27' AS Date), 1500)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2023, N'Daniel Kim', N'daniel.kim88@example.com', N'(555) 901-3456', CAST(N'1996-02-23' AS Date), 3500)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2024, N'Emily Scott', N'emily.scott87@example.com', N'(555) 012-4567', CAST(N'1996-06-08' AS Date), 800)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2025, N'Joshua Young', N'joshua.young83@example.com', N'(555) 123-5678', CAST(N'1991-04-19' AS Date), 1300)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2026, N'Ava Kim', N'ava.kim88@example.com', N'(555) 456-9012', CAST(N'1994-06-08' AS Date), 2500)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2027, N'Mia Mitchell', N'mia.mitchell94@example.com', N'(555) 234-6789', CAST(N'1996-08-17' AS Date), 600)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2028, N'Ryan Nguyen', N'ryan.nguyen90@example.com', N'(555) 345-7890', CAST(N'1994-06-16' AS Date), 3600)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2029, N'Grace Adams', N'grace.adams85@example.com', N'(555) 456-9090', CAST(N'1994-04-16' AS Date), 3400)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2030, N'Samuel Lee', N'samuel.lee89@example.com', N'(555) 567-0123', CAST(N'2002-03-13' AS Date), 500)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2031, N'Chloe Lewis', N'chloe.lewis96@example.com', N'(555) 678-1234', CAST(N'1994-05-11' AS Date), 1600)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2032, N'Tyler Edwards', N'tyler.edwards81@example.com', N'(555) 789-2345', CAST(N'1997-06-19' AS Date), 700)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2033, N'Natalie Brown', N'natalie.brown87@example.com', N'(555) 901-3456', CAST(N'1998-07-17' AS Date), 3500)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2034, N'Kevin Kim', N'kevin.kim82@example.com', N'(555) 012-4567', CAST(N'1992-08-20' AS Date), 600)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2035, N'Addison Jackson', N'addison.jackson91@example.com', N'(555) 123-5678', CAST(N'1990-07-20' AS Date), 2530)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2036, N'Benjamin Cooper', N'benjamin.cooper97@example.com', N'(555) 345-7890', CAST(N'1996-08-16' AS Date), 1690)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2037, N'Sofia Davis', N'sofia.davis80@example.com', N'(555) 789-2345', CAST(N'1976-06-15' AS Date), 3700)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2038, N'Christopher Martinez', N'christopher.martinez95@example.com', N'(555) 234-6789', CAST(N'1978-07-21' AS Date), 3200)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2039, N'Madison Collins', N'madison.collins94@example.com', N'(555) 345-7890', CAST(N'1980-08-16' AS Date), 1700)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2040, N'Noah Rodriguez', N'noah.rodriguez84@example.com', N'(555) 456-9012', CAST(N'1990-04-13' AS Date), 2600)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2041, N'Ella Smith', N'ella.smith86@example.com', N'(555) 567-0123', CAST(N'1992-03-19' AS Date), 3000)
INSERT [dbo].[Employee] ([id], [full_name], [email], [phone], [date_of_birth], [salary]) VALUES (2042, N'James Lee', N'james.lee83@example.com', N'(555) 678-1234', CAST(N'1992-12-08' AS Date), 2200)
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Project] ON 

INSERT [dbo].[Project] ([id], [title], [description]) VALUES (17, N'Redesign Website', N'The goal is to redesign an existing website to improve its usability, functionality, and user experience. The website is a critical part of the organization''s online presence and serves as a key marketing tool to promote its services and products.')
INSERT [dbo].[Project] ([id], [title], [description]) VALUES (18, N'Database Migration', N'The goal of this project is to migrate an existing database to a new platform to improve its performance, scalability, and security. The database is critical to the organization''s operations and stores sensitive and confidential data.')
INSERT [dbo].[Project] ([id], [title], [description]) VALUES (19, N'Create a Mobile Game', N'This project involves creating a mobile game for a gaming company. The game will be developed using a game engine and will have engaging gameplay and high-quality graphics. The project includes defining requirements, choosing a game engine, designing game mechanics and user interface, developing the game, testing the game, optimizing the game, and publishing the game.')
INSERT [dbo].[Project] ([id], [title], [description]) VALUES (20, N'Develop an AI-powered Chatbot', N'This project involves developing an AI-powered chatbot for a company that wants to provide customer support through a chat interface. The chatbot will use natural language processing and machine learning to understand customer queries and provide relevant responses. The project includes defining the scope, choosing an AI platform, designing the conversational flow, developing the chatbot, testing the chatbot, integrating the chatbot with customer support systems, and monitoring user feedback and chatbot performance metrics.')
INSERT [dbo].[Project] ([id], [title], [description]) VALUES (21, N'Build an Online Marketplace ', N'This project involves building an online marketplace for a company that wants to expand its sales beyond brick-and-mortar stores. The marketplace will allow vendors to sell their products and customers to purchase them online. The project includes defining requirements, choosing an e-commerce platform, designing the user interface, developing the website, testing the website, implementing web analytics, and deploying the website.')
INSERT [dbo].[Project] ([id], [title], [description]) VALUES (22, N'Develop a Project Management Application', N'This project involves developing a project management application for a company that is currently managing projects using spreadsheets and email. The application will allow users to create and manage projects, tasks, and timelines, as well as communicate with team members. The project includes defining requirements, choosing a development platform, designing the user interface, developing the application, testing the application, deploying the application, and collecting user feedback and usage metrics.')
INSERT [dbo].[Project] ([id], [title], [description]) VALUES (23, N'Implement a Document Management System', N'This project involves implementing a document management system (DMS) for a company that is currently managing documents manually. The DMS will allow users to store, organize, and retrieve documents electronically. The project includes defining requirements, selecting a DMS platform, designing system architecture, configuring the system, migrating existing documents, training users, and monitoring system usage and performance.')
INSERT [dbo].[Project] ([id], [title], [description]) VALUES (24, N'Website Development', N'The goal of this project is to create a website that is visually appealing, user-friendly, and optimized for search engines. The website will be designed to meet the needs of the target audience and to achieve the objectives of the organization.')
INSERT [dbo].[Project] ([id], [title], [description]) VALUES (25, N'Cloud Migration', N'The goal of this project is to migrate the organization''s applications and systems to the cloud, reducing the need for on-premise infrastructure and providing greater flexibility and scalability. The project will involve choosing a cloud provider, developing a migration plan, and conducting comprehensive testing to ensure that the migrated applications and systems are functioning as intended.')
INSERT [dbo].[Project] ([id], [title], [description]) VALUES (26, N'Mobile App Development', N'The goal of this project is to create a mobile app that provides value to the target audience and achieves the objectives of the organization. The app will be designed to be visually appealing, easy to use, and optimized for performance on mobile devices. The project will involve conducting user research, developing wireframes and user flow diagrams, designing mockups, and building the front-end and back-end code for the app.')
SET IDENTITY_INSERT [dbo].[Project] OFF
GO
SET IDENTITY_INSERT [dbo].[Task] ON 

INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2, N'Develop a project plan', N'Create a very detailed plan outlining the timeline, budget, resources, and deliverables for the database migration project.', 1, 18, CAST(N'2023-04-14' AS Date), 1, CAST(N'2023-01-10' AS Date), CAST(N'2023-03-12' AS Date), NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (1002, N'Analyze existing database structure and data', N'Analyze the existing database structure and data to understand the complexity and dependencies', 2006, 18, CAST(N'2023-06-17' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-02-22' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (1003, N'Identify target database platform and requirements', N'Identify the target database platform and requirements to ensure that it meets the organization''s business objectives and technical needs.', 2002, 18, CAST(N'2023-04-03' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-02-22' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (1004, N'Design new database schema and data migration plan', N'Design a new database schema and data migration plan to ensure that the data is migrated accurately and efficiently.', 2008, 18, CAST(N'2023-04-08' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-02-22' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (1005, N'Write scripts to extract, transform, and load data', N'Write scripts to extract data from the existing database, transform it to match the new schema, and load it into the new database.', 2008, 18, CAST(N'2023-04-11' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-02-22' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (1006, N'Define requirements', N'Define the requirements for the mobile game, including gameplay mechanics, graphics, and sound effects', 2023, 19, CAST(N'2023-07-03' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-02-22' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (1007, N'Choose a game engine', N'Choose a game engine, such as Unity or Unreal Engine, that is suitable for building the game', 1, 19, CAST(N'2023-07-05' AS Date), 2, CAST(N'2023-01-10' AS Date), CAST(N'2023-03-11' AS Date), CAST(N'2023-03-11' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (1008, N'Design game mechanics and user interface', N'Design the game mechanics and user interface, taking into account usability and user experience (UX) best practices', 2028, 19, CAST(N'2023-03-24' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-02-22' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (1009, N'Develop game', N'Develop the game, including creating game assets and programming game logic.', 2018, 19, CAST(N'2023-05-31' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-02-22' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (1010, N'Test game', N'Test the game thoroughly to ensure that it is stable and fun to play.
', 1002, 19, CAST(N'2023-06-30' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-02-22' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (1011, N'Optimize game', N'Optimize the game for performance and compatibility with different mobile devices.
', 2004, 19, CAST(N'2023-07-08' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-02-22' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (1012, N'Define scope', N'Define the scope of the chatbot, including the types of customer inquiries it will handle.
', 2029, 20, CAST(N'2023-03-21' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-02-22' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (1013, N'Choose an AI platform', N'Choose an artificial intelligence (AI) platform, such as Dialogflow or Watson Assistant, that is suitable for building the chatbot', 2013, 20, CAST(N'2023-03-23' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-02-22' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (1014, N'Design conversational flow', N'Design the conversational flow of the chatbot, taking into account user intents and potential conversation paths', 2014, 20, CAST(N'2023-03-31' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-02-22' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (1015, N'Develop chatbot', N'Develop the chatbot, including training it to understand and respond to customer inquiries.
', 2012, 20, CAST(N'2023-05-01' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-02-22' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (1016, N'Test chatbot', N'Test the chatbot thoroughly to ensure that it is functioning correctly and providing accurate responses.
', 1, 20, CAST(N'2023-05-31' AS Date), 3, CAST(N'2023-01-10' AS Date), CAST(N'2023-03-12' AS Date), NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (1017, N'Integrate chatbot with customer support systems', N'Integrate the chatbot with the company''s customer support systems, such as helpdesk software or live chat platforms.
', 2021, 20, CAST(N'2023-06-08' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-02-22' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (1018, N'Monitor user feedback and chatbot performance metrics', N'Monitor user feedback and chatbot performance metrics to identify areas for improvement and new features to add.
', 2017, 20, CAST(N'2023-06-30' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-02-22' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2002, N'Develop a project plan', N'Create a detailed plan outlining the timeline, budget, resources, and deliverables for the website redesign project.', 2028, 17, CAST(N'2023-04-11' AS Date), 0, CAST(N'2023-01-10' AS Date), NULL, NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2003, N'Identify website requirements and specifications', N'Gather and document the website requirements and specifications to ensure that the new website meets the organization''s business objectives and user needs', 2022, 17, CAST(N'2023-04-19' AS Date), 0, CAST(N'2023-01-10' AS Date), NULL, NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2004, N'Conduct user research to gather insights', N'Conduct surveys, interviews, and focus groups with users to gather insights and feedback on the existing website.', 2014, 17, CAST(N'2023-04-21' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-02-28' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2005, N'Analyze website traffic and engagement data', N'Analyze website traffic and engagement data to identify areas for improvement and inform the redesign process.
', 2013, 17, CAST(N'2023-04-29' AS Date), 0, CAST(N'2023-01-10' AS Date), NULL, NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2006, N'Develop wireframes and prototypes', N'Develop wireframes and prototypes of the new website to visualize the design and layout.
', 1, 17, CAST(N'2023-05-08' AS Date), 1, CAST(N'2023-01-10' AS Date), CAST(N'2023-03-12' AS Date), NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2007, N'Obtain stakeholder approval for design', N'Present the design concepts to stakeholders and obtain their approval before moving forward with development.

', 2026, 17, CAST(N'2023-05-13' AS Date), 0, CAST(N'2023-01-10' AS Date), NULL, NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2008, N'Write HTML/CSS code for website', N'Write HTML/CSS code to implement the approved design and layout.

', 2013, 17, CAST(N'2023-05-22' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-02-28' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2009, N'Develop and integrate content management system', N'Develop and integrate a content management system (CMS) to enable easy content updates and management.

', 2012, 17, CAST(N'2023-05-27' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-02-28' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2010, N'Test website for usability and functionality', N'Test the new website for usability and functionality to ensure that it meets the requirements and user needs.
', 2022, 17, CAST(N'2023-06-09' AS Date), 0, CAST(N'2023-01-10' AS Date), NULL, NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2011, N'Deploy website to hosting platform', N'Deploy the new website to a hosting platform.

', 2015, 17, CAST(N'2023-06-17' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-02-28' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2012, N'Train website administrators on content management system', N'Provide training to website administrators on how to use the CMS to update and manage content
', 2037, 17, CAST(N'2023-06-20' AS Date), 0, CAST(N'2023-01-10' AS Date), NULL, NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2013, N'Launch website and conduct post-launch review', N'Launch the new website and conduct a post-launch review to identify any issues and make improvements', 2035, 17, CAST(N'2023-06-24' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-02-28' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2014, N'Define requirements', N'Define the requirements for the project management application, including task management, resource allocation, and project tracking.
', 2016, 22, CAST(N'2023-06-05' AS Date), 0, CAST(N'2023-01-10' AS Date), NULL, NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2015, N'Choose a development platform', N'Choose a development platform, such as ASP.NET or Ruby on Rails, that is suitable for building the application.
', 2012, 22, CAST(N'2023-06-07' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-03-05' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2016, N'Design user interface', N'Design the user interface for the application, taking into account usability and user experience (UX) best practices
', 1, 22, CAST(N'2023-06-10' AS Date), 1, CAST(N'2023-01-10' AS Date), CAST(N'2023-03-12' AS Date), NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2017, N'Develop application', N'Develop the application, including creating the database schema and implementing business logic.
', 2012, 22, CAST(N'2023-06-13' AS Date), 0, CAST(N'2023-01-10' AS Date), NULL, NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2018, N'Test application', N'Test the application thoroughly to ensure that it is stable and bug-free.

', 2040, 22, CAST(N'2023-06-16' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-03-05' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2019, N'Deploy application', N'Deploy the application to a production environment and monitor its performance and availability
', 1, 22, CAST(N'2023-06-18' AS Date), 1, CAST(N'2023-01-10' AS Date), CAST(N'2023-03-12' AS Date), NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2020, N'Collect user feedback and usage metrics', N'Collect user feedback and usage metrics

', 1, 22, CAST(N'2023-06-24' AS Date), 1, CAST(N'2023-01-10' AS Date), CAST(N'2023-03-12' AS Date), NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2021, N'Define requirements', N'Define the requirements for the document management system, including document types, access control, and search functionality.

', 2019, 23, CAST(N'2023-04-11' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-03-11' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2022, N'Choose a document management platform', N'Choose a document management platform, such as SharePoint or Alfresco, that meets the requirements.


', 2019, 23, CAST(N'2023-04-13' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-03-11' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2023, N'Design system architecture', N'Design the architecture of the document management system, including the storage solution and backup strategy.


', 2026, 23, CAST(N'2023-04-16' AS Date), 0, CAST(N'2023-01-10' AS Date), NULL, NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2024, N'Configure the document management system', N'Configure the document management system, including setting up user permissions and document workflows.


', 2024, 23, CAST(N'2023-04-18' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-03-11' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2025, N'Migrate existing documents', N'Migrate existing documents to the new system and ensure they are properly tagged and categorized.



', 2020, 23, CAST(N'2023-04-21' AS Date), 0, CAST(N'2023-01-10' AS Date), NULL, NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2026, N'Train users', N'Train users on how to use the document management system and its features.



', 2012, 23, CAST(N'2023-04-24' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-03-11' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2027, N'Monitor system usage and performance', N'Monitor system usage and performance to identify areas for improvement


', 2021, 23, CAST(N'2023-04-27' AS Date), 0, CAST(N'2023-01-10' AS Date), NULL, NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2028, N'Analyze current infrastructure', N'Analyze the existing infrastructure to determine which applications and systems should be migrated to the cloud.


', 2012, 25, CAST(N'2023-03-29' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-01-15' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2029, N'Choose a cloud provider', N'Research and compare different cloud providers to determine which provider best suits the organization''s needs.

', 2023, 25, CAST(N'2023-04-01' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-03-19' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2030, N'Develop migration plan', N'Develop a comprehensive plan for migrating the organization''s applications and systems to the cloud, including timelines, dependencies, and risks.

', 2017, 25, CAST(N'2023-04-04' AS Date), 0, CAST(N'2023-01-10' AS Date), NULL, NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2031, N'Prepare applications and systems for migration', N'Prepare applications and systems for migration, including configuring security settings and ensuring compatibility with the chosen cloud provider
', 2016, 25, CAST(N'2023-04-07' AS Date), 0, CAST(N'2023-01-10' AS Date), NULL, NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2032, N'Migrate applications and systems to the cloud', N'Migrate the organization''s applications and systems to the cloud, following the migration plan and addressing any issues that arise.
', 2014, 25, CAST(N'2023-04-11' AS Date), 0, CAST(N'2023-01-10' AS Date), NULL, NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2033, N'Conduct post-migration testing', N'Conduct comprehensive testing to ensure that the migrated applications and systems are functioning as intended and that there are no bugs or errors.
', 2013, 25, CAST(N'2023-04-14' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-03-19' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2034, N'Optimize cloud infrastructure', N'Optimize the cloud infrastructure, including configuring security settings and fine-tuning performance. 
', 1, 25, CAST(N'2023-04-21' AS Date), 1, CAST(N'2023-01-10' AS Date), CAST(N'2023-03-12' AS Date), NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2035, N'Train staff on using the cloud', N'Train staff on how to use the new cloud infrastructure and applications, providing support and guidance as needed.', 2019, 25, CAST(N'2023-04-24' AS Date), 0, CAST(N'2023-01-10' AS Date), NULL, NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2036, N'Define project scope and objectives', N'Define the scope of the mobile app development project, outlining the objectives, goals, and deliverables.', 2012, 26, CAST(N'2023-03-13' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-01-18' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2037, N'Conduct user research', N'Gather user insights to understand their needs and preferences for the mobile app. Conduct surveys, interviews, and analyze mobile app analytics', 2012, 26, CAST(N'2023-03-18' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-01-18' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2038, N'Develop app wireframes and user flow diagrams', N'Create wireframes and user flow diagrams that will serve as the blueprints for the mobile app''s design and functionality.', 2021, 26, CAST(N'2023-03-20' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-03-22' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2039, N'Design website mockups', N'Based on the wireframes and user flow diagrams, design website mockups that showcase the website''s visual design and user interface.
', 2018, 24, CAST(N'2023-03-16' AS Date), 0, CAST(N'2023-01-10' AS Date), NULL, NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2040, N'Develop website front-end and back-end code', N'Build the website''s front-end and back-end code using technologies such as HTML, CSS, JavaScript, and PHP.
', 2012, 24, CAST(N'2023-03-18' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-01-18' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2041, N'Conduct quality assurance testing', N'Conduct comprehensive testing to ensure that the website is functioning as intended and that there are no bugs or errors.', 2027, 24, CAST(N'2023-03-20' AS Date), 0, CAST(N'2023-01-10' AS Date), NULL, NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2042, N'Choose an e-commerce platform', N'Choose an e-commerce platform, such as WooCommerce or Shopify, that meets the requirements.
', 1, 21, CAST(N'2023-03-29' AS Date), 1, CAST(N'2023-01-10' AS Date), CAST(N'2023-03-12' AS Date), NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2043, N'Design user interface', N'Design the user interface for the online marketplace, taking into account usability and user experience (UX) best practices.

', 2023, 21, CAST(N'2023-03-31' AS Date), 2, CAST(N'2023-01-10' AS Date), NULL, CAST(N'2023-03-27' AS Date))
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2044, N'Develop Website', N'Develop the website, including creating the database schema and implementing business logic.


', 2012, 21, CAST(N'2023-04-14' AS Date), 0, CAST(N'2023-01-10' AS Date), NULL, NULL)
INSERT [dbo].[Task] ([id], [title], [description], [assignee], [project_id], [due_date], [status], [created_at], [updated_at], [resolved]) VALUES (2045, N'Test website', N'Test the website thoroughly to ensure that it is stable and bug-free.


', 2040, 21, CAST(N'2023-04-29' AS Date), 0, CAST(N'2023-01-10' AS Date), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Task] OFF
GO
ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK_Task_Employee] FOREIGN KEY([assignee])
REFERENCES [dbo].[Employee] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_Employee]
GO
ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK_Task_Project] FOREIGN KEY([project_id])
REFERENCES [dbo].[Project] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_Project]
GO
/****** Object:  StoredProcedure [dbo].[GetProjectPercentage]    Script Date: 12-Mar-23 6:16:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[GetProjectPercentage]


AS
BEGIN
	DROP TABLE IF EXISTS ##tmpFinished
	DROP TABLE IF EXISTS ##tmpAll
	SELECT COUNT(t.id) AS NumOfFinished, p.* 
	INTO ##tmpFinished
	FROM dbo.Project AS p
	JOIN dbo.Task AS t ON t.project_id = p.id
	WHERE t.status = 2
	GROUP BY p.id, p.title, p.description

	SELECT COUNT(t.id) AS NumOfAll, p.* 
	INTO ##tmpAll
	FROM dbo.Project AS p
	JOIN dbo.Task AS t ON t.project_id = p.id
	--WHERE t.status = 2
	GROUP BY p.id, p.title, p.description

	SELECT ROUND((CAST(tf.NumOfFinished AS FLOAT) / CAST(ta.NumOfAll AS FLOAT)) * 100, 2) AS Percentage, tf.id, tf.title, tf.description 
	FROM ##tmpFinished AS tf
	INNER JOIN ##tmpAll AS ta ON ta.id = tf.id
	ORDER BY Percentage DESC
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateTask]    Script Date: 12-Mar-23 6:16:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[UpdateTask]

	 @TaskId INT
	,@Title VARCHAR(200)
	,@Description VARCHAR(1000)
	,@Assignee INT
	,@DueDate DATETIME
	,@Status INT

AS
BEGIN

	DECLARE @Resolved DATETIME

	IF @Status = 2
	BEGIN
	    SET @Resolved = GETDATE()
	END
	ELSE
	BEGIN
	    SET @Resolved = NULL
	END
	
	UPDATE dbo.Task SET title = @Title, description = @Description, assignee = @Assignee, due_date = @DueDate, status = @Status, updated_at = GETDATE(), resolved = @Resolved
	WHERE id = @TaskId

END
GO
USE [master]
GO
ALTER DATABASE [taskMgmt] SET  READ_WRITE 
GO
