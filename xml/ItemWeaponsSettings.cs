using System.Xml.Serialization;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public class ItemWeaponsSettings {

    private ItemWeaponsSettingsItemWeapon[] itemsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemWeapon")]
    public ItemWeaponsSettingsItemWeapon[] Items {
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
public class ItemWeaponsSettingsItemWeapon : XmlData{

    private string indexField;

    private string nameField;

    private float weaponLevelField;

    private string nextLevelIndexField;

    private float typeField;

    private float attackPointField;

    private float maxEXPField;

    private string iconNameField;

    private string mashField;

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
    [System.Xml.Serialization.XmlElementAttribute("WeaponLevel")]
    public float WeaponLevel {
        get {
            return this.weaponLevelField;
        }
        set {
            this.weaponLevelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NextLevelIndex")]
    public string NextLevelIndex {
        get {
            return this.nextLevelIndexField;
        }
        set {
            this.nextLevelIndexField = value;
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
    [System.Xml.Serialization.XmlElementAttribute("MaxEXP")]
    public float MaxEXP {
        get {
            return this.maxEXPField;
        }
        set {
            this.maxEXPField = value;
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
    [System.Xml.Serialization.XmlElementAttribute("Mash")]
    public string Mash {
        get {
            return this.mashField;
        }
        set {
            this.mashField = value;
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
