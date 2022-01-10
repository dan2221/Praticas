import os
import glob

# https://stackoverflow.com/questions/33400682/check-if-a-directory-contains-a-file-with-a-given-extension
for fname in os.listdir('ajuda/.'):
    if fname.endswith('.py'):
        # do stuff on the file
        print('existe arquivo py')
        break
else:
	print('não existe arquivo py')
    # do stuff if a file .true doesn't exist.

if not any(fname.endswith('.png') for fname in os.listdir('Ajuda/.')):
	print('não existe arquivo png')
else:
	print('existe arquivo png')

# stuff
if not glob.glob('Ajuda/*.png'):
    # do stuff if no file ending in .true exists
	print('não existe arquivo png')
else:
	print('existe arquivo png')