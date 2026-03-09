Imports System.Windows.Forms.AxHost

Namespace DLAFormfactory

    ''' <summary>
    ''' Dataset for creating templates for the HTML generator in IDEA
    ''' Templates are filled with a default model but can be modified
    ''' </summary>
    Public Class HTMLTemplates
        Protected oSet As DataSet
        Protected oTemplates As DataTable
        Public Const T_NAME As String = "Template_Name"
        Public Const T_HEADER As String = "Template_Header"
        Public Const T_BODY As String = "Template_Body"
        Public Const T_FOOTER As String = "Template_Footer"
        Public Const T_SQL As String = "Template_SQL"
        Public Const T_FILEPATH As String = "File Path"
        ''' <summary>
        ''' Create the entity and create the internal datastructure for the templates
        ''' </summary>
        Sub New()
            Me.oSet = New DataSet("HTMLtemplates")
            Me.oTemplates = New DataTable("templates")
            oSet.Tables.Add(Me.oTemplates)
            Me.oTemplates.Columns.Add(New DataColumn(T_NAME))
            Me.oTemplates.Columns.Add(New DataColumn(T_HEADER))
            Me.oTemplates.Columns.Add(New DataColumn(T_BODY))
            Me.oTemplates.Columns.Add(New DataColumn(T_FOOTER))
            Me.oTemplates.Columns.Add(New DataColumn(T_SQL))
            Me.oTemplates.Columns.Add(New DataColumn(T_FILEPATH))
            Me.oTemplates.Columns.Add(New DataColumn("id"))
        End Sub
        ''' <summary>
        ''' Add a template to the set of templates
        ''' </summary>
        ''' <param name="name">Name of the template</param>
        ''' <param name="header"></param>
        ''' <param name="body"></param>
        ''' <param name="footer"></param>
        ''' <param name="sql">SQL statement for the retrieval of data from the repository</param>
        ''' <returns></returns>
        Function AddTemplate(name As String, header As String, body As String, footer As String, sql As String, Optional path As String = "") As Boolean
            Dim oRow As DataRow
            Try
                oRow = oTemplates.NewRow()
                oRow(T_NAME) = name
                oRow(T_HEADER) = header
                oRow(T_BODY) = body
                oRow(T_FOOTER) = footer
                oRow(T_SQL) = sql
                oRow(T_FILEPATH) = path

                oRow("id") = Guid.NewGuid()
                oTemplates.Rows.Add(oRow)
                oTemplates.AcceptChanges()
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
                Return False
            End Try

            Return True
        End Function
        ''' <summary>
        ''' Get row from the template datatable by template name
        ''' </summary>
        ''' <param name="template"></param>
        ''' <returns></returns>
        Function GetRowByTemplate(template As String) As DataRow
            Dim oRow As DataRow
            Try
                For Each oRow In Me.oTemplates.Rows
                    If template.Contains("#" + oRow(T_NAME).ToString().ToLower() + "#") Then
                        Return oRow
                        Exit For
                    End If
                Next
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return oTemplates.NewRow

        End Function
        ''' <summary>
        ''' Find a templateelement in the template data structure based on the name
        ''' </summary>
        ''' <param name="rowname">name of the template</param>
        ''' <returns>Return is true if the element is found in the collection</returns>
        Function FindRowByName(rowname As String) As Boolean
            Try
                For Each oRow In Me.oTemplates.Rows
                    If oRow(T_NAME).ToString().ToLower() = rowname.ToLower() Then
                        Return True
                        Exit For
                    End If
                Next
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return False

        End Function
        ''' <summary>
        ''' Get the element in the templates based on the name
        ''' </summary>
        ''' <param name="name"></param>
        ''' <returns>the datarow with the content of the template</returns>
        Function GetRowByName(name As String) As DataRow
            Dim oRow As DataRow
            Try
                For Each oRow In Me.oTemplates.Rows
                    If oRow(T_NAME).ToString().ToUpper() = name.ToUpper Then
                        Return oRow
                        Exit For
                    End If
                Next
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return oTemplates.NewRow

        End Function
        ''' <summary>
        ''' Save template definition to a XML file
        ''' </summary>
        ''' <param name="file"></param>
        ''' <returns></returns>
        Function SaveTemplates(file As String) As Boolean
            Try
                If file.Length = 0 Then
                    MsgBox("No filename defined for templates", MsgBoxStyle.OkOnly)
                    Return False
                End If
                DefaultTemplates()
                oSet.WriteXml(file)
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
                Return False
            End Try
            Return True

        End Function
        ''' <summary>
        ''' Define the default templates that can be used as start for your own templates
        ''' </summary>
        ''' <returns></returns>
        Public Function DefaultTemplates() As Boolean
            Try
                If Me.oTemplates.Rows.Count = 0 Then
                    Me.AddTemplate("Page_Template",
                                   "",
                                   "<html><title>IDEA Publisher Template</title><link rel='stylesheet' href=https://www.w3schools.com/w3css/4/w3.css><body>
<div class='w3-top w3-bar w3-khaki w3-wide w3-padding w3-card'>
<a href='index.html' class='w3-bar-item w3-button'><b>IDEA</b>Publisher</a>
<div class='w3-right w3-hide-small'>
<a href='https://data-docent.nl/' class='w3-bar-item w3-button'>Home</a>
<a href='index.html' class='w3-bar-item w3-button'>Sitemap</a>
</div></div>
<!-- Page Start -->
<div id='home' class='w3-content' style='max-width:1564px'>
<div class='w3-display-container w3-content' style='max-width:1500px;'>
<img class='w3-image' src='https://data-docent.nl/images/bannerlaag.png' alt='Architecture' width='100%'>
<div class='w3-display-left w3-margin-top w3-center'><h1 class='w3-xxlarge w3-text-white w3-wide'>
<span class='w3-padding w3-black w3-opacity-min'>
<b>Sparx</b></span>
<span class='w3-hide-small w3-text-light-green'>Enterprise Architect</span>
</h1>
</div>
</div>
<div class='container'>#content#</div></div>
<div class='w3-footer w3-bar w3-khaki w3-wide w3-padding w3-card'>
<img src='https://data-docent.nl/images/interactorylogo.png' height='50px' >Generated by IDEA from Interactory
</div>
</body>
</html>
",
                                   "",
                                   "")
                    Dim blnPdf As Boolean = False
                    Me.AddTemplate("Detail_Package",
                                   "",
                                   "<h1 class='w3-khaki' >#name#</h1><p>#notes#</p>#list_packages_package##list_diagrams_package##list_elements_package#<hr>",
                                   "<footer class=''ftco-footer ftco-bg-dark ftco-section''</footer>",
                                   "select * from t_package where package_id = #id#",
                                    "\package#id#.html")
                    Me.AddTemplate("List_Packages",
                                   "<div class='w3-card-4' ><header class='w3-container w3-khaki'><h1 class='w3-khaki' >Packages</h1></header><div class='w3-container' >",
                                   "<a href=""package#package_id#.html"" >#name#</a>",
                                   "</div></div>",
                                   "select * from t_package order by name")
                    Me.AddTemplate("List_Packages_Package",
                                   "<div class='w3-card-4' ><header class='w3-container w3-lime'><h1 class='w3-khaki' >Packages</h1></header><div class='w3-container' >",
                                   "<div class='w3-panel'><h3><a href=""package#package_id#.html"" >#name#</a><p>#notes#</p></div>",
                                   "</div></div>",
                                   "select * from t_package where parent_id = #id# order by name")
                    Me.AddTemplate("Detail_Diagram",
                                   "Back to <a href='package#package_id#.html' >parent</a><hr>",
                                    "<h1 class='w3-khaki' >#name#</h1><p>#notes#</p><img src=""diagram#diagram_id#.png"" usemap=#ideamap >#diagram_map#<hr>#list_elements_diagram#",
                                   "<footer class=''ftco-footer ftco-bg-dark ftco-section''</footer>",
                                   "select * from t_diagram where diagram_id = #id# order by name",
                                   "\diagram#id#.html")
                    Me.AddTemplate("List_Diagrams_Package",
                                   "<div class='w3-card-4' ><header class='w3-container w3-khaki'><h1 class='w3-khaki' >Diagrams</h1></header><div class='w3-container' ><ul>",
                                   "<li><a href=""diagram#diagram_id#.html"" >#name#</a></li>",
                                   "</ul></div></div>",
                                   "select * from t_diagram where package_id = #id# order by name")
                    Me.AddTemplate("Detail_Element",
                                   "Back to <a href='package#package_id#.html' >parent</a><hr>",
                                   "<h1 class='w3-khaki' >#name#</h1><p>#note#</p><hr>
  <table class='w3-table w3-striped w3-border'>
  <thead>
    <tr>
      <th >Value</th>
      <th >Description</th>

    </tr>
  </thead>
  <tbody>
    <tr>
      <td>Alias</td>
      <td>#alias#</td>
    </tr>
    <tr>
      <td>Version</td>
      <td>#version#</td>
    </tr>
    <tr>
      <td>Author</td>
      <td>#author#</td>
    </tr>
    <tr>
      <td>Created date</td>
      <td>#createddate#</td>
    </tr>
  </tbody>
</table>   
<a href='diagram#pdata1#.html' ><b>#alias#</b></a>
#list_attributes_element#
#list_diagrams_element#",
                                   "<footer class=''ftco-footer ftco-bg-dark ftco-section''</footer>",
                                   "select * from t_object where object_id = #id# order by name",
                                   "\element#id#.html")
                    Me.AddTemplate("List_Elements_Package",
                                   "<div class='w3-card-4' ><header class='w3-container w3-lime'><h1 class='w3-khaki' >Objects</h1></header><div class='w3-container' >",
                                   "<div class='w3-panel'><h3><a href=""element#object_id#.html"" >#name#</a></h3><p>#note#</p></div>",
                                   "</div></div>",
                                   "select * from t_object where package_id = #id# order by name")
                    Me.AddTemplate("List_Elements_Diagram",
                                   "<div class='w3-card-4' ><header class='w3-container w3-lime'><h1 class='w3-khaki' >Objects</h1></header><div class='w3-container' >",
                                   "<div class='w3-panel'><h3><a href=""element#object_id#.html"" >#name#</a></h3><p>#note#</p></div>",
                                   "</div></div>",
                                   "select t_object.* from t_object, t_diagramobjects  where t_object.Object_ID = t_diagramobjects.Object_ID and t_diagramobjects.Diagram_ID = #id# order by t_object.name")
                    Me.AddTemplate("List_Diagrams_Element",
                                   "<div class='w3-card-4' ><header class='w3-container w3-lime'><h1 class=w3-lime' >Diagrams</h1></header><div class='w3-container' ><ul>",
                                   "<li><a href=""diagram#diagram_id#.html"" >#name#</a></li>",
                                   "</ul></div></div>",
                                   "select t_diagram.* from t_diagram, t_diagramobjects  where t_diagram.diagram_ID = t_diagramobjects.diagram_ID and t_diagramobjects.Object_ID = #id# order by t_diagram.name")

                    'Me.AddTemplate("List_Elements_Element",
                    '               "<div class='w3-card-4' ><header class='w3-container w3-lime'><h1 class='w3-khaki' >Related objects</h1></header><div class='w3-container' >",
                    '               "<div class='w3-panel'><h3><a href=""element#object_id#.html"" >#name#</a></h3><p>#note#</p></div>",
                    '               "</div></div>",
                    '               "select t_object.* from t_object, t_connector  where (t_object.Object_ID = t_connector.start_object_ID and t_connector.end_object_id = #id#) Or (t_object.Object_ID = t_connector.end_object_ID and t_connector.start_object_id = #id#)  order by t_object.name")
                    Me.AddTemplate("List_Attributes_Element",
                                   "<div class='w3-card-4' ><header class='w3-container w3-khaki'><h1 class='w3-khaki' >Attributes</h1></header><div class='w3-container' ><table class='w3-table w3-striped w3-border'><thead><tr><th >Name</th><th>Type</th><th>Length</th><th >Description</th></tr></thead><tbody>",
                                   "<tr><td >#name#</td><td>#type#</td><td>#length#/#scale#</td><td>#notes#</td></tr>",
                                   "</tbody></table></div>",
                                   "select * from t_attribute where object_id = #id# order by name")
                    Me.AddTemplate("Default_Url",
                                   "",
                                   "<a href=""#url#.html"" >#title#</a>",
                                   "",
                                   "")
                    Me.AddTemplate("index.html",
                               "",
    "<div class='w3-row'>
    <div class='w3-card-4 w3-third' > 
    <header Class='w3-container w3-light-blue'>
      <h1>Packages</h1>
    </header>
    <div class='w3-container w3-gray'>
    <ul>
     #packagesitemap#
    </ul>
    </div>
    </div>
    <div class='w3-card-4 w3-third'  > 
    <header Class='w3-container w3-pale-red'>
      <h1>Diagrams</h1>
    </header><div class='w3-container w3-gray'>
    <ul>
     #diagramsitemap#
    </ul>
    </div>
    </div>
    <div class='w3-card-4 w3-third'  > 
    <header Class='w3-container w3-pale-blue'>
      <h1>Elements</h1>
    </header><div class='w3-container w3-gray'>
    <ul>
     #elementsitemap#
    </ul>
    </div>
    </div>

    </div>",
                               "",
                               "",
                               "\index.html")
                End If
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
                Return False
            End Try
            Return True

        End Function
        Public ReadOnly Property Templates() As DataTable
            Get
                Return Me.oTemplates
            End Get

        End Property
        ''' <summary>
        ''' Loading the templates from a XML file with definitions
        ''' </summary>
        ''' <param name="file"></param>
        ''' <returns></returns>
        Function LoadTemplates(file As String) As Boolean
            Try
                If file.Length > 0 And System.IO.File.Exists(file) Then
                    Me.oSet.Clear()
                    Me.oSet.ReadXml(file)
                    Me.oTemplates = oSet.Tables("Templates")
                Else
                    Me.DefaultTemplates()
                End If
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
                Return False
            End Try
            Return True

        End Function
    End Class

End Namespace
