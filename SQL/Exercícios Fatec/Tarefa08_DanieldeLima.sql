-- Atividade 8 - SQL

-- a) Criar tabelas
CREATE TABLE GRAVADORA (
 CodGrav	INT PRIMARY KEY,
 Nome_grav	VARCHAR(20)
);

CREATE TABLE CDS (
Codigo		INT PRIMARY KEY,
Nome		VARCHAR(30),
Gravadora	INT,
Data_Compra DATETIME,
Valor_pago	NUMERIC(10,2),
Local_Compra VARCHAR(20),
Album		INT,
FOREIGN KEY (Gravadora) REFERENCES GRAVADORA(CodGrav)
);

-- b) Inserir 10 registros na tabela CDS e 5 na GRAVADORA
INSERT INTO GRAVADORA(
	CodGrav,
	Nome_grav
)
VALUES
(1, 'Diamond'),
(2, 'Master Records'),
(3, 'VIP Universe'),
(4, 'Pôr do Sol'),
(5, 'Random');

INSERT INTO CDS (
	Codigo,
	Nome,
	Gravadora,
	Data_Compra,
	Valor_pago,
	Local_Compra,
	Album
)
VALUES
(1,'Amor Genuíno', 4, '20220114', 59.89, 'Americanas', 0),
(22,'DJ André Platinum CD', 2, '20220201', 39.90, 'Submarino', 1),
(31,'Eletric waves', 1, '20220220', 29.90, 'Saraiva', 0),
(41,'Mr. Laurence Jazz Show', 3, '20220207', 98.20, 'Saraiva', 1),
(25,'Rodolph Opera Concert', 3, '20220223', 109.99, 'Saraiva', 1),
(16,'Minha terrinha', 4, '20220901', 74.60, 'Saraiva', 0),
(7,'Good Life', 1, '20220118', 21.90, 'Americanas', 0),
(8,'Exciting Samba', 2,'20220117', 24.99, 'Submarino', 1),
(29,'Work Alcholic', 5,'20220301', 16.80, 'Americanas', 0),
(14,'Cant Stop Dancing', 2,'20220313', 35.40, 'Submarino', 0);

-- c) selecionar todos os CDs
SELECT * FROM CDS;

-- d) Selecionar os campos nome e data_compra da tabela CDS.
SELECT Nome, Data_Compra FROM CDS;

-- e) Exibir o total gasto com a compra dos Cds.SELECT SUM(Valor_pago) AS Total_gasto FROM CDS;

-- f) Mostre a quantidade de Cds.
SELECT COUNT(Codigo) AS Quantidade_de_CDs FROM CDS;

-- g) Mostre o nome de todos cds comprados no Submarino.SELECT Nome FROM CDS
WHERE Local_Compra = 'Submarino';

-- h) Mostrar todos os cds que são álbuns.
SELECT * FROM CDS WHERE Album = 1;

-- i) Mostre o valor do cd que custou mais caro.
SELECT MAX(Valor_pago) AS CD_mais_caro FROM CDS;

-- j) Mostrar todos os CDs que tem nome iniciado pela letra “R”
SELECT * FROM CDS WHERE Nome LIKE 'R%';

-- k) Mostrar a média de preços dos CDs.
SELECT AVG(Valor_pago) AS Media_de_precos FROM CDS;

-- l) Quantos CDs foram comprados na Americanas?
SELECT COUNT(Nome) AS CDs_na_Americanas FROM CDS
WHERE Local_Compra = 'Americanas';

-- m) Atualizar o preço dos CDs reajustando em 10%.
UPDATE CDS
SET Valor_pago=Valor_pago * 1.10;

-- n) Mostrar todos os CDs comprados no Submarino, Americanas e Saraiva.
SELECT * FROM CDS
WHERE Local_Compra IN ('Submarino', 'Americanas', 'Saraiva');

-- o) Mostrar todos os CDs com código entre 20 e 30 inclusive.
SELECT * FROM CDS
WHERE Codigo BETWEEN 20 AND 30;

-- p) Mostrar todos os CDs cujo valor pago seja maior que 25,00.SELECT * FROM CDS
WHERE Valor_pago > 25.00;

-- q) Mostrar o preço do CD mais barato.
SELECT MIN(Valor_pago) AS Preco_mais_barato FROM CDS;

-- r) Mostrar todos os locais de compra, sem duplicidade.
SELECT DISTINCT Local_Compra
AS Locais_de_compra
FROM CDS;

-- resetar dados
/*
DROP TABLE CDS;
DROP TABLE GRAVADORA;
*/