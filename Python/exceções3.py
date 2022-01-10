class InputError(Exception):
    def __init__(self, message):
        self.message = message

nome = 'Adda'
while True:
    try:
        x = input('Digite um nome: ')
        if x == nome:
            break
        else:
            raise InputError('Nome inválido')
    except InputError as ex:
        print(ex)