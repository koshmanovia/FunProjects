@echo off

"C:\MyProg\VS\projects\Apress\head 2\SimpleSCharpApp2.0\bin\Debug\SimpleSCharpApp2.0.exe" -arg1 /arg2 

@if %errorlevel% == "0" goto success

:fail

echo this application has failed!
echo return value = %ERRORLEVEL%
GOTO END

:success
echo this application has successed!
echo return value = %ERRORLEVEL%
GOTO END
:end
echo All Done
pause