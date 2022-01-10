@echo off
cls

set /A valor=1
for %%G in (1 35,5 52,6 53,11 63) do (
	call:bgm_off %%G
)
pause
exit

:bgm_off
if %valor% equ 1 (
	echo arquivo %~1 tipo 1
	set /A valor=2
) else (
	echo arquivo %~1 tipo 2
	set /A valor=1
)
goto:eof