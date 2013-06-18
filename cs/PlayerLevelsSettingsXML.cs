using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System;

// 플레이어 레벨정보 얻기 
public class PlayerLevelsSettingsXML : MonoBehaviour {

	public enum PlayerLevelsIndexes {
		Level1,
		Level2,
		Level3,
		Level4,
		Level5,
		Level6,
		Level7,
		Level8,
		Level9,
		Level10,
		Level11,
		Level12,
		Level13,
		Level14,
		Level15,
		Level16,
		Level17,
		Level18,
		Level19,
		Level20,
	};

	public enum TagNames {
		Name, // 인덱스(문자열)
		MaxHP, // 최대 생명치
		MaxEXP, // 다음레벨에 필요한 경험치
	};

	private Dictionary<string, string> statusValues;
	private string playerlevelsSettingsTag = "PlayerLevel";
	public TextAsset GameAsset;
	public List<PlayerLevelSettings> playerlevelsSettings;

	void Start() {
		//GetStatusValue();
		//foreach(PlayerLevelSettings pSettings in playerlevelsSettings) {
			//Debug.Log("Name: " + pSettings.statusValues[Enum.GetName(typeof(TagNames), TagNames.Name)]);
		//}
	}

	public void GetStatusValue() {
		XmlDocument xmlDoc = new XmlDocument();
		xmlDoc.LoadXml(GameAsset.text);
		XmlNodeList setting_values = xmlDoc.GetElementsByTagName(playerlevelsSettingsTag);
		playerlevelsSettings = new List<PlayerLevelSettings>();
		foreach (XmlNode setting_value in setting_values) {
			XmlNodeList status_contents = setting_value.ChildNodes;
			PlayerLevelSettings playerlevelSettings = new PlayerLevelSettings();
			playerlevelSettings.statusValues = new Dictionary<string, string>();
			foreach (XmlNode status_content in status_contents) {
				foreach (string tag_name in Enum.GetNames(typeof(TagNames))) {
					if (status_content.Name == tag_name) {
						playerlevelSettings.statusValues.Add(tag_name, status_content.InnerText);
					}
				}
			}
			playerlevelsSettings.Add(playerlevelSettings);
		}
	}

	public string GetStringStatus(PlayerLevelsIndexes kind, TagNames tag) {
		return playerlevelsSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)];
	}

	public int GetIntStatus(PlayerLevelsIndexes kind, TagNames tag) {
		return (int)float.Parse(playerlevelsSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}

	public float GetFloatStatus(PlayerLevelsIndexes kind, TagNames tag) {
		return float.Parse(playerlevelsSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}


}