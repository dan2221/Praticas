

popA = 8000
popB = 200000

while not (popA >= popB):
	porcentagemA = popA * 0.03
	popA += porcentagemA
	porcentagemB = popB * 0.015
	popB += porcentagemB

print('País A: ' , popA)
print('País B: ' , popB)
print('\nDiferença:',(popA - popB))
