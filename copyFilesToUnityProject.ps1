$unityProjectScrDir = 'C:\Users\Public\Documents\Unity Projects\maerd_xml\Assets\Scripts'
$unityProjectXmlDir = 'C:\Users\Public\Documents\Unity Projects\maerd_xml\Assets\Resources\XmlData'
Copy-Item -Path .\cs\*.cs -Destination $unityProjectScrDir
Copy-Item -Path .\xml\*.xml -Destination $unityProjectXmlDir