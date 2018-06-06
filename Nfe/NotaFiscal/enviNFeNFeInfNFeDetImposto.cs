[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class enviNFeNFeInfNFeDetImposto
{
    private decimal vTotTribField;

    private enviNFeNFeInfNFeDetImpostoICMS iCMSField;

    private enviNFeNFeInfNFeDetImpostoPIS pISField;

    private enviNFeNFeInfNFeDetImpostoCOFINS cOFINSField;

    /// <remarks/>
    public decimal vTotTrib
    {
        get
        {
            return this.vTotTribField;
        }
        set
        {
            this.vTotTribField = value;
        }
    }

    /// <remarks/>
    public enviNFeNFeInfNFeDetImpostoICMS ICMS
    {
        get
        {
            return this.iCMSField;
        }
        set
        {
            this.iCMSField = value;
        }
    }

    /// <remarks/>
    public enviNFeNFeInfNFeDetImpostoPIS PIS
    {
        get
        {
            return this.pISField;
        }
        set
        {
            this.pISField = value;
        }
    }

    /// <remarks/>
    public enviNFeNFeInfNFeDetImpostoCOFINS COFINS
    {
        get
        {
            return this.cOFINSField;
        }
        set
        {
            this.cOFINSField = value;
        }
    }
}