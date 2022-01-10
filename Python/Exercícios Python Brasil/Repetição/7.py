#a = int(input('Digite um número: '))
#b = int(input('Digite um número: '))
#c = int(input('Digite um número: '))
#d = int(input('Digite um número: '))
#e = int(input('Digite um número: '))

#a = 100
#for G in range (1, a-5):
#	print(G)

lista = [3, 5, 7, 10, 11]
resultado = []
for x in lista:
    if x % 2 == 1:
        resultado.append(x)
print(resultado)

conjunto_a = {1, 1, 3, 4, 5}
conjunto_b = {1, 3, 6}
conjunto_a.add(6)
conjunto_a.remove(1)
resultado = list(conjunto_a.intersection(conjunto_b))

print(resultado)

