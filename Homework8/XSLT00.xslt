<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="xml" indent="yes"/>

  <xsl:template match="/">

    <html>
      
      <head>
        <title>
          OrderList
        </title>
      </head>

      <body>
        <ul>
          <xsl:for-each select="ArrayOfOrder/Order">
            <br/>
            <li>
              <h2>Client:</h2>
              <xsl:value-of select="Client"/>
            </li>
            <li>
              <h2>Good:</h2>
              <xsl:value-of select="Good"/>
            </li>
            <li>
              <h2>Price:</h2>
              <xsl:value-of select="Price"/>
            </li>
            <li>
              <h2>Count:</h2>
              <xsl:value-of select="Num"/>
            </li>
            <li>
              <h2>ID:</h2>
              <xsl:value-of select="ID"/>
            </li>
            <br/>
          </xsl:for-each>
        </ul>
      </body>
      
    </html>
    
  </xsl:template>
  
</xsl:stylesheet>