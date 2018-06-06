[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
public partial class enviNFe
{
    private uint idLoteField;

    private byte indSincField;

    private enviNFeNFe nFeField;

    private decimal versaoField;

    /// <remarks/>
    public uint idLote
    {
        get
        {
            return this.idLoteField;
        }
        set
        {
            this.idLoteField = value;
        }
    }

    /// <remarks/>
    public byte indSinc
    {
        get
        {
            return this.indSincField;
        }
        set
        {
            this.indSincField = value;
        }
    }

    /// <remarks/>
    public enviNFeNFe NFe
    {
        get
        {
            return this.nFeField;
        }
        set
        {
            this.nFeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal versao
    {
        get
        {
            return this.versaoField;
        }
        set
        {
            this.versaoField = value;
        }
    }
}