conjuntoj = {1, 2, 3, 4, 4, 2}
conjuntoj.add(5)
conjuntoj.discard(2)
print(conjuntoj,'\n')

print("[{}]  {}".format('One', 'Two'))

valores = ['x',
	'brutal',	'Brutal Justice v1.0',
	'doa',		'DOA',
	'hunterg',	'Nightsweeper v1.4',
	'NBDOWN',	'Never Back Down',
	'BDRAG',	'Rage Rise of The Black Dragon',
	'SOR3A',	"SoR3 - Adams Story Extended",
	'SORV',		'Streets of Rage V - demo 2017',
	'URBANR',	'Urban Reign',
	'WAYW',		'Way of the Warrior'
]

for g in range(1, len(valores)):
	if (g % 2 != 0):
		print(valores[g],'é uma variável')
	else:
		print(valores[g],'é um diretório')

if 'brutal' in valores:
	print('EXISTE A VARIAVEL BRUTAL NOS VALORES!')

if not 'sonic' in valores:
	print('A VAR SONIC NÃO EXISTE!')


conjunto = {1,2,3,4,5}
conjunto2= {5,6,7,8,9}
lista_val=[]
lista_val=["daniel","Chaves","Chap"]

print('Elemento individual:',lista_val[1])
lista_val.append("Quico")
print(lista_val)

# Union: Junta os dois arrays em 1 e ELIMINA os valores duplicados
conjunto_uniao = conjunto.union(conjunto2)
print('\nUnião: {}'.format(conjunto_uniao))

# Intersection: usado para se referir apenas aos valores os arrays têm em comum.
conjunto_interseccao = conjunto.intersection(conjunto2)
print('\nIntersecção: {}'.format(conjunto_interseccao))

# Difference:
conjunto_diferenca1 = conjunto.difference(conjunto2)
conjunto_diferenca2 = conjunto2.difference(conjunto)
print('\nDiferença entre 1 e 2: {}'.format(conjunto_diferenca1))
print('Diferença entre 2 e 1: {}'.format(conjunto_diferenca2))

# Symmetreic_difference: declara apenas os valores que os array não possuem em comum, nesse caso o 5 ficou excluído.
conjunto_diff_simetrica = conjunto.symmetric_difference(conjunto2)
print('\nDiferença simétrica: {}'.format(conjunto_diff_simetrica))

# Subconjuntos --------------------------------------------------

conjunto_a = {1,2,3}
conjunto_b = {1,2,3,4,5}
subconjunto_customizado = {{11,12,13},{21,22,23},{31,32,33}}
print(subconjunto_customizado)

# Issubset: tornando um conjunto subconjunto em outro
conjunto_subset = conjunto_a.issubset(conjunto_b)
print('A é subconjunto de B:',conjunto_subset)

# Issuperset: B é superconjunto porque possui mais elementos q A e 3 deles tem em comum.
conjunto_superset = conjunto_b.issuperset(conjunto_a)
print('B é superconjunto de A:',conjunto_superset)

# Removendo duplicidades
lista = ['cachorro', 'cachorro', 'gato', 'gato', 'elefante']
print('\nLista sem alteração: ',lista)
# Pra isso converta a lista pra um conjunto
conjunto_animais = set(lista)
print('Duplicidade removida: ',conjunto_animais)

conjuntox = {1, 2, 2, 1, 6, 5}
print(conjuntox)