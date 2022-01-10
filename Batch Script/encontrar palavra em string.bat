@echo off
echo AxelMazShiva|find "Maz" >nul
if errorlevel 1 (echo notfound) else (echo found)
echo.
echo AxelMazShiva|find "Blaze" >nul
if errorlevel 1 (echo notfound) else (echo found)
echo.
pause
exit