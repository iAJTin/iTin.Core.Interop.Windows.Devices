@ECHO OFF
CLS

rmdir ..\documentation /s /q

xmldocmd ..\src\bin\Debug\netstandard2.0\iTin.Core.Interop.Windows.Devices.dll ..\documentation --toc

PAUSE
