-- BASIC CONCEPTS (PARTE 1)

-- Este arquivo é uma anotação dos conteúdos
-- que aprendi no curso de SQL.

-- Select seleciona os dados
select idCliente from ContasReceber
where idCliente = 3;

-- DISTINCT serve para não exibir resultados repetidos.
SELECT DISTINCT Cidade FROM Clientes;

-- LIMIT exibe os a quantidade de primeiros dodos.
SELECT Celular, Cidade
FROM Clientes
LIMIT 4;

--OFFSET deve ser usado junto com Limit
-- ele especifica um intervalo após o limit.
SELECT idCliente, Cidade
FROM Clientes
LIMIT 2,4;

-- Outra forma de se referir ao atributo de uma tabela,
-- embora não seja muito útil.
SELECT Clientes.Celular from CLientes;

-- ORDER ordena a exibição de acordo com o dado citado.
SELECT * FROM Clientes
ORDER BY Nome;

/*
    É possível usar mais parâmetros para compor uma hierarquia de exibição.
    Isso funciona quando um objeto possuí alguns valores de atributos iguais a
    outro. Neste exemlo usaremos o cliente Cícero.
*/
SELECT * FROM Clientes
ORDER BY Nome, Idade;

-- WHERE é semelhante ao if das linguagens de programação.
/*
    =        IGUAL
    !=       DIFERENTE
    >        MAIOR QUE
    <        MENOR QUE
    >=       MAIOR OU IGUAL
    <=       MENOR OU IGUAL
    BETWEEN  Between an inclusive range.
*/

-- Igual
SELECT idCliente, Nome FROM Clientes
WHERE idCliente = 10;

-- Maior
SELECT idCliente, Nome FROM Clientes
WHERE idCliente > 10;

-- Menor
SELECT idCliente, Nome FROM Clientes
WHERE idCliente < 10;

-- Diferente
SELECT idCliente, Cidade FROM Clientes
WHERE Cidade != 'Mauá';

-- Igual
SELECT Nome, Cidade FROM Clientes
WHERE Cidade = 'Santo André';

--Between (entre)
SELECT Nome FROM Clientes
WHERE idCliente BETWEEN 3 AND 8;

