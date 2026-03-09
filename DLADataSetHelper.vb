Namespace DLAFormfactory


    ''' <summary>
    ''' Helper for working with datatables and datasets in import and export routines
    ''' </summary>
    Public Class DLADataSetHelper
        Protected DataSet As DataSet
        ''' <summary>
        ''' Create a new instance of the helper
        ''' </summary>
        Public Sub New()
            Me.DataSet = New DataSet("Conversion")
        End Sub
        ''' <summary>
        ''' Active datatable in a dataset
        ''' </summary>
        Private _DataTable As DataTable
        ''' <summary>
        ''' Set or get a datatable
        ''' </summary>
        ''' <returns></returns>
        Public Property DataTable() As DataTable
            Get
                Return _DataTable
            End Get
            Set(ByVal value As DataTable)
                _DataTable = value
            End Set
        End Property
        ''' <summary>
        ''' Convert a datatable content to a string based on a template string
        ''' </summary>
        ''' <param name="template"></param>
        Public Function DataTable2String(ByVal template As String) As String
            Dim objRow As DataRow
            Dim objColumn As DataColumn
            Dim strTotal As String = ""
            Try
                For Each objRow In Me.DataTable.Rows
                    Dim strRegel As String = template
                    For Each objColumn In DataTable.Columns
                        Dim strValue As String = objRow.Item(objColumn)
                        strValue = strValue.Replace("'", "''")
                        'strValue = strValue.Replace("'''", "''")
                        strRegel = strRegel.Replace("#[" + objColumn.ColumnName.ToLower + "]#", strValue)
                    Next
                    If strRegel.IndexOf("#[") > 0 Then
                        While strRegel.IndexOf("#[") > 0
                            Dim strEerste As String = strRegel.Substring(0, strRegel.IndexOf("#["))
                            Dim strLaatste As String = strRegel.Substring(strRegel.IndexOf("]#") + 2)
                            strRegel = strEerste + "NULL" + strLaatste
                        End While
                    End If
                    strTotal += strRegel + vbCrLf + vbCrLf
                Next
                strTotal = strTotal.Replace("'NULL'", " NULL ")
                Return strTotal
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return ""

        End Function
    End Class
End Namespace
