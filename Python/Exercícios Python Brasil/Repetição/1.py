a = int(input('Digite o valor:  '))

while (a > 10) or (a < 0):
	print('Valor inválido! \n')
	a = int(input('Digite outro valor: '))

print ('Sua nota é: ', a)