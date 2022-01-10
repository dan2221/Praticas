@echo off
set /A mario=0
set /A luigi=0
set /A browser=1

echo %%mario%%
pause
exit

For %%G IN (
	%mario%
	%luigi%
	%browser%
) do (
	if %%G EQU 1 (goto %%G)
)
echo nenhum identificado
pause
exit


:mario
echo mario ativado
pause
exit

:luigi
echo luigi ativado
pause
exit

:browser
echo browser ativado
pause
exit