Imports System.Data.SqlClient

Module Module1
    Dim cmd As SqlCommand = New SqlCommand
    Dim db As New DataClasses1DataContext

    Dim dbcont As Integer = 0

    Public SERVERCONNECTION As String = ""
    Public con As String = getconnection()
    Public Qconn As New SqlConnection(con)
    Public objcommon As New clsCommonMethods

    'Public LoginMODE As String = ""
    Public listcompoind, listname, listdob, list_name, listmname, listlname, listsex, listinvidividid, listEthnic, searchcompound As String
    Public patient As String
    Public expintdate As Date
    Public list_DOB As Date
    Public Cuser As String
    Public C_patient As String = ""


    Public Visit_ID As Integer = 0
    Private dssID As String = Nothing
    Private IndividID As String

    Public txt_id As String
    Public btn_submit1 As Button
    Public btn_update1 As Button


    Public Function READLOCATION()
        If System.IO.File.Exists("C:\SYS.CONFIG\WindowsApp1.txt") Then
            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader("C:\SYS.CONFIG\WindowsApp1.txt")
            SERVERCONNECTION = fileReader.ReadLine()
            fileReader.Close()
        End If
    End Function

    Public Function getconnection()
        READLOCATION()
        con = My.MySettings.Default.washprojectConnectionString
        Return con
    End Function

    Public Sub OpenCon()
        If Qconn.State = ConnectionState.Closed Then
            Qconn.Open()
        End If
    End Sub

    Public Sub CloseCon()
        If Qconn.State = ConnectionState.Open Then
            Qconn.Close()
        End If
    End Sub

    Public Sub FillMyGrid(ByVal gridName As DataGridView, ByVal sql As String)
        OpenCon()
        Try
            Dim grdDA As New SqlDataAdapter(sql, Qconn)
            Dim grdDT As New DataTable
            grdDA.Fill(grdDT)
            gridName.DataSource = grdDT
            gridName.Refresh()
        Catch ex As Exception
            MsgBox("ERROR Description: " & ex.Message)
            Exit Sub
        End Try
        With gridName
            .RowsDefaultCellStyle.BackColor = Color.Snow
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
        End With
    End Sub

    'nagumba start
    Public Class clsManageQueue
        Public Function CheckPatientIfInQueueAndPending(ByVal ptnID As String)
            'GetdssID = ptnID.ToString
            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            db.Connection.Open()

            Try
            Catch ex As Exception
                MsgBox("system error in validating the patient's clinic attendance " + ex.Message)
            Finally
                db.Connection.Close()
            End Try

            Return dbcont
            Windows.Forms.Cursor.Current = Cursors.Default
        End Function

    End Class

    Public Property GetdssID As String
        Get
            Return dssID
        End Get
        Set(ByVal value As String)
            dssID = value
        End Set
    End Property

    Public Sub GetMyMANAGER1(ByVal P_ID As String)
        Dim myQuery As String = Nothing
        objcommon.setIndividID = P_ID

        Try

            OpenCon()

            myQuery = " select  [Visit_ID]
                          ,[DSS_ID]
                          ,[COMPOUNDID]
                          ,[NAME]
                          ,[MNAME]
                          ,[LNAME]
                          ,[DOB]
                          ,[GENDER]
                          ,[SECTION1]
                          ,[SECTION2]
                          ,[RESP_STATUS]
                          ,[BARCODES]
                          ,[category]
                          ,[status]
                          ,[Rec_Date]
                          ,[officer]
                          ,[interviewdate]  FROM [washproject].[dbo].[queue]  WHERE  DSS_ID = '" & objcommon.setIndividID & "' and status = 'NO'"


            Dim cmd As New SqlCommand(myQuery, Qconn)
            Dim Pdr As SqlDataReader = cmd.ExecuteReader
            If Pdr.HasRows Then
                While Pdr.Read

                    '  Select Case QLocation
                    '-  Case "lwak"

                    Visit_ID = Pdr.Item("Visit_ID")

                End While

                Pdr.Close()
            End If
        Catch ex As Exception
            MsgBox("error in fetching VISIT_ID " + ex.Message)
            Exit Sub
        Finally
            CloseCon()
        End Try
    End Sub

    Public Class clsCommonMethods
        Public Property setIndividID As String
            Get
                Return dssID
            End Get
            Set(ByVal value As String)
                dssID = value
            End Set
        End Property
    End Class
    'nagumba end

    Public Sub msgError(ByVal msg As String)
        MsgBox(msg, MsgBoxStyle.Critical, Application.ProductName)
    End Sub
    Public Sub msgWarn(ByVal msg As String)
        MsgBox(msg, MsgBoxStyle.Exclamation, Application.ProductName)
    End Sub
    Public Sub msgSuccess(ByVal msg1 As String)
        MsgBox(msg1, MsgBoxStyle.Information, Application.ProductName)
    End Sub
    Public Sub msgYesNo(ByVal msg2 As String)
        MsgBox(msg2, MsgBoxStyle.OkCancel, Application.ProductName)
    End Sub
End Module
