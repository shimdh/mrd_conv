Get-ChildItem .\xml\*.xsd | ForEach-Object {    
    .\xml\xsd.exe $_.FullName /o:'.\xml' /classes
}