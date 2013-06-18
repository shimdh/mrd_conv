using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System;

// 스킬정보 얻기 
public class SkillsSettingsXML : MonoBehaviour {

	public enum SkillsIndexes {
		active_around, // 지면강타
		active_dash, // 공간돌파
		active_whirlwind, // 회전베기
		passive_critical_rate, // 치명타확률
		passive_defence_rate, // 방어력
		passive_critical_damage, // 치명타대미지
		passive_critical_heal, // 흡혈
	};

	public string[] SkillDescription = {
		"지면강타",
		"공간돌파",
		"회전베기",
		"치명타확률",
		"방어력",
		"치명타대미지",
		"흡혈",
	};

	public enum TagNames {
		Index, // 인덱스
		SkillName, // 기본 스킬 이름
		RequiredLevel, // 스킬 획득레벨(0:이벤트)
		FirstSkillLevel, // 1차 스킬 진화 레벨
		SecondSkillLevel, // 2차 스킬 진화 레벨
		ThirdSkillLevel, // 3차 스킬 진화 레벨
		Damage, // 스킬 데미지(무기의 %)
		AffectedDistance, // 사정거리
		WideRange, // 광역범위
		CoolDownTime, // 쿨다운 타임(초)
		StartAnimationTime, // 시작 애니메이션 조절(기준1)
		MiddleAnimationTime, // 중간 애니메이션 조절(기준1)
		EndAnimationTime, // 끝 애니메이션 조절(기준1)
		DefaultSkillDescription, // 기본 스킬 설명
		FirstSkillDescription, // 1차 스킬 설명
		SecondSkillDescription, // 2차 스킬 설명
		ThirdSkillDescription, // 3차 스킬 설명
	};

	private Dictionary<string, string> statusValues;
	private string skillsSettingsTag = "Skill";
	public TextAsset GameAsset;
	public List<SkillSettings> skillsSettings;

	void Start() {
		//GetStatusValue();
		//foreach(SkillSettings pSettings in skillsSettings) {
			//Debug.Log("Name: " + pSettings.statusValues[Enum.GetName(typeof(TagNames), TagNames.Name)]);
		//}
	}

	public void GetStatusValue() {
		XmlDocument xmlDoc = new XmlDocument();
		xmlDoc.LoadXml(GameAsset.text);
		XmlNodeList setting_values = xmlDoc.GetElementsByTagName(skillsSettingsTag);
		skillsSettings = new List<SkillSettings>();
		foreach (XmlNode setting_value in setting_values) {
			XmlNodeList status_contents = setting_value.ChildNodes;
			SkillSettings skillSettings = new SkillSettings();
			skillSettings.statusValues = new Dictionary<string, string>();
			foreach (XmlNode status_content in status_contents) {
				foreach (string tag_name in Enum.GetNames(typeof(TagNames))) {
					if (status_content.Name == tag_name) {
						skillSettings.statusValues.Add(tag_name, status_content.InnerText);
					}
				}
			}
			skillsSettings.Add(skillSettings);
		}
	}

	public string GetStringStatus(SkillsIndexes kind, TagNames tag) {
		return skillsSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)];
	}

	public int GetIntStatus(SkillsIndexes kind, TagNames tag) {
		return (int)float.Parse(skillsSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}

	public float GetFloatStatus(SkillsIndexes kind, TagNames tag) {
		return float.Parse(skillsSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}


}