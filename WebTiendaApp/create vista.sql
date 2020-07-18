USE [PruebaNet]
GO

/****** Object:  View [dbo].[vw_EmpleadoTienda]    Script Date: 18/07/2020 3:46:42 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[vw_EmpleadoTienda]
AS
SELECT        TblE.Nombres, TblC.Cargo, TblT.NombreTienda, DATENAME(MONTH, TblET.Fecha) AS Mes, DATENAME(DAY, TblET.Fecha) AS Dia
FROM            dbo.TblEmpleado AS TblE INNER JOIN
                         dbo.TblCargo AS TblC ON TblE.IdEmpleado = TblC.IdEmpleado INNER JOIN
                         dbo.TblEmpleadoTblTienda AS TblET ON TblET.IdEmpleado = TblE.IdEmpleado INNER JOIN
                         dbo.TblTienda AS TblT ON TblET.IdTienda = TblT.IdTienda
GO


