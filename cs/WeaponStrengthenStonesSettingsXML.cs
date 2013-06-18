using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System;

// 무기강화석 정보 얻기 
public class WeaponStrengthenStonesSettingsXML : MonoBehaviour {

	public enum WeaponStrengthenStonesIndexes {
		weapon_upgrade_01, // 무기 강화석
	};

	public string[] WeaponStrengthenStoneDescription = {
		"무기 강화석",
	};

	public enum TagNames {
		Index, // 인덱스
		Name, // 이름
		ChargedEXP, // 충전 경험치
		IconName, // 아이콘 파일명
		Description, // 설명글
	};

	private Dictionary<string, string> statusValues;
	private string weaponstrengthenstonesSettingsTag = "WeaponStrengthenStone";
	public TextAsset GameAsset;
	public List<WeaponStrengthenStoneSettings> weaponstrengthenstonesSettings;

	void Start() {
		//GetStatusValue();
		//foreach(WeaponStrengthenStoneSettings pSettings in weaponstrengthenstonesSettings) {
			//Debug.Log("Name: " + pSettings.statusValues[Enum.GetName(typeof(TagNames), TagNames.Name)]);
		//}
	}

	public void GetStatusValue() {
		XmlDocument xmlDoc = new XmlDocument();
		xmlDoc.LoadXml(GameAsset.text);
		XmlNodeList setting_values = xmlDoc.GetElementsByTagName(weaponstrengthenstonesSettingsTag);
		weaponstrengthenstonesSettings = new List<WeaponStrengthenStoneSettings>();
		foreach (XmlNode setting_value in setting_values) {
			XmlNodeList status_contents = setting_value.ChildNodes;
			WeaponStrengthenStoneSettings weaponstrengthenstoneSettings = new WeaponStrengthenStoneSettings();
			weaponstrengthenstoneSettings.statusValues = new Dictionary<string, string>();
			foreach (XmlNode status_content in status_contents) {
				foreach (string tag_name in Enum.GetNames(typeof(TagNames))) {
					if (status_content.Name == tag_name) {
						weaponstrengthenstoneSettings.statusValues.Add(tag_name, status_content.InnerText);
					}
				}
			}
			weaponstrengthenstonesSettings.Add(weaponstrengthenstoneSettings);
		}
	}

	public string GetStringStatus(WeaponStrengthenStonesIndexes kind, TagNames tag) {
		return weaponstrengthenstonesSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)];
	}

	public int GetIntStatus(WeaponStrengthenStonesIndexes kind, TagNames tag) {
		return (int)float.Parse(weaponstrengthenstonesSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}

	public float GetFloatStatus(WeaponStrengthenStonesIndexes kind, TagNames tag) {
		return float.Parse(weaponstrengthenstonesSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}


}