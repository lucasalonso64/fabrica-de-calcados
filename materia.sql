USE [bdfabcalcados]
GO

/****** Object:  Table [dbo].[Materia]    Script Date: 03/26/2020 12:08:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Materia](
	[CodigoFornecedor] [int] IDENTITY(1,1) NOT NULL,
	[NomeFornecedor] [varchar](50) NULL,
	[CNPJForncedor] [varchar](50) NULL,
	[CodigoMateria] [int] NULL,
	[NomeMateria] [varchar](50) NULL,
	[UnidadeMedida] [varchar](50) NULL,
	[Tipo] [varchar](50) NULL,
 CONSTRAINT [PK_Materia] PRIMARY KEY CLUSTERED 
(
	[CodigoFornecedor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

