# Criando Excessões personalizadas #

class Error(Exception): #parâmetro exception, ela herda a excessão
	pass # não faz nada

class InputError(Error):
	def __init__(self, message):
		self.message = message

while True:
	try:
		x = int(input('Entre com uma nota de 0 a 10: '))
		print(x)
		if x > 10:
			# raise força uma excessão
			raise InputError('Nota não pode ser maior que 10!\n')
		elif x < 0:
			raise InputError('Nota não pode ser menor que 0!\n')
		break # Break força a saída do loop
	except ValueError:
		print('Valor inválido! Deve-se digitar apenas números!\n')
	except InputError as ex:
		print(ex)