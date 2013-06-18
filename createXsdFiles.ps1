Get-ChildItem .\xml\*.xml | ForEach-Object {    
    .\xml\xsd.exe $_.FullName /o:'.\xml' /classes
}