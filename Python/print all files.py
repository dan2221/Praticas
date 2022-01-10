import os
import os.path
import shutil
import glob

lista_de_arquivos = []

dir_path = os.path.dirname(os.path.realpath(__file__))
print('Diretório:',dir_path)

lista = os.listdir(dir_path) # dir is your directory path
number_files = len(lista)
print ('Pastas e arquivos:',number_files)

print ('Somente arquivos:',len([name for name in os.listdir('.') if os.path.isfile(name)]))
'''
print('Lista de pastas e arquivos:')
for file in lista:
   print (file)
'''
print('Somente arquivos txt')
file = glob.glob("*.txt")
file.sort(key=os.path.getmtime) # Organizado por tempo
print("\n".join(file))

# ------------------------------------------------

'''
print('Lendo linhas -------------')
lines = []
with open('mod_list/hunter.txt') as f:
    lines = f.readlines()

count = 0
for line in lines:
    count += 1
    if "ModFolder:" in line:
    	print('------------------\nExiste Mod Folder!\n------------------')
    	dicionario.update({count: line.replace("ModFolder:","").replace('\n','')})
#    print(f'line {count}: {line}')
print(dicionario)
'''
# -------------------------------------------------
dicionario = {}

count = 0
for mod_arq in glob.glob("mod_list/*.txt"):
	count += 1
	varmod = mod_arq.replace('.txt','').replace('mod_list\\','')
	print(f'{count}: {varmod}')
	with open(f'mod_list/{varmod}.txt') as f:
		lines = f.readlines()
	for line in lines:
	    if "Mod Folder:" in line:
	    	print('------------------\nExiste Mod Folder!\n------------------')
	    	dicionario.update({count: {'variavel': varmod, 'pasta': line.replace("Mod Folder:","").replace('\n','')}})

print('Lista completa: ')

for key, value in dicionario.items():
    print(f'{key} - {value}')


print('---------------------------')
print('Valores indivíduais do mod')
print('---------------------------')
print(dicionario[4]['pasta'])
print(dicionario[4]['variavel'])
'''
print('--------------------------')
print(lista_de_arquivos)
'''