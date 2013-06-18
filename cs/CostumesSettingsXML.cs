using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System;

// 코스튬정보 얻기 
public class CostumesSettingsXML : MonoBehaviour {

	public enum CostumesIndexes {
		impomen_weapon_01, // 임포멘의 무기
		impomen_helmet_01, // 임포멘의 투구
		impomen_armor_01, // 임포멘의 갑옷
		impomen_cloak_01, // 임포멘의 망토
	};

	public string[] CostumeDescription = {
		"임포멘의 무기",
		"임포멘의 투구",
		"임포멘의 갑옷",
		"임포멘의 망토",
	};

	public enum TagNames {
		Index, // 인덱스
		Name, // 이름
		SetPart, // 세트 구분자
		AddingActingPower, // 최대 행동력 추가(추가 능력치)
		WearLocation, // 코스튬 장착위치(1: 무기, 2: 투구, 3: 갑옷, 4: 망토)
		IconName, // 아이콘 파일명
		Mash, // 연결 매쉬
		Description, // 설명글
	};

	private Dictionary<string, string> statusValues;
	private string costumesSettingsTag = "Costume";
	public TextAsset GameAsset;
	public List<CostumeSettings> costumesSettings;

	void Start() {
		//GetStatusValue();
		//foreach(CostumeSettings pSettings in costumesSettings) {
			//Debug.Log("Name: " + pSettings.statusValues[Enum.GetName(typeof(TagNames), TagNames.Name)]);
		//}
	}

	public void GetStatusValue() {
		XmlDocument xmlDoc = new XmlDocument();
		xmlDoc.LoadXml(GameAsset.text);
		XmlNodeList setting_values = xmlDoc.GetElementsByTagName(costumesSettingsTag);
		costumesSettings = new List<CostumeSettings>();
		foreach (XmlNode setting_value in setting_values) {
			XmlNodeList status_contents = setting_value.ChildNodes;
			CostumeSettings costumeSettings = new CostumeSettings();
			costumeSettings.statusValues = new Dictionary<string, string>();
			foreach (XmlNode status_content in status_contents) {
				foreach (string tag_name in Enum.GetNames(typeof(TagNames))) {
					if (status_content.Name == tag_name) {
						costumeSettings.statusValues.Add(tag_name, status_content.InnerText);
					}
				}
			}
			costumesSettings.Add(costumeSettings);
		}
	}

	public string GetStringStatus(CostumesIndexes kind, TagNames tag) {
		return costumesSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)];
	}

	public int GetIntStatus(CostumesIndexes kind, TagNames tag) {
		return (int)float.Parse(costumesSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}

	public float GetFloatStatus(CostumesIndexes kind, TagNames tag) {
		return float.Parse(costumesSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}


}