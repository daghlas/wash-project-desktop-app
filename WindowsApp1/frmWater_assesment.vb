
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmWater_assesment
    Dim db As New DataClasses1DataContext
    Dim return_date As Date

    Public Sub ClearForm()
        cb_role.SelectedIndex = -1
        txt_role.Clear()
        nud_dur.Value = 0
        cb_dur.SelectedIndex = -1
        nud_workers.Value = 0
        cb_waterexists.SelectedIndex = -1
        cb_no_operation.SelectedIndex = -1
        chk_jan.Checked = False
        chk_feb.Checked = False
        chk_mar.Checked = False
        chk_apr.Checked = False
        chk_may.Checked = False
        chk_jun.Checked = False
        chk_jul.Checked = False
        chk_aug.Checked = False
        chk_sep.Checked = False
        chk_oct.Checked = False
        chk_nov.Checked = False
        chk_dec.Checked = False
        cb_delivery.SelectedIndex = -1
        txt_delivery.Clear()
        cb_know_origin.SelectedIndex = -1
        txt_origin.Clear()
        cb_water_treated.SelectedIndex = -1
        cb_sourcetreatment.SelectedIndex = -1
        nud_freq.Value = 0
        cb_freq.SelectedIndex = -1
        ComboBox1.SelectedIndex = -1
        TextBox1.Clear()
        cb_containers.SelectedIndex = -1
        dtp_lastfill.Value = return_date
        cb_container_emptied.SelectedIndex = -1
        cb_treatcontainer.SelectedIndex = -1
        cb_containertreat_method.SelectedIndex = -1
        cb_treatwaterincontainer.SelectedIndex = -1
        dtp_treated2.Value = return_date
        cb_treated2.SelectedIndex = -1
        txt_treated2.Clear()
        cb_site_type.SelectedIndex = -1
        cb_surfacewater.SelectedIndex = -1
        cb_used_drink.SelectedIndex = -1
        cb_people_access.SelectedIndex = -1
        chk1.Checked = False
        chjk_1_2.Checked = False
        chk_more2.Checked = False
        chk_o.Checked = False
        nud_people_access.Value = 0
        cb_water_available.SelectedIndex = -1
        cb_rsnnowater.SelectedIndex = -1
        cb_animal_ws.SelectedIndex = -1
        cb_dropping_ws.SelectedIndex = -1
        cb_animaldrink_ws.SelectedIndex = -1
        cb_toilet_ws.SelectedIndex = -1
        cb_HF_ws.SelectedIndex = -1
        cb_farm_ws.SelectedIndex = -1
        cb_slaughter_ws.SelectedIndex = -1
        cb_school_ws.SelectedIndex = -1
        cb_drainage_ws.SelectedIndex = -1
        cb_samples_ws.SelectedIndex = -1
        cb_reason_ws.SelectedIndex = -1
        txt_barcode1.Clear()
        txt_barcode2.Clear()
        txt_time.Clear()
        txt_pH.Clear()
        txt_turbidity.Clear()
        txt_Chlorine.Clear()
        chk_catlle.Checked = False
        chk_goats.Checked = False
        chk_sheep.Checked = False
        chk_pigs.Checked = False
        chk_chick.Checked = False
        chk_ducks.Checked = False
        chk_cats.Checked = False
        chk_dogs.Checked = False
        chk_unk.Checked = False
        cb_common_animal.SelectedIndex = -1
        cb_animalcount.SelectedIndex = -1
        cb_farm_desc.SelectedIndex = -1
        cb_animal_housing.SelectedIndex = -1
        cb_wastedisposal.SelectedIndex = -1
    End Sub

    Private Sub cb_no_operation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_no_operation.SelectedIndexChanged
        If cb_no_operation.Text.Trim.ToLower = "yes" Then
            chk_jan.Enabled = True
            chk_feb.Enabled = True
            chk_mar.Enabled = True
            chk_apr.Enabled = True
            chk_may.Enabled = True
            chk_jun.Enabled = True
            chk_jul.Enabled = True
            chk_aug.Enabled = True
            chk_sep.Enabled = True
            chk_oct.Enabled = True
            chk_nov.Enabled = True
            chk_dec.Enabled = True
        Else
            chk_jan.Enabled = False
            chk_feb.Enabled = False
            chk_mar.Enabled = False
            chk_apr.Enabled = False
            chk_may.Enabled = False
            chk_jun.Enabled = False
            chk_jul.Enabled = False
            chk_aug.Enabled = False
            chk_sep.Enabled = False
            chk_oct.Enabled = False
            chk_nov.Enabled = False
            chk_dec.Enabled = False

            chk_jan.Checked = False
            chk_feb.Checked = False
            chk_mar.Checked = False
            chk_apr.Checked = False
            chk_may.Checked = False
            chk_jun.Checked = False
            chk_jul.Checked = False
            chk_aug.Checked = False
            chk_sep.Checked = False
            chk_oct.Checked = False
            chk_nov.Checked = False
            chk_dec.Checked = False
        End If
    End Sub

    Private Sub cb_delivery_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_delivery.SelectedIndexChanged
        If cb_delivery.Text.Trim.ToLower = "other" Then
            txt_delivery.Enabled = True
        Else
            txt_delivery.Enabled = False
            txt_delivery.Clear()
        End If

        If cb_delivery.Text.Trim.ToLower = "i dont know" Then
            cb_know_origin.Enabled = False
            txt_origin.Enabled = False

            cb_know_origin.SelectedIndex = -1
        Else
            cb_know_origin.Enabled = True

        End If

        If cb_delivery.Text.Trim.ToLower = "truck" Then
            nud_freq.Enabled = True
            cb_freq.Enabled = True

        Else
            nud_freq.Enabled = False
            cb_freq.Enabled = False

            nud_freq.Value = 0
            cb_freq.SelectedIndex = -1

        End If
    End Sub

    Private Sub cb_know_origin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_know_origin.SelectedIndexChanged
        If cb_know_origin.Text.Trim.ToLower = "yes" Then
            txt_origin.Enabled = True
        Else
            txt_origin.Enabled = False
            txt_origin.Clear()
        End If
    End Sub

    Private Sub cb_water_treated_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_water_treated.SelectedIndexChanged
        If cb_water_treated.Text.ToLowerInvariant = "yes" Then
            cb_sourcetreatment.Enabled = True
        Else
            cb_sourcetreatment.Enabled = False
            cb_sourcetreatment.SelectedIndex = -1
        End If
    End Sub

    Private Sub cb_containers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_containers.SelectedIndexChanged
        If cb_containers.Text.Trim.ToLower = "yes" Then
            dtp_lastfill.Enabled = True
            cb_container_emptied.Enabled = True
        Else
            return_date = "1990 - 10 - 10"
            dtp_lastfill.Value = return_date
            dtp_lastfill.Enabled = False
            cb_container_emptied.Enabled = False

            cb_container_emptied.SelectedIndex = -1
        End If
    End Sub

    Private Sub cb_role_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_role.SelectedIndexChanged
        If cb_role.Text.Trim.ToLower = "other" Then
            txt_role.Enabled = True
        Else
            txt_role.Enabled = False
            txt_role.Clear()
        End If
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_treatwaterincontainer.SelectedIndexChanged
        If cb_treatwaterincontainer.Text.Trim.ToLower = "yes" Then
            cb_treated2.Enabled = True
            dtp_treated2.Enabled = True
            txt_treated2.Enabled = False
            txt_treated2.Clear()
        Else
            cb_treated2.Enabled = False
            dtp_treated2.Enabled = False
            return_date = "1990-10-10"
            dtp_treated2.Value = return_date
            txt_treated2.Enabled = False

            cb_treated2.SelectedIndex = -1
            txt_treated2.Clear()

        End If
    End Sub

    Private Sub cb_treated2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_treated2.SelectedIndexChanged
        If cb_treated2.Text.Trim.ToLower = "other" Then
            txt_treated2.Enabled = True
        Else
            txt_treated2.Enabled = False
            txt_treated2.Clear()

        End If
    End Sub

    Private Sub cb_site_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_site_type.SelectedIndexChanged
        If cb_site_type.Text.Trim = "Surface water (river, stream, lake, dam, pond, canal, irrigation channel)" Then
            cb_surfacewater.Enabled = True
        Else
            cb_surfacewater.Enabled = False
            cb_surfacewater.SelectedIndex = -1
        End If

    End Sub

    Private Sub cb_water_available_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_water_available.SelectedIndexChanged
        If cb_water_available.Text.Trim.ToLower = "no" Then
            cb_rsnnowater.Enabled = True
        Else
            cb_rsnnowater.Enabled = False
            cb_rsnnowater.SelectedIndex = -1

        End If
    End Sub

    Private Sub chk_unk_CheckedChanged(sender As Object, e As EventArgs) Handles chk_unk.CheckedChanged

        If chk_unk.CheckState = CheckState.Checked Then
            chk_catlle.Enabled = False
            chk_goats.Enabled = False
            chk_sheep.Enabled = False
            chk_pigs.Enabled = False
            chk_chick.Enabled = False
            chk_ducks.Enabled = False
            chk_dogs.Enabled = False
            chk_cats.Enabled = False

            chk_catlle.Checked = False
            chk_goats.Checked = False
            chk_sheep.Checked = False
            chk_pigs.Checked = False
            chk_chick.Checked = False
            chk_ducks.Checked = False
            chk_cats.Checked = False
            chk_dogs.Checked = False
        Else

            chk_catlle.Enabled = True
            chk_goats.Enabled = True
            chk_sheep.Enabled = True
            chk_pigs.Enabled = True
            chk_chick.Enabled = True
            chk_ducks.Enabled = True
            chk_cats.Enabled = True
            chk_dogs.Enabled = True
        End If

    End Sub

    Private Sub cb_treatcontainer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_treatcontainer.SelectedIndexChanged
        If cb_treatcontainer.Text.Trim.ToLower = "yes" Then
            cb_containertreat_method.Enabled = True
        Else
            cb_containertreat_method.Enabled = False
            cb_containertreat_method.SelectedIndex = -1
        End If
    End Sub

    Private Sub cb_samples_ws_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_samples_ws.SelectedIndexChanged
        If cb_samples_ws.Text.Trim.ToLower = "yes" Then
            cb_reason_ws.Enabled = False
            txt_barcode1.Enabled = True
            txt_barcode2.Enabled = True
            txt_time.Enabled = True
            txt_pH.Enabled = True
            txt_turbidity.Enabled = True
            txt_Chlorine.Enabled = True

            cb_reason_ws.SelectedIndex = -1

        ElseIf cb_samples_ws.Text.Trim.ToLower = "no" Then
            cb_reason_ws.Enabled = True
            txt_barcode1.Enabled = False
            txt_barcode2.Enabled = False
            txt_time.Enabled = False
            txt_pH.Enabled = False
            txt_turbidity.Enabled = False
            txt_Chlorine.Enabled = False

            txt_barcode1.Clear()
            txt_barcode2.Clear()
            txt_time.Clear()
            txt_pH.Clear()
            txt_turbidity.Clear()
            txt_Chlorine.Clear()
        Else
            cb_reason_ws.Enabled = False
            txt_barcode1.Enabled = False
            txt_barcode2.Enabled = False
            txt_time.Enabled = False
            txt_pH.Enabled = False
            txt_turbidity.Enabled = False
            txt_Chlorine.Enabled = False

            cb_reason_ws.SelectedIndex = -1
            txt_barcode1.Clear()
            txt_barcode2.Clear()
            txt_time.Clear()
            txt_pH.Clear()
            txt_turbidity.Clear()
            txt_Chlorine.Clear()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cb_role.Text = "" Then
            MsgBox("Enter Your Role")
            Exit Sub
        End If
        If cb_role.Text.Trim.ToLower = "other" And txt_role.Text = "" Then
            MsgBox("Specify Your Role")
            Exit Sub
        End If
        If nud_dur.Value <= 0 Then
            MsgBox("Enter Duration Worked")
            Exit Sub
        End If
        If cb_dur.Text = "" Then
            MsgBox("Specify Duration(Weeks/Months..)")
            Exit Sub
        End If
        If nud_workers.Value <= 0 Then
            MsgBox("Enter number of other workers.")
            Exit Sub
        End If
        If cb_waterexists.Text = "" Then
            MsgBox("Enter Site Age")
            Exit Sub
        End If
        If cb_no_operation.Text = "" Then
            MsgBox("Enter Seasonality")
            Exit Sub
        End If
        If cb_no_operation.Text.Trim.ToLower = "yes" And
            chk_jan.CheckState = CheckState.Checked = False And
            chk_feb.CheckState = CheckState.Checked = False And
            chk_mar.CheckState = CheckState.Checked = False And
            chk_apr.CheckState = CheckState.Checked = False And
            chk_may.CheckState = CheckState.Checked = False And
            chk_jun.CheckState = CheckState.Checked = False And
            chk_jul.CheckState = CheckState.Checked = False And
            chk_aug.CheckState = CheckState.Checked = False And
            chk_sep.CheckState = CheckState.Checked = False And
            chk_oct.CheckState = CheckState.Checked = False And
            chk_nov.CheckState = CheckState.Checked = False And
            chk_dec.CheckState = CheckState.Checked = False Then
            MsgBox("Pick at least a month")
            Exit Sub
        End If
        If cb_delivery.Text.Trim.ToLower = "" Then
            MsgBox("Enter Delivery Method")
            Exit Sub
        End If
        If cb_delivery.Text.Trim.ToLower = "other" And txt_delivery.Text = "" Then
            MsgBox("Specify Other Delivery Means")
            Exit Sub
        End If
        If cb_know_origin.Text.Trim.ToLower = "yes" And cb_know_origin.Text = "" Then
            MsgBox("Enter Origin of Water")
            Exit Sub
        End If
        If cb_know_origin.Text.Trim.ToLower = "yes" And txt_origin.Text = "" Then
            MsgBox("Specify Origin")
            Exit Sub
        End If

        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(tp2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If cb_water_treated.Text = "" Then
            MsgBox("Enter if water is treated")
            Exit Sub
        End If
        If cb_water_treated.Text.Trim.ToLower = "yes" And cb_sourcetreatment.Text = "" Then
            MsgBox("Specify how water is treated")
            Exit Sub
        End If
        If cb_delivery.Text.Trim.ToLower = "truck" And nud_freq.Value <= 0 Then
            MsgBox("Enter how often the water is trucked")
            Exit Sub
        End If
        If cb_delivery.Text.Trim.ToLower = "truck" And cb_freq.Text = "" Then
            MsgBox("Enter delivery frequency (per day/per week..)")
            Exit Sub
        End If
        If ComboBox1.Text = "" Then
            MsgBox("Enter number of people served")
            Exit Sub
        End If
        If TextBox1.Text = "" Then
            MsgBox("Enter description of charges")
            Exit Sub
        End If
        If cb_containers.Text = "" Then
            MsgBox("Enter if containers are on site")
            Exit Sub
        End If
        If cb_containers.Text.Trim.ToLower = "yes" And cb_container_emptied.Text = "" Then
            MsgBox("Enter if containers were emptied and cleaned")
            Exit Sub
        End If
        If cb_treatcontainer.Text = "" Then
            MsgBox("Enter if water is treatd and made safe for drinking")
            Exit Sub
        End If
        If cb_treatcontainer.Text.Trim.ToLower = "yes" And cb_containertreat_method.Text = "" Then
            MsgBox("Specify how the water is treated")
            Exit Sub
        End If

        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(tp3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If cb_treatwaterincontainer.Text = "" Then
            MsgBox("Enter if water was treated to make it safe for drinking")
            Exit Sub
        End If
        If cb_treatwaterincontainer.Text.Trim.ToLower = "yes" And cb_treated2.Text = "" Then
            MsgBox("Enter how the water was treated")
            Exit Sub
        End If
        If cb_treated2.Text.Trim.ToLower = "other" And txt_treated2.Text = "" Then
            MsgBox("Specify other treatment method")
            Exit Sub
        End If

        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(tp4)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If cb_site_type.Text = "" Then
            MsgBox("Enter Site type")
            Exit Sub
        End If
        If cb_site_type.Text = "Surface water (river, stream, lake, dam, pond, canal, irrigation channel)" And cb_surfacewater.Text = "" Then
            MsgBox("Enter type of surface water")
            Exit Sub
        End If
        If cb_used_drink.Text = "" Then
            MsgBox("Enter if water is used for drinking")
            Exit Sub
        End If
        If cb_used_drink.Text.Trim.ToLower = "yes" And cb_people_access.Text = "" Then
            MsgBox("Enter how people access the water")
            Exit Sub
        End If
        If chk1.Checked = False And
                chk_o.CheckState = CheckState.Checked = False And
                chk_more2.CheckState = CheckState.Checked = False And
                chjk_1_2.CheckState = CheckState.Checked = False Then
            MsgBox("Check the relevant boxes")
            Exit Sub
        End If
        If nud_people_access.Value <= 0 Then
            MsgBox("Enter number of people getting the water")
            Exit Sub
        End If
        If cb_water_available.Text = "" Then
            MsgBox("Enter if water is currently available")
            Exit Sub
        End If
        If cb_water_available.Text.Trim.ToLower = "no" And cb_rsnnowater.Text = "" Then
            MsgBox("Enter reason of water unavailabiliy")
            Exit Sub
        End If

        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(tp5)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If cb_animal_ws.Text = "" Then
            MsgBox("Enter if livestock are visible")
            Exit Sub
        End If
        If cb_dropping_ws.Text = "" Then
            MsgBox("Enter if livestock droppings are visible")
            Exit Sub
        End If
        If cb_animaldrink_ws.Text = "" Then
            MsgBox("Enter if livestock water source are visible")
            Exit Sub
        End If
        If cb_toilet_ws.Text = "" Then
            MsgBox("Enter if there toilets")
            Exit Sub
        End If
        If cb_HF_ws.Text = "" Then
            MsgBox("Enter if there are health care facilities")
            Exit Sub
        End If
        If cb_farm_ws.Text = "" Then
            MsgBox("Enter if there is a farm")
            Exit Sub
        End If
        If cb_slaughter_ws.Text = "" Then
            MsgBox("Enter if there is a slaughterhouse")
            Exit Sub
        End If
        If cb_school_ws.Text = "" Then
            MsgBox("Enter if there is a school")
            Exit Sub
        End If
        If cb_drainage_ws.Text = "" Then
            MsgBox("Enter if drainage are visible")
            Exit Sub
        End If

        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(tp6)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If cb_samples_ws.Text = "" Then
            MsgBox("Enter if water sample was taken")
            Exit Sub
        End If
        If cb_samples_ws.Text.Trim.ToLower = "no" And cb_reason_ws.Text = "" Then
            MsgBox("Enter reason")
            Exit Sub
        End If
        If cb_samples_ws.Text.Trim.ToLower = "yes" And txt_barcode1.Text = "" Then
            MsgBox("Enter barcode1")
            Exit Sub
        End If
        If cb_samples_ws.Text.Trim.ToLower = "yes" And txt_barcode2.Text = "" Then
            MsgBox("Enter barcode2")
            Exit Sub
        End If
        If cb_samples_ws.Text.Trim.ToLower = "yes" And txt_time.Text = "" Then
            MsgBox("Enter time collected")
            Exit Sub
        End If
        If cb_samples_ws.Text.Trim.ToLower = "yes" And txt_pH.Text = "" Then
            MsgBox("Enter pH")
            Exit Sub
        End If
        If cb_samples_ws.Text.Trim.ToLower = "yes" And txt_turbidity.Text = "" Then
            MsgBox("Enter turbidity")
            Exit Sub
        End If
        If cb_samples_ws.Text.Trim.ToLower = "yes" And txt_Chlorine.Text = "" Then
            MsgBox("Enter Chlorine residue")
            Exit Sub
        End If


        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(tp7)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(tp8)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(tp9)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(tp1)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(tp2)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(tp3)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(tp4)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(tp5)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(tp6)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(tp7)
    End Sub

    Private Sub Button16_Click_1(sender As Object, e As EventArgs) Handles Button16.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(tp8)
    End Sub
    Private Sub cb_used_drink_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_used_drink.SelectedIndexChanged
        If cb_used_drink.Text.Trim = "Yes" Then
            cb_people_access.Enabled = True
        Else
            cb_people_access.Enabled = False
            cb_people_access.SelectedIndex = -1
        End If
    End Sub

    Private Sub frmWater_assesment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(tp1)

        Label17.Text = listinvidividid + " | " + list_name + " " + listmname + " " + listlname + " | " + listsex + " | " + listdob

        OpenCon()
        Dim cmd As SqlCommand

        Try
            Using conn As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=washproject;Integrated Security=True")
                Dim reader As SqlDataReader
                Try
                    conn.Open()
                    Dim query As String
                    query = "SELECT * FROM water WHERE individid = '" & listinvidividid & "'"
                    cmd = New SqlCommand(query, Qconn)
                    reader = cmd.ExecuteReader

                    While reader.Read
                        cb_role.Text = reader.Item("role")
                        txt_role.Text = reader.Item("otherRole")
                        nud_dur.Value = reader.Item("duration")
                        cb_dur.Text = reader.Item("durationPeriod")
                        nud_workers.Value = reader.Item("workers")
                        cb_waterexists.Text = reader.Item("siteAge")
                        cb_no_operation.Text = reader.Item("seasonality")
                        chk_jan.Checked = reader.Item("Jan")
                        chk_feb.Checked = reader.Item("Feb")
                        chk_mar.Checked = reader.Item("Mar")
                        chk_apr.Checked = reader.Item("Apr")
                        chk_may.Checked = reader.Item("May")
                        chk_jun.Checked = reader.Item("Jun")
                        chk_jul.Checked = reader.Item("Jul")
                        chk_aug.Checked = reader.Item("Aug")
                        chk_sep.Checked = reader.Item("Sep")
                        chk_oct.Checked = reader.Item("Oct")
                        chk_nov.Checked = reader.Item("Nov")
                        chk_dec.Checked = reader.Item("Dec")
                        cb_delivery.Text = reader.Item("delivery")
                        txt_delivery.Text = reader.Item("deliverySpecified")
                        cb_know_origin.Text = reader.Item("origin")
                        txt_origin.Text = reader.Item("originSpecified")

                        cb_water_treated.Text = reader.Item("originTreatment")
                        cb_sourcetreatment.Text = reader.Item("treatmentSpecified")
                        nud_freq.Value = reader.Item("deliveryFrequency")
                        cb_freq.Text = reader.Item("deliveryFrequncySpecify")
                        ComboBox1.Text = reader.Item("customers")
                        TextBox1.Text = reader.Item("charges")

                        cb_containers.Text = reader.Item("storageContainers")
                        dtp_lastfill.Value = reader.Item("dateLastFilled")
                        cb_container_emptied.Text = reader.Item("cleanFilled")
                        cb_treatcontainer.Text = reader.Item("drinkTreat")
                        cb_containertreat_method.Text = reader.Item("drinkTreatSpecify")

                        cb_treatwaterincontainer.Text = reader.Item("currentContainerTreat")
                        dtp_treated2.Value = reader.Item("dateTreated")
                        cb_treated2.Text = reader.Item("howTreated")
                        txt_treated2.Text = reader.Item("howTreatedSpecify")

                        cb_site_type.Text = reader.Item("sourceType")
                        cb_surfacewater.Text = reader.Item("surfaceWater")
                        cb_used_drink.Text = reader.Item("siteDrinking")
                        cb_people_access.Text = reader.Item("siteAccess")
                        chk1.Checked = reader.Item("aMeter")
                        chjk_1_2.Checked = reader.Item("twoMeters")
                        chk_more2.Checked = reader.Item("plusTwoMeters")
                        chk_o.Checked = reader.Item("noPeople")
                        nud_people_access.Value = reader.Item("customerCount")
                        cb_water_available.Text = reader.Item("waterAvailability")

                        cb_rsnnowater.Text = reader.Item("waterUnavailable")
                        cb_animal_ws.Text = reader.Item("livestockVisible")
                        cb_dropping_ws.Text = reader.Item("animalDroppings")
                        cb_animaldrink_ws.Text = reader.Item("waterAnimals")
                        cb_toilet_ws.Text = reader.Item("wasteWater")
                        cb_HF_ws.Text = reader.Item("healthCare")
                        cb_farm_ws.Text = reader.Item("farm")
                        cb_slaughter_ws.Text = reader.Item("slaughterhouse")
                        cb_school_ws.Text = reader.Item("school")
                        cb_drainage_ws.Text = reader.Item("drainage")

                        cb_samples_ws.Text = reader.Item("sampleTaken")
                        cb_reason_ws.Text = reader.Item("sampleNotTaken")
                        txt_barcode1.Text = reader.Item("barcode1")
                        txt_barcode2.Text = reader.Item("barcode2")
                        txt_time.Text = reader.Item("collectionTime")
                        txt_pH.Text = reader.Item("ph")
                        txt_turbidity.Text = reader.Item("turbidy")
                        txt_Chlorine.Text = reader.Item("chlorine")

                        chk_catlle.Checked = reader.Item("cattle")
                        chk_goats.Checked = reader.Item("goats")
                        chk_sheep.Checked = reader.Item("sheep")
                        chk_pigs.Checked = reader.Item("pigs")
                        chk_chick.Checked = reader.Item("chicken")
                        chk_ducks.Checked = reader.Item("ducks")
                        chk_cats.Checked = reader.Item("cats")
                        chk_dogs.Checked = reader.Item("dogs")
                        chk_unk.Checked = reader.Item("unknown")
                        cb_common_animal.Text = reader.Item("commonAnimal")
                        cb_animalcount.Text = reader.Item("totalAnimals")
                        cb_farm_desc.Text = reader.Item("farmDescription")
                        cb_animal_housing.Text = reader.Item("animalKeeping")
                        cb_wastedisposal.Text = reader.Item("animalWaste")
                    End While

                    If reader.HasRows Then
                        btn_submit.Enabled = False
                        btn_update.Enabled = True
                    Else
                        btn_submit.Enabled = True
                        btn_update.Enabled = False
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        If chk_unk.CheckState = CheckState.Checked = False And
            chk_catlle.CheckState = CheckState.Checked = False And
            chk_goats.CheckState = CheckState.Checked = False And
            chk_sheep.CheckState = CheckState.Checked = False And
            chk_pigs.CheckState = CheckState.Checked = False And
            chk_chick.CheckState = CheckState.Checked = False And
            chk_ducks.CheckState = CheckState.Checked = False And
            chk_cats.CheckState = CheckState.Checked = False Then
            MsgBox("Check the relevant answers")
            Exit Sub
        End If
        If cb_common_animal.Text = "" Then
            MsgBox("Enter most common animal")
            Exit Sub
        End If
        If cb_animalcount.Text = "" Then
            MsgBox("Enter estimated number of animals present")
            Exit Sub
        End If
        If cb_farm_desc.Text = "" Then
            MsgBox("Enter farm description")
            Exit Sub
        End If
        If cb_animal_housing.Text = "" Then
            MsgBox("Enter how animals are kept")
            Exit Sub
        End If
        If cb_wastedisposal.Text = "" Then
            MsgBox("Enter waste disposal method")
            Exit Sub
        End If

        Try
            db.water1(listinvidividid, cb_role.Text, txt_role.Text, nud_dur.Value, cb_dur.Text,
            nud_workers.Value, cb_waterexists.Text, cb_no_operation.Text, chk_jan.Checked, chk_feb.Checked,
            chk_mar.Checked, chk_apr.Checked, chk_may.Checked, chk_jun.Checked, chk_jul.Checked, chk_aug.Checked,
            chk_sep.Checked, chk_oct.Checked, chk_nov.Checked, chk_dec.Checked, cb_delivery.Text, txt_delivery.Text,
            cb_know_origin.Text, txt_origin.Text,
            cb_water_treated.Text, cb_sourcetreatment.Text, nud_freq.Value, cb_freq.Text, ComboBox1.Text, TextBox1.Text,
            cb_containers.Text, dtp_lastfill.Value.Date, cb_container_emptied.Text, cb_treatcontainer.Text,
            cb_containertreat_method.Text,
            cb_treatwaterincontainer.Text, dtp_treated2.Value.Date, cb_treated2.Text,
            txt_treated2.Text,
            cb_site_type.Text, cb_surfacewater.Text, cb_used_drink.Text, cb_people_access.Text, chk1.Checked,
            chjk_1_2.Checked, chk_more2.Checked, chk_o.Checked, nud_people_access.Value,
            cb_water_available.Text,
            cb_rsnnowater.Text, cb_animal_ws.Text, cb_dropping_ws.Text, cb_animaldrink_ws.Text, cb_toilet_ws.Text,
            cb_HF_ws.Text, cb_farm_ws.Text, cb_slaughter_ws.Text, cb_school_ws.Text,
            cb_drainage_ws.Text,
            cb_samples_ws.Text, cb_reason_ws.Text, txt_barcode1.Text, txt_barcode2.Text, txt_time.Text, txt_pH.Text,
            txt_turbidity.Text, txt_Chlorine.Text,
            chk_catlle.Checked, chk_goats.Checked, chk_sheep.Checked, chk_pigs.Checked, chk_chick.Checked, chk_ducks.Checked,
            chk_cats.Checked, chk_dogs.Checked, chk_unk.Checked, cb_common_animal.Text, cb_animalcount.Text,
            cb_farm_desc.Text, cb_animal_housing.Text, cb_wastedisposal.Text,
            1)

            msgSuccess("Successfully Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If MsgBox("Survey Complete, Select Next Individual..?", MsgBoxStyle.OkCancel, Application.ProductName) = DialogResult.OK Then
            frmIndividuals.Show()
            Me.Close()
        Else
            frmIndividuals.Close()
        End If

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            db.water1(listinvidividid, cb_role.Text, txt_role.Text, nud_dur.Value, cb_dur.Text,
            nud_workers.Value, cb_waterexists.Text, cb_no_operation.Text, chk_jan.Checked, chk_feb.Checked,
            chk_mar.Checked, chk_apr.Checked, chk_may.Checked, chk_jun.Checked, chk_jul.Checked, chk_aug.Checked,
            chk_sep.Checked, chk_oct.Checked, chk_nov.Checked, chk_dec.Checked, cb_delivery.Text, txt_delivery.Text,
            cb_know_origin.Text, txt_origin.Text,
            cb_water_treated.Text, cb_sourcetreatment.Text, nud_freq.Value, cb_freq.Text, ComboBox1.Text, TextBox1.Text,
            cb_containers.Text, dtp_lastfill.Value.Date, cb_container_emptied.Text, cb_treatcontainer.Text,
            cb_containertreat_method.Text,
            cb_treatwaterincontainer.Text, dtp_treated2.Value.Date, cb_treated2.Text,
            txt_treated2.Text,
            cb_site_type.Text, cb_surfacewater.Text, cb_used_drink.Text, cb_people_access.Text, chk1.Checked,
            chjk_1_2.Checked, chk_more2.Checked, chk_o.Checked, nud_people_access.Value,
            cb_water_available.Text,
            cb_rsnnowater.Text, cb_animal_ws.Text, cb_dropping_ws.Text, cb_animaldrink_ws.Text, cb_toilet_ws.Text,
            cb_HF_ws.Text, cb_farm_ws.Text, cb_slaughter_ws.Text, cb_school_ws.Text,
            cb_drainage_ws.Text,
            cb_samples_ws.Text, cb_reason_ws.Text, txt_barcode1.Text, txt_barcode2.Text, txt_time.Text, txt_pH.Text,
            txt_turbidity.Text, txt_Chlorine.Text,
            chk_catlle.Checked, chk_goats.Checked, chk_sheep.Checked, chk_pigs.Checked, chk_chick.Checked, chk_ducks.Checked,
            chk_cats.Checked, chk_dogs.Checked, chk_unk.Checked, cb_common_animal.Text, cb_animalcount.Text,
            cb_farm_desc.Text, cb_animal_housing.Text, cb_wastedisposal.Text,
            2)

            msgSuccess("Successfully Updated")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If MsgBox("Survey Complete, Select Next Individual..?", MsgBoxStyle.OkCancel, Application.ProductName) = DialogResult.OK Then
            frmIndividuals.Show()
            Me.Hide()
        Else
            frmIndividuals.Close()
        End If
    End Sub
End Class