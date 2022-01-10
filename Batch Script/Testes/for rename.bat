@echo off
For /R arquivos\ %%a IN (
	A0	Aviao
	B0	Barril
	C0	Cachorro
	D0	Defeito
	E0	Elegante
	F0	Formado
	G0	Grave
) do Move "%%a.txt" "%%b.txt"
pause