@ECHO OFF &SETLOCAL
echo Concatenar contagem:
SET /a count=5
for /l %%a in (1,1,%count%) do call set "Myvar=%%Myvar%%, %%a"
ECHO %Myvar:~2%

set "Myvar="
echo.
echo Concatenar nomes:
for %%G in ("axel", "blaze", "adam") do call set "Myvar=%%Myvar%%, %%G"
ECHO %Myvar:~2%
echo.
echo Concatenar sem FOR:
call set "Myvar=%%Myvar%%, "Zan""
ECHO %Myvar:~2%
echo.
pause
exit /b

