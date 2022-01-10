@echo off
For /R arquivos\ %%G IN (*.txt) do Echo "%%G"
pause