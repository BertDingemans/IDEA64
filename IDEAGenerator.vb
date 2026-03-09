Imports System.Windows.Forms
Imports System.Xml
Imports System.IO
Imports IDEA.DLAFormfactory

''' <summary>
''' Generating elements from one layer to the other (CDM - LDM - FDM) These are
''' complex transformations tha tcan be modified when relevant. Important is to
''' consider that these routines are based on the IDEA screens. In the scripts in
''' the sample repository there are differences in implementation.
''' </summary>
Public Class IDEAGenerator
    Private Repository As EA.Repository = DLA2EAHelper.GetRepository()

    ''' <summary>
    ''' create a connector in the EA repository
    ''' </summary>
    ''' <param name="Source">Source object</param>
    ''' <param name="Target">Target Object</param>
    ''' <param name="Type">Type of connector</param>
    ''' <returns></returns>
    Public Function CreateConnector(ByVal Source As EA.Element, ByVal Target As EA.Element, ByVal Type As String) As Boolean
        Dim objCon As EA.Connector
        objCon = Source.Connectors.AddNew(Type, Type)
        objCon.SupplierID = Source.ElementID
        objCon.ClientID = Target.ElementID
        objCon.Direction = "Destination to Source"
        objCon.Update()
        Source.Update()
        Return True
    End Function
    ''' <summary>
    ''' Create a sample UI of a Class element
    ''' </summary>
    ''' <param name="objEle"></param>
    ''' <returns></returns>
    Public Function CopyClass2UI(ByVal objEle As EA.Element, Package_id As String, AttributeConnector As Boolean) As Integer

        Dim objNewDiagram As EA.Diagram
        Dim objDON As EA.DiagramObject
        Dim objGUI As EA.Element
        Dim objLabel As EA.Element
        Dim objAttribute As EA.Attribute
        Dim objPack As EA.Package
        Dim intX As Int32
        Dim intY As Int32
        Dim intLen As Int32
        Dim intHeight As Int32

        Dim strControl As String

        objPack = Me.Repository.GetPackageByID(Convert.ToInt32(Package_id))
        objNewDiagram = objPack.Diagrams.AddNew(objEle.Name & " User Interface", "simpleUI")
        objNewDiagram.Update()
        If AttributeConnector Then
            objDON = objNewDiagram.DiagramObjects.AddNew("", "")
            objDON.ElementID = objEle.ElementID
            objDON.top = -20
            objDON.bottom = -200
            objDON.left = 700
            objDON.right = 900
            objDON.ShowNotes = False
            objDON.Update()
        End If

        intX = 200
        intY = -20
        For Each objAttribute In objEle.Attributes
            intLen = 400
            intHeight = 25
            If Mid(objAttribute.Type, 1, 6) = "Lookup" Or objAttribute.Type.Contains("Enum") Then
                strControl = "simpleCombobox"
            ElseIf objAttribute.Type = "Date" Then
                strControl = "simpleDateTime"
                intLen = 100
            ElseIf objAttribute.Type = "Short" Or objAttribute.Type = "Long" Or objAttribute.Type = "Integer" Then
                strControl = "simpleEdit"
                intLen = 100
            ElseIf objAttribute.Type = "Boolean" Then
                strControl = "simpleCheckBox"
                intLen = 200
            ElseIf objAttribute.Type = "Memo" Then
                strControl = "simpleEdit"
                intHeight = 100
            Else
                strControl = "simpleEdit"
            End If
            Dim strLabel As String
            strLabel = Replace(objAttribute.Name, "_", " ")
            strLabel = Replace(strLabel, " id", "")
            objGUI = objPack.Elements.AddNew(objAttribute.Name, strControl)
            Dim objTV As EA.TaggedValue
            objTV = objGUI.TaggedValues.AddNew("IDEAOriginalAttribute", objAttribute.AttributeGUID)
            objTV.Value = objAttribute.AttributeGUID
            objTV.Update()
            objGUI.TaggedValues.Refresh()
            objGUI.Update()
            objLabel = objPack.Elements.AddNew(strLabel, "simpleLabel")
            objLabel.Update()

            objPack.Elements.Refresh()
            objPack.Update()
            If AttributeConnector Then
                Dim objCon As EA.Connector
                objCon = objEle.Connectors.AddNew(objAttribute.Name, "")
                objCon.SupplierID = objEle.ElementID
                objCon.ClientID = objGUI.ElementID
                objCon.Direction = "Destination to Source"
                objCon.StyleEx = "LFEP=" & objAttribute.AttributeGUID & "L;"
                objCon.Update()
            End If

            objDON = objNewDiagram.DiagramObjects.AddNew("", "")
            objDON.ElementID = objGUI.ElementID
            objDON.top = intY
            objDON.bottom = (intY - intHeight)
            objDON.left = 155
            objDON.right = 155 + intLen
            objDON.Update()

            objDON = objNewDiagram.DiagramObjects.AddNew("", "")
            objDON.ElementID = objLabel.ElementID
            objDON.top = intY
            objDON.bottom = (intY - intHeight)
            objDON.left = 20
            objDON.right = 150
            intY = intY - (intHeight + 5)
            objDON.Update()
            objNewDiagram.DiagramObjects.Refresh()
            objNewDiagram.Update()
        Next
        Return objNewDiagram.DiagramID
    End Function

    ''' <summary>
    ''' Refactor an asssociation and move it together with an attribute to a new class
    ''' </summary>
    ''' <param name="oldElement"></param>
    ''' <param name="newElement"></param>
    ''' <param name="AttributeID"></param>
    ''' <returns></returns>
    Public Function RefactorAssociation(ByVal oldElement As EA.Element, ByVal newElement As EA.Element, ByVal AttributeID As String) As Boolean
        Dim oConnector As EA.Connector
        Dim oAttribute As EA.Attribute
        Try
            oAttribute = Repository.GetAttributeByID(AttributeID)
            For Each oConnector In oldElement.Connectors
                If oConnector.StyleEx.Contains(oAttribute.AttributeGUID) Then
                    If oConnector.ClientID = oldElement.ElementID Then
                        oConnector.ClientID = newElement.ElementID
                    Else
                        oConnector.SupplierID = newElement.ElementID
                    End If
                    oConnector.Update()
                End If
            Next
            oldElement.Update()
            newElement.Update()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Copy an attribute from one class to antother
    ''' </summary>
    ''' <param name="objSource"></param>
    ''' <param name="objTarget"></param>
    ''' <param name="strType"></param>
    ''' <param name="strAttributeId"></param>
    ''' <param name="blnCreateAssociation"></param>
    ''' <returns></returns>
    Public Function CopyAttribute(ByVal objSource As EA.Element, ByVal objTarget As EA.Element, ByVal strType As String, ByVal strAttributeId As String, ByVal blnCreateAssociation As Boolean) As EA.Attribute
        Return CopyAttribute(objSource, objTarget, strType, strAttributeId, blnCreateAssociation, "Destination -> Source")
    End Function
    ''' <summary>
    ''' Copy an attribute from one class to antother
    ''' </summary>
    ''' <param name="objSource"></param>
    ''' <param name="objTarget"></param>
    ''' <param name="strType"></param>
    ''' <param name="strAttributeId"></param>
    ''' <param name="blnCreateAssociation"></param>
    ''' <param name="strDirection"></param>
    ''' <returns></returns>
    Public Function CopyAttribute(ByVal objSource As EA.Element, ByVal objTarget As EA.Element, ByVal strType As String, ByVal strAttributeId As String, ByVal blnCreateAssociation As Boolean, ByVal strDirection As String) As EA.Attribute

        Dim objAttribute As EA.Attribute
        Dim objColumn As EA.Attribute
        Dim strAttribute As String
        Select Case objTarget.Stereotype.ToUpper()
            Case "TABLE"
                strAttribute = "Column"
            Case "XSDCOMPLEXTYPE"
                strAttribute = "XSDelement"
            Case Else
                strAttribute = ""
        End Select

        objAttribute = Repository.GetAttributeByID(strAttributeId)
        objColumn = objTarget.Attributes.AddNew(objAttribute.Name, strAttribute)
        objColumn.AllowDuplicates = objAttribute.AllowDuplicates
        objColumn.LowerBound = objAttribute.LowerBound
        objColumn.AllowDuplicates = False
        objColumn.Notes = objAttribute.Notes
        objColumn.IsID = objAttribute.IsID
        objColumn.Pos = objAttribute.Pos
        objColumn.Type = Attribute2Column(objAttribute, objColumn, objSource, objTarget)

        objColumn.Visibility = "Private"
        objColumn.Stereotype = strAttribute
        'database specific columntype handling
        If objTarget.Stereotype.ToUpper() = "TABLE" Then
            If objColumn.Type.Contains("varchar") Then
                objColumn.Length = 100
            End If
            If objAttribute.IsID Then
                Me.CreatePrimaryKey(objTarget, objColumn)
                objColumn.IsOrdered = True
            End If
            If objAttribute.LowerBound = "1" Then
                objColumn.AllowDuplicates = False
            End If
        End If
        objColumn.Update()
        objTarget.Update()
        If blnCreateAssociation Then
            Me.CreateConnectorForAttribute(objAttribute, objColumn, strDirection, True, "")
        End If
        Return objColumn
    End Function

    ''' <summary>
    ''' Create a primary key column for the transformation to the database structure
    ''' </summary>
    ''' <param name="Table"></param>
    ''' <param name="Column"></param>
    Private Sub CreatePrimaryKey(Table As EA.Element, Column As EA.Attribute)
        Try
            Dim oOperation As EA.Method
            oOperation = Table.Methods.AddNew("PK_" & Table.Name, "")
            oOperation.Stereotype = "PK"
            Dim oPara As EA.Parameter
            oOperation.Update()
            oPara = oOperation.Parameters.AddNew(Column.Name, Column.Type)
            oPara.Kind = "in"
            oPara.Update()
            Table.Update()
        Catch ex As Exception
            DLAFormfactory.DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Create a connector (mapping for an attribute)
    ''' </summary>
    ''' <param name="objSource"></param>
    ''' <param name="objTarget"></param>
    ''' <param name="strDirection"></param>
    ''' <param name="blnName"></param>
    ''' <param name="strStereotype"></param>
    ''' <param name="linestyle"></param>
    Public Sub CreateConnectorForAttribute(ByVal objSource As EA.Attribute, ByVal objTarget As EA.Attribute, ByVal strDirection As String, ByVal blnName As Boolean, ByVal strStereotype As String, Optional ByVal linestyle As EA.LinkLineStyle = EA.LinkLineStyle.LineStyleDirect)
        Dim objCon As EA.Connector
        Dim objEle As EA.Element
        Dim strNaam As String = ""
        If blnName = True Then
            strNaam = objSource.Name
        End If

        objEle = Repository.GetElementByID(objSource.ParentID)
        objCon = objEle.Connectors.AddNew(strNaam, "")
        objCon.SupplierID = objSource.ParentID
        If strStereotype.Length > 0 Then
            objCon.Stereotype = strStereotype
        End If
        objCon.ClientID = objTarget.ParentID
        objCon.Direction = strDirection
        objCon.StyleEx = "LFEP=" & objSource.AttributeGUID & "L;LFSP=" & objTarget.AttributeGUID & "R;"
        'objCon.LineStyle = linestyle
        objCon.Update()

    End Sub
    ''' <summary>
    ''' Routine for creating columns in a PDM from a class attribute in a LDM
    ''' </summary>
    ''' <param name="objAttribute"></param>
    ''' <param name="objTargetAttribute"></param>
    ''' <param name="objSource"></param>
    ''' <param name="objTarget"></param>
    ''' <returns></returns>
    Private Shared Function Attribute2Column(ByVal objAttribute As EA.Attribute, objTargetAttribute As EA.Attribute, ByVal objSource As EA.Element, ByVal objTarget As EA.Element) As String
        Dim strRet As String = "Variant"
        Dim intTeller As Int16
        Dim VBNet As String = "String, String,Date,Long,Integer,Double,Boolean,DateTime,Decimal,Memo"
        Dim SQLServer As String = "varchar, nvarchar,date,number,int,number,bit,datetime,decimal,text"
        Dim PostgreSQL As String = "varchar, varchar,date,decimal,integer,double precision,boolean,datetime,decimal,text"
        Dim XSD As String = "string, string,date,long,int,double,boolean,dateTime,decimal"
        Dim SourceArray As String()
        Dim TargetArray As String()
        Try
            Select Case objSource.Stereotype.ToUpper()
                Case "TABLE"
                    If objSource.Gentype.ToUpper().Contains("POSTGRE") Then
                        SourceArray = PostgreSQL.Replace(" ", "").Split(",")
                    Else
                        SourceArray = SQLServer.Replace(" ", "").Split(",")
                    End If
                Case "XSDCOMPLEXTYPE"
                    SourceArray = XSD.Replace(" ", "").Split(",")
                Case Else
                    SourceArray = VBNet.Replace(" ", "").Split(",")
            End Select

            Select Case objTarget.Stereotype.ToUpper()
                Case "TABLE"
                    If objTarget.Gentype.ToUpper().Contains("POSTGRE") Then
                        TargetArray = PostgreSQL.Replace(" ", "").Split(",")
                    Else
                        TargetArray = SQLServer.Replace(" ", "").Split(",")
                    End If

                    strRet = "sql_variant"
                Case "XSDCOMPLEXTYPE"
                    TargetArray = XSD.Replace(" ", "").Split(",")
                    strRet = "anyType"
                Case Else
                    TargetArray = VBNet.Replace(" ", "").Split(",")
                    strRet = "Variant"
            End Select

            intTeller = 0
            While intTeller <= UBound(SourceArray)
                Dim strType As String = objAttribute.Type.ToUpper()
                If strType.Contains("LOOKUP") Then
                    strType = "INTEGER"
                ElseIf strType.Contains("ENUM") Then
                    strType = "STRING"
                End If
                If SourceArray(intTeller).ToUpper() = strType Then
                    strRet = TargetArray(intTeller)
                End If
                intTeller += 1
            End While
            '           objTargetAttribute.Type = strRet
            Return strRet
        Catch ex As Exception
            DLAFormfactory.DLA2EAHelper.Error2Log(ex)
        End Try
        Return ""
    End Function

    ''' <summary>
    ''' Create an element in the repository based on the name and the type
    ''' </summary>
    ''' <param name="strName"></param>
    ''' <param name="strType"></param>
    ''' <param name="intPackage">Package id where to add the newly created element</param>
    ''' <returns></returns>
    Public Function CreateElement(ByVal strName As String, ByVal strType As String, ByVal intPackage As Integer) As EA.Element
        Dim objPack As EA.Package
        Dim objNew As EA.Element
        objPack = Me.Repository.GetPackageByID(intPackage)
        Select Case strType.ToUpper()
            Case "INTERFACE"
                objNew = objPack.Elements.AddNew(strName, "Interface")
                '               objNew.Notes = 
                objNew.Gentype = "VBNet"
            Case "CLASS"
                objNew = objPack.Elements.AddNew(strName, "Class")
                '              objNew.Notes = "Copy from table to class by script"
                objNew.Gentype = "VBNet"
            Case "XSD"
                objNew = objPack.Elements.AddNew(strName, "Class")
                '                objNew.Notes = "Copy from class to table by script"
                'objNew.Gentype = "SQL Server 2012"
                objNew.Type = "Class"
                objNew.Stereotype = "XSDcomplexType"
            Case "TABLE"
                objNew = objPack.Elements.AddNew(strName, "EAUML::table")
                '              objNew.Notes = "Copy from class to table by script"
                objNew.Gentype = "SQL Server 2012"
                objNew.Type = "Class"
                objNew.Stereotype = "table"
            Case "ARCHIMATE_BUSINESSOBJECT"
                objNew = objPack.Elements.AddNew(strName, "ArchiMate3::ArchiMate_BusinessObject")
            Case "ARCHIMATE_DATAOBJECT"
                objNew = objPack.Elements.AddNew(strName, "ArchiMate3::ArchiMate_DataObject")

        End Select
        objNew.Update()
        objPack.Update()
        Return objNew
    End Function

    ''' <summary>
    ''' Create a trace association between two elements in different XDM layers
    ''' </summary>
    ''' <param name="objEle"></param>
    ''' <param name="objNew"></param>
    Public Sub CreateTraceAssociation(ByVal objEle As EA.Element, ByVal objNew As EA.Element)
        Dim objCon As EA.Connector
        objCon = objEle.Connectors.AddNew(objEle.Name & " to " & objNew.Name, "trace")
        objCon.SupplierID = objEle.ElementID
        objCon.ClientID = objNew.ElementID
        objCon.Direction = "Source -> Destination"
        objCon.Update()
        objEle.Update()
    End Sub

    ''' <summary>
    ''' Copy an association
    ''' </summary>
    ''' <param name="oldConnection"></param>
    ''' <param name="objEle"></param>
    ''' <param name="objNew"></param>
    ''' <returns></returns>
    Public Function CopyAssociation(oldConnection As EA.Connector, ByVal objEle As EA.Element, ByVal objNew As EA.Element, Optional FullCopy As Boolean = True) As EA.Connector
        Dim objCon As EA.Connector
        Try
            objCon = objEle.Connectors.AddNew(oldConnection.Name, oldConnection.Type)
            objCon.SupplierID = objEle.ElementID
            objCon.ClientID = objNew.ElementID
            objCon.ClientEnd.Cardinality = oldConnection.ClientEnd.Cardinality
            objCon.SupplierEnd.Cardinality = oldConnection.SupplierEnd.Cardinality

            If FullCopy Then
                objCon.Direction = oldConnection.Direction
                objCon.ClientEnd.Role = oldConnection.ClientEnd.Role
                objCon.SupplierEnd.Role = oldConnection.SupplierEnd.Role
                objCon.Notes = oldConnection.Notes
            Else
                objCon.Direction = "Unspecified"
                'This one should be made empty going from table 2 class
                objCon.Name = ""
            End If
            objCon.Update()
            objEle.Update()
            Return objCon
        Catch ex As Exception
            DLAFormfactory.DLA2EAHelper.Error2Log(ex)
        End Try
        Return Nothing
    End Function
    ''' <summary>
    ''' Move an attribute from one element to the other for refactoring
    ''' </summary>
    ''' <param name="attribute_id"></param>
    ''' <param name="target_id"></param>
    Public Sub RefactorAttribute(ByVal attribute_id As String, ByVal target_id As String)
        Dim strSQL As String
        strSQL = String.Format("UPDATE t_attribute SET object_id = {0} WHERE id = {1} ", target_id, attribute_id)
        Me.Repository.Execute(strSQL)
    End Sub
End Class

