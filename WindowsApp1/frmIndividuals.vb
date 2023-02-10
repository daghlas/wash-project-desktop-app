Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports Microsoft.VisualBasic.ApplicationServices

Public Class frmIndividuals
    Dim db As New DataClasses1DataContext
    Dim ptnCheck As Integer = 0
    Dim objQueue As New clsManageQueue

    Dim duplication As String

    Public Sub QueuePatient()
        'initialise system values
        SystemQueueInitialise()
        ptnCheck = objQueue.CheckPatientIfInQueueAndPending(C_patient) 'check if patient exist

        'ptnCheck = CountOpenIstances(C_patient)



        If ptnCheck > 0 Then
            MsgBox(C_patient & " has an open file. " & vbNewLine & "Please check the previous survey records and complete appropriately!")
            Exit Sub
        Else
            Try
                db.ManageQueue(listcompoind, list_name, listmname, listlname, listdob, listsex, listEthnic, patient, C_patient, expintdate, Cuser)
                MsgBox("Participant successfully queued for Survey!")
                GetMyMANAGER1(C_patient)

                frmWASH.Show()
                Me.Hide()
                frmWater_assesment.Close()

            Catch eex As Exception
                msgError(eex.Message)
            End Try
        End If

    End Sub

    Private Sub SystemQueueInitialise()
        C_patient = listinvidividid
    End Sub

    Private Sub cmdQueue_Click(sender As Object, e As EventArgs) Handles cmdQueue.Click

        GetQueue(listinvidividid)
        If Not duplication = "" Then
            msgError(listname & " " & listmname & " of ID " & listinvidividid & " has an open file. " & vbNewLine &
                    "Check previous records")
            If MsgBox((listname & " " & listmname & " of ID " & listinvidividid & vbNewLine &
                "Edit previous records?"), MsgBoxStyle.YesNo, Application.ProductName) = DialogResult.Yes Then
                frmWASH.Show()
                frmWater_assesment.Close()
                Exit Sub
            End If
        Else
            QueuePatient()
        End If
    End Sub

    Private Sub dtgvill_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgvill.Click
        Try
            Dim r As String = Me.dtgvill.CurrentRow.Cells("village code").Value 'village code
            Dim svillage As String = ""
            svillage = r

            FillMyGrid(DataGridView2, "SELECT distinct locationid , [socialgpid],HHFNAME,HHMNAME, HHLNAME, isnull([consent],'YES')[consent],village,c FROM [dbo].[individual]
                                            a left outer join [washproject].[dbo].[hhsection] b on a. locationid = b.hhid where locationid ! = ''  and VILLAGE='" & r & "' 
                                              order by village,c ") 'populate listview


        Catch ex As Exception
            msgError(ex.Message)
        End Try

    End Sub

    Private Sub frmIndividuals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT   VILLCODE as 'village code', VILLNAME as 'village name' FROM village ORDER BY VILLCODE ASC"
        FillMyGrid(Me.dtgvill, query)
        cmdQueue.Enabled = False
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim searchcompound As String
        Dim sqlstring = ""

        searchcompound = Me.DataGridView2.CurrentRow.Cells("locationid").Value
        sqlstring = "SELECT [INDIVIDID],[locationid] LOCATIONID,SOCIALGPID,[NAME],[MNAME],[LNAME],[GENDER],[ETHNIC],cast([DOB] as date)DOB FROM dbo.individual WHERE  locationid ='" + searchcompound + "'"

        FillMyGrid(DataGridView1, sqlstring)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        listcompoind = ""
        listname = ""
        listdob = ""
        list_name = ""
        listmname = ""
        listlname = ""
        listsex = ""
        listinvidividid = ""
        list_DOB = "1990-10-10"
        listEthnic = ""

        If DataGridView1.Rows.Count > 0 Then
            listcompoind = Me.DataGridView1.CurrentRow.Cells("locationid").Value
            list_name = Me.DataGridView1.CurrentRow.Cells("NAME").Value
            listdob = Me.DataGridView1.CurrentRow.Cells("DOB").Value
            listname = Me.DataGridView1.CurrentRow.Cells("NAME").Value
            listmname = Me.DataGridView1.CurrentRow.Cells("MNAME").Value
            listlname = Me.DataGridView1.CurrentRow.Cells("LNAME").Value
            listsex = Me.DataGridView1.CurrentRow.Cells("GENDER").Value
            listinvidividid = Me.DataGridView1.CurrentRow.Cells("INDIVIDID").Value
            listEthnic = Me.DataGridView1.CurrentRow.Cells("ETHNIC").Value

        End If

        cmdQueue.Enabled = True
    End Sub

    Public Sub GetQueue(Barcode As String)
        OpenCon()
        Dim SQL As String = "SELECT ltrim(rtrim([DSS_ID])) as DSS_ID 
            FROM [washproject].[dbo].[queue] 
                WHERE ltrim(rtrim([DSS_ID])) = '" & listinvidividid.Trim & "'"
        Dim cmd As New SqlCommand(SQL, Qconn)
        Dim rDR As SqlDataReader = cmd.ExecuteReader


        duplication = ""

        While rDR.Read
            duplication = rDR.Item("DSS_ID")
        End While
        CloseCon()
        rDR.Close()
    End Sub
End Class