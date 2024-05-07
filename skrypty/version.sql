USE [TAB]
GO

/****** Object:  Table [dbo].[version]    Script Date: 07/05/2024 21:10:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[version](
	[number] [varchar](50) NOT NULL,
	[id_version] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
	[id_system] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Version] PRIMARY KEY CLUSTERED 
(
	[id_version] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[version]  WITH CHECK ADD  CONSTRAINT [FK_Version_System] FOREIGN KEY([id_system])
REFERENCES [dbo].[system] ([id_system])
GO

ALTER TABLE [dbo].[version] CHECK CONSTRAINT [FK_Version_System]
GO

