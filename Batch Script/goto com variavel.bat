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

if "%opcao%" == "1" goto %m1%
if "%opcao%" == "2" goto %m2%
if "%opcao%" == "3" goto %m3%
if "%opcao%" == "4" goto %m4%

echo.
echo nenhuma opcao foi escolhida
pause

:ban
echo.
echo a fruta escolhida foi banana.
echo.
pause
goto inicio

:mel
echo.
echo a fruta escolhida foi melancia.
echo.
pause
goto inicio

:cer
echo.
echo a fruta escolhida foi cereja.
echo.
pause
goto inicio

:per
echo.
echo a fruta escolhida foi Pera.
echo.
pause
goto inicio