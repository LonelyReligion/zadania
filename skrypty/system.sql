USE [TAB]
GO

/****** Object:  Table [dbo].[system]    Script Date: 07/05/2024 21:10:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[system](
	[id_system] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
	[id_related_system] [decimal](18, 0) NULL,
	[id_client] [decimal](18, 0) NOT NULL,
	[type] [varchar](50) NOT NULL,
	[name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_System] PRIMARY KEY CLUSTERED 
(
	[id_system] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[system]  WITH CHECK ADD  CONSTRAINT [FK_System_Client] FOREIGN KEY([id_client])
REFERENCES [dbo].[client] ([id_client])
GO

ALTER TABLE [dbo].[system] CHECK CONSTRAINT [FK_System_Client]
GO

