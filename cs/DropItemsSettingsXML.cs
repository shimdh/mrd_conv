using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System;

// 드롭 아이템 정보 얻기 
public class DropItemsSettingsXML : MonoBehaviour {

	public enum DropItemsIndexes {
		Fishing,
		Drop_Impomen_Atype,
	};


	public enum TagNames {
		Index, // 인덱스
		ItemIndex_1, // 아이템 인덱스_1
		Count_1, // 개수_1
		Rate_1, // 확률_1
		ItemIndex_2, // 아이템 인덱스_2
		Count_2, // 개수_2
		Rate_2, // 확률_2
		ItemIndex_3, // 아이템 인덱스_3
		Count_3, // 개수_3
		Rate_3, // 확률_3
		ItemIndex_4, // 아이템 인덱스_4
		Count_4, // 개수_4
		Rate_4, // 확률_4
		ItemIndex_5, // 아이템 인덱스_5
		Count_5, // 개수_5
		Rate_5, // 확률_5
		ItemIndex_6, // 아이템 인덱스_6
		Count_6, // 개수_6
		Rate_6, // 확률_6
		ItemIndex_7, // 아이템 인덱스_7
		Count_7, // 개수_7
		Rate_7, // 확률_7
		ItemIndex_8, // 아이템 인덱스_8
		Count_8, // 개수_8
		Rate_8, // 확률_8
		ItemIndex_9, // 아이템 인덱스_9
		Count_9, // 개수_9
		Rate_9, // 확률_9
		ItemIndex_10, // 아이템 인덱스_10
		Count_10, // 개수_10
		Rate_10, // 확률_10
	};

	private Dictionary<string, string> statusValues;
	private string dropitemsSettingsTag = "DropItem";
	public TextAsset GameAsset;
	public List<DropItemSettings> dropitemsSettings;

	void Start() {
		//GetStatusValue();
		//foreach(DropItemSettings pSettings in dropitemsSettings) {
			//Debug.Log("Name: " + pSettings.statusValues[Enum.GetName(typeof(TagNames), TagNames.Name)]);
		//}
	}

	public void GetStatusValue() {
		XmlDocument xmlDoc = new XmlDocument();
		xmlDoc.LoadXml(GameAsset.text);
		XmlNodeList setting_values = xmlDoc.GetElementsByTagName(dropitemsSettingsTag);
		dropitemsSettings = new List<DropItemSettings>();
		foreach (XmlNode setting_value in setting_values) {
			XmlNodeList status_contents = setting_value.ChildNodes;
			DropItemSettings dropitemSettings = new DropItemSettings();
			dropitemSettings.statusValues = new Dictionary<string, string>();
			foreach (XmlNode status_content in status_contents) {
				foreach (string tag_name in Enum.GetNames(typeof(TagNames))) {
					if (status_content.Name == tag_name) {
						dropitemSettings.statusValues.Add(tag_name, status_content.InnerText);
					}
				}
			}
			dropitemsSettings.Add(dropitemSettings);
		}
	}

	public string GetStringStatus(DropItemsIndexes kind, TagNames tag) {
		return dropitemsSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)];
	}

	public int GetIntStatus(DropItemsIndexes kind, TagNames tag) {
		return (int)float.Parse(dropitemsSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}

	public float GetFloatStatus(DropItemsIndexes kind, TagNames tag) {
		return float.Parse(dropitemsSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}


}