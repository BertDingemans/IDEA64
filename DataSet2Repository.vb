Imports System.Runtime.InteropServices

Namespace DLAFormfactory

    ''' <summary>
    ''' Helper class for transforming output from the Sparx API in a more usable format
    ''' within a DotNet (windows) application.
    ''' </summary>
    Public Class DataSet2Repository
        Private _Repository As EA.Repository
        Public fouten As String = ""

        ''' <summary>
        ''' Bewaar de package property voor het aanmaken van elementen in dit package
        ''' </summary>
        Private _Package_id As String
        Protected objLastElement As EA.Element
        ''' <summary>
        ''' Return the stored package id
        ''' </summary>
        ''' <returns></returns>
        Public Property Package_Id() As String
            Get
                Return _Package_id
            End Get
            Set(ByVal value As String)
                _Package_id = value
            End Set
        End Property
        ''' <summary>
        ''' include a reference to the repository as that saves typing
        ''' </summary>
        ''' <returns></returns>
        Public Property Repository() As EA.Repository
            Get
                Return _Repository
            End Get
            Set(ByVal value As EA.Repository)
                _Repository = value
            End Set
        End Property
        ''' <summary>
        ''' Process a datarow for import to transform to a new element and association in EA
        ''' </summary>
        ''' <param name="Parent">The element to start from</param>
        ''' <param name="objRow">Datarow that is imported</param>
        ''' <param name="Fieldname">The name of the field in the datarow</param>
        ''' <param name="objStereoType">The stereotype of the element to connect to</param>
        ''' <param name="ConStereoType">The stereotype of the column to connect to</param>
        ''' <param name="PostFix">Eventually use a postfix (for a context) for the fieldcontent</param>
        ''' <returns></returns>
        Public Function AddElementAndConnector(Parent As EA.Element, objRow As DataRow, Fieldname As String, objStereoType As String, ConStereoType As String, Optional PostFix As String = "", Optional Direction As String = "Unspecified") As EA.Element
            Try
                Dim objChild As EA.Element
                If Not IsDBNull(objRow.Item(Fieldname)) Then
                    Dim strChild As String = Strings.Trim(objRow.Item(Fieldname) + PostFix)
                    objChild = Me.FindOrAddElement(strChild, objStereoType, False)
                    objChild.Status = "Import4Hub"
                    objChild.Update()
                    Dim objCon As EA.Connector
                    objCon = Me.AddConnector(objChild, Parent, ConStereoType, Direction)
                    objCon.Update()
                    Return objChild
                End If
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return Nothing
        End Function
        ''' <summary>
        ''' Create a new object and connector to the repository
        ''' </summary>
        ''' <param name="Parent">Parent entity</param>
        ''' <param name="Fieldvalue">Fieldvalue and postfix is combined to create the name of the linked object</param>
        ''' <param name="objStereoType">Stereotype of the element that will be created</param>
        ''' <param name="ConStereoType">Stereotype of the connector between the object and the newly created element</param>
        ''' <param name="blnSoureToTarget">Direction of the connector</param>
        ''' <param name="PostFix">Fieldvalue and postfix is combined to create the name of the linked object</param>
        ''' <param name="ConnectorText">Text for the connector name</param>
        ''' <returns></returns>
        Public Function AddElementAndConnectorValue(Parent As EA.Element, Fieldvalue As String, objStereoType As String, ConStereoType As String, Optional blnSoureToTarget As Boolean = True, Optional PostFix As String = "", Optional ConnectorText As String = "", Optional Direction As String = "Unspecified") As EA.Element
            Try
                Dim objChild As EA.Element
                If Fieldvalue.ToString().Length > 0 Then
                    Dim strChild As String = Fieldvalue + PostFix
                    objChild = Me.FindOrAddElement(strChild, objStereoType, False)
                    objChild.Status = "Import4Hub"
                    objChild.Update()
                    Dim objCon As EA.Connector
                    objCon = Me.AddConnector(Parent, objChild, ConStereoType, ConnectorText, Direction)
                    If Not IsNothing(objCon) Then
                        objCon.Notes = ConnectorText
                        objCon.Update()
                    End If

                    Return objChild
                End If
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return Nothing
        End Function
        ''' <summary>
        ''' Process the mapping definitions that are used for the import of the excel sheet to the repository
        ''' </summary>
        ''' <param name="DefinitionRow">Definition of the mapping as a datarow from the definitions dataset</param>
        ''' <param name="ImportRow">Data items that are transformed in the import routine</param>
        ''' <param name="Element">Element to create the content to</param>
        ''' <returns></returns>
        Public Function ProcessMappingDefinitions(DefinitionRow As DataRow, ImportRow As DataRow, Element As EA.Element) As EA.Element
            Dim strType As String = DefinitionRow("MappingType").ToString().ToUpper()
            Dim strValue As String
            Dim strName As String
            Dim Package As EA.Package

            Try
                If DefinitionRow("SourceColumn").Contains("@") Then
                    strValue = DefinitionRow("SourceColumn").Replace("@", "")
                Else
                    strValue = ImportRow.Item(DefinitionRow("SourceColumn")).ToString()
                End If
                Select Case strType
                    'Find Object by Name
                    Case "FON"
                        strName = ImportRow.Item(DefinitionRow("SourceColumn")).ToString()
                        If DefinitionRow("PostFix").ToString().Length > 0 Then
                            strName += DefinitionRow("PostFix").ToString()
                        End If
                        strName = strName.Trim()
                        Element = Me.FindOrAddElement(strName, DefinitionRow("ObjectStereoType").ToString(), True)
                    'find package by name
                    Case "FPN"
                        strName = ImportRow.Item(DefinitionRow("SourceColumn")).ToString()
                        If DefinitionRow("PostFix").ToString().Length > 0 Then
                            strName += DefinitionRow("PostFix").ToString()
                        End If
                        Package = Me.FindOrAddPackage(strName, True, "")
                        Element.PackageID = Package.PackageID
                        Element.Update()
                    'Find object by tagged value
                    Case "FOT"
                        strName = ImportRow.Item(DefinitionRow("SourceColumn")).ToString()
                        If DefinitionRow("PostFix").ToString().Length > 0 Then
                            strName += DefinitionRow("PostFix").ToString()
                        End If
                        Element = Me.FindElementByTaggedValue(DefinitionRow("TargetColumn"), ImportRow.Item(DefinitionRow("SourceColumn")).ToString())
                    'Add property to object
                    'Find Object by Name + add attribute
                    Case "OBA"
                        strName = ImportRow.Item(DefinitionRow("SourceColumn")).ToString()
                        If DefinitionRow("PostFix").ToString().Length > 0 Then
                            strName += DefinitionRow("PostFix").ToString()
                        End If
                        strName = strName.Trim()
                        Dim intPos As Int16
                        Dim strAttributes As String() = {}
                        intPos = strName.IndexOf("|")

                        If intPos > 0 Then
                            Dim strSplits As String
                            strSplits = strName.Substring(intPos + 1)
                            If strSplits.IndexOf(" ") > 0 Then
                                strAttributes = strSplits.Split(" ")
                            Else
                                strAttributes = {strSplits}
                            End If
                            strName = strName.Substring(0, intPos)
                        End If
                        Element = Me.FindOrAddElement(strName, DefinitionRow("ObjectStereoType").ToString(), True)
                        If strAttributes.Length > 0 Then
                            Dim strAttr As String
                            For Each strAttr In strAttributes
                                strAttr = strAttr.Trim()
                                If strAttr.Length > 2 Then
                                    If strAttr.Contains("(") Then
                                        Element.Notes += strAttr.Replace("(", "").Replace(")", "")
                                    Else
                                        Me.AddAttribute(Element, strAttr, "String")
                                    End If
                                End If
                            Next
                        End If
                        'add property
                    Case "PRO", "LPR"
                        If strType = "LPR" And Not IsNothing(Me.objLastElement) Then
                            Element = Me.objLastElement
                        End If
                        If Not IsNothing(Element) Then
                            If DefinitionRow("TargetColumn").ToString().ToUpper() = "NOTES" Then
                                Element.Notes = strValue + vbCrLf
                            End If
                            If DefinitionRow("TargetColumn").ToString().ToUpper() = "ALIAS" Then
                                Element.Alias = strValue
                            End If

                            If DefinitionRow("TargetColumn").ToString().ToUpper() = "STATUS" Then
                                Element.Status = strValue
                            End If
                            Element.Update()
                        End If
                    'Add Element and Connector
                    Case "OCO", "PCO", "LCO"
                        If strType = "LCO" Then
                            Element = Me.objLastElement
                        End If
                        Dim SourceToTarget As Boolean = True
                        If strType = "PCO" Then
                            SourceToTarget = False
                        End If
                        strName = ImportRow.Item(DefinitionRow("SourceColumn")).ToString()
                        If strName.Length > 0 Then
                            If DefinitionRow("PostFix").ToString().Length > 0 Then
                                strName += DefinitionRow("PostFix").ToString()
                            End If
                            Me.AddElementAndConnectorValue(Element, strName, DefinitionRow("ObjectStereoType"), DefinitionRow("ConnectorStereoType"), SourceToTarget, Direction:=DefinitionRow("ConnectorDirection").ToString())
                        End If
                    'Specific routine for adding business roles to the model
                    'Specific for the Dutch Railways
                    Case "ROL"
                        Dim objKoppel As EA.Element
                        Dim objCon As EA.Connector
                        If IsDBNull(ImportRow.Item(DefinitionRow("SourceColumn"))) Then
                            objKoppel = FindOrAddElement(DefinitionRow("TargetColumn"), "ArchiMate_BusinessRole", False)
                            objKoppel.Status = "FromSharePoint"
                            objKoppel.Update()
                            objCon = Me.AddConnector(Element, objKoppel, "ArchiMate_Association", "Unspecified")
                            objCon.Name = ImportRow(DefinitionRow("SourceColumn"))
                            objCon.Update()
                        End If
                    'Add a tagged value to the object
                    Case "TV"
                        'hij rekent zelf uit of het een memo veld moet worden of niet
                        Me.AddOrUpdateTaggedValue(Element, DefinitionRow("TargetColumn").ToString(), DefinitionRow("SourceColumn").ToString(), ImportRow,
                                          ImportRow(DefinitionRow("SourceColumn")).ToString().Length > 225)
                    Case "FIL"
                        'hij rekent zelf uit of het een memo veld moet worden of niet
                        Me.AddOrUpdateLinkedFile(Element, Strings.Trim(ImportRow.Item(DefinitionRow("SourceColumn").ToString()).ToString()), DefinitionRow("TargetFilter").ToString(), ImportRow)
                    Case "ATT"
                        'hij rekent zelf uit of het een memo veld moet worden of niet
                        Me.AddAttribute(Element, ImportRow(DefinitionRow("SourceColumn")), "")
                End Select
                Return Element
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return Nothing
        End Function

        ''' <summary>
        ''' Add an attribute to an element
        ''' </summary>
        ''' <param name="objElement">The element that is parent</param>
        ''' <param name="strName">The name of the attribute</param>
        ''' <param name="strType">The datatype of the element</param>
        ''' <returns></returns>
        Public Function AddAttribute(ByVal objElement As EA.Element, ByVal strName As String, ByVal strType As String) As EA.Element
            Dim objAttribute As EA.Attribute
            If strName.Length > 0 And strName.ToUpper() <> "NULL" Then
                If Not IsNothing(objElement) Then
                    objAttribute = objElement.Attributes.AddNew(Strings.Trim(strName), strType)
                    objAttribute.Update()
                    objElement.Update()
                End If
            End If
            Return objElement
        End Function

        ''' <summary>
        ''' Add (when not exist) or update a tagged value from a datarow
        ''' </summary>
        ''' <param name="Element">Parent element</param>
        ''' <param name="name">Name of the field in the datarow</param>
        ''' <param name="Row">Datarow with the import data</param>
        ''' <param name="isMemo">Is the value a memo</param>
        Public Sub AddOrUpdateTaggedValue(ByVal Element As EA.Element, ByVal name As String, Row As DataRow, ByVal isMemo As Boolean)
            If Not IsDBNull(Row.Item(name)) Then
                Me.AddOrUpdateTaggedValue(Element, name, Strings.Trim(Row.Item(name)), isMemo)
            End If
        End Sub
        ''' <summary>
        ''' Add (when not exist) or update a tagged value from a datarow with a different tv name
        ''' </summary>
        ''' <param name="Element">Parement element</param>
        ''' <param name="tvname">Name of the tagged value</param>
        ''' <param name="rowname">Name of the field in the datarow</param>
        ''' <param name="Row">datarow with imported data</param>
        ''' <param name="isMemo">Memo field</param>
        Public Sub AddOrUpdateTaggedValue(ByVal Element As EA.Element, ByVal tvname As String, rowname As String, Row As DataRow, ByVal isMemo As Boolean)
            If tvname.Length = 0 Then
                tvname = rowname
            End If
            If Not IsDBNull(Row.Item(rowname)) Then
                Me.AddOrUpdateTaggedValue(Element, tvname, Strings.Trim(Row.Item(rowname).ToString()), isMemo)
            End If
        End Sub

        Public Sub AddOrUpdateLinkedFile(ByVal objElement As EA.Element, ByVal strName As String, strTemplate As String, Row As DataRow)
            Dim objFile As EA.File
            Dim strFiles As String = ""

            Try
                If strName.Length > 0 And strName.ToUpper() <> "NULL" Then
                    If Not IsNothing(objElement) Then
                        For Each File As EA.File In objElement.Files
                            strFiles += File.Name + "; "
                        Next
                        strTemplate = strTemplate.Replace("#source#", strName)
                        If Not strFiles.Contains(strTemplate) Then
                            objFile = objElement.Files.AddNew(Strings.Trim(strTemplate), "")
                            objFile.Type = "Web Address"
                            objFile.Update()
                            objElement.Update()
                        End If

                    End If
                    End If
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try

        End Sub

        ''' <summary>
        ''' Get a tagged value content for an element
        ''' </summary>
        ''' <param name="Element">Parent element</param>
        ''' <param name="name">Tagged value name</param>
        ''' <returns>Tagged value content</returns>
        Public Shared Function GetTaggedValue(ByVal Element As EA.Element, ByVal name As String) As String
            Dim objTV As EA.TaggedValue
            Dim Found As Boolean = False
            Dim strRet As String = ""
            Try
                For Each objTV In Element.TaggedValues
                    If objTV.Name = name Then
                        If objTV.Value = "<memo>" Then
                            strRet = objTV.Notes
                            Found = True
                        Else
                            strRet = objTV.Value
                        End If
                        Exit For
                    End If
                Next
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return strRet
        End Function
        ''' <summary>
        ''' Add or update a tagged value to an element
        ''' </summary>
        ''' <param name="Element">Parent object</param>
        ''' <param name="name">Tagged value name</param>
        ''' <param name="value">Tagged value content</param>
        ''' <param name="isMemo">Is the value a memo value</param>
        Public Sub AddOrUpdateTaggedValue(ByVal Element As EA.Element, ByVal name As String, ByVal value As String, ByVal isMemo As Boolean)
            Try
                Dim objTV As EA.TaggedValue
                Dim Found As Boolean = False
                If Not String.IsNullOrEmpty(value) And value <> ChrW(129) Then
                    For Each objTV In Element.TaggedValues
                        If objTV.Name = name Then
                            Found = True
                            Exit For
                        End If
                    Next
                    If isMemo Then
                        If Found = False Then
                            objTV = Element.TaggedValues.AddNew(name, "<memo>")
                        End If
                        objTV.Notes = value
                    Else
                        If Found = False Then
                            objTV = Element.TaggedValues.AddNew(name, Strings.Trim(value))
                        Else
                            objTV.Value = value
                        End If
                    End If
                    objTV.Update()
                End If
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
        End Sub
        ''' <summary>
        ''' Convert a stereotype to an objecttype
        ''' </summary>
        ''' <param name="stereotype">Name of the stereotype</param>
        ''' <returns>Name of the objecttype</returns>
        Public Function ConvertStereotype2Type(ByVal stereotype As String) As String
            Dim strRet As String = "Class"

            Select Case stereotype.ToUpper().Replace("ARCHIMATE3::", "")
                Case "ARCHIMATE_APPLICATIONCOMPONENT"
                    strRet = "Component"
                Case "ARCHIMATE_BUSINESSROLE"
                    strRet = "BusinessRole"
                Case "ARCHIMATE_GROUPING"
                    strRet = "Grouping"
                Case "ARCHIMATE_APPLICATIONINTERFACE"
                    strRet = "Interface"
                Case "ARCHIMATE_BUSINESSFUNCTION", "ARCHIMATE_BUSINESSPROCESS", "BUSINESSPROCESS"
                    strRet = "Activity"
                Case "ARCHIMATE_APPLICATIONFUNCTION"
                    strRet = "ApplicationFunction"
                Case "ARCHIMATE_LOCATION"
                    strRet = "Class"
                Case "ARCHIMATE_WORKPACKAGE"
                    strRet = "WorkPackage"
                    'Case "ARCHIMATE_DELIVERABLE"
                    '    strRet = "Deliverable"
                Case "ARCHIMATE_CAPABILIY"
                    strRet = "Capability"
                Case "ARCHIMATE_VALUE"
                    strRet = "Class"
                Case "ARCHIMATE_PLATEAU"
                    strRet = "Plateau"
                Case "ARCHIMATE_OUTCOME"
                    strRet = "Outcome"
                Case "ARCHIMATE_GOAL"
                    strRet = "Goal"
                Case "ARCHIMATE_DRIVER"
                    strRet = "Driver"
                Case "ARCHIMATE_STAKEHOLDER"
                    strRet = "Stakeholder"
                Case Else
                    strRet = "Class"
            End Select
            Return strRet
        End Function
        ''' <summary>
        ''' Convert a stereotype of a connector to a connectortype
        ''' </summary>
        ''' <param name="stereotype">Name of the stereotype</param>
        ''' <returns>Name of the connectortype</returns>
        Public Function ConvertAssociationStereotype2Type(ByVal stereotype As String) As String
            Dim strRet As String = "Association"
            Select Case stereotype.ToUpper().Replace("ARCHIMATE3::", "")
                Case "ARCHIMATE_AGGREGATION"
                    strRet = "Aggregation"
                Case "DEPENDENCY"
                    strRet = "Dependency"
                    stereotype = ""
            End Select
            Return strRet
        End Function
        ''' <summary>
        ''' Add an element to the repository
        ''' </summary>
        ''' <param name="stereotype">Stereotype of the element</param>
        ''' <param name="name">Name of the element</param>
        ''' <param name="memo">Note field text</param>
        ''' <returns></returns>
        Public Function AddElement(ByVal stereotype As String, ByVal name As String, ByVal memo As String) As EA.Element
            Dim objPack As EA.Package
            Dim objElement As EA.Element
            Try
                If Me.Package_Id.Contains("{") Then
                    objPack = _Repository.GetPackageByGuid(Me.Package_Id)
                Else
                    objPack = _Repository.GetPackageByID(Convert.ToInt32(Me.Package_Id))
                End If
                If stereotype.Contains("|") Then
                    Dim strTypeStereotype As String()
                    strTypeStereotype = stereotype.Split("|")
                    Dim strType = strTypeStereotype(0)
                    stereotype = strTypeStereotype(1)
                    objElement = objPack.Elements.AddNew(name, strType)
                Else
                    If stereotype.Contains("ArchiMa") Then
                        stereotype = "ArchiMate3::" + stereotype
                    End If
                    objElement = objPack.Elements.AddNew(Strings.Trim(name), ConvertStereotype2Type(stereotype))
                End If
                If Not String.IsNullOrEmpty(stereotype) Then
                    objElement.Stereotype = stereotype

                End If
                If Not String.IsNullOrEmpty(memo) Then
                    objElement.Notes = memo
                End If
                objElement.Update()
                objPack.Update()
                objLastElement = objElement
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
            Return objElement
        End Function
        ''' <summary>
        ''' Add a package to the model based on the name and a memo text
        ''' Developed for the Dutch Air Traffic Control
        ''' </summary>
        ''' <param name="name">Name of the Package</param>
        ''' <param name="memo">Eventually a memo text an empty string will not add a memo of course</param>
        ''' <returns></returns>
        Public Function AddPackage(ByVal name As String, ByVal memo As String) As EA.Package
            Dim objPack As EA.Package
            Dim objPackage As EA.Package
            Try
                If Me.Package_Id.Contains("{") Then
                    objPack = _Repository.GetPackageByGuid(Me.Package_Id)
                Else
                    objPack = _Repository.GetPackageByID(Convert.ToInt32(Me.Package_Id))
                End If
                objPackage = objPack.Packages.AddNew(Strings.Trim(name), "")
                If Not String.IsNullOrEmpty(memo) Then
                    objPackage.Notes = memo
                End If
                objPackage.Update()
                objPack.Update()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
            Return objPackage
        End Function
        ''' <summary>
        ''' Add a new UML element instead of an ArchiMate MDG item
        ''' </summary>
        ''' <param name="name">Name of the element hat will be creayed</param>
        ''' <param name="objecttype">Object type in the UML notation for the element to  create</param>
        ''' <returns></returns>
        Public Function AddUMLElement(ByVal name As String, ByVal objecttype As String) As EA.Element
            Dim objPack As EA.Package
            Dim objElement As EA.Element
            Try
                If Me.Package_Id.Contains("{") Then
                    objPack = _Repository.GetPackageByGuid(Me.Package_Id)
                Else
                    objPack = _Repository.GetPackageByID(Convert.ToInt32(Me.Package_Id))
                End If
                objElement = objPack.Elements.AddNew(name, objecttype)
                objElement.Update()
                objPack.Update()
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return objElement
        End Function

        ''' <summary>
        ''' Find a package by name
        ''' </summary>
        ''' <param name="name">Name to search for</param>
        ''' <returns>The found package or nothing</returns>
        Public Function FindPackage(ByVal name As String) As EA.Package
            Dim objPack As EA.Package
            Try
                Dim strSql As String
                strSql = String.Format("SELECT package_id FROM t_package WHERE name = '{0}' ", Strings.Trim(name))
                Dim objDT As DataTable
                objDT = DLA2EAHelper.SQL2DataTable(strSql, Me.Repository)
                If objDT.Rows.Count = 1 Then
                    objPack = Me.Repository.GetPackageByID(objDT.Rows(0).Item("package_id"))
                Else
                    objPack = Nothing
                End If
            Catch ex As Exception
                fouten += "Fout in FindPackage" & ex.Message & vbCrLf
            End Try
            Return objPack
        End Function

        ''' <summary>
        ''' Search or add an element by name and stereotype
        ''' </summary>
        ''' <param name="name">Name of the element</param>
        ''' <param name="stereotype">Stereotype</param>
        ''' <param name="Found">Element found (true) or added (false)</param>
        ''' <returns>Element found or added</returns>
        Public Function FindOrAddElement(ByVal name As String, ByVal stereotype As String, ByRef Found As Boolean) As EA.Element

            Return Me.FindOrAddElement(name, stereotype, Found, "")
        End Function
        ''' <summary>
        ''' Find or add an element including a memo
        ''' </summary>
        ''' <param name="name">Name of the element</param>
        ''' <param name="stereotype">Stereotype</param>
        ''' <param name="Found">Element found (true) or added (false)</param>
        ''' <param name="memo">Memo with a description of the element</param>
        ''' <returns>Element found or added</returns>
        Public Function FindOrAddElement(ByVal name As String, ByVal stereotype As String, ByRef Found As Boolean, ByVal memo As String) As EA.Element
            Dim objElement As EA.Element
            objElement = Me.FindElement(Strings.Trim(name), stereotype, Found)
            If Found = False And name.Length > 0 Then
                objElement = Me.AddElement(stereotype, Strings.Trim(name), memo)
                Found = True
            End If
            Me.objLastElement = objElement
            Return objElement
        End Function
        ''' <summary>
        ''' Find or add a package based on the name use this call when a memo is available
        ''' </summary>
        ''' <param name="name"></param>
        ''' <param name="Found"></param>
        ''' <param name="memo"></param>
        ''' <returns></returns>
        Public Function FindOrAddPackage(ByVal name As String, ByRef Found As Boolean, ByVal memo As String) As EA.Package
            Dim objPackage As EA.Package
            objPackage = Me.FindPackage(Strings.Trim(name), Found)
            If Found = False And name.Length > 0 Then
                objPackage = Me.AddPackage(name, memo)
                Found = True
            End If
            Return objPackage
        End Function
        ''' <summary>
        ''' Search for an element by name and stereotype
        ''' </summary>
        ''' <param name="name">Name of the element</param>
        ''' <param name="stereotype">Stereotye of the element</param>
        ''' <param name="Found">Is the element found</param>
        ''' <returns>The found element or nothing</returns>
        Public Function FindElement(ByVal name As String, ByVal stereotype As String, ByRef Found As Boolean) As EA.Element
            Dim objElement As EA.Element
            Try
                Dim strSql As String
                If stereotype.Contains("::") Then
                    Dim strSplit As String() = stereotype.Split("::")
                    stereotype = strSplit(2)
                End If
                strSql = String.Format("SELECT object_id FROM t_object WHERE (alias = '{0}' or name = '{0}')  AND stereotype = '{1}'", Strings.Trim(name.Replace("'", "''")), stereotype)
                Dim objDT As DataTable
                objDT = DLA2EAHelper.SQL2DataTable(strSql, Me.Repository)

                If Not IsNothing(objDT) Then
                    If objDT.Rows.Count > 0 Then
                        objElement = Me.Repository.GetElementByID(objDT.Rows(0).Item("object_id"))
                        Found = True
                        Return objElement
                    Else
                        Found = False
                    End If
                Else
                    Found = False
                End If
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return Nothing
        End Function

        Public Function FindConnector(ByVal source_id As String, target_id As String, connectortype As String, ByVal stereotype As String, ByRef Found As Boolean) As EA.Connector
            Dim objConnector As EA.Connector
            Try
                Dim strSql As String
                If stereotype.Contains("::") Then
                    Dim strSplit As String() = stereotype.Split("::")
                    stereotype = strSplit(2)
                End If
                strSql = String.Format("SELECT connector_id FROM t_connector WHERE start_object_id = {0} AND end_object_id = {1} AND connector_type = '{3}'  AND stereotype = '{4}'", source_id, target_id, connectortype, stereotype)
                Dim objDT As DataTable
                objDT = DLA2EAHelper.SQL2DataTable(strSql, Me.Repository)

                If Not IsNothing(objDT) Then
                    If objDT.Rows.Count > 0 Then
                        objConnector = Me.Repository.GetConnectorByID(objDT.Rows(0).Item("connector_id"))
                        Found = True
                        Return objConnector
                    Else
                        Found = False
                    End If
                Else
                    Found = False
                End If
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return Nothing
        End Function
        ''' <summary>
        ''' Find a package by name
        ''' </summary>
        ''' <param name="name">Name o search for</param>
        ''' <param name="Found">Reference parameter for a found element or not</param>
        ''' <returns></returns>
        Public Function FindPackage(ByVal name As String, ByRef Found As Boolean) As EA.Package
            Dim objPack As EA.Package
            Dim objPackage As EA.Package
            Try
                objPack = _Repository.GetPackageByID(Me.Package_Id)
                Dim strSql As String
                strSql = String.Format("SELECT package_id FROM t_package WHERE name = '{0}'  ", Strings.Trim(name.Replace("'", "''")))
                Dim objDT As DataTable
                objDT = DLA2EAHelper.SQL2DataTable(strSql, Me.Repository)

                If Not IsNothing(objDT) Then
                    If objDT.Rows.Count > 0 Then
                        objPackage = Me.Repository.GetPackageByID(objDT.Rows(0).Item("package_id"))
                        Found = True
                        Return objPackage
                    Else
                        Found = False
                    End If
                Else
                    Found = False
                End If
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return Nothing
        End Function
        ''' <summary>
        ''' Search for an element by tagged value (for keys from an external system
        ''' </summary>
        ''' <param name="name">Tagged value name</param>
        ''' <param name="value">Value to search for</param>
        ''' <returns>The found element or nothing</returns>
        Public Function FindElementByTaggedValue(ByVal name As String, ByVal value As String) As EA.Element
            Dim objPack As EA.Package
            Dim objElement As EA.Element

            Try
                objPack = _Repository.GetPackageByID(Me.Package_Id)
                Dim strSql As String
                strSql = String.Format("select t_object.object_id from t_object, t_objectproperties where t_object.Object_ID = t_objectproperties.Object_ID and t_objectproperties.Property = '{0}' and t_objectproperties.value = '{1}'", Strings.Trim(name), Strings.Trim(value))
                Dim objDT As DataTable
                objDT = DLA2EAHelper.SQL2DataTable(strSql, Me.Repository)
                If Not IsNothing(objDT) Then
                    '            And objDT.Rows.Count = 1 Then
                    objElement = Me.Repository.GetElementByID(objDT.Rows(0).Item("object_id"))
                    Return objElement
                End If
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return Nothing
        End Function

        ''' <summary>
        ''' vAdd a connector to the repository
        ''' </summary>
        ''' <param name="Source">Source object</param>
        ''' <param name="Target">Target object</param>
        ''' <param name="stereotype">Connector stereotype</param>
        ''' <returns>The added connector or nothing</returns>
        Public Function AddConnector(ByVal Source As EA.Element, ByVal Target As EA.Element, ByVal stereotype As String, Optional Direction As String = "Unspecified") As EA.Connector
            Return Me.AddConnector(Source, Target, stereotype, "", Direction)
        End Function
        ''' <summary>
        ''' Add a connector to the reposity with a connector name
        ''' </summary>
        ''' <param name="Source">Source object</param>
        ''' <param name="Target">Target object</param>
        ''' <param name="stereotype">Connector stereotype</param>
        ''' <param name="Melding">Name of the connector</param>
        ''' <returns>Added connector or nothing</returns>
        Public Function AddConnector(ByVal Source As EA.Element, ByVal Target As EA.Element, ByVal stereotype As String, ByVal Melding As String, Direction As String) As EA.Connector
            Dim objConnector As EA.Connector
            Dim blnFound As Boolean = False
            Dim strType As String
            Try
                Dim sql As String
                If Not IsNothing(Source) And Not IsNothing(Target) Then
                    If stereotype.Contains("|") Then
                        Dim strTypeStereotype As String()
                        strTypeStereotype = stereotype.Split("|")
                        strType = strTypeStereotype(0)
                        stereotype = strTypeStereotype(1)
                    Else
                        If stereotype.Contains("ArchiMa") Then
                            stereotype = "ArchiMate3::" + stereotype
                        End If
                        strType = ConvertAssociationStereotype2Type(stereotype)
                    End If
                    sql = String.Format("select t_connector.connector_id from t_connector where t_connector.stereotype LIKE '%{0}%' and t_connector.end_object_id = {1} and t_connector.start_object_id = {2} union select t_connector.connector_id from t_connector where t_connector.stereotype LIKE '%{0}%' and t_connector.end_object_id = {2} and t_connector.start_object_id = {1} ", stereotype.Replace("ArchiMate3::", ""), Source.ElementID, Target.ElementID)
                    Dim objDT As DataTable
                    objDT = DLA2EAHelper.SQL2DataTable(sql, Me.Repository)
                    If objDT.TableName = "ERROR" Then
                        objConnector = Source.Connectors.AddNew(Strings.Trim(Melding), strType)
                        objConnector.SupplierID = Target.ElementID
                        objConnector.ClientID = Source.ElementID
                        If strType <> stereotype Then
                            objConnector.Stereotype = stereotype
                        End If
                        objConnector.Direction = Direction
                        objConnector.Update()
                        Target.Update()
                        Source.Update()
                        'raarr
                        Dim strSourceType As String = "0"
                        If stereotype.Contains("Composition") Then
                            strSourceType = "2"
                        End If
                        If stereotype.Contains("Aggregation") Then
                            strSourceType = "1"
                        End If
                        If strSourceType <> "0" Then
                            Dim strUpdate As String = String.Format("Update t_connector set SourceIsAggregate = {0} where connector_id = {1} ", strSourceType, objConnector.ConnectorID)

                        End If
                    Else
                        Dim Row As DataRow = objDT.Rows(0)
                        objConnector = Repository.GetConnectorByID(Convert.ToInt32(Row("connector_id")))
                    End If
                End If
                Return objConnector
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return Nothing
        End Function

        Function CorrectArchiMateConnectors() As Boolean
            Try
                DLA2EAHelper.GetRepository().Execute("Update t_connector set SourceIsAggregate = 2 where stereotype LIKE '%ArchiMate_Composition%' ")
                DLA2EAHelper.GetRepository().Execute("Update t_connector set SourceIsAggregate = 1, direction = 'Unspecified' where stereotype LIKE '%ArchiMate_Aggregation%' ")
                Return True
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
                Return False
            End Try
        End Function
    End Class
End Namespace




