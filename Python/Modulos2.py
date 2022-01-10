# Tema: Módulos, importação de classes, lambda.

# Módulo são os arquivos .py, eles podem interagir entre eles
class Televisao:
	def __init__(self):
		self.ligada = False
		self.canal = 5

	def power(self):
		if self.ligada:
			self.ligada = False
		else:
			self.ligada = True

	def aumenta_canal(self):
		if self.ligada:
			self.canal += 1

	def diminui_canal(self):
		if self.ligada:
			self.canal -= 1
