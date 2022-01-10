@echo off
CALL :Display 5 , 10
pause
goto fim


:Display
echo The value of parameter 1 is %~1
echo The value of parameter 2 is %~2
goto:eof

:fim