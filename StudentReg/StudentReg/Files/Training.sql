USE [Training]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 18-11-2019 07:47:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [nvarchar](50) NULL,
	[DOB] [date] NULL,
	[StudentAddress] [nvarchar](500) NULL,
	[StudentEmail] [nvarchar](50) NULL,
	[StudentMobileNo] [bigint] NULL,
	[StudentAge] [int] NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO




insert into Students
values ('sumesh','1983-12-12','palakkad','sumesh@gmail.com',7353511222,33)


select * from Students