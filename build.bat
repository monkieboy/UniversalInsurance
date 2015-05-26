@echo off
cls
".paket\paket" update
"packages\FAKE\tools\Fake.exe" build.fsx