/*
 
Este es el codigo de la base de datos , hasta el momento (10/08/25) 



 CREATE DATABASE LABORATORIO_PRESENCIAL
GO
USE LABORATORIO_PRESENCIAL
 
CREATE TABLE INVENTARIO (
ID INT IDENTITY (1,1),
CODIGO_DEL_REPUESTO VARCHAR(4) NOT NULL,
NOMBRE_DEL_REPUESTO VARCHAR(100) NOT NULL,
MARCA_DEL_REPUESTO VARCHAR(100) NOT NULL,
VEHICULO VARCHAR(100) NOT NULL,
MODELO VARCHAR(100) NOT NULL,
ANIO INT NOT NULL,
CANTIDAD INT NOT NULL,
FECHA_DE_REGISTRO DATETIME NOT NULL,
FECHA_DE_MODIFICION DATETIME,
ESTADO BIT NOT NULL
);

select * from inventario

INSERT INTO [dbo].[INVENTARIO]
           ([CODIGO_DEL_REPUESTO]
           ,[NOMBRE_DEL_REPUESTO]
           ,[MARCA_DEL_REPUESTO]
           ,[VEHICULO]
           ,[MODELO]
           ,[ANIO]
           ,[CANTIDAD]
           ,[FECHA_DE_REGISTRO]
           ,[FECHA_DE_MODIFICION]
           ,[ESTADO])
     VALUES
           ('1234'
           ,'Compensador'
           ,'KYB'
           ,'Honda'
           ,'Civic'
           ,2024
           ,5
           ,'2025-06-01'
           ,null
           ,1)
GO
 

 
INSERT INTO [dbo].[INVENTARIO]
           ([CODIGO_DEL_REPUESTO]
           ,[NOMBRE_DEL_REPUESTO]
           ,[MARCA_DEL_REPUESTO]
           ,[VEHICULO]
           ,[MODELO]
           ,[ANIO]
           ,[CANTIDAD]
           ,[FECHA_DE_REGISTRO]
           ,[FECHA_DE_MODIFICION]
           ,[ESTADO])
     VALUES
           ('1235'
           ,'muflas'
           ,'KYB'
           ,'toyoca'
           ,'Civic'
           ,2024
           ,5
           ,'2025-06-01'
           ,null
           ,1)
GO
 
 INSERT INTO [dbo].[INVENTARIO]
           ([CODIGO_DEL_REPUESTO]
           ,[NOMBRE_DEL_REPUESTO]
           ,[MARCA_DEL_REPUESTO]
           ,[VEHICULO]
           ,[MODELO]
           ,[ANIO]
           ,[CANTIDAD]
           ,[FECHA_DE_REGISTRO]
           ,[FECHA_DE_MODIFICION]
           ,[ESTADO])
     VALUES
           ('0211'
           ,'Sebastian'
           ,'Prueba'
           ,'Nissa'
           ,'Nissan'
           ,2024
           ,5
           ,'2025-06-01'
           ,null
           ,1)
GO
 
 */