# -*- coding: utf-8 -*-


class WriteChildCSFile():
    def __init__(self, class_name):
        self.csChildStringList = []
        self.class_name = class_name

    def writeUsingState(self):
        using_stat = 'using'
        self.csChildStringList.append(using_stat + ' System.Collections;')
        self.csChildStringList.append(using_stat + ' System.Collections.Generic;')

    def writeBeginClassState(self):
        self.csChildStringList.append("public class " + self.class_name + " {")
        self.csChildStringList.append("\tpublic Dictionary<string, string> statusValues;")
        self.csChildStringList.append("}")

    def getStringList(self):
        self.writeUsingState()
        self.csChildStringList.append('')
        self.writeBeginClassState()

        return self.csChildStringList


class WriteCSFile():
    def __init__(self, class_name, sub_plural, tag_plural, class_comment, items_names, status_keys, status_keys_korean,
                 items_description):
        self.enum_tag = 'TagNames'
        self.tag_plural = tag_plural
        self.sub_plural = sub_plural
        self.origin_name = class_name
        self.class_name = sub_plural + tag_plural + 'SettingsXML'
        self.enum_index = sub_plural + tag_plural + 'Indexes'
        self.class_comment = class_comment
        self.array_description = class_name + 'Description'
        self.csStringList = []
        self.status_keys = status_keys
        self.status_keys_korean = status_keys_korean
        self.items_description = items_description
        self.items_names = items_names

    def writeUsingState(self):
        using_stat = 'using'
        self.csStringList.append(using_stat + ' UnityEngine;')
        self.csStringList.append(using_stat + ' System.Collections;')
        self.csStringList.append(using_stat + ' System.Collections.Generic;')
        self.csStringList.append(using_stat + ' System.Text;')
        self.csStringList.append(using_stat + ' System.Xml;')
        self.csStringList.append(using_stat + ' System.IO;')
        self.csStringList.append(using_stat + ' System;')

    def writeBeginClassState(self):

        self.csStringList.append(self.class_comment.encode('utf-8'))
        self.csStringList.append("public class " + self.class_name + " : MonoBehaviour {")

    def writeEndClassState(self):
        self.csStringList.append("}")

    def writeEnumIndexes(self):
        self.csStringList.append("\tpublic enum " + self.enum_index + " {")
        for idx, p_name in enumerate(self.items_names):
            if self.items_description is not None:
                self.csStringList.append("\t\t" + p_name + "," + " // " + self.items_description[idx].encode('utf-8'))
            else:
                self.csStringList.append("\t\t" + p_name + ",")

        self.csStringList.append("\t};")

    def writeArrayDescriptions(self):
        if self.items_description is None:
            return
        self.csStringList.append("\tpublic string[] " + self.array_description + " = {")
        for p_name in self.items_description:
            self.csStringList.append("\t\t\"" + p_name.encode('utf-8') + "\",")
        self.csStringList.append("\t};")

    def writeEnumTags(self):
        self.csStringList.append("\tpublic enum " + self.enum_tag + " {")
        for idx, p_key in enumerate(self.status_keys):
            #csStringList.append("\t\t" + p_key + "," + " // " + statusKeysKorean[idx])
            self.csStringList.append("\t\t" + p_key + "," + " // " + self.status_keys_korean[idx].encode('utf-8'))
        self.csStringList.append("\t};")

    def writeVariables(self):
        self.csStringList.append("\tprivate Dictionary<string, string> statusValues;")
        self.csStringList.append(
            "\tprivate string " + self.sub_plural.lower() + self.tag_plural + "SettingsTag = \"" + self.origin_name + "\";")
        self.csStringList.append("\tpublic TextAsset GameAsset;")
        self.csStringList.append(
            "\tpublic List<" + self.origin_name + "Settings> " + self.sub_plural.lower() + self.tag_plural + "Settings;")

    def writeStartMethod(self):
        self.csStringList.append("\tvoid Start() {")
        self.csStringList.append("\t\t//GetStatusValue();")
        self.csStringList.append(
            "\t\t//foreach(" + self.origin_name + "Settings pSettings in " + self.sub_plural.lower() + self.tag_plural + "Settings) {")
        self.csStringList.append(
            "\t\t\t//Debug.Log(\"Name: \" + pSettings.statusValues[Enum.GetName(typeof(TagNames), TagNames.Name)]);")
        self.csStringList.append("\t\t//}")
        self.csStringList.append("\t}")

    def writeGetStatusValue(self):
        self.csStringList.append("\tpublic void GetStatusValue() {")

        self.csStringList.append("\t\tXmlDocument xmlDoc = new XmlDocument();")
        self.csStringList.append("\t\txmlDoc.LoadXml(GameAsset.text);")
        self.csStringList.append(
            "\t\tXmlNodeList setting_values = xmlDoc.GetElementsByTagName(" + self.sub_plural.lower() + self.tag_plural + "SettingsTag);")
        self.csStringList.append(
            "\t\t" + self.sub_plural.lower() + self.tag_plural + "Settings = new List<" + self.origin_name + "Settings>();")
        self.csStringList.append("\t\tforeach (XmlNode setting_value in setting_values) {")

        self.csStringList.append("\t\t\tXmlNodeList status_contents = setting_value.ChildNodes;")
        self.csStringList.append(
            "\t\t\t" + self.origin_name + "Settings " + self.origin_name.lower() + "Settings = new " + self.origin_name + "Settings();")
        self.csStringList.append(
            "\t\t\t" + self.origin_name.lower() + "Settings.statusValues = new Dictionary<string, string>();")
        self.csStringList.append("\t\t\tforeach (XmlNode status_content in status_contents) {")

        self.csStringList.append("\t\t\t\tforeach (string tag_name in Enum.GetNames(typeof(TagNames))) {")
        self.csStringList.append("\t\t\t\t\tif (status_content.Name == tag_name) {")

        self.csStringList.append(
            "\t\t\t\t\t\t" + self.origin_name.lower() + "Settings.statusValues.Add(tag_name, status_content.InnerText);")
        self.csStringList.append("\t\t\t\t\t}")
        self.csStringList.append("\t\t\t\t}")
        self.csStringList.append("\t\t\t}")
        self.csStringList.append(
            "\t\t\t" + self.sub_plural.lower() + self.tag_plural + "Settings.Add(" + self.origin_name.lower() + "Settings);")
        self.csStringList.append("\t\t}")
        self.csStringList.append("\t}")

    def writeParseStatusValue(self):
        self.csStringList.append("\tpublic string GetStringStatus(" + self.enum_index + " kind, " + self.enum_tag + " tag) {")
        self.csStringList.append("\t\treturn " + self.sub_plural.lower() + self.tag_plural + "Settings[(int)kind].statusValues[Enum.GetName(typeof(" + self.enum_tag + "), tag)];")
        self.csStringList.append("\t}")
        self.csStringList.append("")
        self.csStringList.append("\tpublic int GetIntStatus(" + self.enum_index + " kind, " + self.enum_tag + " tag) {")
        self.csStringList.append("\t\treturn (int)float.Parse(" + self.sub_plural.lower() + self.tag_plural + "Settings[(int)kind].statusValues[Enum.GetName(typeof(" + self.enum_tag + "), tag)]);")
        self.csStringList.append("\t}")
        self.csStringList.append("")
        self.csStringList.append("\tpublic float GetFloatStatus(" + self.enum_index + " kind, " + self.enum_tag + " tag) {")
        self.csStringList.append("\t\treturn float.Parse(" + self.sub_plural.lower() + self.tag_plural + "Settings[(int)kind].statusValues[Enum.GetName(typeof(" + self.enum_tag + "), tag)]);")
        self.csStringList.append("\t}")
        self.csStringList.append("")

    def getStringList(self):
        self.writeUsingState()
        self.csStringList.append('')
        self.writeBeginClassState()
        self.csStringList.append('')
        self.writeEnumIndexes()
        self.csStringList.append('')
        self.writeArrayDescriptions()
        self.csStringList.append('')
        self.writeEnumTags()
        self.csStringList.append('')
        self.writeVariables()
        self.csStringList.append('')
        self.writeStartMethod()
        self.csStringList.append('')
        self.writeGetStatusValue()
        self.csStringList.append('')
        self.writeParseStatusValue()
        self.csStringList.append('')
        self.writeEndClassState()

        return self.csStringList


class WriteCSFileWithoutDescription():
    def __init__(self, class_name, sub_plural, tag_plural, class_comment, items_names, status_keys, status_keys_korean):
        self.enum_tag = 'TagNames'
        self.tag_plural = tag_plural
        self.sub_plural = sub_plural
        self.origin_name = class_name
        self.class_name = sub_plural + tag_plural + 'SettingsXML'
        self.enum_index = sub_plural + tag_plural + 'Indexes'
        self.class_comment = class_comment
        self.csStringList = []
        self.status_keys = status_keys
        self.status_keys_korean = status_keys_korean
        self.items_names = items_names

    def writeUsingState(self):
        using_stat = 'using'
        self.csStringList.append(using_stat + ' UnityEngine;')
        self.csStringList.append(using_stat + ' System.Collections;')
        self.csStringList.append(using_stat + ' System.Collections.Generic;')
        self.csStringList.append(using_stat + ' System.Text;')
        self.csStringList.append(using_stat + ' System.Xml;')
        self.csStringList.append(using_stat + ' System.IO;')
        self.csStringList.append(using_stat + ' System;')

    def writeBeginClassState(self):
        self.csStringList.append(self.class_comment.encode('utf-8'))
        self.csStringList.append("public class " + self.class_name + " : MonoBehaviour {")

    def writeEndClassState(self):
        self.csStringList.append("}")

    def writeEnumIndexes(self):
        self.csStringList.append("\tpublic enum " + self.enum_index + " {")
        for idx, p_name in enumerate(self.items_names):
            self.csStringList.append("\t\t" + p_name + ",")
        self.csStringList.append("\t};")

    def writeEnumTags(self):
        self.csStringList.append("\tpublic enum " + self.enum_tag + " {")
        for idx, p_key in enumerate(self.status_keys):
            #csStringList.append("\t\t" + p_key + "," + " // " + statusKeysKorean[idx])
            self.csStringList.append("\t\t" + p_key + "," + " // " + self.status_keys_korean[idx].encode('utf-8'))
        self.csStringList.append("\t};")

    def writeVariables(self):
        self.csStringList.append("\tprivate Dictionary<string, string> statusValues;")
        self.csStringList.append(
            "\tprivate string " + self.sub_plural.lower() + self.tag_plural + "SettingsTag = \"" + self.origin_name + "\";")
        self.csStringList.append("\tpublic TextAsset GameAsset;")
        self.csStringList.append(
            "\tpublic List<" + self.origin_name + "Settings> " + self.sub_plural.lower() + self.tag_plural + "Settings;")

    def writeStartMethod(self):
        self.csStringList.append("\tvoid Start() {")
        self.csStringList.append("\t\t//GetStatusValue();")
        self.csStringList.append(
            "\t\t//foreach(" + self.origin_name + "Settings pSettings in " + self.sub_plural.lower() + self.tag_plural + "Settings) {")
        self.csStringList.append(
            "\t\t\t//Debug.Log(\"Name: \" + pSettings.statusValues[Enum.GetName(typeof(TagNames), TagNames.Name)]);")
        self.csStringList.append("\t\t//}")
        self.csStringList.append("\t}")

    def writeGetStatusValue(self):
        self.csStringList.append("\tpublic void GetStatusValue() {")

        self.csStringList.append("\t\tXmlDocument xmlDoc = new XmlDocument();")
        self.csStringList.append("\t\txmlDoc.LoadXml(GameAsset.text);")
        self.csStringList.append(
            "\t\tXmlNodeList setting_values = xmlDoc.GetElementsByTagName(" + self.sub_plural.lower() + self.tag_plural + "SettingsTag);")
        self.csStringList.append(
            "\t\t" + self.sub_plural.lower() + self.tag_plural + "Settings = new List<" + self.origin_name + "Settings>();")
        self.csStringList.append("\t\tforeach (XmlNode setting_value in setting_values) {")

        self.csStringList.append("\t\t\tXmlNodeList status_contents = setting_value.ChildNodes;")
        self.csStringList.append(
            "\t\t\t" + self.origin_name + "Settings " + self.origin_name.lower() + "Settings = new " + self.origin_name + "Settings();")
        self.csStringList.append(
            "\t\t\t" + self.origin_name.lower() + "Settings.statusValues = new Dictionary<string, string>();")
        self.csStringList.append("\t\t\tforeach (XmlNode status_content in status_contents) {")

        self.csStringList.append("\t\t\t\tforeach (string tag_name in Enum.GetNames(typeof(TagNames))) {")
        self.csStringList.append("\t\t\t\t\tif (status_content.Name == tag_name) {")

        self.csStringList.append(
            "\t\t\t\t\t\t" + self.origin_name.lower() + "Settings.statusValues.Add(tag_name, status_content.InnerText);")
        self.csStringList.append("\t\t\t\t\t}")
        self.csStringList.append("\t\t\t\t}")
        self.csStringList.append("\t\t\t}")
        self.csStringList.append(
            "\t\t\t" + self.sub_plural.lower() + self.tag_plural + "Settings.Add(" + self.origin_name.lower() + "Settings);")
        self.csStringList.append("\t\t}")
        self.csStringList.append("\t}")

    def writeParseStatusValue(self):
        self.csStringList.append("\tpublic string GetStringStatus(" + self.enum_index + " kind, " + self.enum_tag + " tag) {")
        self.csStringList.append("\t\treturn " + self.sub_plural.lower() + self.tag_plural + "Settings[(int)kind].statusValues[Enum.GetName(typeof(" + self.enum_tag + "), tag)];")
        self.csStringList.append("\t}")
        self.csStringList.append("")
        self.csStringList.append("\tpublic int GetIntStatus(" + self.enum_index + " kind, " + self.enum_tag + " tag) {")
        self.csStringList.append("\t\treturn (int)float.Parse(" + self.sub_plural.lower() + self.tag_plural + "Settings[(int)kind].statusValues[Enum.GetName(typeof(" + self.enum_tag + "), tag)]);")
        self.csStringList.append("\t}")
        self.csStringList.append("")
        self.csStringList.append("\tpublic float GetFloatStatus(" + self.enum_index + " kind, " + self.enum_tag + " tag) {")
        self.csStringList.append("\t\treturn float.Parse(" + self.sub_plural.lower() + self.tag_plural + "Settings[(int)kind].statusValues[Enum.GetName(typeof(" + self.enum_tag + "), tag)]);")
        self.csStringList.append("\t}")
        self.csStringList.append("")

    def getStringList(self):
        self.writeUsingState()
        self.csStringList.append('')
        self.writeBeginClassState()
        self.csStringList.append('')
        self.writeEnumIndexes()
        self.csStringList.append('')
        self.writeEnumTags()
        self.csStringList.append('')
        self.writeVariables()
        self.csStringList.append('')
        self.writeStartMethod()
        self.csStringList.append('')
        self.writeGetStatusValue()
        self.csStringList.append('')
        self.writeParseStatusValue()
        self.csStringList.append('')
        self.writeEndClassState()

        return self.csStringList
