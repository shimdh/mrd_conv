using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System;

// 스킬 슬롯 정보 얻기 
public class SkillSlotsSettingsXML : MonoBehaviour {

	public enum SkillSlotsIndexes {
		active_around_01, // 광역 1번째 슬롯
		active_around_02, // 광역 2번째 슬롯
		active_around_03, // 광역 3번째 슬롯
		active_dash_01, // 돌진 1번째 슬롯
		active_dash_02, // 돌진 2번째 슬롯
		active_dash_03, // 돌진 3번째 슬롯
		active_whirlwind_01, // 휠윈드 1번째 슬롯
		active_whirlwind_02, // 휠윈드 2번째 슬롯
		active_whirlwind_03, // 휠윈드 3번째 슬롯
		passive_critical_rate_01, // 패시브 1번째 슬롯
		passive_defence_rate_01, // 패시브 2번째 슬롯
		passive_critical_damage_01, // 패시브 3번째 슬롯
		passive_critical_heal_01, // 패시브 4번째 슬롯
	};

	public string[] SkillSlotDescription = {
		"광역 1번째 슬롯",
		"광역 2번째 슬롯",
		"광역 3번째 슬롯",
		"돌진 1번째 슬롯",
		"돌진 2번째 슬롯",
		"돌진 3번째 슬롯",
		"휠윈드 1번째 슬롯",
		"휠윈드 2번째 슬롯",
		"휠윈드 3번째 슬롯",
		"패시브 1번째 슬롯",
		"패시브 2번째 슬롯",
		"패시브 3번째 슬롯",
		"패시브 4번째 슬롯",
	};

	public enum TagNames {
		Index, // 인덱스
		Name, // 이름
		RequiredLevel, // 슬롯 개방 레벨
		Description, // 슬롯 설명
	};

	private Dictionary<string, string> statusValues;
	private string skillslotsSettingsTag = "SkillSlot";
	public TextAsset GameAsset;
	public List<SkillSlotSettings> skillslotsSettings;

	void Start() {
		//GetStatusValue();
		//foreach(SkillSlotSettings pSettings in skillslotsSettings) {
			//Debug.Log("Name: " + pSettings.statusValues[Enum.GetName(typeof(TagNames), TagNames.Name)]);
		//}
	}

	public void GetStatusValue() {
		XmlDocument xmlDoc = new XmlDocument();
		xmlDoc.LoadXml(GameAsset.text);
		XmlNodeList setting_values = xmlDoc.GetElementsByTagName(skillslotsSettingsTag);
		skillslotsSettings = new List<SkillSlotSettings>();
		foreach (XmlNode setting_value in setting_values) {
			XmlNodeList status_contents = setting_value.ChildNodes;
			SkillSlotSettings skillslotSettings = new SkillSlotSettings();
			skillslotSettings.statusValues = new Dictionary<string, string>();
			foreach (XmlNode status_content in status_contents) {
				foreach (string tag_name in Enum.GetNames(typeof(TagNames))) {
					if (status_content.Name == tag_name) {
						skillslotSettings.statusValues.Add(tag_name, status_content.InnerText);
					}
				}
			}
			skillslotsSettings.Add(skillslotSettings);
		}
	}

	public string GetStringStatus(SkillSlotsIndexes kind, TagNames tag) {
		return skillslotsSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)];
	}

	public int GetIntStatus(SkillSlotsIndexes kind, TagNames tag) {
		return (int)float.Parse(skillslotsSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}

	public float GetFloatStatus(SkillSlotsIndexes kind, TagNames tag) {
		return float.Parse(skillslotsSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}


}