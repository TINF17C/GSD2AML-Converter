namespace Gsd2Aml.Lib.Models
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile", IsNullable = false)]
    public partial class ISO15745Profile
    {

        private ProfileHeaderT profileHeaderField;

        private ProfileBodyT profileBodyField;

        private SignatureType signatureField;

        /// <remarks/>
        public ProfileHeaderT ProfileHeader
        {
            get
            {
                return this.profileHeaderField;
            }
            set
            {
                this.profileHeaderField = value;
            }
        }

        /// <remarks/>
        public ProfileBodyT ProfileBody
        {
            get
            {
                return this.profileBodyField;
            }
            set
            {
                this.profileBodyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ProfileHeaderT
    {

        private string profileIdentificationField;

        private string profileRevisionField;

        private string profileNameField;

        private string profileSourceField;

        private ProfileClassID_EnumT profileClassIDField;

        private System.DateTime profileDateField;

        private bool profileDateFieldSpecified;

        private string additionalInformationField;

        private ISO15745ReferenceT iSO15745ReferenceField;

        private string[] iASInterfaceTypeField;

        /// <remarks/>
        public string ProfileIdentification
        {
            get
            {
                return this.profileIdentificationField;
            }
            set
            {
                this.profileIdentificationField = value;
            }
        }

        /// <remarks/>
        public string ProfileRevision
        {
            get
            {
                return this.profileRevisionField;
            }
            set
            {
                this.profileRevisionField = value;
            }
        }

        /// <remarks/>
        public string ProfileName
        {
            get
            {
                return this.profileNameField;
            }
            set
            {
                this.profileNameField = value;
            }
        }

        /// <remarks/>
        public string ProfileSource
        {
            get
            {
                return this.profileSourceField;
            }
            set
            {
                this.profileSourceField = value;
            }
        }

        /// <remarks/>
        public ProfileClassID_EnumT ProfileClassID
        {
            get
            {
                return this.profileClassIDField;
            }
            set
            {
                this.profileClassIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ProfileDate
        {
            get
            {
                return this.profileDateField;
            }
            set
            {
                this.profileDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProfileDateSpecified
        {
            get
            {
                return this.profileDateFieldSpecified;
            }
            set
            {
                this.profileDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string AdditionalInformation
        {
            get
            {
                return this.additionalInformationField;
            }
            set
            {
                this.additionalInformationField = value;
            }
        }

        /// <remarks/>
        public ISO15745ReferenceT ISO15745Reference
        {
            get
            {
                return this.iSO15745ReferenceField;
            }
            set
            {
                this.iSO15745ReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IASInterfaceType")]
        public string[] IASInterfaceType
        {
            get
            {
                return this.iASInterfaceTypeField;
            }
            set
            {
                this.iASInterfaceTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public enum ProfileClassID_EnumT
    {

        /// <remarks/>
        AIP,

        /// <remarks/>
        Process,

        /// <remarks/>
        InformationExchange,

        /// <remarks/>
        Resource,

        /// <remarks/>
        Device,

        /// <remarks/>
        CommunicationNetwork,

        /// <remarks/>
        Equipment,

        /// <remarks/>
        Human,

        /// <remarks/>
        Material,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ISO15745ReferenceT
    {

        private string iSO15745PartField;

        private string iSO15745EditionField;

        private string profileTechnologyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string ISO15745Part
        {
            get
            {
                return this.iSO15745PartField;
            }
            set
            {
                this.iSO15745PartField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string ISO15745Edition
        {
            get
            {
                return this.iSO15745EditionField;
            }
            set
            {
                this.iSO15745EditionField = value;
            }
        }

        /// <remarks/>
        public string ProfileTechnology
        {
            get
            {
                return this.profileTechnologyField;
            }
            set
            {
                this.profileTechnologyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("SignatureProperty", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SignaturePropertyType
    {

        private System.Xml.XmlElement[] itemsField;

        private string[] textField;

        private string targetField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("SignatureProperties", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SignaturePropertiesType
    {

        private SignaturePropertyType[] signaturePropertyField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SignatureProperty")]
        public SignaturePropertyType[] SignatureProperty
        {
            get
            {
                return this.signaturePropertyField;
            }
            set
            {
                this.signaturePropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("Manifest", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class ManifestType
    {

        private ReferenceType[] referenceField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reference")]
        public ReferenceType[] Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("Reference", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class ReferenceType
    {

        private TransformType[] transformsField;

        private DigestMethodType digestMethodField;

        private byte[] digestValueField;

        private string idField;

        private string uRIField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
        public TransformType[] Transforms
        {
            get
            {
                return this.transformsField;
            }
            set
            {
                this.transformsField = value;
            }
        }

        /// <remarks/>
        public DigestMethodType DigestMethod
        {
            get
            {
                return this.digestMethodField;
            }
            set
            {
                this.digestMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] DigestValue
        {
            get
            {
                return this.digestValueField;
            }
            set
            {
                this.digestValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class TransformType
    {

        private object[] itemsField;

        private string[] textField;

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("XPath", typeof(string))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("DigestMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class DigestMethodType
    {

        private System.Xml.XmlNode[] anyField;

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("Object", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class ObjectType
    {

        private System.Xml.XmlNode[] anyField;

        private string idField;

        private string mimeTypeField;

        private string encodingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
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
        public string MimeType
        {
            get
            {
                return this.mimeTypeField;
            }
            set
            {
                this.mimeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("SPKIData", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SPKIDataType
    {

        private byte[][] sPKISexpField;

        private System.Xml.XmlElement anyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SPKISexp", DataType = "base64Binary")]
        public byte[][] SPKISexp
        {
            get
            {
                return this.sPKISexpField;
            }
            set
            {
                this.sPKISexpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("PGPData", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class PGPDataType
    {

        private object[] itemsField;

        private ItemsChoiceType1[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("PGPKeyID", typeof(byte[]), DataType = "base64Binary")]
        [System.Xml.Serialization.XmlElementAttribute("PGPKeyPacket", typeof(byte[]), DataType = "base64Binary")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("##any:")]
        Item,

        /// <remarks/>
        PGPKeyID,

        /// <remarks/>
        PGPKeyPacket,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class X509IssuerSerialType
    {

        private string x509IssuerNameField;

        private string x509SerialNumberField;

        /// <remarks/>
        public string X509IssuerName
        {
            get
            {
                return this.x509IssuerNameField;
            }
            set
            {
                this.x509IssuerNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string X509SerialNumber
        {
            get
            {
                return this.x509SerialNumberField;
            }
            set
            {
                this.x509SerialNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("X509Data", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class X509DataType
    {

        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("X509CRL", typeof(byte[]), DataType = "base64Binary")]
        [System.Xml.Serialization.XmlElementAttribute("X509Certificate", typeof(byte[]), DataType = "base64Binary")]
        [System.Xml.Serialization.XmlElementAttribute("X509IssuerSerial", typeof(X509IssuerSerialType))]
        [System.Xml.Serialization.XmlElementAttribute("X509SKI", typeof(byte[]), DataType = "base64Binary")]
        [System.Xml.Serialization.XmlElementAttribute("X509SubjectName", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("##any:")]
        Item,

        /// <remarks/>
        X509CRL,

        /// <remarks/>
        X509Certificate,

        /// <remarks/>
        X509IssuerSerial,

        /// <remarks/>
        X509SKI,

        /// <remarks/>
        X509SubjectName,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("RetrievalMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class RetrievalMethodType
    {

        private TransformType[] transformsField;

        private string uRIField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
        public TransformType[] Transforms
        {
            get
            {
                return this.transformsField;
            }
            set
            {
                this.transformsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("RSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class RSAKeyValueType
    {

        private byte[] modulusField;

        private byte[] exponentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] Modulus
        {
            get
            {
                return this.modulusField;
            }
            set
            {
                this.modulusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] Exponent
        {
            get
            {
                return this.exponentField;
            }
            set
            {
                this.exponentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("DSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class DSAKeyValueType
    {

        private byte[] pField;

        private byte[] qField;

        private byte[] gField;

        private byte[] yField;

        private byte[] jField;

        private byte[] seedField;

        private byte[] pgenCounterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] P
        {
            get
            {
                return this.pField;
            }
            set
            {
                this.pField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] Q
        {
            get
            {
                return this.qField;
            }
            set
            {
                this.qField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] G
        {
            get
            {
                return this.gField;
            }
            set
            {
                this.gField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] J
        {
            get
            {
                return this.jField;
            }
            set
            {
                this.jField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] Seed
        {
            get
            {
                return this.seedField;
            }
            set
            {
                this.seedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] PgenCounter
        {
            get
            {
                return this.pgenCounterField;
            }
            set
            {
                this.pgenCounterField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("KeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class KeyValueType
    {

        private object itemField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("DSAKeyValue", typeof(DSAKeyValueType))]
        [System.Xml.Serialization.XmlElementAttribute("RSAKeyValue", typeof(RSAKeyValueType))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("KeyInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class KeyInfoType
    {

        private object[] itemsField;

        private ItemsChoiceType2[] itemsElementNameField;

        private string[] textField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("KeyName", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("KeyValue", typeof(KeyValueType))]
        [System.Xml.Serialization.XmlElementAttribute("MgmtData", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("PGPData", typeof(PGPDataType))]
        [System.Xml.Serialization.XmlElementAttribute("RetrievalMethod", typeof(RetrievalMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("SPKIData", typeof(SPKIDataType))]
        [System.Xml.Serialization.XmlElementAttribute("X509Data", typeof(X509DataType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType2[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
    public enum ItemsChoiceType2
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("##any:")]
        Item,

        /// <remarks/>
        KeyName,

        /// <remarks/>
        KeyValue,

        /// <remarks/>
        MgmtData,

        /// <remarks/>
        PGPData,

        /// <remarks/>
        RetrievalMethod,

        /// <remarks/>
        SPKIData,

        /// <remarks/>
        X509Data,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("SignatureValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SignatureValueType
    {

        private string idField;

        private byte[] valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
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
        [System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("SignatureMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SignatureMethodType
    {

        private string hMACOutputLengthField;

        private System.Xml.XmlNode[] anyField;

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string HMACOutputLength
        {
            get
            {
                return this.hMACOutputLengthField;
            }
            set
            {
                this.hMACOutputLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("CanonicalizationMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class CanonicalizationMethodType
    {

        private System.Xml.XmlNode[] anyField;

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("SignedInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SignedInfoType
    {

        private CanonicalizationMethodType canonicalizationMethodField;

        private SignatureMethodType signatureMethodField;

        private ReferenceType[] referenceField;

        private string idField;

        /// <remarks/>
        public CanonicalizationMethodType CanonicalizationMethod
        {
            get
            {
                return this.canonicalizationMethodField;
            }
            set
            {
                this.canonicalizationMethodField = value;
            }
        }

        /// <remarks/>
        public SignatureMethodType SignatureMethod
        {
            get
            {
                return this.signatureMethodField;
            }
            set
            {
                this.signatureMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reference")]
        public ReferenceType[] Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SignatureType
    {

        private SignedInfoType signedInfoField;

        private SignatureValueType signatureValueField;

        private KeyInfoType keyInfoField;

        private ObjectType[] objectField;

        private string idField;

        /// <remarks/>
        public SignedInfoType SignedInfo
        {
            get
            {
                return this.signedInfoField;
            }
            set
            {
                this.signedInfoField = value;
            }
        }

        /// <remarks/>
        public SignatureValueType SignatureValue
        {
            get
            {
                return this.signatureValueField;
            }
            set
            {
                this.signatureValueField = value;
            }
        }

        /// <remarks/>
        public KeyInfoType KeyInfo
        {
            get
            {
                return this.keyInfoField;
            }
            set
            {
                this.keyInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Object")]
        public ObjectType[] Object
        {
            get
            {
                return this.objectField;
            }
            set
            {
                this.objectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    [System.Xml.Serialization.XmlRootAttribute("ExternalTextDocument", Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives", IsNullable = false)]
    public partial class ExternalTextDocumentT
    {

        private ExternalTextT[] textField;

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Text")]
        public ExternalTextT[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public partial class ExternalTextT
    {

        private string textIdField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string TextId
        {
            get
            {
                return this.textIdField;
            }
            set
            {
                this.textIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class LanguageT
    {

        private ExternalTextT[] textField;

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Text")]
        public ExternalTextT[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ErrorCode2ItemT))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ErrorCode2T
    {

        private ExternalTextRefT nameField;

        private ExternalTextRefT helpField;

        /// <remarks/>
        public ExternalTextRefT Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ExternalTextRefT Help
        {
            get
            {
                return this.helpField;
            }
            set
            {
                this.helpField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public partial class ExternalTextRefT
    {

        private string textIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string TextId
        {
            get
            {
                return this.textIdField;
            }
            set
            {
                this.textIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ErrorCode2ItemT : ErrorCode2T
    {

        private byte errorCode2Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ErrorCode2
        {
            get
            {
                return this.errorCode2Field;
            }
            set
            {
                this.errorCode2Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class LogBookEntryItemT
    {

        private object itemField;

        private uint statusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ErrorCode2List", typeof(LogBookEntryItemTErrorCode2List))]
        [System.Xml.Serialization.XmlElementAttribute("ErrorCode2Value", typeof(ErrorCode2T))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class LogBookEntryItemTErrorCode2List
    {

        private ErrorCode2ItemT[] errorCode2ItemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ErrorCode2Item")]
        public ErrorCode2ItemT[] ErrorCode2Item
        {
            get
            {
                return this.errorCode2ItemField;
            }
            set
            {
                this.errorCode2ItemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ProfileUnitDiagTypeItemT
    {

        private ExternalTextRefT nameField;

        private ExternalTextRefT helpField;

        private ProfileUnitDiagTypeItemTRef[] refField;

        private uint aPIField;

        private ushort userStructureIdentifierField;

        /// <remarks/>
        public ExternalTextRefT Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ExternalTextRefT Help
        {
            get
            {
                return this.helpField;
            }
            set
            {
                this.helpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Ref")]
        public ProfileUnitDiagTypeItemTRef[] Ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint API
        {
            get
            {
                return this.aPIField;
            }
            set
            {
                this.aPIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort UserStructureIdentifier
        {
            get
            {
                return this.userStructureIdentifierField;
            }
            set
            {
                this.userStructureIdentifierField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ProfileUnitDiagTypeItemTRef : ValueItemReferenceT
    {

        private UnitDiagRefTypeEnumT dataTypeField;

        private string defaultValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitDiagRefTypeEnumT DataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DefaultValue
        {
            get
            {
                return this.defaultValueField;
            }
            set
            {
                this.defaultValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public enum UnitDiagRefTypeEnumT
    {

        /// <remarks/>
        Bit,

        /// <remarks/>
        BitArea,

        /// <remarks/>
        Integer8,

        /// <remarks/>
        Integer16,

        /// <remarks/>
        Integer32,

        /// <remarks/>
        Integer64,

        /// <remarks/>
        Unsigned8,

        /// <remarks/>
        Unsigned16,

        /// <remarks/>
        Unsigned32,

        /// <remarks/>
        Unsigned64,

        /// <remarks/>
        Float32,

        /// <remarks/>
        Float64,

        /// <remarks/>
        VisibleString,

        /// <remarks/>
        OctetString,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RecordDataRefT))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ValueItemReferenceT
    {

        private string valueItemTargetField;

        private uint byteOffsetField;

        private byte bitOffsetField;

        private string bitLengthField;

        private string textIdField;

        private ushort lengthField;

        private bool lengthFieldSpecified;

        public ValueItemReferenceT()
        {
            this.bitOffsetField = ((byte)(0));
            this.bitLengthField = "1";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string ValueItemTarget
        {
            get
            {
                return this.valueItemTargetField;
            }
            set
            {
                this.valueItemTargetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint ByteOffset
        {
            get
            {
                return this.byteOffsetField;
            }
            set
            {
                this.byteOffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "0")]
        public byte BitOffset
        {
            get
            {
                return this.bitOffsetField;
            }
            set
            {
                this.bitOffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string BitLength
        {
            get
            {
                return this.bitLengthField;
            }
            set
            {
                this.bitLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string TextId
        {
            get
            {
                return this.textIdField;
            }
            set
            {
                this.textIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LengthSpecified
        {
            get
            {
                return this.lengthFieldSpecified;
            }
            set
            {
                this.lengthFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class RecordDataRefT : ValueItemReferenceT
    {

        private string idField;

        private RecordDataRefTypeEnumT dataTypeField;

        private string defaultValueField;

        private string allowedValuesField;

        private bool changeableField;

        private bool visibleField;

        public RecordDataRefT()
        {
            this.changeableField = true;
            this.visibleField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string ID
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
        public RecordDataRefTypeEnumT DataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DefaultValue
        {
            get
            {
                return this.defaultValueField;
            }
            set
            {
                this.defaultValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowedValues
        {
            get
            {
                return this.allowedValuesField;
            }
            set
            {
                this.allowedValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Changeable
        {
            get
            {
                return this.changeableField;
            }
            set
            {
                this.changeableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Visible
        {
            get
            {
                return this.visibleField;
            }
            set
            {
                this.visibleField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public enum RecordDataRefTypeEnumT
    {

        /// <remarks/>
        Bit,

        /// <remarks/>
        BitArea,

        /// <remarks/>
        Integer8,

        /// <remarks/>
        Integer16,

        /// <remarks/>
        Integer32,

        /// <remarks/>
        Integer64,

        /// <remarks/>
        Unsigned8,

        /// <remarks/>
        Unsigned16,

        /// <remarks/>
        Unsigned32,

        /// <remarks/>
        Unsigned64,

        /// <remarks/>
        Float32,

        /// <remarks/>
        Float64,

        /// <remarks/>
        Date,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("TimeOfDay with date indication")]
        TimeOfDaywithdateindication,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("TimeOfDay without date indication")]
        TimeOfDaywithoutdateindication,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("TimeDifference with date indication")]
        TimeDifferencewithdateindication,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("TimeDifference without date indication")]
        TimeDifferencewithoutdateindication,

        /// <remarks/>
        NetworkTime,

        /// <remarks/>
        NetworkTimeDifference,

        /// <remarks/>
        VisibleString,

        /// <remarks/>
        OctetString,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Unsigned8+Unsigned8")]
        Unsigned8Unsigned8,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Float32+Unsigned8")]
        Float32Unsigned8,

        /// <remarks/>
        Boolean,

        /// <remarks/>
        UnicodeString8,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("61131_STRING")]
        Item61131_STRING,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("61131_WSTRING")]
        Item61131_WSTRING,

        /// <remarks/>
        TimeStamp,

        /// <remarks/>
        TimeStampDifference,

        /// <remarks/>
        TimeStampDifferenceShort,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("OctetString2+Unsigned8")]
        OctetString2Unsigned8,

        /// <remarks/>
        Unsigned16_S,

        /// <remarks/>
        Integer16_S,

        /// <remarks/>
        Unsigned8_S,

        /// <remarks/>
        OctetString_S,

        /// <remarks/>
        N2,

        /// <remarks/>
        N4,

        /// <remarks/>
        V2,

        /// <remarks/>
        L2,

        /// <remarks/>
        R2,

        /// <remarks/>
        T2,

        /// <remarks/>
        T4,

        /// <remarks/>
        D2,

        /// <remarks/>
        E2,

        /// <remarks/>
        C4,

        /// <remarks/>
        X2,

        /// <remarks/>
        X4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Unipolar2.16")]
        Unipolar216,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class UnitDiagTypeItemT
    {

        private ExternalTextRefT nameField;

        private ExternalTextRefT helpField;

        private UnitDiagTypeItemTRef[] refField;

        private ushort userStructureIdentifierField;

        /// <remarks/>
        public ExternalTextRefT Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ExternalTextRefT Help
        {
            get
            {
                return this.helpField;
            }
            set
            {
                this.helpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Ref")]
        public UnitDiagTypeItemTRef[] Ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort UserStructureIdentifier
        {
            get
            {
                return this.userStructureIdentifierField;
            }
            set
            {
                this.userStructureIdentifierField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class UnitDiagTypeItemTRef : ValueItemReferenceT
    {

        private UnitDiagRefTypeEnumT dataTypeField;

        private string defaultValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitDiagRefTypeEnumT DataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DefaultValue
        {
            get
            {
                return this.defaultValueField;
            }
            set
            {
                this.defaultValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ProfileChannelProcessAlarmItemT
    {

        private ExternalTextRefT nameField;

        private ExternalTextRefT helpField;

        private object[] extChannelProcessAlarmListField;

        private uint aPIField;

        private ushort reasonField;

        /// <remarks/>
        public ExternalTextRefT Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ExternalTextRefT Help
        {
            get
            {
                return this.helpField;
            }
            set
            {
                this.helpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ExtChannelProcessAlarmItem", typeof(ExtChannelProcessAlarmItemT), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ProfileExtChannelProcessAlarmItem", typeof(ProfileExtChannelProcessAlarmItemT), IsNullable = false)]
        public object[] ExtChannelProcessAlarmList
        {
            get
            {
                return this.extChannelProcessAlarmListField;
            }
            set
            {
                this.extChannelProcessAlarmListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint API
        {
            get
            {
                return this.aPIField;
            }
            set
            {
                this.aPIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Reason
        {
            get
            {
                return this.reasonField;
            }
            set
            {
                this.reasonField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ExtChannelProcessAlarmItemT
    {

        private ExternalTextRefT nameField;

        private ExternalTextRefT helpField;

        private ProcessAlarmReasonAddValueItemT[] processAlarmReasonAddValueField;

        private ushort reasonField;

        /// <remarks/>
        public ExternalTextRefT Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ExternalTextRefT Help
        {
            get
            {
                return this.helpField;
            }
            set
            {
                this.helpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DataItem", IsNullable = false)]
        public ProcessAlarmReasonAddValueItemT[] ProcessAlarmReasonAddValue
        {
            get
            {
                return this.processAlarmReasonAddValueField;
            }
            set
            {
                this.processAlarmReasonAddValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Reason
        {
            get
            {
                return this.reasonField;
            }
            set
            {
                this.reasonField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ProcessAlarmReasonAddValueItemT
    {

        private byte idField;

        private ProcessAlarmReasonAddValueDataItemTypeEnumT dataTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Id
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
        public ProcessAlarmReasonAddValueDataItemTypeEnumT DataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public enum ProcessAlarmReasonAddValueDataItemTypeEnumT
    {

        /// <remarks/>
        Integer8,

        /// <remarks/>
        Integer16,

        /// <remarks/>
        Integer32,

        /// <remarks/>
        Integer64,

        /// <remarks/>
        Unsigned8,

        /// <remarks/>
        Unsigned16,

        /// <remarks/>
        Unsigned32,

        /// <remarks/>
        Unsigned64,

        /// <remarks/>
        Float32,

        /// <remarks/>
        Float64,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ProfileExtChannelProcessAlarmItemT
    {

        private ExternalTextRefT nameField;

        private ExternalTextRefT helpField;

        private ProcessAlarmReasonAddValueItemT[] processAlarmReasonAddValueField;

        private ushort reasonField;

        /// <remarks/>
        public ExternalTextRefT Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ExternalTextRefT Help
        {
            get
            {
                return this.helpField;
            }
            set
            {
                this.helpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DataItem", IsNullable = false)]
        public ProcessAlarmReasonAddValueItemT[] ProcessAlarmReasonAddValue
        {
            get
            {
                return this.processAlarmReasonAddValueField;
            }
            set
            {
                this.processAlarmReasonAddValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Reason
        {
            get
            {
                return this.reasonField;
            }
            set
            {
                this.reasonField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class SystemDefinedChannelProcessAlarmItemT
    {

        private object[] extChannelProcessAlarmListField;

        private string reasonField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ExtChannelProcessAlarmItem", typeof(ExtChannelProcessAlarmItemT), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ProfileExtChannelProcessAlarmItem", typeof(SystemDefinedChannelProcessAlarmItemTProfileExtChannelProcessAlarmItem), IsNullable = false)]
        public object[] ExtChannelProcessAlarmList
        {
            get
            {
                return this.extChannelProcessAlarmListField;
            }
            set
            {
                this.extChannelProcessAlarmListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Reason
        {
            get
            {
                return this.reasonField;
            }
            set
            {
                this.reasonField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class SystemDefinedChannelProcessAlarmItemTProfileExtChannelProcessAlarmItem : ProfileExtChannelProcessAlarmItemT
    {

        private uint aPIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint API
        {
            get
            {
                return this.aPIField;
            }
            set
            {
                this.aPIField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ChannelProcessAlarmItemT
    {

        private ExternalTextRefT nameField;

        private ExternalTextRefT helpField;

        private ExtChannelProcessAlarmItemT[] extChannelProcessAlarmListField;

        private ushort reasonField;

        /// <remarks/>
        public ExternalTextRefT Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ExternalTextRefT Help
        {
            get
            {
                return this.helpField;
            }
            set
            {
                this.helpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ExtChannelProcessAlarmItem", IsNullable = false)]
        public ExtChannelProcessAlarmItemT[] ExtChannelProcessAlarmList
        {
            get
            {
                return this.extChannelProcessAlarmListField;
            }
            set
            {
                this.extChannelProcessAlarmListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Reason
        {
            get
            {
                return this.reasonField;
            }
            set
            {
                this.reasonField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ProfileChannelDiagItemT
    {

        private ExternalTextRefT nameField;

        private ExternalTextRefT helpField;

        private object[] extChannelDiagListField;

        private uint aPIField;

        private ushort errorTypeField;

        private string maintenanceAlarmStateField;

        public ProfileChannelDiagItemT()
        {
            this.maintenanceAlarmStateField = "D";
        }

        /// <remarks/>
        public ExternalTextRefT Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ExternalTextRefT Help
        {
            get
            {
                return this.helpField;
            }
            set
            {
                this.helpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ExtChannelDiagItem", typeof(ExtChannelDiagItemT), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ProfileExtChannelDiagItem", typeof(ProfileExtChannelDiagItemT), IsNullable = false)]
        public object[] ExtChannelDiagList
        {
            get
            {
                return this.extChannelDiagListField;
            }
            set
            {
                this.extChannelDiagListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint API
        {
            get
            {
                return this.aPIField;
            }
            set
            {
                this.aPIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ErrorType
        {
            get
            {
                return this.errorTypeField;
            }
            set
            {
                this.errorTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("D")]
        public string MaintenanceAlarmState
        {
            get
            {
                return this.maintenanceAlarmStateField;
            }
            set
            {
                this.maintenanceAlarmStateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ExtChannelDiagItemT
    {

        private ExternalTextRefT nameField;

        private ExternalTextRefT helpField;

        private ExtChannelAddValueItemT[] extChannelAddValueField;

        private ushort errorTypeField;

        private string maintenanceAlarmStateField;

        public ExtChannelDiagItemT()
        {
            this.maintenanceAlarmStateField = "D";
        }

        /// <remarks/>
        public ExternalTextRefT Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ExternalTextRefT Help
        {
            get
            {
                return this.helpField;
            }
            set
            {
                this.helpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DataItem", IsNullable = false)]
        public ExtChannelAddValueItemT[] ExtChannelAddValue
        {
            get
            {
                return this.extChannelAddValueField;
            }
            set
            {
                this.extChannelAddValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ErrorType
        {
            get
            {
                return this.errorTypeField;
            }
            set
            {
                this.errorTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("D")]
        public string MaintenanceAlarmState
        {
            get
            {
                return this.maintenanceAlarmStateField;
            }
            set
            {
                this.maintenanceAlarmStateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ExtChannelAddValueItemT
    {

        private byte idField;

        private ExtChannelAddValueDataItemTypeEnumT dataTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Id
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
        public ExtChannelAddValueDataItemTypeEnumT DataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public enum ExtChannelAddValueDataItemTypeEnumT
    {

        /// <remarks/>
        Integer8,

        /// <remarks/>
        Integer16,

        /// <remarks/>
        Integer32,

        /// <remarks/>
        Unsigned8,

        /// <remarks/>
        Unsigned16,

        /// <remarks/>
        Unsigned32,

        /// <remarks/>
        Float32,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ProfileExtChannelDiagItemT
    {

        private ExternalTextRefT nameField;

        private ExternalTextRefT helpField;

        private ExtChannelAddValueItemT[] extChannelAddValueField;

        private ushort errorTypeField;

        private string maintenanceAlarmStateField;

        public ProfileExtChannelDiagItemT()
        {
            this.maintenanceAlarmStateField = "D";
        }

        /// <remarks/>
        public ExternalTextRefT Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ExternalTextRefT Help
        {
            get
            {
                return this.helpField;
            }
            set
            {
                this.helpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DataItem", IsNullable = false)]
        public ExtChannelAddValueItemT[] ExtChannelAddValue
        {
            get
            {
                return this.extChannelAddValueField;
            }
            set
            {
                this.extChannelAddValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ErrorType
        {
            get
            {
                return this.errorTypeField;
            }
            set
            {
                this.errorTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("D")]
        public string MaintenanceAlarmState
        {
            get
            {
                return this.maintenanceAlarmStateField;
            }
            set
            {
                this.maintenanceAlarmStateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class SystemDefinedChannelDiagItemT
    {

        private object[] extChannelDiagListField;

        private string errorTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ExtChannelDiagItem", typeof(ExtChannelDiagItemT), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ProfileExtChannelDiagItem", typeof(SystemDefinedChannelDiagItemTProfileExtChannelDiagItem), IsNullable = false)]
        public object[] ExtChannelDiagList
        {
            get
            {
                return this.extChannelDiagListField;
            }
            set
            {
                this.extChannelDiagListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ErrorType
        {
            get
            {
                return this.errorTypeField;
            }
            set
            {
                this.errorTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class SystemDefinedChannelDiagItemTProfileExtChannelDiagItem : ProfileExtChannelDiagItemT
    {

        private uint aPIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint API
        {
            get
            {
                return this.aPIField;
            }
            set
            {
                this.aPIField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ChannelDiagItemT
    {

        private ExternalTextRefT nameField;

        private ExternalTextRefT helpField;

        private ExtChannelDiagItemT[] extChannelDiagListField;

        private ushort errorTypeField;

        private string maintenanceAlarmStateField;

        public ChannelDiagItemT()
        {
            this.maintenanceAlarmStateField = "D";
        }

        /// <remarks/>
        public ExternalTextRefT Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ExternalTextRefT Help
        {
            get
            {
                return this.helpField;
            }
            set
            {
                this.helpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ExtChannelDiagItem", IsNullable = false)]
        public ExtChannelDiagItemT[] ExtChannelDiagList
        {
            get
            {
                return this.extChannelDiagListField;
            }
            set
            {
                this.extChannelDiagListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ErrorType
        {
            get
            {
                return this.errorTypeField;
            }
            set
            {
                this.errorTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("D")]
        public string MaintenanceAlarmState
        {
            get
            {
                return this.maintenanceAlarmStateField;
            }
            set
            {
                this.maintenanceAlarmStateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class SystemRedundancyT
    {

        private SRDeviceTypeEnumT deviceTypeField;

        private ushort maxSwitchOverTimeField;

        private bool primaryAR_OnBothNAPsSupportedField;

        private bool primaryAR_OnBothNAPsSupportedFieldSpecified;

        private bool rT_InputOnBackupAR_SupportedField;

        private byte numberOfAR_SetsField;

        private ushort minRDHTField;

        private bool minRDHTFieldSpecified;

        private bool dataInvalidOnBackupAR_SupportedField;

        private ushort s2MaxInputOnBackupDelayField;

        private bool s2MaxInputOnBackupDelayFieldSpecified;

        private ushort r2MaxInputOnBackupDelayField;

        private bool r2MaxInputOnBackupDelayFieldSpecified;

        public SystemRedundancyT()
        {
            this.rT_InputOnBackupAR_SupportedField = false;
            this.numberOfAR_SetsField = ((byte)(1));
            this.dataInvalidOnBackupAR_SupportedField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SRDeviceTypeEnumT DeviceType
        {
            get
            {
                return this.deviceTypeField;
            }
            set
            {
                this.deviceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort MaxSwitchOverTime
        {
            get
            {
                return this.maxSwitchOverTimeField;
            }
            set
            {
                this.maxSwitchOverTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PrimaryAR_OnBothNAPsSupported
        {
            get
            {
                return this.primaryAR_OnBothNAPsSupportedField;
            }
            set
            {
                this.primaryAR_OnBothNAPsSupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrimaryAR_OnBothNAPsSupportedSpecified
        {
            get
            {
                return this.primaryAR_OnBothNAPsSupportedFieldSpecified;
            }
            set
            {
                this.primaryAR_OnBothNAPsSupportedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool RT_InputOnBackupAR_Supported
        {
            get
            {
                return this.rT_InputOnBackupAR_SupportedField;
            }
            set
            {
                this.rT_InputOnBackupAR_SupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "1")]
        public byte NumberOfAR_Sets
        {
            get
            {
                return this.numberOfAR_SetsField;
            }
            set
            {
                this.numberOfAR_SetsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort MinRDHT
        {
            get
            {
                return this.minRDHTField;
            }
            set
            {
                this.minRDHTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinRDHTSpecified
        {
            get
            {
                return this.minRDHTFieldSpecified;
            }
            set
            {
                this.minRDHTFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool DataInvalidOnBackupAR_Supported
        {
            get
            {
                return this.dataInvalidOnBackupAR_SupportedField;
            }
            set
            {
                this.dataInvalidOnBackupAR_SupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort S2MaxInputOnBackupDelay
        {
            get
            {
                return this.s2MaxInputOnBackupDelayField;
            }
            set
            {
                this.s2MaxInputOnBackupDelayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool S2MaxInputOnBackupDelaySpecified
        {
            get
            {
                return this.s2MaxInputOnBackupDelayFieldSpecified;
            }
            set
            {
                this.s2MaxInputOnBackupDelayFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort R2MaxInputOnBackupDelay
        {
            get
            {
                return this.r2MaxInputOnBackupDelayField;
            }
            set
            {
                this.r2MaxInputOnBackupDelayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool R2MaxInputOnBackupDelaySpecified
        {
            get
            {
                return this.r2MaxInputOnBackupDelayFieldSpecified;
            }
            set
            {
                this.r2MaxInputOnBackupDelayFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public enum SRDeviceTypeEnumT
    {

        /// <remarks/>
        S2,

        /// <remarks/>
        R1,

        /// <remarks/>
        R2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ApplicationRelationsObsoleteT
    {

        private ApplicationRelationsObsoleteTTimingProperties timingPropertiesField;

        private ushort aR_BlockVersionField;

        private ushort iOCR_BlockVersionField;

        private ushort alarmCR_BlockVersionField;

        private ushort submoduleDataBlockVersionField;

        /// <remarks/>
        public ApplicationRelationsObsoleteTTimingProperties TimingProperties
        {
            get
            {
                return this.timingPropertiesField;
            }
            set
            {
                this.timingPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort AR_BlockVersion
        {
            get
            {
                return this.aR_BlockVersionField;
            }
            set
            {
                this.aR_BlockVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort IOCR_BlockVersion
        {
            get
            {
                return this.iOCR_BlockVersionField;
            }
            set
            {
                this.iOCR_BlockVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort AlarmCR_BlockVersion
        {
            get
            {
                return this.alarmCR_BlockVersionField;
            }
            set
            {
                this.alarmCR_BlockVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort SubmoduleDataBlockVersion
        {
            get
            {
                return this.submoduleDataBlockVersionField;
            }
            set
            {
                this.submoduleDataBlockVersionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ApplicationRelationsObsoleteTTimingProperties
    {

        private string sendClockField;

        private string reductionRatioField;

        public ApplicationRelationsObsoleteTTimingProperties()
        {
            this.sendClockField = "32";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("32")]
        public string SendClock
        {
            get
            {
                return this.sendClockField;
            }
            set
            {
                this.sendClockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReductionRatio
        {
            get
            {
                return this.reductionRatioField;
            }
            set
            {
                this.reductionRatioField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class MAUTypeItemT
    {

        private ushort valueField;

        private ushort extensionField;

        private bool adjustSupportedField;

        public MAUTypeItemT()
        {
            this.extensionField = ((ushort)(0));
            this.adjustSupportedField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "0")]
        public ushort Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AdjustSupported
        {
            get
            {
                return this.adjustSupportedField;
            }
            set
            {
                this.adjustSupportedField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ApplicationRelationsT
    {

        private ApplicationRelationsTTimingProperties timingPropertiesField;

        private ApplicationRelationsTRT_Class3TimingProperties rT_Class3TimingPropertiesField;

        private string startupModeField;

        private ushort numberOfAdditionalInputCRField;

        private ushort numberOfAdditionalOutputCRField;

        private ushort numberOfAdditionalMulticastProviderCRField;

        private ushort numberOfMulticastConsumerCRField;

        private bool pullModuleAlarmSupportedField;

        private ushort numberOfARField;

        public ApplicationRelationsT()
        {
            this.startupModeField = "Legacy";
            this.numberOfAdditionalInputCRField = ((ushort)(0));
            this.numberOfAdditionalOutputCRField = ((ushort)(0));
            this.numberOfAdditionalMulticastProviderCRField = ((ushort)(0));
            this.numberOfMulticastConsumerCRField = ((ushort)(0));
            this.pullModuleAlarmSupportedField = false;
            this.numberOfARField = ((ushort)(1));
        }

        /// <remarks/>
        public ApplicationRelationsTTimingProperties TimingProperties
        {
            get
            {
                return this.timingPropertiesField;
            }
            set
            {
                this.timingPropertiesField = value;
            }
        }

        /// <remarks/>
        public ApplicationRelationsTRT_Class3TimingProperties RT_Class3TimingProperties
        {
            get
            {
                return this.rT_Class3TimingPropertiesField;
            }
            set
            {
                this.rT_Class3TimingPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("Legacy")]
        public string StartupMode
        {
            get
            {
                return this.startupModeField;
            }
            set
            {
                this.startupModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "0")]
        public ushort NumberOfAdditionalInputCR
        {
            get
            {
                return this.numberOfAdditionalInputCRField;
            }
            set
            {
                this.numberOfAdditionalInputCRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "0")]
        public ushort NumberOfAdditionalOutputCR
        {
            get
            {
                return this.numberOfAdditionalOutputCRField;
            }
            set
            {
                this.numberOfAdditionalOutputCRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "0")]
        public ushort NumberOfAdditionalMulticastProviderCR
        {
            get
            {
                return this.numberOfAdditionalMulticastProviderCRField;
            }
            set
            {
                this.numberOfAdditionalMulticastProviderCRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "0")]
        public ushort NumberOfMulticastConsumerCR
        {
            get
            {
                return this.numberOfMulticastConsumerCRField;
            }
            set
            {
                this.numberOfMulticastConsumerCRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool PullModuleAlarmSupported
        {
            get
            {
                return this.pullModuleAlarmSupportedField;
            }
            set
            {
                this.pullModuleAlarmSupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "1")]
        public ushort NumberOfAR
        {
            get
            {
                return this.numberOfARField;
            }
            set
            {
                this.numberOfARField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ApplicationRelationsTTimingProperties
    {

        private string sendClockField;

        private string reductionRatioField;

        private string reductionRatioPow2Field;

        private ushort preferredSendClockField;

        private bool preferredSendClockFieldSpecified;

        public ApplicationRelationsTTimingProperties()
        {
            this.sendClockField = "32";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("32")]
        public string SendClock
        {
            get
            {
                return this.sendClockField;
            }
            set
            {
                this.sendClockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReductionRatio
        {
            get
            {
                return this.reductionRatioField;
            }
            set
            {
                this.reductionRatioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReductionRatioPow2
        {
            get
            {
                return this.reductionRatioPow2Field;
            }
            set
            {
                this.reductionRatioPow2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort PreferredSendClock
        {
            get
            {
                return this.preferredSendClockField;
            }
            set
            {
                this.preferredSendClockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PreferredSendClockSpecified
        {
            get
            {
                return this.preferredSendClockFieldSpecified;
            }
            set
            {
                this.preferredSendClockFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ApplicationRelationsTRT_Class3TimingProperties
    {

        private string sendClockField;

        private string reductionRatioField;

        private string reductionRatioPow2Field;

        private ushort maxReductionRatioIsochroneModeField;

        private bool maxReductionRatioIsochroneModeFieldSpecified;

        private ushort preferredSendClockField;

        private bool preferredSendClockFieldSpecified;

        public ApplicationRelationsTRT_Class3TimingProperties()
        {
            this.sendClockField = "32";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("32")]
        public string SendClock
        {
            get
            {
                return this.sendClockField;
            }
            set
            {
                this.sendClockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReductionRatio
        {
            get
            {
                return this.reductionRatioField;
            }
            set
            {
                this.reductionRatioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReductionRatioPow2
        {
            get
            {
                return this.reductionRatioPow2Field;
            }
            set
            {
                this.reductionRatioPow2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort MaxReductionRatioIsochroneMode
        {
            get
            {
                return this.maxReductionRatioIsochroneModeField;
            }
            set
            {
                this.maxReductionRatioIsochroneModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxReductionRatioIsochroneModeSpecified
        {
            get
            {
                return this.maxReductionRatioIsochroneModeFieldSpecified;
            }
            set
            {
                this.maxReductionRatioIsochroneModeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort PreferredSendClock
        {
            get
            {
                return this.preferredSendClockField;
            }
            set
            {
                this.preferredSendClockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PreferredSendClockSpecified
        {
            get
            {
                return this.preferredSendClockFieldSpecified;
            }
            set
            {
                this.preferredSendClockFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class RT_Class3PropertiesT
    {

        private string startupModeField;

        private string forwardingModeField;

        private ushort maxBridgeDelayField;

        private ushort maxBridgeDelayFFWField;

        private bool maxBridgeDelayFFWFieldSpecified;

        private ushort maxDFP_FeedField;

        private bool maxDFP_FeedFieldSpecified;

        private ushort maxDFP_FramesField;

        private bool alignDFP_SubframesField;

        private bool dFP_OutboundTruncationSupportedField;

        private bool dFP_RedundantPathLayoutSupportedField;

        private ushort maxNumberIR_FrameDataField;

        private ushort maxRangeIR_FrameIDField;

        private FragmentationTypeEnumT fragmentationTypeField;

        private bool fragmentationTypeFieldSpecified;

        private ushort maxRedPeriodLengthField;

        private ushort minFSOField;

        private ushort minRTC3_GapField;

        private uint minYellowTimeField;

        private ushort yellowSafetyMarginField;

        private uint maxRetentionTimeField;

        private bool maxRetentionTimeFieldSpecified;

        public RT_Class3PropertiesT()
        {
            this.startupModeField = "Legacy";
            this.maxDFP_FramesField = ((ushort)(0));
            this.alignDFP_SubframesField = false;
            this.dFP_OutboundTruncationSupportedField = false;
            this.dFP_RedundantPathLayoutSupportedField = false;
            this.maxRangeIR_FrameIDField = ((ushort)(1024));
            this.maxRedPeriodLengthField = ((ushort)(3875));
            this.minFSOField = ((ushort)(5000));
            this.minRTC3_GapField = ((ushort)(1120));
            this.minYellowTimeField = ((uint)(9600));
            this.yellowSafetyMarginField = ((ushort)(160));
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("Legacy")]
        public string StartupMode
        {
            get
            {
                return this.startupModeField;
            }
            set
            {
                this.startupModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ForwardingMode
        {
            get
            {
                return this.forwardingModeField;
            }
            set
            {
                this.forwardingModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort MaxBridgeDelay
        {
            get
            {
                return this.maxBridgeDelayField;
            }
            set
            {
                this.maxBridgeDelayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort MaxBridgeDelayFFW
        {
            get
            {
                return this.maxBridgeDelayFFWField;
            }
            set
            {
                this.maxBridgeDelayFFWField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxBridgeDelayFFWSpecified
        {
            get
            {
                return this.maxBridgeDelayFFWFieldSpecified;
            }
            set
            {
                this.maxBridgeDelayFFWFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort MaxDFP_Feed
        {
            get
            {
                return this.maxDFP_FeedField;
            }
            set
            {
                this.maxDFP_FeedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxDFP_FeedSpecified
        {
            get
            {
                return this.maxDFP_FeedFieldSpecified;
            }
            set
            {
                this.maxDFP_FeedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "0")]
        public ushort MaxDFP_Frames
        {
            get
            {
                return this.maxDFP_FramesField;
            }
            set
            {
                this.maxDFP_FramesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AlignDFP_Subframes
        {
            get
            {
                return this.alignDFP_SubframesField;
            }
            set
            {
                this.alignDFP_SubframesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool DFP_OutboundTruncationSupported
        {
            get
            {
                return this.dFP_OutboundTruncationSupportedField;
            }
            set
            {
                this.dFP_OutboundTruncationSupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool DFP_RedundantPathLayoutSupported
        {
            get
            {
                return this.dFP_RedundantPathLayoutSupportedField;
            }
            set
            {
                this.dFP_RedundantPathLayoutSupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort MaxNumberIR_FrameData
        {
            get
            {
                return this.maxNumberIR_FrameDataField;
            }
            set
            {
                this.maxNumberIR_FrameDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "1024")]
        public ushort MaxRangeIR_FrameID
        {
            get
            {
                return this.maxRangeIR_FrameIDField;
            }
            set
            {
                this.maxRangeIR_FrameIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FragmentationTypeEnumT FragmentationType
        {
            get
            {
                return this.fragmentationTypeField;
            }
            set
            {
                this.fragmentationTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FragmentationTypeSpecified
        {
            get
            {
                return this.fragmentationTypeFieldSpecified;
            }
            set
            {
                this.fragmentationTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "3875")]
        public ushort MaxRedPeriodLength
        {
            get
            {
                return this.maxRedPeriodLengthField;
            }
            set
            {
                this.maxRedPeriodLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "5000")]
        public ushort MinFSO
        {
            get
            {
                return this.minFSOField;
            }
            set
            {
                this.minFSOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "1120")]
        public ushort MinRTC3_Gap
        {
            get
            {
                return this.minRTC3_GapField;
            }
            set
            {
                this.minRTC3_GapField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "9600")]
        public uint MinYellowTime
        {
            get
            {
                return this.minYellowTimeField;
            }
            set
            {
                this.minYellowTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "160")]
        public ushort YellowSafetyMargin
        {
            get
            {
                return this.yellowSafetyMarginField;
            }
            set
            {
                this.yellowSafetyMarginField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint MaxRetentionTime
        {
            get
            {
                return this.maxRetentionTimeField;
            }
            set
            {
                this.maxRetentionTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxRetentionTimeSpecified
        {
            get
            {
                return this.maxRetentionTimeFieldSpecified;
            }
            set
            {
                this.maxRetentionTimeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public enum FragmentationTypeEnumT
    {

        /// <remarks/>
        Dynamic,

        /// <remarks/>
        Static,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class PROFIenergyT
    {

        private PROFIenergyTEnergySavingModeItem[] energySavingModeListField;

        private PROFIenergyTMeasurementItem[] measurementListField;

        private string profileVersionField;

        private PE_EntityClassEnumT entityClassField;

        private bool entityClassFieldSpecified;

        private PE_EntitySubclassEnumT entitySubclassField;

        private bool entitySubclassFieldSpecified;

        private bool dynamicTimeAndEnergyValuesField;

        private bool pESAP_uses_PROFIenergyASEField;

        public PROFIenergyT()
        {
            this.dynamicTimeAndEnergyValuesField = false;
            this.pESAP_uses_PROFIenergyASEField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("EnergySavingModeItem", IsNullable = false)]
        public PROFIenergyTEnergySavingModeItem[] EnergySavingModeList
        {
            get
            {
                return this.energySavingModeListField;
            }
            set
            {
                this.energySavingModeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("MeasurementItem", IsNullable = false)]
        public PROFIenergyTMeasurementItem[] MeasurementList
        {
            get
            {
                return this.measurementListField;
            }
            set
            {
                this.measurementListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProfileVersion
        {
            get
            {
                return this.profileVersionField;
            }
            set
            {
                this.profileVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PE_EntityClassEnumT EntityClass
        {
            get
            {
                return this.entityClassField;
            }
            set
            {
                this.entityClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EntityClassSpecified
        {
            get
            {
                return this.entityClassFieldSpecified;
            }
            set
            {
                this.entityClassFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PE_EntitySubclassEnumT EntitySubclass
        {
            get
            {
                return this.entitySubclassField;
            }
            set
            {
                this.entitySubclassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EntitySubclassSpecified
        {
            get
            {
                return this.entitySubclassFieldSpecified;
            }
            set
            {
                this.entitySubclassFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool DynamicTimeAndEnergyValues
        {
            get
            {
                return this.dynamicTimeAndEnergyValuesField;
            }
            set
            {
                this.dynamicTimeAndEnergyValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool PESAP_uses_PROFIenergyASE
        {
            get
            {
                return this.pESAP_uses_PROFIenergyASEField;
            }
            set
            {
                this.pESAP_uses_PROFIenergyASEField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class PROFIenergyTEnergySavingModeItem
    {

        private byte idField;

        private uint timeToPauseField;

        private uint rTTOField;

        private uint timeMinLengthOfStayField;

        private float powerConsumptionField;

        private float energyConsumptionToDestinationField;

        private float energyConsumptionToOperationField;

        public PROFIenergyTEnergySavingModeItem()
        {
            this.powerConsumptionField = ((float)(0F));
            this.energyConsumptionToDestinationField = ((float)(0F));
            this.energyConsumptionToOperationField = ((float)(0F));
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ID
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
        public uint TimeToPause
        {
            get
            {
                return this.timeToPauseField;
            }
            set
            {
                this.timeToPauseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint RTTO
        {
            get
            {
                return this.rTTOField;
            }
            set
            {
                this.rTTOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint TimeMinLengthOfStay
        {
            get
            {
                return this.timeMinLengthOfStayField;
            }
            set
            {
                this.timeMinLengthOfStayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
        public float PowerConsumption
        {
            get
            {
                return this.powerConsumptionField;
            }
            set
            {
                this.powerConsumptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
        public float EnergyConsumptionToDestination
        {
            get
            {
                return this.energyConsumptionToDestinationField;
            }
            set
            {
                this.energyConsumptionToDestinationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
        public float EnergyConsumptionToOperation
        {
            get
            {
                return this.energyConsumptionToOperationField;
            }
            set
            {
                this.energyConsumptionToOperationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class PROFIenergyTMeasurementItem
    {

        private PROFIenergyTMeasurementItemMeasurementValue[] measurementValueField;

        private ushort numberField;

        private bool numberFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeasurementValue")]
        public PROFIenergyTMeasurementItemMeasurementValue[] MeasurementValue
        {
            get
            {
                return this.measurementValueField;
            }
            set
            {
                this.measurementValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberSpecified
        {
            get
            {
                return this.numberFieldSpecified;
            }
            set
            {
                this.numberFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class PROFIenergyTMeasurementItemMeasurementValue
    {

        private ushort idField;

        private byte accuracyDomainField;

        private byte accuracyClassField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ID
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
        public byte AccuracyDomain
        {
            get
            {
                return this.accuracyDomainField;
            }
            set
            {
                this.accuracyDomainField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte AccuracyClass
        {
            get
            {
                return this.accuracyClassField;
            }
            set
            {
                this.accuracyClassField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public enum PE_EntityClassEnumT
    {

        /// <remarks/>
        Class1,

        /// <remarks/>
        Class2,

        /// <remarks/>
        Class3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public enum PE_EntitySubclassEnumT
    {

        /// <remarks/>
        Subclass1,

        /// <remarks/>
        Subclass2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class F_ParameterRecordDataT
    {

        private F_ParameterRecordDataTF_Check_iPar f_Check_iParField;

        private F_ParameterRecordDataTF_SIL f_SILField;

        private F_ParameterRecordDataTF_CRC_Length f_CRC_LengthField;

        private F_ParameterRecordDataTF_CRC_Seed f_CRC_SeedField;

        private F_ParameterRecordDataTF_Passivation f_PassivationField;

        private F_ParameterRecordDataTF_Block_ID f_Block_IDField;

        private F_ParameterRecordDataTF_Par_Version f_Par_VersionField;

        private F_ParameterRecordDataTF_Source_Add f_Source_AddField;

        private F_ParameterRecordDataTF_Dest_Add f_Dest_AddField;

        private F_ParameterRecordDataTF_WD_Time f_WD_TimeField;

        private F_ParameterRecordDataTF_Par_CRC f_Par_CRCField;

        private F_ParameterRecordDataTF_iPar_CRC f_iPar_CRCField;

        private ushort f_ParamDescCRCField;

        private string f_SupportedParametersField;

        private ushort indexField;

        private ushort transferSequenceField;

        private bool changeableWithBumpField;

        public F_ParameterRecordDataT()
        {
            this.transferSequenceField = ((ushort)(0));
            this.changeableWithBumpField = false;
        }

        /// <remarks/>
        public F_ParameterRecordDataTF_Check_iPar F_Check_iPar
        {
            get
            {
                return this.f_Check_iParField;
            }
            set
            {
                this.f_Check_iParField = value;
            }
        }

        /// <remarks/>
        public F_ParameterRecordDataTF_SIL F_SIL
        {
            get
            {
                return this.f_SILField;
            }
            set
            {
                this.f_SILField = value;
            }
        }

        /// <remarks/>
        public F_ParameterRecordDataTF_CRC_Length F_CRC_Length
        {
            get
            {
                return this.f_CRC_LengthField;
            }
            set
            {
                this.f_CRC_LengthField = value;
            }
        }

        /// <remarks/>
        public F_ParameterRecordDataTF_CRC_Seed F_CRC_Seed
        {
            get
            {
                return this.f_CRC_SeedField;
            }
            set
            {
                this.f_CRC_SeedField = value;
            }
        }

        /// <remarks/>
        public F_ParameterRecordDataTF_Passivation F_Passivation
        {
            get
            {
                return this.f_PassivationField;
            }
            set
            {
                this.f_PassivationField = value;
            }
        }

        /// <remarks/>
        public F_ParameterRecordDataTF_Block_ID F_Block_ID
        {
            get
            {
                return this.f_Block_IDField;
            }
            set
            {
                this.f_Block_IDField = value;
            }
        }

        /// <remarks/>
        public F_ParameterRecordDataTF_Par_Version F_Par_Version
        {
            get
            {
                return this.f_Par_VersionField;
            }
            set
            {
                this.f_Par_VersionField = value;
            }
        }

        /// <remarks/>
        public F_ParameterRecordDataTF_Source_Add F_Source_Add
        {
            get
            {
                return this.f_Source_AddField;
            }
            set
            {
                this.f_Source_AddField = value;
            }
        }

        /// <remarks/>
        public F_ParameterRecordDataTF_Dest_Add F_Dest_Add
        {
            get
            {
                return this.f_Dest_AddField;
            }
            set
            {
                this.f_Dest_AddField = value;
            }
        }

        /// <remarks/>
        public F_ParameterRecordDataTF_WD_Time F_WD_Time
        {
            get
            {
                return this.f_WD_TimeField;
            }
            set
            {
                this.f_WD_TimeField = value;
            }
        }

        /// <remarks/>
        public F_ParameterRecordDataTF_Par_CRC F_Par_CRC
        {
            get
            {
                return this.f_Par_CRCField;
            }
            set
            {
                this.f_Par_CRCField = value;
            }
        }

        /// <remarks/>
        public F_ParameterRecordDataTF_iPar_CRC F_iPar_CRC
        {
            get
            {
                return this.f_iPar_CRCField;
            }
            set
            {
                this.f_iPar_CRCField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort F_ParamDescCRC
        {
            get
            {
                return this.f_ParamDescCRCField;
            }
            set
            {
                this.f_ParamDescCRCField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string F_SupportedParameters
        {
            get
            {
                return this.f_SupportedParametersField;
            }
            set
            {
                this.f_SupportedParametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Index
        {
            get
            {
                return this.indexField;
            }
            set
            {
                this.indexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "0")]
        public ushort TransferSequence
        {
            get
            {
                return this.transferSequenceField;
            }
            set
            {
                this.transferSequenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ChangeableWithBump
        {
            get
            {
                return this.changeableWithBumpField;
            }
            set
            {
                this.changeableWithBumpField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class F_ParameterRecordDataTF_Check_iPar
    {

        private F_Check_iParEnumT defaultValueField;

        private string allowedValuesField;

        private bool changeableField;

        private bool visibleField;

        public F_ParameterRecordDataTF_Check_iPar()
        {
            this.defaultValueField = F_Check_iParEnumT.NoCheck;
            this.allowedValuesField = "Check NoCheck";
            this.changeableField = false;
            this.visibleField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(F_Check_iParEnumT.NoCheck)]
        public F_Check_iParEnumT DefaultValue
        {
            get
            {
                return this.defaultValueField;
            }
            set
            {
                this.defaultValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("Check NoCheck")]
        public string AllowedValues
        {
            get
            {
                return this.allowedValuesField;
            }
            set
            {
                this.allowedValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Changeable
        {
            get
            {
                return this.changeableField;
            }
            set
            {
                this.changeableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Visible
        {
            get
            {
                return this.visibleField;
            }
            set
            {
                this.visibleField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public enum F_Check_iParEnumT
    {

        /// <remarks/>
        Check,

        /// <remarks/>
        NoCheck,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class F_ParameterRecordDataTF_SIL
    {

        private F_SIL_EnumT defaultValueField;

        private string allowedValuesField;

        private bool changeableField;

        private bool visibleField;

        private bool visibleFieldSpecified;

        public F_ParameterRecordDataTF_SIL()
        {
            this.defaultValueField = F_SIL_EnumT.SIL3;
            this.allowedValuesField = "SIL1 SIL2 SIL3 NoSIL";
            this.changeableField = true;
            this.visibleField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(F_SIL_EnumT.SIL3)]
        public F_SIL_EnumT DefaultValue
        {
            get
            {
                return this.defaultValueField;
            }
            set
            {
                this.defaultValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("SIL1 SIL2 SIL3 NoSIL")]
        public string AllowedValues
        {
            get
            {
                return this.allowedValuesField;
            }
            set
            {
                this.allowedValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Changeable
        {
            get
            {
                return this.changeableField;
            }
            set
            {
                this.changeableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Visible
        {
            get
            {
                return this.visibleField;
            }
            set
            {
                this.visibleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VisibleSpecified
        {
            get
            {
                return this.visibleFieldSpecified;
            }
            set
            {
                this.visibleFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public enum F_SIL_EnumT
    {

        /// <remarks/>
        SIL1,

        /// <remarks/>
        SIL2,

        /// <remarks/>
        SIL3,

        /// <remarks/>
        NoSIL,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class F_ParameterRecordDataTF_CRC_Length
    {

        private F_CRC_LengthEnumT defaultValueField;

        private string allowedValuesField;

        private bool changeableField;

        private bool changeableFieldSpecified;

        private bool visibleField;

        public F_ParameterRecordDataTF_CRC_Length()
        {
            this.defaultValueField = F_CRC_LengthEnumT.Item3ByteCRC;
            this.allowedValuesField = "3-Byte-CRC";
            this.changeableField = false;
            this.visibleField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(F_CRC_LengthEnumT.Item3ByteCRC)]
        public F_CRC_LengthEnumT DefaultValue
        {
            get
            {
                return this.defaultValueField;
            }
            set
            {
                this.defaultValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("3-Byte-CRC")]
        public string AllowedValues
        {
            get
            {
                return this.allowedValuesField;
            }
            set
            {
                this.allowedValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Changeable
        {
            get
            {
                return this.changeableField;
            }
            set
            {
                this.changeableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChangeableSpecified
        {
            get
            {
                return this.changeableFieldSpecified;
            }
            set
            {
                this.changeableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Visible
        {
            get
            {
                return this.visibleField;
            }
            set
            {
                this.visibleField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public enum F_CRC_LengthEnumT
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3-Byte-CRC")]
        Item3ByteCRC,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4-Byte-CRC")]
        Item4ByteCRC,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class F_ParameterRecordDataTF_CRC_Seed
    {

        private F_CRC_SeedEnumT defaultValueField;

        private bool defaultValueFieldSpecified;

        private string allowedValuesField;

        private bool changeableField;

        private bool changeableFieldSpecified;

        private bool visibleField;

        private bool visibleFieldSpecified;

        public F_ParameterRecordDataTF_CRC_Seed()
        {
            this.defaultValueField = F_CRC_SeedEnumT.CRCSeed2432;
            this.allowedValuesField = "CRC-Seed24/32";
            this.changeableField = false;
            this.visibleField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public F_CRC_SeedEnumT DefaultValue
        {
            get
            {
                return this.defaultValueField;
            }
            set
            {
                this.defaultValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DefaultValueSpecified
        {
            get
            {
                return this.defaultValueFieldSpecified;
            }
            set
            {
                this.defaultValueFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowedValues
        {
            get
            {
                return this.allowedValuesField;
            }
            set
            {
                this.allowedValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Changeable
        {
            get
            {
                return this.changeableField;
            }
            set
            {
                this.changeableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChangeableSpecified
        {
            get
            {
                return this.changeableFieldSpecified;
            }
            set
            {
                this.changeableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Visible
        {
            get
            {
                return this.visibleField;
            }
            set
            {
                this.visibleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VisibleSpecified
        {
            get
            {
                return this.visibleFieldSpecified;
            }
            set
            {
                this.visibleFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public enum F_CRC_SeedEnumT
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("CRC-Seed24/32")]
        CRCSeed2432,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class F_ParameterRecordDataTF_Passivation
    {

        private F_PassivationEnumT defaultValueField;

        private string allowedValuesField;

        private bool changeableField;

        private bool changeableFieldSpecified;

        private bool visibleField;

        private bool visibleFieldSpecified;

        public F_ParameterRecordDataTF_Passivation()
        {
            this.defaultValueField = F_PassivationEnumT.DeviceModule;
            this.allowedValuesField = "Device/Module";
            this.changeableField = false;
            this.visibleField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(F_PassivationEnumT.DeviceModule)]
        public F_PassivationEnumT DefaultValue
        {
            get
            {
                return this.defaultValueField;
            }
            set
            {
                this.defaultValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("Device/Module")]
        public string AllowedValues
        {
            get
            {
                return this.allowedValuesField;
            }
            set
            {
                this.allowedValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Changeable
        {
            get
            {
                return this.changeableField;
            }
            set
            {
                this.changeableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChangeableSpecified
        {
            get
            {
                return this.changeableFieldSpecified;
            }
            set
            {
                this.changeableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Visible
        {
            get
            {
                return this.visibleField;
            }
            set
            {
                this.visibleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VisibleSpecified
        {
            get
            {
                return this.visibleFieldSpecified;
            }
            set
            {
                this.visibleFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public enum F_PassivationEnumT
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Device/Module")]
        DeviceModule,

        /// <remarks/>
        Channel,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class F_ParameterRecordDataTF_Block_ID
    {

        private byte defaultValueField;

        private string allowedValuesField;

        private bool changeableField;

        private bool visibleField;

        public F_ParameterRecordDataTF_Block_ID()
        {
            this.defaultValueField = ((byte)(0));
            this.allowedValuesField = "0..7";
            this.changeableField = false;
            this.visibleField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "0")]
        public byte DefaultValue
        {
            get
            {
                return this.defaultValueField;
            }
            set
            {
                this.defaultValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("0..7")]
        public string AllowedValues
        {
            get
            {
                return this.allowedValuesField;
            }
            set
            {
                this.allowedValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Changeable
        {
            get
            {
                return this.changeableField;
            }
            set
            {
                this.changeableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Visible
        {
            get
            {
                return this.visibleField;
            }
            set
            {
                this.visibleField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class F_ParameterRecordDataTF_Par_Version
    {

        private byte defaultValueField;

        private bool defaultValueFieldSpecified;

        private string allowedValuesField;

        private bool changeableField;

        private bool changeableFieldSpecified;

        private bool visibleField;

        private bool visibleFieldSpecified;

        public F_ParameterRecordDataTF_Par_Version()
        {
            this.defaultValueField = ((byte)(1));
            this.allowedValuesField = "1";
            this.changeableField = false;
            this.visibleField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DefaultValue
        {
            get
            {
                return this.defaultValueField;
            }
            set
            {
                this.defaultValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DefaultValueSpecified
        {
            get
            {
                return this.defaultValueFieldSpecified;
            }
            set
            {
                this.defaultValueFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowedValues
        {
            get
            {
                return this.allowedValuesField;
            }
            set
            {
                this.allowedValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Changeable
        {
            get
            {
                return this.changeableField;
            }
            set
            {
                this.changeableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChangeableSpecified
        {
            get
            {
                return this.changeableFieldSpecified;
            }
            set
            {
                this.changeableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Visible
        {
            get
            {
                return this.visibleField;
            }
            set
            {
                this.visibleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VisibleSpecified
        {
            get
            {
                return this.visibleFieldSpecified;
            }
            set
            {
                this.visibleFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class F_ParameterRecordDataTF_Source_Add
    {

        private ushort defaultValueField;

        private string allowedValuesField;

        private bool changeableField;

        private bool changeableFieldSpecified;

        private bool visibleField;

        private bool visibleFieldSpecified;

        public F_ParameterRecordDataTF_Source_Add()
        {
            this.defaultValueField = ((ushort)(1));
            this.allowedValuesField = "1..65534";
            this.changeableField = true;
            this.visibleField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "1")]
        public ushort DefaultValue
        {
            get
            {
                return this.defaultValueField;
            }
            set
            {
                this.defaultValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("1..65534")]
        public string AllowedValues
        {
            get
            {
                return this.allowedValuesField;
            }
            set
            {
                this.allowedValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Changeable
        {
            get
            {
                return this.changeableField;
            }
            set
            {
                this.changeableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChangeableSpecified
        {
            get
            {
                return this.changeableFieldSpecified;
            }
            set
            {
                this.changeableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Visible
        {
            get
            {
                return this.visibleField;
            }
            set
            {
                this.visibleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VisibleSpecified
        {
            get
            {
                return this.visibleFieldSpecified;
            }
            set
            {
                this.visibleFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class F_ParameterRecordDataTF_Dest_Add
    {

        private ushort defaultValueField;

        private string allowedValuesField;

        private bool changeableField;

        private bool changeableFieldSpecified;

        private bool visibleField;

        private bool visibleFieldSpecified;

        public F_ParameterRecordDataTF_Dest_Add()
        {
            this.defaultValueField = ((ushort)(1));
            this.allowedValuesField = "1..65534";
            this.changeableField = true;
            this.visibleField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "1")]
        public ushort DefaultValue
        {
            get
            {
                return this.defaultValueField;
            }
            set
            {
                this.defaultValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("1..65534")]
        public string AllowedValues
        {
            get
            {
                return this.allowedValuesField;
            }
            set
            {
                this.allowedValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Changeable
        {
            get
            {
                return this.changeableField;
            }
            set
            {
                this.changeableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChangeableSpecified
        {
            get
            {
                return this.changeableFieldSpecified;
            }
            set
            {
                this.changeableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Visible
        {
            get
            {
                return this.visibleField;
            }
            set
            {
                this.visibleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VisibleSpecified
        {
            get
            {
                return this.visibleFieldSpecified;
            }
            set
            {
                this.visibleFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class F_ParameterRecordDataTF_WD_Time
    {

        private ushort defaultValueField;

        private string allowedValuesField;

        private bool changeableField;

        private bool changeableFieldSpecified;

        private bool visibleField;

        private bool visibleFieldSpecified;

        public F_ParameterRecordDataTF_WD_Time()
        {
            this.defaultValueField = ((ushort)(150));
            this.allowedValuesField = "1..65535";
            this.changeableField = true;
            this.visibleField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "150")]
        public ushort DefaultValue
        {
            get
            {
                return this.defaultValueField;
            }
            set
            {
                this.defaultValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("1..65535")]
        public string AllowedValues
        {
            get
            {
                return this.allowedValuesField;
            }
            set
            {
                this.allowedValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Changeable
        {
            get
            {
                return this.changeableField;
            }
            set
            {
                this.changeableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChangeableSpecified
        {
            get
            {
                return this.changeableFieldSpecified;
            }
            set
            {
                this.changeableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Visible
        {
            get
            {
                return this.visibleField;
            }
            set
            {
                this.visibleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VisibleSpecified
        {
            get
            {
                return this.visibleFieldSpecified;
            }
            set
            {
                this.visibleFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class F_ParameterRecordDataTF_Par_CRC
    {

        private ushort defaultValueField;

        private string allowedValuesField;

        private bool changeableField;

        private bool changeableFieldSpecified;

        private bool visibleField;

        private bool visibleFieldSpecified;

        public F_ParameterRecordDataTF_Par_CRC()
        {
            this.defaultValueField = ((ushort)(53356));
            this.allowedValuesField = "0..65535";
            this.changeableField = true;
            this.visibleField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "53356")]
        public ushort DefaultValue
        {
            get
            {
                return this.defaultValueField;
            }
            set
            {
                this.defaultValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowedValues
        {
            get
            {
                return this.allowedValuesField;
            }
            set
            {
                this.allowedValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Changeable
        {
            get
            {
                return this.changeableField;
            }
            set
            {
                this.changeableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChangeableSpecified
        {
            get
            {
                return this.changeableFieldSpecified;
            }
            set
            {
                this.changeableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Visible
        {
            get
            {
                return this.visibleField;
            }
            set
            {
                this.visibleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VisibleSpecified
        {
            get
            {
                return this.visibleFieldSpecified;
            }
            set
            {
                this.visibleFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class F_ParameterRecordDataTF_iPar_CRC
    {

        private uint defaultValueField;

        private string allowedValuesField;

        private bool changeableField;

        private bool changeableFieldSpecified;

        private bool visibleField;

        private bool visibleFieldSpecified;

        public F_ParameterRecordDataTF_iPar_CRC()
        {
            this.defaultValueField = ((uint)(0));
            this.allowedValuesField = "0..4294967295";
            this.changeableField = true;
            this.visibleField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint DefaultValue
        {
            get
            {
                return this.defaultValueField;
            }
            set
            {
                this.defaultValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowedValues
        {
            get
            {
                return this.allowedValuesField;
            }
            set
            {
                this.allowedValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Changeable
        {
            get
            {
                return this.changeableField;
            }
            set
            {
                this.changeableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChangeableSpecified
        {
            get
            {
                return this.changeableFieldSpecified;
            }
            set
            {
                this.changeableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Visible
        {
            get
            {
                return this.visibleField;
            }
            set
            {
                this.visibleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VisibleSpecified
        {
            get
            {
                return this.visibleFieldSpecified;
            }
            set
            {
                this.visibleFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ParameterRecordDataT
    {

        private ExternalTextRefT nameField;

        private object[] itemsField;

        private MenuItemT[] menuListField;

        private string indexField;

        private uint lengthField;

        private ushort transferSequenceField;

        private bool changeableWithBumpField;

        public ParameterRecordDataT()
        {
            this.transferSequenceField = ((ushort)(0));
            this.changeableWithBumpField = false;
        }

        /// <remarks/>
        public ExternalTextRefT Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Const", typeof(RecordDataConstT))]
        [System.Xml.Serialization.XmlElementAttribute("Ref", typeof(RecordDataRefT))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("MenuItem", IsNullable = false)]
        public MenuItemT[] MenuList
        {
            get
            {
                return this.menuListField;
            }
            set
            {
                this.menuListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Index
        {
            get
            {
                return this.indexField;
            }
            set
            {
                this.indexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint Length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "0")]
        public ushort TransferSequence
        {
            get
            {
                return this.transferSequenceField;
            }
            set
            {
                this.transferSequenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ChangeableWithBump
        {
            get
            {
                return this.changeableWithBumpField;
            }
            set
            {
                this.changeableWithBumpField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class RecordDataConstT
    {

        private uint byteOffsetField;

        private string dataField;

        public RecordDataConstT()
        {
            this.byteOffsetField = ((uint)(0));
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint ByteOffset
        {
            get
            {
                return this.byteOffsetField;
            }
            set
            {
                this.byteOffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class MenuItemT : ObjectT
    {

        private ExternalTextRefT nameField;

        private object[] itemsField;

        /// <remarks/>
        public ExternalTextRefT Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MenuRef", typeof(MenuRefT))]
        [System.Xml.Serialization.XmlElementAttribute("ParameterRef", typeof(ParameterRefT))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class MenuRefT
    {

        private string menuTargetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string MenuTarget
        {
            get
            {
                return this.menuTargetField;
            }
            set
            {
                this.menuTargetField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ParameterRefT
    {

        private string parameterTargetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string ParameterTarget
        {
            get
            {
                return this.parameterTargetField;
            }
            set
            {
                this.parameterTargetField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CategoryItemT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GraphicItemT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValueItemT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ModuleItemT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PortSubmoduleItemBaseT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BuiltInPortSubmoduleItemT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PortSubmoduleItemT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InterfaceSubmoduleItemT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubmoduleItemBaseT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BuiltInSubmoduleItemT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubmoduleItemT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MenuItemT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeviceAccessPointItemT))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public partial class ObjectT
    {

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string ID
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class CategoryItemT : ObjectT
    {

        private ExternalTextRefT infoTextField;

        private string textIdField;

        /// <remarks/>
        public ExternalTextRefT InfoText
        {
            get
            {
                return this.infoTextField;
            }
            set
            {
                this.infoTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string TextId
        {
            get
            {
                return this.textIdField;
            }
            set
            {
                this.textIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class GraphicItemT : ObjectT
    {

        private GraphicItemTEmbedded embeddedField;

        private string graphicFileField;

        /// <remarks/>
        public GraphicItemTEmbedded Embedded
        {
            get
            {
                return this.embeddedField;
            }
            set
            {
                this.embeddedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GraphicFile
        {
            get
            {
                return this.graphicFileField;
            }
            set
            {
                this.graphicFileField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class GraphicItemTEmbedded
    {

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ValueItemT : ObjectT
    {

        private ExternalTextRefT helpField;

        private ValueAssignmentsTAssign[] assignmentsField;

        /// <remarks/>
        public ExternalTextRefT Help
        {
            get
            {
                return this.helpField;
            }
            set
            {
                this.helpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Assign", IsNullable = false)]
        public ValueAssignmentsTAssign[] Assignments
        {
            get
            {
                return this.assignmentsField;
            }
            set
            {
                this.assignmentsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ValueAssignmentsTAssign
    {

        private string textIdField;

        private string contentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string TextId
        {
            get
            {
                return this.textIdField;
            }
            set
            {
                this.textIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ModuleItemT : ObjectT
    {

        private ModuleInfoT moduleInfoField;

        private SubslotListTSubslotItem[] subslotListField;

        private BuiltInSubmoduleItemT[] virtualSubmoduleListField;

        private BuiltInPortSubmoduleItemT[] systemDefinedSubmoduleListField;

        private UseableSubmodulesTSubmoduleItemRef[] useableSubmodulesField;

        private GraphicsReferenceTGraphicItemRef[] graphicsField;

        private string moduleIdentNumberField;

        private string requiredSchemaVersionField;

        private string physicalSubslotsField;

        private ushort fieldbusTypeField;

        private bool fieldbusTypeFieldSpecified;

        public ModuleItemT()
        {
            this.requiredSchemaVersionField = "V1.0";
        }

        /// <remarks/>
        public ModuleInfoT ModuleInfo
        {
            get
            {
                return this.moduleInfoField;
            }
            set
            {
                this.moduleInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SubslotItem", IsNullable = false)]
        public SubslotListTSubslotItem[] SubslotList
        {
            get
            {
                return this.subslotListField;
            }
            set
            {
                this.subslotListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("VirtualSubmoduleItem", IsNullable = false)]
        public BuiltInSubmoduleItemT[] VirtualSubmoduleList
        {
            get
            {
                return this.virtualSubmoduleListField;
            }
            set
            {
                this.virtualSubmoduleListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PortSubmoduleItem", IsNullable = false)]
        public BuiltInPortSubmoduleItemT[] SystemDefinedSubmoduleList
        {
            get
            {
                return this.systemDefinedSubmoduleListField;
            }
            set
            {
                this.systemDefinedSubmoduleListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SubmoduleItemRef", IsNullable = false)]
        public UseableSubmodulesTSubmoduleItemRef[] UseableSubmodules
        {
            get
            {
                return this.useableSubmodulesField;
            }
            set
            {
                this.useableSubmodulesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("GraphicItemRef", IsNullable = false)]
        public GraphicsReferenceTGraphicItemRef[] Graphics
        {
            get
            {
                return this.graphicsField;
            }
            set
            {
                this.graphicsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ModuleIdentNumber
        {
            get
            {
                return this.moduleIdentNumberField;
            }
            set
            {
                this.moduleIdentNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("V1.0")]
        public string RequiredSchemaVersion
        {
            get
            {
                return this.requiredSchemaVersionField;
            }
            set
            {
                this.requiredSchemaVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PhysicalSubslots
        {
            get
            {
                return this.physicalSubslotsField;
            }
            set
            {
                this.physicalSubslotsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort FieldbusType
        {
            get
            {
                return this.fieldbusTypeField;
            }
            set
            {
                this.fieldbusTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FieldbusTypeSpecified
        {
            get
            {
                return this.fieldbusTypeFieldSpecified;
            }
            set
            {
                this.fieldbusTypeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ModuleInfoT
    {

        private ExternalTextRefT nameField;

        private ExternalTextRefT infoTextField;

        private FamilyT familyField;

        private TokenParameterT vendorNameField;

        private TokenParameterT orderNumberField;

        private TokenParameterT hardwareReleaseField;

        private TokenParameterT softwareReleaseField;

        private string categoryRefField;

        private string subCategory1RefField;

        /// <remarks/>
        public ExternalTextRefT Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ExternalTextRefT InfoText
        {
            get
            {
                return this.infoTextField;
            }
            set
            {
                this.infoTextField = value;
            }
        }

        /// <remarks/>
        public FamilyT Family
        {
            get
            {
                return this.familyField;
            }
            set
            {
                this.familyField = value;
            }
        }

        /// <remarks/>
        public TokenParameterT VendorName
        {
            get
            {
                return this.vendorNameField;
            }
            set
            {
                this.vendorNameField = value;
            }
        }

        /// <remarks/>
        public TokenParameterT OrderNumber
        {
            get
            {
                return this.orderNumberField;
            }
            set
            {
                this.orderNumberField = value;
            }
        }

        /// <remarks/>
        public TokenParameterT HardwareRelease
        {
            get
            {
                return this.hardwareReleaseField;
            }
            set
            {
                this.hardwareReleaseField = value;
            }
        }

        /// <remarks/>
        public TokenParameterT SoftwareRelease
        {
            get
            {
                return this.softwareReleaseField;
            }
            set
            {
                this.softwareReleaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string CategoryRef
        {
            get
            {
                return this.categoryRefField;
            }
            set
            {
                this.categoryRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string SubCategory1Ref
        {
            get
            {
                return this.subCategory1RefField;
            }
            set
            {
                this.subCategory1RefField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class FamilyT
    {

        private FamilyEnumT mainFamilyField;

        private string productFamilyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FamilyEnumT MainFamily
        {
            get
            {
                return this.mainFamilyField;
            }
            set
            {
                this.mainFamilyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
        public string ProductFamily
        {
            get
            {
                return this.productFamilyField;
            }
            set
            {
                this.productFamilyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public enum FamilyEnumT
    {

        /// <remarks/>
        General,

        /// <remarks/>
        Drives,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Switching Devices")]
        SwitchingDevices,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("I/O")]
        IO,

        /// <remarks/>
        Valves,

        /// <remarks/>
        Controllers,

        /// <remarks/>
        HMI,

        /// <remarks/>
        Encoders,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("NC/RC")]
        NCRC,

        /// <remarks/>
        Gateway,

        /// <remarks/>
        PLCs,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Ident Systems")]
        IdentSystems,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("PA Profiles")]
        PAProfiles,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Network Components")]
        NetworkComponents,

        /// <remarks/>
        Sensors,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public partial class TokenParameterT
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class SubslotListTSubslotItem
    {

        private ushort subslotNumberField;

        private string textIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort SubslotNumber
        {
            get
            {
                return this.subslotNumberField;
            }
            set
            {
                this.subslotNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string TextId
        {
            get
            {
                return this.textIdField;
            }
            set
            {
                this.textIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class BuiltInSubmoduleItemT : SubmoduleItemBaseT
    {

        private string fixedInSubslotsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FixedInSubslots
        {
            get
            {
                return this.fixedInSubslotsField;
            }
            set
            {
                this.fixedInSubslotsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BuiltInSubmoduleItemT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubmoduleItemT))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class SubmoduleItemBaseT : ObjectT
    {

        private SubmoduleItemBaseTIOData iODataField;

        private SubmoduleItemBaseTRecordDataList recordDataListField;

        private ModuleInfoT moduleInfoField;

        private GraphicsReferenceTGraphicItemRef[] graphicsField;

        private SubmoduleItemBaseTIsochroneMode isochroneModeField;

        private SubmoduleItemBaseTSlotCluster slotClusterField;

        private PROFIenergyT pROFIenergyField;

        private ReportingSystemEventsTObserver[] reportingSystemEventsField;

        private string submoduleIdentNumberField;

        private uint aPIField;

        private bool pROFIsafeSupportedField;

        private string writeable_IM_RecordsField;

        private bool iM5_SupportedField;

        private uint max_iParameterSizeField;

        private ushort subsysModuleDirIndexField;

        private bool subsysModuleDirIndexFieldSpecified;

        private string supportedSubstitutionModesField;

        private bool mayIssueProcessAlarmField;

        public SubmoduleItemBaseT()
        {
            this.aPIField = ((uint)(0));
            this.pROFIsafeSupportedField = false;
            this.iM5_SupportedField = false;
            this.max_iParameterSizeField = ((uint)(0));
        }

        /// <remarks/>
        public SubmoduleItemBaseTIOData IOData
        {
            get
            {
                return this.iODataField;
            }
            set
            {
                this.iODataField = value;
            }
        }

        /// <remarks/>
        public SubmoduleItemBaseTRecordDataList RecordDataList
        {
            get
            {
                return this.recordDataListField;
            }
            set
            {
                this.recordDataListField = value;
            }
        }

        /// <remarks/>
        public ModuleInfoT ModuleInfo
        {
            get
            {
                return this.moduleInfoField;
            }
            set
            {
                this.moduleInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("GraphicItemRef", IsNullable = false)]
        public GraphicsReferenceTGraphicItemRef[] Graphics
        {
            get
            {
                return this.graphicsField;
            }
            set
            {
                this.graphicsField = value;
            }
        }

        /// <remarks/>
        public SubmoduleItemBaseTIsochroneMode IsochroneMode
        {
            get
            {
                return this.isochroneModeField;
            }
            set
            {
                this.isochroneModeField = value;
            }
        }

        /// <remarks/>
        public SubmoduleItemBaseTSlotCluster SlotCluster
        {
            get
            {
                return this.slotClusterField;
            }
            set
            {
                this.slotClusterField = value;
            }
        }

        /// <remarks/>
        public PROFIenergyT PROFIenergy
        {
            get
            {
                return this.pROFIenergyField;
            }
            set
            {
                this.pROFIenergyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Observer", IsNullable = false)]
        public ReportingSystemEventsTObserver[] ReportingSystemEvents
        {
            get
            {
                return this.reportingSystemEventsField;
            }
            set
            {
                this.reportingSystemEventsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubmoduleIdentNumber
        {
            get
            {
                return this.submoduleIdentNumberField;
            }
            set
            {
                this.submoduleIdentNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint API
        {
            get
            {
                return this.aPIField;
            }
            set
            {
                this.aPIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool PROFIsafeSupported
        {
            get
            {
                return this.pROFIsafeSupportedField;
            }
            set
            {
                this.pROFIsafeSupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Writeable_IM_Records
        {
            get
            {
                return this.writeable_IM_RecordsField;
            }
            set
            {
                this.writeable_IM_RecordsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IM5_Supported
        {
            get
            {
                return this.iM5_SupportedField;
            }
            set
            {
                this.iM5_SupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint Max_iParameterSize
        {
            get
            {
                return this.max_iParameterSizeField;
            }
            set
            {
                this.max_iParameterSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort SubsysModuleDirIndex
        {
            get
            {
                return this.subsysModuleDirIndexField;
            }
            set
            {
                this.subsysModuleDirIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SubsysModuleDirIndexSpecified
        {
            get
            {
                return this.subsysModuleDirIndexFieldSpecified;
            }
            set
            {
                this.subsysModuleDirIndexFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SupportedSubstitutionModes
        {
            get
            {
                return this.supportedSubstitutionModesField;
            }
            set
            {
                this.supportedSubstitutionModesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MayIssueProcessAlarm
        {
            get
            {
                return this.mayIssueProcessAlarmField;
            }
            set
            {
                this.mayIssueProcessAlarmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class SubmoduleItemBaseTIOData
    {

        private IODataT inputField;

        private IODataT outputField;

        private byte f_IO_StructureDescVersionField;

        private uint f_IO_StructureDescCRCField;

        private bool f_IO_StructureDescCRCFieldSpecified;

        public SubmoduleItemBaseTIOData()
        {
            this.f_IO_StructureDescVersionField = ((byte)(1));
        }

        /// <remarks/>
        public IODataT Input
        {
            get
            {
                return this.inputField;
            }
            set
            {
                this.inputField = value;
            }
        }

        /// <remarks/>
        public IODataT Output
        {
            get
            {
                return this.outputField;
            }
            set
            {
                this.outputField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "1")]
        public byte F_IO_StructureDescVersion
        {
            get
            {
                return this.f_IO_StructureDescVersionField;
            }
            set
            {
                this.f_IO_StructureDescVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint F_IO_StructureDescCRC
        {
            get
            {
                return this.f_IO_StructureDescCRCField;
            }
            set
            {
                this.f_IO_StructureDescCRCField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool F_IO_StructureDescCRCSpecified
        {
            get
            {
                return this.f_IO_StructureDescCRCFieldSpecified;
            }
            set
            {
                this.f_IO_StructureDescCRCFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class IODataT
    {

        private IODataTDataItem[] dataItemField;

        private IODataTChannel[] channelField;

        private IODataConsistencyEnumT consistencyField;

        public IODataT()
        {
            this.consistencyField = IODataConsistencyEnumT.Itemconsistency;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataItem")]
        public IODataTDataItem[] DataItem
        {
            get
            {
                return this.dataItemField;
            }
            set
            {
                this.dataItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Channel")]
        public IODataTChannel[] Channel
        {
            get
            {
                return this.channelField;
            }
            set
            {
                this.channelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(IODataConsistencyEnumT.Itemconsistency)]
        public IODataConsistencyEnumT Consistency
        {
            get
            {
                return this.consistencyField;
            }
            set
            {
                this.consistencyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class IODataTDataItem
    {

        private IODataTDataItemBitDataItem[] bitDataItemField;

        private DataItemTypeEnumT dataTypeField;

        private ushort lengthField;

        private bool lengthFieldSpecified;

        private bool useAsBitsField;

        private bool subordinateField;

        private string textIdField;

        public IODataTDataItem()
        {
            this.useAsBitsField = false;
            this.subordinateField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BitDataItem")]
        public IODataTDataItemBitDataItem[] BitDataItem
        {
            get
            {
                return this.bitDataItemField;
            }
            set
            {
                this.bitDataItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DataItemTypeEnumT DataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LengthSpecified
        {
            get
            {
                return this.lengthFieldSpecified;
            }
            set
            {
                this.lengthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool UseAsBits
        {
            get
            {
                return this.useAsBitsField;
            }
            set
            {
                this.useAsBitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Subordinate
        {
            get
            {
                return this.subordinateField;
            }
            set
            {
                this.subordinateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string TextId
        {
            get
            {
                return this.textIdField;
            }
            set
            {
                this.textIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class IODataTDataItemBitDataItem
    {

        private byte bitOffsetField;

        private string textIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte BitOffset
        {
            get
            {
                return this.bitOffsetField;
            }
            set
            {
                this.bitOffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string TextId
        {
            get
            {
                return this.textIdField;
            }
            set
            {
                this.textIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public enum DataItemTypeEnumT
    {

        /// <remarks/>
        Integer8,

        /// <remarks/>
        Integer16,

        /// <remarks/>
        Integer32,

        /// <remarks/>
        Integer64,

        /// <remarks/>
        Unsigned8,

        /// <remarks/>
        Unsigned16,

        /// <remarks/>
        Unsigned32,

        /// <remarks/>
        Unsigned64,

        /// <remarks/>
        Float32,

        /// <remarks/>
        Float64,

        /// <remarks/>
        Date,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("TimeOfDay with date indication")]
        TimeOfDaywithdateindication,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("TimeOfDay without date indication")]
        TimeOfDaywithoutdateindication,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("TimeDifference with date indication")]
        TimeDifferencewithdateindication,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("TimeDifference without date indication")]
        TimeDifferencewithoutdateindication,

        /// <remarks/>
        NetworkTime,

        /// <remarks/>
        NetworkTimeDifference,

        /// <remarks/>
        VisibleString,

        /// <remarks/>
        OctetString,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Float32+Status8")]
        Float32Status8,

        /// <remarks/>
        F_MessageTrailer4Byte,

        /// <remarks/>
        F_MessageTrailer5Byte,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Unsigned8+Unsigned8")]
        Unsigned8Unsigned8,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Float32+Unsigned8")]
        Float32Unsigned8,

        /// <remarks/>
        Boolean,

        /// <remarks/>
        UnicodeString8,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("61131_STRING")]
        Item61131_STRING,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("61131_WSTRING")]
        Item61131_WSTRING,

        /// <remarks/>
        TimeStamp,

        /// <remarks/>
        TimeStampDifference,

        /// <remarks/>
        TimeStampDifferenceShort,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("OctetString2+Unsigned8")]
        OctetString2Unsigned8,

        /// <remarks/>
        Unsigned16_S,

        /// <remarks/>
        Integer16_S,

        /// <remarks/>
        Unsigned8_S,

        /// <remarks/>
        OctetString_S,

        /// <remarks/>
        N2,

        /// <remarks/>
        N4,

        /// <remarks/>
        V2,

        /// <remarks/>
        L2,

        /// <remarks/>
        R2,

        /// <remarks/>
        T2,

        /// <remarks/>
        T4,

        /// <remarks/>
        D2,

        /// <remarks/>
        E2,

        /// <remarks/>
        C4,

        /// <remarks/>
        X2,

        /// <remarks/>
        X4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Unipolar2.16")]
        Unipolar216,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class IODataTChannel
    {

        private IODataTChannelData dataField;

        private IODataTChannelQuality qualityField;

        private ushort numberField;

        /// <remarks/>
        public IODataTChannelData Data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }

        /// <remarks/>
        public IODataTChannelQuality Quality
        {
            get
            {
                return this.qualityField;
            }
            set
            {
                this.qualityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class IODataTChannelData
    {

        private ushort bitOffsetField;

        private ushort bitLengthField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort BitOffset
        {
            get
            {
                return this.bitOffsetField;
            }
            set
            {
                this.bitOffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort BitLength
        {
            get
            {
                return this.bitLengthField;
            }
            set
            {
                this.bitLengthField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class IODataTChannelQuality
    {

        private ushort bitOffsetField;

        private QualityFormat_EnumT formatField;

        private bool oppositeDirectionField;

        public IODataTChannelQuality()
        {
            this.oppositeDirectionField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort BitOffset
        {
            get
            {
                return this.bitOffsetField;
            }
            set
            {
                this.bitOffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public QualityFormat_EnumT Format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool OppositeDirection
        {
            get
            {
                return this.oppositeDirectionField;
            }
            set
            {
                this.oppositeDirectionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public enum QualityFormat_EnumT
    {

        /// <remarks/>
        Qualifier,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Embedded Status")]
        EmbeddedStatus,

        /// <remarks/>
        Status,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public enum IODataConsistencyEnumT
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Item consistency")]
        Itemconsistency,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("All items consistency")]
        Allitemsconsistency,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class SubmoduleItemBaseTRecordDataList
    {

        private ParameterRecordDataT[] parameterRecordDataItemField;

        private F_ParameterRecordDataT f_ParameterRecordDataItemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ParameterRecordDataItem")]
        public ParameterRecordDataT[] ParameterRecordDataItem
        {
            get
            {
                return this.parameterRecordDataItemField;
            }
            set
            {
                this.parameterRecordDataItemField = value;
            }
        }

        /// <remarks/>
        public F_ParameterRecordDataT F_ParameterRecordDataItem
        {
            get
            {
                return this.f_ParameterRecordDataItemField;
            }
            set
            {
                this.f_ParameterRecordDataItemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class GraphicsReferenceTGraphicItemRef
    {

        private GraphicsTypeEnumT typeField;

        private string graphicItemTargetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public GraphicsTypeEnumT Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string GraphicItemTarget
        {
            get
            {
                return this.graphicItemTargetField;
            }
            set
            {
                this.graphicItemTargetField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public enum GraphicsTypeEnumT
    {

        /// <remarks/>
        DeviceSymbol,

        /// <remarks/>
        DeviceIcon,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class SubmoduleItemBaseTIsochroneMode
    {

        private ushort t_DC_BaseField;

        private ushort t_DC_MinField;

        private ushort t_DC_MaxField;

        private uint t_IO_BaseField;

        private uint t_IO_InputMinField;

        private uint t_IO_OutputMinField;

        private bool isochroneModeRequiredField;

        public SubmoduleItemBaseTIsochroneMode()
        {
            this.isochroneModeRequiredField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort T_DC_Base
        {
            get
            {
                return this.t_DC_BaseField;
            }
            set
            {
                this.t_DC_BaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort T_DC_Min
        {
            get
            {
                return this.t_DC_MinField;
            }
            set
            {
                this.t_DC_MinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort T_DC_Max
        {
            get
            {
                return this.t_DC_MaxField;
            }
            set
            {
                this.t_DC_MaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint T_IO_Base
        {
            get
            {
                return this.t_IO_BaseField;
            }
            set
            {
                this.t_IO_BaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint T_IO_InputMin
        {
            get
            {
                return this.t_IO_InputMinField;
            }
            set
            {
                this.t_IO_InputMinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint T_IO_OutputMin
        {
            get
            {
                return this.t_IO_OutputMinField;
            }
            set
            {
                this.t_IO_OutputMinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IsochroneModeRequired
        {
            get
            {
                return this.isochroneModeRequiredField;
            }
            set
            {
                this.isochroneModeRequiredField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class SubmoduleItemBaseTSlotCluster
    {

        private ushort countField;

        private ushort fieldbusTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort FieldbusType
        {
            get
            {
                return this.fieldbusTypeField;
            }
            set
            {
                this.fieldbusTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ReportingSystemEventsTObserver
    {

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class SubmoduleItemT : SubmoduleItemBaseT
    {

        private string requiredSchemaVersionField;

        public SubmoduleItemT()
        {
            this.requiredSchemaVersionField = "V2.1";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("V2.1")]
        public string RequiredSchemaVersion
        {
            get
            {
                return this.requiredSchemaVersionField;
            }
            set
            {
                this.requiredSchemaVersionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class BuiltInPortSubmoduleItemT : PortSubmoduleItemBaseT
    {

        private ushort subslotNumberField;

        private string textIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort SubslotNumber
        {
            get
            {
                return this.subslotNumberField;
            }
            set
            {
                this.subslotNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string TextId
        {
            get
            {
                return this.textIdField;
            }
            set
            {
                this.textIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BuiltInPortSubmoduleItemT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PortSubmoduleItemT))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class PortSubmoduleItemBaseT : ObjectT
    {

        private ParameterRecordDataT[] recordDataListField;

        private PortSubmoduleItemBaseTMAUTypeList mAUTypeListField;

        private string submoduleIdentNumberField;

        private MAUTypeEnumT mAUTypeField;

        private string mAUTypesField;

        private string fiberOpticTypesField;

        private ushort maxPortTxDelayField;

        private bool maxPortTxDelayFieldSpecified;

        private ushort maxPortRxDelayField;

        private bool maxPortRxDelayFieldSpecified;

        private bool portDeactivationSupportedField;

        private LinkStateDiagnosisEnumT linkStateDiagnosisCapabilityField;

        private bool linkStateDiagnosisCapabilityFieldSpecified;

        private bool powerBudgetControlSupportedField;

        private bool supportsRingportConfigField;

        private bool isDefaultRingportField;

        private bool supportsMRP_InterconnPortConfigField;

        private bool parameterizationDisallowedField;

        private string writeable_IM_RecordsField;

        private bool iM5_SupportedField;

        private bool checkMAUTypeSupportedField;

        private bool checkMAUTypeSupportedFieldSpecified;

        private bool checkMAUTypeDifferenceSupportedField;

        private bool checkMAUTypeDifferenceSupportedFieldSpecified;

        private bool shortPreamble100MBitSupportedField;

        private bool shortPreamble100MBitSupportedFieldSpecified;

        public PortSubmoduleItemBaseT()
        {
            this.mAUTypeField = MAUTypeEnumT.Item100BASETXFD;
            this.portDeactivationSupportedField = false;
            this.powerBudgetControlSupportedField = false;
            this.supportsRingportConfigField = false;
            this.isDefaultRingportField = false;
            this.supportsMRP_InterconnPortConfigField = false;
            this.parameterizationDisallowedField = false;
            this.iM5_SupportedField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ParameterRecordDataItem", IsNullable = false)]
        public ParameterRecordDataT[] RecordDataList
        {
            get
            {
                return this.recordDataListField;
            }
            set
            {
                this.recordDataListField = value;
            }
        }

        /// <remarks/>
        public PortSubmoduleItemBaseTMAUTypeList MAUTypeList
        {
            get
            {
                return this.mAUTypeListField;
            }
            set
            {
                this.mAUTypeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubmoduleIdentNumber
        {
            get
            {
                return this.submoduleIdentNumberField;
            }
            set
            {
                this.submoduleIdentNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(MAUTypeEnumT.Item100BASETXFD)]
        public MAUTypeEnumT MAUType
        {
            get
            {
                return this.mAUTypeField;
            }
            set
            {
                this.mAUTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MAUTypes
        {
            get
            {
                return this.mAUTypesField;
            }
            set
            {
                this.mAUTypesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FiberOpticTypes
        {
            get
            {
                return this.fiberOpticTypesField;
            }
            set
            {
                this.fiberOpticTypesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort MaxPortTxDelay
        {
            get
            {
                return this.maxPortTxDelayField;
            }
            set
            {
                this.maxPortTxDelayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxPortTxDelaySpecified
        {
            get
            {
                return this.maxPortTxDelayFieldSpecified;
            }
            set
            {
                this.maxPortTxDelayFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort MaxPortRxDelay
        {
            get
            {
                return this.maxPortRxDelayField;
            }
            set
            {
                this.maxPortRxDelayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxPortRxDelaySpecified
        {
            get
            {
                return this.maxPortRxDelayFieldSpecified;
            }
            set
            {
                this.maxPortRxDelayFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool PortDeactivationSupported
        {
            get
            {
                return this.portDeactivationSupportedField;
            }
            set
            {
                this.portDeactivationSupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public LinkStateDiagnosisEnumT LinkStateDiagnosisCapability
        {
            get
            {
                return this.linkStateDiagnosisCapabilityField;
            }
            set
            {
                this.linkStateDiagnosisCapabilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LinkStateDiagnosisCapabilitySpecified
        {
            get
            {
                return this.linkStateDiagnosisCapabilityFieldSpecified;
            }
            set
            {
                this.linkStateDiagnosisCapabilityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool PowerBudgetControlSupported
        {
            get
            {
                return this.powerBudgetControlSupportedField;
            }
            set
            {
                this.powerBudgetControlSupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SupportsRingportConfig
        {
            get
            {
                return this.supportsRingportConfigField;
            }
            set
            {
                this.supportsRingportConfigField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IsDefaultRingport
        {
            get
            {
                return this.isDefaultRingportField;
            }
            set
            {
                this.isDefaultRingportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SupportsMRP_InterconnPortConfig
        {
            get
            {
                return this.supportsMRP_InterconnPortConfigField;
            }
            set
            {
                this.supportsMRP_InterconnPortConfigField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ParameterizationDisallowed
        {
            get
            {
                return this.parameterizationDisallowedField;
            }
            set
            {
                this.parameterizationDisallowedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Writeable_IM_Records
        {
            get
            {
                return this.writeable_IM_RecordsField;
            }
            set
            {
                this.writeable_IM_RecordsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IM5_Supported
        {
            get
            {
                return this.iM5_SupportedField;
            }
            set
            {
                this.iM5_SupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CheckMAUTypeSupported
        {
            get
            {
                return this.checkMAUTypeSupportedField;
            }
            set
            {
                this.checkMAUTypeSupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CheckMAUTypeSupportedSpecified
        {
            get
            {
                return this.checkMAUTypeSupportedFieldSpecified;
            }
            set
            {
                this.checkMAUTypeSupportedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CheckMAUTypeDifferenceSupported
        {
            get
            {
                return this.checkMAUTypeDifferenceSupportedField;
            }
            set
            {
                this.checkMAUTypeDifferenceSupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CheckMAUTypeDifferenceSupportedSpecified
        {
            get
            {
                return this.checkMAUTypeDifferenceSupportedFieldSpecified;
            }
            set
            {
                this.checkMAUTypeDifferenceSupportedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ShortPreamble100MBitSupported
        {
            get
            {
                return this.shortPreamble100MBitSupportedField;
            }
            set
            {
                this.shortPreamble100MBitSupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShortPreamble100MBitSupportedSpecified
        {
            get
            {
                return this.shortPreamble100MBitSupportedFieldSpecified;
            }
            set
            {
                this.shortPreamble100MBitSupportedFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class PortSubmoduleItemBaseTMAUTypeList
    {

        private MAUTypeItemT[] mAUTypeItemField;

        private bool extensionSupportedField;

        public PortSubmoduleItemBaseTMAUTypeList()
        {
            this.extensionSupportedField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MAUTypeItem")]
        public MAUTypeItemT[] MAUTypeItem
        {
            get
            {
                return this.mAUTypeItemField;
            }
            set
            {
                this.mAUTypeItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ExtensionSupported
        {
            get
            {
                return this.extensionSupportedField;
            }
            set
            {
                this.extensionSupportedField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public enum MAUTypeEnumT
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("100BASETXFD")]
        Item100BASETXFD,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("100BASEFXFD")]
        Item100BASEFXFD,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1000BASEXFD")]
        Item1000BASEXFD,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1000BASELXFD")]
        Item1000BASELXFD,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1000BASESXFD")]
        Item1000BASESXFD,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1000BASETFD")]
        Item1000BASETFD,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10GigBASEFX")]
        Item10GigBASEFX,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public enum LinkStateDiagnosisEnumT
    {

        /// <remarks/>
        Up,

        /// <remarks/>
        Down,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Up+Down")]
        UpDown,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class PortSubmoduleItemT : PortSubmoduleItemBaseT
    {

        private ModuleInfoT moduleInfoField;

        private GraphicsReferenceTGraphicItemRef[] graphicsField;

        private string requiredSchemaVersionField;

        public PortSubmoduleItemT()
        {
            this.requiredSchemaVersionField = "V2.25";
        }

        /// <remarks/>
        public ModuleInfoT ModuleInfo
        {
            get
            {
                return this.moduleInfoField;
            }
            set
            {
                this.moduleInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("GraphicItemRef", IsNullable = false)]
        public GraphicsReferenceTGraphicItemRef[] Graphics
        {
            get
            {
                return this.graphicsField;
            }
            set
            {
                this.graphicsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("V2.25")]
        public string RequiredSchemaVersion
        {
            get
            {
                return this.requiredSchemaVersionField;
            }
            set
            {
                this.requiredSchemaVersionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class UseableSubmodulesTSubmoduleItemRef
    {

        private string submoduleItemTargetField;

        private string allowedInSubslotsField;

        private string usedInSubslotsField;

        private string fixedInSubslotsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string SubmoduleItemTarget
        {
            get
            {
                return this.submoduleItemTargetField;
            }
            set
            {
                this.submoduleItemTargetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowedInSubslots
        {
            get
            {
                return this.allowedInSubslotsField;
            }
            set
            {
                this.allowedInSubslotsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UsedInSubslots
        {
            get
            {
                return this.usedInSubslotsField;
            }
            set
            {
                this.usedInSubslotsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FixedInSubslots
        {
            get
            {
                return this.fixedInSubslotsField;
            }
            set
            {
                this.fixedInSubslotsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class InterfaceSubmoduleItemT : ObjectT
    {

        private InterfaceSubmoduleItemTGeneral generalField;

        private ParameterRecordDataT[] recordDataListField;

        private RT_Class3PropertiesT rT_Class3PropertiesField;

        private InterfaceSubmoduleItemTSynchronisationMode synchronisationModeField;

        private InterfaceSubmoduleItemTTimeSynchronisation timeSynchronisationField;

        private InterfaceSubmoduleItemTReportingSystem reportingSystemField;

        private ApplicationRelationsT applicationRelationsField;

        private InterfaceSubmoduleItemTMediaRedundancy mediaRedundancyField;

        private string submoduleIdentNumberField;

        private string textIdField;

        private ushort subslotNumberField;

        private RT_ClassEnumT supportedRT_ClassField;

        private string supportedRT_ClassesField;

        private bool isochroneModeSupportedField;

        private string isochroneModeInRT_ClassesField;

        private string supportedProtocolsField;

        private bool networkComponentDiagnosisSupportedField;

        private bool dCP_HelloSupportedField;

        private bool pTP_BoundarySupportedField;

        private bool dCP_BoundarySupportedField;

        private bool multicastBoundarySupportedField;

        private bool parameterizationDisallowedField;

        private bool delayMeasurementSupportedField;

        private string writeable_IM_RecordsField;

        private bool iM5_SupportedField;

        private ushort maxFrameStartTimeField;

        private ushort minNRT_GapField;

        private bool pDEV_CombinedObjectSupportedField;

        private bool usesStaticARP_CacheEntriesField;

        public InterfaceSubmoduleItemT()
        {
            this.subslotNumberField = ((ushort)(32768));
            this.supportedRT_ClassField = RT_ClassEnumT.Class1;
            this.isochroneModeSupportedField = false;
            this.isochroneModeInRT_ClassesField = "";
            this.networkComponentDiagnosisSupportedField = false;
            this.dCP_HelloSupportedField = false;
            this.pTP_BoundarySupportedField = false;
            this.dCP_BoundarySupportedField = false;
            this.multicastBoundarySupportedField = false;
            this.parameterizationDisallowedField = false;
            this.delayMeasurementSupportedField = false;
            this.iM5_SupportedField = false;
            this.maxFrameStartTimeField = ((ushort)(1600));
            this.minNRT_GapField = ((ushort)(960));
            this.pDEV_CombinedObjectSupportedField = false;
            this.usesStaticARP_CacheEntriesField = false;
        }

        /// <remarks/>
        public InterfaceSubmoduleItemTGeneral General
        {
            get
            {
                return this.generalField;
            }
            set
            {
                this.generalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ParameterRecordDataItem", IsNullable = false)]
        public ParameterRecordDataT[] RecordDataList
        {
            get
            {
                return this.recordDataListField;
            }
            set
            {
                this.recordDataListField = value;
            }
        }

        /// <remarks/>
        public RT_Class3PropertiesT RT_Class3Properties
        {
            get
            {
                return this.rT_Class3PropertiesField;
            }
            set
            {
                this.rT_Class3PropertiesField = value;
            }
        }

        /// <remarks/>
        public InterfaceSubmoduleItemTSynchronisationMode SynchronisationMode
        {
            get
            {
                return this.synchronisationModeField;
            }
            set
            {
                this.synchronisationModeField = value;
            }
        }

        /// <remarks/>
        public InterfaceSubmoduleItemTTimeSynchronisation TimeSynchronisation
        {
            get
            {
                return this.timeSynchronisationField;
            }
            set
            {
                this.timeSynchronisationField = value;
            }
        }

        /// <remarks/>
        public InterfaceSubmoduleItemTReportingSystem ReportingSystem
        {
            get
            {
                return this.reportingSystemField;
            }
            set
            {
                this.reportingSystemField = value;
            }
        }

        /// <remarks/>
        public ApplicationRelationsT ApplicationRelations
        {
            get
            {
                return this.applicationRelationsField;
            }
            set
            {
                this.applicationRelationsField = value;
            }
        }

        /// <remarks/>
        public InterfaceSubmoduleItemTMediaRedundancy MediaRedundancy
        {
            get
            {
                return this.mediaRedundancyField;
            }
            set
            {
                this.mediaRedundancyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubmoduleIdentNumber
        {
            get
            {
                return this.submoduleIdentNumberField;
            }
            set
            {
                this.submoduleIdentNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string TextId
        {
            get
            {
                return this.textIdField;
            }
            set
            {
                this.textIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "32768")]
        public ushort SubslotNumber
        {
            get
            {
                return this.subslotNumberField;
            }
            set
            {
                this.subslotNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(RT_ClassEnumT.Class1)]
        public RT_ClassEnumT SupportedRT_Class
        {
            get
            {
                return this.supportedRT_ClassField;
            }
            set
            {
                this.supportedRT_ClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SupportedRT_Classes
        {
            get
            {
                return this.supportedRT_ClassesField;
            }
            set
            {
                this.supportedRT_ClassesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IsochroneModeSupported
        {
            get
            {
                return this.isochroneModeSupportedField;
            }
            set
            {
                this.isochroneModeSupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string IsochroneModeInRT_Classes
        {
            get
            {
                return this.isochroneModeInRT_ClassesField;
            }
            set
            {
                this.isochroneModeInRT_ClassesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SupportedProtocols
        {
            get
            {
                return this.supportedProtocolsField;
            }
            set
            {
                this.supportedProtocolsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool NetworkComponentDiagnosisSupported
        {
            get
            {
                return this.networkComponentDiagnosisSupportedField;
            }
            set
            {
                this.networkComponentDiagnosisSupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool DCP_HelloSupported
        {
            get
            {
                return this.dCP_HelloSupportedField;
            }
            set
            {
                this.dCP_HelloSupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool PTP_BoundarySupported
        {
            get
            {
                return this.pTP_BoundarySupportedField;
            }
            set
            {
                this.pTP_BoundarySupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool DCP_BoundarySupported
        {
            get
            {
                return this.dCP_BoundarySupportedField;
            }
            set
            {
                this.dCP_BoundarySupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool MulticastBoundarySupported
        {
            get
            {
                return this.multicastBoundarySupportedField;
            }
            set
            {
                this.multicastBoundarySupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ParameterizationDisallowed
        {
            get
            {
                return this.parameterizationDisallowedField;
            }
            set
            {
                this.parameterizationDisallowedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool DelayMeasurementSupported
        {
            get
            {
                return this.delayMeasurementSupportedField;
            }
            set
            {
                this.delayMeasurementSupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Writeable_IM_Records
        {
            get
            {
                return this.writeable_IM_RecordsField;
            }
            set
            {
                this.writeable_IM_RecordsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IM5_Supported
        {
            get
            {
                return this.iM5_SupportedField;
            }
            set
            {
                this.iM5_SupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "1600")]
        public ushort MaxFrameStartTime
        {
            get
            {
                return this.maxFrameStartTimeField;
            }
            set
            {
                this.maxFrameStartTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "960")]
        public ushort MinNRT_Gap
        {
            get
            {
                return this.minNRT_GapField;
            }
            set
            {
                this.minNRT_GapField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool PDEV_CombinedObjectSupported
        {
            get
            {
                return this.pDEV_CombinedObjectSupportedField;
            }
            set
            {
                this.pDEV_CombinedObjectSupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool UsesStaticARP_CacheEntries
        {
            get
            {
                return this.usesStaticARP_CacheEntriesField;
            }
            set
            {
                this.usesStaticARP_CacheEntriesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class InterfaceSubmoduleItemTGeneral
    {

        private ExternalTextRefT dCP_FlashOnceSignalUnitField;

        /// <remarks/>
        public ExternalTextRefT DCP_FlashOnceSignalUnit
        {
            get
            {
                return this.dCP_FlashOnceSignalUnitField;
            }
            set
            {
                this.dCP_FlashOnceSignalUnitField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class InterfaceSubmoduleItemTSynchronisationMode
    {

        private SyncRoleEnumT supportedRoleField;

        private ushort maxLocalJitterField;

        private bool maxLocalJitterFieldSpecified;

        private ushort t_PLL_MAXField;

        private ushort peerToPeerJitterField;

        private bool peerToPeerJitterFieldSpecified;

        private string supportedSyncProtocolsField;

        public InterfaceSubmoduleItemTSynchronisationMode()
        {
            this.supportedRoleField = SyncRoleEnumT.SyncSlave;
            this.t_PLL_MAXField = ((ushort)(1000));
            this.supportedSyncProtocolsField = "";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(SyncRoleEnumT.SyncSlave)]
        public SyncRoleEnumT SupportedRole
        {
            get
            {
                return this.supportedRoleField;
            }
            set
            {
                this.supportedRoleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort MaxLocalJitter
        {
            get
            {
                return this.maxLocalJitterField;
            }
            set
            {
                this.maxLocalJitterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxLocalJitterSpecified
        {
            get
            {
                return this.maxLocalJitterFieldSpecified;
            }
            set
            {
                this.maxLocalJitterFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "1000")]
        public ushort T_PLL_MAX
        {
            get
            {
                return this.t_PLL_MAXField;
            }
            set
            {
                this.t_PLL_MAXField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort PeerToPeerJitter
        {
            get
            {
                return this.peerToPeerJitterField;
            }
            set
            {
                this.peerToPeerJitterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PeerToPeerJitterSpecified
        {
            get
            {
                return this.peerToPeerJitterFieldSpecified;
            }
            set
            {
                this.peerToPeerJitterFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string SupportedSyncProtocols
        {
            get
            {
                return this.supportedSyncProtocolsField;
            }
            set
            {
                this.supportedSyncProtocolsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public enum SyncRoleEnumT
    {

        /// <remarks/>
        SyncMaster,

        /// <remarks/>
        SyncMasterRedundant,

        /// <remarks/>
        SyncSlave,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("SyncMaster+SyncSlave")]
        SyncMasterSyncSlave,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("SyncMasterRedundant+SyncSlave")]
        SyncMasterRedundantSyncSlave,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class InterfaceSubmoduleItemTTimeSynchronisation
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class InterfaceSubmoduleItemTReportingSystem
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class InterfaceSubmoduleItemTMediaRedundancy
    {

        private InterfaceSubmoduleItemTMediaRedundancyInterconnection interconnectionField;

        private string supportedRoleField;

        private string supportedMultipleRoleField;

        private byte maxMRP_InstancesField;

        private bool maxMRP_InstancesFieldSpecified;

        private bool mRPD_SupportedField;

        private bool mRT_SupportedField;

        private bool additionalProtocolsSupportedField;

        private bool additionalForwardingRulesSupportedField;

        public InterfaceSubmoduleItemTMediaRedundancy()
        {
            this.supportedRoleField = "Client";
            this.supportedMultipleRoleField = "Client";
            this.mRPD_SupportedField = false;
            this.mRT_SupportedField = false;
            this.additionalProtocolsSupportedField = false;
            this.additionalForwardingRulesSupportedField = false;
        }

        /// <remarks/>
        public InterfaceSubmoduleItemTMediaRedundancyInterconnection Interconnection
        {
            get
            {
                return this.interconnectionField;
            }
            set
            {
                this.interconnectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("Client")]
        public string SupportedRole
        {
            get
            {
                return this.supportedRoleField;
            }
            set
            {
                this.supportedRoleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("Client")]
        public string SupportedMultipleRole
        {
            get
            {
                return this.supportedMultipleRoleField;
            }
            set
            {
                this.supportedMultipleRoleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte MaxMRP_Instances
        {
            get
            {
                return this.maxMRP_InstancesField;
            }
            set
            {
                this.maxMRP_InstancesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxMRP_InstancesSpecified
        {
            get
            {
                return this.maxMRP_InstancesFieldSpecified;
            }
            set
            {
                this.maxMRP_InstancesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool MRPD_Supported
        {
            get
            {
                return this.mRPD_SupportedField;
            }
            set
            {
                this.mRPD_SupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool MRT_Supported
        {
            get
            {
                return this.mRT_SupportedField;
            }
            set
            {
                this.mRT_SupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AdditionalProtocolsSupported
        {
            get
            {
                return this.additionalProtocolsSupportedField;
            }
            set
            {
                this.additionalProtocolsSupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AdditionalForwardingRulesSupported
        {
            get
            {
                return this.additionalForwardingRulesSupportedField;
            }
            set
            {
                this.additionalForwardingRulesSupportedField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class InterfaceSubmoduleItemTMediaRedundancyInterconnection
    {

        private string supportedMRP_InterconnRoleField;

        private byte maxMRP_InterconnInstancesField;

        private bool maxMRP_InterconnInstancesFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SupportedMRP_InterconnRole
        {
            get
            {
                return this.supportedMRP_InterconnRoleField;
            }
            set
            {
                this.supportedMRP_InterconnRoleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte MaxMRP_InterconnInstances
        {
            get
            {
                return this.maxMRP_InterconnInstancesField;
            }
            set
            {
                this.maxMRP_InterconnInstancesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxMRP_InterconnInstancesSpecified
        {
            get
            {
                return this.maxMRP_InterconnInstancesFieldSpecified;
            }
            set
            {
                this.maxMRP_InterconnInstancesFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/Primitives")]
    public enum RT_ClassEnumT
    {

        /// <remarks/>
        Class1,

        /// <remarks/>
        Class2,

        /// <remarks/>
        Class3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class DeviceAccessPointItemT : ObjectT
    {

        private ModuleInfoT moduleInfoField;

        private CertificationInfoT certificationInfoField;

        private SubslotListTSubslotItem[] subslotListField;

        private DeviceAccessPointItemTIOConfigData iOConfigDataField;

        private UseableModulesTModuleItemRef[] useableModulesField;

        private ARVendorBlockRequestT[] aRVendorBlockField;

        private BuiltInSubmoduleItemT[] virtualSubmoduleListField;

        private DeviceAccessPointItemTSystemDefinedSubmoduleList systemDefinedSubmoduleListField;

        private GraphicsReferenceTGraphicItemRef[] graphicsField;

        private DeviceAccessPointItemTAssetManagement assetManagementField;

        private ApplicationRelationsObsoleteT applicationRelationsField;

        private SystemRedundancyT systemRedundancyField;

        private UseableSubmodulesTSubmoduleItemRef[] useableSubmodulesField;

        private SlotListTSlotItem[] slotListField;

        private SlotGroupsTSlotGroup[] slotGroupsField;

        private DeviceAccessPointItemTFieldbusIntegrationSlots fieldbusIntegrationSlotsField;

        private string moduleIdentNumberField;

        private string pNIO_VersionField;

        private string physicalSlotsField;

        private ushort minDeviceIntervalField;

        private string implementationTypeField;

        private string dNS_CompatibleNameField;

        private string allowedInSlotsField;

        private string fixedInSlotsField;

        private ushort objectUUID_LocalIndexField;

        private string requiredSchemaVersionField;

        private bool multipleWriteSupportedField;

        private bool iOXS_RequiredField;

        private string addressAssignmentField;

        private string physicalSubslotsField;

        private ushort remoteApplicationTimeoutField;

        private uint maxSupportedRecordSizeField;

        private uint powerOnToCommReadyField;

        private bool parameterizationSpeedupSupportedField;

        private bool nameOfStationNotTransferableField;

        private bool sharedDeviceSupportedField;

        private bool sharedInputSupportedField;

        private bool deviceAccessSupportedField;

        private byte numberOfDeviceAccessARField;

        private bool numberOfDeviceAccessARFieldSpecified;

        private byte numberOfImplicitARField;

        private string webServerField;

        private bool autoConfigurationSupportedField;

        private bool cIR_SupportedField;

        private bool prmBeginPrmEndSequenceSupportedField;

        private bool lLDP_NoD_SupportedField;

        private string resetToFactoryModesField;

        private bool iO_SupervisorSupportedField;

        private bool checkDeviceID_AllowedField;

        private bool pROFIenergyASE_SupportedField;

        private bool adaptsRealIdentificationField;

        private uint numberOfSubmodulesField;

        private bool numberOfSubmodulesFieldSpecified;

        public DeviceAccessPointItemT()
        {
            this.requiredSchemaVersionField = "V1.0";
            this.multipleWriteSupportedField = false;
            this.iOXS_RequiredField = true;
            this.addressAssignmentField = "DCP";
            this.remoteApplicationTimeoutField = ((ushort)(300));
            this.maxSupportedRecordSizeField = ((uint)(4068));
            this.powerOnToCommReadyField = ((uint)(0));
            this.parameterizationSpeedupSupportedField = false;
            this.sharedDeviceSupportedField = false;
            this.sharedInputSupportedField = false;
            this.numberOfImplicitARField = ((byte)(1));
            this.autoConfigurationSupportedField = false;
            this.cIR_SupportedField = false;
            this.prmBeginPrmEndSequenceSupportedField = false;
            this.lLDP_NoD_SupportedField = false;
            this.iO_SupervisorSupportedField = false;
            this.pROFIenergyASE_SupportedField = false;
            this.adaptsRealIdentificationField = false;
        }

        /// <remarks/>
        public ModuleInfoT ModuleInfo
        {
            get
            {
                return this.moduleInfoField;
            }
            set
            {
                this.moduleInfoField = value;
            }
        }

        /// <remarks/>
        public CertificationInfoT CertificationInfo
        {
            get
            {
                return this.certificationInfoField;
            }
            set
            {
                this.certificationInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SubslotItem", IsNullable = false)]
        public SubslotListTSubslotItem[] SubslotList
        {
            get
            {
                return this.subslotListField;
            }
            set
            {
                this.subslotListField = value;
            }
        }

        /// <remarks/>
        public DeviceAccessPointItemTIOConfigData IOConfigData
        {
            get
            {
                return this.iOConfigDataField;
            }
            set
            {
                this.iOConfigDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ModuleItemRef", IsNullable = false)]
        public UseableModulesTModuleItemRef[] UseableModules
        {
            get
            {
                return this.useableModulesField;
            }
            set
            {
                this.useableModulesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Request", IsNullable = false)]
        public ARVendorBlockRequestT[] ARVendorBlock
        {
            get
            {
                return this.aRVendorBlockField;
            }
            set
            {
                this.aRVendorBlockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("VirtualSubmoduleItem", IsNullable = false)]
        public BuiltInSubmoduleItemT[] VirtualSubmoduleList
        {
            get
            {
                return this.virtualSubmoduleListField;
            }
            set
            {
                this.virtualSubmoduleListField = value;
            }
        }

        /// <remarks/>
        public DeviceAccessPointItemTSystemDefinedSubmoduleList SystemDefinedSubmoduleList
        {
            get
            {
                return this.systemDefinedSubmoduleListField;
            }
            set
            {
                this.systemDefinedSubmoduleListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("GraphicItemRef", IsNullable = false)]
        public GraphicsReferenceTGraphicItemRef[] Graphics
        {
            get
            {
                return this.graphicsField;
            }
            set
            {
                this.graphicsField = value;
            }
        }

        /// <remarks/>
        public DeviceAccessPointItemTAssetManagement AssetManagement
        {
            get
            {
                return this.assetManagementField;
            }
            set
            {
                this.assetManagementField = value;
            }
        }

        /// <remarks/>
        public ApplicationRelationsObsoleteT ApplicationRelations
        {
            get
            {
                return this.applicationRelationsField;
            }
            set
            {
                this.applicationRelationsField = value;
            }
        }

        /// <remarks/>
        public SystemRedundancyT SystemRedundancy
        {
            get
            {
                return this.systemRedundancyField;
            }
            set
            {
                this.systemRedundancyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SubmoduleItemRef", IsNullable = false)]
        public UseableSubmodulesTSubmoduleItemRef[] UseableSubmodules
        {
            get
            {
                return this.useableSubmodulesField;
            }
            set
            {
                this.useableSubmodulesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SlotItem", IsNullable = false)]
        public SlotListTSlotItem[] SlotList
        {
            get
            {
                return this.slotListField;
            }
            set
            {
                this.slotListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SlotGroup", IsNullable = false)]
        public SlotGroupsTSlotGroup[] SlotGroups
        {
            get
            {
                return this.slotGroupsField;
            }
            set
            {
                this.slotGroupsField = value;
            }
        }

        /// <remarks/>
        public DeviceAccessPointItemTFieldbusIntegrationSlots FieldbusIntegrationSlots
        {
            get
            {
                return this.fieldbusIntegrationSlotsField;
            }
            set
            {
                this.fieldbusIntegrationSlotsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ModuleIdentNumber
        {
            get
            {
                return this.moduleIdentNumberField;
            }
            set
            {
                this.moduleIdentNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PNIO_Version
        {
            get
            {
                return this.pNIO_VersionField;
            }
            set
            {
                this.pNIO_VersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PhysicalSlots
        {
            get
            {
                return this.physicalSlotsField;
            }
            set
            {
                this.physicalSlotsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort MinDeviceInterval
        {
            get
            {
                return this.minDeviceIntervalField;
            }
            set
            {
                this.minDeviceIntervalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
        public string ImplementationType
        {
            get
            {
                return this.implementationTypeField;
            }
            set
            {
                this.implementationTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DNS_CompatibleName
        {
            get
            {
                return this.dNS_CompatibleNameField;
            }
            set
            {
                this.dNS_CompatibleNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowedInSlots
        {
            get
            {
                return this.allowedInSlotsField;
            }
            set
            {
                this.allowedInSlotsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FixedInSlots
        {
            get
            {
                return this.fixedInSlotsField;
            }
            set
            {
                this.fixedInSlotsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ObjectUUID_LocalIndex
        {
            get
            {
                return this.objectUUID_LocalIndexField;
            }
            set
            {
                this.objectUUID_LocalIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("V1.0")]
        public string RequiredSchemaVersion
        {
            get
            {
                return this.requiredSchemaVersionField;
            }
            set
            {
                this.requiredSchemaVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool MultipleWriteSupported
        {
            get
            {
                return this.multipleWriteSupportedField;
            }
            set
            {
                this.multipleWriteSupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool IOXS_Required
        {
            get
            {
                return this.iOXS_RequiredField;
            }
            set
            {
                this.iOXS_RequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("DCP")]
        public string AddressAssignment
        {
            get
            {
                return this.addressAssignmentField;
            }
            set
            {
                this.addressAssignmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PhysicalSubslots
        {
            get
            {
                return this.physicalSubslotsField;
            }
            set
            {
                this.physicalSubslotsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "300")]
        public ushort RemoteApplicationTimeout
        {
            get
            {
                return this.remoteApplicationTimeoutField;
            }
            set
            {
                this.remoteApplicationTimeoutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "4068")]
        public uint MaxSupportedRecordSize
        {
            get
            {
                return this.maxSupportedRecordSizeField;
            }
            set
            {
                this.maxSupportedRecordSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint PowerOnToCommReady
        {
            get
            {
                return this.powerOnToCommReadyField;
            }
            set
            {
                this.powerOnToCommReadyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ParameterizationSpeedupSupported
        {
            get
            {
                return this.parameterizationSpeedupSupportedField;
            }
            set
            {
                this.parameterizationSpeedupSupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NameOfStationNotTransferable
        {
            get
            {
                return this.nameOfStationNotTransferableField;
            }
            set
            {
                this.nameOfStationNotTransferableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SharedDeviceSupported
        {
            get
            {
                return this.sharedDeviceSupportedField;
            }
            set
            {
                this.sharedDeviceSupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SharedInputSupported
        {
            get
            {
                return this.sharedInputSupportedField;
            }
            set
            {
                this.sharedInputSupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DeviceAccessSupported
        {
            get
            {
                return this.deviceAccessSupportedField;
            }
            set
            {
                this.deviceAccessSupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte NumberOfDeviceAccessAR
        {
            get
            {
                return this.numberOfDeviceAccessARField;
            }
            set
            {
                this.numberOfDeviceAccessARField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberOfDeviceAccessARSpecified
        {
            get
            {
                return this.numberOfDeviceAccessARFieldSpecified;
            }
            set
            {
                this.numberOfDeviceAccessARFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "1")]
        public byte NumberOfImplicitAR
        {
            get
            {
                return this.numberOfImplicitARField;
            }
            set
            {
                this.numberOfImplicitARField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string WebServer
        {
            get
            {
                return this.webServerField;
            }
            set
            {
                this.webServerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AutoConfigurationSupported
        {
            get
            {
                return this.autoConfigurationSupportedField;
            }
            set
            {
                this.autoConfigurationSupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool CIR_Supported
        {
            get
            {
                return this.cIR_SupportedField;
            }
            set
            {
                this.cIR_SupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool PrmBeginPrmEndSequenceSupported
        {
            get
            {
                return this.prmBeginPrmEndSequenceSupportedField;
            }
            set
            {
                this.prmBeginPrmEndSequenceSupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool LLDP_NoD_Supported
        {
            get
            {
                return this.lLDP_NoD_SupportedField;
            }
            set
            {
                this.lLDP_NoD_SupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResetToFactoryModes
        {
            get
            {
                return this.resetToFactoryModesField;
            }
            set
            {
                this.resetToFactoryModesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IO_SupervisorSupported
        {
            get
            {
                return this.iO_SupervisorSupportedField;
            }
            set
            {
                this.iO_SupervisorSupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CheckDeviceID_Allowed
        {
            get
            {
                return this.checkDeviceID_AllowedField;
            }
            set
            {
                this.checkDeviceID_AllowedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool PROFIenergyASE_Supported
        {
            get
            {
                return this.pROFIenergyASE_SupportedField;
            }
            set
            {
                this.pROFIenergyASE_SupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AdaptsRealIdentification
        {
            get
            {
                return this.adaptsRealIdentificationField;
            }
            set
            {
                this.adaptsRealIdentificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint NumberOfSubmodules
        {
            get
            {
                return this.numberOfSubmodulesField;
            }
            set
            {
                this.numberOfSubmodulesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberOfSubmodulesSpecified
        {
            get
            {
                return this.numberOfSubmodulesFieldSpecified;
            }
            set
            {
                this.numberOfSubmodulesFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class CertificationInfoT
    {

        private string conformanceClassField;

        private string applicationClassField;

        private string netloadClassField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ConformanceClass
        {
            get
            {
                return this.conformanceClassField;
            }
            set
            {
                this.conformanceClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ApplicationClass
        {
            get
            {
                return this.applicationClassField;
            }
            set
            {
                this.applicationClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NetloadClass
        {
            get
            {
                return this.netloadClassField;
            }
            set
            {
                this.netloadClassField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class DeviceAccessPointItemTIOConfigData
    {

        private ushort maxInputLengthField;

        private ushort maxOutputLengthField;

        private ushort maxDataLengthField;

        private bool maxDataLengthFieldSpecified;

        private bool applicationLengthIncludesIOxSField;

        private ushort maxApplicationInputLengthField;

        private bool maxApplicationInputLengthFieldSpecified;

        private ushort maxApplicationOutputLengthField;

        private bool maxApplicationOutputLengthFieldSpecified;

        private ushort maxApplicationDataLengthField;

        private bool maxApplicationDataLengthFieldSpecified;

        public DeviceAccessPointItemTIOConfigData()
        {
            this.applicationLengthIncludesIOxSField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort MaxInputLength
        {
            get
            {
                return this.maxInputLengthField;
            }
            set
            {
                this.maxInputLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort MaxOutputLength
        {
            get
            {
                return this.maxOutputLengthField;
            }
            set
            {
                this.maxOutputLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort MaxDataLength
        {
            get
            {
                return this.maxDataLengthField;
            }
            set
            {
                this.maxDataLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxDataLengthSpecified
        {
            get
            {
                return this.maxDataLengthFieldSpecified;
            }
            set
            {
                this.maxDataLengthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ApplicationLengthIncludesIOxS
        {
            get
            {
                return this.applicationLengthIncludesIOxSField;
            }
            set
            {
                this.applicationLengthIncludesIOxSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort MaxApplicationInputLength
        {
            get
            {
                return this.maxApplicationInputLengthField;
            }
            set
            {
                this.maxApplicationInputLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxApplicationInputLengthSpecified
        {
            get
            {
                return this.maxApplicationInputLengthFieldSpecified;
            }
            set
            {
                this.maxApplicationInputLengthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort MaxApplicationOutputLength
        {
            get
            {
                return this.maxApplicationOutputLengthField;
            }
            set
            {
                this.maxApplicationOutputLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxApplicationOutputLengthSpecified
        {
            get
            {
                return this.maxApplicationOutputLengthFieldSpecified;
            }
            set
            {
                this.maxApplicationOutputLengthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort MaxApplicationDataLength
        {
            get
            {
                return this.maxApplicationDataLengthField;
            }
            set
            {
                this.maxApplicationDataLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxApplicationDataLengthSpecified
        {
            get
            {
                return this.maxApplicationDataLengthFieldSpecified;
            }
            set
            {
                this.maxApplicationDataLengthFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class UseableModulesTModuleItemRef
    {

        private string moduleItemTargetField;

        private string allowedInSlotsField;

        private string usedInSlotsField;

        private string fixedInSlotsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string ModuleItemTarget
        {
            get
            {
                return this.moduleItemTargetField;
            }
            set
            {
                this.moduleItemTargetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowedInSlots
        {
            get
            {
                return this.allowedInSlotsField;
            }
            set
            {
                this.allowedInSlotsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UsedInSlots
        {
            get
            {
                return this.usedInSlotsField;
            }
            set
            {
                this.usedInSlotsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FixedInSlots
        {
            get
            {
                return this.fixedInSlotsField;
            }
            set
            {
                this.fixedInSlotsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ARVendorBlockRequestT
    {

        private object[] itemsField;

        private MenuItemT[] menuListField;

        private uint lengthField;

        private uint aPIField;

        private ushort aPStructureIdentifierField;

        public ARVendorBlockRequestT()
        {
            this.aPIField = ((uint)(0));
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Const", typeof(RecordDataConstT))]
        [System.Xml.Serialization.XmlElementAttribute("Ref", typeof(RecordDataRefT))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("MenuItem", IsNullable = false)]
        public MenuItemT[] MenuList
        {
            get
            {
                return this.menuListField;
            }
            set
            {
                this.menuListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint Length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint API
        {
            get
            {
                return this.aPIField;
            }
            set
            {
                this.aPIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort APStructureIdentifier
        {
            get
            {
                return this.aPStructureIdentifierField;
            }
            set
            {
                this.aPStructureIdentifierField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class DeviceAccessPointItemTSystemDefinedSubmoduleList
    {

        private InterfaceSubmoduleItemT interfaceSubmoduleItemField;

        private BuiltInPortSubmoduleItemT[] portSubmoduleItemField;

        /// <remarks/>
        public InterfaceSubmoduleItemT InterfaceSubmoduleItem
        {
            get
            {
                return this.interfaceSubmoduleItemField;
            }
            set
            {
                this.interfaceSubmoduleItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PortSubmoduleItem")]
        public BuiltInPortSubmoduleItemT[] PortSubmoduleItem
        {
            get
            {
                return this.portSubmoduleItemField;
            }
            set
            {
                this.portSubmoduleItemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class DeviceAccessPointItemTAssetManagement
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class SlotListTSlotItem
    {

        private ushort slotNumberField;

        private string textIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort SlotNumber
        {
            get
            {
                return this.slotNumberField;
            }
            set
            {
                this.slotNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string TextId
        {
            get
            {
                return this.textIdField;
            }
            set
            {
                this.textIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class SlotGroupsTSlotGroup
    {

        private ExternalTextRefT nameField;

        private ExternalTextRefT infoTextField;

        private string slotListField;

        /// <remarks/>
        public ExternalTextRefT Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ExternalTextRefT InfoText
        {
            get
            {
                return this.infoTextField;
            }
            set
            {
                this.infoTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SlotList
        {
            get
            {
                return this.slotListField;
            }
            set
            {
                this.slotListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class DeviceAccessPointItemTFieldbusIntegrationSlots
    {

        private ushort maxSupportedField;

        private string rangeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort MaxSupported
        {
            get
            {
                return this.maxSupportedField;
            }
            set
            {
                this.maxSupportedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Range
        {
            get
            {
                return this.rangeField;
            }
            set
            {
                this.rangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ApplicationProcessT
    {

        private DeviceAccessPointItemT[] deviceAccessPointListField;

        private ModuleItemT[] moduleListField;

        private ObjectT[] submoduleListField;

        private ValueItemT[] valueListField;

        private object[] channelDiagListField;

        private object[] channelProcessAlarmListField;

        private object[] unitDiagTypeListField;

        private LogBookEntryItemT[] logBookEntryListField;

        private GraphicItemT[] graphicsListField;

        private CategoryItemT[] categoryListField;

        private ApplicationProcessTExternalTextList externalTextListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DeviceAccessPointItem", IsNullable = false)]
        public DeviceAccessPointItemT[] DeviceAccessPointList
        {
            get
            {
                return this.deviceAccessPointListField;
            }
            set
            {
                this.deviceAccessPointListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ModuleItem", IsNullable = false)]
        public ModuleItemT[] ModuleList
        {
            get
            {
                return this.moduleListField;
            }
            set
            {
                this.moduleListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PortSubmoduleItem", typeof(PortSubmoduleItemT), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("SubmoduleItem", typeof(SubmoduleItemT), IsNullable = false)]
        public ObjectT[] SubmoduleList
        {
            get
            {
                return this.submoduleListField;
            }
            set
            {
                this.submoduleListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ValueItem", IsNullable = false)]
        public ValueItemT[] ValueList
        {
            get
            {
                return this.valueListField;
            }
            set
            {
                this.valueListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ChannelDiagItem", typeof(ChannelDiagItemT), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ProfileChannelDiagItem", typeof(ProfileChannelDiagItemT), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("SystemDefinedChannelDiagItem", typeof(SystemDefinedChannelDiagItemT), IsNullable = false)]
        public object[] ChannelDiagList
        {
            get
            {
                return this.channelDiagListField;
            }
            set
            {
                this.channelDiagListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ChannelProcessAlarmItem", typeof(ChannelProcessAlarmItemT), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ProfileChannelProcessAlarmItem", typeof(ProfileChannelProcessAlarmItemT), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("SystemDefinedChannelProcessAlarmItem", typeof(SystemDefinedChannelProcessAlarmItemT), IsNullable = false)]
        public object[] ChannelProcessAlarmList
        {
            get
            {
                return this.channelProcessAlarmListField;
            }
            set
            {
                this.channelProcessAlarmListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ProfileUnitDiagTypeItem", typeof(ProfileUnitDiagTypeItemT), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("UnitDiagTypeItem", typeof(UnitDiagTypeItemT), IsNullable = false)]
        public object[] UnitDiagTypeList
        {
            get
            {
                return this.unitDiagTypeListField;
            }
            set
            {
                this.unitDiagTypeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("LogBookEntryItem", IsNullable = false)]
        public LogBookEntryItemT[] LogBookEntryList
        {
            get
            {
                return this.logBookEntryListField;
            }
            set
            {
                this.logBookEntryListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("GraphicItem", IsNullable = false)]
        public GraphicItemT[] GraphicsList
        {
            get
            {
                return this.graphicsListField;
            }
            set
            {
                this.graphicsListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CategoryItem", IsNullable = false)]
        public CategoryItemT[] CategoryList
        {
            get
            {
                return this.categoryListField;
            }
            set
            {
                this.categoryListField = value;
            }
        }

        /// <remarks/>
        public ApplicationProcessTExternalTextList ExternalTextList
        {
            get
            {
                return this.externalTextListField;
            }
            set
            {
                this.externalTextListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ApplicationProcessTExternalTextList
    {

        private ExternalTextT[] primaryLanguageField;

        private LanguageT[] languageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Text", IsNullable = false)]
        public ExternalTextT[] PrimaryLanguage
        {
            get
            {
                return this.primaryLanguageField;
            }
            set
            {
                this.primaryLanguageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Language")]
        public LanguageT[] Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class DeviceFunctionT
    {

        private FamilyT familyField;

        /// <remarks/>
        public FamilyT Family
        {
            get
            {
                return this.familyField;
            }
            set
            {
                this.familyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class DeviceIdentityT
    {

        private ExternalTextRefT infoTextField;

        private TokenParameterT vendorNameField;

        private string vendorIDField;

        private string deviceIDField;

        /// <remarks/>
        public ExternalTextRefT InfoText
        {
            get
            {
                return this.infoTextField;
            }
            set
            {
                this.infoTextField = value;
            }
        }

        /// <remarks/>
        public TokenParameterT VendorName
        {
            get
            {
                return this.vendorNameField;
            }
            set
            {
                this.vendorNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VendorID
        {
            get
            {
                return this.vendorIDField;
            }
            set
            {
                this.vendorIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DeviceID
        {
            get
            {
                return this.deviceIDField;
            }
            set
            {
                this.deviceIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    public partial class ProfileBodyT
    {

        private DeviceIdentityT deviceIdentityField;

        private DeviceFunctionT deviceFunctionField;

        private ApplicationProcessT applicationProcessField;

        /// <remarks/>
        public DeviceIdentityT DeviceIdentity
        {
            get
            {
                return this.deviceIdentityField;
            }
            set
            {
                this.deviceIdentityField = value;
            }
        }

        /// <remarks/>
        public DeviceFunctionT DeviceFunction
        {
            get
            {
                return this.deviceFunctionField;
            }
            set
            {
                this.deviceFunctionField = value;
            }
        }

        /// <remarks/>
        public ApplicationProcessT ApplicationProcess
        {
            get
            {
                return this.applicationProcessField;
            }
            set
            {
                this.applicationProcessField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("Transforms", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class TransformsType
    {

        private TransformType[] transformField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Transform")]
        public TransformType[] Transform
        {
            get
            {
                return this.transformField;
            }
            set
            {
                this.transformField = value;
            }
        }
    }

}
