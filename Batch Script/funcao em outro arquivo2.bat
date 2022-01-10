@echo off
cls

set /A count=0
set /A arqnum=1
for %%G in (1 35,5 52,6 53,11 63) do (
		call:change %%G
	)
)
echo.
echo contador: %count%
echo.
echo opcao atual %arqnum%
pause
exit

:change
echo valor atual: %arqnum%
if %arqnum% equ 2 (
	set snd2=%~1
	set /A arqnum=1
	set /A count+=1
	call funcao_arquivo.bat
) else (
	set snd1=%~1
	set /A arqnum=2
)
echo -----------------------------
echo valor alterado: %arqnum%
goto:eof