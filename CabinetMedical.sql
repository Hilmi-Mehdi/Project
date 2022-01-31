Create Database CabinetMedical
go
use CabinetMedical
go

create table Patient(
	Num_pat int primary key Identity,
	Nom_pat varchar(40),
	Pre_pat varchar(40),
	Date_n_pat Date,
	Sex_pat char,
	Num_tel varchar(10),
	Addrs_pat varchar(50),
	Code_apci int
)

insert into Patient values 
('Hilmi','Mehdi','6/30/2000','H','0631417887','Quartier Inara Marrakech',1231),
('Hammoucha','Mohamed','3/20/2001','H','0631453287','Abwab Marrakech Marrakech',2131)

create table RDV(
	Num_rdv int primary key Identity,
	Date_rdv Date,
	Heur_rdv Time,
	Val_rdv varchar(40),
	Num_pat int references Patient(Num_pat)
)

insert into RDV values
('1/31/2022','10:30','Consultation',1),
('1/29/2022','9:30','Consultation',2)

create table Assurance(
	Num_mat_pat int primary key,
	Type_cans varchar(30),
	Date_val Date,
	Num_pat int references Patient(Num_pat)
)

insert into Assurance values
(13213,'Type Assurance 1', '1/31/2022',2)

create table Ordonnonce(
	Num_ordon int primary key Identity,
	Date_ordon Date,
	Nom_medc varchar(40),
	Form_medc varchar(40)
)

insert into Ordonnonce values
('1/31/2022','Claradol','3 fois par jour')

create table Consultation(
	Num_cons int primary key Identity,
	Date_cons Date,
	Diag_cons varchar(50),
	Num_ordon int references Ordonnonce(Num_ordon)
)

insert into Consultation values
('1/31/2022','Diagnostic',1)

create table Certificat (
	Num_cert int primary key identity,
	Date_cert Date,
	Titre_cert varchar(20),
	Com_cert varchar(40),
	Num_cons int references Consultation(Num_cons)
)

insert into Certificat values
('1/31/2022','Certificat Medical','',1)

create table APCI (
	Num_apci int primary key Identity,
	Nom_doct varchar(40),
	Spc_doct varchar(40),
	Tel_cab varchar(10),
	Desc_apci varchar(30),
	Code_apci int,
	Num_mat int,
	Num_cons int references Consultation(Num_cons)
)

insert into APCI values
('DR.MAAZOUZ','cardiologue','0524728392','APCI Description',1231,1312,1)

select * from APCI
select * from Consultation
select * from Ordonnonce
select * from Patient
select * from Certificat
select * from Assurance
select * from RDV

go
use master
go 
Drop database CabinetMedical