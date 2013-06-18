using System.Xml.Serialization;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public class PlayersSettings {
    
    private PlayersSettingsPlayer[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Player")]
    public PlayersSettingsPlayer[] Items {
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
public class PlayersSettingsPlayer {
    
    private string nameField;
    
    private int sexField;
    
    private int defaultAttackDistanceField;
    
    private int defaultAttackAngleField;
    
    private float defaultAttackSpeed1Field;
    
    private float defaultAttackSpeed2Field;
    
    private float defaultAttackSpeed3Field;
    
    private float defaultAttackDelayField;
    
    private int movingSpeedField;
    
    private int additionalHPField;
    
    private float blockPointField;
    
    private float criticalAttackRateField;
    
    private float criticalAttackDamageField;
    
    private int criticalAttackRecoveryPointField;
    
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
    [System.Xml.Serialization.XmlElementAttribute("Sex")]
    public string Sex {
        get {
            return this.sexField;
        }
        set {
            this.sexField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DefaultAttackDistance")]
    public string DefaultAttackDistance {
        get {
            return this.defaultAttackDistanceField;
        }
        set {
            this.defaultAttackDistanceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DefaultAttackAngle")]
    public string DefaultAttackAngle {
        get {
            return this.defaultAttackAngleField;
        }
        set {
            this.defaultAttackAngleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DefaultAttackSpeed1")]
    public string DefaultAttackSpeed1 {
        get {
            return this.defaultAttackSpeed1Field;
        }
        set {
            this.defaultAttackSpeed1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DefaultAttackSpeed2")]
    public string DefaultAttackSpeed2 {
        get {
            return this.defaultAttackSpeed2Field;
        }
        set {
            this.defaultAttackSpeed2Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DefaultAttackSpeed3")]
    public string DefaultAttackSpeed3 {
        get {
            return this.defaultAttackSpeed3Field;
        }
        set {
            this.defaultAttackSpeed3Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DefaultAttackDelay")]
    public string DefaultAttackDelay {
        get {
            return this.defaultAttackDelayField;
        }
        set {
            this.defaultAttackDelayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MovingSpeed")]
    public string MovingSpeed {
        get {
            return this.movingSpeedField;
        }
        set {
            this.movingSpeedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AdditionalHP")]
    public string AdditionalHP {
        get {
            return this.additionalHPField;
        }
        set {
            this.additionalHPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BlockPoint")]
    public string BlockPoint {
        get {
            return this.blockPointField;
        }
        set {
            this.blockPointField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CriticalAttackRate")]
    public string CriticalAttackRate {
        get {
            return this.criticalAttackRateField;
        }
        set {
            this.criticalAttackRateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CriticalAttackDamage")]
    public string CriticalAttackDamage {
        get {
            return this.criticalAttackDamageField;
        }
        set {
            this.criticalAttackDamageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CriticalAttackRecoveryPoint")]
    public string CriticalAttackRecoveryPoint {
        get {
            return this.criticalAttackRecoveryPointField;
        }
        set {
            this.criticalAttackRecoveryPointField = value;
        }
    }
}
