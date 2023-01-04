create table Contas(
CodConta int,
DataAbertura datetime,
saldo money,
cliente varchar(20)
)
-----------------------------------
insert into contas (Codconta, DataAbertura,Saldo,Cliente)
			values (100,'01/01/2022',3000,'Ana')

insert into contas (Codconta,dataAbertura,Saldo,cliente)
			values (200,'08/01/2022',3000,'Eva')

insert into contas (Codconta, dataAbertura, Saldo, cliente)
			values (300,'10/01/2022',3000,'Rui')

insert into contas (Codconta, dataAbertura, Saldo, cliente)
			values (400,'15/01/2022', 3000, 'Bob')

create table Deposito (
Codconta int,
DataDeposito datetime,
valordep money
)
--------------------------------------------------------------
create table Saques(
CodConta int,
Datasaque datetime,
valorsaq money
)

-------------------------------------------------------------
go
create trigger TrSaque on Saques after insert as 
begin
	declare @codconta int,
			@valorsaq money

	select @codconta = codconta from inserted
	select @valorsaq = valorsaq from inserted
	update Contas set saldo = saldo - @valorsaq where codconta = @codconta
end

---------------------------------------------------------------------------
select * from contas
insert into saques (codconta, datasaque, valorsaq)
			values (100,'16/11/2022',1000)
select * from contas

---------------------------------------------------------------------------
go
create trigger TrDeposito on Deposito after insert as 
begin
	declare @codconta int,
			@valordep money

	select @codconta = codconta from inserted
	select @valordep = valordep from inserted
	update Contas set saldo = saldo + @valordep where codconta = @codconta
end
-----------------------------------------------------------------------------
select * from contas
insert into Deposito (codconta, DataDeposito, valordep)
			values (100,'16/11/2022',1000)
insert into Deposito (codconta, DataDeposito, valordep)
			values (200,'17/11/2022',700)
insert into Deposito (codconta, DataDeposito, valordep)
			values (300,'17/11/2022',1500)
insert into Deposito (codconta, DataDeposito, valordep)
			values (100,'18/11/2022',4000)

select * from contas

------------------------------------------------------------------------------
