use ConsultorioMedico

CREATE TABLE tbFuncionario(
idFuncionario int primary key not null,
Nome varchar(20) not null,
Cpf int not null,
cargo varchar(20) not null,
Telefone int not null,
Endereco varchar(100) not null,
turno varchar(15) not null	
)

CREATE TABLE tbPlanoMedico(
idPlano int primary key not null,
Titular varchar(20) not null,
Empresa varchar(15) not null
)

CREATE TABLE tbConsulta(
idConsulta int primary key not null,
idPaciente int not null,
Agenda varchar(5),
TipoConsulta varchar(20)
)

create table tbEspecialidades(

idEspecialidade int primary key not null,
NomeEspecialidade varchar(20) not null,
Atividade varchar(6) not null
)

INSERT INTO tbEspecialidades VALUES(1,'PEDIATRA','ATIVO')

INSERT INTO tbConsulta VALUES (1,2,'Sim','Podólogo')



INSERT INTO tbFuncionario VALUES(1,'jose',1236549,'Analista',213456789,'Rua Pera','matutino')

INSERT INTO tbPlanoMedico VALUES(1,'Henrique','Notredame')
INSERT INTO tbPlanoMedico VALUES(2,'Jose','Intermedica')

SELECT * FROM tbEspecialidades

drop table tbPlanoMedico




