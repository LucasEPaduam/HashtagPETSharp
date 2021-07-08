CREATE DATABASE IF NOT EXISTS hashpetsharp;
SHOW DATABASES; 
USE hashpetsharp;
CREATE TABLE IF NOT EXISTS Administrativo(
cargo varchar (20) NOT NULL,
nome varchar (50)  NOT NULL,
cpf int (11)  NOT NULL,
nascimento int (8)  NOT NULL,
idade int (2)  NOT NULL,
rua varchar (50)  NOT NULL,
numero int (5)  NOT NULL,
cep int (8)  NOT NULL,
cidade varchar (50)  NOT NULL,
UF varchar (2)  NOT NULL
);
DESCRIBE Administrativo;

CREATE TABLE IF NOT EXISTS Veterinario (
crmv int (5) NOT NULL,
nome varchar (50)  NOT NULL,
rua varchar (50)  NOT NULL,
numero int (5)  NOT NULL,
cep int (8)  NOT NULL,
cidade varchar (50)  NOT NULL,
UF varchar (2)  NOT NULL
);

CREATE TABLE IF NOT EXISTS Usuario (
codigo int (10) NOT NULL,
senha int (6) NOT NULL,
tipo varchar (1) NOT NULL
);

/* Perguntar sobre DOUBLE para o professor*/
CREATE TABLE IF NOT EXISTS exame(
codigo int (10) NOT NULL,
nome varchar (20)  NOT NULL,
preco double (3,2)  NOT NULL
);

/* Perguntar sobre CÓDIGO para o professor*/
CREATE TABLE IF NOT EXISTS medicamento(
tipo varchar (1)  NOT NULL
);

CREATE TABLE IF NOT EXISTS remedio(
codigo int (10) NOT NULL,
nome varchar (20)  NOT NULL,
preco double (3,2)  NOT NULL
);

CREATE TABLE IF NOT EXISTS vacina(
codigo int (10) NOT NULL,
nome varchar (20)  NOT NULL,
preco double (3,2)  NOT NULL
);

CREATE TABLE IF NOT EXISTS consulta(
datahora int (15) NOT NULL
);

CREATE TABLE IF NOT EXISTS paciente(
codigopet varchar (10)  NOT NULL,
nomepet varchar (10) NOT NULL,
raca varchar (10)  NOT NULL,
idade int (2)  NOT NULL,
peso double (2,2)  NOT NULL,
sexo varchar (1)  NOT NULL,
PRIMARY KEY (codigopet)
);

USE hashpetsharp;
DROP TABLES paciente;

CREATE TABLE IF NOT EXISTS dono(
cpf int (11)  NOT NULL PRIMARY KEY,
paciente_codigopet INT NOT NULL,
nomedono varchar (50)  NOT NULL,
rua varchar (50)  NOT NULL,
numero int (5)  NOT NULL,
cep int (8)  NOT NULL,
cidade varchar (50)  NOT NULL,
UF varchar (2)  NOT NULL,
email varchar (20)  NOT NULL,
telefone int (11)  NOT NULL,
CONSTRAINT fk_dono_paciente FOREIGN KEY (paciente_codigopet) REFERENCES hashpetsharp.paciente (codigopet)
);
USE hashpetsharp;
DESCRIBE dono;



