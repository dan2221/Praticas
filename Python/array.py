animal = ['vaca', 'porco', 'cavalo', 'galinha'] # Colchetes: Variável, List
planta = ('mulungu','orquídea','flor da pedra') # Parênteses: Constante, Tuple
numeros = ['#000000', '#0000ff', '#ff0000']
print(numeros)

meuNome = 'daniel'

# adicione o comando insert

print('Lista Normal: ',animal)
print('Apenas dois: ',animal[2],animal[3])
if 'peixe' in animal:
	print('Existe um peixe na lista')
else:
	print('Não existe um peixe na lista')

animal.append('jumento')
animal.append('peixe')
print('Acrescentado  2: ',animal)

if 'peixe' in animal:
	print('Existe um peixe na lista')
else:
	print('Não existe um peixe na lista')

# Apagar item da lista
animal.pop(0)
print('index apagado:', animal)

animal.remove('galinha')
print('Nome apagado: ', animal)

animal.sort()
print('Ordem Alfabética: ', animal)

animal.reverse()
print('Ordem Reversa: ',animal)

animal[0]='ovelha'
print('Valor trocado: ',animal,'\n')

print('Contando valores')
print('  variável animal: ',len(animal),'itens')
print('  constante planta: ',len(planta),'itens\n')

print('Tipo de array')
print('  planta:',type(planta))
print('  animal:',type(animal),'\n')

print('Trocando o tipo')
animal = tuple(animal)
print('  planta:',type(planta))
print('  animal:',type(animal),'\n')

Idade = 20
Ano = 2000

print('idade:{}Ano:{}'.format(Idade,Ano))

print('\nN° de letras no nome: ', len(meuNome))

lista_paises = ['Brasil', 'Escócia', 'Alemanha', 'Inglaerra']

lista_paises.sort ()
print(lista_paises)
