a = int(input('Primeiro valor: '))
b = int(input('Segundo valor: '))
c = int(input('Terceiro valor: '))
# int:	 converte a variável para inteiro
# input: permite que você digite o valor, igual ao set/p do Batch

if a > b and a > c:
	print('O maior número é {}'.format(a))
elif b > a and b>c:
	print('O maior número é {}'.format(b))
elif c > a and c>b:
	print('O maior número é {}'.format(c))
else:
	print('Existem valores iguais')

conta = a % 2
print(conta)

pausa = input('Pressione Enter')
	