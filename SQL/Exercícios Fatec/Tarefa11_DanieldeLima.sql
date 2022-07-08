-- ATIVIDADE 11

-- a) Criar as tabelas e Relacionamentos.
CREATE TABLE Cursos(
	Codcurso	INT PRIMARY KEY,
	Nome		VARCHAR(20)
);

CREATE TABLE Disciplinas(
	Codisc	INT PRIMARY KEY,
	Nome	VARCHAR(20)
);

CREATE TABLE Alunos(
	RM		INT PRIMARY KEY,
	Nome	VARCHAR(45),
	Curso	INT,
	Serie	INT,
	Periodo VARCHAR(20),
	FOREIGN KEY (Curso) REFERENCES Cursos(Codcurso)
);

CREATE TABLE Notas(
	RM		INT,
	Discipl INT,
	Nota1	NUMERIC(10,2),
	Nota2	NUMERIC(10,2),
	CONSTRAINT PK_nota PRIMARY KEY (RM,Discipl), -- Chave composta
	FOREIGN KEY (RM) REFERENCES Alunos(RM),
	FOREIGN KEY (Discipl) REFERENCES Disciplinas(Codisc)
);

-- b) Inserir 5 registros em cada tabela.
INSERT INTO Cursos VALUES
(1, 'Inform�tica'),
(2, 'Pl�stico'),
(3, 'Log�stica'),
(4, 'Pol�meros'),
(5, 'Gest�o Empresarial');

INSERT INTO Disciplinas VALUES
(1, 'Matem�tica'),
(2, 'Banco de Dados'),
(3, 'LPII'),
(4, 'Administra��o Geral'),
(5, 'Direito Empresarial');

INSERT INTO Alunos VALUES
(1100, 'Daniel de Lima', 1, 3, 'manh�'),
(7762, 'Guilherme Lopes', 1, 3, 'manh�'),
(1987, 'Julio Almeida', 2, 4, 'noite'),
(1231, 'Nat�lia Rocha', 3, 1, 'noite'),
(8771, 'Marcelo Rubens', 5, 2, 'noite');

INSERT INTO Notas (RM,Discipl,Nota1)VALUES
(1100, 2, 5.7),
(7762, 2, 9.2);
INSERT INTO Notas (RM,Discipl,Nota1,Nota2)VALUES
(1987, 1, 8.5, 7.8),
(8771, 3, 5.7, 8.0);
INSERT INTO Notas (RM,Discipl)VALUES
(1231, 1);

-- c) Selecionar nome, per�odo e s�rie de todos os alunos do curso de Inform�tica.
SELECT Alunos.Nome, Alunos.Periodo, Alunos.Serie
FROM Alunos INNER JOIN Cursos
ON Cursos.Codcurso = Alunos.Curso
WHERE Cursos.Nome = 'Inform�tica';

-- d) Selecionar Nome do aluno, curso, nome da disciplina, nota1 e nota2, de todos os alunos.
SELECT Alunos.Nome, Cursos.Nome AS Curso,
	Disciplinas.Nome AS Disciplina, Notas.Nota1, Notas.Nota2
FROM Alunos INNER JOIN Cursos ON Alunos.Curso = Cursos.Codcurso
INNER JOIN Notas ON Alunos.RM = Notas.RM
INNER JOIN Disciplinas ON Notas.Discipl = Disciplinas.Codisc;

-- e) Selecionar todas as notas do aluno (Seu nome).
SELECT Alunos.Nome, Notas.Nota1, Notas.Nota2
FROM Notas LEFT OUTER JOIN Alunos
ON Alunos.RM = Notas.RM
WHERE Alunos.Nome = 'Daniel de Lima';

-- f) Selecionar RM, nome e curso de todos os alunos com nota1 superior a 8 na disciplina Matem�tica;
SELECT Alunos.RM, Alunos.Nome, Cursos.Nome AS Curso
FROM Cursos INNER JOIN Alunos ON Alunos.Curso = Cursos.Codcurso
INNER JOIN Notas ON Alunos.RM = Notas.RM
INNER JOIN Disciplinas ON Notas.Discipl = Disciplinas.Codisc
WHERE Disciplinas.Nome = 'Matem�tica' AND Notas.Nota1 > 8;

-- g) Quantas notas (nota1) inferior a 6,0, em Banco de Dados, temos no Cadastro de Notas?
SELECT COUNT(Notas.Nota1) AS Notas_Vermelhas_BD
FROM Notas LEFT OUTER JOIN Disciplinas
ON Notas.Discipl = Disciplinas.Codisc
WHERE Notas.Nota1 < 6.0 AND Disciplinas.Nome = 'Banco de Dados';

-- h) Qual a m�dia de Notas (Nota2) na disciplina LPII?
SELECT AVG(Notas.Nota2) AS Media_de_notas_2
FROM Notas INNER JOIN Disciplinas
ON Notas.Discipl = Disciplinas.Codisc
WHERE Disciplinas.Nome = 'LPII';

-- i) Quantos alunos temos no curso de Inform�tica?
SELECT COUNT(Alunos.Nome) AS Qtde_Alunos 
FROM Alunos INNER JOIN Cursos
ON Alunos.Curso = Cursos.Codcurso
WHERE Cursos.Nome = 'Inform�tica';

-- j) Quantos alunos temos no curso de Pl�stico?
SELECT COUNT(Alunos.RM) AS Qtde_Alunos
FROM Alunos INNER JOIN Cursos
ON Alunos.Curso = Cursos.Codcurso
WHERE Cursos.Nome = 'Pl�stico';

-- k) Selecionar todos os alunos que n�o possuem Nota1.
SELECT Alunos.Nome AS Alunos_Sem_Nota1
FROM Notas LEFT OUTER JOIN Alunos
ON Alunos.RM = Notas.RM
WHERE Notas.Nota1 is NULL;

-- l) Selecionar todos os alunos que n�o possuem Nota2.
SELECT Alunos.Nome FROM Alunos
LEFT OUTER JOIN  Notas ON Alunos.RM = Notas.RM
WHERE Notas.Nota2 IS NULL;

-- m) Selecionar todos os alunos que n�o possuem Nota1 em Matem�tica.
SELECT Notas.RM AS Alunos_Sem_Nota1_Matematica
FROM Notas LEFT OUTER JOIN Disciplinas
ON Notas.Discipl = Disciplinas.Codisc
WHERE Notas.Nota1 IS NULL AND Disciplinas.Nome = 'Matem�tica';

DROP TABLE Alunos;
DROP TABLE Cursos;
DROP TABLE Disciplinas;
DROP TABLE Notas;
