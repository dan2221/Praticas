@echo off
setlocal EnableDelayedExpansion
set elem[1]=First element
set elem[2]=Second one
set elem[3]=The third one
set i=2
echo !elem[%i%]!
pause