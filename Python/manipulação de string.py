#Encontrar alguma coisa
data = 'From stephen.marquard@uct.ac.za Sat Jan 5 09:14:16 2008'
inicio = data.find('@')
print('ID da letra:',inicio)
fim = data.find(' ', inicio)
print(fim)
host = data[inicio + 1 : fim]
print(host)

arq = 'hunter.txt'
new_arq = arq.replace('.txt','')

print('Variavel do mod:{}'.format(new_arq))