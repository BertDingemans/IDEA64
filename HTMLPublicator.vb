Imports System.IO
Imports System.Text
Imports IDEA.DLAFormfactory
''' <summary>
''' Class for the HTML generator. Various functions to generate HTML pages and
''' snippets from the elements in the repository
''' </summary>
''' 
Public Class HTMLPublicator
    Const ForReading = 1, ForWriting = 2

    Public Path As String = ""
    Protected sHome As String
    Protected sTemplate As String
    Protected oSBPackageSiteMap As New StringBuilder("")
    Protected oSBDiagramSiteMap As New StringBuilder("")
    Protected oSBElementSiteMap As New StringBuilder("")

    Protected oALDiagrams As New ArrayList()
    Protected oALPackages As New ArrayList()
    Protected oALElements As New ArrayList()
    Protected oDef As New IDEADefinitions()
    Private Repository As EA.Repository = DLA2EAHelper.GetRepository()
    Private _Templates As HTMLTemplates
    Public Property Templates() As HTMLTemplates
        Get
            Return _Templates
        End Get
        Set(ByVal value As HTMLTemplates)
            _Templates = value
        End Set
    End Property
    ''' <summary>
    ''' Check if a diagram is already processed by the publisher and if not add it to the list of ready to process diagrams
    ''' </summary>
    ''' <param name="oRow">Row met data</param>
    ''' <returns></returns>
    Private Function CheckAndAddItem(ByVal oRow As DataRow, sTemplateName As String) As Boolean
        If sTemplateName.ToLower.Contains("list_diagrams") Then
            If Me.oALDiagrams.Contains(oRow("diagram_id")) = False Then
                Me.oALDiagrams.Add(oRow("diagram_id"))
                Return True
            End If
        End If
        If sTemplateName.ToLower.Contains("list_packages") Then
            If Me.oALPackages.Contains(oRow("package_id")) = False Then
                Me.oALPackages.Add(oRow("package_id"))
                Return True
            End If
        End If
        If sTemplateName.ToLower.Contains("list_elements") Then
            If Me.oALElements.Contains(oRow("object_id")) = False Then
                Me.oALElements.Add(oRow("object_id"))
                Return True
            End If
        End If
        Return False
    End Function
    ''' <summary>
    ''' Check if a diagram is processed and if so remove it from the list of to be processed diagrams
    ''' </summary>
    ''' <param name="ID"></param>
    ''' <returns></returns>
    Private Function CheckAndRemoveDiagram(ByVal ID As String) As Boolean
        If Me.oALDiagrams.Contains(ID) Then
            Me.oALDiagrams.Remove(ID)
            Me.Repository.WriteOutput("IDEA", "Diagram" + ID + " Removed from Array", 0)
            Return True
        Else
            Return False
        End If
    End Function
    ''' <summary>
    ''' Remove a package from the list of packages based on the id
    ''' </summary>
    ''' <param name="ID"></param>
    ''' <returns></returns>
    Private Function CheckAndRemovePackage(ByVal ID As String) As Boolean
        If Me.oALPackages.Contains(ID) Then
            Me.oALPackages.Remove(ID)
            Me.Repository.WriteOutput("IDEA", "Package" + ID + " Removed from Array", 0)
            Return True
        Else
            Return False
        End If
    End Function
    ''' <summary>
    ''' Remove a package from the list of elements based on the id
    ''' </summary>
    ''' <param name="ID"></param>
    ''' <returns>Success</returns>
    Private Function CheckAndRemoveElement(ByVal ID As String) As Boolean
        If Me.oALElements.Contains(ID) Then
            Me.oALElements.Remove(ID)
            Me.Repository.WriteOutput("IDEA", "Element" + ID + " Removed from Array", 0)
            Return True
        Else
            Return False
        End If
    End Function
    ''' <summary>
    ''' Read the template from a template file on the disk
    ''' </summary>
    ''' <param name="sTemplateFile">Name of the template file</param>
    Public Sub ReadHTMLTemplate(ByVal sTemplateFile As String)
        If File.Exists(sTemplateFile) Then
            Me.sTemplate = File.ReadAllText(sTemplateFile)
        End If
    End Sub
    ''' <summary>
    ''' Create a html href tag from the filename and the title
    ''' </summary>
    ''' <param name="sTitel">title of the hyperlink</param>
    ''' <param name="sURL">url to link to</param>
    ''' <returns></returns>
    Public Function MaakURL(ByVal sTitel As String, ByVal sURL As String) As String
        'Maak een url voor een lijst of overzicht 
        Dim oRow As DataRow
        oRow = Me._Templates.GetRowByName("Default_url")
        Dim sText As String = oRow("template_body").ToString()
        Return sText.Replace("#url#", sURL).Replace("#title#", sTitel)
    End Function
    ''' <summary>
    ''' Write the processed string to a file and do some processing for the tags
    ''' </summary>
    ''' <param name="sNaam">Name of the file</param>
    ''' <param name="sContent">html content</param>
    Public Sub Export2HTML(ByVal sNaam As String, ByVal sContent As String)
        'Export content naar een htmlfile gebaseerd op een constante in het templatebased on the constant of the path 
        Dim sValue As String
        If sNaam.Contains("#") = False Then
            sValue = sTemplate.Replace("#content#", sContent)
            'when a homepage is defined this is added too
            sValue = sValue.Replace("#home", sHome)
            Dim sFile As String = FullFileName(sNaam)
            File.WriteAllText(sFile, sValue)
            Repository.WriteOutput("IDEA", FullFileName(sNaam) + " Is created", 0)
        End If
    End Sub
    ''' <summary>
    ''' Make a full file name of the html file including the path and the extension
    ''' </summary>
    ''' <param name="Path"></param>
    ''' <param name="sNaam"></param>
    ''' <returns></returns>
    Public Function FullFileName(ByVal sNaam As String) As String
        Try
            If sNaam.ToLower().Contains(Me.Path.ToLower()) Then
                Return sNaam
            ElseIf Not sNaam.ToLower.Contains(".") Then
                Return Me.Path & sNaam & ".html"
            End If
            Return Me.Path & sNaam
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try

    End Function
    ''' <summary>
    ''' Publish the package content to Html pages
    ''' </summary>
    ''' <param name="oPkg"></param>
    Public Sub PubliceerRootPackage(ByVal oPkg As EA.Package)
        'Voor de zekerheid als de root anders verwerkt gaat worden
        sHome = "package" + oPkg.PackageID.ToString() + ".html"
        PubliceerPackage(oPkg)
        PubliceerSubPackages()
        PubliceerDiagrams()
        PubliceerElements()
    End Sub
    ''' <summary>
    ''' Publish the subpackages of a package
    ''' </summary>
    Public Sub PubliceerSubPackages()
        Try
            Dim oRow As DataRow = Me._Templates.GetRowByName("Detail_Package")
            Dim sResultaat As String = ""

            Dim strId As String
            While Me.oALPackages.Count > 0
                strId = Me.oALPackages(0)
                Dim oPkg As EA.Package
                oPkg = Me.Repository.GetPackageByID(strId)
                If Not File.Exists(FullFileName("element" + strId)) Then
                    MaakSiteMapURL(MaakURL(oPkg.Name, "package" + oPkg.PackageID.ToString()), "package")
                    sResultaat = ""
                    sResultaat = Me.ProcessSQL2Template(oRow(HTMLTemplates.T_NAME), oRow(HTMLTemplates.T_SQL), oRow(HTMLTemplates.T_HEADER), oRow(HTMLTemplates.T_BODY), oRow(HTMLTemplates.T_FOOTER), strId)
                    'maak een pdf document aan als er een template voor is
                    If oRow(HTMLTemplates.T_FILEPATH).ToString().Length > 0 Then
                        Dim strFileName As String = oRow(HTMLTemplates.T_FILEPATH)
                        strFileName = strFileName.Replace("#id#", oPkg.PackageID.ToString()).Replace("#guid#", oPkg.PackageGUID).Replace("#name#", oPkg.Name)
                        Export2HTML(strFileName, sResultaat)
                    End If
                End If
                Me.CheckAndRemovePackage(strId)
            End While
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub
    ''' <summary>
    ''' Process all the elements etc based on the collection of html templates
    ''' </summary>
    Public Sub PubliceerHTMLPagina()
        Try
            Dim oRow As DataRow
            Dim sResultaat As String = ""
            For Each oRow In Me.Templates.Templates.Rows
                If oRow(HTMLTemplates.T_FILEPATH).ToString().Length > 0 Then
                    sResultaat = Me.ProcessSQL2Template(oRow(HTMLTemplates.T_NAME).ToString(), oRow(HTMLTemplates.T_SQL).ToString(), oRow(HTMLTemplates.T_HEADER).ToString(), oRow(HTMLTemplates.T_BODY).ToString(), oRow(HTMLTemplates.T_FOOTER).ToString(), "")
                    sResultaat = sResultaat.Replace("#sitemap#", oSBPackageSiteMap.ToString())
                    Export2HTML(oRow(HTMLTemplates.T_FILEPATH), sResultaat)
                End If
            Next
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try

    End Sub
    ''' <summary>
    ''' Publish  all the diagrams based on an array of found diagrams
    ''' </summary>
    Public Sub PubliceerDiagrams()
        Try
            Dim oRow As DataRow = Me._Templates.GetRowByName("Detail_Diagram")
            Dim sResultaat As String = ""

            Dim strId As String
            While Me.oALDiagrams.Count > 0
                strId = Me.oALDiagrams(0)
                Dim oDgm As EA.Diagram
                oDgm = Me.Repository.GetDiagramByID(strId)
                MaakSiteMapURL(MaakURL(oDgm.Name, "diagram" + oDgm.DiagramID.ToString()), "diagram")
                sResultaat = ""
                sResultaat = Me.ProcessSQL2Template(oRow(HTMLTemplates.T_NAME), oRow(HTMLTemplates.T_SQL), oRow(HTMLTemplates.T_HEADER), oRow(HTMLTemplates.T_BODY), oRow(HTMLTemplates.T_FOOTER), strId)
                If sResultaat.Contains("#diagram_map#") Then
                    Dim strMap As String
                    strMap = MakeDiagramMap(oDgm)
                    sResultaat = sResultaat.Replace("#diagram_map#", strMap)
                End If
                If oRow(HTMLTemplates.T_FILEPATH).ToString().Length > 0 Then
                    Dim strFileName As String = oRow(HTMLTemplates.T_FILEPATH)
                    strFileName = strFileName.Replace("#id#", oDgm.DiagramID.ToString()).Replace("#guid#", oDgm.DiagramGUID).Replace("#name#", oDgm.Name)
                    Export2HTML(strFileName, sResultaat)
                    Me.SaveDiagramImage(Path + strFileName, oDgm.DiagramID)
                End If
                Me.CheckAndRemoveDiagram(strId)
            End While
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try

    End Sub
    ''' <summary>
    ''' Publish all the elements found based on an array of found elements
    ''' </summary>
    Public Sub PubliceerElements()
        Try
            Dim oRow As DataRow = Me._Templates.GetRowByName("Detail_Element")
            Dim sResultaat As String = ""
            Dim strId As String
            If oRow(HTMLTemplates.T_BODY).ToString().Length > 0 Then
                While Me.oALElements.Count > 0
                    strId = Me.oALElements(0)
                    If oRow(HTMLTemplates.T_FILEPATH).ToString().Length > 0 Then
                        Dim strFileName As String = oRow(HTMLTemplates.T_FILEPATH)
                        Dim oEle As EA.Element
                        oEle = Me.Repository.GetElementByID(Convert.ToInt32(strId))
                        If oEle.Name.Length > 0 Then
                            MaakSiteMapURL(MaakURL(oEle.Name, "element" + oEle.ElementID.ToString()), "element")
                        End If
                        strFileName = strFileName.Replace("#id#", oEle.ElementID.ToString()).Replace("#guid#", oEle.ElementGUID).Replace("#name#", oEle.Name)
                        If Not File.Exists(strFileName) Then
                            sResultaat = ""
                            sResultaat = Me.ProcessSQL2Template(oRow(HTMLTemplates.T_NAME).ToString(), oRow(HTMLTemplates.T_SQL).ToString(), oRow(HTMLTemplates.T_HEADER).ToString(), oRow(HTMLTemplates.T_BODY).ToString(), oRow(HTMLTemplates.T_FOOTER).ToString(), strId)
                            Export2HTML(strFileName, sResultaat)
                        End If
                    End If
                    Me.CheckAndRemoveElement(strId)
                End While
            End If
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try

    End Sub
    ''' <summary>
    ''' Write the diagram to disk as a png file on a standardized location
    ''' </summary>
    Public Sub SaveDiagramImage(ByVal sDiagram As String, DiagramID As Integer)
        'Schrijf diagram weg naar een plaatje 
        Dim objProject As EA.Project
        objProject = Repository.GetProjectInterface()
        Repository.OpenDiagram(DiagramID)
        objProject.SaveDiagramImageToFile(sDiagram.Replace(".html", ".png"))
        Repository.CloseDiagram(DiagramID)
    End Sub
    ''' <summary>
    ''' Create a sitemap url for a package or diagram. With diagram you can define a tree like structure
    ''' </summary>
    ''' <param name="sURL"></param>
    ''' <param name="bNiveau"></param>
    Public Sub MaakSiteMapURL(ByVal sURL As String, ByVal concepttype As String)
        'Opbouwen van de sitemap met URLs packages krijgen een h3
        If concepttype = "package" Then
            oSBPackageSiteMap.Append("<li>" + sURL + "</li>")
        End If
        If concepttype = "diagram" Then
            oSBDiagramSiteMap.Append("<li>" + sURL + "</li>")
        End If
        If concepttype = "element" Then
            oSBElementSiteMap.Append("<li>" + sURL + "</li>")
        End If
    End Sub
    ''' <summary>
    ''' Process sql statement for various templates for an element
    ''' </summary>
    ''' <param name="sNaam"></param>
    ''' <param name="sSql"></param>
    ''' <param name="sHeader"></param>
    ''' <param name="sBody"></param>
    ''' <param name="sFooter"></param>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Function ProcessSQL2Template(ByRef sNaam As String, sSql As String, sHeader As String, sBody As String, sFooter As String, id As String) As String
        Dim oDataTable As DataTable
        Dim sResultaat As String = ""
        Try
            'eerst gaan we het element zelf verwerken
            If sSql.Length > 0 And ((sSql.Contains("#id#") And id.Length > 0) Or Not sSql.Contains("#id#")) Then
                sSql = sSql.Replace("#id#", id)
                oDataTable = DLA2EAHelper.SQL2DataTable(sSql, Me.Repository)
                Dim oColumn As DataColumn
                Dim oRow As DataRow
                Dim blnFirst As Boolean = True
                For Each oRow In oDataTable.Rows
                    Dim sRegel = sBody
                    For Each oColumn In oDataTable.Columns
                        If blnFirst = True Then
                            sHeader = sHeader.Replace("#" + oColumn.ColumnName.ToLower() + "#", IIf(DBNull.Value.Equals(oRow(oColumn.ColumnName)), "&nbsp;", oRow(oColumn.ColumnName)))
                            sFooter = sFooter.Replace("#" + oColumn.ColumnName.ToLower() + "#", IIf(DBNull.Value.Equals(oRow(oColumn.ColumnName)), "&nbsp;", oRow(oColumn.ColumnName)))
                        End If
                        If sRegel.Contains("#" + oColumn.ColumnName.ToLower() + "#") Then
                            sRegel = sRegel.Replace("#" + oColumn.ColumnName.ToLower() + "#", IIf(DBNull.Value.Equals(oRow(oColumn.ColumnName)), "&nbsp;", oRow(oColumn.ColumnName)))
                        End If
                    Next
                    blnFirst = False
                    Me.CheckAndAddItem(oRow, sNaam)
                    sResultaat += sRegel
                Next
            Else
                sResultaat = sBody
            End If
            'daarna gaan we kijken of er nog andere html blokken zitten

            While (sResultaat.Contains("#list") Or sResultaat.Contains("#detail")) And sSql.Length > 0
                Repository.WriteOutput("IDEA", sResultaat, 0)
                Dim oTmplRow As DataRow
                oTmplRow = Me.Templates.GetRowByTemplate(sResultaat)
                If Me.Templates.FindRowByName(oTmplRow(HTMLTemplates.T_NAME).ToString().ToLower()) = False Then
                    Exit While
                End If
                sResultaat = sResultaat.Replace("#" + oTmplRow(HTMLTemplates.T_NAME).ToString().ToLower() + "#",
                                                Me.ProcessSQL2Template(oTmplRow(HTMLTemplates.T_NAME).ToString(),
                                                                       oTmplRow(HTMLTemplates.T_SQL).ToString(),
                                                                       oTmplRow(HTMLTemplates.T_HEADER).ToString(),
                                                                       oTmplRow(HTMLTemplates.T_BODY).ToString(),
                                                                       oTmplRow(HTMLTemplates.T_FOOTER).ToString(), id))
            End While
            Dim strTekst As String = sHeader + sResultaat + sFooter
            ' een beetje lelijk maar het werkt voor nu
            If strTekst.Contains("#") Then
                strTekst = strTekst.Replace("#note#", "").Replace("#notes#", "").Replace("#alias#", "").Replace("#name#", "")
            End If
            If sResultaat.Length > 0 Then
                Return strTekst
            Else
                Return ""
            End If
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
        Return ""
    End Function
    ''' <summary>
    ''' Publish a package to html
    ''' </summary>
    ''' <param name="oPkg">Object of the package to process</param>
    Public Sub PubliceerPackage(ByVal oPkg As EA.Package)
        Try
            Dim oRow As DataRow = Me._Templates.GetRowByName("Detail_Package")
            Dim sResultaat As String = ""
            MaakSiteMapURL(MaakURL(oPkg.Name, "package" + oPkg.PackageID.ToString()), "package")
            sResultaat = Me.ProcessSQL2Template(oRow(HTMLTemplates.T_NAME), oRow(HTMLTemplates.T_SQL), oRow(HTMLTemplates.T_HEADER), oRow(HTMLTemplates.T_BODY), oRow(HTMLTemplates.T_FOOTER), oPkg.PackageID)
            If oRow(HTMLTemplates.T_FILEPATH).ToString().Length > 0 Then
                Dim strFileName As String = oRow(HTMLTemplates.T_FILEPATH)
                strFileName = strFileName.Replace("#id#", oPkg.PackageID.ToString()).Replace("#guid#", oPkg.PackageGUID).Replace("#name#", oPkg.Name)
                Export2HTML(strFileName, sResultaat)
            End If
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try

    End Sub
    ''' <summary>
    ''' Write the constructed sitemap to a file 
    ''' </summary>
    Sub PublishSiteMap()
        Dim oRow As DataRow = Me._Templates.GetRowByName("Index.html")
        If oRow(HTMLTemplates.T_BODY).Contains("sitemap#") Then
            Dim sResultaat As String = oRow(HTMLTemplates.T_HEADER).ToString() + oRow(HTMLTemplates.T_BODY).ToString() + oRow(HTMLTemplates.T_FOOTER).ToString()
            sResultaat = sResultaat.Replace("#packagesitemap#", oSBPackageSiteMap.ToString())
            sResultaat = sResultaat.Replace("#diagramsitemap#", oSBDiagramSiteMap.ToString())
            sResultaat = sResultaat.Replace("#elementsitemap#", oSBElementSiteMap.ToString())
            Dim strFileName As String = oRow(HTMLTemplates.T_FILEPATH)
            Export2HTML(strFileName, sResultaat)
        End If
    End Sub
    ''' <summary>
    ''' Convert an element and a diagramobject in a diagram to a map tag in a html construction. In here a number of calculations and transformations are needed
    ''' </summary>
    ''' <param name="oElement">Element to process</param>
    ''' <param name="oDO">Data object to process (read the coordinates)</param>
    ''' <param name="MinX">Min X position of alle the elements</param>
    ''' <param name="MinY">Min Y position of alle the elements</param>
    ''' <param name="MaxX">Max X position of alle the elements when resizing is needed</param>
    ''' <returns></returns>
    Public Function Element2Map(ByVal oElement As EA.Element, ByVal oDO As EA.DiagramObject, ByVal MinX As Double, ByVal MinY As Double, ByVal MaxX As Double) As String
        Dim sCoord
        Try
            sCoord = ""
            'Calculate the coordinates for each part of an element
            sCoord += "<area shape='rect' coords='"
            sCoord += Int(Convert.ToDouble(oDO.left - 10)).ToString() + ","
            sCoord += Int(Convert.ToDouble(Math.Abs(oDO.top) - 10)).ToString() + ","
            sCoord += Int(Convert.ToDouble(oDO.right + MinX) + 10).ToString() + ","
            sCoord += Int(Convert.ToDouble(Math.Abs(oDO.bottom) + 10)).ToString() + "' target='_self'  "
            If oElement.IsComposite = True Then
                sCoord += " href='diagram" + oElement.CompositeDiagram.diagramID.ToString() + ".html' >"
                If Me.oALDiagrams.Contains(oElement.CompositeDiagram.diagramID.ToString()) = False Then
                    Me.oALDiagrams.Add(oElement.CompositeDiagram.diagramID.ToString())
                End If
            ElseIf oElement.Stereotype = "NavigationCell" Then
                sCoord += " href='diagram" + oElement.MiscData(0) + ".html' >"
            Else
                sCoord += " href='element" + oElement.ElementID.ToString() + ".html' >"
            End If

            Return sCoord
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
        Return ""
    End Function
    ''' <summary>
    ''' Publish a diagram and all the elements to a html page
    ''' </summary>
    ''' <param name="oDgm"></param>
    Public Function MakeDiagramMap(ByVal oDgm As EA.Diagram) As String
        Dim oElement As EA.Element
        Dim oDiagramObject As EA.DiagramObject
        Dim sMap As String
        Dim iMinX As Integer
        Dim iMinY As Integer
        Dim iMaxX As Integer

        'Aanmaken map elementen
        Try
            sMap = ""
            'calculate the min and max coordinates for all elements in the diagram
            'necessary for positioning the rect elements
            iMaxX = 0
            iMinX = 1000
            iMinY = 1000
            For Each oDiagramObject In oDgm.DiagramObjects
                If Math.Abs(oDiagramObject.top) < iMinY Then
                    iMinY = Math.Abs(oDiagramObject.top)
                End If
                If oDiagramObject.left < iMinX Then
                    iMinX = oDiagramObject.left
                End If
                If oDiagramObject.right > iMaxX Then
                    iMaxX = oDiagramObject.right
                End If
            Next
            'create all the elements based on the option of a combined diagram element page or not
            For Each oDiagramObject In oDgm.DiagramObjects
                oElement = Repository.GetElementByID(oDiagramObject.ElementID)
                sMap += Element2Map(oElement, oDiagramObject, iMinX, iMinY, iMaxX)
            Next
            Return "<map name='ideamap' >" + sMap + "</map>"
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
        Return ""
    End Function
    ''' <summary>
    ''' delete all the files available in the publication folder
    ''' </summary>
    Sub DeleteFilesInFolder()
        Try
            If Directory.Exists(Path) Then
                For Each _file As String In Directory.GetFiles(Path)
                    File.Delete(_file)
                Next
            End If
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try

    End Sub

    ''' <summary>
    ''' Generate the documentation based on the first package
    ''' </summary>
    ''' <param name="oPackage">The rootpackage to start processing</param>
    Public Sub Generate(ByVal oPackage As EA.Package)
        Try
            Repository.CreateOutputTab("IDEA")
            Repository.EnableUIUpdates = False
            Me.sTemplate = Me.Templates.GetRowByName("Page_Template")(HTMLTemplates.T_BODY)
            ReadHTMLTemplate(Path + "\" + oDef.GetSettingValue("HTMLTemplate"))
            DeleteFilesInFolder()
            Repository.WriteOutput("IDEA", "Generator is started", 0)
            PubliceerRootPackage(oPackage)
            PubliceerHTMLPagina()
            PublishSiteMap()
            Repository.WriteOutput("IDEA", "Generator is ready", 0)
            Repository.EnableUIUpdates = True
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub
End Class
