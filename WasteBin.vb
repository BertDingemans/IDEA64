
Namespace DLAFormfactory
    ''' <summary>
    ''' Class for handling wastebin routines when a user deletes an item from the repository
    ''' </summary>
    Public Class WasteBin
        ''' <summary>
        ''' Copy an element to the wastebin before we delete it from the repository
        ''' </summary>
        ''' <param name="Repository"></param>
        ''' <param name="strEntityId"></param>
        ''' <returns></returns>
        Public Shared Function WasteBinElement(Repository As EA.Repository, strEntityId As String) As Boolean
            Dim oElement As EA.Element
            Dim intPackage_id As Int32 = GetWasteBinPackage_id()
            Try
                If intPackage_id <> -999 Then
                    oElement = Repository.GetElementByID(Convert.ToInt32(strEntityId))
                    If oElement.PackageID <> intPackage_id Then
                        Dim oClone = oElement.Clone()
                        oClone.PackageID = intPackage_id
                        oClone.Name = oElement.Name + " (Del)"
                        oClone.Status = "Deleted"
                        oClone.Update()
                        Return True
                    Else
                        Return DeleteFromWasteBin(Repository)
                    End If
                Else
                    Return True
                End If
                Return True
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return False
        End Function
        ''' <summary>
        ''' Can the user delete an element from the wastebin when the user is authorized
        ''' </summary>
        ''' <param name="Repository"></param>
        ''' <returns></returns>
        Private Shared Function DeleteFromWasteBin(Repository As EA.Repository) As Boolean
            Return DLA2EAHelper.IsUserGroupMember(Repository, "Administrators")
        End Function
        ''' <summary>
        ''' Delete a package but copy a clone before the delete to the wastebin package
        ''' </summary>
        ''' <param name="Repository"></param>
        ''' <param name="strEntityId"></param>
        ''' <returns></returns>
        Public Shared Function WasteBinPackage(Repository As EA.Repository, strEntityId As String) As Boolean
            Dim oPackage As EA.Package
            Try
                Dim intPackage_id As Int32 = GetWasteBinPackage_id()
                If intPackage_id <> -999 Then
                    oPackage = Repository.GetPackageByID(Convert.ToInt32(strEntityId))
                    If oPackage.ParentID <> intPackage_id Then
                        Dim oClone As EA.Package
                        oClone = oPackage.Clone
                        oClone.ParentID = intPackage_id
                        oClone.Name = oPackage.Name + " (Del)"
                        oClone.Update()
                        Return True
                    Else
                        Return DeleteFromWasteBin(Repository)
                    End If
                End If
                Return True
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return False
        End Function
        ''' <summary>
        ''' retrieve the package id from the settings
        ''' when the id is -999 the wastebin package is not defined
        ''' </summary>
        ''' <returns></returns>
        Shared Function GetWasteBinPackage_id() As Int32
            Dim oDef As New IDEADefinitions()
            Dim strPackage_id As String
            Dim intPackage_id As Int32 = -999
            strPackage_id = oDef.GetSettingValue("WasteBinPackage_id")
            If strPackage_id.Length > 0 And strPackage_id <> "-999" And Not strPackage_id.Contains("{") Then
                intPackage_id = Convert.ToInt32(strPackage_id)
            End If
            Return intPackage_id
        End Function
    End Class

End Namespace
