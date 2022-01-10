@echo off
For /R arquivos\ %%G IN (*.txt) do copy "%%G" arquivos2
pause