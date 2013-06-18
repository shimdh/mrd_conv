using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System;

// 적정보 얻기 
public class EnemiesSettingsXML : MonoBehaviour {

	public enum EnemiesIndexes {
		sweeper_a1,
	};

	public enum TagNames {
		Name, // 인덱스(문자열)
		Description, // 이름
		Level, // 레벨
		DefaultAttackDistance, // 기본 공격거리
		DefaultAttackAngle, // 기본 공격각도(도)
		DefaultAttackSpeed1, // 기본공속 1타(초)
		DefaultAttackSpeed2, // 기본공속 2타(초)
		DefaultAttackSpeed3, // 기본공속 3타(초)
		MovingSpeed, // 이동속도
		MaxHP, // 최대생명력
		AttackPoint, // 공격력
		BlockPoint, // 방어력(%)
		AccuracyRate, // 명중률(%)
		ExperiencePoint, // 경험치
		DropItemIndex, // 드롭 아이템 인덱스
	};

	private Dictionary<string, string> statusValues;
	private string enemiesSettingsTag = "Enemy";
	public TextAsset GameAsset;
	public List<EnemySettings> enemiesSettings;

	void Start() {
		//GetStatusValue();
		//foreach(EnemySettings pSettings in enemiesSettings) {
			//Debug.Log("Name: " + pSettings.statusValues[Enum.GetName(typeof(TagNames), TagNames.Name)]);
		//}
	}

	public void GetStatusValue() {
		XmlDocument xmlDoc = new XmlDocument();
		xmlDoc.LoadXml(GameAsset.text);
		XmlNodeList setting_values = xmlDoc.GetElementsByTagName(enemiesSettingsTag);
		enemiesSettings = new List<EnemySettings>();
		foreach (XmlNode setting_value in setting_values) {
			XmlNodeList status_contents = setting_value.ChildNodes;
			EnemySettings enemySettings = new EnemySettings();
			enemySettings.statusValues = new Dictionary<string, string>();
			foreach (XmlNode status_content in status_contents) {
				foreach (string tag_name in Enum.GetNames(typeof(TagNames))) {
					if (status_content.Name == tag_name) {
						enemySettings.statusValues.Add(tag_name, status_content.InnerText);
					}
				}
			}
			enemiesSettings.Add(enemySettings);
		}
	}

	public string GetStringStatus(EnemiesIndexes kind, TagNames tag) {
		return enemiesSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)];
	}

	public int GetIntStatus(EnemiesIndexes kind, TagNames tag) {
		return (int)float.Parse(enemiesSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}

	public float GetFloatStatus(EnemiesIndexes kind, TagNames tag) {
		return float.Parse(enemiesSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}


}