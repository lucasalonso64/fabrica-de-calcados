USE [bdfabcalcados]
GO

/****** Object:  Table [dbo].[Color]    Script Date: 03/26/2020 12:07:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Color](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Cor] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Color] PRIMARY KEY CLUSTERED 
(
	[Cor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Color]  WITH CHECK ADD  CONSTRAINT [FK_Color_Color] FOREIGN KEY([Cor])
REFERENCES [dbo].[Color] ([Cor])
GO

ALTER TABLE [dbo].[Color] CHECK CONSTRAINT [FK_Color_Color]
GO
