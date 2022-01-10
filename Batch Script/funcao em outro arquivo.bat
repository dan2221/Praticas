@echo off
cls

set /A count=0
set /A arqnum=2
for %%G in (1 35,5 52,6 53,11 63) do (
	echo valor dentro: %arqnum%
	if %arqnum% equ 2 (
		set /A count+=1
		call:change
	) else (
		call:change
	)
)
echo.
echo contador de 2: %count%
echo.
echo opcao atual %arqnum%
pause
exit

:change
echo ----------
if %arqnum% equ 2 (set /A arqnum=1) else (
	if %arqnum% equ 1 (set /A arqnum=2)
)
echo valor alterado para: %arqnum%
echo ----------
goto:eof