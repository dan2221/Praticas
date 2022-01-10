@echo off
:inicio
cls
set m1=ban
set m2=mel
set m3=cer
set m4=per
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

for %%G in (1 2 3 4) do (
	if "%opcao%" == "%%G" goto m%%G
)

echo.
echo nenhuma opcao foi escolhida
pause

:m1
echo.
echo a fruta escolhida foi banana.
echo.
pause
goto inicio

:m2
echo.
echo a fruta escolhida foi melancia.
echo.
pause
goto inicio

:m3
echo.
echo a fruta escolhida foi cereja.
echo.
pause
goto inicio

:m4
echo.
echo a fruta escolhida foi Pera.
echo.
pause
goto inicio