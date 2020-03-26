USE [bdfabcalcados]
GO

/****** Object:  Table [dbo].[Relação_2]    Script Date: 03/26/2020 12:09:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Relação_2](
	[CodigoProduto] [int] NULL,
	[CodigoPedido] [int] NULL
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Relação_2]  WITH CHECK ADD  CONSTRAINT [FK__Relação_2__Codig__1273C1CD] FOREIGN KEY([CodigoProduto])
REFERENCES [dbo].[Produto] ([CodigoProduto])
GO

ALTER TABLE [dbo].[Relação_2] CHECK CONSTRAINT [FK__Relação_2__Codig__1273C1CD]
GO

ALTER TABLE [dbo].[Relação_2]  WITH CHECK ADD  CONSTRAINT [FK__Relação_2__Codig__1367E606] FOREIGN KEY([CodigoPedido])
REFERENCES [dbo].[Pedido] ([CodigoPedido])
GO

ALTER TABLE [dbo].[Relação_2] CHECK CONSTRAINT [FK__Relação_2__Codig__1367E606]
GO

