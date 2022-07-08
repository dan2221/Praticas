-- JOIN, Operações de tabelas (PARTE 3)

-- Este arquivo é uma anotação dos conteúdos
-- que aprendi no curso de SQl.

-- JUNTAR TABELAS

-- No Sql juntar tabelas significa combinar dados
-- de uma ou mais tabelas para cirar uma tabela temporária.

-- 
SELECT customers.ID, customers.Name, orders.Name AS Product, orders.Amount
FROM customers, orders
WHERE customers.ID = orders.Customer_ID
ORDER BY customers.ID;

-- NOMES CUSTOMIZADOS (AS)

-- Tabelas, assim como colunas também podem ter nomes
-- customizados. Neste caso os nomes das tabelas foram
-- alterados para versões abreviadas.
SELECT ct.ID, ct.Name, ord.Name AS Product, ord.Amount
FROM customers AS ct, orders AS ord -- Veja o exemplo!
WHERE ct.ID = ord.Customer_ID
ORDER BY ct.ID;

-- TIPOS DE ADESÃO (JOIN)

-- INNER JOIN (Adesão interna)

-- Funciona como a interseção entre dois conjuntos.
SELECT * FROM customers
INNER JOIN orders
ON customers.ID = orders.Customer_ID;
-- o "ON" serve para especificar a condição de junção/adesão.
-- Se parece com o where.

-- LEFT JOIN retorna as linhas (rows) da tabela esquerda
-- sempre quando não houver combinação.

-- Retorna a tabela esquerda e sua interseção com a tabela
-- direita.
SELECT
    ID,
    Name AS Ct_name,
    City
---- LEFT       <---->         RIGHT
FROM customers LEFT OUTER JOIN orders
ON customers.ID = orders.Customer_ID;

-- Outro exemplo
SELECT customers.Name, items.Name
FROM customers LEFT OUTER JOIN items
ON customers.ID=items.Seller_id;
-- Quando não houver dados em comum (match)
-- O NULL será escrito.

-- RIGHT OUTER JOIN
SELECT
    customers.Name AS CLients,
    items.Name AS Products
FROM customers RIGHT OUTER JOIN items
ON customers.ID=items.Seller_id;

-- Existem outros tipos de junção, mas não são
-- suportadas pelo MySQL.

------------------------------------------------------
-- COMBINANDO (MATCHING) DADOS DE VÁRIAS TABELAS
------------------------------------------------------
--
-- Para funcionar as tabelas devem ter colunas iguais.
-- Utilizamos dois operadores oara isso:

-- • UNION: combina multiplos datasets em um único e
-- remove quaisquer dados duplicados.
SELECT * FROM customers
UNION
SELECT * FROM customers2;
-- Repare no nome David e Chloe!

-- Se a quantidade de colunas não for igual você pode
-- Substituir a coluna que falta por NULL.

-- Exemplo:
/*
SELECT FirstName, LastName, Company
FROM businessContacts
UNION
SELECT FirstName, LastName, NULL
FROM otherContacts;
*/

-- • UNION ALL: faz o mesmo, porém não remove linhas
-- (rows) duplicadas. Ele é mais rápido que o UNION.
SELECT * FROM customers
UNION ALL
SELECT * FROM customers2
ORDER BY ID;

-- INSERT DATA ----------------------------
-- Especificando atributos

INSERT INTO customers (ID, Name, City, Age)
VALUES
(8, 'Anthony', 'Young', 35);
SELECT * FROM customers;

-- Sem especificar atributos
INSERT INTO customers
VALUES (9, 'Oswald', 'Paris', 55);
SELECT * FROM customers;

-- EDITAR/ATUALIZAR REGISTROS (UPDATE) ----
UPDATE employees
SET Salary=5000
WHERE ID=1;

UPDATE employees
SET Salary = 5100, FirstName='Robert'
WHERE ID=1;

-- DELETE
DELETE FROM employees
WHERE ID=1;

SELECT * FROM employees;

-- CRIAÇÃO DE TABELA ----------
CREATE TABLE pets(
ID      INT,
Name    VARCHAR(30),
Species VARCHAR(30),
Age     INT,
-- float and double has the same parameter. The first one is
-- the var lenght, and the second one is the number of
-- decimals.
Peso    FLOAT(5,2)
);
-- O tipo de dado varchar é basicamente uma
-- String com limite de caracteres.

/* OUTROS TIPOS DE VARIÁVEIS
-
NUMÉRICOS: INT, FLOAT E DOUBLE
DATA E TEMPO:
-
    • DATA - YYYY-MM-DD
    • DATETIME - YYYY-MM-DD HH:MM:SS
    • TIMESTAMP
    • TIME - HH:MM:SS
-
STRING:
-
    • CHAR - largura fixa
    • VARCHAR - largura variável, o máximo
      pode ser especificado nos parenteses.
    • BLOB - "Binary Large Objects". Este tipo de dado
      armazena montantes de dados binários, como
      imagens e outros arquivos.
    • TEXT -  Grande quantidade de dados de texto.
*/

-- CONSTRAINTS: são especificações de regras à tabela.
/*
    • NOT NULL: indica que uma coluna não pode conter nenhum
                valor vazio.
    • UNIQUE: não permite que hajam valores duplicados na coluna.
    • PRIMARY KEY: indica o index da tabela.
    • CHECK: determina se um valor é válido ou não através de uma
             expressão lógica.
    • DEFAULT: se nenhum valor for atribuído à coluna, o que for
               escrito no default será utilizado como padrão.
*/
-- AUTO_INCREMENT

-- Habilita a gereção automática de numeros únicos a cada registro
-- inserido. Por padrão o valor inicial é 1 e vai aumentando +1 para
-- cada novo registro criado.
CREATE TABLE people (
    ID    INTEGER PRIMARY KEY AUTOINCREMENT,
    FirstName VARCHAR NOT NULL,
    LastName VARCHAR NOT NULL,
    City VARCHAR NOT NULL
);

INSERT INTO people(FirstName,LastName,City)
VALUES
('John', 'Smith', 'New York'),
('David', 'Williams', 'Los Angeles'),
('Chloe', 'Anderson', 'Chicago');

SELECT * FROM people;

--- ALTER TABLE

-- Comando utilizado para adicionar, deletar ou modificar
-- colunas em uma tabela existente.

-- Adicionando coluna:
ALTER TABLE people ADD DateofBirth date;

SELECT * FROM people;

-- Removendo coluna

-- O código abaixo não funciona no SQLite.
-- ALTER TABLE people DROP COLUMN DateofBirth;

-- Para "remover" a coluna no SQLite é necessário
-- recriar uma tabela sem a coluna indesejada :(

-- RENOMEAR (não funciona no SQLite)
-- ALTER TABLE people
-- RENAME FirstName TO Name;

-- Renomear tabela (não funciona no SQLite)
-- RENAME TABLE people TO clients;

-- VIEW

-- View é uma tabela virtual, baseada no resultado 
-- da declaração do SQL. Elas permitem impor
-- restrições aos usuários que têm acesso a elas.
--
-- Algumas vantagens:
-- • Não ocupam espaço no BD.
-- • Podem ser reusadas.
-- • Traz mais segurança devido às restrições.
-- • Simplificação do códogo.

CREATE VIEW folks AS
SELECT *
FROM employees;

SELECT * FROM folks;

-- Atualizado uma View (não funciona no SQLite)
/*
CREATE OR REPLACE VIEW folks AS
SELECT *
FROM employees;
*/

-- Deletar um view
DROP VIEW folks;