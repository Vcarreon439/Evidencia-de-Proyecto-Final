/*Create Database LibreriaBD*/
/*Go*/
Use LibreriaBD
	
	/*Tema - Lista*/
	Create Table Tema(
		Codigo varchar(5) Primary Key Not Null,
		Nombre varchar(50) Not Null
	);

	/*Autor - Listo y pendiente a renovar foto*/
	Create Table Autor(
		Codigo varchar(20) Primary Key Not Null,
		nombres varchar(50) NULL,
		apellidos varchar(50) NULL,
		paisNac varchar(50) NULL,
		ciudadNac varchar(50) NULL,
		comentarios text NULL,
		foto varchar(50) NULL
	);

	/*Editorial - Listo*/
	Create Table Editorial(
		Codigo varchar(5) Primary Key Not Null,
		Nombre varchar(50) Not Null,
		Telefono varchar(10) Not Null,
		Correo varchar(50) Not Null,
		Direccion text Not Null
	);


	/*Libro - Listo*/
	Create Table Libro(
		Codigo int Primary Key Identity,
		ISBN varchar(15) Null,
		Titulo varchar(50) Not Null,
		codEditorial varchar(5) Not Null,
		aEdicion varchar(4) Null,
		lEdicion Varchar(50) Null,
		numEdicion smallint Null,
		Copias int Not Null,
		Disponibilidad bit,
		Circulacion int Not Null,
		Foreign Key (codEditorial) references Editorial(Codigo)
	);

	/*AutoresLibro - Listo*/
	Create Table AutoresLibro(
		codLibro int,
		codAutor varchar(20),
		Foreign Key (codAutor) References Autor(Codigo),
		Foreign Key (codLibro) References Libro(Codigo)
	);
	
	/*temaLibro - Listo*/
	Create Table temaLibro(
		codLibro int,
		codTema varchar(5),
		Foreign Key (codLibro) references Libro(Codigo),
		Foreign Key (codTema) references Tema(Codigo)
	);

	/*Usuarios - Listo*/
	Create Table Usuarios(
		Codigo int Identity Not Null,
		CURP varchar(18) Primary Key Not Null,
		Nombre varchar(50) Not Null,
		Apellidos varchar(50) Not Null,
		EntidadFederativa varchar(50) Not Null,
		Genero varchar(9) Not Null,
		Domicilio text Null,
		situacion varchar(20) Null,
		FechaNac SmallDateTime Not Null
	);

	/*Prestamos - Lista*/
	Create Table Prestamos(
		NumeroPedido int Identity,
		Codigo varchar(20) Primary Key Not Null,
		codUsuario varchar(18) Not Null,
		FechaSalida SmallDateTime Not Null,
		FechaMaxima SmallDateTime Not Null,
		FechaDev SmallDateTime Not Null,
		estadoPrestamo bit,
		Foreign Key (codUsuario) References Usuarios(CURP),
	);

	/*librosPrestamos - Listo*/
	Create Table librosPrestamo(
		Codigo int identity Primary Key,
		codLibro int,
		codPrestamo varchar(20),
		Foreign Key (codLibro) references Libro(Codigo),
		Foreign Key (codPrestamo) references Prestamos(Codigo)
	);

	/*Managers - Listo*/
	Create Table Managers(
		Id int Primary Key Identity Not Null,
		Nombre Varchar(50) Not Null,
		Contraseña Varchar(50) Not Null,
		Rol Varchar(20) Not Null
	);
