using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System;

// 퀘스트 조건 정보 얻기 
public class QuestConditionsSettingsXML : MonoBehaviour {

	public enum QuestConditionsIndexes {
		quest_01, // 아이템 획득
	};

	public string[] QuestConditionDescription = {
		"아이템 획득",
	};

	public enum TagNames {
		Index, // 인덱스
		Name, // 이름
		QuestCondition, // 퀘스트 조건
		Description, // 설명글
	};

	private Dictionary<string, string> statusValues;
	private string questconditionsSettingsTag = "QuestCondition";
	public TextAsset GameAsset;
	public List<QuestConditionSettings> questconditionsSettings;

	void Start() {
		//GetStatusValue();
		//foreach(QuestConditionSettings pSettings in questconditionsSettings) {
			//Debug.Log("Name: " + pSettings.statusValues[Enum.GetName(typeof(TagNames), TagNames.Name)]);
		//}
	}

	public void GetStatusValue() {
		XmlDocument xmlDoc = new XmlDocument();
		xmlDoc.LoadXml(GameAsset.text);
		XmlNodeList setting_values = xmlDoc.GetElementsByTagName(questconditionsSettingsTag);
		questconditionsSettings = new List<QuestConditionSettings>();
		foreach (XmlNode setting_value in setting_values) {
			XmlNodeList status_contents = setting_value.ChildNodes;
			QuestConditionSettings questconditionSettings = new QuestConditionSettings();
			questconditionSettings.statusValues = new Dictionary<string, string>();
			foreach (XmlNode status_content in status_contents) {
				foreach (string tag_name in Enum.GetNames(typeof(TagNames))) {
					if (status_content.Name == tag_name) {
						questconditionSettings.statusValues.Add(tag_name, status_content.InnerText);
					}
				}
			}
			questconditionsSettings.Add(questconditionSettings);
		}
	}

	public string GetStringStatus(QuestConditionsIndexes kind, TagNames tag) {
		return questconditionsSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)];
	}

	public int GetIntStatus(QuestConditionsIndexes kind, TagNames tag) {
		return (int)float.Parse(questconditionsSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}

	public float GetFloatStatus(QuestConditionsIndexes kind, TagNames tag) {
		return float.Parse(questconditionsSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}


}