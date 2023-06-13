@echo off

set "file_path=.\VideohubSimulator"
set "target_file=BmdVideoHub.exe"

set "zipname=VideohubSimulator_v1.0.1_debug.zip"

if exist "%file_path" (
    	echo Simulator already downloaded...
) else (
	echo creating directory...
	mkdir %file_path%

	echo Downloading Videohub Simulator...
	powershell.exe -ExecutionPolicy Bypass -File download_simulator.ps1
	
	echo unzip archive...
	powershell -Command "Expand-Archive -Path '.\%zipname%' -DestinationPath %file_path%"
	
	echo cleanup...
	rm %zipname%
)