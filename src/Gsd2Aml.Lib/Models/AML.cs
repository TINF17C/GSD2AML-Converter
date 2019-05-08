using System;
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
    internal partial class CAEXFile : CAEXBasicObject
    {

        private CAEXFileExternalReference[] externalReferenceField;

        private CAEXFileInstanceHierarchy[] instanceHierarchyField;

        private CAEXFileInterfaceClassLib[] interfaceClassLibField;

        private CAEXFileRoleClassLib[] roleClassLibField;

        private CAEXFileSystemUnitClassLib[] systemUnitClassLibField;

        private string fileNameField;

        private string schemaVersionField;

        internal CAEXFile()
        {
            this.schemaVersionField = "2.15";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExternalReference")]
        internal CAEXFileExternalReference[] ExternalReference
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
        internal CAEXFileInstanceHierarchy[] InstanceHierarchy
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
        internal CAEXFileInterfaceClassLib[] InterfaceClassLib
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
        internal CAEXFileRoleClassLib[] RoleClassLib
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
        internal CAEXFileSystemUnitClassLib[] SystemUnitClassLib
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
        internal string FileName
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
        internal string SchemaVersion
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
    internal partial class CAEXFileExternalReference : CAEXBasicObject
    {

        private string pathField;

        private string aliasField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal string Path
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
        internal string Alias
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
    internal partial class CAEXBasicObject
    {

        private CAEXBasicObjectDescription descriptionField;

        private CAEXBasicObjectVersion versionField;

        private CAEXBasicObjectRevision[] revisionField;

        private CAEXBasicObjectCopyright copyrightField;

        private object[] additionalInformationField;

        private ChangeMode changeModeField;

        internal CAEXBasicObject()
        {
            this.changeModeField = ChangeMode.state;
        }

        /// <remarks/>
        internal CAEXBasicObjectDescription Description
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
        internal CAEXBasicObjectVersion Version
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
        internal CAEXBasicObjectRevision[] Revision
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
        internal CAEXBasicObjectCopyright Copyright
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
        internal object[] AdditionalInformation
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
        internal ChangeMode ChangeMode
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
    internal partial class CAEXBasicObjectDescription
    {

        private ChangeMode changeModeField;

        private string valueField;

        internal CAEXBasicObjectDescription()
        {
            this.changeModeField = ChangeMode.state;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ChangeMode.state)]
        internal ChangeMode ChangeMode
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
    internal enum ChangeMode
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
    internal partial class CAEXBasicObjectVersion
    {

        private ChangeMode changeModeField;

        private string valueField;

        internal CAEXBasicObjectVersion()
        {
            this.changeModeField = ChangeMode.state;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ChangeMode.state)]
        internal ChangeMode ChangeMode
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    internal partial class CAEXBasicObjectRevision : CAEXBasicObject
    {

        private System.DateTime revisionDateField;

        private string oldVersionField;

        private string newVersionField;

        private string authorNameField;

        private string commentField;

        /// <remarks/>
        internal System.DateTime RevisionDate
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
        internal string OldVersion
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
        internal string NewVersion
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
        internal string AuthorName
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
        internal string Comment
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
    internal partial class CAEXBasicObjectCopyright
    {

        private ChangeMode changeModeField;

        private string valueField;

        internal CAEXBasicObjectCopyright()
        {
            this.changeModeField = ChangeMode.state;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ChangeMode.state)]
        internal ChangeMode ChangeMode
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
    internal partial class MappingType : CAEXBasicObject
    {

        private MappingTypeAttributeNameMapping[] attributeNameMappingField;

        private MappingTypeInterfaceNameMapping[] interfaceNameMappingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttributeNameMapping")]
        internal MappingTypeAttributeNameMapping[] AttributeNameMapping
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
        internal MappingTypeInterfaceNameMapping[] InterfaceNameMapping
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
    internal partial class MappingTypeAttributeNameMapping : CAEXBasicObject
    {

        private string systemUnitAttributeNameField;

        private string roleAttributeNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal string SystemUnitAttributeName
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
        internal string RoleAttributeName
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
    internal partial class MappingTypeInterfaceNameMapping : CAEXBasicObject
    {

        private string systemUnitInterfaceNameField;

        private string roleInterfaceNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal string SystemUnitInterfaceName
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
        internal string RoleInterfaceName
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
    internal partial class AttributeValueRequirementType : CAEXBasicObject
    {

        private object itemField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NominalScaledType", typeof(AttributeValueRequirementTypeNominalScaledType))]
        [System.Xml.Serialization.XmlElementAttribute("OrdinalScaledType", typeof(AttributeValueRequirementTypeOrdinalScaledType))]
        [System.Xml.Serialization.XmlElementAttribute("UnknownType", typeof(AttributeValueRequirementTypeUnknownType))]
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
        internal string Name
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
    internal partial class AttributeValueRequirementTypeNominalScaledType
    {

        private object[] requiredValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequiredValue")]
        internal object[] RequiredValue
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
    internal partial class AttributeValueRequirementTypeOrdinalScaledType
    {

        private object requiredMaxValueField;

        private object requiredValueField;

        private object requiredMinValueField;

        /// <remarks/>
        internal object RequiredMaxValue
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
        internal object RequiredValue
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
        internal object RequiredMinValue
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
    internal partial class AttributeValueRequirementTypeUnknownType
    {

        private string requirementsField;

        /// <remarks/>
        internal string Requirements
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
    internal partial class CAEXObject : CAEXBasicObject
    {

        private string idField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        internal string Name
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
    internal partial class SystemUnitClassType : CAEXObject
    {

        private AttributeType[] attributeField;

        private InterfaceClassType[] externalInterfaceField;

        private InternalElementType[] internalElementField;

        private SystemUnitClassTypeSupportedRoleClass[] supportedRoleClassField;

        private SystemUnitClassTypeInternalLink[] internalLinkField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attribute")]
        internal AttributeType[] Attribute
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
        internal InterfaceClassType[] ExternalInterface
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
        internal InternalElementType[] InternalElement
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
        internal SystemUnitClassTypeSupportedRoleClass[] SupportedRoleClass
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
        internal SystemUnitClassTypeInternalLink[] InternalLink
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
    internal partial class AttributeType : CAEXObject
    {

        private object defaultValueField;

        private object valueField;

        private AttributeTypeRefSemantic[] refSemanticField;

        private AttributeValueRequirementType[] constraintField;

        private AttributeType[] attributeField;

        private string unitField;

        private string attributeDataTypeField;

        /// <remarks/>
        internal object DefaultValue
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
        internal object Value
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
        internal AttributeTypeRefSemantic[] RefSemantic
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
        internal AttributeValueRequirementType[] Constraint
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
        internal AttributeType[] Attribute
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
        internal string Unit
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
        internal string AttributeDataType
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
    internal partial class AttributeTypeRefSemantic : CAEXBasicObject
    {

        private string correspondingAttributePathField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal string CorrespondingAttributePath
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
    internal partial class InterfaceClassType : CAEXObject
    {

        private AttributeType[] attributeField;

        private string refBaseClassPathField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attribute")]
        internal AttributeType[] Attribute
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
        internal string RefBaseClassPath
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
    internal partial class InterfaceFamilyType : InterfaceClassType
    {

        private InterfaceFamilyType[] interfaceClassField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InterfaceClass")]
        internal InterfaceFamilyType[] InterfaceClass
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
    internal partial class InternalElementType : SystemUnitClassType
    {

        private InternalElementTypeRoleRequirements roleRequirementsField;

        private MappingType mappingObjectField;

        private string refBaseSystemUnitPathField;

        /// <remarks/>
        internal InternalElementTypeRoleRequirements RoleRequirements
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
        internal MappingType MappingObject
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
        internal string RefBaseSystemUnitPath
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
    internal partial class InternalElementTypeRoleRequirements : CAEXBasicObject
    {

        private AttributeType[] attributeField;

        private InterfaceClassType[] externalInterfaceField;

        private string refBaseRoleClassPathField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attribute")]
        internal AttributeType[] Attribute
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
        internal InterfaceClassType[] ExternalInterface
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
        internal string RefBaseRoleClassPath
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
    internal partial class SystemUnitClassTypeSupportedRoleClass : CAEXBasicObject
    {

        private MappingType mappingObjectField;

        private string refRoleClassPathField;

        /// <remarks/>
        internal MappingType MappingObject
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
        internal string RefRoleClassPath
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
    internal partial class SystemUnitClassTypeInternalLink : CAEXObject
    {

        private string refPartnerSideAField;

        private string refPartnerSideBField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        internal string RefPartnerSideA
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
        internal string RefPartnerSideB
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
    internal partial class SystemUnitFamilyType : SystemUnitClassType
    {

        private SystemUnitFamilyType[] systemUnitClassField;

        private string refBaseClassPathField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SystemUnitClass")]
        internal SystemUnitFamilyType[] SystemUnitClass
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
        internal string RefBaseClassPath
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
    internal partial class RoleClassType : CAEXObject
    {

        private AttributeType[] attributeField;

        private RoleClassTypeExternalInterface[] externalInterfaceField;

        private string refBaseClassPathField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attribute")]
        internal AttributeType[] Attribute
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
        internal RoleClassTypeExternalInterface[] ExternalInterface
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
        internal string RefBaseClassPath
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
    internal partial class RoleClassTypeExternalInterface : InterfaceClassType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class RoleFamilyType : RoleClassType
    {

        private RoleFamilyType[] roleClassField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RoleClass")]
        internal RoleFamilyType[] RoleClass
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
    internal partial class CAEXFileInstanceHierarchy : CAEXObject
    {

        private InternalElementType[] internalElementField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InternalElement")]
        internal InternalElementType[] InternalElement
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
    internal partial class CAEXFileInterfaceClassLib : CAEXObject
    {

        private InterfaceFamilyType[] interfaceClassField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InterfaceClass")]
        internal InterfaceFamilyType[] InterfaceClass
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
    internal partial class CAEXFileRoleClassLib : CAEXObject
    {

        private RoleFamilyType[] roleClassField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RoleClass")]
        internal RoleFamilyType[] RoleClass
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
    internal partial class CAEXFileSystemUnitClassLib : CAEXObject
    {

        private SystemUnitFamilyType[] systemUnitClassField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SystemUnitClass")]
        internal SystemUnitFamilyType[] SystemUnitClass 
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
    
    internal class WriterHeader
    {
        internal string WriterName { get; set; }

        internal string WriterID { get; set; }

        internal string WriterVendor { get; set; }

        internal string WriterVersion { get; set; }

        internal string WriterRelease { get; set; }

        internal string LastWritingDateTime { get; set; }

        internal string WriterProjectTitle { get; set; }

        internal string WriterProjectID { get; set; }
    }

    internal class Wrapper
    {
        // Default search property
        internal CAEXFile CAEXFile { get; set; }

        // First rule
        internal WriterHeader WriterHeader { get; set; }

        // Second rule
        internal CAEXFileSystemUnitClassLib SystemUnitClassLib { get; set; }

        // Third rule
        internal SystemUnitFamilyType SystemUnitClass { get; set; }

        internal SystemUnitClassType SystemUnitClassType { get; set; }

        internal SystemUnitClassTypeSupportedRoleClass SupportedRoleClass { get; set; }

        internal InternalElementType InternalElement { get; set; }

        internal AttributeType Attribute { get; set; }

        internal InterfaceClassType ExternalInterface { get; set; }

        // Attributes (ID, Name)
        internal CAEXObject CAEXObject { get; set; }
    }
}
