CREATE DATABASE PROYECTOQAG4
USE PROYECTOQAG4



CREATE TABLE ROL(
IdRol int NOT NULL primary key identity,
Descripcion VARCHAR (50),
NombreMenu VARCHAR (50),
FechaRegistro datetime default getdate()
)


CREATE TABLE PERMISOS(
IdPermiso int NOT NUL primary key identity,
IdRol int references ROL (IdRol),
NombreMenu VARCHAR (50),
FechaRegistro datetime default getdate()
)

CREATE TABLE USUARIO(
IdUsuario int NOT NULL primary key identity,
Documento varchar(50),
NombreCompleto varchar(50),
Correo varchar (50),
Clave varchar(50),
IdRol int references ROL (IdRol),
Estado bit,
FechaRegistro datetime default getdate()
)

Drop table PRODUCTO
Drop table CATEGORIA
CREATE TABLE CATEGORIA(
IdCategoria NOT NULL int primary key identity,
Descripcion varchar(100),
Estado bit,
FechaRegistro datetime default getdate()
)

CREATE TABLE PRODUCTO(
IdProducto  int NOT NULL primary key identity,
Codigo varchar(50),
Nombre varchar (50),
Descripcion varchar(100),
IdCategoria int references CATEGORIA(IdCategoria),
Stock int not null default 0,
PrecioVenta decimal(10,2) default 0,
Estado bit,
FechaRegistro datetime default getdate()
)

select * from VENTA
CREATE TABLE VENTA(
IdVenta int NOT NULL primary key identity,
IdUsuario int references USUARIO(IdUsuario),
TipoDocuemnto varchar (50),
NumeroDocumento varchar (50),
MontoPago decimal (10,2),
MontoCambio decimal (10,2),
MontoTotal decimal (10,2),
FechaRegistro datetime default getdate()
)

CREATE TABLE DETALLEVENTA(
IdDetalleVenta int NOT NULL primary key identity,
IdVenta int references VENTA(IdVenta),
IdProducto int references PRODUCTO(IdProducto),
PrecioVenta decimal(10,2),
Cantidad int,
Subtotal decimal (10,2),
FechaRegistro datetime default getdate()
)


DELETE USUARIO
DELETE PERMISOS
DELETE ROL
 DROP TABLE ROL
/*Insertando ROL*/

Select * from ROL
insert into ROL (Descripcion,NombreMenu)
values ('ADMINISTRADOR',1)

insert into ROL (Descripcion)
values ('EMPLEADO')

insert into ROL (Descripcion)
values ('CONTADOR')

insert into ROL (Descripcion)
values ('PASANTE')


/*Insertando usuario*/

Select * from USUARIO
insert USUARIO (Documento,NombreCompleto, Correo,Clave,IdRol,Estado)
values ('101010','ADMIN','@GMAIL.COM','123',1,1)

insert USUARIO (Documento,NombreCompleto, Correo,Clave,IdRol,Estado)
values ('JChacon','JulioCesarChaconAmavizca','@GMAIL.COM','Chacon123',1,1)

insert USUARIO (Documento,NombreCompleto, Correo,Clave,IdRol,Estado)
values ('Admin','Julio Cesar Chacon Amavizca','@GMAIL.COM','1234',15,1)

insert USUARIO (Documento,NombreCompleto, Correo,Clave,IdRol,Estado)
values ('TBernardo','Tadeo','@GMAIL.COM','1234',2,1)

insert USUARIO (Documento,NombreCompleto, Correo,Clave,IdRol,Estado)
values ('JNavia','Julian','@GMAIL.COM','1234',3,1)

insert USUARIO (Documento,NombreCompleto, Correo,Clave,IdRol,Estado)
values ('JRomero','Javier','@GMAIL.COM','1234',3,0)

Select * from ROL

Select * from PERMISOS
delete PERMISOS
/* CONFIGURAR PERMISOS*/

INSERT INTO PERMISOS (IdRol,NombreMenu) 
values (15,'MenuVentas'),
(15,'MenuInventario'),
(15,'MenuGanaderia'),
(15,'MenuContabilidad'),
(15,'MenuUsuarios'),
(15,'MenuAcercade')


INSERT INTO PERMISOS (IdRol,NombreMenu) 
values (2,'MenuVentas'),
(2,'MenuGanaderia')

INSERT INTO PERMISOS (IdRol,NombreMenu) 
values 
(3,'MenuContabilidad')

select * from USUARIO

select p.IdRol,p.NombreMenu  from PERMISOS p
inner join ROL r on r.IdRol = p.IdRol
inner join USUARIO u on u.IdRol = r.IdRol
where u.IdUsuario = 1

SELECT u.IdUsuario, u.Documento, u.NombreCompleto, u.Correo, u.Clave, u.Estado, r.IdRol,r.Descripcion FROM USUARIO u
inner join rol r on r.IdRol = u.IdRol

delete  from USUARIO where IdUsuario=6
update USUARIO set Estado = 0 where IdUsuario=2


/*Procedimientos almacenados*/


/*Registrar usuarios validos sin repetir nombres de usuarios*/
CREATE PROC SP_REGISTRARUSUARIO(
@Usuario varchar(50),
@NombreCompleto varchar(100),
@Correo varchar(100),
@Clave varchar(100),
@IdRol int,
@Estado bit,
@IdUsuarioResultado int output,
@Mensaje varchar (500) output
)
as
begin
	set @IdUsuarioResultado=0
	set @Mensaje=''
	if not exists (select * from USUARIO where Documento = @Usuario)
	begin
		insert into USUARIO(Documento, NombreCompleto, Correo, Clave, IdRol, Estado )values
		(@Usuario,@NombreCompleto,@Correo,@Clave,@IdRol,@Estado)
		set @IdUsuarioResultado= SCOPE_IDENTITY()
		
	end
	else
	set @Mensaje = 'Este nombre de usuario ya esta registrado'


end
go

/*editar usuarios validos sin repetir nombres de usuarios*/
CREATE PROC SP_EDITARUSUARIO(
@IdUsuario int,
@Usuario varchar(50),
@NombreCompleto varchar(100),
@Correo varchar(100),
@Clave varchar(100),
@IdRol int,
@Estado bit,
@Respueta bit output,
@Mensaje varchar (500) output
)
as
begin
	set @Respueta=0
	set @Mensaje=''

	if not exists (select * from USUARIO where Documento = @Usuario and IdUsuario!= @IdUsuario)
	begin
		update USUARIO set
		Documento= @Usuario, 
		NombreCompleto=@NombreCompleto , 
		Correo=@Correo , 
		Clave=@Clave , 
		IdRol=@IdRol, 
		Estado =@Estado
		where IdUsuario=@IdUsuario
		set @Respueta= 1
		
	end
	else
	set @Mensaje = 'No se puede repetir el nombre de usuario para mas de un usuario'


end


/*editar usuarios validos sin repetir nombres de usuarios*/
select * from DETALLEVENTA
CREATE PROC SP_ELIMINARUSUARIO(
@IdUsuario int,
@Respueta bit output,
@Mensaje varchar (500) output
)
as
begin
	set @Respueta=0
	set @Mensaje=''
	declare @pasoreglas bit = 1

	IF exists(Select * from VENTA v
	INNER JOIN USUARIO u on u.IdUsuario = v.IdUsuario
	where u.IdUsuario =@IdUsuario
	)
	BEGIN
	set @pasoreglas=0
	set @Respueta=0
	set @Mensaje=@Mensaje + 'No se puede eliminar porque el usuario se encuentra relacionado con una VENTA'
	END

	if(@pasoreglas=1)
	BEGIN
		delete FROM USUARIO WHERE IdUsuario= @IdUsuario
		set @Respueta=1
	END

END

/* procedimiento para guardar categoria  */

CREATE PROC SP_REGISTRARCATEGORIA(
@Descripcion varchar(50),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)as
begin
	set @Resultado=0
	if not exists (SELECT * FROM CATEGORIA WHERE Descripcion=@Descripcion)
	begin
		insert into CATEGORIA (Descripcion,Estado)values (@Descripcion,@Estado)
		set @Resultado=SCOPE_IDENTITY()
	end
	else
	set @Mensaje='No se puede repetir la descripcion de una categoria'

end
go

/* procedimiento para editar categoria  */

CREATE PROC SP_EDITARCATEGORIA(
@IdCategoria int,
@Descripcion varchar(50),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)as
begin
	set @Resultado=1
	if not exists (SELECT * FROM CATEGORIA WHERE Descripcion=@Descripcion and IdCategoria!=@IdCategoria)
		update CATEGORIA SET
		Descripcion = @Descripcion,
		Estado= @Estado
		where IdCategoria=@IdCategoria
	
	else
	begin
	set @Resultado=0
	set @Mensaje='No se puede repetir la descripcion de una categoria'
	
	end
end
go


/* procedimiento para eliminar categoria  */

CREATE PROC SP_ELIMINARCATEGORIA(
@IdCategoria int,
@Resultado int output,
@Mensaje varchar(500) output
)as
begin
	set @Resultado=1
	if not exists (SELECT * FROM CATEGORIA c
	inner join PRODUCTO p on p.IdCategoria = c.IdCategoria
	where c.IdCategoria= @IdCategoria
	)
	begin
	delete top(1) from CATEGORIA where IdCategoria = @IdCategoria
	end
	ELSE
	begin
	set @Resultado=0
	set @Mensaje='La categoria se encuentra relacionada a un producto'
	
	end
end
go

/* procedimiento para agregar productos  */
ALTER PROC SP_REGISTRARPRODUCTO(
@Codigo varchar (20),
@Nombre varchar (30),
@Descripcion varchar(50),
@IdCategoria int,
@Stock int,
@PrecioVenta decimal(10,2),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)as
begin
	set @Resultado=0
	if not exists (SELECT * FROM PRODUCTO WHERE Codigo=@Codigo)
	begin
		insert into PRODUCTO(Codigo,Nombre, Descripcion,IdCategoria,Stock,PrecioVenta,Estado)values (@Codigo,@Nombre, @Descripcion,@IdCategoria,@Stock,@PrecioVenta,@Estado)
		set @Resultado=SCOPE_IDENTITY()
	end
	else
	set @Mensaje='Ya existe un producto con el mismo codigo'

end
go


/* procedimiento para editar productos  */

ALTER PROC SP_EDITARPRODUCTO(
@IdProducto int,
@Codigo varchar (20),
@Nombre varchar (30),
@Descripcion varchar(50),
@IdCategoria int,
@Stock int,
@PrecioVenta decimal(10,2),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)as
begin
	set @Resultado=1
	if not exists (SELECT * FROM PRODUCTO WHERE Codigo=@Codigo and IdProducto!=@IdProducto)

		update PRODUCTO set
		Codigo=@Codigo,
		Nombre=@Nombre, 
		Descripcion=@Descripcion,
		IdCategoria=@IdCategoria,
		Stock=@Stock,
		PrecioVenta=@PrecioVenta,
		Estado= @Estado
		where IdProducto=@IdProducto

	else
	begin
	set @Resultado=0
	set @Mensaje='Ya existe un producto con el mismo codigo'
	end
end
go


/* procedimiento para eliminar productos  */

create PROC SP_ELIMINARPRODUCTO(
@IdProducto int,
@Respueta int output,
@Mensaje varchar(500) output
)as
begin

	set @Mensaje=''
	set @Respueta=0
	declare @pasoreglas bit=1
	if exists (SELECT * FROM DETALLEVENTA dv
	inner join PRODUCTO p on p.IdProducto = dv.IdProducto
	where p.IdProducto= @IdProducto
	)
	begin

	set @pasoreglas=0
	set @Respueta=0
	set @Mensaje=@Mensaje+'No se puede eliminar porque se encuentra relacionado a una VENTA'

	end
	if(@pasoreglas=1)
	begin
	delete from PRODUCTO where IdProducto=@IdProducto
	set @Respueta=1
	end
end
go







Exec SP_REGISTRARUSUARIO 'KGongora','Karla','k@hotmail.com','123',2,1, @idusuariogenerado output,@mensaje output


DECLARE @respuesta int
declare @mensaje varchar(500)

Exec SP_EDITARUSUARIO 1,'101010','Karla','k@hotmail.com','123',2,1, @respuesta output,@mensaje output

Select @respuesta
select @mensaje



Select * from USUARIO

UPDATE PRODUCTO SET ESTADO =1

Select IdCategoria,Descripcion, Estado from CATEGORIA


insert INTO CATEGORIA (Descripcion,Estado) values ('Quesos',1)
insert INTO CATEGORIA (Descripcion,Estado) values ('Enlatados',1)
insert INTO CATEGORIA (Descripcion,Estado) values ('Bebidas',1)



SELECT IdProducto,Codigo,Nombre, p.Descripcion,c.IdCategoria,c.Descripcion[DescripcionCategoria],Stock,PrecioVenta, p.Estado from PRODUCTO p
inner join CATEGORIA c on c.IdCategoria= p.IdCategoria



insert into PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Estado) values('101010','Queso Rojo','KG',1,1)

select * from PRODUCTO



/*FORMATO PARA LOS DOCUMENTOS DE VENTA*/


CREATE TABLE NEGOCIO(
IdNegocio int NOT NULL primary key,
Nombre varchar (60),
RUC varchar(60),
Direccion varchar(60),
Logo varbinary(MAX) NULL
)

INSERT INTO NEGOCIO (IdNegocio,Nombre, RUC,Direccion) VALUES (1,'CodigoEstudiante','101010','Guadalupe de Ures')

SELECT IdNegocio,Nombre, RUC, Direccion, Logo FROM NEGOCIO where IdNegocio=1
select IdNegocio,Nombre,RUC,Direccion from NEGOCIO WHERE IdNegocio=1
SELECT Logo FROM NEGOCIO where IdNegocio=1



/*Agrega esto para que puedas ver como funciona el data grid de ventas*/
select * from CATEGORIA
insert into PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria,Stock,PrecioVenta, Estado) values('25554','Soda pet','LT',3,35,25.5,1)

Select * from VENTA
Select * from DETALLEVENTA


/* DETALLES DE LA VENTA */

Create TYPE [dbo].[EDetalle_Ventas] AS TABLE (
[IdProducto] int null,
[PrecioVenta] decimal (18,2),
[Cantidad] int null,
[SubTotal] decimal(18,2)
)
GO

create procedure usp_RegistrarVenta(
@IdUsuario int,
@TipoDocumento varchar(500),
@NumeroDocumento varchar(500),
@MontoPago decimal(18,2),
@MontoCambio decimal(18,2),
@MontoTotal decimal(18,2),
@DetalleVenta [EDetalle_Ventas] READONLY,                                      
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
	
	begin try

		declare @idventa int = 0
		set @Resultado = 1
		set @Mensaje = ''

		begin  transaction registro

		insert into VENTA(IdUsuario,TipoDocuemnto,NumeroDocumento,MontoPago,MontoCambio,MontoTotal)
		values(@IdUsuario,@TipoDocumento,@NumeroDocumento,@MontoPago,@MontoCambio,@MontoTotal)

		set @idventa = SCOPE_IDENTITY()

		insert into DETALLEVENTA(IdVenta,IdProducto,PrecioVenta,Cantidad,SubTotal)
		select @idventa,IdProducto,PrecioVenta,Cantidad,SubTotal from @DetalleVenta

		commit transaction registro

	end try
	begin catch
		set @Resultado = 0
		set @Mensaje = ERROR_MESSAGE()
		rollback transaction registro
	end catch

end

go

Select count(*)+1 from VENTA
select * from PRODUCTO
update PRODUCTO set Stock=Stock-@cantidad where IdProducto=@idproducto

Select* from VENTA

select p.Nombre,dv.PrecioVenta,dv.Cantidad,dv.SubTotal from DETALLEVENTA dv
                   inner join PRODUCTO p on p.IdProducto = dv.IdProducto
                     where dv.IdVenta = 00001

					 
select v.IdVenta,u.NombreCompleto,
v.TipoDocuemnto,v.NumeroDocumento,
v.MontoPago,v.MontoCambio,v.MontoTotal,
convert(char(10),v.FechaRegistro,103)[FechaRegistro]
from VENTA v
inner join USUARIO u on u.IdUsuario = v.IdUsuario
where v.NumeroDocumento = 00001

/* SISTEMA DE GANADERIA 
METODOS: 
BUSCAR
ELIMINAR
LISTAR
REGISTRAR

HISTORIAL
*/



/* PROPUESTA TABLA DE GANADERIA

CREATE TABLE ROL(
IdRol int primary key identity,
Descripcion VARCHAR (50),
NombreMenu VARCHAR (50),
FechaRegistro datetime default getdate()
)

Tabla Ziniga
Tabla doctores
Tabla tecnicos




CREATE TABLE BOVINOS(
Id_animal VARCHAR (20)

)

CREATE TABLE HISTORIAL(
Id_historial INT,
N_Placa INT,
Color_Placa VARCHAR (20),
Fecha_Nacimiento datetime default getdate(),
Raza VARCHAR(30),
Grupo VARCHAR(30),
Padre VARCHAR (50),
Madre VARCHAR (50),
#Partos VARCHAR()

CREATE TABLE ZINIGA(
NombreZiniga Varchar (50) primary key,
DireccionZiniga Varchar (50),
NumeroZiniga int,
CorreoZiniga Varchar(50)
)

)
*/

Select IdCategoria,Descripcion, Estado from CATEGORIA
insert INTO UPP(IdUPP,NombreProductor,UbicacionRancho) values (1234,'GGG','RANCENCIO')
Select IdUPP,NombreProductor, UbicacionRancho from UPP
CREATE TABLE UPP(
	IdUPP INT PRIMARY KEY,
	NombreProductor VARCHAR (50),
	UbicacionRancho VARCHAR (100)
)
drop table GANADO
drop table VENTAS
drop table MUERTES
drop table PARTOS
drop table MOVIMIENTOS

insert INTO CATEGORIA (Descripcion,Estado) values ('Quesos',1)
insert into GANADO (IdGanado,Apodo,Sexo,
Peso,Proposito,FechaNacimiento,TipoRegistro,UPP)VALUES 
(45645,'LOQUITA','MACHO',1234.00,'DOBLE PROPOSITO','2022-05-30T05:57:19','Modular',1234
)

CREATE TABLE GANADO(
	IdGanado int NOT NULL primary key,
	Apodo varchar(50),
	Sexo varchar(6),
	Peso decimal (7,3),
	Proposito varchar(50),
	FechaNacimiento date,
	FechaAretado datetime default getdate(),
	TipoRegistro varchar(50),
	UPP int references UPP(IdUPP)
)
select FechaVacunacion,VacunadoPor from VACUNACION
CREATE TABLE VACUNACION(
	FechaVacunacion datetime default getdate(),
	VacunadoPor varchar(50)
)
select * from GANADO
INSERT INTO PARTOS (IdGanado,Sexo,Estado) VALUES (12364,'Macho',1)
select u.IdUPP,g.IdGanado,v.FechaVenta,v.PrecioVenta,v.PrecioSubasta from ventas v
inner join GANADO g on g.IdGanado=v.IdGanado
inner join UPP u on u.IdUPP=v.IdUPP

select g.IdGanado,p.FechaParto,p.Sexo,p.Estado from PARTOS p
inner join GANADO g on g.IdGanado = p.IdGanado

CREATE TABLE PARTOS(
	IdGanado int  references GANADO(IdGanado),
	FechaParto datetime default getdate(),
	Sexo varchar(6),
	Estado int
)

CREATE TABLE MOVIMIENTOS(
	IdMovimiento int NOT NULL identity,
	FechaMovimiento datetime default getdate(),
	TipoMovimiento varchar(50),
	IdGanado int references GANADO(IdGanado)
)
select * from USUARIO
select * from upp
select * from ventas
insert into VENTAS(IdUPP,IdGanado,PrecioVenta,PrecioSubasta) values (1234,12364,1500.00,1500.00)
drop table VENTAS

CREATE TABLE VENTAS(
IdUPP int references UPP(IdUPP),
IdGanado int references GANADO (IdGanado),
FechaVenta datetime default getdate(),
PrecioVenta decimal	(10,2),
PrecioSubasta decimal (10,2)
)


select u.IdUPP,g.IdGanado,v.FechaVenta,v.PrecioVenta,v.PrecioSubasta from ventas v
inner join GANADO g on g.IdGanado=v.IdGanado
inner join UPP u on u.IdUPP=v.IdUPP


CREATE TABLE MUERTES(
IdUPP int NOT NULL references UPP (IdUPP),
IdGanado int references GANADO (IdGanado),
FechaMuerte datetime default getdate(),
DescripcionMuerte VARCHAR (255)
)

INSERT INTO UPP (IdUPP,NombreProductor,UbicacionRancho) VALUES (123456789,'Jose Fernando', 'Guadalupe de ures')
select * from UPP
/* PROCEDIMIENTO PARA REGISTROS VALIDADOS GANADERIA*/
EXEC SP_INGRESOGANADO 12345678,'calita', 'Macho', '25.12', 'Doble proposito','28/1/2013','28/1/2013',123456789

CREATE PROC SP_INGRESOGANADO(
	@IdGanado int,
	@Apodo varchar(50),
	@Sexo varchar(6),
	@Peso decimal(7,3),
	@Proposito varchar(50),
	@FechaNacimiento varchar(10),
	@FechaAretado Varchar(10),
	@UPP int
)
AS
BEGIN
	IF exists (SELECT * FROM UPP WHERE IdUPP = @UPP)
		BEGIN try
			BEGIN transaction ingresarGanado
				INSERT INTO GANADO(IdGanado,Apodo,Sexo,Peso,Proposito,FechaNacimiento,FechaAretado,TipoRegistro,UPP)
				VALUES(@IdGanado,@Apodo,@Sexo,@Peso,@Proposito,@FechaNacimiento,@FechaAretado,'Ingreso',@UPP)

				INSERT INTO MOVIMIENTOS(FechaMovimiento,TipoMovimiento,IdGanado)
				VALUES(getdate(),'Ingreso',@IdGanado)

				COMMIT transaction ingresarGanado
		END try
		BEGIN catch
			rollback transaction ingresarGanado
		END catch		
		
END

CREATE PROC SP_INGRESOGANADO(
	@IdGanado int,
	@Apodo varchar(50),
	@Sexo varchar(6),
	@Peso decimal(7,3),
	@Proposito varchar(50),
	@FechaNacimiento varchar(8),
	@FechaAretado varchar(8),
	@UPP int
)
AS
	DECLARE @FechaNacimientoDate DATE = @FechaNacimiento
	DECLARE @FechaAretadoDatetime DATETIME = @FechaAretado
	DECLARE @FechaMovimiento DATETIME = getdate()
	DECLARE @fallo1 VARCHAR(50) = 'fallo el ingreso de ganado'
	DECLARE @fallo2 VARCHAR(50) = 'fallo el ingreso de movimiento'

	IF exists (SELECT * FROM UPP WHERE IdUPP = @UPP)
		BEGIN TRANSACTION ingresarGanado
			BEGIN try
				INSERT INTO GANADO(IdGanado,Apodo,Sexo,Peso,Proposito,FechaNacimiento,FechaAretado,TipoRegistro,UPP)
				VALUES(@IdGanado,@Apodo,@Sexo,@Peso,@Proposito,@FechaNacimientoDate,@FechaAretadoDatetime,'Ingreso',@UPP)

				COMMIT TRANSACTION ingresarGanado
			END try
			BEGIN catch
				ROLLBACK TRANSACTION ingresarGanado
				SELECT @fallo1
			END catch

		BEGIN TRANSACTION ingresarMovimiento
			BEGIN try
				INSERT INTO MOVIMIENTOS(FechaMovimiento,TipoMovimiento,IdGanado)
				VALUES(@FechaMovimiento,'Ingreso',@IdGanado)

				COMMIT TRANSACTION ingresarMovimiento
			END try
			BEGIN catch
				ROLLBACK TRANSACTION ingresarMovimiento
				SELECT @fallo2
			END catch	
GO


CREATE PROC SP_MUERTEGANADO(
	@IdGanado int,
	@IdUPP int,
	@FechaMuerte varchar(8),
	@DescripcionMuerte varchar(255)
)
AS
BEGIN
	DECLARE @FechaMuerteDatetime DATETIME = @FechaMuerte
	DECLARE @FechaMovimiento DATETIME = getdate()

	IF exists (SELECT * FROM GANADO WHERE IdGanado = @IdGanado)
		BEGIN TRANSACTION muerteGanado
			BEGIN try
				DELETE FROM GANADO WHERE IdGanado = @IdGanado

				INSERT INTO MOVIMIENTOS(FechaMovimiento,TipoMovimiento,IdGanado)
				VALUES(@FechaMovimiento,'Muerte',@IdGanado)

				INSERT INTO MUERTES(IdUPP,IdGanado,FechaMuerte,DescripcionMuerte)
				VALUES(@IdUPP,@IdGanado,@FechaMuerte,@DescripcionMuerte)

				COMMIT TRANSACTION muerteGanado
			END try
			BEGIN catch
				ROLLBACK TRANSACTION muerteGanado
			END catch
END
GO 

CREATE PROC SP_VENTAGANADO(
	@IdUPP int,
	@IdGanado int,
	@PrecioVenta decimal(10,2),
	@PrecioSubasta decimal(10,2)
)
AS
BEGIN
	DECLARE @FechaMovimiento DATETIME = getdate()

	IF exists (SELECT * FROM UPP WHERE IdUPP = @IdUPP)
		IF exists(SELECT * FROM GANADO WHERE IdGanado = @IdGanado)
				BEGIN transaction ventaGanado
					BEGIN try
						INSERT INTO VENTAS(IdUPP,IdGanado,FechaVenta,PrecioVenta,PrecioSubasta)
						VALUES(@IdUPP,@IdGanado,getdate(),@PrecioVenta,@PrecioSubasta)

						INSERT INTO MOVIMIENTOS(FechaMovimiento,TipoMovimiento,IdGanado)
						VALUES(@FechaMovimiento,'Venta',@IdGanado)

						DELETE FROM GANADO WHERE IdGanado = @IdGanado

						COMMIT transaction ventaGanado
					END try
					BEGIN catch
						ROLLBACK transaction ventaGanado
				END catch
END
GO


CREATE PROC SP_AGREGARUPP(
	@IdUPP int,
	@NombreProductor varchar(50),
	@UbicacionRancho varchar(100)
)
AS
BEGIN
	BEGIN transaction agregarUPP
		BEGIN try
			INSERT INTRO UPP(IdUPP,NombreProductor,UbicacionRancho)
			VALUES(@IdUPP,@NombreProductor,@UbicacionRancho)

			COMMIT transaction agregarUPP
		END try
		BEGIN catch
			ROLLBACK transaction agregarUPP
		END catch
END


CREATE TABLE COMPRAS(
	IdUPP int references UPP(IdUPP),
	IdGanado int,
	FechaCompra datetime default getdate(),
	PrecioCompra decimal	(10,2),
)


CREATE PROC SP_COMPRAGANADO(
	@IdUPP INT,
	@PrecioCompra decimal(10,2),
	@IdGanado INT,
	@Apodo varchar(50),
	@Sexo varchar(6),
	@Peso decimal(7,3),
	@Proposito varchar(50),
	@FechaNacimiento varchar(10),
	@FechaAretado varchar(10)
)
AS
BEGIN
	DECLARE @FechaNacimientoDate DATE = @FechaNacimiento
	DECLARE @FechaAretadoDatetime DATETIME = @FechaAretado
	DECLARE @FechaMovimiento DATETIME = getdate()

	BEGIN TRANSACTION compraGanado
		BEGIN TRY
			INSERT INTO GANADO(IdGanado,Apodo,Sexo,Peso,Proposito,FechaNacimiento,FechaAretado,TipoRegistro,UPP)
			VALUES(@IdGanado,@Apodo,@Sexo,@Peso,@Proposito,@FechaNacimientoDate,@FechaAretadoDatetime,'Compra',@IdUPP)

			INSERT INTO COMPRAS(IdUPP,IdGanado,FechaCompra,PrecioCompra)
			VALUES(@IdUPP,@IdGanado,@FechaMovimiento,@PrecioCompra)

			INSERT INTO MOVIMIENTOS(FechaMovimiento,TipoMovimiento,IdGanado)
			VALUES(@FechaMovimiento,'Compra',@IdGanado)

			COMMIT TRANSACTION compraGanado
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION compraGanado
		END CATCH
END
GO


CREATE PROC SP_AGREGARPARTO(
	@IdGanado INT,
	@FechaParto VARCHAR(10),
	@Sexo VARCHAR(6),
)
AS
BEGIN
	DECLARE @FechaPartoDatetime DATETIME = @FechaParto

	IF EXISTS (SELECT * FROM GANADO WHERE IdGanado = @IdGanado)
		BEGIN TRANSACTION agregarParto
			BEGIN TRY
				INSERT INTO PARTOS(IdGanado,FechaParto,Sexo,Estado)
				VALUES(@IdGanado,@FechaPartoDatetime,@Sexo,1)

				COMMIT TRANSACTION agregarParto
			END TRY
			BEGIN CATCH
				ROLLBACK TRANSACTION agregarParto
			END CATCH
END
GO


CREATE PROC SP_AGREGARVACUNACION(
	@VacunadoPor VARCHAR(50),
	@FechaVacunacion VARCHAR(10),
	@IdUPP int
)
AS
BEGIN
	DECLARE @FechaVacunacionDatetime DATETIME = @FechaVacunacion

	IF exists (SELECT * FROM UPP WHERE IdUPP = @IdUPP)
		BEGIN TRANSACTION agregarVacunacion
			BEGIN TRY
				INSERT INTO VACUNACION(FechaVacunacion,VacunadoPor,IdUPP)
				VALUES(@FechaVacunacionDatetime,@VacunadoPor,@IdUPP)

				COMMIT TRANSACTION agregarVacunacion
			END TRY
			BEGIN CATCH
				ROLLBACK TRANSACTION agregarVacunacion
			END CATCH
END
GO


/*PROCEDIMIENTO PARA BUSCAR DETALLE DE VENTAS */ 

MontoPago decimal (10,2),
MontoCambio decimal (10,2),
MontoTotal decimal (10,2),
FechaRegistro datetime default getdate()

select r.NumeroDocumento,p.PrecioVenta,
p.Cantidad, Subtotal,MontoTotal, MontoCambio, MontoPago,u.NombreCompleto, 
r.FechaRegistro
from DETALLEVENTA p
inner join VENTA r on r.IdVenta = p.IdDetalleVenta
inner join USUARIO u on u.IdUsuario= r.IdUsuario
where r.NumeroDocumento=00008


Select IdVenta,TipoDocuemnto,NumeroDocumento,MontoPago,
MontoCambio, MontoTotal, u.NombreCompleto,v.FechaRegistro from VENTA v
inner join USUARIO u on u.IdUsuario= v.IdUsuario

select * from VENTA


SELECT u.IdUsuario, u.Documento, u.NombreCompleto, u.Correo, u.Clave, u.Estado, r.IdRol,r.Descripcion FROM USUARIO u
inner join rol r on r.IdRol = u.IdRol