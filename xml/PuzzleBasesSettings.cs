using System.Xml.Serialization;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public class PuzzleBasesSettings {
    
    private PuzzleBasesSettingsPuzzleBase[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PuzzleBase")]
    public PuzzleBasesSettingsPuzzleBase[] Items {
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
public class PuzzleBasesSettingsPuzzleBase {
    
    private string indexField;
    
    private string nameField;
    
    private string zoneIndexField;
    
    private string requiredPuzzleField;
    
    private float pageOrderField;
    
    private float addingBehaviourPointField;
    
    private string iconNameField;
    
    private string storyField;
    
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
    [System.Xml.Serialization.XmlElementAttribute("ZoneIndex")]
    public string ZoneIndex {
        get {
            return this.zoneIndexField;
        }
        set {
            this.zoneIndexField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RequiredPuzzle")]
    public string RequiredPuzzle {
        get {
            return this.requiredPuzzleField;
        }
        set {
            this.requiredPuzzleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PageOrder")]
    public float PageOrder {
        get {
            return this.pageOrderField;
        }
        set {
            this.pageOrderField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AddingBehaviourPoint")]
    public float AddingBehaviourPoint {
        get {
            return this.addingBehaviourPointField;
        }
        set {
            this.addingBehaviourPointField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("IconName")]
    public string IconName {
        get {
            return this.iconNameField;
        }
        set {
            this.iconNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Story")]
    public string Story {
        get {
            return this.storyField;
        }
        set {
            this.storyField = value;
        }
    }
}
