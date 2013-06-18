using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System;

// 플레이어정보 얻기 
public class PlayersSettingsXML : MonoBehaviour {

	public enum PlayersIndexes {
		Player1,
	};

	public enum TagNames {
		Name, // 이름
		Sex, // 성별(남성1/여성2)
		DefaultAttackDistance, // 기본 공격거리
		DefaultAttackAngle, // 기본 공격각도(도)
		DefaultAttackSpeed1, // 기본 공속 1타(초)
		DefaultAttackSpeed2, // 기본 공속 2타(초)
		DefaultAttackSpeed3, // 기본 공속 3타(초)
		DefaultAttackDelay, // 기본 공속 딜레이(초)
		MovingSpeed, // 이동속도
		AdditionalHP, // 추가생명력
		BlockPoint, // 방어력(%)
		CriticalAttackRate, // 치명타확률(%)
		CriticalAttackDamage, // 치명타시 대미지(%)
		CriticalAttackRecoveryPoint, // 치명타시 회복량
	};

	private Dictionary<string, string> statusValues;
	private string playersSettingsTag = "Player";
	public TextAsset GameAsset;
	public List<PlayerSettings> playersSettings;

	void Start() {
		//GetStatusValue();
		//foreach(PlayerSettings pSettings in playersSettings) {
			//Debug.Log("Name: " + pSettings.statusValues[Enum.GetName(typeof(TagNames), TagNames.Name)]);
		//}
	}

	public void GetStatusValue() {
		XmlDocument xmlDoc = new XmlDocument();
		xmlDoc.LoadXml(GameAsset.text);
		XmlNodeList setting_values = xmlDoc.GetElementsByTagName(playersSettingsTag);
		playersSettings = new List<PlayerSettings>();
		foreach (XmlNode setting_value in setting_values) {
			XmlNodeList status_contents = setting_value.ChildNodes;
			PlayerSettings playerSettings = new PlayerSettings();
			playerSettings.statusValues = new Dictionary<string, string>();
			foreach (XmlNode status_content in status_contents) {
				foreach (string tag_name in Enum.GetNames(typeof(TagNames))) {
					if (status_content.Name == tag_name) {
						playerSettings.statusValues.Add(tag_name, status_content.InnerText);
					}
				}
			}
			playersSettings.Add(playerSettings);
		}
	}

	public string GetStringStatus(PlayersIndexes kind, TagNames tag) {
		return playersSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)];
	}

	public int GetIntStatus(PlayersIndexes kind, TagNames tag) {
		return (int)float.Parse(playersSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}

	public float GetFloatStatus(PlayersIndexes kind, TagNames tag) {
		return float.Parse(playersSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}


}