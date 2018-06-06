[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class enviNFeNFeInfNFeDet
{
    private enviNFeNFeInfNFeDetProd prodField;

    private enviNFeNFeInfNFeDetImposto impostoField;

    private string infAdProdField;

    private byte nItemField;

    /// <remarks/>
    public enviNFeNFeInfNFeDetProd prod
    {
        get
        {
            return this.prodField;
        }
        set
        {
            this.prodField = value;
        }
    }

    /// <remarks/>
    public enviNFeNFeInfNFeDetImposto imposto
    {
        get
        {
            return this.impostoField;
        }
        set
        {
            this.impostoField = value;
        }
    }

    /// <remarks/>
    public string infAdProd
    {
        get
        {
            return this.infAdProdField;
        }
        set
        {
            this.infAdProdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte nItem
    {
        get
        {
            return this.nItemField;
        }
        set
        {
            this.nItemField = value;
        }
    }
}