CREATE DATABASE IF NOT EXISTS hashpetsharp;
USE hashpetsharp; 

CREATE TABLE IF NOT EXISTS Administrativo(
cpf varchar (11) PRIMARY KEY NOT NULL,
nome varchar (255)  NOT NULL,
idade varchar (2)  NOT NULL,
rua varchar (50)  NOT NULL,
numero varchar (5)  NOT NULL,
cep varchar (8)  NOT NULL,
cidade varchar (50)  NOT NULL,
UF varchar (2)  NOT NULL
);

CREATE TABLE IF NOT EXISTS Veterinario (
crmv varchar (11) PRIMARY KEY NOT NULL,
nome varchar (50)  NOT NULL,
rua varchar (50)  NOT NULL,
numero varchar (5)  NOT NULL,
cep varchar (8)  NOT NULL,
cidade varchar (50)  NOT NULL,
UF varchar (2)  NOT NULL
);

CREATE TABLE IF NOT EXISTS Usuario (
usuario varchar (11) primary key NOT NULL,
nome_usuario varchar (50) NOT NULL,
senha varchar (6) NOT NULL

);

CREATE TABLE IF NOT EXISTS Exame(
codigo varchar (4) PRIMARY KEY NOT NULL,
nome varchar (20)  NOT NULL,
preco varchar (10) NOT NULL
);

CREATE TABLE IF NOT EXISTS Remedio(
codigo varchar (4) PRIMARY KEY NOT NULL,
nome varchar (20)  NOT NULL,
preco varchar (10) NOT NULL
);

CREATE TABLE IF NOT EXISTS Vacina(
codigo varchar (4) PRIMARY KEY NOT NULL,
nome varchar (20)  NOT NULL,
preco varchar (10) NOT NULL
);

CREATE TABLE IF NOT EXISTS agendamento(
data_consulta varchar (10) NOT NULL,
hora_consulta varchar (5) NOT NULL,
agendamento_codigopet varchar (10) NOT NULL,
agendamento_nomepet varchar (15) NOT NULL,
agendamento_vetcrmv varchar (5) NOT NULL,
agendamento_nomevet varchar (50) NOT NULL,
PRIMARY KEY (data_consulta, hora_consulta, agendamento_vetcrmv),
CONSTRAINT fk_agendamento_paciente FOREIGN KEY (agendamento_codigopet) REFERENCES hashpetsharp.paciente (codigopet),
CONSTRAINT fk_agendamento_Veterinario FOREIGN KEY (agendamento_vetcrmv) REFERENCES hashpetsharp.Veterinario (crmv)
);
CREATE TABLE IF NOT EXISTS Consulta(
consulta_data varchar (10) NOT NULL,
consulta_hora varchar (5) NOT NULL,
consulta_vetcrmv varchar (5) NOT NULL,
consulta_nomevet varchar (50) NOT NULL,
consulta_codigopet varchar (10) NOT NULL,
consulta_nomepet varchar (50) NOT NULL,
consulta_peso varchar (10) NOT NULL,
consulta_idade varchar (4),
consulta_obs varchar (500),
consulta_vacina varchar (100),
consulta_remedio varchar (100),
consulta_exame varchar (100),
 primary key (consulta_data, consulta_hora, consulta_vetcrmv),
CONSTRAINT fk_consulta_veterinario FOREIGN KEY (consulta_vetcrmv) REFERENCES hashpetsharp.veterinario (crmv),
CONSTRAINT fk_consulta_paciente FOREIGN KEY (consulta_codigopet) REFERENCES hashpetsharp.paciente (codigopet),
CONSTRAINT fk_consulta_agendamento FOREIGN KEY (consulta_data) REFERENCES hashpetsharp.agendamento (data_consulta),
CONSTRAINT fk_consulta_agendamento FOREIGN KEY (consulta_hora) REFERENCES hashpetsharp.agendamento (hora_consulta)

);

CREATE TABLE IF NOT EXISTS Paciente(
codigopet varchar (10) PRIMARY KEY NOT NULL,
dono_cpf varchar (11) NOT NULL,
nomepet varchar (15) NOT NULL,
raca varchar (10)  NOT NULL,
idade varchar (2)  NOT NULL,
peso varchar (8)  NOT NULL,
sexo varchar (1)  NOT NULL,
CONSTRAINT fk_paciente_dono FOREIGN KEY (dono_cpf) REFERENCES hashpetsharp.dono (cpf)
);

CREATE TABLE IF NOT EXISTS Dono(
cpf varchar (11) PRIMARY KEY NOT NULL,
paciente_codigopet varchar (10) NOT NULL,
nomedono varchar (255)  NOT NULL,
rua varchar (50)  NOT NULL,
numero varchar (5)  NOT NULL,
cep varchar (8)  NOT NULL,
cidade varchar (50)  NOT NULL,
UF varchar (2)  NOT NULL,
email varchar (255)  NOT NULL,
telefone varchar (11)  NOT NULL,
CONSTRAINT fk_dono_paciente FOREIGN KEY (paciente_codigopet) REFERENCES hashpetsharp.paciente (codigopet)
);

DESCRIBE Administrativo;
DESCRIBE Veterinario;
DESCRIBE Usuario;
DESCRIBE Exame;
DESCRIBE Remedio;
DESCRIBE Vacina;
DESCRIBE Consulta;
DESCRIBE Paciente;
DESCRIBE Dono;

