[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class enviNFeNFeInfNFeDetImpostoICMSICMS00
{
    private byte origField;

    private byte cSTField;

    private byte modBCField;

    private decimal vBCField;

    private byte pICMSField;

    private decimal vICMSField;

    /// <remarks/>
    public byte orig
    {
        get
        {
            return this.origField;
        }
        set
        {
            this.origField = value;
        }
    }

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
    public byte modBC
    {
        get
        {
            return this.modBCField;
        }
        set
        {
            this.modBCField = value;
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
    public byte pICMS
    {
        get
        {
            return this.pICMSField;
        }
        set
        {
            this.pICMSField = value;
        }
    }

    /// <remarks/>
    public decimal vICMS
    {
        get
        {
            return this.vICMSField;
        }
        set
        {
            this.vICMSField = value;
        }
    }
}