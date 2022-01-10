@echo off
:inicio
cls
echo.
echo Escolha uma fruta:
echo.
echo [1] Banana
echo [2] Melancia
echo [3] Cereja
echo [4] Pera
echo.
echo.
set /p opcao=digite a opcao desejada:

call:minha_funcao

goto inicio

:minha_funcao
if "%opcao%" == "1" (
	echo voce escolheu Banana
	pause
)
if "%opcao%" == "2" (
	echo voce escolheu Melancia
	pause
)
if "%opcao%" == "3" (
	echo voce escolheu Cereja
	pause
)
if "%opcao%" == "4" (
	echo voce escolheu Pera
	pause
)
goto:eof

cls
echo se isso aparecer significa a funcao foi passada.
pause
pause