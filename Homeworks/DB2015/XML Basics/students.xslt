<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <body>
        <table style="border:2px solid #24343A; border-radius: 4px;">
          <tr bgcolor="#4488A5" style="color:#ffffff; text-align:center;">
            <xsl:for-each select="students/student[1]/*">
              <th>
                <xsl:value-of select ="local-name()"/>
              </th>
            </xsl:for-each>
          </tr>
          <xsl:for-each select="students/student">
            <tr bgcolor="#8DC1D7" style="color:#21323B;">
              <xsl:for-each select="*">
                <td>
                  <xsl:value-of select="text()"/>
                </td>
                </xsl:for-each>
            </tr>
            <tr>
              <td>
                <table style="border:2px solid #24343A; border-radius: 4px;">
                  <tr bgcolor="#4488A5" style="color:#ffffff; text-align:center;">
                    <xsl:for-each select="exams/exam[1]/*">
                      <th>

                          <xsl:value-of select ="local-name()"/>

                      </th>
                    </xsl:for-each>
                    <tr bgcolor="#4488A5" style="color:#ffffff; text-align:center;">
                      <xsl:for-each select="exams/exam">
                        <tr bgcolor="#4488A5" style="color:#ffffff; text-align:center;">
                          <xsl:for-each select="*">
                            <td>
                              <xsl:value-of select="text()"/>
                            </td>
                          </xsl:for-each>
                        </tr>
                      </xsl:for-each>
                    </tr>
                  </tr>
                </table>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>