Create table TblEmpleado(
IdEmpleado int IDENTITY(1,1) not null,
Nombres Varchar(100) not null,
Identificacion int not null,
FechaNacimiento datetime,
genero char(1),
PRIMARY KEY (IdEmpleado),
) ;


Create table TblCargo(
IdCargo int IDENTITY(1,1) not null,
Cargo Varchar(50) not null,
Salario numeric(18,2) default(0),
IdEmpleado int FOREIGN KEY REFERENCES TblEmpleado(IdEmpleado)
);

Create table TblTienda(
IdTienda int IDENTITY(1,1) not null,
NombreTienda varchar(50) not null,
Direccion varchar(100) null,
Telefono int default(0)
)


Create table TblEmpleadoTblTienda(
IdTienda int not null,
IdEmpleado int not null,
Fecha datetime null,
primary key(IdEmpleado,IdTienda)
)