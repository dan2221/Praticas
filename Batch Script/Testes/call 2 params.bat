@echo off
call complemento.bat banana amarela
call:alter morango vermelho
echo.
echo Chamada terceirizada:
for %%G in (caqui, maca, tomate, framboesa, cereja) do (call:alter %%G "vermelho Borgonha")
echo -------------------------------------
echo.
pause
exit

:alter
call complemento.bat "%~1" "%~2"
goto:eof