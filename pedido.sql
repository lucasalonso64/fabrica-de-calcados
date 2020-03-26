USE [bdfabcalcados]
GO

/****** Object:  Table [dbo].[Pedido]    Script Date: 03/26/2020 12:08:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Pedido](
	[CodigoPedido] [int] IDENTITY(1,1) NOT NULL,
	[NomeCliente] [varchar](50) NULL,
	[ValorItem] [money] NULL,
	[Produtos] [varchar](50) NULL,
	[Tamanho] [varchar](50) NULL,
	[Quantidade] [int] NULL,
	[Desconto] [money] NULL,
	[ValoTotal] [money] NULL,
	[ValorItemTotal] [money] NULL,
	[ValorFinalPrevio] [money] NULL,
	[CodigoCliente] [int] NULL,
 CONSTRAINT [PK__Pedido__72162F0B07020F21] PRIMARY KEY CLUSTERED 
(
	[CodigoPedido] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK__Pedido__CodigoCl__08EA5793] FOREIGN KEY([CodigoCliente])
REFERENCES [dbo].[Cliente] ([CodigoCliente])
GO

ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK__Pedido__CodigoCl__08EA5793]
GO

