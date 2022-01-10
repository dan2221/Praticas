@echo off
cls
set var1=louro_jose
set var2=21
call:teste_logico louro_jose
call:teste_logico 12
pause
exit

:teste_logico
IF "%~1" == "" (echo %~1 eh string) else (echo %~1 nao eh string)
rem if "%var1%" > "0" (echo eh numero) else (echo nao eh numero)
goto:eof
