@ECHO OFF &SETLOCAL
echo Concatenar contagem:
SET /a count=5
for /l %%a in (1,1,%count%) do call set "SorTeam=%%SorTeam%%, %%a"
ECHO %SorTeam:~2%

set "SorTeam="
set "Animais="
set "Frutas="
set "Cores="
set name=daniel
echo concatenar espaco:
call set "name=%%name%% "
echo %name%Lima
echo.
echo --------------------
pause

if "%Cores%" == "" (echo variavel nao tem nada!) else (echo tem valor)

for %%G in (Vaca, Cachorro, Macaco, Zebra) do call set "Animais=%%Animais%%, %%G"
for %%G in (Melancia, Morango, Pitanga, Marolo) do call set "Frutas=%%Frutas%%, %%G"
for %%G in (Azul, Vermelho, Roxo, Preto) do call set "Cores=%%Cores%%, %%G"
echo.
echo Concatenar nomes:
for %%G in ("[char]Axel", "[char]Blaze", [char]Adam, MrX2) do call set "SorTeam=%%SorTeam%%, %%G"
ECHO %SorTeam:~2%
echo.
echo Concatenar sem FOR:
call set "SorTeam=%%SorTeam%%, "Zan2""
call set "SorTeam=%%SorTeam%%, Shiva"
ECHO variavel concatenada: %SorTeam:~2%
ECHO variavel normal: %SorTeam%
echo -----------------------------------------
echo for %%S in (%SorTeam:~2%) do (
	echo %%S|find "MrX" >nul
	if errorlevel 1 (echo Zan not found) else (echo Zan found!)
)
pause

echo.
echo Encontrando valores:
echo %SorTeam:~2%|find "Zan" >nul
if errorlevel 1 (echo Zan not found) else (echo Zan found!)
echo %SorTeam:~2%|find "Blaze" >nul
if errorlevel 1 (echo Blaze not found) else (echo Blaze found!)
echo %SorTeam:~2%|find "MrX*" >nul
if errorlevel 1 (echo mrx not found) else (echo mrx found!)
echo.
echo Separando valores com FOR:
for %%G in (%SorTeam:~2%) do echo %%G
echo.
echo Procurando um valor em varios conjuntos com FOR:
for %%S in (%Animais%, %Frutas%, %Cores%) do (
	echo %%S|find "Preto" >nul
	if errorlevel 1 (
		echo ------------------------
		echo Termo atual: %%S
		echo Preto not found
	) else (
		echo ------------------------
		echo Termo atual: %%S
		echo Preto found!
	)
)
echo.
pause
exit /b

