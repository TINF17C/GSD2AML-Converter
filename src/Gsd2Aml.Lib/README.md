# Gsd2Aml.Lib

Welcome to the Gsd2Aml.Lib! This library was developed as a student project by (in alphabetical order)
1. Nico Dietz
2. Steffen Gerdes
3. Constantin Ruhdorfer
4. Jonas Komarek
5. Phuc Quang Vu
6. Michael Weidmann

at [Cooperate State University Stuttgart](https://www.dhbw-stuttgart.de/home/).
This project is distributed via:
1. [GitHub](https://github.com/TINF17C/GSD2AML-Converter)
2. [NuGet](https://www.nuget.org/packages/Gsd2Aml.Lib)

We can be found as a [GitHub Team](https://github.com/orgs/TINF17C/teams/gsd2aml).

## About this project

This library converts a Profinet (PN-)GSD file to AutomationML.
The library can either
1. return a string containing the AutomatonML content.
2. convert the GSD file to an .aml file and package that, including all its dependencies, into an .amlx package. This process uses the [AML.Engine](https://www.nuget.org/packages/Aml.Engine).

## Contributing to this project

Contributions are always welcome!
If you want to contribute feel free to fork this repo and later perform a pull request. 

## File structure

The relevant files and folders are listed here.

### Logging/
Contains the logging service.

### Models/
Contains the classes representing AML and GSD.
Also contains the used XSD files.

### Properties/
Contains the assembly info.

### Compressor.cs
Contains all the logic that is required to:
1. Create a temporary folder
2. Find files and copy them to this folder
3. Uses the AML.Engine to build the .amlx package

### Converter.cs
Contains all the logic that traverses the GSD file and uses the rulesset file to translate the GSD file to AML.

### Util.cs
Contains the utility functionality.

### gsd2aml.xml
This is the rulesset file.
Please have a look below.

## GSD2AML Rules

The rules for conversion are written in XML and are listed here.

### Tables of Content

1. [Structure](#structure)
2. [References](#references)
3. [Reference Types](#reference_types)
4. [GUID](#guid)
5. [The Rule Element](#rule_element)

### <a name="structure"></a>Structure

This section will explain the structure of a gsd2aml rulesset file.

The gsd2aml file will consist of one, and only one, element, the `<Body>`. Each seperate rule shall be direct child of this element.

A rule must start with the GSD element, which is to be replaced. It must have a child `<Replacement>` describing the corresponding XML-structure of the AML replacement.

```xml
<ProfileBody>
    <Replacement>
        <SystemUnitClassLib Name="ComponentSystemUnitClassLib">
            <Version>1.0.0</Version>
        </SystemUnitClassLib>
    </Replacement>
</ProfileBody>
```

Additionally a rule can also have any number of `<Reference>` childs. References will be explained in the following section.

### <a name="references"></a>References

#### <a name="references-normal_references"></a>Normal Reference

It may not be possible to replace a GSD element with a static replacements. Let's look at this example:

```xml
<SubslotItem SubslotNumber="32768" TextId="TOK_Subslot_8000" />
```

This element has a attribute "SubslotNumber". In order to transform this element to AML the attribute "SubslotNumber" should be converted into an `Attribute`, `<Value>` pair.

```xml
<ExternalInterface Name="" ID="">
    <Attribute Name="SubslotNumber" AttributeDataType="xs:integer">
        <Value></Value>
    </Attribute>
</ExternalInterface>
```

Unfortunately the converter itself cannot figure out where this information is located. A referece, signaled by a `$` followed by an identifier like `$1`, is necessary.

The conversion rule for "SubslotItem" may look like this:

```xml
<SubslotItem>
    <Replacement>
        <ExternalInterface Name="" ID="">
            <Attribute Name="SubslotNumber" AttriubteDataType="xs:integer">
                <Value>$1<Value>
            </Attribute>
        </ExternalInterface>
    </Replacement>
    <Reference Ref="$1">
        <ISO15745Profile.ProfileBody.ApplicationProcess.DeviceAccessPointList.DeviceAccessPointItem.SlotList.SlotItem SubslotNumber="" />
    </Reference>
</SubslotItem>
```

Every reference within the replacement element shall have a corresponding reference element. This element must have the attribute `Ref=""` with the identifier. There are different [types](#reference_types) of references. These will be explained later. The content of the reference shall be a the location of the referenced value. A reference only has one child. The child is the full qualified path to the referenced element in a point sepearted list without whitespace.

The element shall have one attribute, which shall be the same attribute that is being referenced. If the attribute exists, its value will be the return value.

#### <a name="references-true_references"></a>True Reference

You may have noticed that the example above never resolved the GSD attribute TextId of the "SubslotItem" element. This is because the TextId attribute in itself is also a reference within the GSD file and as such must be handled differently. To differentiate this case from a normal reference, it shall be named "true reference".

A true reference within an GSD file will always reference another element within a "List", that has the attribute `ID` or other identifying attribute like `TextId`.

These references must be handled differently by the GSD2AML Converter. The converter will know of the different "reference lists" (such as `ExternalTextList`) and their location within the GSD. The converter merely needs to know which list to look in and the corresponding id. Therefore each list will receive its own "type" which can be used as an attribute of the reference element. The other way around, this means that the converter __cannot__ handle true references of lists that the converter does not know.

 Consider the example from above. `TextId=TOK_Subslot_8000` signifies that this attribute references an element within a text list with the id `TOK_Subslot_8000`.

```xml
<SubslotItem>
    <Replacement>
        <ExternalInterface Name="$1" ID="GUID" RefBaseClassPath="physicalEndPoint/SubSlot">
            <Attribute Name="SubslotNumber" AttributeDataType="xs:integer">
                <Value>$2</Value>
            </Attribute>
        </ExternalInterface>
    </Replacement>
    <Reference Ref="$1" Type="TextRef">
        <ISO15745Profile.ProfileBody.ApplicationProcess.DeviceAccessPointList.DeviceAccessPointItem.SlotList.SlotItem TextId="" />
    </Reference>
    <Reference Ref="$2">
        <ISO15745Profile.ProfileBody.ApplicationProcess.DeviceAccessPointList.DeviceAccessPointItem.SlotList.SlotItem SubslotNumber="" />
    </Reference>
</SubslotItem>
```

The type `TextRef` will tell the converter to search under `ExternalTextList/PrimaryLanguage`. The content of a true reference is the location of the corresponding id.

Other languages will be ignored.

### <a name="reference_types"></a>Reference Types

This section will list the different reference types and their uses.

#### <a name="reference_types-Normal-Ref></a>Normal Ref

No type is specified. The refernced value will be used.

#### <a name="reference_types-TextRef"></a>TextRef

A `TextRef` is a true reference. Within the GSD it will reference an element within `<ExternalTextList>`. As the name suggest it will only return a single text. It will only over use the `<PrimaryLanguage>`. The location of the reference __id__ used in the GSD will be given as content of the reference.


#### <a name="reference_types-graphicref"></a>GraphicRef

A `GraphicRef` is a true reference. Within the GSD it will reference an element within `GraphicsList`. The location of the reference __id__ used in the GSD will be given as content of the reference.

#### <a name="special_reference_types"></a>RelGsdFilePath

`RelGsdFilePath` returns a relative path to the original GSD file.

### <a name="guid"></a>GUID

Every time the converters reads the string `GUID`, it will be replaced with a real GUID.

### <a name="rule_element"></a> The Rule Element

In order to maintain modularity while also providing a way to define the structure of the result aml in terms of parent-child relationships, a `<Rule></Rule>` element is introduced.

The content of the `<Rule></Rule>` tag shall be a full a string consisting of the relative path from the parent rule element to the GSD element, which should be placed here.

That path shall a rule of its own and a child of the `<Body>` element.

Example:

```xml
<InternalElement CAEXObject.Name="LogicalInterface" CAEXObject.ID="GUID">
    <SystemUnitClassType.InternalElement>
    <Rule>
ProfileBody.ApplicationProcess.DeviceAccessPointList.DeviceAccessPointItem.SystemDefinedSubmoduleList.InterfaceSubmoduleItem
    </Rule>
    </SystemUnitClassType.InternalElement>
</InternalElement>

  <ProfileBody.ApplicationProcess.DeviceAccessPointList.DeviceAccessPointItem.SystemDefinedSubmoduleList.InterfaceSubmoduleItem>
  ...
</ProfileBody.ApplicationProcess.DeviceAccessPointList.DeviceAccessPointItem.SystemDefinedSubmoduleList.InterfaceSubmoduleItem>
```