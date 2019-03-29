# GSD2AML Rules

## Tables of Content

1. [Structure](#structure)
2. [References](#references)
3. [Reference Types](#reference_types)
4. [Special Reference Types](#special_reference_types)

## <a name="structure"></a>Structure

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

## <a name="references"></a>References

### <a name="references-normal_references"></a>Normal Reference

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
    <Reference Ref="$1" Type="InlineRef">
        <SubslotItem SubslotNumber="" />
    </Reference>
</SubslotItem>
```

Every reference within the replacement element shall have a corresponding reference element. This element must have the attribute `Ref=""` with the identifier. The different [types](#reference_types) will be explained later. The content of the reference shall be a is the location of the referenced value. The inmost element of a reference may have one or none attributes. If the attribute exists, its value will be the return value. If it does not exists, the value of the inmost tag will be used.

### <a name="references-true_references"></a>True Reference

You may have noticed that the example above never resolved the GSD attribute TextId of the "SubslotItem" element. This is because the TextId attribute in itself is also a reference within the GSD file and as such must be handled differently. To differentiate this case from a normal reference, it shall be named "true reference".

A true reference within an GSD file will always reference another element with a "List", that has the attribute `ID` (or alternativly `TextId`).

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
    <Reference Ref="$1" Type="SingleTextRef" Internal="true">
        <SubslotItem TextId="" />
    </Reference>
    <Reference Ref="$2" Type="InlineRef">
        <SubslotItem SubslotNumber="" />
    </Reference>
</SubslotItem>
```

The type `SingleTextRef` will tell the converter to search under `ExternalTextList/PrimaryLanguage`. The content of a true reference is the location of the corresponding id.

### <a name="references-internal"></a>Internal

You may have noticed the use of the reference attribute `Internal` in the examples above. This attribute will take a boolean value (`true` or `false`) and can be used for convenience purposes. If `Internal` is set to true, it will limit the scope of the reference to only the GSD rule element (in this case `<SubslotItem>`). If the value can not be found within this element `Internal` has to be set to `false` and the entire XML tree, beginning from `<ISO15745>` has to be given.

If the reference value is conveniently not a true reference and also an attribute on the rule element, [`Type="InlineRef"`](#reference_types-inlineref) can be used.

## <a name="reference_types"></a>Reference Types

This section will list the different reference types and their uses.

### <a name="reference_types-singletextref"></a>SingleTextRef

A `SingleTextRef` is a true reference. Within the GSD it will reference an element within `<ExternalTextList>`. As the name suggest it will only return a single text. It will only over use the `<PrimaryLanguage>`. The location of the reference __id__ used in the GSD will be given as content of the reference.


### <a name="reference_types-graphicref"></a>GraphicRef

A `GraphicRef` is a true reference. Within the GSD it will reference an element within `GraphicsList`. The location of the reference __id__ used in the GSD will be given as content of the reference.

### <a name="reference_types-directref"></a>DirectRef

A `DirectRef` is __not__ a true reference. It will directly use the value of the referenced location. 

### <a name="reference_types-inlineref"></a>InlineRef

An `InlineRef` is __not__ a true reference and a derivative of a [`DirectRef`](#reference_types-directref). It signals that that referenced value is the value of an attribute of the rule element.

## <a name="special_reference_types></a>Special Reference Types

There are several special reference types for values that cannot be directly read from the GSD file.

### <a name="special_reference_types"></a>GSDRef

`GSDRef` returns a relative path to the original GSD file.