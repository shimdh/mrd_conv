using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System;

// 스킬석 정보 얻기 
public class ItemSkillStonesSettingsXML : MonoBehaviour {

	public enum ItemSkillStonesIndexes {
		active_skillstone_01, // 붉은 꿈의 파편
		active_skillstone_02, // 붉은 꿈의 파편
		active_skillstone_03, // 붉은 꿈의 파편
		active_skillstone_04, // 붉은 꿈의 파편
		active_skillstone_05, // 붉은 꿈의 파편
		active_skillstone_06, // 붉은 꿈의 파편
		active_skillstone_07, // 붉은 꿈의 파편
		active_skillstone_08, // 붉은 꿈의 파편
		active_skillstone_09, // 붉은 꿈의 파편
		active_skillstone_10, // 붉은 꿈의 파편
		passive_skillstone_01, // 푸른 꿈의 파편
		passive_skillstone_02, // 푸른 꿈의 파편
		passive_skillstone_03, // 푸른 꿈의 파편
		passive_skillstone_04, // 푸른 꿈의 파편
		passive_skillstone_05, // 푸른 꿈의 파편
		passive_skillstone_06, // 푸른 꿈의 파편
		passive_skillstone_07, // 푸른 꿈의 파편
		passive_skillstone_08, // 푸른 꿈의 파편
		passive_skillstone_09, // 푸른 꿈의 파편
		passive_skillstone_10, // 푸른 꿈의 파편
	};

	public string[] ItemSkillStoneDescription = {
		"붉은 꿈의 파편",
		"붉은 꿈의 파편",
		"붉은 꿈의 파편",
		"붉은 꿈의 파편",
		"붉은 꿈의 파편",
		"붉은 꿈의 파편",
		"붉은 꿈의 파편",
		"붉은 꿈의 파편",
		"붉은 꿈의 파편",
		"붉은 꿈의 파편",
		"푸른 꿈의 파편",
		"푸른 꿈의 파편",
		"푸른 꿈의 파편",
		"푸른 꿈의 파편",
		"푸른 꿈의 파편",
		"푸른 꿈의 파편",
		"푸른 꿈의 파편",
		"푸른 꿈의 파편",
		"푸른 꿈의 파편",
		"푸른 꿈의 파편",
	};

	public enum TagNames {
		Index, // 인덱스
		Name, // 이름
		SkillStoneLevel, // 스킬석 레벨
		NextSkillStoneLevel, // 다음 단계 스킬석 인덱스
		ActivePassive, // 액티브1/패시브2
		Description, // 설명
	};

	private Dictionary<string, string> statusValues;
	private string itemskillstonesSettingsTag = "ItemSkillStone";
	public TextAsset GameAsset;
	public List<ItemSkillStoneSettings> itemskillstonesSettings;

	void Start() {
		//GetStatusValue();
		//foreach(ItemSkillStoneSettings pSettings in itemskillstonesSettings) {
			//Debug.Log("Name: " + pSettings.statusValues[Enum.GetName(typeof(TagNames), TagNames.Name)]);
		//}
	}

	public void GetStatusValue() {
		XmlDocument xmlDoc = new XmlDocument();
		xmlDoc.LoadXml(GameAsset.text);
		XmlNodeList setting_values = xmlDoc.GetElementsByTagName(itemskillstonesSettingsTag);
		itemskillstonesSettings = new List<ItemSkillStoneSettings>();
		foreach (XmlNode setting_value in setting_values) {
			XmlNodeList status_contents = setting_value.ChildNodes;
			ItemSkillStoneSettings itemskillstoneSettings = new ItemSkillStoneSettings();
			itemskillstoneSettings.statusValues = new Dictionary<string, string>();
			foreach (XmlNode status_content in status_contents) {
				foreach (string tag_name in Enum.GetNames(typeof(TagNames))) {
					if (status_content.Name == tag_name) {
						itemskillstoneSettings.statusValues.Add(tag_name, status_content.InnerText);
					}
				}
			}
			itemskillstonesSettings.Add(itemskillstoneSettings);
		}
	}

	public string GetStringStatus(ItemSkillStonesIndexes kind, TagNames tag) {
		return itemskillstonesSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)];
	}

	public int GetIntStatus(ItemSkillStonesIndexes kind, TagNames tag) {
		return (int)float.Parse(itemskillstonesSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}

	public float GetFloatStatus(ItemSkillStonesIndexes kind, TagNames tag) {
		return float.Parse(itemskillstonesSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}


}