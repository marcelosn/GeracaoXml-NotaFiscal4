[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class enviNFeNFeInfNFeEmit
{
    private ulong cNPJField;

    private string xNomeField;

    private enviNFeNFeInfNFeEmitEnderEmit enderEmitField;

    private uint ieField;

    private byte cRTField;

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
    public enviNFeNFeInfNFeEmitEnderEmit enderEmit
    {
        get
        {
            return this.enderEmitField;
        }
        set
        {
            this.enderEmitField = value;
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
    public byte CRT
    {
        get
        {
            return this.cRTField;
        }
        set
        {
            this.cRTField = value;
        }
    }
}