@echo off

cls
for %%G in (
	massa
	raposa
	chinelo
) do (
	set palavra=super %%G azul
	set missigno= missing number
)
echo %%G
echo a palavra final eh %palavra%
echo %missigno%
pause