-- Tarefa 07

-- a) Criar tabelas
CREATE TABLE Clientes (
	Codcli	int PRIMARY KEY,
	Nome	varchar(30),
	Ender	varchar(40),
	Bairro	varchar(20),
	Cidade	varchar(20),
	Idade	int
);

CREATE TABLE Produtos (
	Codprod		int PRIMARY KEY,
	Descricao	varchar(20),
	Preco		numeric(9,2),
);

CREATE TABLE Pedidos (
	Codped		int, -- Chave primária
	Codcli		int, -- Chave estrangeira
	Dataentrega datetime,
	PRIMARY KEY(Codped),
	------------------- Fonte/origem da chave estrangeira.
	FOREIGN KEY(Codcli) REFERENCES CLientes(Codcli)
);

CREATE TABLE Itens_pedido (
	Codped	int, -- Chave estrangeira
	Codprod	int, -- Chave estrangeira
	Qtde	int
	FOREIGN KEY(Codped) REFERENCES Pedidos(Codped),
	FOREIGN KEY(Codprod) REFERENCES produtos(Codprod)
);

-- b) inserir 5 registros
INSERT INTO Clientes (
	Codcli, Nome, Ender, Bairro, Cidade, Idade
) VALUES
(1, 'Vanderley', 'R. Oswaldo Cruz', 'Vila América', 'Mauá', 41),
(2, 'Jucicleuda', 'Av. São Bento', 'Pôr do Sol', 'SBC', 39),
(3, 'Aderbal', 'R. Juscelino Kubcheck', 'Vila da Alegria', 'Santo André', 37),
(4, 'Petruquio', 'R. Barão Gabriel', 'Delcides Telles', 'SCS', 26),
(5, 'Soraia', 'Av. Ramon Valdez', 'Vlillagran', 'SCS', 51);

INSERT INTO Produtos (
	Codprod, Descricao, Preco
) VALUES
(10, 'Tennis Olympikus', 200.00),
(20, 'Chinelo Avaianas', 18.00),
(30, 'Sandália Moleca', 46.99),
(40, 'Sapato VIP', 299.00),
(50, 'Pacote de meias', 29.00);

INSERT INTO Pedidos (
	Codped, Codcli, Dataentrega
) VALUES
(100, 1, '20220320'),
(101, 2, '20220322'),
(102, 3, '20220324'),
(103, 4, '20220323'),
(104, 5, '20220401');

INSERT INTO Itens_Pedido (Codped, Codprod, Qtde)
VALUES
(100, 10, 12),
(101, 20, 5),
(102, 30, 23),
(103, 40, 11),
(104, 50, 9);

-- c) Selecionar produtos com preço entre 10 e 70
SELECT * FROM Produtos
WHERE Preco >= 10 AND Preco <=70;

-- d) média de idade dos clientes
SELECT AVG(Idade)
AS Media_de_Idade
FROM Clientes;

-- e) Média de preço dos produtos
SELECT AVG(Preco)
AS Media_de_Precos
FROM Produtos;

-- f) Quantos pedidos temos no cadastro
SELECT COUNT(Codped)
AS Qtde_pedidos
FROM Pedidos;

-- g) Clientes que moram em Santo André, SBC, SCS ou Mauá
SELECT * FROM Clientes
WHERE Cidade IN ('Santo André', 'SBC', 'SCS', 'Mauá');


-- Testando -----------------
SELECT * FROM Clientes;
SELECT * FROM Produtos;
SELECT * FROM Pedidos;
SELECT * FROM Itens_pedido;

/*
-- Resetar tabelas
DROP TABLE Itens_pedido;
DROP TABLE Pedidos;
DROP TABLE Produtos;
DROP TABLE Clientes;
*/