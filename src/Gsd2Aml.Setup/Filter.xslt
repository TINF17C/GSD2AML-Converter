<?xml version="1.0" ?>
<xsl:transform version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:wix="http://schemas.microsoft.com/wix/2006/wi"
    exclude-result-prefixes="wix">

  <xsl:output method="xml" indent="yes"/>
  
  <!-- By default, copy all attributes and elements to the output. -->
  <xsl:template match="@*|*">
    <xsl:copy>
      <xsl:apply-templates select="@*" />
      <xsl:apply-templates select="*" />
    </xsl:copy>
  </xsl:template>

  <xsl:key name="pdb-search" match="wix:Component[contains(wix:File/@Source, '.pdb')]" use="@Id"/>
  <xsl:key name="doc-search" match="wix:Component[contains(wix:File/@Source, '.Lib.xml')]" use="@Id"/>

  <!-- Override copy (do nothing) for elements with this Id, so they are omitted from the output. -->
  <xsl:template match="wix:Component[key('pdb-search', @Id)]" />
  <xsl:template match="wix:ComponentRef[key('pdb-search', @Id)]" />
  <xsl:template match="wix:Component[key('doc-search', @Id)]" />
  <xsl:template match="wix:ComponentRef[key('doc-search', @Id)]" />
  
  <xsl:template match="wix:File[@Id='Gsd2Aml.Gui.exe']">
    <xsl:copy>
      <xsl:variable name="leadingSpace" select="preceding-sibling::text()[1]" />
      <xsl:apply-templates select="@*"/>
       <!--Add linebreak and indentation, as requested in the comments--> 
      <xsl:value-of select="concat($leadingSpace, '  ')" />
      <Shortcut Id="{@Id}" Name="GSD2AML Converter" Icon="Gsd2Aml.Gui.exe" IconIndex="0" WorkingDirectory="INSTALLFOLDER" Advertise="yes" Directory="ProgramMenuFolder" xmlns="http://schemas.microsoft.com/wix/2006/wi">
        <Icon Id="Gsd2Aml.Gui.exe" SourceFile="$(var.SourceDir)\Gsd2Aml.Gui.exe" xmlns="http://schemas.microsoft.com/wix/2006/wi"/>
      </Shortcut>
       <!--Linebreak and indentation--> 
      <xsl:value-of select="$leadingSpace"/>
    </xsl:copy>
  </xsl:template>

</xsl:transform>