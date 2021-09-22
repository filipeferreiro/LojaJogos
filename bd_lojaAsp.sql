create database bd_lojaAsp;
use bd_lojaAsp;

create table tb_funcionario(
	CodFuncionario varchar(255) primary key,
    NomeFuncionario varchar(255) not null,
    CPFFuncionario varchar(255) not null,
    RGFuncionario varchar(255) not null,
    NascFuncionario varchar(255) not null,
    EnderecoFuncionario varchar(255) not null,
    CelFuncionario varchar(255) not null,
    EmailFuncionario varchar(255) not null,
    CargoFuncionario varchar(255) not null
);

create table tb_cliente(
	CPFCliente varchar(255) primary key,
    NomeCliente varchar(255) not null,
    NascCliente varchar(255) not null,
    EnderecoCliente varchar(255) not null,
    CelCliente varchar(255) not null,
    EmailCliente varchar(255) not null
);

create table tb_jogo(
	CodJogo varchar(255) primary key,
    NomeJogo varchar(255) not null,
    VersaoJogo varchar(255) not null,
    DesJogo varchar(255) not null,
    GeneroJogo varchar(255) not null,
    EtariaJogo varchar(255) not null,
    PlatJogo varchar(255) not null,
    AnoJogo varchar(255) not null,
    SinopseJogo text not null
);
