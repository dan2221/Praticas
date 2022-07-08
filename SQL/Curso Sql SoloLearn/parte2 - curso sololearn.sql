-- FILTERING, FUNCTIONS, SUBQUERIES (PARTE2)

-- Este arquivo é uma anotação dos conteúdos
-- que aprendi no curso de SQl.

/*
    Operadores lógicos
     
    AND, OR, NOT: Já são conhecidos
    
    IN: verdadeiro se a operação é igual a uma
    lista de expressões.
*/

-- AND
SELECT Nome, Sobrenome, Idade
FROM Clientes
WHERE Idade >=30 AND Idade <=40;

-- OR
SELECT Nome, Sobrenome, Cidade FROM Clientes
WHERE Cidade = 'São Paulo' OR Cidade = 'Santo André';

-- AND e OR
SELECT Nome, Cidade, Idade FROM Clientes
WHERE Cidade = 'Santos'
AND (Idade=30 OR Idade=37);

-- IN: usado quando você quer comparar
-- uma coluna com mais de um valor.

-- Em vez de fazer isso:
SELECT * FROM Clientes
WHERE Cidade = 'Mauá'
OR Cidade = 'Mooca'
OR Cidade = 'Chicago';

-- Faça isso:
SELECT * FROM Clientes
-- repare que a sintaxe usa parenteses.
WHERE Cidade IN ('Mauá','Mooca','Santo André');

-- NOT e IN
SELECT * FROM Clientes
WHERE Cidade NOT IN ('Mauá','Mooca','Santo André');

-- CONCAT (Concatenar)
/* AVISO: esta função NÃO FUNCIONA no SQLite
          Neste caso se deve usar o operador
          || para fazer concatenar.
  
    O exemplo abaixo não funciona no SQlite.
    Use-o em outro SGBD.
SELECT CONCAT(Nome, ', ' , Cidade)
FROM Clientes;
*/

-- Concatenação com operador (||):
SELECT Nome || ', ' || Cidade
FROM Clientes;

-- Coluna customizada (custom collumn):
SELECT Nome || ', ' || Cidade
AS new_column -- Nome da nova coluna.
FROM Clientes;

-- FUNÇÕES ----------------------------

-- UPPER e LOWER (Maiúsculo e minúsuclo)
SELECT LOWER(Nome), UPPER(Sobrenome)
AS LastName
FROM Clientes;

-- SQRT: square root (raíz quadrada)
SELECT valor, SQRT(valor) AS raiz_quadrada
FROM ContasReceber;

-- AVG: Average Value (Valor médio)
SELECT AVG(valor) AS media
FROM ContasReceber;

-- SUM (SOMA)
SELECT SUM(valor) AS Soma_dos_valores
FROM ContasReceber;

-- SUBQUERIES -----------------------------------

-- Subquery significa um query dentro de outro.
-- Isso é feito com a ajuda de parenteses.
SELECT idCliente, valor FROM ContasReceber
WHERE valor > (SELECT AVG(valor) FROM ContasReceber)
ORDER BY valor DESC;
-- DESC: descending order
-- ASC: ascending order

-------------------------------------

-- LIKE: pesquisa valores que iniciam
--       ou terminam com o argumento
--       digitado.

-- Inicia com A
SELECT * FROM Clientes
WHERE Nome LIKE 'A%';

-- Termina com s
SELECT * FROM Clientes
WHERE SobreNome LIKE '%s';

-----------------------------------

-- Função MIN
SELECT MIN(Idade) FROM Clientes;

-- Função MAX
SELECT MAX(Idade) FROM Clientes;