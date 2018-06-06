[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class enviNFeNFeInfNFeDetImpostoPISPISOutr
{
    private byte cSTField;

    private decimal vBCField;

    private decimal pPISField;

    private decimal vPISField;

    /// <remarks/>
    public byte CST
    {
        get
        {
            return this.cSTField;
        }
        set
        {
            this.cSTField = value;
        }
    }

    /// <remarks/>
    public decimal vBC
    {
        get
        {
            return this.vBCField;
        }
        set
        {
            this.vBCField = value;
        }
    }

    /// <remarks/>
    public decimal pPIS
    {
        get
        {
            return this.pPISField;
        }
        set
        {
            this.pPISField = value;
        }
    }

    /// <remarks/>
    public decimal vPIS
    {
        get
        {
            return this.vPISField;
        }
        set
        {
            this.vPISField = value;
        }
    }
}