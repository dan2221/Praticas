@echo off

for /f %%a in ('dir mods\*.txt /b /a-d ^|find /c /v ""') do set count=%%a
echo %count%

pause
exit