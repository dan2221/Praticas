@echo off
mode con: cols=35 lines=10
cls
echo.
echo.
echo.
for /f %%a in ('dir aula*.html /b /a-d ^|find /c /v ""') do  echo Anotacoes:  %%a
echo.
echo [E] Exercicios
echo.
set /p arquivo=Escolha o numero do arquivo:

if "%arquivo%" == "e" (goto secao)

start palemoon aula%arquivo%.html
set "arquivo="
exit

:secao
cls
echo.
echo.
echo.
for /f %%a in ('dir exercicio*.html /b /a-d ^|find /c /v ""') do echo Exercicios: %%a
echo.
echo.
set /p arquivo=Escolha o numero do arquivo:

start palemoon execicio%arquivo%.html
set "arquivo="
exit