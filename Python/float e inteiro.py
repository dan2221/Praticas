# Quando os dois argumentos são inteiros o resultado é inteiro.
# Quando um dos argumentos é float/decimal o resultado é float.
print(2 ** 3)
print(2 ** 3.)
print(2. ** 3)
print(2. ** 3.)

# Com a divisão há uma EXCEÇÃO!

print(6 / 3) # Utilizando apenas inteiros.
print(6 / 3.)
print(6. / 3)
print(6. / 3.)

# Para corrigir isso utilize barra dupla:
print(6 // 3)