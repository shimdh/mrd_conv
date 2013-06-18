using System.Xml.Serialization;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public class PlayerLevelsSettings {
    
    private PlayerLevelsSettingsPlayerLevel[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PlayerLevel")]
    public PlayerLevelsSettingsPlayerLevel[] Items {
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
public class PlayerLevelsSettingsPlayerLevel {
    
    private string nameField;
    
    private int maxHPField;
    
    private int maxEXPField;
    
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
    [System.Xml.Serialization.XmlElementAttribute("MaxHP")]
    public string MaxHP {
        get {
            return this.maxHPField;
        }
        set {
            this.maxHPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MaxEXP")]
    public string MaxEXP {
        get {
            return this.maxEXPField;
        }
        set {
            this.maxEXPField = value;
        }
    }
}
