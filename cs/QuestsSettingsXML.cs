using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System;

// 퀘스트 정보 얻기 
public class QuestsSettingsXML : MonoBehaviour {

	public enum QuestsIndexes {
		first_quest, // 첫번째 퀘스트
	};

	public string[] QuestDescription = {
		"첫번째 퀘스트",
	};

	public enum TagNames {
		Index, // 인덱스
		Name, // 이름
		QuestCondition1, // 퀘스트 조건 인덱스1
		QuestCondition2, // 퀘스트 조건 인덱스2
		QuestCondition3, // 퀘스트 조건 인덱스3
		QuestCondition4, // 퀘스트 조건 인덱스4
		QuestCondition5, // 퀘스트 조건 인덱스5
		QuestCondition6, // 퀘스트 조건 인덱스6
		QuestCondition7, // 퀘스트 조건 인덱스7
		Description, // 설명글
	};

	private Dictionary<string, string> statusValues;
	private string questsSettingsTag = "Quest";
	public TextAsset GameAsset;
	public List<QuestSettings> questsSettings;

	void Start() {
		//GetStatusValue();
		//foreach(QuestSettings pSettings in questsSettings) {
			//Debug.Log("Name: " + pSettings.statusValues[Enum.GetName(typeof(TagNames), TagNames.Name)]);
		//}
	}

	public void GetStatusValue() {
		XmlDocument xmlDoc = new XmlDocument();
		xmlDoc.LoadXml(GameAsset.text);
		XmlNodeList setting_values = xmlDoc.GetElementsByTagName(questsSettingsTag);
		questsSettings = new List<QuestSettings>();
		foreach (XmlNode setting_value in setting_values) {
			XmlNodeList status_contents = setting_value.ChildNodes;
			QuestSettings questSettings = new QuestSettings();
			questSettings.statusValues = new Dictionary<string, string>();
			foreach (XmlNode status_content in status_contents) {
				foreach (string tag_name in Enum.GetNames(typeof(TagNames))) {
					if (status_content.Name == tag_name) {
						questSettings.statusValues.Add(tag_name, status_content.InnerText);
					}
				}
			}
			questsSettings.Add(questSettings);
		}
	}

	public string GetStringStatus(QuestsIndexes kind, TagNames tag) {
		return questsSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)];
	}

	public int GetIntStatus(QuestsIndexes kind, TagNames tag) {
		return (int)float.Parse(questsSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}

	public float GetFloatStatus(QuestsIndexes kind, TagNames tag) {
		return float.Parse(questsSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}


}