USE [bdfabcalcados]
GO

/****** Object:  Table [dbo].[Producao]    Script Date: 03/26/2020 12:08:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Producao](
	[CodigoProducao] [int] IDENTITY(1,1) NOT NULL,
	[Lote] [int] NOT NULL,
	[CodigoProduto] [int] NULL,
	[DataProducao] [date] NULL,
	[Tamanho] [varchar](50) NULL,
	[Quantidade] [int] NULL,
 CONSTRAINT [PK_Producao] PRIMARY KEY CLUSTERED 
(
	[CodigoProducao] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

