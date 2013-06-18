Get-ChildItem .\xml\*.xml | ForEach-Object {    
    (Get-Content $_.FullName -Encoding UTF8) | Set-Content -Encoding UTF8 -Path $_.FullName
}