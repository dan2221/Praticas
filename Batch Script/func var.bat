@echo off
call:funcao orochi rugal

echo char1 ta %orochi%
echo char2 ta %rugal%
pause


:funcao
set %~1=ativado
set %~2=desativado
goto:eof