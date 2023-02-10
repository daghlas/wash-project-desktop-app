Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.Form
Imports System.Security
Public Class frmsearchutility
    Private nxtid As Integer = 1
    Dim ptnCheck As Integer = 0
    Dim ptnAdd As Integer = 0
    'instantiate a new class
    Dim objQueue As New clsManageQueue
    Dim objCommon As New clsCommonMethods
    Dim Found As Boolean = False
    Dim db As New DataClasses1DataContext
    Dim dupcheck As String = ""


    Private Sub SystemQueueInitialise2()

        Select Case chkChange.Checked 'check if the selection has been done correctly
            Case True
                If chkAdult.Checked = False And Me.chkchild.Checked = False Then
                    msgError("You must make a selection when change category is selected!")
                    Exit Sub
                End If
            Case False

        End Select
        C_patient = listinvidividid 'set current patient
        Dim rowVal As String = listinvidividid 'create a code to queue patients in line
    End Sub


    Private Sub ContextMenuHandler(ByVal Sender As Object, ByVal e As EventArgs)
        ''  Dim fload As New frmNewBorn
        'Dim mi As MenuItem = DirectCast(Sender, MenuItem)

    End Sub





    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetMyconfig()
        Dim ctx As New ContextMenu
        Dim i1 As New MenuItem("Add NewNorn")
        AddHandler i1.Click, AddressOf ContextMenuHandler
        ctx.MenuItems.Add(i1)
        Me.DataGridView1.ContextMenu = ctx
        dtpDOB.MaxDate = Now.Date

        If LoginMODE = "KAP" Then
            Button3.Visible = False
        End If


        'If LoginMODE = "Express" Then
        '    Label11.Visible = True
        '    TextBox1.Visible = True
        '    DateTimePicker2.Visible = True
        '    DateTimePicker2.MaxDate = Now.Date
        '    TextBox1.Text = ""
        'End If

        Me.MdiParent = mdiSERO

        ' disable controls
        Me.cmdsearch.Enabled = True
        Me.cmdQueue.Enabled = False
        Me.chkchild.Enabled = False
        Me.chkAdult.Enabled = False
        Me.chkChange.Enabled = False
        Dim SQL As String
        SQL = "SELECT villcode as 'village code',villname as 'village NAME' FROM [settings].[villages] ORDER BY villcode ASC"
        QLocation = Interview_location

        Select Case QLocation
            Case "lwak"
                ''Label2.Visible = True
                DataGridView2.Visible = True
                dtgvill.Visible = True
                '
                pic_Image.Visible = False
                cmd_Go.Visible = True
                GroupBox2.Visible = False
                CheckBox1.Visible = True
                txtLocation.Enabled = True
                txtSublocation.Enabled = True
                txtLocation.Visible = True
                txtSublocation.Visible = True
                cbCluster.Enabled = False
                cbVillage.Enabled = False
                txtOtherSpecify.Enabled = False
                cbCluster.Visible = False
                cbVillage.Visible = False
                txtOtherSpecify.Visible = False

                Label10.Text = "Sublocation"
                Label15.Text = "Village"
                FillMyGrid(Me.dtgvill, SQL)


            Case "kibera"
                'Label2.Text = "patient care system | Non-Surveillance Demorgraphic Information"
                DataGridView2.Visible = True
                dtgvill.Visible = True
                '  Label3.Visible = True
                ' txt_uniqueId.Visible = True
                pic_Image.Visible = True
                cmd_Go.Visible = True
                GroupBox2.Visible = False
                CheckBox1.Visible = True

                txtLocation.Enabled = False
                txtSublocation.Enabled = False
                txtLocation.Visible = False
                txtSublocation.Visible = False
                cbCluster.Enabled = True
                cbVillage.Enabled = True
                txtOtherSpecify.Enabled = True
                cbCluster.Visible = True
                cbVillage.Visible = True
                txtOtherSpecify.Visible = True
                Label10.Text = "Village"
                Label15.Text = "Cluster"
                '  SQL = "SELECT [villcode] AS 'CLUSTER',[villname]AS 'CLUSTER NAME' FROM [PCS].[kibera].[Clusters] order by cast ([villcode] as int)"
                FillMyGrid(Me.dtgvill, SQL)

            Case "manyatta"
                'Label2.Text = "patient care system | Non-Surveillance Demorgraphic Information"
                DataGridView2.Visible = True
                dtgvill.Visible = True
                '  Label3.Visible = True
                ' txt_uniqueId.Visible = True
                pic_Image.Visible = True
                cmd_Go.Visible = True
                GroupBox2.Visible = False
                CheckBox1.Visible = True

                txtLocation.Enabled = False
                txtSublocation.Enabled = False
                txtLocation.Visible = False
                txtSublocation.Visible = False
                cbCluster.Enabled = True
                cbVillage.Enabled = True
                txtOtherSpecify.Enabled = True
                cbCluster.Visible = True
                cbVillage.Visible = True
                txtOtherSpecify.Visible = True
                Label10.Text = "Village"
                Label15.Text = "Cluster"
                '  SQL = "SELECT [villcode] AS 'CLUSTER',[villname]AS 'CLUSTER NAME' FROM [PCS].[kibera].[Clusters] order by cast ([villcode] as int)"
                FillMyGrid(Me.dtgvill, SQL)
        End Select


    End Sub





    Public Sub QueuePatient()
        'initialise system values
        SystemQueueInitialise()
        ptnCheck = objQueue.CheckPatientIfInQueueAndPending(C_patient) 'check if patient exist

        '  ptnCheck = CountOpenIstances(C_patient)



        If ptnCheck > 0 Then
            msgWarn(C_patient & " has an open file. " & vbNewLine & "Please check the previous survey records and complete appropriately!")
            Exit Sub
        Else
            Try
                db.ManageQueue(listcompoind, list_name, listmname, listlname, listdob, listsex, patient, C_patient, expintdate, Cuser)
                msgSuccess("Participant successfully queued for Survey!")
                GetMyMANAGER1(C_patient)



                Dim fload As New frmSectionOne
                fload.MdiParent = mdiSERO
                fload.Show()





                Me.Close()
            Catch eex As Exception
                msgError(eex.Message)
            End Try
        End If




    End Sub

    Private Sub chkAdult_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAdult.CheckedChanged

        If Me.chkAdult.Checked = True Then
            Cstatus = "Adult"
            patient = "Adult"
            Me.cmdQueue.Enabled = True
            Me.chkchild.Checked = False
        End If
    End Sub

    Private Sub dtgvill_CellContextMenuStripChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgvill.CellContextMenuStripChanged

    End Sub
    Private Sub dtgvill_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgvill.Click
        Try
            Dim r As String = Me.dtgvill.CurrentRow.Cells("village code").Value 'village code
            svillage = r
            Select Case QLocation
                Case "kibera"

                    FillMyGrid(DataGridView2, "SELECT distinct locationid , [socialgpid],HHFNAME,HHMNAME, HHLNAME, isnull([consent],'YES')[consent],village,c FROM [settings].[INDIVIDUAL]
                                            a left outer join [sascov2_sero].[dbo].[hhsection] b on a. locationid = b.hhid where locationid ! = ''  and VILLAGE='" & r & "' 
                                              order by village,c ") 'populate listview
                Case "manyatta"

                    FillMyGrid(DataGridView2, "SELECT distinct locationid , [socialgpid],HHFNAME,HHMNAME, HHLNAME, isnull([consent],'YES')[consent],village,c FROM [settings].[INDIVIDUAL]
                                            a left outer join [sascov2_sero].[dbo].[hhsection] b on a. locationid = b.hhid where locationid ! = ''  and VILLAGE='" & r & "' 
                                              order by village,c ") 'populate listview
                Case "lwak"
                    ' FillMyGrid(DataGridView2, "SELECT COMPOUNDID,CFNAME,CJNAME,CLNAME FROM [settings].[compounds] WHERE villcode='" & r & "' order by villcode, compoundid") 'populate listview

                    FillMyGrid(DataGridView2, "SELECT distinct locationid , [socialgpid],HHFNAME,HHMNAME, HHLNAME, isnull([consent],'YES')[consent],village,c FROM [settings].[INDIVIDUAL]
                                            a left outer join [sascov2_sero].[dbo].[hhsection] b on a. locationid = b.hhid where locationid ! = ''  and VILLAGE='" & r & "'  
                                            order by village,c") 'populate listview

            End Select
        Catch ex As Exception
            msgError(ex.Message)
        End Try



    End Sub

    Private Sub chkchild_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkchild.CheckedChanged

        Select Case chkchild.Checked

            Case True
                Cstatus = "Child"
                patient = "Child"
                Me.cmdQueue.Enabled = True
                Me.chkAdult.Checked = False
            Case False
                Cstatus = Nothing
                C_patient = Nothing
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case MsgBox("Are you sure you want to close ?", MsgBoxStyle.YesNo, "Patient care System | IEIP")
            Case MsgBoxResult.Yes
                Me.Close()
            Case MsgBoxResult.No
                Exit Sub
        End Select
    End Sub

    Private Sub chkChange_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChange.CheckedChanged

        Select Case chkChange.Checked

            Case True
                Me.chkChange.Checked = True
                Me.cmdQueue.Enabled = False 'disable queue command
                Me.chkAdult.Enabled = True 'Enabled selection
                Me.chkchild.Enabled = True
            Case False
                Me.chkChange.Checked = False
                Me.cmdQueue.Enabled = True 'disable queue command
                Me.chkAdult.Enabled = False 'Enabled selection
                Me.chkchild.Enabled = False
        End Select

    End Sub

    Private Sub lstcompounds_Click(ByVal sender As Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub lst_search_results_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        'Me.cmdQueue.Enabled = True
        'Me.chkChange.Enabled = True


        'If LoginMODE = "Vaccination" Then
        '    cmdQueue.Enabled = False
        'End If



        '' Select Case QLocation
        ''   Case "kibera"
        'If lst_search_results.SelectedItems.Item(0).SubItems(1).Text = "N/A" Then

        'Else
        '    Dim id As String = ""
        '    Dim uniqueId As String
        '    id = lst_search_results.SelectedItems.Item(0).Text.Trim
        '    listcompoind = lst_search_results.SelectedItems(0).SubItems(2).Text.Trim
        '    list_name = lst_search_results.SelectedItems(0).SubItems(3).Text.Trim
        '    listmname = lst_search_results.SelectedItems(0).SubItems(4).Text.Trim
        '    listlname = lst_search_results.SelectedItems(0).SubItems(5).Text.Trim
        '    listsex = lst_search_results.SelectedItems(0).SubItems(6).Text.Trim
        '    list_DOB = lst_search_results.SelectedItems(0).SubItems(7).Text.Trim
        '    uniqueId = id
        '    objCommon.GetPhotos(uniqueId, Me, Me.pic_Image)
        'End If
        '' End Select
    End Sub



    Private Sub SystemQueueInitialise()
        Select Case chkChange.Checked 'check if the selection has been done correctly
            Case True
                If chkAdult.Checked = False And Me.chkchild.Checked = False Then
                    msgError("You must make a selection when change category is selected!")
                    Exit Sub
                End If
            Case False

        End Select

        C_patient = listinvidividid 'set current patient
        'If C_patient.Length() <> 7 Then
        Dim DoB As Date = Get_Birth_Date(listinvidividid) 'get the DOB
        'End If
        Dim age
        If C_patient.Length() = 6 Then
            age = txt_age.Text
            CheckBox1.Checked = False
            'nxtid += 1
        Else
            age = getAge(DoB) 'calculate the patients age
        End If
        If age >= 5 Then   'identify if child or adult
            patient = "ADULT"
        Else
            patient = "CHILD"
        End If
        Dim rowVal As String = listinvidividid 'create a code to queue patients in line
    End Sub

    Private Sub cmdsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearch.Click
        frmsearch.Show()
    End Sub




    Public Sub GetKAP(Barcode As String)
        openConn()

        Dim sercat As String = ""
        Dim SQL As String = "SELECT ltrim(rtrim([DSS_ID])) as DSS_ID FROM [sascov2_sero].[dbo].[kap] where ltrim(rtrim([DSS_ID])) = '" & listinvidividid.Trim & "'"

        Dim cmd As New SqlCommand(SQL, Qconn)
        Dim rDR As SqlDataReader = cmd.ExecuteReader

        dupcheck = ""

        While rDR.Read
            dupcheck = rDR.Item("DSS_ID")
        End While

        closeConn()
    End Sub



    Public Sub Getpost_covid(Barcode As String)

        openConn()
        Dim sercat As String = ""
        Dim SQL As String = "SELECT ltrim(rtrim([DSS_ID])) as DSS_ID FROM [sascov2_sero].[dbo].[post_covid_survey] where ltrim(rtrim([DSS_ID])) = '" & listinvidividid.Trim & "'"
        Dim cmd As New SqlCommand(SQL, Qconn)
        Dim rDR As SqlDataReader = cmd.ExecuteReader
        dupcheck = ""
        While rDR.Read
            dupcheck = rDR.Item("DSS_ID")
        End While
        closeConn()

    End Sub

    Private Sub cmdQueue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQueue.Click
        GetMyconfig()

        Dim dupcheck As String = ""

        If LoginMODE = "KAP" Then

            GetKAP(listinvidividid)
            If Not dupcheck = "" Then
                msgError("This participant already has a completed KAP interview. If you want to repeat then delete the first interview first")
                Exit Sub
            End If

        End If



        'If lastevent = "DTH" Then
        '    msgWarn("The supposed client is deceased")
        '    Exit Sub
        'End If


        If LoginMODE = "Express" Then
            If TextBox1.Text = "" Then
                msgError("Please select the interview date")
                Exit Sub
            End If

            If MsgBox("Are you sure this is the correct date", vbYesNo) = vbYes Then
                '   GoTo 100
                expintdate = Me.TextBox1.Text.Trim
            Else
                Exit Sub
            End If
        Else
            expintdate = Now
        End If



        'put a check if already done
        If Interview_forms = "KAP" Then
            Dim fload As New frmKAP
            fload.MdiParent = mdiSERO
            fload.Show()
            Me.Hide()

        ElseIf Interview_forms = "post" Then

            Getpost_covid(listinvidividid)
            If Not dupcheck = "" Then
                msgError("This participant already has a completed post COVID survey. If you want to repeat then delete the first interview first")
                Exit Sub
            End If

            Dim fload As New frmPostCovidConsent
            fload.MdiParent = mdiSERO
            fload.Show()
            Me.Hide()
        Else
            QueuePatient()
        End If



    End Sub

    Public Function CountCharacter(ByVal value As String, ByVal ch As Char) As Integer
        Dim cnt As Integer = 0
        For Each c As Char In value
            If c = ch Then
                cnt += 1
            End If
        Next
        Return cnt
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim count As Integer
        'count = CountCharacter("".Text.Trim, "-"c)

        'Dim uniqueId As String
        'Dim qry As String

        'uniqueId = txt_uniqueId.Text.Trim

        'Select Case QLocation
        '    Case "Thenkibera"
        '        If count = 2 Then
        '            qry = "Select [INDIVIDID],[VILLAGE] As CLUSTER,COMPOUNDID,[NAME],[MNAME],[LNAME],[GENDER],cast([dob] As Date)DOB, lastevent FROM [settings].[Individual] where COMPOUNDID = '" & uniqueId & "' "
        '        ElseIf count = 3 Then
        '            qry = "SELECT [INDIVIDID],[VILLAGE] as CLUSTER,COMPOUNDID,[NAME],[MNAME],[LNAME],[GENDER],cast([dob] as date)DOB, lastevent FROM [settings].[Individual] where (COMPOUNDID = (select COMPOUNDID from [settings].[Individual] where INDIVIDID = '" & uniqueId & "')) "
        '        Else
        '            qry = "SELECT [INDIVIDID],[VILLAGE] as CLUSTER,COMPOUNDID,[NAME],[MNAME],[LNAME],[GENDER],cast([dob] as date)DOB, lastevent FROM [settings].[Individual] where (COMPOUNDID = 'xxxxxxx')"


        '        End If

        '    Case "lwak"
        '        If count = 2 Then
        '            qry = "SELECT [INDIVIDID],[VILLAGE] ,[COMPOUNDID],[NAME],[MNAME],[LNAME],[GENDER],cast([DOB] as date)DOB, lastevent FROM [PCS].[settings].[Individual] where compoundID = '" & uniqueId & "' "
        '        ElseIf count = 3 Then
        '            qry = "SELECT [INDIVIDID],[VILLAGE] ,[COMPOUNDID],[NAME],[MNAME],[LNAME],[GENDER],cast([DOB] as date)DOB, lastevent FROM [PCS].[settings].[Individual] where (compound = (select compoundID from [settings].[Individual] where INDIVIDID = '" & uniqueId & "')) "
        '        End If
        'End Select


        'DataGridView1.DataSource = Nothing
        'FillMyGrid(DataGridView1, qry)
        '----
    End Sub

    Private Sub listParticipant()
        'Dim uniqueId As String
        'Dim dssid As String
        ''  Dim SQL
        'Dim age As Integer

        'age = DateDiff(DateInterval.Year, dtpDOB.Value, Now.Date).ToString
        'dssid = txt_uniqueId.Text.Trim

        'uniqueId = (txt_uniqueId.Text.Trim)
        'Select Case QLocation
        '    Case "kibera"
        '        FillMyGrid(DataGridView1, "Select [INDIVIDID], [Village] As CLUSTER, COMPOUNDID, [Name], [MNAME], [LNAME], [GENDER], cast([DOB] as date)DOB, LASTEVENT FROM [settings].[individual]  WHERE [INDIVIDID] = '" & txt_uniqueId.Text.Trim & "'") 'populate compounds listview
        '                   ' objCommon.GetPhotos(dssid, Me, Me.pic_Image)
        '    Case "lwak"
        '        FillMyGrid(DataGridView1, "SELECT [INDIVIDID],[VILLAGE] ,[COMPOUNDID] ,[NAME],[MNAME],[LNAME],[GENDER],cast([DOB] as date)DOB, LASTEVENT FROM [settings].[individual]  WHERE [INDIVIDID] = '" & txt_uniqueId.Text.Trim & "'") 'populate compounds listview
        'End Select
    End Sub



    Private Sub listParticipantAFTERREG()
        'Dim uniqueId As String
        'Dim dssid As String
        ''  Dim SQL
        'Dim age As Integer

        'age = DateDiff(DateInterval.Year, dtpDOB.Value, Now.Date).ToString
        'dssid = txt_uniqueId.Text.Trim

        'uniqueId = (txt_uniqueId.Text.Trim)
        Select Case QLocation
            Case "kibera"
                FillMyGrid(DataGridView1, "Select [INDIVIDID], [Village] As CLUSTER, [COMPOUNDID], [Name], [MNAME], [LNAME], [GENDER], [DOB],'XXX' AS LASTEVENT FROM [settings].[individual]  WHERE [INDIVIDID] = '" & txtTEMPID.Text.Trim & "'") 'populate compounds listview
                           ' objCommon.GetPhotos(dssid, Me, Me.pic_Image)
            Case "lwak"
                FillMyGrid(DataGridView1, "SELECT [INDIVIDID],[VILLAGE] ,[COMPOUNDID] ,[NAME],[MNAME],[LNAME],[GENDER],[DOB] FROM [settings].[individual]  WHERE [INDIVIDID] = '" & txtTEMPID.Text.Trim & "'") 'populate compounds listview
        End Select
    End Sub



    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            listParticipant()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Go.Click
        listParticipant()
    End Sub

    Private Sub txt_uniqueId_Validated(ByVal sender As Object, ByVal e As System.EventArgs)
        listParticipant()
    End Sub

    Private Sub lst_search_results_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)



    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        'Dim leo As String
        Found = False
        If CheckBox1.Checked Then

            GroupBox2.Visible = True
            ' End Select
            GroupBox2.Enabled = True
            'TextBox1.Text = Date.Today.ToString("yyyy/MM/dd") + "/" + CType(nxtid, String)
            'btnDone.Enabled = False
            'txtTEMPID.Enabled = True
            txtName.Enabled = True
            cb_Gender.Enabled = True
            txt_age.Enabled = True
            'txt_uniqueId.Text = String.Empty
            '   lst_search_results.Clear()
            '    lstcompounds.Clear()
        Else
            GroupBox2.Visible = False
            'GroupBox2.Visible = True
            GroupBox2.Enabled = False
            txtTEMPID.Text = ""
            txtName.Text = ""
            txt_age.Text = ""
            dtpDOB.Value = Now.Date
            cb_Gender.SelectedIndex = -1
        End If
    End Sub

    Private Sub ClearREG()
        ' txtTEMPID.Text = ""
        txtName.Text = ""
        txtMname.Text = ""
        txtlname.Text = ""
        dtpDOB.Value = Now.Date
        txt_age.Text = 0
        cb_Gender.SelectedIndex = -1
        txtLocation.Text = ""
        txtSublocation.Text = ""
        txtContact.Text = ""
    End Sub


    '    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
    '        'nxtid += 1


    '        If txtContact.Text = "" Then
    '            msgError("Contact Information is mandatory")
    '            Exit Sub
    '        End If

    '        Dim sVillage As String = ""

    '        If chk_revisit.CheckState = CheckState.Unchecked Then
    '            Select Case QLocation
    '                Case "lwak"
    '                    txtTEMPID.Text = "SEL" & objCommon.GetMyMAXTemp()
    '                Case "kibera"
    '                    txtTEMPID.Text = "KIB" & objCommon.GetMyMAXTemp()

    '                    If cbVillage.Text.Trim = "Other" Then
    '                        sVillage = txtOtherSpecify.Text.Trim.ToString
    '                    Else
    '                        sVillage = cbVillage.Text.Trim.ToString
    '                    End If
    '            End Select
    '        End If

    '1:
    '        Dim rn As New Random
    '2:
    '        If Not txt_age.Text = "" And txtName.Text <> "" And txtTEMPID.Text <> "" And cb_Gender.Text <> "" Then
    '            If Found Then
    '                listParticipant()
    '            Else
    '                Select Case MessageBox.Show("Save Patient information?", "Non Surveilance Patient Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    '                    Case vbYes
    '                        openConn()
    '                        Try
    '                            Dim age As String = CType(txt_age.Text, String)
    '                            'Dim sql As String = "exec [settings].[nonsurvpatient] '" + txtTEMPID.Text + "', '" + txtNames.Text + "', '" + txtMname.Text + "','" + txtlname.Text + "', '" + dtpDOB.Value.Date + "'," + age + ",'" + cb_Gender.Text + "', '" + Cuser + "', 1"
    '                            ''Dim sql As String = "exec [settings].[nonsurvpatient] '" + TextBox1.Text + "', '" + TextBox2.Text + "', 30, '" + ComboBox1.Text + "', '" + Cuser + "', 1"
    '                            'Dim cmd As New SqlCommand(sql, Qconn)
    '                            'cmd.ExecuteNonQuery()
    '                            Select Case QLocation
    '                                Case "lwak"
    '                                    db.nonsurvpatient(txtTEMPID.Text, UCase(txtName.Text), UCase(txtMname.Text), UCase(txtlname.Text),
    '                                                                        UCase(txtLocation.Text), UCase(txtSublocation.Text),
    '                                                                        UCase(txtContact.Text), dtpDOB.Value.Date, age, cb_Gender.Text.Trim, Cuser, 1)
    '                                Case "kibera"
    '                                    db.nonsurvpatient(txtTEMPID.Text, UCase(txtName.Text), UCase(txtMname.Text), UCase(txtlname.Text),
    '                                              UCase(UCase(sVillage)), UCase(cbCluster.Text.Trim),
    '                                              UCase(txtContact.Text), dtpDOB.Value.Date, age, cb_Gender.Text.Trim, Cuser, 1)
    '                            End Select
    '                            db.Manage_Contacts(txtTEMPID.Text, txtContact.Text, Cuser, 1)

    '                            ClearREG()
    '                        Catch ex As Exception
    '                            msgError("Error saving information: " + ex.Message)
    '                            'enable command on failure
    '                            Exit Try
    '                            Exit Sub
    '                        Finally
    '                            closeConn()
    '                        End Try
    '                        listParticipantAFTERREG()
    '                    Case vbNo
    '                        Exit Sub
    '                End Select
    '            End If
    '        Else
    '            MessageBox.Show("Please Enter correct ID or missing information on patient ID: " + txtTEMPID.Text, "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        End If

    '    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTEMPID.TextChanged, TextBox5.TextChanged, TextBox2.TextChanged

        'If Len(TextBox1.Text) = 4 Then
        '    TextBox1.Text = TextBox1.Text + "/" + CType(Year(Date.Today), String).Substring(2, 2)
        '    'CType(Year(Date.Today), String)
        'End If
    End Sub

    Private Sub TextBox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTEMPID.Leave, TextBox5.Leave, TextBox2.Leave
        'If DateTimePicker1.Text <> "" And TextBox2.Text <> "" And ComboBox1.Text <> "" Then
        openConn()
        Try
            Dim dr As SqlDataReader
            'Dim sql As String = "SELECT * FROM [PCS].[settings].[nonsurvpatients]where ID = '" + TextBox1.Text + "'"
            'Dim cmd As New SqlCommand(sql, Qconn)
            Dim cmd As New SqlCommand
            cmd.Connection = Qconn
            cmd.CommandText = "SELECT * FROM [PCS].[settings].[nonsurvpatients]where ID = '" & txtTEMPID.Text + "'"
            dr = cmd.ExecuteReader()

            While dr.Read
                txtTEMPID.Text = dr("ID").ToString.Trim
                txtName.Text = dr("NAME").ToString.Trim
                txtMname.Text = dr("MNAME").ToString.Trim
                txtlname.Text = dr("LNAME").ToString.Trim
                dtpDOB.Value = dr("DOB").ToString
                cb_Gender.Text = dr("GENDER").ToString.Trim
                '  nud_age.Value = CDec(dr("AgeYrs"))
                txtTEMPID.Enabled = False
                'TextBox2.Enabled = False
                cb_Gender.Enabled = False
                txt_age.Enabled = False
                txt_age.Text = DateDiff(DateInterval.Year, dtpDOB, Now.Date)
                Found = True
            End While
            dr.Close()
        Catch ex As Exception
            msgError("Error saving information: " + ex.Message)
            'enable command on failure
        Finally
            closeConn()
        End Try

        'listParticipant()
        ''Else
        'MessageBox.Show("Please Enter missing information on patient ID: " + TextBox1.Text, "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ''End If
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        txtTEMPID.Text = objCommon.GetMyMAXTemp()
    End Sub

    Private Sub lst_search_results_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        TextBox1.Text = DateTimePicker2.Value
    End Sub

    Private Sub dtpDOB_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpDOB.ValueChanged
        txt_age.Text = DateDiff(DateInterval.Year, dtpDOB.Value, Now.Date)
    End Sub

    Private Sub chk_revisit_CheckedChanged(sender As Object, e As EventArgs) Handles chk_revisit.CheckedChanged
        If chk_revisit.CheckState = CheckState.Checked Then
            txtTEMPID.Enabled = True
        Else
            txtTEMPID.Enabled = False
        End If
    End Sub


    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click

        Me.cmdQueue.Enabled = True
        Me.chkChange.Enabled = True


        If LoginMODE = "Vaccination" Then
            cmdQueue.Enabled = False
        End If

        listcompoind = ""
        listname = ""
        listdob = ""
        list_name = ""
        listmname = ""
        listlname = ""
        listsex = ""
        listinvidividid = ""
        list_DOB = "1900-01-01"
        int_round = "0"

        '  Dim id As String = ""
        '  Dim uniqueId As String
        If DataGridView1.RowCount > 0 Then
            Try
                listinvidividid = Me.DataGridView1.CurrentRow.Cells("INDIVIDID").Value
                int_round = Me.DataGridView1.CurrentRow.Cells("rnd").Value
                int_HIV = Me.DataGridView1.CurrentRow.Cells("hiv").Value
                Select Case QLocation

                    Case "lwak"

                        listcompoind = Me.DataGridView1.CurrentRow.Cells("locationid").Value
                        listmname = Me.DataGridView1.CurrentRow.Cells("MNAME").Value
                        listlname = Me.DataGridView1.CurrentRow.Cells("LNAME").Value
                    Case "kibera"
                        listcompoind = Me.DataGridView1.CurrentRow.Cells("RESID").Value
                        listmname = ""
                        listlname = ""
                End Select
                ' listcompoind = Me.DataGridView1.CurrentRow.Cells("COMPOUNDID").Value
                list_name = Me.DataGridView1.CurrentRow.Cells("NAME").Value
                listname = Me.DataGridView1.CurrentRow.Cells("NAME").Value





                listsex = Me.DataGridView1.CurrentRow.Cells("GENDER").Value
                listdob = Me.DataGridView1.CurrentRow.Cells("DOB").Value
                'lastevent = Me.DataGridView1.CurrentRow.Cells("lastevent").Value
                'listinvidividid = id
                'objCommon.GetPhotos(listinvidividid, Me, Me.pic_Image)
            Catch ex As Exception
                msgError(ex.Message)
            End Try
        End If
    End Sub


    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick


        'If DataGridView1.RowCount > 0 Then
        '    SystemQueueInitialise2()
        '    If LoginMODE = "Vaccination" Then
        '        VaccinationsNew.MdiParent = mdiSERO
        '        VaccinationsNew.Show()
        '    ElseIf LoginMODE = "Clinic" Then
        '        If Not listcompoind = "999" And (Not Mid(listinvidividid, 1, 3) = "SEL" And Not Mid(listinvidividid, 1, 3) = "KIB") And Not lastevent = "XXX" Then
        '            frmNewBorn.MdiParent = mdiSERO
        '            frmNewBorn.Show()
        '        Else
        '            Exit Sub
        '        End If
        '    End If
        'Else
        '    MsgBox("No selected individual")
        'End If

    End Sub

    Private Sub DataGridView2_Click(sender As Object, e As EventArgs) Handles DataGridView2.Click

        'searchcompound = Me.DataGridView1.CurrentRow.Cells("COMPOUND").Value

        Dim sqlstring = ""
        '   Me.lst_search_results.Items.Clear() 'set list view options here
        Dim sqlsqlstring = "SELECT [INDIVIDID],[NAME],[MNAME],[LNAME],[GENDER],cast([DOB] as date)DOB FROM settings.Individual WHERE  locationid ='xxxxxxxxxxxxxxx'"
        Select Case LoginMODE

            Case "KAP"
                Select Case QLocation
                    Case "lwak"
                        searchcompound = Me.DataGridView2.CurrentRow.Cells("locationid").Value
                        sqlstring = "SELECT [INDIVIDID],[locationid] LOCATIONID,SOCIALGPID,[NAME],[MNAME],[LNAME],[GENDER],cast([DOB] as date)DOB FROM settings.Individual_kap WHERE  locationid ='" + searchcompound + "'"

                        compoundconsent = Me.DataGridView2.CurrentRow.Cells("consent").Value.ToLower
                    Case "kibera"
                        searchcompound = Me.DataGridView2.CurrentRow.Cells("RESID").Value
                        sqlstring = "SELECT [INDIVIDID],[COMPOUNDID] as RESID,[NAME],[MNAME],[LNAME],[GENDER],cast([DOB] as date)DOB FROM settings.Individual_kap WHERE  locationid = '" + searchcompound + "'"
                        compoundconsent = Me.DataGridView2.CurrentRow.Cells("consent").Value
                    Case "manyatta"
                        searchcompound = Me.DataGridView2.CurrentRow.Cells("RESID").Value
                        sqlstring = "SELECT [INDIVIDID],[COMPOUNDID] as RESID,[NAME],[MNAME],[LNAME],[GENDER],cast([DOB] as date)DOB FROM settings.Individual_kap WHERE  locationid = '" + searchcompound + "'"
                        compoundconsent = Me.DataGridView2.CurrentRow.Cells("consent").Value


                End Select
            Case Else
                Select Case QLocation
                    Case "lwak"
                        searchcompound = Me.DataGridView2.CurrentRow.Cells("locationid").Value
                        sqlstring = "SELECT [INDIVIDID],[locationid] LOCATIONID,SOCIALGPID,[NAME],[MNAME],[LNAME],[GENDER],cast([DOB] as date)DOB,rnd,hiv FROM settings.Individual WHERE  locationid ='" + searchcompound + "'"

                        compoundconsent = Me.DataGridView2.CurrentRow.Cells("consent").Value.ToLower
                    Case "kibera"
                        searchcompound = Me.DataGridView2.CurrentRow.Cells("locationid").Value
                        sqlstring = "SELECT [INDIVIDID],[locationid] RESID,SOCIALGPID,[NAME],[MNAME],[LNAME],[GENDER],cast([DOB] as date)DOB,rnd,hiv FROM settings.Individual WHERE  locationid ='" + searchcompound + "'"
                        compoundconsent = Me.DataGridView2.CurrentRow.Cells("consent").Value
                    Case "manyatta"
                        searchcompound = Me.DataGridView2.CurrentRow.Cells("locationid").Value
                        sqlstring = "SELECT [INDIVIDID],[locationid] RESID,SOCIALGPID,[NAME],[MNAME],[LNAME],[GENDER],cast([DOB] as date)DOB,rnd,hiv FROM settings.Individual WHERE  locationid ='" + searchcompound + "'"
                        compoundconsent = Me.DataGridView2.CurrentRow.Cells("consent").Value


                End Select
        End Select



        '  lst_view_queue(lst_search_results, sqlstring) 'populate compounds listview

        If LoginMODE = "KAP" Then
            DataGridView1.DataSource = Nothing
            FillMyGrid(DataGridView1, sqlstring)
            Button3.Enabled = False
        Else

            'If compoundconsent.ToLower = "" And int_round = 0 Then
            '    MsgBox("Please consent the household first before conducting ny interview", vbInformation)
            '    Button3.Enabled = True

            '    DataGridView1.DataSource = Nothing
            '    FillMyGrid(DataGridView1, sqlsqlstring)
            '    Button3.Enabled = True

            'ElseIf compoundconsent.ToLower = "no" Then
            '    MsgBox("This household declined consent, so no interview can be conducted", vbInformation)
            '    Button3.Enabled = True

            '    DataGridView1.DataSource = Nothing
            '    FillMyGrid(DataGridView1, sqlsqlstring)
            '    Button3.Enabled = True

            'Else
            If compoundconsent.ToLower = "yes" Or compoundconsent.ToLower = "no" Or compoundconsent.ToLower = "" Then
                    DataGridView1.DataSource = Nothing
                    FillMyGrid(DataGridView1, sqlstring)
                    Button3.Enabled = False
                End If



            End If




    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub cbVillage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVillage.SelectedIndexChanged


        If cbVillage.Text = "Gatwekera" Then
            cbCluster.Enabled = True
            txtOtherSpecify.Clear()
            txtOtherSpecify.Enabled = False
        ElseIf cbVillage.Text.Trim = "Soweto West" Then
            cbCluster.Enabled = False
            cbCluster.Text = "Soweto"
            txtOtherSpecify.Clear()
            txtOtherSpecify.Enabled = False
        ElseIf cbVillage.Text = "Other" Then
            txtOtherSpecify.Enabled = True
            cbCluster.SelectedIndex = -1
            cbCluster.Enabled = False
        Else
            cbCluster.Enabled = False
            txtOtherSpecify.Clear()
            cbCluster.SelectedIndex = -1
            txtOtherSpecify.Enabled = False
        End If


    End Sub

    Private Sub dtgvill_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvill.CellContentClick

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView2.DataSource = Nothing
        DataGridView1.DataSource = Nothing

        Dim fload As New frmConsent
        fload.MdiParent = mdiSERO
        fload.Show()



    End Sub

    Private Sub frmsearchutility_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

        ' Dim r As String = frmsearchutility.dtgvill.CurrentRow.Cells("village code").Value 'village code


        Select Case QLocation
            Case "kibera"
                FillMyGrid(DataGridView2, "SELECT DISTINCT compoundid RESID,[socialgpid],HHFNAME,HHMNAME, HHLNAME, isnull([consent],'')[consent] FROM [settings].[INDIVIDUAL]
  a left outer join [sascov2_sero].[dbo].[hhsection] b on a. compoundid = b.hhid where compoundid ! = ''  and VILLAGE='" & svillage & "'  order by RESID") 'populate listview
            Case "lwak"
                FillMyGrid(DataGridView2, "SELECT COMPOUNDID,CFNAME,CJNAME,CLNAME FROM [settings].[compounds] WHERE villcode='" & svillage & "' order by villcode, compoundid") 'populate listview
        End Select

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub dtgvill_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvill.CellDoubleClick

    End Sub
End Class