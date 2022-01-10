@echo off
echo This is a test> myfile.txt
echo 123>> myfile.txt
echo 245.67>> myfile.txt

echo Veja o arquivo!
myfile.txt

echo. 2>myfile.txt

cls
echo veja se foi limpado!
myfile.txt

echo Creating a file with a list of all files in current directory...
echo. 2>all_present_files.txt

for /f tokens^=* %%i in ('WHERE /r "arquivos" *.*')do (
	if exist "arquivos\%%~nxi" (
		echo "%%~nxi">> all_present_files.txt
	)
)
echo.
echo Check the file!
all_present_files.txt
pause