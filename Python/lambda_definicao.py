# ---- Função normal ----

def funcao(arg1, arg2):
	return arg1 * arg2

# ------- LAMBDA -------

# Lambda é uma função sem nome, ou seja, FUNÇÃO ANÔNIMA.
# É uma função com sintaxe simplificada, porém não é tão poderosa quanto uma função convencional.
# Ela não possui "parênteses" e "return".
a = lambda x, y: x * y

print('Função: ',funcao(2,2))
print('Lambda: ',a(2,2))

print(__name__)

valida_numero = {
    'par': lambda g: True if g % 2 == 0 else False,
    'impar': lambda s: True if s % 2 == 0 else False
}
resultado = valida_numero['par'](10)
print(resultado)