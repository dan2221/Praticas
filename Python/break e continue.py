"""
O Python fornece duas instruções especiais para a execução
de ambas estas tarefas. Digamos, por uma questão de precisão,
que a sua existência na linguagem não é necessária - um
programador experiente é capaz de codificar qualquer algoritmo
sem estas instruções. Tais adições, que não melhoram o poder
expressivo da linguagem, mas apenas simplificam o trabalho do
programador, são por vezes chamadas de doces sintáticos, ou
açúcar sintático.

"""
# break - example

print("The break instruction:")
for i in range(1, 6):
    if i == 3:
        break
    print("Inside the loop.", i)
print("Outside the loop.")


# continue - example

print("\nThe continue instruction:")
for i in range(1, 6):
    if i == 3:
        continue
    print("Inside the loop.", i)
print("Outside the loop.")

# Ambos são keywords