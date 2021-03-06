/*
   sábado, 30 de octubre de 202112:47:09
   User: 
   Server: DESKTOP-P6PGALT\SQLEXPRESS
   Database: Notas
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Table_1
	(
	idNotas int NOT NULL IDENTITY (1, 1),
	Mensaje varchar(2000) NULL,
	FechaEntrega datetime NULL,
	FechaEscritura datetime NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Table_1 SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
