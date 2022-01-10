'''
Sintaxe:

\033[ESTILO];FG;BGm

O texto deve ser inserido após a letra 'm'.

-------------------------------------------

O ESTILO é a forma na qual o texto deve ser exibido, e são representados pelos números 0, 1, 4 e 7

-0:(Nome) sem cor.
-1:(bold) Negrito.
-4:(underline) Sublinhado.
-7:(Negative) Inverte letra e fundo.

------------------------------------------------

FG (Foreground): cor da letra.
BG (Background): cor de fundo.

São ao todo 8 cores, representadas por uma sequência numérica do 30 ao 37:

   FG	|  COR	 |   BG

	30	  Branco		;40
	31	  Vermelho	;41
	32	  Verde		;42
	33	  Amarelo	;43
	34	  Azul		;44
	35	  Magenta	;45
	36	  Cyan		;46
	37	  Cinza		;47

---------------------------------------------

"\033[m" -> Limpar formatação

--------------------------------------

Exemplos de código:
'''
print(" \033[0:31m TEXTO COLORIDO \033[m ")
print(" \033[0:0;41m FUNDO COLORIDO \033[m ")
print(" \033[31:42m TEXTO VERMELHO \033[m ")

pause = input('\nTecle Enter!')