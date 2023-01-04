select*from Categories

select*from Employees
select*from Suppliers

select*from Customers

select*from Categories

select*from Products

select*from Employees

select*from Customers where country = 'mexico'

--mostre os clientes do brazil--
select*from Customers where country = 'brazil'

--mostre os clientes de londres--
select*from Customers where city = 'london'

--todos os produtos que são bebidas--  --categoryid =1
SELECT * FROM Products WHERE CategoryID = 1

--os produtos com preço maio ou igual a 100 --
SELECT * FROM Products WHERE UnitPrice >= 100

--os fornecedores (suppliers) dos estados unidos (USA)
SELECT * FROM Suppliers WHERE Country = 'USA'

SELECT * FROM orders 

--pedidos do dia 11/08/2022--
SELECT * FROM Orders WHERE OrderDate = '20220811'

SELECT * FROM Orders WHERE OrderDate = '11/08/2022'

-- Utilizar caso haja problema com a inserção de data
-- set dateformat mdy

SELECT * FROM Orders WHERE OrderDate BETWEEN '01/07/2022' AND '31/07/2022'
SELECT * FROM Orders WHERE OrderDate >= '01/07/2022' AND OrderDate <= '31/07/2022'

-- Funções de sistema para data e hora
SELECT * FROM Orders WHERE MONTH(OrderDate) = '07' AND YEAR(orderdate) = '2022'


--todos os produtos entre 50 e 70--
SELECT * FROM Products WHERE UnitPrice BETWEEN '50' AND '70'