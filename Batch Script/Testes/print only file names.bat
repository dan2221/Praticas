@echo off
echo Pritando arquivos neste diretorio:
for /f tokens^=* %%i in ('where .:*')do echo %%~nxi
echo.
echo Apenas os nomes dos arquivos sem extensao e diretorio:
for %%f in ("arquivos\*.txt") do @echo %%~nf
echo.
echo Apenas os nomes dos arquivos com extensao:
for /f tokens^=* %%i in ('WHERE /r "%~dp0\arquivos" *.*')do echo %%~nxi

pause

rem os caracteres entranhos servem pra eliminar a extensão do arquivo.