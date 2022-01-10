lista = [1, 10]

# Except {valor}
#	Valor: Classse de excessões embutida no Python

try: # Try verifica cada linha abaixo(filhos) dele, e relaciona com as excessões, quando uma linha dá erro as outras são ignoradas.
	divisao = 10 / 2
	numero = lista[1]
except ZeroDivisionError: # Erro ao divividir por zero.
	print('Não é possível realizar uma divisão por 0!')
except IndexError:	# Erro de índice.
	print('Erro ao acessar um índice inválido da lista!')
except BaseException as ex: # BaseException é o pai de todas as excessões! Serve para todos os erros!
	print('Erro desconhecido. Erro: {}'.format(ex)) # "ex" irá escrever o nome do erro.
else: # Senão houver nenhuma excessão o else será executado!
	print('Não ocorreu nenhuma exceção!')
finally: # Executa independente de haver erro ou não
	print('sempre executa')
