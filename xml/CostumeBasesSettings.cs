using System.Xml.Serialization;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public class CostumeBasesSettings {

    private CostumeBasesSettingsCostumeBase[] itemsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CostumeBase")]
    public CostumeBasesSettingsCostumeBase[] Items {
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
public class CostumeBasesSettingsCostumeBase : XmlData {

    private string indexField;

    private string nameField;

    private float cashField;

    private float rechargedCashDurationField;

    private string weaponIndexField;

    private string helmetIndexField;

    private string armorIndexField;

    private string cloakIndexField;

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
    [System.Xml.Serialization.XmlElementAttribute("Cash")]
    public float Cash {
        get {
            return this.cashField;
        }
        set {
            this.cashField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RechargedCashDuration")]
    public float RechargedCashDuration {
        get {
            return this.rechargedCashDurationField;
        }
        set {
            this.rechargedCashDurationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("WeaponIndex")]
    public string WeaponIndex {
        get {
            return this.weaponIndexField;
        }
        set {
            this.weaponIndexField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("HelmetIndex")]
    public string HelmetIndex {
        get {
            return this.helmetIndexField;
        }
        set {
            this.helmetIndexField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ArmorIndex")]
    public string ArmorIndex {
        get {
            return this.armorIndexField;
        }
        set {
            this.armorIndexField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CloakIndex")]
    public string CloakIndex {
        get {
            return this.cloakIndexField;
        }
        set {
            this.cloakIndexField = value;
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
