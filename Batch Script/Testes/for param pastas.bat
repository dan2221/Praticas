@echo off
For %%G IN (
	shiva
) do (
	move "data\%%G"	chars
	echo %%G
)
pause