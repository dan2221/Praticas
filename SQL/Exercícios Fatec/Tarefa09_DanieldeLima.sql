-- ATIVIDADE 9 - BANCO DE DADOS

-- a) Criar as tabelas x Relacionamentos:
CREATE TABLE Clientes(
	Codcli		INT PRIMARY KEY,
	Nome		VARCHAR(30),
	Endereco	VARCHAR(40),
	Cidade		VARCHAR(30),
	Fone		CHAR(9)
);

CREATE TABLE Transportadora(
	Codigo	INT PRIMARY KEY,
	Nome	VARCHAR(20)
);

CREATE TABLE Pedidos(
	NumPed		 INT PRIMARY KEY,
	Cliente		 INT,
	Data_Entrega DATETIME,
	Transport	 INT,
	-- CHAVES ESTRANGEIRAS
	FOREIGN KEY(Cliente) REFERENCES Clientes(Codcli),
	FOREIGN KEY(Transport) REFERENCES Transportadora(Codigo)
);

-- b) Inserir 5 registros em cada tabela.
INSERT INTO Clientes VALUES
(1, 'Ad�lio Corn�lio', 'R. Jos� Alvez', 'Santo Andr�', '934348765'),
(2, 'Maria Hipotenusa', 'R. S�o Pedro', 'Mau�', '992141445'),
(3, 'Luan Facquin', 'Av. Mister Sam', 'Mau�', '921212121'),
(4, 'Caio Vargas', 'R. Campos Sales', 'SBC', '987213198'),
(5, 'Alan Valdez', 'Av. Olimpio', 'SBC', '987762112');

INSERT INTO Transportadora VALUES
(101, 'ABC'),
(102, 'On�a'),
(103, 'P�r do Sol'),
(104, 'Brazz'),
(105, 'Alpha');

INSERT INTO Pedidos VALUES
(51, 1, '20220220', 101),
(52, 2, '20220215', 102),
(53, 3, '20220224', 103),
(54, 4, '20220301', 104),
(55, 5, '20220304', 105);

-- c) Selecionar todos os pedidos da transportadora ABC.
SELECT * FROM Pedidos INNER JOIN Transportadora
ON Pedidos.Transport = Transportadora.Codigo
WHERE Transportadora.Nome = 'ABC';

-- d) Quantos pedidos existem para o cliente 2?
SELECT COUNT(Pedidos.Cliente) AS Pedidos_do_cliente_2
FROM Pedidos INNER JOIN Clientes
ON Pedidos.Cliente = Clientes.Codcli
WHERE Cliente = 2;

-- e) Qual o n�mero do Pedido mais recente?
-------- Sem INNER JOIN --------------------------------------------------------------------------------------
SELECT NumPed FROM Pedidos AS Pedido_mais_recente
WHERE Data_Entrega = (SELECT MAX(Data_Entrega) FROM Pedidos);

-- f) Temos quantos pedidos para a Transportadora ABC?
SELECT COUNT(Pedidos.NumPed) AS Qtde_pedidos_ABC
FROM Pedidos INNER JOIN Transportadora
ON Transportadora.Codigo = Pedidos.Transport
WHERE Transportadora.Nome = 'ABC';

-- g) Quantos Clientes residem em Mau�?
--------- Sem INNER JOIN -------------------------------------------------------------------------------------
SELECT COUNT(Nome) AS Clientes_em_Maua
FROM Clientes
WHERE Cidade = 'Mau�';

-- h) Selecionar N�mero do Pedido, Data_Entrega e Nome do Cliente.
SELECT Pedidos.NumPed, Pedidos.Data_Entrega, Clientes.Nome
FROM Pedidos INNER JOIN Clientes
ON Pedidos.Cliente = Clientes.Codcli;

-- i) Selecionar N�mero do Pedido, Nome do Cliente e nome da Transportadora.
SELECT Pedidos.NumPed AS Pedido,
	   Clientes.Nome AS Cliente,
	   Transportadora.Nome AS Transportadora
FROM Pedidos INNER JOIN Transportadora
ON Transportadora.Codigo = Pedidos.Transport
INNER JOIN Clientes
ON Clientes.Codcli = Pedidos.Cliente;

-- j) Selecionar todos os clientes da cidade de Santo Andr�, Mau� e SBC.
---------- Sem INNER JOIN ------------------------------------------------------------------------------------
 SELECT * FROM Clientes
 WHERE Cidade IN ('Santo Andr�','Mau�','SBC');