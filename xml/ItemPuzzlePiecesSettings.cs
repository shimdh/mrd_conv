using System.Xml.Serialization;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public class ItemPuzzlePiecesSettings {
    
    private ItemPuzzlePiecesSettingsItemPuzzlePiece[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemPuzzlePiece"]
    public ItemPuzzlePiecesSettingsItemPuzzlePiece[] Items {
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
public class ItemPuzzlePiecesSettingsItemPuzzlePiece {
    
    private string indexField;
    
    private string nameField;
    
    private string baseIndexField;
    
    private float pieceLocationField;
    
    private float conditionField;
    
    private string zoneIndexField;
    
    private float normalMonsterCountField;
    
    private float bossMonsterCountField;
    
    private float fileldDropRateField;
    
    private float fishingCountField;
    
    private float pirateShipCountField;
    
    private float fishingDropRateField;
    
    private string iconNameField;
    
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
    [System.Xml.Serialization.XmlElementAttribute("BaseIndex")]
    public string BaseIndex {
        get {
            return this.baseIndexField;
        }
        set {
            this.baseIndexField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PieceLocation")]
    public float PieceLocation {
        get {
            return this.pieceLocationField;
        }
        set {
            this.pieceLocationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Condition")]
    public float Condition {
        get {
            return this.conditionField;
        }
        set {
            this.conditionField = value;
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
    [System.Xml.Serialization.XmlElementAttribute("NormalMonsterCount")]
    public float NormalMonsterCount {
        get {
            return this.normalMonsterCountField;
        }
        set {
            this.normalMonsterCountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BossMonsterCount")]
    public float BossMonsterCount {
        get {
            return this.bossMonsterCountField;
        }
        set {
            this.bossMonsterCountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FileldDropRate")]
    public float FileldDropRate {
        get {
            return this.fileldDropRateField;
        }
        set {
            this.fileldDropRateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FishingCount")]
    public float FishingCount {
        get {
            return this.fishingCountField;
        }
        set {
            this.fishingCountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PirateShipCount")]
    public float PirateShipCount {
        get {
            return this.pirateShipCountField;
        }
        set {
            this.pirateShipCountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FishingDropRate")]
    public float FishingDropRate {
        get {
            return this.fishingDropRateField;
        }
        set {
            this.fishingDropRateField = value;
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
