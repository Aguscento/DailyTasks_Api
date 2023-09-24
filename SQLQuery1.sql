CREATE DATABASE DBTask
USE DBTask
GO

CREATE TABLE Usuarios(
	IDUsuario_U INT IDENTITY (1,1),
	Nombre_U VARCHAR(25) NOT NULL,
	Email_U VARCHAR(30) NOT NULL,
	Clave_U	VARCHAR(50) NOT NULL,
	Activo_U BIT DEFAULT 1,
	FechaDeCarga_U DATETIME DEFAULT GETDATE()
	CONSTRAINT PK_Usuarios PRIMARY KEY(IDUsuario_U)
)

CREATE TABLE Tareas(
	IDTarea_T INT IDENTITY (1,1),
	IDUsuario_U_T INT NOT NULL,
	Nombre_T VARCHAR(50) NOT NULL,
	Descripcion_T VARCHAR(240),
	FechaDeTarea_T DATETIME NOT NULL,
	HoraDeTarea_T TIME,
	FechaDeCarga_T DATETIME DEFAULT GETDATE()
	CONSTRAINT PK_Tareas PRIMARY KEY(IDTarea_T),
	CONSTRAINT FK_Tareas_Usuarios FOREIGN KEY(IDUsuario_U_T) REFERENCES Usuarios(IDUsuario_U)
)
GO
ALTER TABLE Usuarios
ADD CONSTRAINT UK_Nombre UNIQUE (Nombre_U);
GO


INSERT INTO Usuarios(Nombre_U, Email_U, Clave_U)
SELECT 'cento', 'agus_cento@hotmail.com', '1234' UNION
SELECT 'admin', 'admin@admin.com', '4321'
GO

INSERT INTO Tareas(IDUsuario_U_T, Nombre_T, FechaDeTarea_T)
SELECT '1', 'Almuerzo', '2023-10-3' UNION
SELECT '1', 'Estudio', '2023-10-3'
GO