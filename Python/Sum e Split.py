# split({valor}) texto que deseja encontrar no arquivo.
# sum -> pesquisar

numeros = '20,40,50,12,28,99'
print('Normal: ',numeros)

recorte_numeros = numeros.split(',')
print('Split: ',recorte_numeros)

#int(soma_1) = recorte_numeros[0] + recorte_numeros [1]
#print('Soma de array: ', soma1)

print('\nPrimeiro valor: ',recorte_numeros[0])
print('Segundo valor:  ',recorte_numeros[1])
print('Terceiro valor: ',recorte_numeros[2])

print('\nTipo da var numeros: ',type(recorte_numeros))

#soma_numeros = sum(recorte_numeros)

# --------------------------------------
listinha = [10, 20, 30, 40]
soma_lista = sum(listinha)
print('\nSoma: ',soma_lista)
# --------------------------------------


notas = [0, 0, 9.0, 8.0, 5.0, 10.0, 7.0, 7.5, 4.0, 10.0, 7.0, 7.0, 8.0, 8.0, 7.5]
print('Tipo da var notas: ',type(notas))
## código omitido

soma_das_notas = sum(notas)
print('Soma das notas: ',soma_das_notas)


'''soma_n = sum(numeros)
print('Soma: ',soma_n)'''