@echo off
cls
set a[0]=1 
set a[1]=2 
set a[2]=3 
set a[3]=4 
set a[4]=5 
set a[5]=6 
set a[6]=7 
echo The first element of the array is %a[0]% 
echo The second element of the array is %a[1]% 
echo The third element of the array is %a[2]%
echo.
echo Array completo: %a%
echo.
set /p opcao=Digite o valor do array

echo %a[%opcao%]%

pause
pause