@echo off
SET "Name=VarName"
set VarName=nome da variavel
SET "%VarName%=VarValue"
set "VarName="
Echo %Varname%
pause