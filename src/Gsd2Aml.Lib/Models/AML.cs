using System;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace Gsd2Aml.Lib.Models
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class CAEXFile : CAEXBasicObject
    {

        private CAEXFileExternalReference[] externalReferenceField;

        private CAEXFileInstanceHierarchy[] instanceHierarchyField;

        private CAEXFileInterfaceClassLib[] interfaceClassLibField;

        private CAEXFileRoleClassLib[] roleClassLibField;

        private CAEXFileSystemUnitClassLib[] systemUnitClassLibField;

        private string fileNameField;

        private string schemaVersionField;

        public CAEXFile()
        {
            this.schemaVersionField = "2.15";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExternalReference")]
        public CAEXFileExternalReference[] ExternalReference
        {
            get
            {
                return this.externalReferenceField;
            }
            set
            {
                this.externalReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InstanceHierarchy")]
        public CAEXFileInstanceHierarchy[] InstanceHierarchy
        {
            get
            {
                return this.instanceHierarchyField;
            }
            set
            {
                this.instanceHierarchyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InterfaceClassLib")]
        public CAEXFileInterfaceClassLib[] InterfaceClassLib
        {
            get
            {
                return this.interfaceClassLibField;
            }
            set
            {
                this.interfaceClassLibField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RoleClassLib")]
        public CAEXFileRoleClassLib[] RoleClassLib
        {
            get
            {
                return this.roleClassLibField;
            }
            set
            {
                this.roleClassLibField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SystemUnitClassLib")]
        public CAEXFileSystemUnitClassLib[] SystemUnitClassLib
        {
            get
            {
                return this.systemUnitClassLibField;
            }
            set
            {
                this.systemUnitClassLibField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SchemaVersion
        {
            get
            {
                return this.schemaVersionField;
            }
            set
            {
                this.schemaVersionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CAEXFileExternalReference : CAEXBasicObject
    {

        private string pathField;

        private string aliasField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Alias
        {
            get
            {
                return this.aliasField;
            }
            set
            {
                this.aliasField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MappingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttributeValueRequirementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CAEXObject))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SystemUnitClassType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SystemUnitFamilyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InternalElementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RoleClassType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RoleFamilyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttributeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InterfaceClassType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InterfaceFamilyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WriterHeader))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CAEXBasicObject
    {

        private CAEXBasicObjectDescription descriptionField;

        private CAEXBasicObjectVersion versionField;

        private CAEXBasicObjectRevision[] revisionField;

        private CAEXBasicObjectCopyright copyrightField;

        private object[] additionalInformationField;

        private ChangeMode changeModeField;

        public CAEXBasicObject()
        {
            this.changeModeField = ChangeMode.state;
        }

        /// <remarks/>
        public CAEXBasicObjectDescription Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public CAEXBasicObjectVersion Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Revision")]
        public CAEXBasicObjectRevision[] Revision
        {
            get
            {
                return this.revisionField;
            }
            set
            {
                this.revisionField = value;
            }
        }

        /// <remarks/>
        public CAEXBasicObjectCopyright Copyright
        {
            get
            {
                return this.copyrightField;
            }
            set
            {
                this.copyrightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalInformation")]
        public object[] AdditionalInformation
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ChangeMode.state)]
        public ChangeMode ChangeMode
        {
            get
            {
                return this.changeModeField;
            }
            set
            {
                this.changeModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CAEXBasicObjectDescription
    {

        private ChangeMode changeModeField;

        private string valueField;

        public CAEXBasicObjectDescription()
        {
            this.changeModeField = ChangeMode.state;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ChangeMode.state)]
        public ChangeMode ChangeMode
        {
            get
            {
                return this.changeModeField;
            }
            set
            {
                this.changeModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
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
    public enum ChangeMode
    {

        /// <remarks/>
        state,

        /// <remarks/>
        create,

        /// <remarks/>
        delete,

        /// <remarks/>
        change,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CAEXBasicObjectVersion
    {

        private ChangeMode changeModeField;

        private string valueField;

        public CAEXBasicObjectVersion()
        {
            this.changeModeField = ChangeMode.state;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ChangeMode.state)]
        public ChangeMode ChangeMode
        {
            get
            {
                return this.changeModeField;
            }
            set
            {
                this.changeModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CAEXBasicObjectRevision : CAEXBasicObject
    {

        private System.DateTime revisionDateField;

        private string oldVersionField;

        private string newVersionField;

        private string authorNameField;

        private string commentField;

        /// <remarks/>
        public System.DateTime RevisionDate
        {
            get
            {
                return this.revisionDateField;
            }
            set
            {
                this.revisionDateField = value;
            }
        }

        /// <remarks/>
        public string OldVersion
        {
            get
            {
                return this.oldVersionField;
            }
            set
            {
                this.oldVersionField = value;
            }
        }

        /// <remarks/>
        public string NewVersion
        {
            get
            {
                return this.newVersionField;
            }
            set
            {
                this.newVersionField = value;
            }
        }

        /// <remarks/>
        public string AuthorName
        {
            get
            {
                return this.authorNameField;
            }
            set
            {
                this.authorNameField = value;
            }
        }

        /// <remarks/>
        public string Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CAEXBasicObjectCopyright
    {

        private ChangeMode changeModeField;

        private string valueField;

        public CAEXBasicObjectCopyright()
        {
            this.changeModeField = ChangeMode.state;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ChangeMode.state)]
        public ChangeMode ChangeMode
        {
            get
            {
                return this.changeModeField;
            }
            set
            {
                this.changeModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
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
    public partial class MappingType : CAEXBasicObject
    {

        private MappingTypeAttributeNameMapping[] attributeNameMappingField;

        private MappingTypeInterfaceNameMapping[] interfaceNameMappingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttributeNameMapping")]
        public MappingTypeAttributeNameMapping[] AttributeNameMapping
        {
            get
            {
                return this.attributeNameMappingField;
            }
            set
            {
                this.attributeNameMappingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InterfaceNameMapping")]
        public MappingTypeInterfaceNameMapping[] InterfaceNameMapping
        {
            get
            {
                return this.interfaceNameMappingField;
            }
            set
            {
                this.interfaceNameMappingField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MappingTypeAttributeNameMapping : CAEXBasicObject
    {

        private string systemUnitAttributeNameField;

        private string roleAttributeNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SystemUnitAttributeName
        {
            get
            {
                return this.systemUnitAttributeNameField;
            }
            set
            {
                this.systemUnitAttributeNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoleAttributeName
        {
            get
            {
                return this.roleAttributeNameField;
            }
            set
            {
                this.roleAttributeNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MappingTypeInterfaceNameMapping : CAEXBasicObject
    {

        private string systemUnitInterfaceNameField;

        private string roleInterfaceNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SystemUnitInterfaceName
        {
            get
            {
                return this.systemUnitInterfaceNameField;
            }
            set
            {
                this.systemUnitInterfaceNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoleInterfaceName
        {
            get
            {
                return this.roleInterfaceNameField;
            }
            set
            {
                this.roleInterfaceNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AttributeValueRequirementType : CAEXBasicObject
    {

        private object itemField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NominalScaledType", typeof(AttributeValueRequirementTypeNominalScaledType))]
        [System.Xml.Serialization.XmlElementAttribute("OrdinalScaledType", typeof(AttributeValueRequirementTypeOrdinalScaledType))]
        [System.Xml.Serialization.XmlElementAttribute("UnknownType", typeof(AttributeValueRequirementTypeUnknownType))]
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
        public string Name
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttributeValueRequirementTypeNominalScaledType
    {

        private object[] requiredValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequiredValue")]
        public object[] RequiredValue
        {
            get
            {
                return this.requiredValueField;
            }
            set
            {
                this.requiredValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttributeValueRequirementTypeOrdinalScaledType
    {

        private object requiredMaxValueField;

        private object requiredValueField;

        private object requiredMinValueField;

        /// <remarks/>
        public object RequiredMaxValue
        {
            get
            {
                return this.requiredMaxValueField;
            }
            set
            {
                this.requiredMaxValueField = value;
            }
        }

        /// <remarks/>
        public object RequiredValue
        {
            get
            {
                return this.requiredValueField;
            }
            set
            {
                this.requiredValueField = value;
            }
        }

        /// <remarks/>
        public object RequiredMinValue
        {
            get
            {
                return this.requiredMinValueField;
            }
            set
            {
                this.requiredMinValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttributeValueRequirementTypeUnknownType
    {

        private string requirementsField;

        /// <remarks/>
        public string Requirements
        {
            get
            {
                return this.requirementsField;
            }
            set
            {
                this.requirementsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SystemUnitClassType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SystemUnitFamilyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InternalElementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RoleClassType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RoleFamilyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttributeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InterfaceClassType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InterfaceFamilyType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CAEXObject : CAEXBasicObject
    {

        private string idField = Guid.NewGuid().ToString();

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        public string Name
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SystemUnitFamilyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InternalElementType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SystemUnitClassType : CAEXObject
    {

        private AttributeType[] attributeField;

        private InterfaceClassType[] externalInterfaceField;

        private InternalElementType[] internalElementField;

        private SystemUnitClassTypeSupportedRoleClass[] supportedRoleClassField;

        private SystemUnitClassTypeInternalLink[] internalLinkField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attribute")]
        public AttributeType[] Attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExternalInterface")]
        public InterfaceClassType[] ExternalInterface
        {
            get
            {
                return this.externalInterfaceField;
            }
            set
            {
                this.externalInterfaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InternalElement")]
        public InternalElementType[] InternalElement
        {
            get
            {
                return this.internalElementField;
            }
            set
            {
                this.internalElementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupportedRoleClass")]
        public SystemUnitClassTypeSupportedRoleClass[] SupportedRoleClass
        {
            get
            {
                return this.supportedRoleClassField;
            }
            set
            {
                this.supportedRoleClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InternalLink")]
        public SystemUnitClassTypeInternalLink[] InternalLink
        {
            get
            {
                return this.internalLinkField;
            }
            set
            {
                this.internalLinkField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AttributeType : CAEXObject
    {

        private object defaultValueField;

        private object valueField;

        private AttributeTypeRefSemantic[] refSemanticField;

        private AttributeValueRequirementType[] constraintField;

        private AttributeType[] attributeField;

        private string unitField;

        private string attributeDataTypeField;

        /// <remarks/>
        public object DefaultValue
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
        public object Value
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
        [System.Xml.Serialization.XmlElementAttribute("RefSemantic")]
        public AttributeTypeRefSemantic[] RefSemantic
        {
            get
            {
                return this.refSemanticField;
            }
            set
            {
                this.refSemanticField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Constraint")]
        public AttributeValueRequirementType[] Constraint
        {
            get
            {
                return this.constraintField;
            }
            set
            {
                this.constraintField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attribute")]
        public AttributeType[] Attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AttributeDataType
        {
            get
            {
                return this.attributeDataTypeField;
            }
            set
            {
                this.attributeDataTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttributeTypeRefSemantic : CAEXBasicObject
    {

        private string correspondingAttributePathField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CorrespondingAttributePath
        {
            get
            {
                return this.correspondingAttributePathField;
            }
            set
            {
                this.correspondingAttributePathField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InterfaceFamilyType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InterfaceClassType : CAEXObject
    {

        private AttributeType[] attributeField;

        private string refBaseClassPathField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attribute")]
        public AttributeType[] Attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RefBaseClassPath
        {
            get
            {
                return this.refBaseClassPathField;
            }
            set
            {
                this.refBaseClassPathField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InterfaceFamilyType : InterfaceClassType
    {

        private InterfaceFamilyType[] interfaceClassField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InterfaceClass")]
        public InterfaceFamilyType[] InterfaceClass
        {
            get
            {
                return this.interfaceClassField;
            }
            set
            {
                this.interfaceClassField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InternalElementType : SystemUnitClassType
    {

        private InternalElementTypeRoleRequirements roleRequirementsField;

        private MappingType mappingObjectField;

        private string refBaseSystemUnitPathField;

        /// <remarks/>
        public InternalElementTypeRoleRequirements RoleRequirements
        {
            get
            {
                return this.roleRequirementsField;
            }
            set
            {
                this.roleRequirementsField = value;
            }
        }

        /// <remarks/>
        public MappingType MappingObject
        {
            get
            {
                return this.mappingObjectField;
            }
            set
            {
                this.mappingObjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RefBaseSystemUnitPath
        {
            get
            {
                return this.refBaseSystemUnitPathField;
            }
            set
            {
                this.refBaseSystemUnitPathField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InternalElementTypeRoleRequirements : CAEXBasicObject
    {

        private AttributeType[] attributeField;

        private InterfaceClassType[] externalInterfaceField;

        private string refBaseRoleClassPathField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attribute")]
        public AttributeType[] Attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExternalInterface")]
        public InterfaceClassType[] ExternalInterface
        {
            get
            {
                return this.externalInterfaceField;
            }
            set
            {
                this.externalInterfaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RefBaseRoleClassPath
        {
            get
            {
                return this.refBaseRoleClassPathField;
            }
            set
            {
                this.refBaseRoleClassPathField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SystemUnitClassTypeSupportedRoleClass : CAEXBasicObject
    {

        private MappingType mappingObjectField;

        private string refRoleClassPathField;

        /// <remarks/>
        public MappingType MappingObject
        {
            get
            {
                return this.mappingObjectField;
            }
            set
            {
                this.mappingObjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RefRoleClassPath
        {
            get
            {
                return this.refRoleClassPathField;
            }
            set
            {
                this.refRoleClassPathField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SystemUnitClassTypeInternalLink : CAEXObject
    {

        private string refPartnerSideAField;

        private string refPartnerSideBField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RefPartnerSideA
        {
            get
            {
                return this.refPartnerSideAField;
            }
            set
            {
                this.refPartnerSideAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RefPartnerSideB
        {
            get
            {
                return this.refPartnerSideBField;
            }
            set
            {
                this.refPartnerSideBField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SystemUnitFamilyType : SystemUnitClassType
    {

        private SystemUnitFamilyType[] systemUnitClassField;

        private string refBaseClassPathField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SystemUnitClass")]
        public SystemUnitFamilyType[] SystemUnitClass
        {
            get
            {
                return this.systemUnitClassField;
            }
            set
            {
                this.systemUnitClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RefBaseClassPath
        {
            get
            {
                return this.refBaseClassPathField;
            }
            set
            {
                this.refBaseClassPathField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RoleFamilyType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RoleClassType : CAEXObject
    {

        private AttributeType[] attributeField;

        private RoleClassTypeExternalInterface[] externalInterfaceField;

        private string refBaseClassPathField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attribute")]
        public AttributeType[] Attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExternalInterface")]
        public RoleClassTypeExternalInterface[] ExternalInterface
        {
            get
            {
                return this.externalInterfaceField;
            }
            set
            {
                this.externalInterfaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RefBaseClassPath
        {
            get
            {
                return this.refBaseClassPathField;
            }
            set
            {
                this.refBaseClassPathField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RoleClassTypeExternalInterface : InterfaceClassType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RoleFamilyType : RoleClassType
    {

        private RoleFamilyType[] roleClassField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RoleClass")]
        public RoleFamilyType[] RoleClass
        {
            get
            {
                return this.roleClassField;
            }
            set
            {
                this.roleClassField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CAEXFileInstanceHierarchy : CAEXObject
    {

        private InternalElementType[] internalElementField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InternalElement")]
        public InternalElementType[] InternalElement
        {
            get
            {
                return this.internalElementField;
            }
            set
            {
                this.internalElementField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CAEXFileInterfaceClassLib : CAEXObject
    {

        private InterfaceFamilyType[] interfaceClassField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InterfaceClass")]
        public InterfaceFamilyType[] InterfaceClass
        {
            get
            {
                return this.interfaceClassField;
            }
            set
            {
                this.interfaceClassField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CAEXFileRoleClassLib : CAEXObject
    {

        private RoleFamilyType[] roleClassField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RoleClass")]
        public RoleFamilyType[] RoleClass
        {
            get
            {
                return this.roleClassField;
            }
            set
            {
                this.roleClassField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CAEXFileSystemUnitClassLib : CAEXObject
    {

        private SystemUnitFamilyType[] systemUnitClassField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SystemUnitClass")]
        public SystemUnitFamilyType[] SystemUnitClass 
        {
            get
            {
                return this.systemUnitClassField;
            }
            set
            {
                this.systemUnitClassField = value;
            }
        }
    }
    
    public class WriterHeader
    {
        public string WriterName { get; set; }

        public string WriterID { get; set; }

        public string WriterVendor { get; set; }

        public string WriterVersion { get; set; }

        public string WriterRelease { get; set; }

        public string LastWritingDateTime { get; set; } = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK");

        public string WriterProjectTitle { get; set; }

        public string WriterProjectID { get; set; }
    }

    public class Wrapper
    {
        // Default search property
        public CAEXFile CAEXFile { get; set; }

        // First rule
        public WriterHeader WriterHeader { get; set; }

        // Second rule
        public CAEXFileSystemUnitClassLib SystemUnitClassLib { get; set; }

        // Third rule
        public SystemUnitFamilyType SystemUnitClass { get; set; }

        public SystemUnitClassType SystemUnitClassType { get; set; }

        public SystemUnitClassTypeSupportedRoleClass SupportedRoleClass { get; set; }

        public InternalElementType InternalElement { get; set; }

        public AttributeType Attribute { get; set; }

        public InterfaceClassType ExternalInterface { get; set; }

        // Attributes (ID, Name)
        public CAEXObject CAEXObject { get; set; }
    }
}
