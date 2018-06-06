[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class enviNFeNFeInfNFeDetImpostoCOFINSCOFINSOutr
{
    private byte cSTField;

    private decimal vBCField;

    private decimal pCOFINSField;

    private decimal vCOFINSField;

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
    public decimal pCOFINS
    {
        get
        {
            return this.pCOFINSField;
        }
        set
        {
            this.pCOFINSField = value;
        }
    }

    /// <remarks/>
    public decimal vCOFINS
    {
        get
        {
            return this.vCOFINSField;
        }
        set
        {
            this.vCOFINSField = value;
        }
    }
}