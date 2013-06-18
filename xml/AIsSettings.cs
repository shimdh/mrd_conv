using System.Xml.Serialization;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public class AIsSettings {

    private AIsSettingsAI[] itemsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AI")]
    public AIsSettingsAI[] Items {
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
public class AIsSettingsAI : XmlData {

    private string indexField;

    private string skillFirstCheckField;

    private float step1HPRateField;

    private string step1Skill1LinkedField;

    private float step1Skill1RateField;

    private string step1Skill2LinkedField;

    private float step1Skill2RateField;

    private string step1Skill3LinkedField;

    private float step1Skill3RateField;

    private float step2HPRateField;

    private string step2Skill1LinkedField;

    private float step2Skill1RateField;

    private string step2Skill2LinkedField;

    private float step2Skill2RateField;

    private string step2Skill3LinkedField;

    private float step2Skill3RateField;

    private float step3HPRateField;

    private string step3Skill1LinkedField;

    private float step3Skill1RateField;

    private string step3Skill2LinkedField;

    private float step3Skill2RateField;

    private string step3Skill3LinkedField;

    private float step3Skill3RateField;

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
    [System.Xml.Serialization.XmlElementAttribute("SkillFirstCheck")]
    public string SkillFirstCheck {
        get {
            return this.skillFirstCheckField;
        }
        set {
            this.skillFirstCheckField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Step1HPRate")]
    public float Step1HPRate {
        get {
            return this.step1HPRateField;
        }
        set {
            this.step1HPRateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Step1Skill1Linked")]
    public string Step1Skill1Linked {
        get {
            return this.step1Skill1LinkedField;
        }
        set {
            this.step1Skill1LinkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Step1Skill1Rate")]
    public float Step1Skill1Rate {
        get {
            return this.step1Skill1RateField;
        }
        set {
            this.step1Skill1RateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Step1Skill2Linked")]
    public string Step1Skill2Linked {
        get {
            return this.step1Skill2LinkedField;
        }
        set {
            this.step1Skill2LinkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Step1Skill2Rate")]
    public float Step1Skill2Rate {
        get {
            return this.step1Skill2RateField;
        }
        set {
            this.step1Skill2RateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Step1Skill3Linked")]
    public string Step1Skill3Linked {
        get {
            return this.step1Skill3LinkedField;
        }
        set {
            this.step1Skill3LinkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Step1Skill3Rate")]
    public float Step1Skill3Rate {
        get {
            return this.step1Skill3RateField;
        }
        set {
            this.step1Skill3RateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Step2HPRate")]
    public float Step2HPRate {
        get {
            return this.step2HPRateField;
        }
        set {
            this.step2HPRateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Step2Skill1Linked")]
    public string Step2Skill1Linked {
        get {
            return this.step2Skill1LinkedField;
        }
        set {
            this.step2Skill1LinkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Step2Skill1Rate")]
    public float Step2Skill1Rate {
        get {
            return this.step2Skill1RateField;
        }
        set {
            this.step2Skill1RateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Step2Skill2Linked")]
    public string Step2Skill2Linked {
        get {
            return this.step2Skill2LinkedField;
        }
        set {
            this.step2Skill2LinkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Step2Skill2Rate")]
    public float Step2Skill2Rate {
        get {
            return this.step2Skill2RateField;
        }
        set {
            this.step2Skill2RateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Step2Skill3Linked")]
    public string Step2Skill3Linked {
        get {
            return this.step2Skill3LinkedField;
        }
        set {
            this.step2Skill3LinkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Step2Skill3Rate")]
    public float Step2Skill3Rate {
        get {
            return this.step2Skill3RateField;
        }
        set {
            this.step2Skill3RateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Step3HPRate")]
    public float Step3HPRate {
        get {
            return this.step3HPRateField;
        }
        set {
            this.step3HPRateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Step3Skill1Linked")]
    public string Step3Skill1Linked {
        get {
            return this.step3Skill1LinkedField;
        }
        set {
            this.step3Skill1LinkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Step3Skill1Rate")]
    public float Step3Skill1Rate {
        get {
            return this.step3Skill1RateField;
        }
        set {
            this.step3Skill1RateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Step3Skill2Linked")]
    public string Step3Skill2Linked {
        get {
            return this.step3Skill2LinkedField;
        }
        set {
            this.step3Skill2LinkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Step3Skill2Rate")]
    public float Step3Skill2Rate {
        get {
            return this.step3Skill2RateField;
        }
        set {
            this.step3Skill2RateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Step3Skill3Linked")]
    public string Step3Skill3Linked {
        get {
            return this.step3Skill3LinkedField;
        }
        set {
            this.step3Skill3LinkedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Step3Skill3Rate")]
    public float Step3Skill3Rate {
        get {
            return this.step3Skill3RateField;
        }
        set {
            this.step3Skill3RateField = value;
        }
    }
}
