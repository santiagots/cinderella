  UPDATE [VENTAS_DETALLE]
  SET [Iva] = PRECIO * 0.21
  WHERE [Monto] IS NULL

  UPDATE [VENTAS_DETALLE]
  SET [Monto] =  [Precio] + [Iva]
  WHERE [Monto] IS NULL

  UPDATE [NOTAPEDIDO_DETALLE]
  SET [Iva] = PRECIO * 0.21
  WHERE [Monto] IS NULL

  UPDATE [NOTAPEDIDO_DETALLE]
  SET [Monto] =  [Precio] + [Iva]
  WHERE [Monto] IS NULL