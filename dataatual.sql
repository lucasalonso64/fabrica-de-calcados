USE [bdfabcalcados]
GO

/****** Object:  Table [dbo].[dataatual]    Script Date: 03/26/2020 12:07:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[dataatual](
	[codigodata] [int] NOT NULL,
	[data] [datetime] NOT NULL,
 CONSTRAINT [PK_dataatual_1] PRIMARY KEY CLUSTERED 
(
	[codigodata] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

