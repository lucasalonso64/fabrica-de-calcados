USE [bdfabcalcados]
GO

/****** Object:  Table [dbo].[Entrega]    Script Date: 03/26/2020 12:07:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Entrega](
	[CodigoEntrega] [int] IDENTITY(1,1) NOT NULL,
	[CodigoCliente] [int] NULL,
	[CodigoPedido] [int] NULL,
	[EnderecoCliente] [varchar](100) NULL,
	[EstadoEntrega] [varchar](50) NULL,
 CONSTRAINT [PK__Entrega__6DE3EC0C03317E3D] PRIMARY KEY CLUSTERED 
(
	[CodigoEntrega] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

