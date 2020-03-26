USE [bdfabcalcados]
GO

/****** Object:  Table [dbo].[Produto]    Script Date: 03/26/2020 12:08:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Produto](
	[CodigoProduto] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NULL,
	[Tamanho] [varchar](50) NULL,
	[Colecao] [varchar](50) NULL,
	[PrecoCusto] [money] NULL,
	[Cor] [varchar](50) NULL,
	[Lote] [int] NOT NULL,
 CONSTRAINT [PK__Produto__F94CC5B90BC6C43E] PRIMARY KEY CLUSTERED 
(
	[CodigoProduto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

