using System.Collections.Generic;

[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class enviNFeNFeInfNFe
{
    private enviNFeNFeInfNFeIde ideField;

    private enviNFeNFeInfNFeEmit emitField;

    private enviNFeNFeInfNFeDest destField;

    private enviNFeNFeInfNFeAutXML[] autXMLField;

    private List<enviNFeNFeInfNFeDet> detField;

    private enviNFeNFeInfNFeTotal totalField;

    private enviNFeNFeInfNFeTransp transpField;

    private enviNFeNFeInfNFePag pagField;

    private string idField;

    private decimal versaoField;

    /// <remarks/>
    public enviNFeNFeInfNFeIde ide
    {
        get
        {
            return this.ideField;
        }
        set
        {
            this.ideField = value;
        }
    }

    /// <remarks/>
    public enviNFeNFeInfNFeEmit emit
    {
        get
        {
            return this.emitField;
        }
        set
        {
            this.emitField = value;
        }
    }

    /// <remarks/>
    public enviNFeNFeInfNFeDest dest
    {
        get
        {
            return this.destField;
        }
        set
        {
            this.destField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("autXML")]
    public enviNFeNFeInfNFeAutXML[] autXML
    {
        get
        {
            return this.autXMLField;
        }
        set
        {
            this.autXMLField = value;
        }
    }

    /// <remarks/>
    public List<enviNFeNFeInfNFeDet> det
    {
        get
        {
            return this.detField;
        }
        set
        {
            this.detField = value;
        }
    }

    /// <remarks/>
    public enviNFeNFeInfNFeTotal total
    {
        get
        {
            return this.totalField;
        }
        set
        {
            this.totalField = value;
        }
    }

    /// <remarks/>
    public enviNFeNFeInfNFeTransp transp
    {
        get
        {
            return this.transpField;
        }
        set
        {
            this.transpField = value;
        }
    }

    /// <remarks/>
    public enviNFeNFeInfNFePag pag
    {
        get
        {
            return this.pagField;
        }
        set
        {
            this.pagField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
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