using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System;

// 스킬석정보 얻기 
public class SkillStonesSettingsXML : MonoBehaviour {

	public enum SkillStonesIndexes {
		skill_stone_effect_01, // 1레벨 스킬석 효과
		skill_stone_effect_02, // 2레벨 스킬석 효과
		skill_stone_effect_03, // 3레벨 스킬석 효과
		skill_stone_effect_04, // 4레벨 스킬석 효과
		skill_stone_effect_05, // 5레벨 스킬석 효과
		skill_stone_effect_06, // 6레벨 스킬석 효과
		skill_stone_effect_07, // 7레벨 스킬석 효과
		skill_stone_effect_08, // 8레벨 스킬석 효과
		skill_stone_effect_09, // 9레벨 스킬석 효과
		skill_stone_effect_10, // 10레벨 스킬석 효과
	};

	public string[] SkillStoneDescription = {
		"1레벨 스킬석 효과",
		"2레벨 스킬석 효과",
		"3레벨 스킬석 효과",
		"4레벨 스킬석 효과",
		"5레벨 스킬석 효과",
		"6레벨 스킬석 효과",
		"7레벨 스킬석 효과",
		"8레벨 스킬석 효과",
		"9레벨 스킬석 효과",
		"10레벨 스킬석 효과",
	};

	public enum TagNames {
		Index, // 인덱스
		Name, // 이름
		SkillStoneLevel, // 스킬석 레벨
		WideRangeSkillRecoveryBeadRatio, // 광역 스킬 회복구슬 회복량(%)
		WideRangeSkillDownTime, // 광역 스킬 다운시간(초)
		WideRangeSkillCoolDownTime, // 광역 스킬 쿨타임 시간(초)
		WideRangeSkillDamageIncreasingRatio, // 광역 스킬 데미지증폭(%)
		RushSkillMovementSpeedDecreasingTime, // 돌진 스킬 이동속도 감소 시간(초)
		RushSkillBloodSuckingRatio, // 돌진 스킬 흡혈량(%)
		RushSkillCoolDownTime, // 돌진 스킬 쿨타임 시간(초)
		RushSkillDamageIncreasingRatio, // 돌진 스킬 데미지증폭(%)
		WhirlWindSkillChargingSpeedDecreasingTime, // 휠윈드 스킬 차지 속도 감소 시간(초)
		WhirlWindSkillChargingMovementSpeedIncreasingRatio, // 휠윈드 스킬 차지시 이동속도 증가(%)
		WhirlWindSkillRevCount, // 휠윈드 스킬 회전수
		WhirlWindSkillDamageIncreasingRatio, // 휠윈드 스킬 데미지증폭(%)
		CriticalAttackRatio, // 치명타 확률(%)
		BlockRatio, // 방어력(%)
		CriticalAttackDamageRatio, // 치명타시 데미지량(%)
		CriticalAttackRecoveryHP, // 치명타시 HP회복
		IncreasingHPRatio, // HP량 증폭(%)
	};

	private Dictionary<string, string> statusValues;
	private string skillstonesSettingsTag = "SkillStone";
	public TextAsset GameAsset;
	public List<SkillStoneSettings> skillstonesSettings;

	void Start() {
		//GetStatusValue();
		//foreach(SkillStoneSettings pSettings in skillstonesSettings) {
			//Debug.Log("Name: " + pSettings.statusValues[Enum.GetName(typeof(TagNames), TagNames.Name)]);
		//}
	}

	public void GetStatusValue() {
		XmlDocument xmlDoc = new XmlDocument();
		xmlDoc.LoadXml(GameAsset.text);
		XmlNodeList setting_values = xmlDoc.GetElementsByTagName(skillstonesSettingsTag);
		skillstonesSettings = new List<SkillStoneSettings>();
		foreach (XmlNode setting_value in setting_values) {
			XmlNodeList status_contents = setting_value.ChildNodes;
			SkillStoneSettings skillstoneSettings = new SkillStoneSettings();
			skillstoneSettings.statusValues = new Dictionary<string, string>();
			foreach (XmlNode status_content in status_contents) {
				foreach (string tag_name in Enum.GetNames(typeof(TagNames))) {
					if (status_content.Name == tag_name) {
						skillstoneSettings.statusValues.Add(tag_name, status_content.InnerText);
					}
				}
			}
			skillstonesSettings.Add(skillstoneSettings);
		}
	}

	public string GetStringStatus(SkillStonesIndexes kind, TagNames tag) {
		return skillstonesSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)];
	}

	public int GetIntStatus(SkillStonesIndexes kind, TagNames tag) {
		return (int)float.Parse(skillstonesSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}

	public float GetFloatStatus(SkillStonesIndexes kind, TagNames tag) {
		return float.Parse(skillstonesSettings[(int)kind].statusValues[Enum.GetName(typeof(TagNames), tag)]);
	}


}