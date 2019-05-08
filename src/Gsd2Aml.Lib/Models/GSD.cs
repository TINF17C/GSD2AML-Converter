namespace Gsd2Aml.Lib.Models
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile", IsNullable = false)]
    internal partial class ISO15745Profile
    {

        private ProfileHeaderT profileHeaderField;

        private ProfileBodyT profileBodyField;

        private SignatureType signatureField;

        /// <remarks/>
        internal ProfileHeaderT ProfileHeader
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
        internal ProfileBodyT ProfileBody
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
        internal SignatureType Signature
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
    internal partial class ProfileHeaderT
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
        internal string ProfileIdentification
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
        internal string ProfileRevision
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
        internal string ProfileName
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
        internal string ProfileSource
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
        internal ProfileClassID_EnumT ProfileClassID
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
        internal System.DateTime ProfileDate
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
        internal bool ProfileDateSpecified
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
        internal string AdditionalInformation
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
        internal ISO15745ReferenceT ISO15745Reference
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
        internal string[] IASInterfaceType
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
    internal enum ProfileClassID_EnumT
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
    internal partial class ISO15745ReferenceT
    {

        private string iSO15745PartField;

        private string iSO15745EditionField;

        private string profileTechnologyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        internal string ISO15745Part
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
        internal string ISO15745Edition
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
        internal string ProfileTechnology
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
    internal partial class SignaturePropertyType
    {

        private System.Xml.XmlElement[] itemsField;

        private string[] textField;

        private string targetField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        internal System.Xml.XmlElement[] Items
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
        internal string[] Text
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
        internal string Target
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
        internal string Id
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
    internal partial class SignaturePropertiesType
    {

        private SignaturePropertyType[] signaturePropertyField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SignatureProperty")]
        internal SignaturePropertyType[] SignatureProperty
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
        internal string Id
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
    internal partial class ManifestType
    {

        private ReferenceType[] referenceField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reference")]
        internal ReferenceType[] Reference
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
        internal string Id
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
    internal partial class ReferenceType
    {

        private TransformType[] transformsField;

        private DigestMethodType digestMethodField;

        private byte[] digestValueField;

        private string idField;

        private string uRIField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
        internal TransformType[] Transforms
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
        internal DigestMethodType DigestMethod
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
        internal byte[] DigestValue
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
        internal string Id
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
        internal string URI
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
        internal string Type
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
    internal partial class TransformType
    {

        private object[] itemsField;

        private string[] textField;

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("XPath", typeof(string))]
        internal object[] Items
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
        internal string[] Text
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
        internal string Algorithm
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
    internal partial class DigestMethodType
    {

        private System.Xml.XmlNode[] anyField;

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        internal System.Xml.XmlNode[] Any
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
        internal string Algorithm
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
    internal partial class ObjectType
    {

        private System.Xml.XmlNode[] anyField;

        private string idField;

        private string mimeTypeField;

        private string encodingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        internal System.Xml.XmlNode[] Any
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
        internal string Id
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
        internal string MimeType
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
        internal string Encoding
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
    internal partial class SPKIDataType
    {

        private byte[][] sPKISexpField;

        private System.Xml.XmlElement anyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SPKISexp", DataType = "base64Binary")]
        internal byte[][] SPKISexp
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
        internal System.Xml.XmlElement Any
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
    internal partial class PGPDataType
    {

        private object[] itemsField;

        private ItemsChoiceType1[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("PGPKeyID", typeof(byte[]), DataType = "base64Binary")]
        [System.Xml.Serialization.XmlElementAttribute("PGPKeyPacket", typeof(byte[]), DataType = "base64Binary")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        internal object[] Items
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
        internal ItemsChoiceType1[] ItemsElementName
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
    internal enum ItemsChoiceType1
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
    internal partial class X509IssuerSerialType
    {

        private string x509IssuerNameField;

        private string x509SerialNumberField;

        /// <remarks/>
        internal string X509IssuerName
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
        internal string X509SerialNumber
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
    internal partial class X509DataType
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
        internal object[] Items
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
        internal ItemsChoiceType[] ItemsElementName
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
    internal enum ItemsChoiceType
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
    internal partial class RetrievalMethodType
    {

        private TransformType[] transformsField;

        private string uRIField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
        internal TransformType[] Transforms
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
        internal string URI
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
        internal string Type
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
    internal partial class RSAKeyValueType
    {

        private byte[] modulusField;

        private byte[] exponentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        internal byte[] Modulus
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
        internal byte[] Exponent
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
    internal partial class DSAKeyValueType
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
        internal byte[] P
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
        internal byte[] Q
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
        internal byte[] G
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
        internal byte[] Y
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
        internal byte[] J
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
        internal byte[] Seed
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
        internal byte[] PgenCounter
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
    internal partial class KeyValueType
    {

        private object itemField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("DSAKeyValue", typeof(DSAKeyValueType))]
        [System.Xml.Serialization.XmlElementAttribute("RSAKeyValue", typeof(RSAKeyValueType))]
        internal object Item
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
        internal string[] Text
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
    internal partial class KeyInfoType
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
        internal object[] Items
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
        internal ItemsChoiceType2[] ItemsElementName
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
        internal string[] Text
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
        internal string Id
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
    internal enum ItemsChoiceType2
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
    internal partial class SignatureValueType
    {

        private string idField;

        private byte[] valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        internal string Id
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
        internal byte[] Value
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
    internal partial class SignatureMethodType
    {

        private string hMACOutputLengthField;

        private System.Xml.XmlNode[] anyField;

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        internal string HMACOutputLength
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
        internal System.Xml.XmlNode[] Any
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
        internal string Algorithm
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
    internal partial class CanonicalizationMethodType
    {

        private System.Xml.XmlNode[] anyField;

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        internal System.Xml.XmlNode[] Any
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
        internal string Algorithm
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
    internal partial class SignedInfoType
    {

        private CanonicalizationMethodType canonicalizationMethodField;

        private SignatureMethodType signatureMethodField;

        private ReferenceType[] referenceField;

        private string idField;

        /// <remarks/>
        internal CanonicalizationMethodType CanonicalizationMethod
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
        internal SignatureMethodType SignatureMethod
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
        internal ReferenceType[] Reference
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
        internal string Id
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
    internal partial class SignatureType
    {

        private SignedInfoType signedInfoField;

        private SignatureValueType signatureValueField;

        private KeyInfoType keyInfoField;

        private ObjectType[] objectField;

        private string idField;

        /// <remarks/>
        internal SignedInfoType SignedInfo
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
        internal SignatureValueType SignatureValue
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
        internal KeyInfoType KeyInfo
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
        internal ObjectType[] Object
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
        internal string Id
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
    internal partial class ExternalTextDocumentT
    {

        private ExternalTextT[] textField;

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Text")]
        internal ExternalTextT[] Text
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
        internal string lang
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
    internal partial class ExternalTextT
    {

        private string textIdField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        internal string TextId
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
        internal string Value
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
    internal partial class LanguageT
    {

        private ExternalTextT[] textField;

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Text")]
        internal ExternalTextT[] Text
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
        internal string lang
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
    internal partial class ErrorCode2T
    {

        private ExternalTextRefT nameField;

        private ExternalTextRefT helpField;

        /// <remarks/>
        internal ExternalTextRefT Name
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
        internal ExternalTextRefT Help
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
    internal partial class ExternalTextRefT
    {

        private string textIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        internal string TextId
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
    internal partial class ErrorCode2ItemT : ErrorCode2T
    {

        private byte errorCode2Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal byte ErrorCode2
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
    internal partial class LogBookEntryItemT
    {

        private object itemField;

        private uint statusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ErrorCode2List", typeof(LogBookEntryItemTErrorCode2List))]
        [System.Xml.Serialization.XmlElementAttribute("ErrorCode2Value", typeof(ErrorCode2T))]
        internal object Item
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
        internal uint Status
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
    internal partial class LogBookEntryItemTErrorCode2List
    {

        private ErrorCode2ItemT[] errorCode2ItemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ErrorCode2Item")]
        internal ErrorCode2ItemT[] ErrorCode2Item
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
    internal partial class ProfileUnitDiagTypeItemT
    {

        private ExternalTextRefT nameField;

        private ExternalTextRefT helpField;

        private ProfileUnitDiagTypeItemTRef[] refField;

        private uint aPIField;

        private ushort userStructureIdentifierField;

        /// <remarks/>
        internal ExternalTextRefT Name
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
        internal ExternalTextRefT Help
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
        internal ProfileUnitDiagTypeItemTRef[] Ref
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
        internal uint API
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
        internal ushort UserStructureIdentifier
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
    internal partial class ProfileUnitDiagTypeItemTRef : ValueItemReferenceT
    {

        private UnitDiagRefTypeEnumT dataTypeField;

        private string defaultValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal UnitDiagRefTypeEnumT DataType
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
        internal string DefaultValue
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
    internal enum UnitDiagRefTypeEnumT
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
    internal partial class ValueItemReferenceT
    {

        private string valueItemTargetField;

        private uint byteOffsetField;

        private byte bitOffsetField;

        private string bitLengthField;

        private string textIdField;

        private ushort lengthField;

        private bool lengthFieldSpecified;

        internal ValueItemReferenceT()
        {
            this.bitOffsetField = ((byte)(0));
            this.bitLengthField = "1";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        internal string ValueItemTarget
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
        internal uint ByteOffset
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
        internal byte BitOffset
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
        internal string BitLength
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
        internal string TextId
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
        internal ushort Length
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
        internal bool LengthSpecified
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
    internal partial class RecordDataRefT : ValueItemReferenceT
    {

        private string idField;

        private RecordDataRefTypeEnumT dataTypeField;

        private string defaultValueField;

        private string allowedValuesField;

        private bool changeableField;

        private bool visibleField;

        internal RecordDataRefT()
        {
            this.changeableField = true;
            this.visibleField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        internal string ID
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
        internal RecordDataRefTypeEnumT DataType
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
        internal string DefaultValue
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
        internal string AllowedValues
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
        internal bool Changeable
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
        internal bool Visible
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
    internal enum RecordDataRefTypeEnumT
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
    internal partial class UnitDiagTypeItemT
    {

        private ExternalTextRefT nameField;

        private ExternalTextRefT helpField;

        private UnitDiagTypeItemTRef[] refField;

        private ushort userStructureIdentifierField;

        /// <remarks/>
        internal ExternalTextRefT Name
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
        internal ExternalTextRefT Help
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
        internal UnitDiagTypeItemTRef[] Ref
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
        internal ushort UserStructureIdentifier
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
    internal partial class UnitDiagTypeItemTRef : ValueItemReferenceT
    {

        private UnitDiagRefTypeEnumT dataTypeField;

        private string defaultValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal UnitDiagRefTypeEnumT DataType
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
        internal string DefaultValue
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
    internal partial class ProfileChannelProcessAlarmItemT
    {

        private ExternalTextRefT nameField;

        private ExternalTextRefT helpField;

        private object[] extChannelProcessAlarmListField;

        private uint aPIField;

        private ushort reasonField;

        /// <remarks/>
        internal ExternalTextRefT Name
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
        internal ExternalTextRefT Help
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
        internal object[] ExtChannelProcessAlarmList
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
        internal uint API
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
        internal ushort Reason
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
    internal partial class ExtChannelProcessAlarmItemT
    {

        private ExternalTextRefT nameField;

        private ExternalTextRefT helpField;

        private ProcessAlarmReasonAddValueItemT[] processAlarmReasonAddValueField;

        private ushort reasonField;

        /// <remarks/>
        internal ExternalTextRefT Name
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
        internal ExternalTextRefT Help
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
        internal ProcessAlarmReasonAddValueItemT[] ProcessAlarmReasonAddValue
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
        internal ushort Reason
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
    internal partial class ProcessAlarmReasonAddValueItemT
    {

        private byte idField;

        private ProcessAlarmReasonAddValueDataItemTypeEnumT dataTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal byte Id
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
        internal ProcessAlarmReasonAddValueDataItemTypeEnumT DataType
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
    internal enum ProcessAlarmReasonAddValueDataItemTypeEnumT
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
    internal partial class ProfileExtChannelProcessAlarmItemT
    {

        private ExternalTextRefT nameField;

        private ExternalTextRefT helpField;

        private ProcessAlarmReasonAddValueItemT[] processAlarmReasonAddValueField;

        private ushort reasonField;

        /// <remarks/>
        internal ExternalTextRefT Name
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
        internal ExternalTextRefT Help
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
        internal ProcessAlarmReasonAddValueItemT[] ProcessAlarmReasonAddValue
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
        internal ushort Reason
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
    internal partial class SystemDefinedChannelProcessAlarmItemT
    {

        private object[] extChannelProcessAlarmListField;

        private string reasonField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ExtChannelProcessAlarmItem", typeof(ExtChannelProcessAlarmItemT), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ProfileExtChannelProcessAlarmItem", typeof(SystemDefinedChannelProcessAlarmItemTProfileExtChannelProcessAlarmItem), IsNullable = false)]
        internal object[] ExtChannelProcessAlarmList
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
        internal string Reason
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
    internal partial class SystemDefinedChannelProcessAlarmItemTProfileExtChannelProcessAlarmItem : ProfileExtChannelProcessAlarmItemT
    {

        private uint aPIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal uint API
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
    internal partial class ChannelProcessAlarmItemT
    {

        private ExternalTextRefT nameField;

        private ExternalTextRefT helpField;

        private ExtChannelProcessAlarmItemT[] extChannelProcessAlarmListField;

        private ushort reasonField;

        /// <remarks/>
        internal ExternalTextRefT Name
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
        internal ExternalTextRefT Help
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
        internal ExtChannelProcessAlarmItemT[] ExtChannelProcessAlarmList
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
        internal ushort Reason
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
    internal partial class ProfileChannelDiagItemT
    {

        private ExternalTextRefT nameField;

        private ExternalTextRefT helpField;

        private object[] extChannelDiagListField;

        private uint aPIField;

        private ushort errorTypeField;

        private string maintenanceAlarmStateField;

        internal ProfileChannelDiagItemT()
        {
            this.maintenanceAlarmStateField = "D";
        }

        /// <remarks/>
        internal ExternalTextRefT Name
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
        internal ExternalTextRefT Help
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
        internal object[] ExtChannelDiagList
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
        internal uint API
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
        internal ushort ErrorType
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
        internal string MaintenanceAlarmState
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
    internal partial class ExtChannelDiagItemT
    {

        private ExternalTextRefT nameField;

        private ExternalTextRefT helpField;

        private ExtChannelAddValueItemT[] extChannelAddValueField;

        private ushort errorTypeField;

        private string maintenanceAlarmStateField;

        internal ExtChannelDiagItemT()
        {
            this.maintenanceAlarmStateField = "D";
        }

        /// <remarks/>
        internal ExternalTextRefT Name
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
        internal ExternalTextRefT Help
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
        internal ExtChannelAddValueItemT[] ExtChannelAddValue
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
        internal ushort ErrorType
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
        internal string MaintenanceAlarmState
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
    internal partial class ExtChannelAddValueItemT
    {

        private byte idField;

        private ExtChannelAddValueDataItemTypeEnumT dataTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal byte Id
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
        internal ExtChannelAddValueDataItemTypeEnumT DataType
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
    internal enum ExtChannelAddValueDataItemTypeEnumT
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
    internal partial class ProfileExtChannelDiagItemT
    {

        private ExternalTextRefT nameField;

        private ExternalTextRefT helpField;

        private ExtChannelAddValueItemT[] extChannelAddValueField;

        private ushort errorTypeField;

        private string maintenanceAlarmStateField;

        internal ProfileExtChannelDiagItemT()
        {
            this.maintenanceAlarmStateField = "D";
        }

        /// <remarks/>
        internal ExternalTextRefT Name
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
        internal ExternalTextRefT Help
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
        internal ExtChannelAddValueItemT[] ExtChannelAddValue
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
        internal ushort ErrorType
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
        internal string MaintenanceAlarmState
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
    internal partial class SystemDefinedChannelDiagItemT
    {

        private object[] extChannelDiagListField;

        private string errorTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ExtChannelDiagItem", typeof(ExtChannelDiagItemT), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ProfileExtChannelDiagItem", typeof(SystemDefinedChannelDiagItemTProfileExtChannelDiagItem), IsNullable = false)]
        internal object[] ExtChannelDiagList
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
        internal string ErrorType
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
    internal partial class SystemDefinedChannelDiagItemTProfileExtChannelDiagItem : ProfileExtChannelDiagItemT
    {

        private uint aPIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal uint API
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
    internal partial class ChannelDiagItemT
    {

        private ExternalTextRefT nameField;

        private ExternalTextRefT helpField;

        private ExtChannelDiagItemT[] extChannelDiagListField;

        private ushort errorTypeField;

        private string maintenanceAlarmStateField;

        internal ChannelDiagItemT()
        {
            this.maintenanceAlarmStateField = "D";
        }

        /// <remarks/>
        internal ExternalTextRefT Name
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
        internal ExternalTextRefT Help
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
        internal ExtChannelDiagItemT[] ExtChannelDiagList
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
        internal ushort ErrorType
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
        internal string MaintenanceAlarmState
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
    internal partial class SystemRedundancyT
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

        internal SystemRedundancyT()
        {
            this.rT_InputOnBackupAR_SupportedField = false;
            this.numberOfAR_SetsField = ((byte)(1));
            this.dataInvalidOnBackupAR_SupportedField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal SRDeviceTypeEnumT DeviceType
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
        internal ushort MaxSwitchOverTime
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
        internal bool PrimaryAR_OnBothNAPsSupported
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
        internal bool PrimaryAR_OnBothNAPsSupportedSpecified
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
        internal bool RT_InputOnBackupAR_Supported
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
        internal byte NumberOfAR_Sets
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
        internal ushort MinRDHT
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
        internal bool MinRDHTSpecified
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
        internal bool DataInvalidOnBackupAR_Supported
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
        internal ushort S2MaxInputOnBackupDelay
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
        internal bool S2MaxInputOnBackupDelaySpecified
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
        internal ushort R2MaxInputOnBackupDelay
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
        internal bool R2MaxInputOnBackupDelaySpecified
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
    internal enum SRDeviceTypeEnumT
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
    internal partial class ApplicationRelationsObsoleteT
    {

        private ApplicationRelationsObsoleteTTimingProperties timingPropertiesField;

        private ushort aR_BlockVersionField;

        private ushort iOCR_BlockVersionField;

        private ushort alarmCR_BlockVersionField;

        private ushort submoduleDataBlockVersionField;

        /// <remarks/>
        internal ApplicationRelationsObsoleteTTimingProperties TimingProperties
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
        internal ushort AR_BlockVersion
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
        internal ushort IOCR_BlockVersion
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
        internal ushort AlarmCR_BlockVersion
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
        internal ushort SubmoduleDataBlockVersion
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
    internal partial class ApplicationRelationsObsoleteTTimingProperties
    {

        private string sendClockField;

        private string reductionRatioField;

        internal ApplicationRelationsObsoleteTTimingProperties()
        {
            this.sendClockField = "32";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("32")]
        internal string SendClock
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
        internal string ReductionRatio
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
    internal partial class MAUTypeItemT
    {

        private ushort valueField;

        private ushort extensionField;

        private bool adjustSupportedField;

        internal MAUTypeItemT()
        {
            this.extensionField = ((ushort)(0));
            this.adjustSupportedField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal ushort Value
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
        internal ushort Extension
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
        internal bool AdjustSupported
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
    internal partial class ApplicationRelationsT
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

        internal ApplicationRelationsT()
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
        internal ApplicationRelationsTTimingProperties TimingProperties
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
        internal ApplicationRelationsTRT_Class3TimingProperties RT_Class3TimingProperties
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
        internal string StartupMode
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
        internal ushort NumberOfAdditionalInputCR
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
        internal ushort NumberOfAdditionalOutputCR
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
        internal ushort NumberOfAdditionalMulticastProviderCR
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
        internal ushort NumberOfMulticastConsumerCR
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
        internal bool PullModuleAlarmSupported
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
        internal ushort NumberOfAR
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
    internal partial class ApplicationRelationsTTimingProperties
    {

        private string sendClockField;

        private string reductionRatioField;

        private string reductionRatioPow2Field;

        private ushort preferredSendClockField;

        private bool preferredSendClockFieldSpecified;

        internal ApplicationRelationsTTimingProperties()
        {
            this.sendClockField = "32";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("32")]
        internal string SendClock
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
        internal string ReductionRatio
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
        internal string ReductionRatioPow2
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
        internal ushort PreferredSendClock
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
        internal bool PreferredSendClockSpecified
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
    internal partial class ApplicationRelationsTRT_Class3TimingProperties
    {

        private string sendClockField;

        private string reductionRatioField;

        private string reductionRatioPow2Field;

        private ushort maxReductionRatioIsochroneModeField;

        private bool maxReductionRatioIsochroneModeFieldSpecified;

        private ushort preferredSendClockField;

        private bool preferredSendClockFieldSpecified;

        internal ApplicationRelationsTRT_Class3TimingProperties()
        {
            this.sendClockField = "32";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("32")]
        internal string SendClock
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
        internal string ReductionRatio
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
        internal string ReductionRatioPow2
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
        internal ushort MaxReductionRatioIsochroneMode
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
        internal bool MaxReductionRatioIsochroneModeSpecified
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
        internal ushort PreferredSendClock
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
        internal bool PreferredSendClockSpecified
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
    internal partial class RT_Class3PropertiesT
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

        internal RT_Class3PropertiesT()
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
        internal string StartupMode
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
        internal string ForwardingMode
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
        internal ushort MaxBridgeDelay
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
        internal ushort MaxBridgeDelayFFW
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
        internal bool MaxBridgeDelayFFWSpecified
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
        internal ushort MaxDFP_Feed
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
        internal bool MaxDFP_FeedSpecified
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
        internal ushort MaxDFP_Frames
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
        internal bool AlignDFP_Subframes
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
        internal bool DFP_OutboundTruncationSupported
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
        internal bool DFP_RedundantPathLayoutSupported
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
        internal ushort MaxNumberIR_FrameData
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
        internal ushort MaxRangeIR_FrameID
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
        internal FragmentationTypeEnumT FragmentationType
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
        internal bool FragmentationTypeSpecified
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
        internal ushort MaxRedPeriodLength
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
        internal ushort MinFSO
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
        internal ushort MinRTC3_Gap
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
        internal uint MinYellowTime
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
        internal ushort YellowSafetyMargin
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
        internal uint MaxRetentionTime
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
        internal bool MaxRetentionTimeSpecified
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
    internal enum FragmentationTypeEnumT
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
    internal partial class PROFIenergyT
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

        internal PROFIenergyT()
        {
            this.dynamicTimeAndEnergyValuesField = false;
            this.pESAP_uses_PROFIenergyASEField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("EnergySavingModeItem", IsNullable = false)]
        internal PROFIenergyTEnergySavingModeItem[] EnergySavingModeList
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
        internal PROFIenergyTMeasurementItem[] MeasurementList
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
        internal string ProfileVersion
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
        internal PE_EntityClassEnumT EntityClass
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
        internal bool EntityClassSpecified
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
        internal PE_EntitySubclassEnumT EntitySubclass
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
        internal bool EntitySubclassSpecified
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
        internal bool DynamicTimeAndEnergyValues
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
        internal bool PESAP_uses_PROFIenergyASE
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
    internal partial class PROFIenergyTEnergySavingModeItem
    {

        private byte idField;

        private uint timeToPauseField;

        private uint rTTOField;

        private uint timeMinLengthOfStayField;

        private float powerConsumptionField;

        private float energyConsumptionToDestinationField;

        private float energyConsumptionToOperationField;

        internal PROFIenergyTEnergySavingModeItem()
        {
            this.powerConsumptionField = ((float)(0F));
            this.energyConsumptionToDestinationField = ((float)(0F));
            this.energyConsumptionToOperationField = ((float)(0F));
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal byte ID
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
        internal uint TimeToPause
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
        internal uint RTTO
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
        internal uint TimeMinLengthOfStay
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
        internal float PowerConsumption
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
        internal float EnergyConsumptionToDestination
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
        internal float EnergyConsumptionToOperation
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
    internal partial class PROFIenergyTMeasurementItem
    {

        private PROFIenergyTMeasurementItemMeasurementValue[] measurementValueField;

        private ushort numberField;

        private bool numberFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeasurementValue")]
        internal PROFIenergyTMeasurementItemMeasurementValue[] MeasurementValue
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
        internal ushort Number
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
        internal bool NumberSpecified
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
    internal partial class PROFIenergyTMeasurementItemMeasurementValue
    {

        private ushort idField;

        private byte accuracyDomainField;

        private byte accuracyClassField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal ushort ID
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
        internal byte AccuracyDomain
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
        internal byte AccuracyClass
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
    internal enum PE_EntityClassEnumT
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
    internal enum PE_EntitySubclassEnumT
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
    internal partial class F_ParameterRecordDataT
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

        internal F_ParameterRecordDataT()
        {
            this.transferSequenceField = ((ushort)(0));
            this.changeableWithBumpField = false;
        }

        /// <remarks/>
        internal F_ParameterRecordDataTF_Check_iPar F_Check_iPar
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
        internal F_ParameterRecordDataTF_SIL F_SIL
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
        internal F_ParameterRecordDataTF_CRC_Length F_CRC_Length
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
        internal F_ParameterRecordDataTF_CRC_Seed F_CRC_Seed
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
        internal F_ParameterRecordDataTF_Passivation F_Passivation
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
        internal F_ParameterRecordDataTF_Block_ID F_Block_ID
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
        internal F_ParameterRecordDataTF_Par_Version F_Par_Version
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
        internal F_ParameterRecordDataTF_Source_Add F_Source_Add
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
        internal F_ParameterRecordDataTF_Dest_Add F_Dest_Add
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
        internal F_ParameterRecordDataTF_WD_Time F_WD_Time
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
        internal F_ParameterRecordDataTF_Par_CRC F_Par_CRC
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
        internal F_ParameterRecordDataTF_iPar_CRC F_iPar_CRC
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
        internal ushort F_ParamDescCRC
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
        internal string F_SupportedParameters
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
        internal ushort Index
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
        internal ushort TransferSequence
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
        internal bool ChangeableWithBump
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
    internal partial class F_ParameterRecordDataTF_Check_iPar
    {

        private F_Check_iParEnumT defaultValueField;

        private string allowedValuesField;

        private bool changeableField;

        private bool visibleField;

        internal F_ParameterRecordDataTF_Check_iPar()
        {
            this.defaultValueField = F_Check_iParEnumT.NoCheck;
            this.allowedValuesField = "Check NoCheck";
            this.changeableField = false;
            this.visibleField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(F_Check_iParEnumT.NoCheck)]
        internal F_Check_iParEnumT DefaultValue
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
        internal string AllowedValues
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
        internal bool Changeable
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
        internal bool Visible
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
    internal enum F_Check_iParEnumT
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
    internal partial class F_ParameterRecordDataTF_SIL
    {

        private F_SIL_EnumT defaultValueField;

        private string allowedValuesField;

        private bool changeableField;

        private bool visibleField;

        private bool visibleFieldSpecified;

        internal F_ParameterRecordDataTF_SIL()
        {
            this.defaultValueField = F_SIL_EnumT.SIL3;
            this.allowedValuesField = "SIL1 SIL2 SIL3 NoSIL";
            this.changeableField = true;
            this.visibleField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(F_SIL_EnumT.SIL3)]
        internal F_SIL_EnumT DefaultValue
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
        internal string AllowedValues
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
        internal bool Changeable
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
        internal bool Visible
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
        internal bool VisibleSpecified
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
    internal enum F_SIL_EnumT
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
    internal partial class F_ParameterRecordDataTF_CRC_Length
    {

        private F_CRC_LengthEnumT defaultValueField;

        private string allowedValuesField;

        private bool changeableField;

        private bool changeableFieldSpecified;

        private bool visibleField;

        internal F_ParameterRecordDataTF_CRC_Length()
        {
            this.defaultValueField = F_CRC_LengthEnumT.Item3ByteCRC;
            this.allowedValuesField = "3-Byte-CRC";
            this.changeableField = false;
            this.visibleField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(F_CRC_LengthEnumT.Item3ByteCRC)]
        internal F_CRC_LengthEnumT DefaultValue
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
        internal string AllowedValues
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
        internal bool Changeable
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
        internal bool ChangeableSpecified
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
        internal bool Visible
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
    internal enum F_CRC_LengthEnumT
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
    internal partial class F_ParameterRecordDataTF_CRC_Seed
    {

        private F_CRC_SeedEnumT defaultValueField;

        private bool defaultValueFieldSpecified;

        private string allowedValuesField;

        private bool changeableField;

        private bool changeableFieldSpecified;

        private bool visibleField;

        private bool visibleFieldSpecified;

        internal F_ParameterRecordDataTF_CRC_Seed()
        {
            this.defaultValueField = F_CRC_SeedEnumT.CRCSeed2432;
            this.allowedValuesField = "CRC-Seed24/32";
            this.changeableField = false;
            this.visibleField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal F_CRC_SeedEnumT DefaultValue
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
        internal bool DefaultValueSpecified
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
        internal string AllowedValues
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
        internal bool Changeable
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
        internal bool ChangeableSpecified
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
        internal bool Visible
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
        internal bool VisibleSpecified
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
    internal enum F_CRC_SeedEnumT
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
    internal partial class F_ParameterRecordDataTF_Passivation
    {

        private F_PassivationEnumT defaultValueField;

        private string allowedValuesField;

        private bool changeableField;

        private bool changeableFieldSpecified;

        private bool visibleField;

        private bool visibleFieldSpecified;

        internal F_ParameterRecordDataTF_Passivation()
        {
            this.defaultValueField = F_PassivationEnumT.DeviceModule;
            this.allowedValuesField = "Device/Module";
            this.changeableField = false;
            this.visibleField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(F_PassivationEnumT.DeviceModule)]
        internal F_PassivationEnumT DefaultValue
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
        internal string AllowedValues
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
        internal bool Changeable
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
        internal bool ChangeableSpecified
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
        internal bool Visible
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
        internal bool VisibleSpecified
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
    internal enum F_PassivationEnumT
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
    internal partial class F_ParameterRecordDataTF_Block_ID
    {

        private byte defaultValueField;

        private string allowedValuesField;

        private bool changeableField;

        private bool visibleField;

        internal F_ParameterRecordDataTF_Block_ID()
        {
            this.defaultValueField = ((byte)(0));
            this.allowedValuesField = "0..7";
            this.changeableField = false;
            this.visibleField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "0")]
        internal byte DefaultValue
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
        internal string AllowedValues
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
        internal bool Changeable
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
        internal bool Visible
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
    internal partial class F_ParameterRecordDataTF_Par_Version
    {

        private byte defaultValueField;

        private bool defaultValueFieldSpecified;

        private string allowedValuesField;

        private bool changeableField;

        private bool changeableFieldSpecified;

        private bool visibleField;

        private bool visibleFieldSpecified;

        internal F_ParameterRecordDataTF_Par_Version()
        {
            this.defaultValueField = ((byte)(1));
            this.allowedValuesField = "1";
            this.changeableField = false;
            this.visibleField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal byte DefaultValue
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
        internal bool DefaultValueSpecified
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
        internal string AllowedValues
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
        internal bool Changeable
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
        internal bool ChangeableSpecified
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
        internal bool Visible
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
        internal bool VisibleSpecified
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
    internal partial class F_ParameterRecordDataTF_Source_Add
    {

        private ushort defaultValueField;

        private string allowedValuesField;

        private bool changeableField;

        private bool changeableFieldSpecified;

        private bool visibleField;

        private bool visibleFieldSpecified;

        internal F_ParameterRecordDataTF_Source_Add()
        {
            this.defaultValueField = ((ushort)(1));
            this.allowedValuesField = "1..65534";
            this.changeableField = true;
            this.visibleField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "1")]
        internal ushort DefaultValue
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
        internal string AllowedValues
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
        internal bool Changeable
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
        internal bool ChangeableSpecified
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
        internal bool Visible
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
        internal bool VisibleSpecified
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
    internal partial class F_ParameterRecordDataTF_Dest_Add
    {

        private ushort defaultValueField;

        private string allowedValuesField;

        private bool changeableField;

        private bool changeableFieldSpecified;

        private bool visibleField;

        private bool visibleFieldSpecified;

        internal F_ParameterRecordDataTF_Dest_Add()
        {
            this.defaultValueField = ((ushort)(1));
            this.allowedValuesField = "1..65534";
            this.changeableField = true;
            this.visibleField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "1")]
        internal ushort DefaultValue
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
        internal string AllowedValues
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
        internal bool Changeable
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
        internal bool ChangeableSpecified
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
        internal bool Visible
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
        internal bool VisibleSpecified
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
    internal partial class F_ParameterRecordDataTF_WD_Time
    {

        private ushort defaultValueField;

        private string allowedValuesField;

        private bool changeableField;

        private bool changeableFieldSpecified;

        private bool visibleField;

        private bool visibleFieldSpecified;

        internal F_ParameterRecordDataTF_WD_Time()
        {
            this.defaultValueField = ((ushort)(150));
            this.allowedValuesField = "1..65535";
            this.changeableField = true;
            this.visibleField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "150")]
        internal ushort DefaultValue
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
        internal string AllowedValues
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
        internal bool Changeable
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
        internal bool ChangeableSpecified
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
        internal bool Visible
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
        internal bool VisibleSpecified
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
    internal partial class F_ParameterRecordDataTF_Par_CRC
    {

        private ushort defaultValueField;

        private string allowedValuesField;

        private bool changeableField;

        private bool changeableFieldSpecified;

        private bool visibleField;

        private bool visibleFieldSpecified;

        internal F_ParameterRecordDataTF_Par_CRC()
        {
            this.defaultValueField = ((ushort)(53356));
            this.allowedValuesField = "0..65535";
            this.changeableField = true;
            this.visibleField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "53356")]
        internal ushort DefaultValue
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
        internal string AllowedValues
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
        internal bool Changeable
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
        internal bool ChangeableSpecified
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
        internal bool Visible
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
        internal bool VisibleSpecified
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
    internal partial class F_ParameterRecordDataTF_iPar_CRC
    {

        private uint defaultValueField;

        private string allowedValuesField;

        private bool changeableField;

        private bool changeableFieldSpecified;

        private bool visibleField;

        private bool visibleFieldSpecified;

        internal F_ParameterRecordDataTF_iPar_CRC()
        {
            this.defaultValueField = ((uint)(0));
            this.allowedValuesField = "0..4294967295";
            this.changeableField = true;
            this.visibleField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        internal uint DefaultValue
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
        internal string AllowedValues
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
        internal bool Changeable
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
        internal bool ChangeableSpecified
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
        internal bool Visible
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
        internal bool VisibleSpecified
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
    internal partial class ParameterRecordDataT
    {

        private ExternalTextRefT nameField;

        private object[] itemsField;

        private MenuItemT[] menuListField;

        private string indexField;

        private uint lengthField;

        private ushort transferSequenceField;

        private bool changeableWithBumpField;

        internal ParameterRecordDataT()
        {
            this.transferSequenceField = ((ushort)(0));
            this.changeableWithBumpField = false;
        }

        /// <remarks/>
        internal ExternalTextRefT Name
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
        internal object[] Items
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
        internal MenuItemT[] MenuList
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
        internal string Index
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
        internal uint Length
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
        internal ushort TransferSequence
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
        internal bool ChangeableWithBump
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
    internal partial class RecordDataConstT
    {

        private uint byteOffsetField;

        private string dataField;

        internal RecordDataConstT()
        {
            this.byteOffsetField = ((uint)(0));
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        internal uint ByteOffset
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
        internal string Data
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
    internal partial class MenuItemT : ObjectT
    {

        private ExternalTextRefT nameField;

        private object[] itemsField;

        /// <remarks/>
        internal ExternalTextRefT Name
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
        internal object[] Items
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
    internal partial class MenuRefT
    {

        private string menuTargetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        internal string MenuTarget
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
    internal partial class ParameterRefT
    {

        private string parameterTargetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        internal string ParameterTarget
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
    internal partial class ObjectT
    {

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        internal string ID
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
    internal partial class CategoryItemT : ObjectT
    {

        private ExternalTextRefT infoTextField;

        private string textIdField;

        /// <remarks/>
        internal ExternalTextRefT InfoText
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
        internal string TextId
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
    internal partial class GraphicItemT : ObjectT
    {

        private GraphicItemTEmbedded embeddedField;

        private string graphicFileField;

        /// <remarks/>
        internal GraphicItemTEmbedded Embedded
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
        internal string GraphicFile
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
    internal partial class GraphicItemTEmbedded
    {

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        internal string[] Text
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
    internal partial class ValueItemT : ObjectT
    {

        private ExternalTextRefT helpField;

        private ValueAssignmentsTAssign[] assignmentsField;

        /// <remarks/>
        internal ExternalTextRefT Help
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
        internal ValueAssignmentsTAssign[] Assignments
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
    internal partial class ValueAssignmentsTAssign
    {

        private string textIdField;

        private string contentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        internal string TextId
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
        internal string Content
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
    internal partial class ModuleItemT : ObjectT
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

        internal ModuleItemT()
        {
            this.requiredSchemaVersionField = "V1.0";
        }

        /// <remarks/>
        internal ModuleInfoT ModuleInfo
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
        internal SubslotListTSubslotItem[] SubslotList
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
        internal BuiltInSubmoduleItemT[] VirtualSubmoduleList
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
        internal BuiltInPortSubmoduleItemT[] SystemDefinedSubmoduleList
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
        internal UseableSubmodulesTSubmoduleItemRef[] UseableSubmodules
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
        internal GraphicsReferenceTGraphicItemRef[] Graphics
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
        internal string ModuleIdentNumber
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
        internal string RequiredSchemaVersion
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
        internal string PhysicalSubslots
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
        internal ushort FieldbusType
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
        internal bool FieldbusTypeSpecified
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
    internal partial class ModuleInfoT
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
        internal ExternalTextRefT Name
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
        internal ExternalTextRefT InfoText
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
        internal FamilyT Family
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
        internal TokenParameterT VendorName
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
        internal TokenParameterT OrderNumber
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
        internal TokenParameterT HardwareRelease
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
        internal TokenParameterT SoftwareRelease
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
        internal string CategoryRef
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
        internal string SubCategory1Ref
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
    internal partial class FamilyT
    {

        private FamilyEnumT mainFamilyField;

        private string productFamilyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal FamilyEnumT MainFamily
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
        internal string ProductFamily
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
    internal enum FamilyEnumT
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
    internal partial class TokenParameterT
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        internal string Value
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
    internal partial class SubslotListTSubslotItem
    {

        private ushort subslotNumberField;

        private string textIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal ushort SubslotNumber
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
        internal string TextId
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
    internal partial class BuiltInSubmoduleItemT : SubmoduleItemBaseT
    {

        private string fixedInSubslotsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal string FixedInSubslots
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
    internal partial class SubmoduleItemBaseT : ObjectT
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

        internal SubmoduleItemBaseT()
        {
            this.aPIField = ((uint)(0));
            this.pROFIsafeSupportedField = false;
            this.iM5_SupportedField = false;
            this.max_iParameterSizeField = ((uint)(0));
        }

        /// <remarks/>
        internal SubmoduleItemBaseTIOData IOData
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
        internal SubmoduleItemBaseTRecordDataList RecordDataList
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
        internal ModuleInfoT ModuleInfo
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
        internal GraphicsReferenceTGraphicItemRef[] Graphics
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
        internal SubmoduleItemBaseTIsochroneMode IsochroneMode
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
        internal SubmoduleItemBaseTSlotCluster SlotCluster
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
        internal PROFIenergyT PROFIenergy
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
        internal ReportingSystemEventsTObserver[] ReportingSystemEvents
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
        internal string SubmoduleIdentNumber
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
        internal uint API
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
        internal bool PROFIsafeSupported
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
        internal string Writeable_IM_Records
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
        internal bool IM5_Supported
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
        internal uint Max_iParameterSize
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
        internal ushort SubsysModuleDirIndex
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
        internal bool SubsysModuleDirIndexSpecified
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
        internal string SupportedSubstitutionModes
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
        internal bool MayIssueProcessAlarm
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
    internal partial class SubmoduleItemBaseTIOData
    {

        private IODataT inputField;

        private IODataT outputField;

        private byte f_IO_StructureDescVersionField;

        private uint f_IO_StructureDescCRCField;

        private bool f_IO_StructureDescCRCFieldSpecified;

        internal SubmoduleItemBaseTIOData()
        {
            this.f_IO_StructureDescVersionField = ((byte)(1));
        }

        /// <remarks/>
        internal IODataT Input
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
        internal IODataT Output
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
        internal byte F_IO_StructureDescVersion
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
        internal uint F_IO_StructureDescCRC
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
        internal bool F_IO_StructureDescCRCSpecified
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
    internal partial class IODataT
    {

        private IODataTDataItem[] dataItemField;

        private IODataTChannel[] channelField;

        private IODataConsistencyEnumT consistencyField;

        internal IODataT()
        {
            this.consistencyField = IODataConsistencyEnumT.Itemconsistency;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataItem")]
        internal IODataTDataItem[] DataItem
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
        internal IODataTChannel[] Channel
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
        internal IODataConsistencyEnumT Consistency
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
    internal partial class IODataTDataItem
    {

        private IODataTDataItemBitDataItem[] bitDataItemField;

        private DataItemTypeEnumT dataTypeField;

        private ushort lengthField;

        private bool lengthFieldSpecified;

        private bool useAsBitsField;

        private bool subordinateField;

        private string textIdField;

        internal IODataTDataItem()
        {
            this.useAsBitsField = false;
            this.subordinateField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BitDataItem")]
        internal IODataTDataItemBitDataItem[] BitDataItem
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
        internal DataItemTypeEnumT DataType
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
        internal ushort Length
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
        internal bool LengthSpecified
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
        internal bool UseAsBits
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
        internal bool Subordinate
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
        internal string TextId
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
    internal partial class IODataTDataItemBitDataItem
    {

        private byte bitOffsetField;

        private string textIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal byte BitOffset
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
        internal string TextId
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
    internal enum DataItemTypeEnumT
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
    internal partial class IODataTChannel
    {

        private IODataTChannelData dataField;

        private IODataTChannelQuality qualityField;

        private ushort numberField;

        /// <remarks/>
        internal IODataTChannelData Data
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
        internal IODataTChannelQuality Quality
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
        internal ushort Number
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
    internal partial class IODataTChannelData
    {

        private ushort bitOffsetField;

        private ushort bitLengthField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal ushort BitOffset
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
        internal ushort BitLength
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
    internal partial class IODataTChannelQuality
    {

        private ushort bitOffsetField;

        private QualityFormat_EnumT formatField;

        private bool oppositeDirectionField;

        internal IODataTChannelQuality()
        {
            this.oppositeDirectionField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal ushort BitOffset
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
        internal QualityFormat_EnumT Format
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
        internal bool OppositeDirection
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
    internal enum QualityFormat_EnumT
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
    internal enum IODataConsistencyEnumT
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
    internal partial class SubmoduleItemBaseTRecordDataList
    {

        private ParameterRecordDataT[] parameterRecordDataItemField;

        private F_ParameterRecordDataT f_ParameterRecordDataItemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ParameterRecordDataItem")]
        internal ParameterRecordDataT[] ParameterRecordDataItem
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
        internal F_ParameterRecordDataT F_ParameterRecordDataItem
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
    internal partial class GraphicsReferenceTGraphicItemRef
    {

        private GraphicsTypeEnumT typeField;

        private string graphicItemTargetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal GraphicsTypeEnumT Type
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
        internal string GraphicItemTarget
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
    internal enum GraphicsTypeEnumT
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
    internal partial class SubmoduleItemBaseTIsochroneMode
    {

        private ushort t_DC_BaseField;

        private ushort t_DC_MinField;

        private ushort t_DC_MaxField;

        private uint t_IO_BaseField;

        private uint t_IO_InputMinField;

        private uint t_IO_OutputMinField;

        private bool isochroneModeRequiredField;

        internal SubmoduleItemBaseTIsochroneMode()
        {
            this.isochroneModeRequiredField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal ushort T_DC_Base
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
        internal ushort T_DC_Min
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
        internal ushort T_DC_Max
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
        internal uint T_IO_Base
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
        internal uint T_IO_InputMin
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
        internal uint T_IO_OutputMin
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
        internal bool IsochroneModeRequired
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
    internal partial class SubmoduleItemBaseTSlotCluster
    {

        private ushort countField;

        private ushort fieldbusTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal ushort Count
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
        internal ushort FieldbusType
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
    internal partial class ReportingSystemEventsTObserver
    {

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal string Type
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
    internal partial class SubmoduleItemT : SubmoduleItemBaseT
    {

        private string requiredSchemaVersionField;

        internal SubmoduleItemT()
        {
            this.requiredSchemaVersionField = "V2.1";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("V2.1")]
        internal string RequiredSchemaVersion
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
    internal partial class BuiltInPortSubmoduleItemT : PortSubmoduleItemBaseT
    {

        private ushort subslotNumberField;

        private string textIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal ushort SubslotNumber
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
        internal string TextId
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
    internal partial class PortSubmoduleItemBaseT : ObjectT
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

        internal PortSubmoduleItemBaseT()
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
        internal ParameterRecordDataT[] RecordDataList
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
        internal PortSubmoduleItemBaseTMAUTypeList MAUTypeList
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
        internal string SubmoduleIdentNumber
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
        internal MAUTypeEnumT MAUType
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
        internal string MAUTypes
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
        internal string FiberOpticTypes
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
        internal ushort MaxPortTxDelay
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
        internal bool MaxPortTxDelaySpecified
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
        internal ushort MaxPortRxDelay
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
        internal bool MaxPortRxDelaySpecified
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
        internal bool PortDeactivationSupported
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
        internal LinkStateDiagnosisEnumT LinkStateDiagnosisCapability
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
        internal bool LinkStateDiagnosisCapabilitySpecified
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
        internal bool PowerBudgetControlSupported
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
        internal bool SupportsRingportConfig
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
        internal bool IsDefaultRingport
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
        internal bool SupportsMRP_InterconnPortConfig
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
        internal bool ParameterizationDisallowed
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
        internal string Writeable_IM_Records
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
        internal bool IM5_Supported
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
        internal bool CheckMAUTypeSupported
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
        internal bool CheckMAUTypeSupportedSpecified
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
        internal bool CheckMAUTypeDifferenceSupported
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
        internal bool CheckMAUTypeDifferenceSupportedSpecified
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
        internal bool ShortPreamble100MBitSupported
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
        internal bool ShortPreamble100MBitSupportedSpecified
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
    internal partial class PortSubmoduleItemBaseTMAUTypeList
    {

        private MAUTypeItemT[] mAUTypeItemField;

        private bool extensionSupportedField;

        internal PortSubmoduleItemBaseTMAUTypeList()
        {
            this.extensionSupportedField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MAUTypeItem")]
        internal MAUTypeItemT[] MAUTypeItem
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
        internal bool ExtensionSupported
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
    internal enum MAUTypeEnumT
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
    internal enum LinkStateDiagnosisEnumT
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
    internal partial class PortSubmoduleItemT : PortSubmoduleItemBaseT
    {

        private ModuleInfoT moduleInfoField;

        private GraphicsReferenceTGraphicItemRef[] graphicsField;

        private string requiredSchemaVersionField;

        internal PortSubmoduleItemT()
        {
            this.requiredSchemaVersionField = "V2.25";
        }

        /// <remarks/>
        internal ModuleInfoT ModuleInfo
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
        internal GraphicsReferenceTGraphicItemRef[] Graphics
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
        internal string RequiredSchemaVersion
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
    internal partial class UseableSubmodulesTSubmoduleItemRef
    {

        private string submoduleItemTargetField;

        private string allowedInSubslotsField;

        private string usedInSubslotsField;

        private string fixedInSubslotsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        internal string SubmoduleItemTarget
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
        internal string AllowedInSubslots
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
        internal string UsedInSubslots
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
        internal string FixedInSubslots
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
    internal partial class InterfaceSubmoduleItemT : ObjectT
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

        internal InterfaceSubmoduleItemT()
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
        internal InterfaceSubmoduleItemTGeneral General
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
        internal ParameterRecordDataT[] RecordDataList
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
        internal RT_Class3PropertiesT RT_Class3Properties
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
        internal InterfaceSubmoduleItemTSynchronisationMode SynchronisationMode
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
        internal InterfaceSubmoduleItemTTimeSynchronisation TimeSynchronisation
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
        internal InterfaceSubmoduleItemTReportingSystem ReportingSystem
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
        internal ApplicationRelationsT ApplicationRelations
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
        internal InterfaceSubmoduleItemTMediaRedundancy MediaRedundancy
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
        internal string SubmoduleIdentNumber
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
        internal string TextId
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
        internal ushort SubslotNumber
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
        internal RT_ClassEnumT SupportedRT_Class
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
        internal string SupportedRT_Classes
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
        internal bool IsochroneModeSupported
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
        internal string IsochroneModeInRT_Classes
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
        internal string SupportedProtocols
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
        internal bool NetworkComponentDiagnosisSupported
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
        internal bool DCP_HelloSupported
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
        internal bool PTP_BoundarySupported
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
        internal bool DCP_BoundarySupported
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
        internal bool MulticastBoundarySupported
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
        internal bool ParameterizationDisallowed
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
        internal bool DelayMeasurementSupported
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
        internal string Writeable_IM_Records
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
        internal bool IM5_Supported
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
        internal ushort MaxFrameStartTime
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
        internal ushort MinNRT_Gap
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
        internal bool PDEV_CombinedObjectSupported
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
        internal bool UsesStaticARP_CacheEntries
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
    internal partial class InterfaceSubmoduleItemTGeneral
    {

        private ExternalTextRefT dCP_FlashOnceSignalUnitField;

        /// <remarks/>
        internal ExternalTextRefT DCP_FlashOnceSignalUnit
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
    internal partial class InterfaceSubmoduleItemTSynchronisationMode
    {

        private SyncRoleEnumT supportedRoleField;

        private ushort maxLocalJitterField;

        private bool maxLocalJitterFieldSpecified;

        private ushort t_PLL_MAXField;

        private ushort peerToPeerJitterField;

        private bool peerToPeerJitterFieldSpecified;

        private string supportedSyncProtocolsField;

        internal InterfaceSubmoduleItemTSynchronisationMode()
        {
            this.supportedRoleField = SyncRoleEnumT.SyncSlave;
            this.t_PLL_MAXField = ((ushort)(1000));
            this.supportedSyncProtocolsField = "";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(SyncRoleEnumT.SyncSlave)]
        internal SyncRoleEnumT SupportedRole
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
        internal ushort MaxLocalJitter
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
        internal bool MaxLocalJitterSpecified
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
        internal ushort T_PLL_MAX
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
        internal ushort PeerToPeerJitter
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
        internal bool PeerToPeerJitterSpecified
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
        internal string SupportedSyncProtocols
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
    internal enum SyncRoleEnumT
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
    internal partial class InterfaceSubmoduleItemTTimeSynchronisation
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    internal partial class InterfaceSubmoduleItemTReportingSystem
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    internal partial class InterfaceSubmoduleItemTMediaRedundancy
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

        internal InterfaceSubmoduleItemTMediaRedundancy()
        {
            this.supportedRoleField = "Client";
            this.supportedMultipleRoleField = "Client";
            this.mRPD_SupportedField = false;
            this.mRT_SupportedField = false;
            this.additionalProtocolsSupportedField = false;
            this.additionalForwardingRulesSupportedField = false;
        }

        /// <remarks/>
        internal InterfaceSubmoduleItemTMediaRedundancyInterconnection Interconnection
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
        internal string SupportedRole
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
        internal string SupportedMultipleRole
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
        internal byte MaxMRP_Instances
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
        internal bool MaxMRP_InstancesSpecified
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
        internal bool MRPD_Supported
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
        internal bool MRT_Supported
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
        internal bool AdditionalProtocolsSupported
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
        internal bool AdditionalForwardingRulesSupported
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
    internal partial class InterfaceSubmoduleItemTMediaRedundancyInterconnection
    {

        private string supportedMRP_InterconnRoleField;

        private byte maxMRP_InterconnInstancesField;

        private bool maxMRP_InterconnInstancesFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal string SupportedMRP_InterconnRole
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
        internal byte MaxMRP_InterconnInstances
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
        internal bool MaxMRP_InterconnInstancesSpecified
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
    internal enum RT_ClassEnumT
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
    internal partial class DeviceAccessPointItemT : ObjectT
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

        internal DeviceAccessPointItemT()
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
        internal ModuleInfoT ModuleInfo
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
        internal CertificationInfoT CertificationInfo
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
        internal SubslotListTSubslotItem[] SubslotList
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
        internal DeviceAccessPointItemTIOConfigData IOConfigData
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
        internal UseableModulesTModuleItemRef[] UseableModules
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
        internal ARVendorBlockRequestT[] ARVendorBlock
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
        internal BuiltInSubmoduleItemT[] VirtualSubmoduleList
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
        internal DeviceAccessPointItemTSystemDefinedSubmoduleList SystemDefinedSubmoduleList
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
        internal GraphicsReferenceTGraphicItemRef[] Graphics
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
        internal DeviceAccessPointItemTAssetManagement AssetManagement
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
        internal ApplicationRelationsObsoleteT ApplicationRelations
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
        internal SystemRedundancyT SystemRedundancy
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
        internal UseableSubmodulesTSubmoduleItemRef[] UseableSubmodules
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
        internal SlotListTSlotItem[] SlotList
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
        internal SlotGroupsTSlotGroup[] SlotGroups
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
        internal DeviceAccessPointItemTFieldbusIntegrationSlots FieldbusIntegrationSlots
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
        internal string ModuleIdentNumber
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
        internal string PNIO_Version
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
        internal string PhysicalSlots
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
        internal ushort MinDeviceInterval
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
        internal string ImplementationType
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
        internal string DNS_CompatibleName
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
        internal string AllowedInSlots
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
        internal string FixedInSlots
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
        internal ushort ObjectUUID_LocalIndex
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
        internal string RequiredSchemaVersion
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
        internal bool MultipleWriteSupported
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
        internal bool IOXS_Required
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
        internal string AddressAssignment
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
        internal string PhysicalSubslots
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
        internal ushort RemoteApplicationTimeout
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
        internal uint MaxSupportedRecordSize
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
        internal uint PowerOnToCommReady
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
        internal bool ParameterizationSpeedupSupported
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
        internal bool NameOfStationNotTransferable
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
        internal bool SharedDeviceSupported
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
        internal bool SharedInputSupported
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
        internal bool DeviceAccessSupported
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
        internal byte NumberOfDeviceAccessAR
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
        internal bool NumberOfDeviceAccessARSpecified
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
        internal byte NumberOfImplicitAR
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
        internal string WebServer
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
        internal bool AutoConfigurationSupported
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
        internal bool CIR_Supported
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
        internal bool PrmBeginPrmEndSequenceSupported
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
        internal bool LLDP_NoD_Supported
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
        internal string ResetToFactoryModes
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
        internal bool IO_SupervisorSupported
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
        internal bool CheckDeviceID_Allowed
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
        internal bool PROFIenergyASE_Supported
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
        internal bool AdaptsRealIdentification
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
        internal uint NumberOfSubmodules
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
        internal bool NumberOfSubmodulesSpecified
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
    internal partial class CertificationInfoT
    {

        private string conformanceClassField;

        private string applicationClassField;

        private string netloadClassField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal string ConformanceClass
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
        internal string ApplicationClass
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
        internal string NetloadClass
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
    internal partial class DeviceAccessPointItemTIOConfigData
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

        internal DeviceAccessPointItemTIOConfigData()
        {
            this.applicationLengthIncludesIOxSField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal ushort MaxInputLength
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
        internal ushort MaxOutputLength
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
        internal ushort MaxDataLength
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
        internal bool MaxDataLengthSpecified
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
        internal bool ApplicationLengthIncludesIOxS
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
        internal ushort MaxApplicationInputLength
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
        internal bool MaxApplicationInputLengthSpecified
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
        internal ushort MaxApplicationOutputLength
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
        internal bool MaxApplicationOutputLengthSpecified
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
        internal ushort MaxApplicationDataLength
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
        internal bool MaxApplicationDataLengthSpecified
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
    internal partial class UseableModulesTModuleItemRef
    {

        private string moduleItemTargetField;

        private string allowedInSlotsField;

        private string usedInSlotsField;

        private string fixedInSlotsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        internal string ModuleItemTarget
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
        internal string AllowedInSlots
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
        internal string UsedInSlots
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
        internal string FixedInSlots
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
    internal partial class ARVendorBlockRequestT
    {

        private object[] itemsField;

        private MenuItemT[] menuListField;

        private uint lengthField;

        private uint aPIField;

        private ushort aPStructureIdentifierField;

        internal ARVendorBlockRequestT()
        {
            this.aPIField = ((uint)(0));
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Const", typeof(RecordDataConstT))]
        [System.Xml.Serialization.XmlElementAttribute("Ref", typeof(RecordDataRefT))]
        internal object[] Items
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
        internal MenuItemT[] MenuList
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
        internal uint Length
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
        internal uint API
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
        internal ushort APStructureIdentifier
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
    internal partial class DeviceAccessPointItemTSystemDefinedSubmoduleList
    {

        private InterfaceSubmoduleItemT interfaceSubmoduleItemField;

        private BuiltInPortSubmoduleItemT[] portSubmoduleItemField;

        /// <remarks/>
        internal InterfaceSubmoduleItemT InterfaceSubmoduleItem
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
        internal BuiltInPortSubmoduleItemT[] PortSubmoduleItem
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
    internal partial class DeviceAccessPointItemTAssetManagement
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.profibus.com/GSDML/2003/11/DeviceProfile")]
    internal partial class SlotListTSlotItem
    {

        private ushort slotNumberField;

        private string textIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal ushort SlotNumber
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
        internal string TextId
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
    internal partial class SlotGroupsTSlotGroup
    {

        private ExternalTextRefT nameField;

        private ExternalTextRefT infoTextField;

        private string slotListField;

        /// <remarks/>
        internal ExternalTextRefT Name
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
        internal ExternalTextRefT InfoText
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
        internal string SlotList
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
    internal partial class DeviceAccessPointItemTFieldbusIntegrationSlots
    {

        private ushort maxSupportedField;

        private string rangeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal ushort MaxSupported
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
        internal string Range
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
    internal partial class ApplicationProcessT
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
        internal DeviceAccessPointItemT[] DeviceAccessPointList
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
        internal ModuleItemT[] ModuleList
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
        internal ObjectT[] SubmoduleList
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
        internal ValueItemT[] ValueList
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
        internal object[] ChannelDiagList
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
        internal object[] ChannelProcessAlarmList
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
        internal object[] UnitDiagTypeList
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
        internal LogBookEntryItemT[] LogBookEntryList
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
        internal GraphicItemT[] GraphicsList
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
        internal CategoryItemT[] CategoryList
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
        internal ApplicationProcessTExternalTextList ExternalTextList
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
    internal partial class ApplicationProcessTExternalTextList
    {

        private ExternalTextT[] primaryLanguageField;

        private LanguageT[] languageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Text", IsNullable = false)]
        internal ExternalTextT[] PrimaryLanguage
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
        internal LanguageT[] Language
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
    internal partial class DeviceFunctionT
    {

        private FamilyT familyField;

        /// <remarks/>
        internal FamilyT Family
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
    internal partial class DeviceIdentityT
    {

        private ExternalTextRefT infoTextField;

        private TokenParameterT vendorNameField;

        private string vendorIDField;

        private string deviceIDField;

        /// <remarks/>
        internal ExternalTextRefT InfoText
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
        internal TokenParameterT VendorName
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
        internal string VendorID
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
        internal string DeviceID
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
    internal partial class ProfileBodyT
    {

        private DeviceIdentityT deviceIdentityField;

        private DeviceFunctionT deviceFunctionField;

        private ApplicationProcessT applicationProcessField;

        /// <remarks/>
        internal DeviceIdentityT DeviceIdentity
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
        internal DeviceFunctionT DeviceFunction
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
        internal ApplicationProcessT ApplicationProcess
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
    internal partial class TransformsType
    {

        private TransformType[] transformField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Transform")]
        internal TransformType[] Transform
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
