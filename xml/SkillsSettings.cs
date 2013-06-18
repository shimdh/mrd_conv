using System.Xml.Serialization;


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public class SkillsSettings {
    
    private SkillsSettingsSkill[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Skill")]
    public SkillsSettingsSkill[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public class SkillsSettingsSkill {
    
    private string indexField;
    
    private string skillNameField;
    
    private int requiredLevelField;
    
    private int firstSkillLevelField;
    
    private int secondSkillLevelField;
    
    private int thirdSkillLevelField;
    
    private float damageField;
    
    private int affectedDistanceField;
    
    private int wideRangeField;
    
    private int coolDownTimeField;
    
    private float startAnimationTimeField;
    
    private float middleAnimationTimeField;
    
    private float endAnimationTimeField;
    
    private string defaultSkillDescriptionField;
    
    private string firstSkillDescriptionField;
    
    private string secondSkillDescriptionField;
    
    private string thirdSkillDescriptionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Index")]
    public string Index {
        get {
            return this.indexField;
        }
        set {
            this.indexField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SkillName")]
    public string SkillName {
        get {
            return this.skillNameField;
        }
        set {
            this.skillNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RequiredLevel")]
    public string RequiredLevel {
        get {
            return this.requiredLevelField;
        }
        set {
            this.requiredLevelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FirstSkillLevel")]
    public string FirstSkillLevel {
        get {
            return this.firstSkillLevelField;
        }
        set {
            this.firstSkillLevelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SecondSkillLevel")]
    public string SecondSkillLevel {
        get {
            return this.secondSkillLevelField;
        }
        set {
            this.secondSkillLevelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ThirdSkillLevel")]
    public string ThirdSkillLevel {
        get {
            return this.thirdSkillLevelField;
        }
        set {
            this.thirdSkillLevelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Damage")]
    public string Damage {
        get {
            return this.damageField;
        }
        set {
            this.damageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AffectedDistance")]
    public string AffectedDistance {
        get {
            return this.affectedDistanceField;
        }
        set {
            this.affectedDistanceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("WideRange")]
    public string WideRange {
        get {
            return this.wideRangeField;
        }
        set {
            this.wideRangeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CoolDownTime")]
    public string CoolDownTime {
        get {
            return this.coolDownTimeField;
        }
        set {
            this.coolDownTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("StartAnimationTime")]
    public string StartAnimationTime {
        get {
            return this.startAnimationTimeField;
        }
        set {
            this.startAnimationTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MiddleAnimationTime")]
    public string MiddleAnimationTime {
        get {
            return this.middleAnimationTimeField;
        }
        set {
            this.middleAnimationTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("EndAnimationTime")]
    public string EndAnimationTime {
        get {
            return this.endAnimationTimeField;
        }
        set {
            this.endAnimationTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DefaultSkillDescription")]
    public string DefaultSkillDescription {
        get {
            return this.defaultSkillDescriptionField;
        }
        set {
            this.defaultSkillDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FirstSkillDescription")]
    public string FirstSkillDescription {
        get {
            return this.firstSkillDescriptionField;
        }
        set {
            this.firstSkillDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SecondSkillDescription")]
    public string SecondSkillDescription {
        get {
            return this.secondSkillDescriptionField;
        }
        set {
            this.secondSkillDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ThirdSkillDescription")]
    public string ThirdSkillDescription {
        get {
            return this.thirdSkillDescriptionField;
        }
        set {
            this.thirdSkillDescriptionField = value;
        }
    }
}
