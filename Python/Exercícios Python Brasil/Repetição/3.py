nome = input('Digite seu nome: ')
while len(nome) < 3:
	nome = input('Digite outro nome: ')


idade = int(input('Digite sua idade: '))
while (idade < 0 ) or (idade > 150):
	idade = int(input('Digite outra idade: '))


salario = int(input('Digite seu salário: '))
while salario < 1:
	salario = int(input('Digite outro salário: '))


sexo = input('Digite seu sexo: ')
while (sexo != 'masculino') and (sexo != 'feminino'):
	sexo = input('Dados inálidos! Digite novamente: ')


civil = input('Digite seu Estado civil: ')
while (
	civil != 'solteiro'
) and (
	civil != 'casado'
) and (
	civil != 'divorciado'
) and (
	civil != 'viuvo'
):
	civil = input('Dados inválidos! Digite novamente: ')