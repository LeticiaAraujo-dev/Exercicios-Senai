
USE Pessoal

CREATE TABLE Pessoa (
	idPessoa	INT PRIMARY KEY IDENTITY
	,Nome		VARCHAR(200) NOT NULL
);
GO

CREATE TABLE Email (
	idEmail		INT PRIMARY KEY IDENTITY
	,idPessoa	INT FOREIGN KEY REFERENCES Pessoa (idPessoa)
	,Endereco	VARCHAR(200) NOT NULL
);
GO

CREATE TABLE Telefone (
	idTelefone	INT PRIMARY KEY IDENTITY
	,idPessoa	INT FOREIGN KEY REFERENCES Pessoa (idPessoa)
	,Numero		INT
);
GO

CREATE TABLE CHNs (
	idCHNs		INT PRIMARY KEY IDENTITY
	,idPessoa	INT FOREIGN KEY REFERENCES Pessoa (idPessoa)
	,Descri??o	VARCHAR(200) NOT NULL
);
GO