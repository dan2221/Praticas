@echo off
set /p number=Defina o numero:
set /a even=number %% 2
if %even%==0 (echo numero par) else (echo numero impar)
pause