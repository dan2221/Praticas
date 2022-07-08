-- a) criar tabela
CREATE TABLE EMPREGADOS (
MATR		CHAR(6),
NOME		VARCHAR(12),
SOBRENOME	VARCHAR(15),
DEPT		CHAR(10),
FONE		VARCHAR(14),
DATA_ADM	DATETIME,
CARGO		CHAR(10),
SEXO		CHAR(1),
IDADE		INT,
SALARIO		NUMERIC(10,2),
COMISSAO	NUMERIC(10,2),
PRIMARY KEY (MATR)
)

-- b) inserir 10 registros
INSERT INTO EMPREGADOS (
MATR, NOME, SOBRENOME, DEPT, FONE, DATA_ADM, CARGO, SEXO, IDADE, SALARIO, COMISSAO
)
VALUES
(12, 'Luis', 'Augusto', 'Vendas', '932120929', '20220120','Vendedor','m',35,'3000.00','200.00'),
(10, 'Rosana', 'Malaquias', 'Vendas', '931133919', '20220210','Vendedor','f', 42,'1900.00','200.00'),
(9, 'João', 'Nunes', 'ADM', '922110978', '20211214', 'Auxiliar', 'm', 23, '1700.00', '300.00'),
(16, 'Mônica', 'Souza', 'ADM', '987713341', '20211125', 'Auxiliar', 'f', 28, '1770.00', '300.00'),
(19, 'Bruno', 'Josiel', 'ADM', '988713221', '20211120', 'Auxiliar', 'm', 24, '1500.00', '190.00'),
(5, 'Daniel', 'Lima', 'TI', '991598688', '20210824', 'Dev', 'm', 23, '2000.00', '140.00'),
(8, 'Vladimir', 'Balac', 'TI', '997662166', '20200520', 'Dev', 'm', 40, '6000.00', '160.00'),
(2, 'Renan', 'Oliveira', 'TI', '987762121', '20210709', 'Analista', 'm', 30, '5300.00', '180.00'),
(4, 'Carlos', 'Montiel', 'TI', '976764451', '20210823', 'Dev', 'm', 26, '2100.00', '90.00'),
(14, 'Edvaldo', 'Silva', 'Marketing', '921131387', '20211019', 'Editor', 'm', 44, '2800.00', '1000.00');

-- c) empregados que ganham amis que R$5000
SELECT SOBRENOME, NOME, DEPT, DATA_ADM, SALARIO FROM EMPREGADOS
WHERE SALARIO > 5000.00;

-- d) média de salários
SELECT AVG(SALARIO) AS MEDIA_SALARIO
FROM EMPREGADOS;

-- e) total de funcionarios no departamento de TI
SELECT COUNT(DEPT) AS TOTAL_TI
FROM EMPREGADOS
WHERE DEPT = 'TI';

-- f) total de programadores (devs/desenvolvedores)
SELECT COUNT(DEPT) AS TOTAL_TI
FROM EMPREGADOS
WHERE CARGO = 'Dev';

-- g) soma de todos os salários
SELECT SUM(SALARIO) AS SOMA_SALARIOS
FROM EMPREGADOS;

-- h) maior salário
SELECT MAX(SALARIO) AS MAIOR_SALARIO
FROM EMPREGADOS;

-- i) menor salario
SELECT MIN(SALARIO) AS MAIOR_SALARIO
FROM EMPREGADOS;

-- j) atribuir 5% aos funcionários do dept. de TI
UPDATE EMPREGADOS
SET SALARIO=SALARIO * 1.05
WHERE DEPT = 'TI';

-- k) selecionar os cargos (sem duplicidade)
SELECT DISTINCT CARGO
FROM EMPREGADOS;

-- l) funcionários com idade entre 30 e 40 anos
SELECT NOME, SOBRENOME, IDADE FROM EMPREGADOS
WHERE IDADE >=30 AND IDADE <=40
ORDER BY IDADE;

-- m) média de idades
SELECT AVG(IDADE) AS MEDIA_IDADE FROM EMPREGADOS;

-- n) funcionários com idade entre 20 e 30 anos;
SELECT NOME, SOBRENOME, IDADE FROM EMPREGADOS
WHERE IDADE >=20 AND IDADE <=40
ORDER BY IDADE;

-- o) funcionários com nome iniciado por "J"
SELECT * FROM EMPREGADOS WHERE NOME LIKE 'J%';

-- p) funcionários dos departamentos TI, Vendas e Marketing
SELECT * FROM EMPREGADOS
WHERE DEPT IN ('TI', 'Vendas', 'Marketing');

-- REMOVER VALORES
DROP TABLE EMPREGADOS;