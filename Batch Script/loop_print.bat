@echo off
set /A Image_Width=104
for /l %%X in (25, 1, 127) do (
	call:Reduce %%X
)
pause
exit

:Reduce
set /A Image_Width-=1
echo %~1 representa %Image_Width%
goto:eof

rem for %%G in (
rem	/crop=(x,y,w,h)
rem	tools\IrfanView\i_view32.exe  C:\JOGOS\SORRv5\Tools\cortar.png /crop=(0,0,100,6) /convert=C:\JOGOS\SORRv5\Tools\lifebar\cortado.png
