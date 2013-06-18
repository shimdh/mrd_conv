using System.Xml.Serialization;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public class BossSkillsSettings {

    private BossSkillsSettingsBossSkill[] itemsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BossSkill")]
    public BossSkillsSettingsBossSkill[] Items {
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
public class BossSkillsSettingsBossSkill : XmlData {

    private string indexField;

    private string descriptionField;

    private float skillTypeField;

    private float skillCheckingDistanceField;

    private float coolDownTimeField;

    private float castingTimeField;

    private float damageRateField;

    private float damageMovingSpeedField;

    private float damageAreaWidthField;

    private float damageAreaLengthField;

    private float damageAreaDurationTimeField;

    private float unprotectedTimeField;

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
    [System.Xml.Serialization.XmlElementAttribute("Description")]
    public string Description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SkillType")]
    public float SkillType {
        get {
            return this.skillTypeField;
        }
        set {
            this.skillTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SkillCheckingDistance")]
    public float SkillCheckingDistance {
        get {
            return this.skillCheckingDistanceField;
        }
        set {
            this.skillCheckingDistanceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CoolDownTime")]
    public float CoolDownTime {
        get {
            return this.coolDownTimeField;
        }
        set {
            this.coolDownTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CastingTime")]
    public float CastingTime {
        get {
            return this.castingTimeField;
        }
        set {
            this.castingTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DamageRate")]
    public float DamageRate {
        get {
            return this.damageRateField;
        }
        set {
            this.damageRateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DamageMovingSpeed")]
    public float DamageMovingSpeed {
        get {
            return this.damageMovingSpeedField;
        }
        set {
            this.damageMovingSpeedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DamageAreaWidth")]
    public float DamageAreaWidth {
        get {
            return this.damageAreaWidthField;
        }
        set {
            this.damageAreaWidthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DamageAreaLength")]
    public float DamageAreaLength {
        get {
            return this.damageAreaLengthField;
        }
        set {
            this.damageAreaLengthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DamageAreaDurationTime")]
    public float DamageAreaDurationTime {
        get {
            return this.damageAreaDurationTimeField;
        }
        set {
            this.damageAreaDurationTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("UnprotectedTime")]
    public float UnprotectedTime {
        get {
            return this.unprotectedTimeField;
        }
        set {
            this.unprotectedTimeField = value;
        }
    }
}
