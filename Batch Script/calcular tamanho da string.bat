@echo off

call:Count_Lenght Maz
call:Count_Lenght 2000
call:Count_Lenght "Axel Stone"

PAUSE
exit

:Count_Lenght
(echo "%~1" & echo.) | findstr /O . | more +1 | (set /P RESULT= & call exit /B %%RESULT%%)
set /A STRLENGTH=%ERRORLEVEL%-5
if %STRLENGTH% gtr 3 (echo %~1 maior que 3) else (echo %~1 menor que 3)
echo string "%~1" length = %STRLENGTH%
goto:eof