rem FOR /F "tokens=2 delims= " %%P IN ('tasklist ^| findstr /i fiddler') DO  echo TaskKill.exe /f /PID %%P
for /f %%i in ('where fiddler ^| findstr /i fiddler.exe') do cd %%~dpiScripts
xcopy %1 . /y