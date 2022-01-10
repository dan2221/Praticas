# Tema: Módulos, importação de classes, lambda.

# Módulo são os arquivos .py, eles podem interagir entre eles

# Acessando uma classe de outro módulo
#	 Módulo	    |    Classe
from Modulos2 import Televisao
from Modulos3 import contador_letras

# 	No Python, temos uma convenção idiomática para solucionar problemas
# como o do nosso tipo, em que precisamos que um código não execute se
# estiver sendo apenas importado.
if __name__ == '__main__':
	televisao = Televisao()
	print(televisao.ligada)
	televisao.power()
	print(televisao.ligada)
	lista = ['cachorro','gato','elefante']
	total_letras = contador_letras(lista)
	print('total de letras por palavra de lista: ',total_letras)