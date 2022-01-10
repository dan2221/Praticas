import shutil
''' Comando OPEN {path} {valor}

Valores:

	w -> write(escrever) e sobescrever arquivo.
	a -> atualizar/editar arquivo.
	r -> read/ler arquivo.
'''

# split({valor}) # O split é um divisor de string, insira um valor
#				  que contém na variável e ela será dividida.
# sum -> soma

def escrever(texto):
	arquivo = open('teste.txt', 'w')
	arquivo.write(texto)
	arquivo.close() # Fechar abertura do arquivo

def atualizar(texto):
	arquivo = open('teste.txt', 'a')
	arquivo.write(texto)
	arquivo.close() # Fechar abertura do arquivo

def ler_arquivo(nome_arquivo):
	arquivo = open(nome_arquivo, 'r')
	texto = arquivo.read()
	print(texto)
'''
def copiar(name_file):
	shutil.copy(name_file, 'C:/ESTUDO/Python/pasta_teste/')

def move(name_file_move)
	shutil.move(name_file_move, 'C:/ESTUDO/Python/pasta_teste/')
'''
shutil.copyfile('teste.txt', 'C:/ESTUDO/Python/pasta_test/')

