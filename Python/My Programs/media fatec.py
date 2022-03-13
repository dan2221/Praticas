# Calculadora de média do aluno
print("Simulador de notas do Fatecano\n")

loop = 'infinito'

while loop == 'infinito':
	# Inserir notas
	P1 = float(input("Digite a nota da P1: ").replace(",","."))
	P2 = float(input("Digite a nota da P2: ").replace(",","."))
	T = float(input("Digite a nota de Trabalho: ").replace(",","."))

	# Cálculo da média
	media = round(P1*0.35 + P2*0.35 + T*0.3, 1)

	# Output
	print("\nMédia: ", media)
	if media < 6:
		print('Reprovado, que pena :(')
	else:
		print('Aprovado, parabéns : )')

	print("\n----------------------------\n")