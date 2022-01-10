@echo off
mode con: cols=35 lines=8
cls
echo.
echo.
echo.
for /f %%a in ('dir aula*.html /b /a-d ^|find /c /v ""') do echo Numero de arquivos: %%a
echo.
set /p arquivo=Escolha o numero do arquivo:

start palemoon aula%arquivo%.html