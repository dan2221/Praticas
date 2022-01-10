import os
import os.path
import shutil
from pathlib import Path

# Funções -------------------------------------

clear = lambda: os.system('cls')

def move(name_file_move, diretorio_move):
	shutil.move(name_file_move, diretorio_move)

def ren(nome_original, novo_nome):
	os.rename(nome_original,novo_nome)



#move("arquivo.txt","palettes")
'''
os.chdir('palettes') # Change dir/escolher diretório.
ren('arquivo.txt','novo_nome.txt')

os.chdir('..') # voltar diretório
ren('vermelho.txt','azul.txt')
'''
#move('novo_nome.txt','palettes')

ren('palettes','arquivos_de_cores')