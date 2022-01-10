div=1
ln=[1]
print('Linhas diferentes:\n')
for G in range (20):
	print(div)
	div+=1
	ln.append(div)

print('------------\nMesma linha:\n')

for i in range(20): 
    print(ln[i], end =" ")