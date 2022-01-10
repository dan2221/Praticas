@echo off
for /L %%i in (%start%,1,%end%) do (
   set /A j=%%i + 4
   call set elem[%%i]=%%elem[!j!]%%
)
pause