opcao = str(input('Type the desired option: '))

if opcao == '1':
	for x in range(1, 101):
		print(x)

if opcao == '2':
	for x in range(1, 101):
		if x%2==1:
			print(x)

if opcao == '3':
	for x in range(1, 101):
		if x%2==0:
			print(x)

if opcao == '4':
	for x in range(1, 101):
		if x%2==1:
			print(x, "x", 2, "=", x * 2)

if opcao == '5':
	a = "How to use a for loop in Python"
	for i in a:
		print(i)

if opcao == '6':
	a = ["How to use a for loop in Python"]
	for i in a:
		print(i.count(''))

opcao = str(input('Type the desired option: '))