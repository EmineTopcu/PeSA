del PeSAExe.Zip
copy PeSA.Engine\bin\Debug\PeSAEngine.dll
copy PeSA.Windows\bin\Debug\PeSA.exe
"C:\Program Files\7-Zip\7z" a -tzip PeSAExe.zip @zipfiles.txt