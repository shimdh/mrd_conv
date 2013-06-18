$xmldata=[Xml](get-content .\xml\SkillsSettings.xml)
$skills = $xmldata.SkillsSettings.Skill
$skills | Select-Object -Property Index, DefaultSkillDescription | `
    Export-Csv -NoTypeInformation -Path .\xml\skill.csv -Encoding UTF8    