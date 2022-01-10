For %%G IN (
	A0
	B0
	C0
	D0
	E0
	F0
	G0
) DO (
	FOR %%H IN (
		Aviao
		Batalha
		Canela
		Duracel
		Esquisito
		Fosforo
		Garganta
	) Rename "arquivos\%%G.txt" "%%H.txt"
)
pause