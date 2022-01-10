@echo off
For %%G IN (
	blaze fielding
) do (
	move "data\%%G"	chars
	echo %%G
)
pause