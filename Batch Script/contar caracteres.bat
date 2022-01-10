@ECHO OFF
set "file=lorem.txt"
echo File choosed: %file%
echo.
for %%i in (%file%) do @set count=%%~zi
echo this file has %count% characters including whitespaces and special chars like line-feed/carriage-return etc.
echo.
pause