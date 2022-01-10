import os
import os.path
import shutil
from pathlib import Path

#proj = 'Brutal Justice v1.0'

# Funções -------------------------------------

def move(name_file_move, diretorio_move):
	shutil.move(name_file_move, diretorio_move)

def ren(nome_original, novo_nome):
	os.rename(nome_original,novo_nome)


move("mod/games/Brutal Justice v1.0/palettes/enemies","palettes")
