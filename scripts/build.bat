@echo off
REM Build di rilascio della soluzione
dotnet build Catalog.sln -c Release
if errorlevel 1 exit /b 1
