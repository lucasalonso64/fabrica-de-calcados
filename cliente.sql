USE [bdfabcalcados]
GO

/****** Object:  Table [dbo].[Cliente]    Script Date: 03/26/2020 12:07:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Cliente](
	[CodigoCliente] [int] IDENTITY(1,1) NOT NULL,
	[NomeCliente] [varchar](50) NULL,
	[Telefone] [varchar](50) NULL,
	[Cpf] [varchar](50) NULL,
	[CnpjCLi] [varchar](50) NULL,
	[EnderecoCliente] [varchar](50) NULL,
	[NomeLoja] [varchar](50) NULL,
 CONSTRAINT [PK__Cliente__E0DD7E717F60ED59] PRIMARY KEY CLUSTERED 
(
	[CodigoCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

