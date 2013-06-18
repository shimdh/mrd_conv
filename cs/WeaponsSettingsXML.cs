using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System;

// 무기정보 얻기 
public class WeaponsSettingsXML : MonoBehaviour {

	public enum WeaponsIndexes {
		weapon_01, // 큐피티안의 무기
		weapon_02, // 큐피티안의 무기
	};

	public string[] WeaponDescription = {
		"큐피티안의 무기",
		"큐피티안의 무기",
	};

	public enum TagNames {
		Index, // 인덱스
		Name, // 이름
		WeaponLevel, // 무기 레벨
		NextLevelIndex, // 다음 단계 무기 인덱스
		AttackPoint, // 공격력
		MaxEXP, // 최대경험치
		IconName, // 아이콘 파일명
		Mash, // 연결 매쉬
		Description, // 설명글
	};

	private Dictionary<string, string> statusValues;
	private string weaponsSettingsTag = "Weapon";
	public TextAsset GameAsset;
	public List<WeaponSettings> weaponsSettings;

	void Start() {
		//GetStatusValue();
		//foreach(WeaponSettings pSettings in weaponsSettings) {
			//Debug.Log("Name: " + pSettings.statusValues[Enum.GetName(typeof(TagNames), TagNames.Name)]);
		//}
	}

	public void GetStatusValue() {
		XmlDocument xmlDoc = new XmlDocument();
		xmlDoc.LoadXml(GameAsset.text);
		XmlNodeList setting_values = xmlDoc.GetElementsByTagName(weaponsSettingsTag);
		weaponsSettings = new List<WeaponSettings>();
		foreach (XmlNode setting_value in setting_values) {
			XmlNodeList status_contents = setting_value.ChildNodes;
			WeaponSettings weaponSettings = new WeaponSettings();
			weaponSettings.statusValues = new Dictionary<string, string>();
			foreach (XmlNode status_content in status_contents) {
				foreach (string tag_name in Enum.GetNames(typeof(TagNames))) {
					if (status_content.Name == tag_name) {
						weaponSettings.statusValues.Add(tag_name, status_content.InnerText);
					}
				}
			}
			weaponsSettings.Add(weaponSettings);
		}
	}

	public string GetStringStatus(WeaponsIndexes kind, TagNames tag) {
		return weaponsSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)];
	}

	public int GetIntStatus(WeaponsIndexes kind, TagNames tag) {
		return (int)float.Parse(weaponsSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}

	public float GetFloatStatus(WeaponsIndexes kind, TagNames tag) {
		return float.Parse(weaponsSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}


}