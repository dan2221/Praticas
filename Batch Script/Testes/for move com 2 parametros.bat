@echo off
FOR /R arquivos\ %%A IN (
	A0
	B0
	C0
	D0
	E0
	F0
	G0
) DO FOR arquivos2\ %%B IN (
	Aviao
	Barril
	Cachorro
	Defeito
	Elegante
	Formado
	Grave
) DO move "%%A.txt" "arquivos2\%%B.txt"
pause