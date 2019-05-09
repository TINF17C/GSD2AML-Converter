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
  <xsl:key name="doc-search" match="wix:Component[contains(wix:File/@Source, '.Lib.xml')]|wix:Component[contains(wix:File/@Source, 'AML.Engine.xml')]|wix:Component[contains(wix:File/@Source, 'NLog.xml')]" use="@Id"/>

  <!-- Override copy (do nothing) for elements with this Id, so they are omitted from the output. -->
  <xsl:template match="wix:Component[key('pdb-search', @Id)]" />
  <xsl:template match="wix:ComponentRef[key('pdb-search', @Id)]" />
  <xsl:template match="wix:Component[key('doc-search', @Id)]" />
  <xsl:template match="wix:ComponentRef[key('doc-search', @Id)]" />

</xsl:transform>