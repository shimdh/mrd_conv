using System.Xml.Serialization;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public class EnemiesSettings {

    private EnemiesSettingsEnemy[] itemsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Enemy")]
    public EnemiesSettingsEnemy[] Items {
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
public class EnemiesSettingsEnemy : XmlData {

    private string nameField;

    private string descriptionField;

    private float typeField;

    private float levelField;

    private float defaultAttackDistanceField;

    private float defaultAttackAngleField;

    private float defaultAttackSpeed1Field;

    private float defaultAttackSpeed2Field;

    private float defaultAttackSpeed3Field;

    private float movingSpeedField;

    private float maxHPField;

    private float attackPointField;

    private float blockPointField;

    private float accuracyRateField;

    private float experiencePointField;

    private float costumeRateField;

    private string costumeIndex1Field;

    private string costumeIndex2Field;

    private string dropItemIndexField;

    private string aIIndexField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Name")]
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
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
    [System.Xml.Serialization.XmlElementAttribute("Type")]
    public float Type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Level")]
    public float Level {
        get {
            return this.levelField;
        }
        set {
            this.levelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DefaultAttackDistance")]
    public float DefaultAttackDistance {
        get {
            return this.defaultAttackDistanceField;
        }
        set {
            this.defaultAttackDistanceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DefaultAttackAngle")]
    public float DefaultAttackAngle {
        get {
            return this.defaultAttackAngleField;
        }
        set {
            this.defaultAttackAngleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DefaultAttackSpeed1")]
    public float DefaultAttackSpeed1 {
        get {
            return this.defaultAttackSpeed1Field;
        }
        set {
            this.defaultAttackSpeed1Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DefaultAttackSpeed2")]
    public float DefaultAttackSpeed2 {
        get {
            return this.defaultAttackSpeed2Field;
        }
        set {
            this.defaultAttackSpeed2Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DefaultAttackSpeed3")]
    public float DefaultAttackSpeed3 {
        get {
            return this.defaultAttackSpeed3Field;
        }
        set {
            this.defaultAttackSpeed3Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MovingSpeed")]
    public float MovingSpeed {
        get {
            return this.movingSpeedField;
        }
        set {
            this.movingSpeedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MaxHP")]
    public float MaxHP {
        get {
            return this.maxHPField;
        }
        set {
            this.maxHPField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AttackPoint")]
    public float AttackPoint {
        get {
            return this.attackPointField;
        }
        set {
            this.attackPointField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BlockPoint")]
    public float BlockPoint {
        get {
            return this.blockPointField;
        }
        set {
            this.blockPointField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AccuracyRate")]
    public float AccuracyRate {
        get {
            return this.accuracyRateField;
        }
        set {
            this.accuracyRateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ExperiencePoint")]
    public float ExperiencePoint {
        get {
            return this.experiencePointField;
        }
        set {
            this.experiencePointField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CostumeRate")]
    public float CostumeRate {
        get {
            return this.costumeRateField;
        }
        set {
            this.costumeRateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CostumeIndex1")]
    public string CostumeIndex1 {
        get {
            return this.costumeIndex1Field;
        }
        set {
            this.costumeIndex1Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CostumeIndex2")]
    public string CostumeIndex2 {
        get {
            return this.costumeIndex2Field;
        }
        set {
            this.costumeIndex2Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DropItemIndex")]
    public string DropItemIndex {
        get {
            return this.dropItemIndexField;
        }
        set {
            this.dropItemIndexField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AIIndex")]
    public string AIIndex {
        get {
            return this.aIIndexField;
        }
        set {
            this.aIIndexField = value;
        }
    }
}
