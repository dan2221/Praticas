#	O split é um divisor de string, insira um valor
# que contém na variável e ela será dividida.

x = 'blue,red,green'

a,b,c = x.split(",")

#	A variável x foi dividida entre as variáveis a,
# b e c. Os valores foram distribuídos entre elas de
# acordo com a ordem de corte.

print(a)
print(b)
print(c)

print('\n')

words = "This is random text we’re going to split apart"

#	A variável word foi dividida em forma de conjunto
# e tudo foi atribuído a variável words2.

words2 = words.split(" ")
print(words2)
print('')