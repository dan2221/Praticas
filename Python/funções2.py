# Classe
class Calculadora:
	# Instanciando a classe
	# Instancia é quando voce tem uma classe mas
	# precisa dar um nome para chama-la
	def __init__(self, num1, num2):
		self.valor_a = num1
		self.valor_b = num2
	# Método
	def soma(self):
		return self.valor_a + self.valor_b
	# Método
	def subtracao(self):
		return self.valor_a - self.valor_b
	# Método
	def multiplicacao(self):
		return self.valor_a * self.valor_b
	# Método
	def divisao(self):
		return self.valor_a / self.valor_b

calculadora = Calculadora(10, 2)
print('Funções envolvendo {} e {}:'.format(calculadora.valor_a,calculadora.valor_b))
print('Soma:          ',calculadora.soma())
print('Subtração:     ',calculadora.subtracao())
print('Multiplicação: ',calculadora.multiplicacao())
print('Divisão:       ',calculadora.divisao(),'\n')