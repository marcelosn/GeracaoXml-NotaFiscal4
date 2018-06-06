[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class enviNFeNFeInfNFeAutXML
{
    private ulong cNPJField;

    private bool cNPJFieldSpecified;

    private ulong cPFField;

    private bool cPFFieldSpecified;

    /// <remarks/>
    public ulong CNPJ
    {
        get
        {
            return this.cNPJField;
        }
        set
        {
            this.cNPJField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CNPJSpecified
    {
        get
        {
            return this.cNPJFieldSpecified;
        }
        set
        {
            this.cNPJFieldSpecified = value;
        }
    }

    /// <remarks/>
    public ulong CPF
    {
        get
        {
            return this.cPFField;
        }
        set
        {
            this.cPFField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CPFSpecified
    {
        get
        {
            return this.cPFFieldSpecified;
        }
        set
        {
            this.cPFFieldSpecified = value;
        }
    }
}