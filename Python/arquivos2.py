import os
import os.path
import shutil
from pathlib import Path


# Pastas
if not os.path.exists('aulinha_1'): # Verificar existência de pasta.
	os.mkdir('aulinha_1') # Criando pasta
else:
	print('Diretório já existe!')

# Change dir/escolher diretório.
os.chdir('aulinha_1')

# Criar arquivo
# Path touch cria o arquivo independente dele existir ou não.
Path('xpto.txt').touch()

if os.path.isfile('xpto.txt'): # Verificar existência de arquivo.
	print('O arquivo xpto existe!')
else:
	print('O arquivo xpto não existe!')

# Copiar arquivo

shutil.copy('xpto.txt', 'xpto_1.txt')
shutil.copy('xpto.txt', 'xpto_2.txt')
shutil.copy('xpto.txt', 'xpto_3.txt')

print('Diretório atual: ',os.getcwd())
arquivos_aula = os.listdir('.') # Pega arquivos da pasta atual.
print('Arquivos do diretório: ',arquivos_aula)
#assert len(os.listdir('.')) == 4

for el in range(10):
	Path(f'live_{el}.txt').touch()

# Obter apenas arquivos iniciados em live
l = ([f for f in os.listdir('.') if f.startswith('live')])
print(l)
