using System.Xml.Serialization;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public class ItemSkillStonesSettings {
    
    private ItemSkillStonesSettingsItemSkillStone[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemSkillStone")]
    public ItemSkillStonesSettingsItemSkillStone[] Items {
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
public class ItemSkillStonesSettingsItemSkillStone {
    
    private string indexField;
    
    private string nameField;
    
    private int skillStoneLevelField;
    
    private string nextSkillStoneLevelField;
    
    private int activePassiveField;
    
    private string descriptionField;
    
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
    [System.Xml.Serialization.XmlElementAttribute("SkillStoneLevel")]
    public string SkillStoneLevel {
        get {
            return this.skillStoneLevelField;
        }
        set {
            this.skillStoneLevelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NextSkillStoneLevel")]
    public string NextSkillStoneLevel {
        get {
            return this.nextSkillStoneLevelField;
        }
        set {
            this.nextSkillStoneLevelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ActivePassive")]
    public string ActivePassive {
        get {
            return this.activePassiveField;
        }
        set {
            this.activePassiveField = value;
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
}
