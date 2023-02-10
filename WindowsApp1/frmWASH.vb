Imports System.Data.SqlClient

Public Class frmWASH
    Dim str_chk_cwaste_bush As String
    Dim db As New DataClasses1DataContext
    Dim return_date As Date
    Private Sub fill_checkboxes()
        If chk_cwaste_bush.CheckState = CheckState.Checked Then
            str_chk_cwaste_bush = "YES"
        Else
            str_chk_cwaste_bush = "NO"
        End If
    End Sub

    Private Sub cb_wtr_paid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_wtr_paid.SelectedIndexChanged
        If cb_wtr_paid.Text.Trim.ToLower = "yes" Then
            cb_hh_pays.Enabled = True
        Else

            cb_hh_pays.Enabled = True
            cb_hh_pays.SelectedIndex = -1

        End If
    End Sub

    Private Sub cb_wtr_quality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_wtr_quality.SelectedIndexChanged

        If cb_wtr_quality.Text.Trim.ToLower = "no" Then
            cb_quality_rsn.Enabled = True
        Else
            cb_quality_rsn.Enabled = False
            cb_quality_rsn.SelectedIndex = -1
        End If

    End Sub

    Private Sub cb_quality_rsn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_quality_rsn.SelectedIndexChanged
        'If cb_wtr_quality.Text.Trim.ToLower = "no" Or cb_wtr_quality.Text.Trim.ToLower = "i don't know" Then
        '    cb_quality_rsn.Enabled = False
        'Else
        '    cb_quality_rsn.Enabled = True
        'End If

        If cb_quality_rsn.Text.Trim.ToLower = "other" Then
            txt_qual_rsn_other.Enabled = True
        Else
            txt_qual_rsn_other.Enabled = False
            txt_qual_rsn_other.Clear()
        End If

    End Sub

    Private Sub cb_wtr_pay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_wtr_pay.SelectedIndexChanged
        If cb_wtr_pay.Text.Trim.ToLower = "yes" Then
            txt_wtr_cost.Enabled = True
        Else
            txt_wtr_cost.Enabled = False
            txt_wtr_cost.Clear()
        End If
    End Sub

    Private Sub cb_wtr_fetch_keep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_wtr_fetch_keep.SelectedIndexChanged
        If cb_wtr_fetch_keep.Text.Trim = "Yes, all are used for fetching water." Or cb_wtr_fetch_keep.Text.Trim = "Yes, some are for fetching water." Then

            txt_num_cont.Enabled = True
            cb_conta_vol.Enabled = True
            'CheckedListBox6.Enabled = False
            'txt_num_cont.Clear()

        Else
            txt_num_cont.Enabled = False
            txt_num_cont.Clear()
            cb_conta_vol.Enabled = False
            cb_conta_vol.SelectedIndex = -1
            'CheckedListBox6.Enabled = True

        End If
    End Sub

    Private Sub cb_wtr_avail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_wtr_avail.SelectedIndexChanged
        If cb_wtr_avail.Text.Trim = "No, always sufficient" Or cb_wtr_avail.Text.Trim = "I dont know" Then
            cb_no_drinking.Enabled = False
            cb_no_drinking.SelectedIndex = -1

        Else
            cb_no_drinking.Enabled = True
        End If
    End Sub

    Private Sub cb_no_drinking_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_no_drinking.SelectedIndexChanged
        If cb_no_drinking.Text.Trim.ToLower = "other" Then
            txt_other_no_drinkingwater.Enabled = True
        Else
            txt_other_no_drinkingwater.Enabled = False
            txt_other_no_drinkingwater.Clear()
        End If
    End Sub

    Private Sub cbt_toil_share_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbt_toil_share.SelectedIndexChanged
        If cbt_toil_share.Text.Trim.ToLower = "yes" Then
            cb_share_toilet.Enabled = True
        Else
            cb_share_toilet.Enabled = False
            cb_share_toilet.SelectedIndex = -1

        End If
    End Sub

    Private Sub cb_toilet_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_toilet_type.SelectedIndexChanged
        If cb_toilet_type.Text.Trim = "Flush or pour flush" Then
            cb_sewer_disp.Enabled = True
        Else
            cb_sewer_disp.Enabled = False
            cb_sewer_disp.SelectedIndex = -1
        End If

        If cb_toilet_type.Text.Trim = "Dry pit latrine" Then
            cb_pit_type.Enabled = True
            cb_last_emptied.Enabled = True
        Else
            cb_pit_type.Enabled = False
            cb_last_emptied.Enabled = False
            cb_last_emptied.SelectedIndex = -1
            cb_pit_type.SelectedIndex = -1
        End If

    End Sub

    Private Sub cb_washh_place_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_washh_place.SelectedIndexChanged

        If cb_washh_place.Text.Trim = "No handwashing place in dwelling/plot/yard" Or cb_washh_place.Text.Trim = "No permission to see" Then
            txt_hand_was_place.Enabled = False
            cb_wash_wtr_cont.Enabled = False
            cb_soap_avail.Enabled = False
            txt_hand_was_place.Clear()
            cb_wash_wtr_cont.SelectedIndex = -1
            cb_soap_avail.SelectedIndex = -1
        Else
            txt_hand_was_place.Enabled = True
            cb_wash_wtr_cont.Enabled = True
            cb_soap_avail.Enabled = True
        End If

    End Sub

    Private Sub cbt_comm_treat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbt_comm_treat.SelectedIndexChanged
        If cbt_comm_treat.Text.Trim.ToLower = "other" Then
            txt_comm_specify.Enabled = True
        Else

            txt_comm_specify.Enabled = False
            txt_comm_specify.Clear()
        End If
    End Sub

    Private Sub chk_ctn_idk_CheckedChanged(sender As Object, e As EventArgs) Handles chk_ctn_idk.CheckedChanged
        If chk_ctn_idk.CheckState = CheckState.Checked Then
            chk_ctn_wmwol.Enabled = False
            chk_ctn_wmwl.Enabled = False
            chk_ctn_nmwol.Enabled = False
            chk_ctn_nmwl.Enabled = False

            chk_ctn_wmwol.Checked = False
            chk_ctn_wmwl.Checked = False
            chk_ctn_nmwol.Checked = False
            chk_ctn_nmwl.Checked = False
        Else
            chk_ctn_wmwol.Enabled = True
            chk_ctn_wmwl.Enabled = True
            chk_ctn_nmwol.Enabled = True
            chk_ctn_nmwl.Enabled = True
        End If
    End Sub

    Private Sub chk_use_idk_CheckedChanged(sender As Object, e As EventArgs) Handles chk_use_idk.CheckedChanged
        If chk_use_idk.CheckState = CheckState.Checked Then
            chk_use_food.Enabled = False
            chk_use_chem.Enabled = False
            chk_use_fuel.Enabled = False
            chk_use_noprev.Enabled = False
            chk_use_other.Enabled = False

            chk_use_food.Checked = False
            chk_use_chem.Checked = False
            chk_use_fuel.Checked = False
            chk_use_noprev.Checked = False
            chk_use_other.Checked = False
        Else
            chk_use_food.Enabled = True
            chk_use_chem.Enabled = True
            chk_use_fuel.Enabled = True
            chk_use_noprev.Enabled = True
            chk_use_other.Enabled = True
        End If
    End Sub

    Private Sub chk_fetch_idk_CheckedChanged(sender As Object, e As EventArgs) Handles chk_fetch_idk.CheckedChanged
        If chk_fetch_idk.CheckState = CheckState.Checked Then
            chk_fetch_wmwol.Enabled = False
            chk_fetch_wmwl.Enabled = False
            chk_fetch_nmwol.Enabled = False
            chk_fetch_nmwl.Enabled = False

            chk_fetch_wmwol.Checked = False
            chk_fetch_wmwl.Checked = False
            chk_fetch_nmwol.Checked = False
            chk_fetch_nmwl.Checked = False
        Else
            chk_fetch_wmwol.Enabled = True
            chk_fetch_wmwl.Enabled = True
            chk_fetch_nmwol.Enabled = True
            chk_fetch_nmwl.Enabled = True
        End If
    End Sub

    Private Sub chk_cwaste_idk_CheckedChanged(sender As Object, e As EventArgs) Handles chk_cwaste_idk.CheckedChanged
        If chk_cwaste_idk.CheckState = CheckState.Checked Then
            chk_cwaste_usetoilet.Enabled = False
            chk_cwaste_left.Enabled = False
            chk_cwaste_wash.Enabled = False
            chk_cwaste_bury.Enabled = False
            chk_cwaste_yard.Enabled = False
            chk_cwaste_bush.Enabled = False
            chk_cwaste_toilet.Enabled = False

            chk_cwaste_usetoilet.Checked = False
            chk_cwaste_left.Checked = False
            chk_cwaste_wash.Checked = False
            chk_cwaste_bury.Checked = False
            chk_cwaste_yard.Checked = False
            chk_cwaste_bush.Checked = False
            chk_cwaste_toilet.Checked = False
        Else
            chk_cwaste_usetoilet.Enabled = True
            chk_cwaste_left.Enabled = True
            chk_cwaste_wash.Enabled = True
            chk_cwaste_bury.Enabled = True
            chk_cwaste_yard.Enabled = True
            chk_cwaste_bush.Enabled = True
            chk_cwaste_toilet.Enabled = True

        End If
    End Sub

    Private Sub chk_lat_idk_CheckedChanged(sender As Object, e As EventArgs) Handles chk_lat_idk.CheckedChanged
        If chk_lat_idk.CheckState = CheckState.Checked Then
            chk_lat_comfy.Enabled = False
            chk_lat_status.Enabled = False
            chk_lat_privacy.Enabled = False
            chk_lat_hygiene.Enabled = False
            chk_lat_poll.Enabled = False
            chk_lat_prev.Enabled = False

            chk_lat_comfy.Checked = False
            chk_lat_status.Checked = False
            chk_lat_privacy.Checked = False
            chk_lat_hygiene.Checked = False
            chk_lat_poll.Checked = False
            chk_lat_prev.Checked = False
        Else
            chk_lat_comfy.Enabled = True
            chk_lat_status.Enabled = True
            chk_lat_privacy.Enabled = True
            chk_lat_hygiene.Enabled = True
            chk_lat_poll.Enabled = True
            chk_lat_prev.Enabled = True
        End If
    End Sub

    Private Sub txt_own_spec_TextChanged(sender As Object, e As EventArgs) Handles txt_own_spec.TextChanged
        If cb_own_other.CheckState = CheckState.Checked Then
            txt_own_spec.Enabled = True
        Else
            txt_own_spec.Enabled = False
            txt_own_spec.Clear()
        End If
    End Sub

    Private Sub chk_timeunknown_CheckedChanged(sender As Object, e As EventArgs) Handles chk_timeunknown.CheckedChanged
        If chk_timeunknown.CheckState = CheckState.Checked Then
            txt_fetch_time.Enabled = False
            txt_fetch_time.Clear()
        Else
            txt_fetch_time.Enabled = True
        End If
    End Sub

    Private Sub chk_brk_idk_CheckedChanged(sender As Object, e As EventArgs) Handles chk_brk_idk.CheckedChanged
        If chk_brk_idk.CheckState = CheckState.Checked Then
            chk_brk_wpc.Enabled = False
            chk_brk_plumber.Enabled = False
            chk_brk_head.Enabled = False
            chk_brk_repair.Enabled = False
            chk_brk_nothing.Enabled = False
            chk_brk_other.Enabled = False

            chk_brk_wpc.Checked = False
            chk_brk_plumber.Checked = False
            chk_brk_head.Checked = False
            chk_brk_repair.Checked = False
            chk_brk_nothing.Checked = False
            chk_brk_other.Checked = False
        Else
            chk_brk_wpc.Enabled = True
            chk_brk_plumber.Enabled = True
            chk_brk_head.Enabled = True
            chk_brk_repair.Enabled = True
            chk_brk_nothing.Enabled = True
            chk_brk_other.Enabled = True
        End If
    End Sub

    Private Sub cb_dr_idk_CheckedChanged(sender As Object, e As EventArgs) Handles cb_dr_idk.CheckedChanged
        If cb_dr_idk.CheckState = CheckState.Checked Then
            cb_dr_boil.Enabled = False
            cb_dr_bleach.Enabled = False
            cb_dr_strain.Enabled = False
            cb_dr_filter.Enabled = False
            cb_dr_solar.Enabled = False
            cb_dr_settle.Enabled = False
            cb_dr_tablet.Enabled = False
            cb_dr_other.Enabled = False
            cb_dr_specify.Enabled = False

            cb_dr_boil.Checked = False
            cb_dr_bleach.Checked = False
            cb_dr_strain.Checked = False
            cb_dr_filter.Checked = False
            cb_dr_solar.Checked = False
            cb_dr_settle.Checked = False
            cb_dr_tablet.Checked = False
            cb_dr_other.Checked = False
            cb_dr_specify.Enabled = False
        Else
            cb_dr_boil.Enabled = True
            cb_dr_bleach.Enabled = True
            cb_dr_strain.Enabled = True
            cb_dr_filter.Enabled = True
            cb_dr_solar.Enabled = True
            cb_dr_settle.Enabled = True
            cb_dr_tablet.Enabled = True
            cb_dr_other.Enabled = True
            cb_dr_specify.Enabled = True
        End If
    End Sub

    Private Sub cb_wtr_act_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_wtr_act.SelectedIndexChanged
        If cb_wtr_act.Text.Trim.ToLower = "yes" Or cb_wtr_act.Text.Trim = "I don’t know" Then
            cb_dr_boil.Enabled = True
            cb_dr_bleach.Enabled = True
            cb_dr_strain.Enabled = True
            cb_dr_filter.Enabled = True
            cb_dr_solar.Enabled = True
            cb_dr_settle.Enabled = True
            cb_dr_tablet.Enabled = True
            cb_dr_idk.Enabled = True
            cb_dr_other.Enabled = True
            cb_dr_specify.Enabled = False

            cbt_comm_treat.Enabled = False
            txt_comm_specify.Enabled = False

            cbt_comm_treat.Enabled = True
            chk_treat_treated.Enabled = False
            chk_treat_qlty.Enabled = False
            chk_treat_nomoney.Enabled = False
            chk_treat_notaware.Enabled = False
            chk_treat_other.Enabled = False
            txt_treat_specify.Enabled = False

            cb_treat_method.Enabled = True
            cb_not_able_totreat.Enabled = False

            chk_treat_treated.Checked = False
            chk_treat_qlty.Checked = False
            chk_treat_nomoney.Checked = False
            chk_treat_notaware.Checked = False
            chk_treat_other.Checked = False
            txt_treat_specify.Clear()
            cb_not_able_totreat.SelectedIndex = -1

        Else
            cb_dr_boil.Enabled = False
            cb_dr_bleach.Enabled = False
            cb_dr_strain.Enabled = False
            cb_dr_filter.Enabled = False
            cb_dr_solar.Enabled = False
            cb_dr_settle.Enabled = False
            cb_dr_tablet.Enabled = False
            cb_dr_idk.Enabled = False
            cb_dr_other.Enabled = False
            cb_dr_specify.Enabled = False

            cbt_comm_treat.Enabled = False
            txt_comm_specify.Enabled = False

            chk_treat_treated.Enabled = True
            chk_treat_qlty.Enabled = True
            chk_treat_nomoney.Enabled = True
            chk_treat_notaware.Enabled = True
            chk_treat_other.Enabled = True
            txt_treat_specify.Enabled = False

            cb_treat_method.Enabled = False
            cb_not_able_totreat.Enabled = True

            cb_dr_boil.Checked = False
            cb_dr_bleach.Checked = False
            cb_dr_strain.Checked = False
            cb_dr_filter.Checked = False
            cb_dr_solar.Checked = False
            cb_dr_settle.Checked = False
            cb_dr_tablet.Checked = False
            cb_dr_idk.Checked = False
            cb_dr_other.Checked = False
            txt_treat_specify.Clear()
            txt_comm_specify.Clear()
            cb_dr_specify.Clear()
            cbt_comm_treat.SelectedIndex = -1
            cb_treat_method.SelectedIndex = -1

        End If

    End Sub

    Private Sub txt_wtr_cost_TextChanged(sender As Object, e As EventArgs) Handles txt_wtr_cost.TextChanged
        If cb_wtr_pay.Text.Trim.ToLower = "yes" Then
            txt_wtr_cost.Enabled = True
        Else
            txt_wtr_cost.Enabled = False
        End If
    End Sub

    Private Sub cb_lat_emptiedby_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_lat_emptiedby.SelectedIndexChanged
        If cb_last_emptied.Text.Trim.ToLower = "yes emptied" Then
            cb_lat_emptiedby.Enabled = True
            cb_waste_disposed_to.Enabled = True
        Else
            cb_lat_emptiedby.Enabled = False
            cb_waste_disposed_to.Enabled = False
            cb_lat_emptiedby.SelectedIndex = -1
        End If
    End Sub

    Private Sub chk_smp_idk_CheckedChanged(sender As Object, e As EventArgs) Handles chk_smp_idk.CheckedChanged
        If chk_smp_idk.CheckState = CheckState.Checked Then
            chk_smp_boil.Enabled = False
            chk_smp_bleach.Enabled = False
            chk_smp_strain.Enabled = False
            chk_smp_filter.Enabled = False
            chk_smp_solar.Enabled = False
            chk_smp_settle.Enabled = False
            chk_smp_tablet.Enabled = False
            chk_smp_other.Enabled = False
            txt_smp_specify.Enabled = False

            chk_smp_boil.Checked = False
            chk_smp_bleach.Checked = False
            chk_smp_strain.Checked = False
            chk_smp_filter.Checked = False
            chk_smp_solar.Checked = False
            chk_smp_settle.Checked = False
            chk_smp_tablet.Checked = False
            chk_smp_other.Checked = False
            txt_smp_specify.Clear()
        Else
            chk_smp_boil.Enabled = True
            chk_smp_bleach.Enabled = True
            chk_smp_strain.Enabled = True
            chk_smp_filter.Enabled = True
            chk_smp_solar.Enabled = True
            chk_smp_settle.Enabled = True
            chk_smp_tablet.Enabled = True
            chk_smp_other.Enabled = True
            txt_smp_specify.Enabled = True
        End If
    End Sub

    Private Sub cb_water_sample_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_water_sample.SelectedIndexChanged
        If cb_water_sample.Text.Trim.ToLower = "yes" Then
            cb_contact.Enabled = True
            txt_source1_barcode.Enabled = True
            txt_source2_barcode.Enabled = True
            dtp_fetch_date.Enabled = True
            txt_fetch_time.Enabled = True
            chk_timeunknown.Enabled = True
            cb_sample_treated.Enabled = True
            txt_PH_result.Enabled = True
            txt_turbidity.Enabled = True
            txt_chlorine.Enabled = True

            chk_smp_boil.Enabled = True
            chk_smp_bleach.Enabled = True
            chk_smp_strain.Enabled = True
            chk_smp_filter.Enabled = True
            chk_smp_solar.Enabled = True
            chk_smp_settle.Enabled = True
            chk_smp_tablet.Enabled = True
            chk_smp_idk.Enabled = True
            chk_smp_other.Enabled = True
        Else
            cb_contact.Enabled = False
            txt_source1_barcode.Enabled = False
            txt_source2_barcode.Enabled = False
            dtp_fetch_date.Enabled = False
            return_date = "1990-10-10"
            dtp_fetch_date.Value = return_date
            txt_fetch_time.Enabled = False
            chk_timeunknown.Enabled = False
            cb_sample_treated.Enabled = False
            txt_PH_result.Enabled = False
            txt_turbidity.Enabled = False
            txt_chlorine.Enabled = False

            chk_smp_boil.Enabled = False
            chk_smp_bleach.Enabled = False
            chk_smp_strain.Enabled = False
            chk_smp_filter.Enabled = False
            chk_smp_solar.Enabled = False
            chk_smp_settle.Enabled = False
            chk_smp_tablet.Enabled = False
            chk_smp_idk.Enabled = False
            chk_smp_other.Enabled = False

            cb_contact.Clear()
            txt_source1_barcode.Clear()
            txt_source2_barcode.Clear()
            txt_fetch_time.Clear()
            chk_timeunknown.Checked = False
            cb_sample_treated.SelectedIndex = -1
            txt_PH_result.Clear()
            txt_turbidity.Clear()
            txt_chlorine.Clear()

            chk_smp_boil.Checked = False
            chk_smp_bleach.Checked = False
            chk_smp_strain.Checked = False
            chk_smp_filter.Checked = False
            chk_smp_solar.Checked = False
            chk_smp_settle.Checked = False
            chk_smp_tablet.Checked = False
            chk_smp_idk.Checked = False
            chk_smp_other.Checked = False
        End If
    End Sub

    Private Sub chk_brk_other_CheckedChanged(sender As Object, e As EventArgs) Handles chk_brk_other.CheckedChanged
        If chk_brk_other.CheckState = CheckState.Checked Then
            txt_brk_specify.Enabled = True
        Else
            txt_brk_specify.Enabled = False
            txt_brk_specify.Clear()
        End If
    End Sub

    Private Sub cb_dr_other_CheckedChanged(sender As Object, e As EventArgs) Handles cb_dr_other.CheckedChanged
        If cb_dr_other.CheckState = CheckState.Checked Then
            cb_dr_specify.Enabled = True
        Else
            cb_dr_specify.Enabled = False
            cb_dr_specify.Clear()
        End If
    End Sub

    Private Sub chk_treat_other_CheckedChanged(sender As Object, e As EventArgs) Handles chk_treat_other.CheckedChanged
        If chk_treat_other.CheckState = CheckState.Checked Then
            txt_treat_specify.Enabled = True
        Else
            txt_treat_specify.Enabled = False
            txt_treat_specify.Clear()
        End If
    End Sub

    Private Sub cb_last_emptied_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_last_emptied.SelectedIndexChanged
        If cb_last_emptied.Text.Trim = "Yes emptied" Then
            cb_waste_disposed_to.Enabled = True
            cb_lat_emptiedby.Enabled = True
            cb_waste_leak.Enabled = False
        Else
            cb_lat_emptiedby.Enabled = False
            cb_waste_disposed_to.Enabled = False
            cb_waste_leak.Enabled = False
            cb_lat_emptiedby.SelectedIndex = -1
            cb_waste_disposed_to.SelectedIndex = -1
            cb_waste_leak.SelectedIndex = -1
        End If
        If cb_last_emptied.Text.Trim = "Never emptied" Then
            cb_waste_leak.Enabled = True
        Else
            cb_waste_leak.Enabled = False
            cb_waste_leak.SelectedIndex = -1

        End If

    End Sub

    Private Sub cb_sewer_disp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_sewer_disp.SelectedIndexChanged
        If cb_sewer_disp.Text.Trim = "Septic tank" Or cb_sewer_disp.Text.Trim = "Pit latrine" Then
            cb_last_emptied.Enabled = True
        Else
            cb_last_emptied.Enabled = False
            cb_last_emptied.SelectedIndex = -1
        End If
    End Sub

    Private Sub cb_own_other_CheckedChanged(sender As Object, e As EventArgs) Handles cb_own_other.CheckedChanged
        If cb_own_other.CheckState = CheckState.Checked Then
            txt_own_spec.Enabled = True
        Else
            txt_own_spec.Enabled = False
            txt_own_spec.Clear()
        End If
    End Sub

    Private Sub chk_smp_other_CheckedChanged(sender As Object, e As EventArgs) Handles chk_smp_other.CheckedChanged
        If chk_smp_other.CheckState = CheckState.Checked Then
            txt_smp_specify.Enabled = True
        Else
            txt_smp_specify.Enabled = False
            txt_smp_specify.Clear()
        End If
    End Sub

    Private Sub ComboBox54_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox54.SelectedIndexChanged
        If ComboBox54.Text.Trim = "No" Then
            chk_cwaste_usetoilet.Enabled = False
            chk_cwaste_left.Enabled = False
            chk_cwaste_wash.Enabled = False
            chk_cwaste_bury.Enabled = False
            chk_cwaste_yard.Enabled = False
            chk_cwaste_bush.Enabled = False
            chk_cwaste_toilet.Enabled = False
            chk_cwaste_idk.Enabled = False

            chk_cwaste_usetoilet.Checked = False
            chk_cwaste_left.Checked = False
            chk_cwaste_wash.Checked = False
            chk_cwaste_bury.Checked = False
            chk_cwaste_yard.Checked = False
            chk_cwaste_bush.Checked = False
            chk_cwaste_toilet.Checked = False
            chk_cwaste_idk.Checked = False
        Else
            chk_cwaste_usetoilet.Enabled = True
            chk_cwaste_left.Enabled = True
            chk_cwaste_wash.Enabled = True
            chk_cwaste_bury.Enabled = True
            chk_cwaste_yard.Enabled = True
            chk_cwaste_bush.Enabled = True
            chk_cwaste_toilet.Enabled = True
            chk_cwaste_idk.Enabled = True
        End If
    End Sub

    Private Sub cb_livelihood_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_livelihood.SelectedIndexChanged
        If cb_livelihood.Text = "Other" Then
            txt_livelihood_other.Enabled = True
        Else
            txt_livelihood_other.Enabled = False
            txt_livelihood_other.Clear()
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If txt_waterplace.Text = "" Then
            MsgBox("Enter the different drinking water sources")
            Exit Sub
        End If
        If cb_placedesc.Text = "" Then
            MsgBox("Enter description of the water source")
            Exit Sub
        End If
        If cb_place_season.Text = "" Then
            MsgBox("Enter what seasons the water place is used")
            Exit Sub
        End If
        If cb_ranks.Text = "" Then
            MsgBox("Mark the two main water sources")
            Exit Sub
        End If
        If cb_mostused.Text = "" Then
            MsgBox("Enter most used water source")
            Exit Sub
        End If
        If cb_secondmost_used.Text = "" Then
            MsgBox("Enter second most used water source")
            Exit Sub
        End If

        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage3)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage5)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If cb_wtr_act.Text.Trim.ToLower = "yes" And cb_treat_method.Text = "" Then
            MsgBox("Enter how often you treat the water")
            Exit Sub
        End If
        If cb_wtr_act.Text.Trim.ToLower = "no" And cb_not_able_totreat.Text = "" Then
            MsgBox("Enter main reason why water can't be treated")
            Exit Sub
        End If
        If cb_treat_lastfetch.Text = "" Then
            MsgBox("Enter if water was treated on last fetch")
            Exit Sub
        End If
        If cb_wtr_pay.Text = "" Then
            MsgBox("Enter if you pay for the water")
            Exit Sub
        End If
        If cb_wtr_pay.Text = "Yes" And txt_wtr_cost.Text = "" Then
            MsgBox("Enter cost of water")
            Exit Sub
        End If
        If cb_wtr_hand.Text = "" Then
            MsgBox("Enter if water is used for handwashing")
            Exit Sub
        End If
        If cb_wtr_laundry.Text = "" Then
            MsgBox("Enter if water is used for laundry")
            Exit Sub
        End If
        If cb_wtr_cook.Text = "" Then
            MsgBox("Enter if water is used for cooking")
            Exit Sub
        End If
        If cb_wtr_bath.Text = "" Then
            MsgBox("Enter if water is used for bathing")
            Exit Sub
        End If


        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage7)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If ComboBox1.Text = "" Then
            MsgBox("Enter Sex of respondent")
            Exit Sub
        End If
        If NumericUpDown1.Value <= 0 Then
            MsgBox("Enter value of all ages")
            Exit Sub
        End If
        If ComboBox3.Text = "" Then
            MsgBox("Enter highest level of education")
            Exit Sub
        End If
        If cb_livelihood.Text = "" Then
            MsgBox("Enter source of livelihood")
            Exit Sub
        End If
        If cb_livelihood.Text.Trim.ToLower = "other" And txt_livelihood_other.Text = "" Then
            MsgBox("Specify other source of livelihood")
            Exit Sub
        End If

        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage2)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage4)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If txt_wtr_sourcelocation.Text = "" Then
            MsgBox("Describe where water source is")
            Exit Sub
        End If
        If cb_wtr_indwelling.Text = "" Then
            MsgBox("Enter if there is a water source within the dwelling")
            Exit Sub
        End If
        If cb_wtr_allways.Text = "" Then
            MsgBox("Enter water source reliability")
            Exit Sub
        End If
        If cb_season_rsn.Text = "" Then
            MsgBox("Enter reasosns why water may be unavailable")
            Exit Sub
        End If
        If cb_wtr_paid.Text = "" Then
            MsgBox("Enter how the water is paid for")
            Exit Sub
        End If
        If cb_hh_pays.Text = "" Then
            MsgBox("Enter if your household contributes monetarily towares water point maintenance")
            Exit Sub
        End If
        If cb_repair_time.Text = "" Then
            MsgBox("Enter how long it takes to repair water source in the event of a breakdown")
            Exit Sub
        End If

        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage14)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If chk_brk_idk.CheckState = CheckState.Checked = False And
            chk_brk_wpc.CheckState = CheckState.Checked = False And
            chk_brk_plumber.CheckState = CheckState.Checked = False And
            chk_brk_head.CheckState = CheckState.Checked = False And
            chk_brk_repair.CheckState = CheckState.Checked = False And
            chk_brk_nothing.CheckState = CheckState.Checked = False And
            chk_brk_other.CheckState = CheckState.Checked = False Then
            MsgBox("Check atleast one option")
            Exit Sub
        End If
        If chk_brk_other.Checked = True And txt_brk_specify.Text = "" Then
            MsgBox("Specify Other solution checked")
            Exit Sub
        End If
        If cb_wtr_trip_time.Text = "" Then
            MsgBox("Enter the amount of time it takes to reach the source")
            Exit Sub
        End If
        If cb_means_waterscource.Text = "" Then
            MsgBox("Enter the means used to reach the water source")
            Exit Sub
        End If
        If cb_wtr_distance.Text = "" Then
            MsgBox("Ënter how far the water source is from home")
            Exit Sub
        End If
        If cb_wk_trips.Text = "" Then
            MsgBox("Enter your weekly number of trips to water soure")
            Exit Sub
        End If

        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage5)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If cb_wtr_quality.Text = "" Then
            MsgBox("Enter if supplied water is safe for drinking")
            Exit Sub
        End If
        If cb_wtr_quality.Text.Trim.ToLower = "no" And cb_quality_rsn.Text = "" Then
            MsgBox("Enter what makes water unsafe")
            Exit Sub
        End If
        If cb_quality_rsn.Text.Trim.ToLower = "other" And txt_qual_rsn_other.Text = "" Then
            MsgBox("Specify other reason why water is unsafe for drinking")
            Exit Sub
        End If
        If cb_wtr_act.Text = "" Then
            MsgBox("Enter if you use the water for cleaning")
            Exit Sub
        End If
        If cb_wtr_act.Text = "Yes" And
            cb_dr_idk.CheckState = CheckState.Checked = False And
            cb_dr_boil.CheckState = CheckState.Checked = False And
            cb_dr_bleach.CheckState = CheckState.Checked = False And
            cb_dr_strain.CheckState = CheckState.Checked = False And
            cb_dr_filter.CheckState = CheckState.Checked = False And
            cb_dr_solar.CheckState = CheckState.Checked = False And
            cb_dr_settle.CheckState = CheckState.Checked = False And
            cb_dr_tablet.CheckState = CheckState.Checked = False And
            cb_dr_other.CheckState = CheckState.Checked = False Then
            MsgBox("Check the relevant options (2.7.1)")
            Exit Sub
        End If
        If cb_dr_other.Checked = True And cb_dr_specify.Text = "" Then
            MsgBox("Specify Other water treatment method checked")
            Exit Sub
        End If
        If cb_wtr_act.Text = "Yes" And cbt_comm_treat.Text = "" Then
            MsgBox("Enter most used treatment method")
            Exit Sub
        End If
        If cb_wtr_act.Text = "I don’t know" And cbt_comm_treat.Text = "" Then
            MsgBox("Enter most used treatment method")
            Exit Sub

        End If
        If cbt_comm_treat.Text.Trim.ToLower = "other" And txt_comm_specify.Text = "" Then
            MsgBox("Specify other common treatment method")
            Exit Sub
        End If
        If chk_treat_other.Checked = True And txt_treat_specify.Text = "" Then
            MsgBox("Specify other reason checked why water is not treated")
            Exit Sub
        End If
        If cb_wtr_act.Text = "No" And
            chk_treat_treated.CheckState = CheckState.Checked = False And
            chk_treat_qlty.CheckState = CheckState.Checked = False And
            chk_treat_nomoney.CheckState = CheckState.Checked = False And
            chk_treat_notaware.CheckState = CheckState.Checked = False And
            chk_treat_other.CheckState = CheckState.Checked = False Then
            MsgBox("Check the relevant options (2.7.2)")
            Exit Sub
        End If

        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage6)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If txt_wtr_containers.Text = "" Then
            MsgBox("Enter number of visible storage containers")
            Exit Sub
        End If
        If chk_ctn_idk.CheckState = CheckState.Checked = False And
            chk_ctn_wmwol.CheckState = CheckState.Checked = False And
            chk_ctn_wmwl.CheckState = CheckState.Checked = False And
            chk_ctn_nmwol.CheckState = CheckState.Checked = False And
            chk_ctn_nmwl.CheckState = CheckState.Checked = False Then
            MsgBox("Check the relevant boxes (3.1.1)")
            Exit Sub
        End If
        If chk_use_idk.CheckState = CheckState.Checked = False And
            chk_use_food.CheckState = CheckState.Checked = False And
            chk_use_chem.CheckState = CheckState.Checked = False And
            chk_use_fuel.CheckState = CheckState.Checked = False And
            chk_use_noprev.CheckState = CheckState.Checked = False And
            chk_use_other.CheckState = CheckState.Checked = False Then
            MsgBox("Check the relevant boxes (3.1.2)")
            Exit Sub
        End If
        If chk_draw_spiggot.CheckState = CheckState.Checked = False And
            chk_draw_pour.CheckState = CheckState.Checked = False And
            chk_draw_other.CheckState = CheckState.Checked = False Then
            MsgBox("Check the relevnant boxes (3.1.3)")
            Exit Sub
        End If

        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage8)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If cb_wtr_fetch_keep.Text = "" Then
            MsgBox("Enter if you use containers to fetch and store water")
            Exit Sub
        End If
        If (cb_wtr_fetch_keep.Text.Trim = "Yes, all are used for fetching water." Or cb_wtr_fetch_keep.Text.Trim = "Yes, some are for fetching water.") And txt_num_cont.Text = "" Then
            MsgBox("Enter shown fetch containers")
            Exit Sub
        End If
        If (cb_wtr_fetch_keep.Text.Trim = "Yes, all are used for fetching water." Or cb_wtr_fetch_keep.Text.Trim = "Yes, some are for fetching water.") And cb_conta_vol.Text = "" Then
            MsgBox("Enter approximate liters containers can hold")
            Exit Sub
        End If
        If chk_fetch_idk.CheckState = CheckState.Checked = False And
            chk_fetch_wmwol.CheckState = CheckState.Checked = False And
            chk_fetch_wmwl.CheckState = CheckState.Checked = False And
            chk_fetch_nmwol.CheckState = CheckState.Checked = False And
            chk_fetch_nmwl.CheckState = CheckState.Checked = False Then
            MsgBox("Check the relevant boxes (3.2.2)")
            Exit Sub
        End If
        If cb_wtr_avail.Text = "" Then
            MsgBox("Enter if drinking water availability has been insufficient")
            Exit Sub
        End If
        If cb_wtr_avail.Text = "Yes" And cb_no_drinking.Text = "" Then
            MsgBox("Enter reason why drinking water was insuffient")
            Exit Sub
        End If
        If cb_no_drinking.Text.Trim.ToLower = "other" And txt_other_no_drinkingwater.Text = "" Then
            MsgBox("Specify other reason")
            Exit Sub
        End If


        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage9)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If cb_toilet_desc.Text = "" Then
            MsgBox("Enter toilet description")
            Exit Sub
        End If
        If cbt_toil_share.Text = "" Then
            MsgBox("Enter if toilet is shared")
            Exit Sub
        End If
        If cbt_toil_share.Text.Trim.ToLower = "yes" And cb_share_toilet.Text = "" Then
            MsgBox("Enter if public toilet is shared")
            Exit Sub
        End If
        If cb_toilet_loc.Text = "" Then
            MsgBox("Enter toilet location")
            Exit Sub
        End If
        If cb_toilet_type.Text = "" Then
            MsgBox("Enter toilet type")
            Exit Sub
        End If
        If cb_toilet_type.Text.Trim = "Flush or pour flush" And cb_sewer_disp.Text = "" Then
            MsgBox("Enter where the sewer is flushed")
            Exit Sub
        End If
        If cb_toilet_type.Text.Trim = "Dry pit latrine" And cb_pit_type.Text = "" Then
            MsgBox("Enter pit type")
            Exit Sub
        End If
        If cb_toilet_type.Text.Trim = "Dry pit latrine" And cb_last_emptied.Text = "" Then
            MsgBox("Enter last emptied")
            Exit Sub
        End If
        If (cb_sewer_disp.Text.Trim = "Septic tank" Or cb_sewer_disp.Text.Trim = "Pit latrine") And cb_last_emptied.Text = "" Then
            MsgBox("Enter last emptied")
            Exit Sub
        End If
        If cb_last_emptied.Text.Trim = "Yes emptied" And cb_lat_emptiedby.Text = "" Then
            MsgBox("Enter who last emptied the sewer/pit")
            Exit Sub
        End If


        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage10)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If cb_last_emptied.Text.Trim = "Yes emptied" And cb_waste_disposed_to.Text = "" Then
            MsgBox("Enter where sewer was disposed to")
            Exit Sub
        End If
        If cb_last_emptied.Text.Trim = "Never emptied" And cb_waste_leak.Text = "" Then
            MsgBox("Enter if waste leaks")
            Exit Sub
        End If
        If ComboBox54.Text = "" Then
            MsgBox("Enter if children under 5 yrs live in the area")
            Exit Sub
        End If
        If ComboBox54.Text = "Yes" And
            chk_cwaste_idk.CheckState = CheckState.Checked = False And
            chk_cwaste_usetoilet.CheckState = CheckState.Checked = False And
            chk_cwaste_left.CheckState = CheckState.Checked = False And
            chk_cwaste_wash.CheckState = CheckState.Checked = False And
            chk_cwaste_bury.CheckState = CheckState.Checked = False And
            chk_cwaste_yard.CheckState = CheckState.Checked = False And
            chk_cwaste_bush.CheckState = CheckState.Checked = False And
            chk_cwaste_toilet.CheckState = CheckState.Checked = False Then
            MsgBox("Check the relevant boxes (4.2.1)")
            Exit Sub
        End If
        If chk_lat_idk.CheckState = CheckState.Checked = False And
            chk_lat_comfy.CheckState = CheckState.Checked = False And
            chk_lat_status.CheckState = CheckState.Checked = False And
            chk_lat_privacy.CheckState = CheckState.Checked = False And
            chk_lat_hygiene.CheckState = CheckState.Checked = False And
            chk_lat_poll.CheckState = CheckState.Checked = False And
            chk_lat_prev.CheckState = CheckState.Checked = False Then
            MsgBox("Check the relevant boxes (4.3)")
            Exit Sub
        End If

        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage11)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If cb_washh_place.Text = "" Then
            MsgBox("Enter if handwashing facility is present")
            Exit Sub
        End If
        If Not (cb_washh_place.Text.Trim = "No handwashing place in dwelling/plot/yard" Or cb_washh_place.Text.Trim = "No permission to see") And txt_hand_was_place.Text = "" Then
            MsgBox("Show handwashing facility")
            Exit Sub
        End If
        If Not (cb_washh_place.Text.Trim = "No handwashing place in dwelling/plot/yard" Or cb_washh_place.Text.Trim = "No permission to see") And cb_wash_wtr_cont.Text = "" Then
            MsgBox("Enter if water is availabe at handwashing place")
            Exit Sub
        End If
        If Not (cb_washh_place.Text.Trim = "No handwashing place in dwelling/plot/yard" Or cb_washh_place.Text.Trim = "No permission to see") And cb_soap_avail.Text = "" Then
            MsgBox("Enter if soap is available")
            Exit Sub
        End If
        If chk_wash_abreastfeed.CheckState = CheckState.Checked = False And
                chk_wash_afeces.CheckState = CheckState.Checked = False And
                chk_wash_atoil.CheckState = CheckState.Checked = False And
                chk_wash_bbreastfeed.CheckState = CheckState.Checked = False And
                chk_wash_bcooking.CheckState = CheckState.Checked = False And
                chk_wash_beat.CheckState = CheckState.Checked = False And
                chk_wash_need.CheckState = CheckState.Checked = False And
            chk_wash_aeat.CheckState = CheckState.Checked = False Then
            MsgBox("Check the relevant boxes (5.4)")
            Exit Sub
        End If
        If chk_wash_cpractice.CheckState = CheckState.Checked = False And
                chk_wash_clean.CheckState = CheckState.Checked = False And
                chk_wash_avoid.CheckState = CheckState.Checked = False And
                chk_wash_smell.CheckState = CheckState.Checked = False And
            chk_wash_other.CheckState = CheckState.Checked = False Then
            MsgBox("Check the relevant boxes (5.4.1)")
            Exit Sub
        End If
        If chk_wash_other.CheckState = True And chk_wash_specify.Text = "" Then
            MsgBox("Specify other reason")
            Exit Sub
        End If

        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage12)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If cb_own_cats.CheckState = CheckState.Checked = False And
                cb_own_chick.CheckState = CheckState.Checked = False And
                cb_own_dog.CheckState = CheckState.Checked = False And
                cb_own_duck.CheckState = CheckState.Checked = False And
                cb_own_goats.CheckState = CheckState.Checked = False And
                cb_own_other.CheckState = CheckState.Checked = False And
                cb_own_pigs.CheckState = CheckState.Checked = False And
                cb_own_sheep.CheckState = CheckState.Checked = False And
                cb_own_cattle.CheckState = CheckState.Checked = False Then
            MsgBox("Check the relevant boxes (6.1)")
            Exit Sub
        End If
        If cb_c_cat.CheckState = CheckState.Checked = False And
                cb_c_chick.CheckState = CheckState.Checked = False And
                cb_c_dog.CheckState = CheckState.Checked = False And
                cb_c_duck.CheckState = CheckState.Checked = False And
                cb_c_goats.CheckState = CheckState.Checked = False And
                cb_c_pig.CheckState = CheckState.Checked = False And
                cb_c_sheep.CheckState = CheckState.Checked = False And
                cb_c_cattle.CheckState = CheckState.Checked = False Then
            MsgBox("Check the relevant boxes (6.2)")
            Exit Sub
        End If
        If cb_hse_cat.CheckState = CheckState.Checked = False And
                cb_hse_cattle.CheckState = CheckState.Checked = False And
                cb_hse_chick.CheckState = CheckState.Checked = False And
                cb_hse_dog.CheckState = CheckState.Checked = False And
                cb_hse_duck.CheckState = CheckState.Checked = False And
                cb_hse_goat.CheckState = CheckState.Checked = False And
                cb_hse_pig.CheckState = CheckState.Checked = False And
                cb_hse_sheep.CheckState = CheckState.Checked = False Then
            MsgBox("Check the relevant boxes (6.3)")
            Exit Sub
        End If
        If cb_own_other.Checked = True And txt_own_spec.Text = "" Then
            MsgBox("Specify other reason checked")
            Exit Sub
        End If
        If txt_contact_days.Text = "" Then
            MsgBox("Enter how often you are in contact with the animals")
            Exit Sub
        End If
        If cb_care_animals.Text = "" Then
            MsgBox("Enter if any other member looks after the animals")
            Exit Sub
        End If


        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage13)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage2)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage3)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage4)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage14)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage6)
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage7)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage8)
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage9)
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage10)
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage11)
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage12)
    End Sub

    Private Sub chk_wash_other_CheckedChanged(sender As Object, e As EventArgs) Handles chk_wash_other.CheckedChanged
        If chk_wash_other.CheckState = CheckState.Checked Then
            chk_wash_specify.Enabled = True
        Else
            chk_wash_specify.Enabled = False
            chk_wash_specify.Clear()
        End If
    End Sub

    Private Sub frmWASH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage1)

        Label31.Text = listinvidividid + " | " + list_name + " " + listmname + " " + listlname + " | " + listsex + " | " + listdob

        OpenCon()
        Dim cmd As SqlCommand

        Try
            Using conn As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=washproject;Integrated Security=True;MultipleActiveResultSets=true")
                Dim reader As SqlDataReader
                Try
                    conn.Open()
                    Dim query As String
                    query = "SELECT * FROM wash WHERE individid = '" & listinvidividid & "'"
                    cmd = New SqlCommand(query, Qconn)
                    reader = cmd.ExecuteReader

                    While reader.Read
                        ComboBox1.Text = reader.Item("Gender")
                        NumericUpDown1.Value = reader.Item("AllAgesNumber")
                        ComboBox3.Text = reader.Item("EducationLevel")
                        cb_livelihood.Text = reader.Item("LivelihoodSource")
                        txt_livelihood_other.Text = reader.Item("DescribeOther")

                        txt_waterplace.Text = reader.Item("WaterPlace")
                        cb_placedesc.Text = reader.Item("SourceDescription")
                        cb_place_season.Text = reader.Item("PlaceSeason")
                        cb_ranks.Text = reader.Item("MainSources")
                        cb_mostused.Text = reader.Item("MostUsed")
                        cb_secondmost_used.Text = reader.Item("SecondMostUsed")

                        txt_wtr_sourcelocation.Text = reader.Item("SourceLocation")
                        cb_wtr_indwelling.Text = reader.Item("ExactLocation")
                        cb_wtr_allways.Text = reader.Item("SourceReliability")
                        cb_season_rsn.Text = reader.Item("NotReliableReason")
                        cb_wtr_paid.Text = reader.Item("Payments")
                        cb_hh_pays.Text = reader.Item("HouseContribution")
                        cb_repair_time.Text = reader.Item("RepairTime")

                        chk_brk_wpc.Checked = reader.Item("PointCommitte")
                        chk_brk_plumber.Checked = reader.Item("Plumber")
                        chk_brk_head.Checked = reader.Item("VilllageHead")
                        chk_brk_repair.Checked = reader.Item("SelfDone")
                        chk_brk_nothing.Checked = reader.Item("Nothing")
                        chk_brk_idk.Checked = reader.Item("DontKnow")
                        chk_brk_other.Checked = reader.Item("Other")
                        txt_brk_specify.Text = reader.Item("SpecifyOther")
                        cb_wtr_trip_time.Text = reader.Item("TripTime")
                        cb_means_waterscource.Text = reader.Item("Means")
                        cb_wtr_distance.Text = reader.Item("SourceDistance")
                        cb_wk_trips.Text = reader.Item("WeeklyTrips")

                        cb_wtr_quality.Text = reader.Item("WaterQuality")
                        cb_quality_rsn.Text = reader.Item("QualityNotAcceptable")
                        txt_qual_rsn_other.Text = reader.Item("Reason")
                        cb_wtr_act.Text = reader.Item("WaterClean")
                        cb_dr_boil.Checked = reader.Item("Boil")
                        cb_dr_bleach.Checked = reader.Item("Bleach")
                        cb_dr_strain.Checked = reader.Item("Strain")
                        cb_dr_filter.Checked = reader.Item("WaterFilter")
                        cb_dr_solar.Checked = reader.Item("SolarDisinfection")
                        cb_dr_settle.Checked = reader.Item("Settle")
                        cb_dr_tablet.Checked = reader.Item("TreatmentTablet")
                        cb_dr_idk.Checked = reader.Item("CleanDontKnow")
                        cb_dr_other.Checked = reader.Item("CleanOther")
                        cb_dr_specify.Text = reader.Item("CleanOtherSpecify")
                        cbt_comm_treat.Text = reader.Item("CommonTreatment")
                        txt_comm_specify.Text = reader.Item("OtherCommonTreatment")
                        chk_treat_treated.Checked = reader.Item("AlreadyTreated")
                        chk_treat_qlty.Checked = reader.Item("GoodQuality")
                        chk_treat_nomoney.Checked = reader.Item("NoMaterials")
                        chk_treat_notaware.Checked = reader.Item("NotAware")
                        chk_treat_other.Checked = reader.Item("OtherReason")
                        txt_treat_specify.Text = reader.Item("OtherReasonSpecify")

                        cb_treat_method.Text = reader.Item("TreatMethod")
                        cb_not_able_totreat.Text = reader.Item("NotAbleToTreat")
                        cb_treat_lastfetch.Text = reader.Item("LastTreat")
                        cb_wtr_pay.Text = reader.Item("SitePayment")
                        txt_wtr_cost.Text = reader.Item("SiteCost")
                        cb_wtr_hand.Text = reader.Item("Handwashing")
                        cb_wtr_laundry.Text = reader.Item("Laundry")
                        cb_wtr_cook.Text = reader.Item("Cooking")
                        cb_wtr_bath.Text = reader.Item("Bathing")

                        txt_wtr_containers.Text = reader.Item("Containers")
                        chk_ctn_nmwl.Checked = reader.Item("NarrowWithLid")
                        chk_ctn_nmwol.Checked = reader.Item("NarrowWithoutLid")
                        chk_ctn_wmwl.Checked = reader.Item("WideWithLid")
                        chk_ctn_wmwol.Checked = reader.Item("WideWithouLid")
                        chk_ctn_idk.Checked = reader.Item("DontKnowType")
                        chk_use_food.Checked = reader.Item("FoodStorage")
                        chk_use_chem.Checked = reader.Item("ChemicalStorage")
                        chk_use_fuel.Checked = reader.Item("Fuel")
                        chk_use_noprev.Checked = reader.Item("ForWater")
                        chk_use_other.Checked = reader.Item("OtherOriginalUse")
                        chk_use_idk.Checked = reader.Item("UseNotKnown")
                        chk_draw_spiggot.Checked = reader.Item("Spigot")
                        chk_draw_pour.Checked = reader.Item("Pour")
                        chk_draw_other.Checked = reader.Item("LadleLike")

                        cb_wtr_fetch_keep.Text = reader.Item("FetchAndKeep")
                        txt_num_cont.Text = reader.Item("FetchingContainers")
                        cb_conta_vol.Text = reader.Item("ContainerVolume")
                        chk_fetch_nmwl.Checked = reader.Item("withLid")
                        chk_fetch_nmwol.Checked = reader.Item("NoLid")
                        chk_fetch_wmwl.Checked = reader.Item("wideLid")
                        chk_fetch_wmwol.Checked = reader.Item("WideNoLid")
                        chk_fetch_idk.Checked = reader.Item("IDKType")
                        cb_wtr_avail.Text = reader.Item("WaterAvailability")
                        cb_no_drinking.Text = reader.Item("NotEnough")
                        txt_other_no_drinkingwater.Text = reader.Item("SpecifyNotEnough")

                        cb_toilet_desc.Text = reader.Item("ToiletDesc")
                        cbt_toil_share.Text = reader.Item("SharedToilet")
                        cb_share_toilet.Text = reader.Item("PublicOrShared")
                        cb_toilet_loc.Text = reader.Item("ToiletLocation")
                        cb_toilet_type.Text = reader.Item("ToiletType")
                        cb_sewer_disp.Text = reader.Item("SewageDirected")
                        cb_pit_type.Text = reader.Item("Slabbed")
                        cb_last_emptied.Text = reader.Item("Emptied")
                        cb_lat_emptiedby.Text = reader.Item("WhoEmptied")
                        cb_waste_disposed_to.Text = reader.Item("DisposalLocation")
                        cb_waste_leak.Text = reader.Item("Leaks")
                        ComboBox54.Text = reader.Item("ChildrenPresence")
                        chk_cwaste_toilet.Checked = reader.Item("DisposeToLatrine")
                        chk_cwaste_bush.Checked = reader.Item("RubbishPit")
                        chk_cwaste_yard.Checked = reader.Item("OutsideYard")
                        chk_cwaste_bury.Checked = reader.Item("Underground")
                        chk_cwaste_wash.Checked = reader.Item("WashAway")
                        chk_cwaste_left.Checked = reader.Item("LeftThere")
                        chk_cwaste_usetoilet.Checked = reader.Item("UsesLatrine")
                        chk_cwaste_idk.Checked = reader.Item("IdkHow")
                        chk_lat_prev.Checked = reader.Item("Diseases")
                        chk_lat_poll.Checked = reader.Item("Pollution")
                        chk_lat_hygiene.Checked = reader.Item("Hygienic")
                        chk_lat_privacy.Checked = reader.Item("Privacy")
                        chk_lat_status.Checked = reader.Item("CommunityStatus")
                        chk_lat_comfy.Checked = reader.Item("Comfort")
                        chk_lat_idk.Checked = reader.Item("IdkWhy")

                        cb_washh_place.Text = reader.Item("HandWashPlace")
                        txt_hand_was_place.Text = reader.Item("OtherPlace")
                        cb_wash_wtr_cont.Text = reader.Item("WaterPresence")
                        cb_soap_avail.Text = reader.Item("Detergents")
                        chk_wash_beat.Checked = reader.Item("BeforeEating")
                        chk_wash_atoil.Checked = reader.Item("AfterToilet")
                        chk_wash_bcooking.Checked = reader.Item("BeforeCooking")
                        chk_wash_aeat.Checked = reader.Item("AfterEating")
                        chk_wash_afeces.Checked = reader.Item("AfterFecesHandling")
                        chk_wash_bbreastfeed.Checked = reader.Item("BeforeBreastFeed")
                        chk_wash_abreastfeed.Checked = reader.Item("AfterBreastFeed")
                        chk_wash_need.Checked = reader.Item("Need")
                        chk_wash_clean.Checked = reader.Item("CleanHands")
                        chk_wash_avoid.Checked = reader.Item("AvoidDisease")
                        chk_wash_cpractice.Checked = reader.Item("CommonPrac")
                        chk_wash_smell.Checked = reader.Item("RemoveSmell")
                        chk_wash_other.Checked = reader.Item("OtherOpinion")
                        chk_wash_specify.Text = reader.Item("OtherOpinionSpecify")

                        cb_own_cattle.Checked = reader.Item("OwnCattle")
                        cb_own_goats.Checked = reader.Item("OwnGoat")
                        cb_own_sheep.Checked = reader.Item("OwnSheep")
                        cb_own_pigs.Checked = reader.Item("OwnPig")
                        cb_own_chick.Checked = reader.Item("OwnChicken")
                        cb_own_duck.Checked = reader.Item("OwnDucks")
                        cb_own_cats.Checked = reader.Item("OwnCats")
                        cb_own_dog.Checked = reader.Item("OwnDogs")
                        cb_own_other.Checked = reader.Item("OwnOther")

                        txt_own_spec.Text = reader.Item("SpecifyOwnOther")
                        cb_c_cattle.Checked = reader.Item("RoamCattle")
                        cb_c_goats.Checked = reader.Item("RoamGoat")
                        cb_c_sheep.Checked = reader.Item("RoamSheep")
                        cb_c_pig.Checked = reader.Item("RoamPigs")
                        cb_c_chick.Checked = reader.Item("RoamChicken")
                        cb_c_duck.Checked = reader.Item("RoamDucks")
                        cb_c_cat.Checked = reader.Item("RoamCats")
                        cb_c_dog.Checked = reader.Item("RoamDogs")
                        cb_hse_cattle.Checked = reader.Item("ContactCattle")
                        cb_hse_goat.Checked = reader.Item("contactGoat")
                        cb_hse_sheep.Checked = reader.Item("ContactSheep")
                        cb_hse_pig.Checked = reader.Item("ContactPigs")
                        cb_hse_chick.Checked = reader.Item("ContactChicken")
                        cb_hse_duck.Checked = reader.Item("ContactDucks")
                        cb_hse_cat.Checked = reader.Item("ContactCats")
                        cb_hse_dog.Checked = reader.Item("ContactDogs")
                        txt_contact_days.Text = reader.Item("ContactFreq")
                        cb_care_animals.Text = reader.Item("CareOutside")

                        cb_water_sample.Text = reader.Item("WaterSample")
                        cb_contact.Text = reader.Item("Contact")
                        txt_source1_barcode.Text = reader.Item("FirstSource")
                        txt_source2_barcode.Text = reader.Item("SecondSource")
                        dtp_fetch_date.Value = reader.Item("CollectionDate")
                        txt_fetch_time.Text = reader.Item("FetchTime")
                        chk_timeunknown.Checked = reader.Item("TimeUnknown")
                        cb_sample_treated.Text = reader.Item("SampleTreated")
                        chk_smp_boil.Checked = reader.Item("WaterBoil")
                        chk_smp_bleach.Checked = reader.Item("WaterBleach")
                        chk_smp_strain.Checked = reader.Item("Waterstrain")
                        chk_smp_filter.Checked = reader.Item("FilterWater")
                        chk_smp_solar.Checked = reader.Item("DisinfectionSolar")
                        chk_smp_settle.Checked = reader.Item("StandAndSettle")
                        chk_smp_tablet.Checked = reader.Item("WaterTreatmentTable")
                        chk_smp_idk.Checked = reader.Item("idkTreatment")
                        chk_smp_other.Checked = reader.Item("TreatmentOther")
                        txt_smp_specify.Text = reader.Item("SpecifyTreatmentOther")
                        txt_PH_result.Text = reader.Item("PH")
                        txt_turbidity.Text = reader.Item("Turbidity")
                        txt_chlorine.Text = reader.Item("ChlorineResidue")
                    End While

                    If reader.HasRows Then
                        btn_submit1.Enabled = False
                        btn_update1.Enabled = True
                    Else
                        btn_submit1.Enabled = True
                        btn_update1.Enabled = False
                    End If
                    reader.Close()

                Catch ex As Exception
                    MsgBox(ex.Message)

                    conn.Close()

                End Try

            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btn_submit1_Click(sender As Object, e As EventArgs) Handles btn_submit1.Click
        If cb_water_sample.Text = "" Then
            MsgBox("Enter if sample was taken")
            Exit Sub
        End If
        If cb_water_sample.Text.Trim.ToLower = "yes" And cb_contact.Text = "" Then
            MsgBox("Enter contact")
            Exit Sub
        End If
        If cb_water_sample.Text.Trim.ToLower = "yes" And txt_source1_barcode.Text = "" Then
            MsgBox("Enter barcode 1")
            Exit Sub
        End If
        If cb_water_sample.Text.Trim.ToLower = "yes" And txt_source2_barcode.Text = "" Then
            MsgBox("Enter barcode 2")
            Exit Sub
        End If
        If cb_water_sample.Text.Trim.ToLower = "yes" And chk_timeunknown.Checked = False And txt_fetch_time.Text = "" Then
            MsgBox("Enter time")
            Exit Sub
        End If
        If cb_water_sample.Text.Trim.ToLower = "yes" And cb_sample_treated.Text = "" Then
            MsgBox("Enter if water was treated")
            Exit Sub
        End If
        If cb_water_sample.Text.Trim.ToLower = "yes" And
                chk_smp_idk.CheckState = CheckState.Checked = False And
                chk_smp_boil.CheckState = CheckState.Checked = False And
                chk_smp_bleach.CheckState = CheckState.Checked = False And
                chk_smp_strain.CheckState = CheckState.Checked = False And
                chk_smp_filter.CheckState = CheckState.Checked = False And
                chk_smp_solar.CheckState = CheckState.Checked = False And
                chk_smp_settle.CheckState = CheckState.Checked = False And
                chk_smp_tablet.CheckState = CheckState.Checked = False And
                chk_smp_other.CheckState = CheckState.Checked = False Then
            MsgBox("Check the relevant boxes")
            Exit Sub
        End If
        If chk_smp_other.Checked = True And txt_smp_specify.Text = "" Then
            MsgBox("Specify other checked reason")
            Exit Sub
        End If
        If cb_water_sample.Text.Trim.ToLower = "yes" And txt_PH_result.Text = "" Then
            MsgBox("Enter pH result")
            Exit Sub
        End If
        If cb_water_sample.Text.Trim.ToLower = "yes" And txt_turbidity.Text = "" Then
            MsgBox("Enter turbidity")
            Exit Sub
        End If
        If cb_water_sample.Text.Trim.ToLower = "yes" And txt_chlorine.Text = "" Then
            MsgBox("Enter chlorine residue")
            Exit Sub
        End If

        Try
            db.wash1(listinvidividid, ComboBox1.Text, NumericUpDown1.Value, ComboBox3.Text, cb_livelihood.Text,
                    txt_livelihood_other.Text,
                    txt_waterplace.Text, cb_placedesc.Text, cb_place_season.Text, cb_ranks.Text, cb_mostused.Text,
                    cb_secondmost_used.Text,
                    txt_wtr_sourcelocation.Text, cb_wtr_indwelling.Text, cb_wtr_allways.Text, cb_season_rsn.Text,
                    cb_wtr_paid.Text, cb_hh_pays.Text, cb_repair_time.Text,
                    chk_brk_wpc.Checked, chk_brk_plumber.Checked, chk_brk_head.Checked, chk_brk_repair.Checked,
                    chk_brk_nothing.Checked, chk_brk_idk.Checked, chk_brk_other.Checked, txt_brk_specify.Text, cb_wtr_trip_time.Text,
                    cb_means_waterscource.Text, cb_wtr_distance.Text, cb_wk_trips.Text,
                    cb_wtr_quality.Text, cb_quality_rsn.Text, txt_qual_rsn_other.Text, cb_wtr_act.Text, cb_dr_boil.Checked,
                    cb_dr_bleach.Checked, cb_dr_strain.Checked, cb_dr_filter.Checked, cb_dr_solar.Checked, cb_dr_settle.Checked,
                    cb_dr_tablet.Checked, cb_dr_idk.Checked, cb_dr_other.Checked, cb_dr_specify.Text, cbt_comm_treat.Text,
                    txt_comm_specify.Text, chk_treat_treated.Checked, chk_treat_qlty.Checked, chk_treat_nomoney.Checked, chk_treat_notaware.Checked,
                    chk_treat_other.Checked, txt_treat_specify.Text,
                    cb_treat_method.Text, cb_not_able_totreat.Text, cb_treat_lastfetch.Text, cb_wtr_pay.Text, txt_wtr_cost.Text,
                    cb_wtr_hand.Text, cb_wtr_laundry.Text, cb_wtr_cook.Text, cb_wtr_bath.Text,
                    txt_wtr_containers.Text, chk_ctn_nmwl.Checked, chk_ctn_nmwol.Checked, chk_ctn_wmwl.Checked, chk_ctn_wmwol.Checked,
                    chk_ctn_idk.Checked, chk_use_food.Checked, chk_use_chem.Checked, chk_use_fuel.Checked, chk_use_noprev.Checked,
                    chk_use_other.Checked, chk_use_idk.Checked, chk_draw_spiggot.Checked, chk_draw_pour.Checked,
                    chk_draw_other.Checked,
                    cb_wtr_fetch_keep.Text, txt_num_cont.Text, cb_conta_vol.Text, chk_fetch_nmwl.Checked, chk_fetch_nmwol.Checked,
                    chk_fetch_wmwl.Checked, chk_fetch_wmwol.Checked, chk_fetch_idk.Checked, cb_wtr_avail.Text, cb_no_drinking.Text,
                    txt_other_no_drinkingwater.Text,
                    cb_toilet_desc.Text, cbt_toil_share.Text, cb_share_toilet.Text, cb_toilet_loc.Text, cb_toilet_type.Text, cb_sewer_disp.Text,
                    cb_pit_type.Text, cb_last_emptied.Text, cb_lat_emptiedby.Text,
                    cb_waste_disposed_to.Text, cb_waste_leak.Text, ComboBox54.Text, chk_cwaste_toilet.Checked, chk_cwaste_bush.Checked,
                    chk_cwaste_yard.Checked, chk_cwaste_bury.Checked, chk_cwaste_wash.Checked, chk_cwaste_left.Checked, chk_cwaste_usetoilet.Checked,
                    chk_cwaste_idk.Checked, chk_lat_prev.Checked, chk_lat_poll.Checked, chk_lat_hygiene.Checked, chk_lat_privacy.Checked, chk_lat_status.Checked,
                    chk_lat_comfy.Checked, chk_lat_idk.Checked,
                    cb_washh_place.Text, txt_hand_was_place.Text, cb_wash_wtr_cont.Text, cb_soap_avail.Text, chk_wash_beat.Checked,
                    chk_wash_atoil.Checked, chk_wash_bcooking.Checked, chk_wash_aeat.Checked, chk_wash_afeces.Checked, chk_wash_bbreastfeed.Checked,
                    chk_wash_abreastfeed.Checked, chk_wash_need.Checked, chk_wash_clean.Checked, chk_wash_avoid.Checked, chk_wash_cpractice.Checked,
                    chk_wash_smell.Checked, chk_wash_other.Checked, chk_wash_specify.Text,
                    cb_own_cattle.Checked, cb_own_goats.Checked, cb_own_sheep.Checked, cb_own_pigs.Checked, cb_own_chick.Checked,
                    cb_own_duck.Checked, cb_own_cats.Checked, cb_own_dog.Checked, cb_own_other.Checked,
                    txt_own_spec.Text, cb_c_cattle.Checked, cb_c_goats.Checked, cb_c_sheep.Checked, cb_c_pig.Checked, cb_c_chick.Checked,
                    cb_c_duck.Checked, cb_c_cat.Checked, cb_c_dog.Checked, cb_hse_cattle.Checked, cb_hse_goat.Checked,
                    cb_hse_sheep.Checked, cb_hse_pig.Checked, cb_hse_chick.Checked, cb_hse_duck.Checked, cb_hse_cat.Checked,
                    cb_hse_dog.Checked, txt_contact_days.Text, cb_care_animals.Text,
                    cb_water_sample.Text, cb_contact.Text, txt_source1_barcode.Text, txt_source2_barcode.Text, dtp_fetch_date.Value.Date,
                    txt_fetch_time.Text, chk_timeunknown.Checked, cb_sample_treated.Text, chk_smp_boil.Checked, chk_smp_bleach.Checked, chk_smp_strain.Checked,
                    chk_smp_filter.Checked, chk_smp_solar.Checked, chk_smp_settle.Checked, chk_smp_tablet.Checked, chk_smp_idk.Checked,
                    chk_smp_other.Checked, txt_smp_specify.Text, txt_PH_result.Text, txt_turbidity.Text, txt_chlorine.Text, 1)
            msgSuccess("Successfully Saved")
        Catch ex As Exception
            msgError(ex.Message)
        End Try

        If MsgBox("Wash form done! Go to next from(Water Assess)?", MsgBoxStyle.OkCancel, Application.ProductName) = DialogResult.OK Then
            frmWater_assesment.Show()
            Me.Close()
        Else
            frmIndividuals.Show()
        End If

    End Sub

    Private Sub btn_update1_Click(sender As Object, e As EventArgs) Handles btn_update1.Click
        Try
            db.wash1(listinvidividid, ComboBox1.Text, NumericUpDown1.Value, ComboBox3.Text, cb_livelihood.Text,
                   txt_livelihood_other.Text,
                   txt_waterplace.Text, cb_placedesc.Text, cb_place_season.Text, cb_ranks.Text, cb_mostused.Text,
                   cb_secondmost_used.Text,
                   txt_wtr_sourcelocation.Text, cb_wtr_indwelling.Text, cb_wtr_allways.Text, cb_season_rsn.Text,
                   cb_wtr_paid.Text, cb_hh_pays.Text, cb_repair_time.Text,
                   chk_brk_wpc.Checked, chk_brk_plumber.Checked, chk_brk_head.Checked, chk_brk_repair.Checked,
                   chk_brk_nothing.Checked, chk_brk_idk.Checked, chk_brk_other.Checked, txt_brk_specify.Text, cb_wtr_trip_time.Text,
                   cb_means_waterscource.Text, cb_wtr_distance.Text, cb_wk_trips.Text,
                   cb_wtr_quality.Text, cb_quality_rsn.Text, txt_qual_rsn_other.Text, cb_wtr_act.Text, cb_dr_boil.Checked,
                   cb_dr_bleach.Checked, cb_dr_strain.Checked, cb_dr_filter.Checked, cb_dr_solar.Checked, cb_dr_settle.Checked,
                   cb_dr_tablet.Checked, cb_dr_idk.Checked, cb_dr_other.Checked, cb_dr_specify.Text, cbt_comm_treat.Text,
                   txt_comm_specify.Text, chk_treat_treated.Checked, chk_treat_qlty.Checked, chk_treat_nomoney.Checked, chk_treat_notaware.Checked,
                   chk_treat_other.Checked, txt_treat_specify.Text,
                   cb_treat_method.Text, cb_not_able_totreat.Text, cb_treat_lastfetch.Text, cb_wtr_pay.Text, txt_wtr_cost.Text,
                   cb_wtr_hand.Text, cb_wtr_laundry.Text, cb_wtr_cook.Text, cb_wtr_bath.Text,
                   txt_wtr_containers.Text, chk_ctn_nmwl.Checked, chk_ctn_nmwol.Checked, chk_ctn_wmwl.Checked, chk_ctn_wmwol.Checked,
                   chk_ctn_idk.Checked, chk_use_food.Checked, chk_use_chem.Checked, chk_use_fuel.Checked, chk_use_noprev.Checked,
                   chk_use_other.Checked, chk_use_idk.Checked, chk_draw_spiggot.Checked, chk_draw_pour.Checked,
                   chk_draw_other.Checked,
                   cb_wtr_fetch_keep.Text, txt_num_cont.Text, cb_conta_vol.Text, chk_fetch_nmwl.Checked, chk_fetch_nmwol.Checked,
                   chk_fetch_wmwl.Checked, chk_fetch_wmwol.Checked, chk_fetch_idk.Checked, cb_wtr_avail.Text, cb_no_drinking.Text,
                   txt_other_no_drinkingwater.Text,
                   cb_toilet_desc.Text, cbt_toil_share.Text, cb_share_toilet.Text, cb_toilet_loc.Text, cb_toilet_type.Text, cb_sewer_disp.Text,
                   cb_pit_type.Text, cb_last_emptied.Text, cb_lat_emptiedby.Text,
                   cb_waste_disposed_to.Text, cb_waste_leak.Text, ComboBox54.Text, chk_cwaste_toilet.Checked, chk_cwaste_bush.Checked,
                   chk_cwaste_yard.Checked, chk_cwaste_bury.Checked, chk_cwaste_wash.Checked, chk_cwaste_left.Checked, chk_cwaste_usetoilet.Checked,
                   chk_cwaste_idk.Checked, chk_lat_prev.Checked, chk_lat_poll.Checked, chk_lat_hygiene.Checked, chk_lat_privacy.Checked, chk_lat_status.Checked,
                   chk_lat_comfy.Checked, chk_lat_idk.Checked,
                   cb_washh_place.Text, txt_hand_was_place.Text, cb_wash_wtr_cont.Text, cb_soap_avail.Text, chk_wash_beat.Checked,
                   chk_wash_atoil.Checked, chk_wash_bcooking.Checked, chk_wash_aeat.Checked, chk_wash_afeces.Checked, chk_wash_bbreastfeed.Checked,
                   chk_wash_abreastfeed.Checked, chk_wash_need.Checked, chk_wash_clean.Checked, chk_wash_avoid.Checked, chk_wash_cpractice.Checked,
                   chk_wash_smell.Checked, chk_wash_other.Checked, chk_wash_specify.Text,
                   cb_own_cattle.Checked, cb_own_goats.Checked, cb_own_sheep.Checked, cb_own_pigs.Checked, cb_own_chick.Checked,
                   cb_own_duck.Checked, cb_own_cats.Checked, cb_own_dog.Checked, cb_own_other.Checked,
                   txt_own_spec.Text, cb_c_cattle.Checked, cb_c_goats.Checked, cb_c_sheep.Checked, cb_c_pig.Checked, cb_c_chick.Checked,
                   cb_c_duck.Checked, cb_c_cat.Checked, cb_c_dog.Checked, cb_hse_cattle.Checked, cb_hse_goat.Checked,
                   cb_hse_sheep.Checked, cb_hse_pig.Checked, cb_hse_chick.Checked, cb_hse_duck.Checked, cb_hse_cat.Checked,
                   cb_hse_dog.Checked, txt_contact_days.Text, cb_care_animals.Text,
                   cb_water_sample.Text, cb_contact.Text, txt_source1_barcode.Text, txt_source2_barcode.Text, dtp_fetch_date.Value.Date,
                   txt_fetch_time.Text, chk_timeunknown.Checked, cb_sample_treated.Text, chk_smp_boil.Checked, chk_smp_bleach.Checked, chk_smp_strain.Checked,
                   chk_smp_filter.Checked, chk_smp_solar.Checked, chk_smp_settle.Checked, chk_smp_tablet.Checked, chk_smp_idk.Checked,
                   chk_smp_other.Checked, txt_smp_specify.Text, txt_PH_result.Text, txt_turbidity.Text, txt_chlorine.Text, 2)
            msgSuccess("Successfully Updated")
        Catch ex As Exception
            msgError(ex.Message)
        End Try

        If MsgBox("Wash form done! Go to next from(Water Assess)?", MsgBoxStyle.OkCancel , Application.ProductName) = DialogResult.OK  Then
            frmWater_assesment.Show()
            Me.Close()
        Else
            frmIndividuals.Show()
        End If
    End Sub
End Class