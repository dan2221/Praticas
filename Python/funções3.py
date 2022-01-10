# Classe
class Televisao:
	# Instanciando a classe
	# Instancia é quando voce tem uma classe mas precisa dar um nome para chama-la
	def __init__(self):
		self.ligada = False
		self.canal = 5

	# Método
	def power(self):
		if self.ligada:
			self.ligada = False
		else:
			self.ligada = True
	# Método
	def aumenta_canal(self):
		if self.ligada: # equivalente a "if self.ligada == True"
			self.canal += 1

	def diminui_canal(self):
		if self.ligada:
			self.canal -= 1

televisao = Televisao()
print('Televisão está ligada: ',televisao.ligada)
televisao.power()
print('Televisão está ligada: ',televisao.ligada)
televisao.power()
print('Televisão está ligada: ',televisao.ligada)
televisao.power()
print('Televisão está ligada: ',televisao.ligada)
for G in range(5):
	televisao.aumenta_canal()

televisao.diminui_canal()
print('Canal: ',televisao.canal)

def minha_funcao(numero):
    if numero % 2 == 0:
        return '{} é par'.format(numero)
    else:
        return '{} é ímpar'.format(numero)
    return "zero é neutro"

class Carro:
    def __init__(self):
        self.motor = 'desligado'
        self.movimento = False

    def ligar(self):
        self.motor = 'ligado'
    
    def acelerar(self):
        if self.motor == 'ligado':
            self.movimento = True

    def carro_em_movimento(self):
        return self.movimento

carro = Carro()
carro.acelerar()
carro_em_movimento = carro.carro_em_movimento()
print(carro_em_movimento)