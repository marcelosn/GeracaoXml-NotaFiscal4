[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class enviNFeNFeInfNFeDest
{
    private ulong cNPJField;

    private string xNomeField;

    private enviNFeNFeInfNFeDestEnderDest enderDestField;

    private byte indIEDestField;

    private uint ieField;

    private string imField;

    private string emailField;

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
    public string xNome
    {
        get
        {
            return this.xNomeField;
        }
        set
        {
            this.xNomeField = value;
        }
    }

    /// <remarks/>
    public enviNFeNFeInfNFeDestEnderDest enderDest
    {
        get
        {
            return this.enderDestField;
        }
        set
        {
            this.enderDestField = value;
        }
    }

    /// <remarks/>
    public byte indIEDest
    {
        get
        {
            return this.indIEDestField;
        }
        set
        {
            this.indIEDestField = value;
        }
    }

    /// <remarks/>
    public uint IE
    {
        get
        {
            return this.ieField;
        }
        set
        {
            this.ieField = value;
        }
    }

    /// <remarks/>
    public string IM
    {
        get
        {
            return this.imField;
        }
        set
        {
            this.imField = value;
        }
    }

    /// <remarks/>
    public string email
    {
        get
        {
            return this.emailField;
        }
        set
        {
            this.emailField = value;
        }
    }
}