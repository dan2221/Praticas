@echo off
For /R arquivos\ %%G IN (
	A0.txt
	B0.txt
	C0.txt
	D0.txt
	E0.txt
	F0.txt
	G0.txt
) do Move "%%G" arquivos2