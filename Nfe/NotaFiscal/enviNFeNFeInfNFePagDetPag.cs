[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class enviNFeNFeInfNFePagDetPag
{
    private byte tPagField;

    private decimal vPagField;

    /// <remarks/>
    public byte tPag
    {
        get
        {
            return this.tPagField;
        }
        set
        {
            this.tPagField = value;
        }
    }

    /// <remarks/>
    public decimal vPag
    {
        get
        {
            return this.vPagField;
        }
        set
        {
            this.vPagField = value;
        }
    }
}