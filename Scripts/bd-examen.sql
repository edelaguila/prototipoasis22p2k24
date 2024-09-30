create database if not exists LabClinico;
Use LabClinico;

# Tabla de Referencias
create table if not exists tbl_referencias(
	pk_idReferencia	int not null,
    Descripcion		varchar(50)
);

# Tabla de Pacientes
create table if not exists tbl_paciente(
	pk_idPaciente	int not null,
    nombrePaci		varchar(50),
    apellidoPaci	varchar(50),
    FechaNacimiento	date,
    Genero			int,
    direccionPAci	varchar(30),
    Telefono		int,
    estadoPaci		int,
    fk_idReferencia	int not null # FK hacia tbl_referencias
);

# Tabla de Encabezado de Factura
Create table if not exists tbl_encabezadofactura(
	pk_idEncabezado	int not null,
    serieFactura	varchar(30),
    numFactura		int,
    fk_idPaciente	int, # FK hacia tbl_paciente
    fechaOrden		datetime,
    total			double,
    fk_idTipoPago	int # FK hacia tbl_pago
);

# Tabla de Pago
create table if not exists tbl_pago(
	pk_idPago		int not null,
    tipoPago		varchar(50)
);

# Tabla de Detalle de Factura
create table if not exists tbl_detallefactura(
	pk_idDetallefac	int not null,
    fk_idEncabezado	int, # FK hacia tbl_encabezadofactura
    fk_idExamen		int, # FK hacia tbl_examen
    subtotal		double
);

# Tabla de Exámenes
create table if not exists tbl_examen(
	pk_idExamen		int not null,
    fk_codtipoExam	int, # FK hacia tbl_tipoexamen
    nombreExam		varchar(30),
    precio			double
);

# Tabla de Tipo de Exámenes
create table if not exists tbl_tipoexamen(
	pk_codtipoExam	int,
    nom_tipExam		varchar(35),
    descripcion		varchar(35)
);

#-----Llaves Primarias-----------------
alter table tbl_paciente add primary key (pk_idPaciente);
alter table tbl_referencias add primary key (pk_idReferencia);
alter table tbl_encabezadofactura add primary key(pk_idEncabezado);
alter table tbl_detallefactura add primary key(pk_idDetallefac);
alter table tbl_examen add primary key (pk_idExamen);
alter table tbl_pago add primary key (pk_idPago);
alter table tbl_tipoexamen add primary key (pk_codtipoExam);

#-----Llaves Foráneas--------------
alter table tbl_paciente add constraint fk_paci_ref foreign key(fk_idReferencia) references tbl_referencias (pk_idReferencia);
alter table tbl_encabezadofactura add constraint fk_enf_paci foreign key (fk_idPaciente) references tbl_paciente (pk_idPaciente);
alter table tbl_encabezadofactura add constraint fk_enf_tpag foreign key (fk_idTipoPago) references tbl_pago (pk_idPago);
alter table tbl_detallefactura add constraint fk_dfac_efac foreign key (fk_idEncabezado) references tbl_encabezadofactura (pk_idEncabezado);
alter table tbl_detallefactura add constraint fk_dfac_exam foreign key (fk_idExamen) references tbl_examen (pk_idExamen);
alter table tbl_examen add constraint fk_exam_texam foreign key(fk_codtipoExam) references tbl_tipoexamen(pk_codtipoExam);
