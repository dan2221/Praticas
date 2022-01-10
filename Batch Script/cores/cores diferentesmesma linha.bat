@echo off
cls

echo | set /p dummyName=ser de direita eh 
call:cor 1a "Correto"
echo.
echo | set /p dummyName=ser de esquerda eh 
call:cor 1c "Errado"
pause


exit
:cor
>%2 (set/p=.) <&1
findstr /a:%1 . %2 con &erase %2
for /f "delims=" %%a in ('cmd /k prompt $h$h ^<^&1') do echo %%a
goto:eof