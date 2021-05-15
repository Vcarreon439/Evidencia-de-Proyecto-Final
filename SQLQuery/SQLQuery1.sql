Create Table Autor(
		Codigo varchar(20) Primary Key Not Null,
		nombres varchar(50),
		apellidos varchar(50),
		paisNac varchar(50),
		ciudadNac varchar(50),
		comentarios text,
		foto varchar(50)
	);

	Create Table Editorial(
		Codigo varchar(5) Primary Key Not Null,
		Nombre varchar(50) Not Null,
		Telefono varchar(10),
		Contacto varchar(30),
		Direccion text
	);

	Create Table Tema(
		Codigo varchar(10) Primary Key Not Null,
		Nombre varchar(35) Not Null
	);

	Create Table Libro(
		Codigo int Primary Key Identity,
		ISBN varchar(15),
		Titulo varchar(50),
		codEditorial varchar(5),
		aEdicion varchar(5),
		lEdicion Varchar(20),
		numEdicion int,
		Foreign Key (codEditorial) references Editorial(Codigo)
	);

	Create Table AutoresLibro(
		idAutorLibro int Primary Key Identity,
		codLibro int,
		codAutor varchar(20),
		Foreign Key (codAutor) References Autor(Codigo),
		Foreign Key (codLibro) References Libro(Codigo)
	);
	

	Create Table temaLibro(
		codLibro int,
		codTema varchar(10),
		Foreign Key (codLibro) references Libro(Codigo),
		Foreign Key (codTema) references Tema(Codigo)
	);

	Create Table Usuarios(
		Codigo int Identity,
		CURP varchar(18) Primary Key Not Null,
		Nombre varchar(50) Not Null,
		Apellidos varchar(50) Not Null,
		Domicilio text,
		FechaNac SmallDateTime
	);

	Create Table Prestamos(
		NumeroPedido int Identity,
		Codigo varchar(20) Primary Key,
		codLibro int,
		codUsuario varchar(18),
		FechaSalida SmallDateTime,
		FechaMaxima SmallDateTime,
		FechaDev SmallDateTime,
		Foreign Key (codLibro) References Libro(Codigo),
		Foreign Key (codUsuario) References Usuarios(CURP)
	);