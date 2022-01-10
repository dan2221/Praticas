# Utilizando barra dupla (//) em uma divisão cujo resultado é
# um inteiro, é retornado um inteiro. Utilizando em uma divisão
# com resultado float o mesmo resultado retornará ARREDONDADO!

print('Inteiro:', 6 / 3) # floor division (divisão inteira)

print('\nDecimal:')
print('Uma barra:', 6 / 4)
print('Duas barras:', 6 // 4)
print()
print('Uma barra:', 6. / 4)
print('Duas barras:', 6. // 4)

print('\nNegativos:')
print(-6 // 4)
print(6. // -4)

# O símbolo de porcentagem é utilizado para calcular o
# RESTO DA DIVISÃO:
#
#	  50 |20
#	- 40 ¨¨¨¨¨
#	_____|2
#	  10

print('-----------------')
print('Resto da divisão:')
print(50 % 20)
