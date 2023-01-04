-- ************************************************************************
-- FUN��ES MATEM�TICAS
-- ************************************************************************

-- ABS: Retorna o n�mero sem o sinal (valor absoluto).
SELECT ABS(5)
SELECT ABS(-5)
SELECT ABS(+5)

-- SIGN: retorna o sinal de um n�mero.
SELECT SIGN(5)
SELECT SIGN(-5)
SELECT SIGN(+5)

-- SIN: retorna o seno de um n�mero.
SELECT SIN(0.5)

-- COS: retorna o cosseno de um n�mero.
SELECT COS(0.5)

-- TAN: retorna a tangente de um n�mero.
SELECT TAN(0.5)

-- ASIN: retorna o arcseno de um n�mero.
SELECT ASIN(0.5)

-- ACOS: retorna o arccosseno de um n�mero.
SELECT ACOS(0.5)

-- ATAN: retorna o arctangente de um n�mero.
SELECT ATAN(0.5)

-- PI: retorna o n�mero PI.
SELECT PI()

-- Calcular a �rea de um circulo de 5cm.
SELECT PI()*5*5
SELECT 3.14*5*5

-- Calcular o valor de um combustivel (etanol)
-- Armazenado em um tanque cil�ndrico de 5m de raio e 20m de altura
SELECT PI()*5*5 *20 * 1000* 3.2
SELECT 3.14*5*5 *20 * 1000* 3.2

-- POWER: retorna um n�mero elevado a outro (pot�ncia)
SELECT POWER(2,10) -- 2 elevado a 10
SELECT POWER(3,4) -- 3 elevado a 4
SELECT POWER(5,3) -- 5 elevado a 3

-- RAND: retorna valor rand�mico/aleat�rio. Por pad�o entre 0 e 0.9999..
SELECT RAND()
SELECT RAND() * 6 + 1

-- FLOOR: arredonda casas decimais para baixo.
SELECT FLOOR(2.2)
SELECT FLOOR(2.456)
SELECT FLOOR(2.00001)
SELECT FLOOR(2.999999999)
SELECT FLOOR(RAND()*6+1)

-- CEILING: arredonda para cima retornando o n�mero inteiro.
SELECT CEILING(2.2)
SELECT CEILING(2.456)
SELECT CEILING(2.00001)
SELECT CEILING(2.999999999)

-- ROUND: arredonda seguindo as regras matem�ticas.
-- O segundo argumento da fun��o determina a casa em que ocorre o arredondamento.
-- Obs: todos os retornos s�o exibidos com 6 d�gitos, inclusive n�meros inteiros.
SELECT ROUND(2.1,0)
SELECT ROUND(2.3,0)
SELECT ROUND(2.5,0)
SELECT ROUND(2.8,0)
SELECT ROUND(2.9,0)

SELECT ROUND(2.823645, 1)  -- 2.8
SELECT ROUND(2.823645, 3)  -- 2.824
SELECT ROUND(2.8236555, 4) -- 2.8237
SELECT ROUND(2.823645, 0)  -- 3

-- Exemplo utilizando o banco Northwind (necess�rio executar o mesmo antes):
SELECT productName, UnitPrice,
		UnitPrice * 1.0377 AS 'Aumenta 3,77%',
		ROUND(UnitPrice * 1.0373,2) AS 'Aumenta 3,73% e arred',
		SQRT(UnitPrice) AS 'raiz' FROM Products

-- ************************************************************************
-- FUN��ES DE DATA E HORA
-- ************************************************************************

-- retorna a data, hora, minuto, segundo e mil�simo do sistema.
SELECT GETDATE()

SELECT DAY(GETDATE())
SELECT MONTH(GETDATE())
SELECT YEAR(GETDATE())

-- Exemplos utilizando o banco Northwind:
SELECT * FROM Orders WHERE YEAR(OrderDate) = 2022
SELECT * FROM Employees WHERE MONTH(BirthDate) = 1
SELECT * FROM Employees WHERE MONTH(BirthDate) = MONTH(GETDATE())


-- Retorna data e tempo em horas, minutos, segundos e nanosegundos.
SELECT SYSDATETIME()

-- Mesmo retorno da anterior, com a adi��o do fuso hor�rio. 
SELECT SYSDATETIMEOFFSET()

-- The date and time is returned as UTC time (Coordinated Universal Time).
SELECT SYSUTCDATETIME()

/****************************************************************************
INTERVALOS
*****************************************************************************
dd - dia
mm - m�s
yy - ano
hh - hora
mi - minuto
ss - segundo
ms - milisegundos
ns - nanosegundos
ww - n�mero da semana
dw - dia da semana (a partir de dommingo)
dy - dia do ano
qq - trimestre
****************************************************************************/
SELECT DATEPART(dd,'21/05/1972')
SELECT DATEPART(mm,'21/05/1972')
SELECT DATEPART(yy,'21/05/1972')


SELECT DATEPART(ww,GETDATE()) -- n�mero da semana
SELECT DATEPART(dw,GETDATE()) -- dia da semana
SELECT DATEPART(qq,GETDATE()) -- trimestre
SELECT DATEPART(dy,GETDATE()) -- dia do ano

SELECT DATEPART(hh,GETDATE()) -- hora
SELECT DATEPART(mi,GETDATE()) -- minuto
SELECT DATEPART(ss,GETDATE()) -- segundo
SELECT DATEPART(ms,GETDATE()) -- milisegundos
SELECT DATEPART(ns,GETDATE()) -- nanosegundos
SELECT DATEPART(ns,SYSDATETIME()) -- nanosegundos

-- NOME DA DATA ---------------------------------
SELECT DATENAME(dw,GETDATE())
SELECT DATENAME(mm,GETDATE())