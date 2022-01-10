@echo off
set /p numero=escreva o numero:

set /A soma=%numero%+10
set /A sub=%numero%-10
echo %soma%
echo %sub%
pause