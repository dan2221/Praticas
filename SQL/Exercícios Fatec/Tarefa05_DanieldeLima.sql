-- TAREFA 05

-- a) criar tabela de produtos
CREATE TABLE Produtos (
Codprod		int PRIMARY KEY,
Descricao	varchar(20),
Preco		numeric(9,2),
Qtde		int,
Cor			char(20)
);

-- b) inserir 10 registros
INSERT INTO Produtos (
	Codprod, Descricao, Preco, Qtde, Cor
) VALUES
(1, 'Chocolate', 4.00, 40, 'marrom'),
(2, 'Suco_uva', 3.40, 80, 'roxo'),
(3, 'Arroz', 14.00, 100, 'Branco'),
(4, 'Picolé', 1.50, 60, 'Azul'),
(5, 'Chinelo', 16.00, 30, 'Preto'),
(6, 'Banana', 3.20, 90, 'Amarelo'),
(7, 'Maçã', 5.00, 150, 'Vermelho'),
(8, 'Pêra', 9.20, 60, 'Amarelo'),
(9, 'Morango', 6.50, 70, 'Vermelho'),
(10, 'Televisão', 510.00, 3, 'Azul');

-- c) quantidade de produtos
SELECT COUNT(Descricao)
AS Qtde_de_produtos
FROM Produtos;

-- d) produtos com preço entre 10 e 50 reais
SELECT * FROM Produtos
WHERE Preco >= 10 AND Preco <= 50;

-- e) valor do produto mais caro
SELECT MAX(Preco)
AS Valor_mais_alto
FROM Produtos;

-- f) valor do produto mais barato
SELECT MIN(Preco)
AS Valor_mais_alto
FROM Produtos;

-- g) Média dos preços
SELECT AVG(Preco) AS Media_preco
FROM Produtos;

-- h) quantidade de produtos vermelhos
SELECT COUNT(Cor)
AS Qtde_vermelhos
FROM Produtos
WHERE Cor = 'Vermelho';

-- i) acrescentar 15% aos preços abaixo de R$10.00
UPDATE Produtos
SET Preco = Preco * 1.15
WHERE Preco < 10.00;

SELECT * FROM Produtos;

-- j) descontar 5% aos preços acima de R$500.00
UPDATE Produtos
SET Preco = Preco * 0.95
WHERE Preco > 500.00;

SELECT * FROM Produtos;

-- k) Excluir todos os produtos com qtde abaixo de 5
DELETE FROM Produtos
WHERE Qtde < 5;

SELECT * FROM Produtos;

-- l) Listar cores sem duplicidade
SELECT Cor FROM Produtos
GROUP BY Cor;

-- m) Selecionar produtos de cor azul, vermelho, branco e preto.
SELECT * FROM Produtos
WHERE Cor IN (
	'Azul',
	'Vermelho',
	'Branco',
	'Preto'
) ORDER BY Cor;

-- n) Somatório das quantidades
SELECT SUM(Qtde)
AS Qtde_total
FROM Produtos;

-- o) Produtos com descrição iniciada por "A"
SELECT * FROM Produtos
WHERE Descricao LIKE 'A%';


-- Resetar
DROP TABLE Produtos;