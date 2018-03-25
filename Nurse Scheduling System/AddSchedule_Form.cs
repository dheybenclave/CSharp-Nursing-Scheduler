using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Bunifu.Framework.UI;
using Bunifu.Framework.Lib;
using System.Globalization;

namespace Nurse_Scheduling_System
{
    public partial class AddSchedule_Form : Form
    {
        Db_Utilities db = new Db_Utilities();
        Responsive res = new Responsive();
        DataTable table = new DataTable();
        MySqlDataAdapter adapt;
        MySqlCommand cmd;
        List<string> checkeddays = new List<string>();
        List<string> checkmonths = new List<string>();
        List<string> alldays = new List<string>();
        List<string> allsunday = new List<string>();
        List<string> selectedweeks = new List<string>();
        List<string> selecteddays = new List<string>();
        List<string> finaldaysrepeat = new List<string>();
        List<string> subdaterange = new List<string>();
        AutoCompleteStringCollection autonursename = new AutoCompleteStringCollection();
        AutoCompleteStringCollection autopatientname = new AutoCompleteStringCollection();
        AutoCompleteStringCollection autoroom = new AutoCompleteStringCollection();
        int count_id = 0;
        int count_id2 = 0;
        string subdateranges, selectedtime, selecteddate = "";
        string date = DateTime.Now.Date.ToString("MMMM dd, yyyy").ToUpper();
        string time = DateTime.Now.ToLongTimeString();
        bool multischedmultirepeat = false;
        public AddSchedule_Form()
        {
            InitializeComponent();
            res.generateresponsive(this);
            forloaddata();
            tmtime.Time = Convert.ToDateTime(time);
            fortime();
            cmbweekmonth.selectedIndex = DateTime.Now.Month - 1;
            lblofthismonth.Text = lblofthismonth.Text + " " + date.Split(' ')[0].ToUpper();
            string id = Schedule_Form.getid ;
             string pos = Schedule_Form.getpos ;
            if (id.Length != 0  && pos != "Admin" )
            {
                table = db.QuerySelect("SELECT nurse_fullname FROM db_scheduler_system.tbl_nurse where nurse_id = " + id + " ; ");
                foreach (DataRow dr in table.Rows)
                {
                    txtnursename.Text = dr[0].ToString();
                    txtnursename.Enabled = false;
                }
            }
            else {

                txtnursename.Text = "";
                txtnursename.Enabled = true;
            }

        }

        public void sizingcell()
        {
            if (switchmultiple.Value == true && switchrepeat.Value == true) { clndrdate.CellPadding = new Padding(10, 5, 10, 5); clndrdate.ShowMonthHeaders = false; }
            else { clndrdate.CellPadding = new Padding(-1, -1, -1, -1); clndrdate.ShowMonthHeaders = true; }
     
        }
        private void switchmultiple_OnValueChange(object sender, EventArgs e)
        {
            sizingcell();
            if (switchmultiple.Value == true) { clndrdate.SelectionMode = DevExpress.XtraEditors.Repository.CalendarSelectionMode.Multiple; }
            else { clndrdate.SelectionMode = DevExpress.XtraEditors.Repository.CalendarSelectionMode.Single; }
        }

        private void switchrepeat_OnValueChange(object sender, EventArgs e)
        {
            sizingcell();
            if (switchrepeat.Value == true) { pnlrepeat.Enabled = pnlselectdate.Enabled = true; rdrepeat.SelectedIndex = tabrepeat.SelectedTabPageIndex = 2; }
            else { pnlrepeat.Enabled = false; pnlselectdate.Enabled = true; }

        }

        public void fortime()
        {
            string hour = "";
            if (tmtime.Text.Split(':')[0].Length == 1) { hour = "0" + tmtime.Text.Split(':')[0]; }
            else { hour = tmtime.Text.Split(':')[0]; }
            lblhour.Text = hour;
            lblminute.Text = tmtime.Time.ToString().Split(':')[1].Split(' ')[0];
            lblampm.Text = tmtime.Text.Split(' ')[1];
        }

        private void tmtime_KeyUp(object sender, KeyEventArgs e)
        {
            fortime();
        }

        private void xtraTabPage3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdrepeat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdrepeat.SelectedIndex == 0) { tabrepeat.SelectedTabPageIndex = 0; pnlselectdate.Enabled = switchmultiple.Value = false; }
            else if (rdrepeat.SelectedIndex == 1) { tabrepeat.SelectedTabPageIndex = 1; pnlselectdate.Enabled = switchmultiple.Value = false; }
            else if (rdrepeat.SelectedIndex == 2) { tabrepeat.SelectedTabPageIndex = 2; pnlselectdate.Enabled = true; }
            else { pnlselectdate.Enabled = true; }

        }

        string forsummary = "on";
        private void btnsummary_Click(object sender, EventArgs e)
        {
            btnsummary.Text = "S \n U \n M \n M \n A \n R \n Y";
            if (forsummary == "on")
            {
                while (!(pnlright.Width == 280)) { pnlright.Width++; }
                forsummary = "off";
            }
            else
            {
                while (!(pnlright.Width == 20)) { pnlright.Width--; }
                forsummary = "on";
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void forcheckdays(Bunifu.Framework.UI.BunifuCheckbox checkbox)
        {
            string subcheck = checkbox.Name.Replace("chk", "").ToString();
            if (checkbox.Checked == true) { if (subcheck != "selectall")checkeddays.Add(subcheck.ToLower()); }
            else { checkeddays.Remove(subcheck); }
            if (subcheck != "selectall") { chkselectall.Checked = false; } else { }
        }

        private void chkselectall_OnChange(object sender, EventArgs e)
        {
            forcheckdays(chkselectall);
            if (chkselectall.Checked == true)
            {
                checkeddays.Clear();
                chkmonday.Checked = chktuesday.Checked = chkwednesday.Checked = chkthursday.Checked = chkfriday.Checked = chksaturday.Checked = chksunday.Checked = true;
                for (int i = 0; i < 7; i++) { checkeddays.Add(CultureInfo.CurrentUICulture.DateTimeFormat.DayNames[i].ToLower()); }
            }
            else
            {
                chkselectall.Checked = chkmonday.Checked = chktuesday.Checked = chkwednesday.Checked = chkthursday.Checked = chkfriday.Checked = chksaturday.Checked = chksunday.Checked = false;
                checkeddays.Clear();
            }

        }

        private void chkmonday_OnChange(object sender, EventArgs e)
        {
            forcheckdays(chkmonday);
        }

        private void chktuesday_OnChange(object sender, EventArgs e)
        {
            forcheckdays(chktuesday);
        }

        private void chkwednesday_OnChange(object sender, EventArgs e)
        {
            forcheckdays(chkwednesday);
        }

        private void chkthursday_OnChange(object sender, EventArgs e)
        {
            forcheckdays(chkthursday);
        }

        private void chkfriday_OnChange(object sender, EventArgs e)
        {
            forcheckdays(chkfriday);
        }

        private void chksaturday_OnChange(object sender, EventArgs e)
        {
            forcheckdays(chksaturday);
        }

        private void chksunday_OnChange(object sender, EventArgs e)
        {
            forcheckdays(chksunday);
        }

        public void forcheckmonths(Bunifu.Framework.UI.BunifuCheckbox checkbox)
        {

            string subcheck = checkbox.Name.Replace("chk", "").ToString();
            if (checkbox.Checked == true) { if (subcheck != "selectall2")checkmonths.Add(subcheck.ToLower()); }
            else { checkmonths.Remove(subcheck); }
            if (subcheck != "selectall2") { chkselectall2.Checked = false; } else { }

        }

        private void chkselectall2_OnChange(object sender, EventArgs e)
        {
            forcheckmonths(chkselectall2);
            if (chkselectall2.Checked == true)
            {
                checkmonths.Clear();
                chkjanuary.Checked = chkfebruary.Checked = chkmarch.Checked = chkapril.Checked = chkmay.Checked = chkjune.Checked
                    = chkjuly.Checked = chkaugust.Checked = chkseptember.Checked = chkoctober.Checked = chknovember.Checked = chkdecember.Checked = true;
                for (int i = 0; i < 12; i++) { checkmonths.Add(CultureInfo.CurrentUICulture.DateTimeFormat.MonthNames[i].ToLower()); }
            }
            else
            {
                chkjanuary.Checked = chkfebruary.Checked = chkmarch.Checked = chkapril.Checked = chkmay.Checked = chkjune.Checked
                  = chkjuly.Checked = chkaugust.Checked = chkseptember.Checked = chkoctober.Checked = chknovember.Checked = chkdecember.Checked = false;
                checkmonths.Clear();
            }
        }

        private void chkjanuary_OnChange(object sender, EventArgs e)
        {
            forcheckmonths(chkjanuary);
        }

        private void chkfebruary_OnChange(object sender, EventArgs e)
        {
            forcheckmonths(chkfebruary);

        }

        private void chkmarch_OnChange(object sender, EventArgs e)
        {
            forcheckmonths(chkmarch);
        }

        private void chkapril_OnChange(object sender, EventArgs e)
        {
            forcheckmonths(chkapril);
        }

        private void chkmay_OnChange(object sender, EventArgs e)
        {
            forcheckmonths(chkmay);
        }

        private void chkjune_OnChange(object sender, EventArgs e)
        {
            forcheckmonths(chkjune);
        }

        private void chkjuly_OnChange(object sender, EventArgs e)
        {
            forcheckmonths(chkjuly);
        }

        private void chkaugust_OnChange(object sender, EventArgs e)
        {
            forcheckmonths(chkaugust);
        }

        private void chkseptember_OnChange(object sender, EventArgs e)
        {
            forcheckmonths(chkseptember);

        }

        private void chkoctober_OnChange(object sender, EventArgs e)
        {
            forcheckmonths(chkoctober);
        }

        private void chknovember_OnChange(object sender, EventArgs e)
        {

            forcheckmonths(chknovember);
        }

        private void chkdecember_OnChange(object sender, EventArgs e)
        {
            forcheckmonths(chkdecember);
        }

        public void forloaddata()
        {
            try
            {
                table = db.QuerySelect("SELECT * FROM tbl_nurse");
                foreach (DataRow dr in table.Rows) { autonursename.Add(dr[1].ToString()); }
                table = db.QuerySelect("SELECT * FROM tbl_patient");
                foreach (DataRow dr in table.Rows) { autopatientname.Add(dr[1].ToString()); }
                table = db.QuerySelect("SELECT * FROM tbl_room");
                foreach (DataRow dr in table.Rows) { autoroom.Add(dr[1].ToString()); autoroom.Add(dr[2].ToString()); }

                txtnursename.AutoCompleteSource = txtpatientname.AutoCompleteSource = txtroom.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtnursename.AutoCompleteMode = txtpatientname.AutoCompleteMode = txtroom.AutoCompleteMode = AutoCompleteMode.Suggest;

                txtnursename.AutoCompleteCustomSource = autonursename; txtpatientname.AutoCompleteCustomSource = autopatientname; txtroom.AutoCompleteCustomSource = autoroom;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        public Boolean forseletecranges(bool b)
        {
            subdaterange.Clear();
            for (int i = 0; i < clndrdate.SelectedRanges.Count; i++) // get all selected days and year only
            {
                int start = Convert.ToInt32(clndrdate.SelectedRanges[i].StartDate.ToString("dd")) - 1;
                int end = Convert.ToInt32(clndrdate.SelectedRanges[i].EndDate.ToString("dd")) - 1;
                while (start != end)
                {
                    start++;
                    if (!subdaterange.Contains(start.ToString()))
                    {
                          string date = (start.ToString().Length == 1 ? "0" + start.ToString() : start.ToString());
                        if (b == true)
                        { subdateranges = clndrdate.SelectedRanges[i].StartDate.ToString("yyyy") + "-" + "_" + "-" + start.ToString() + " " + tmtime.Time.ToString("hh:mm:ss"); }
                        else { subdateranges = clndrdate.SelectedRanges[i].StartDate.ToString("yyyy") + "-" + clndrdate.SelectedRanges[i].StartDate.ToString("MM") + "-" + date + " " + tmtime.Time.ToString("hh:mm:ss"); }

                        subdaterange.Add(subdateranges);
                    }
                    else { subdaterange.Remove(subdateranges); }
                }

            }
                
            return b;

            //////////////////////////////////////GET ALL  SELECTED RANGES DATE : MULTI AND SINGLE ////////////////////////////////////////
        }

        public void forsavingsched()
        {
            selectedtime = tmtime.Time.ToString("hh:mm:ss");
            selecteddate = clndrdate.DateTime.ToString("yyyy-MM-dd") + " " + selectedtime;


            int countdaysinmonth = DateTime.DaysInMonth(DateTime.Now.Year, cmbweekmonth.selectedIndex + 1);
            int counter = 0;
            selectedweeks.Clear(); selecteddays.Clear(); alldays.Clear(); allsunday.Clear(); 
            try
            {

                for (int i = 0; i <= countdaysinmonth; i++)//get all days in selected month
                {
                    counter++;
                    if (counter <= countdaysinmonth)
                    {
                        string subdates = Convert.ToDateTime(DateTime.Now.Month + " " + counter + ", " + DateTime.Now.Year).ToLongDateString();
                        if (subdates.Contains("Sunday")) { allsunday.Add(subdates); } else { }//get start week
                        alldays.Add(subdates);                   }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

            //////////////////////////////////////GET ALL  SELECTED AND CURRENT DATES : MULTI AND SINGLE ////////////////////////////////////////

            try // nested condition
            {
                if (switchrepeat.Value == true && switchmultiple.Value == false)// repeat manipulate
                {
                    if (rdrepeat.SelectedIndex == 0)//days repeat 
                    {
                        selecteddays.Clear();
                        for (int i = 0; i < checkeddays.Count; i++)
                        {
                            for (int j = 0; j < alldays.Count; j++)
                            {
                                if (alldays[j].ToLower().Contains(checkeddays[i]))
                                { selecteddays.Add(Convert.ToDateTime(alldays[j].ToString()).ToString("yyyy-MM-dd") + " " + tmtime.Time.ToString("hh:mm:ss")); }
                            }
                        }
                    }
                    else if (rdrepeat.SelectedIndex == 1)//weeks repeat
                    {

                        if (cmbweeks.selectedIndex == 0)//if week selected
                        {
                            selecteddays.Clear();
                            int startlevel = Convert.ToInt32(allsunday[cmbweeklevel.selectedIndex].Split(' ')[2].Replace(",", ""));
                            int counterlevel = startlevel + 6;
                            int sub = (((int)cmbweekmonth.selectedIndex) + 1);
                            string selectedmonth = (sub.ToString().Length == 1 ? "0" + sub.ToString() : sub.ToString());
                            while (startlevel <= counterlevel) { selecteddays.Add(DateTime.Now.Year + "-" + selectedmonth + "-" + startlevel++ + " " + tmtime.Time.ToString("hh:mm:ss")); }
                        }
                        else
                        {
                            selecteddays.Clear(); selectedweeks.Clear();
                            for (int i = 0; i < alldays.Count; i++) { if (alldays[i].Contains(cmbweeks.selectedValue)) { selectedweeks.Add(alldays[i]); } else { } }
                            selecteddays.Add(Convert.ToDateTime(selectedweeks[cmbweeklevel.selectedIndex]).ToString("yyyy-MM-dd") + " " + tmtime.Time.ToString("hh:mm:ss"));
                        }
                    }
                    else if (rdrepeat.SelectedIndex == 2)//repeat but single sched
                    {
                        selecteddays.Clear();
                        List<string> sublistrangedate = new List<string>();

                        date = clndrdate.DateTime.ToString("dd");
                        for (int i = 0; i < checkmonths.Count; i++)
                        {
                            for (int j = 0; j < cmbweekmonth.Items.Length; j++)
                            {

                                if (cmbweekmonth.Items[j].ToLower().Equals(checkmonths[i]))
                                {
                                    cmbweekmonth.selectedIndex = j;
                                    int sub = (((int)cmbweekmonth.selectedIndex) + 1);
                                    string selectedmonth = (sub.ToString().Length == 1 ? "0" + sub.ToString() : sub.ToString());
                                    selecteddays.Add(DateTime.Now.Year + "-" + selectedmonth + "-" + date + " " + tmtime.Time.ToString("hh:mm:ss"));
                                }
                            }
                        }
                    }

                }
                if (switchrepeat.Value == false && switchmultiple.Value == true) // multi sched but no repeat
                {
                    selecteddays.Clear();
                    forseletecranges(false);
                    selecteddays = subdaterange;
   
                }

                if (switchmultiple.Value == true && switchrepeat.Value == true)//multiple sched and repeat
                {
                    forseletecranges(true);
                    string selectedmonths = "";

                    if (checkmonths.Count != 0)
                    {
                        for (int i = 0; i < checkmonths.Count; i++)
                        {

                            for (int j = 0; j < cmbweekmonth.Items.Length; j++)
                            {

                                if (cmbweekmonth.Items[j].ToLower() == checkmonths[i])
                                {
                                    cmbweekmonth.selectedIndex = j;

                                    int sub = (((int)cmbweekmonth.selectedIndex) + 1);
                                    selectedmonths = (sub.ToString().Length == 1 ? "0" + sub.ToString() : sub.ToString());
                                }
                            }
                            for (int k = 0; k < subdaterange.Count; k++)
                            {
                                string subselectedays = subdaterange[k].Replace("_", selectedmonths).ToString();
                                selecteddays.Add(subselectedays);
                            }
                        }

                    }
                    else { fornotif(2, "Please Check Months!."); }
                  
                }

                if (switchmultiple.Value == false && switchrepeat.Value == false) //single sched
                {
                    selecteddays.Clear();
                    selecteddays.Add(selecteddate);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        public void foraddaccount()
        {
            try
            {
                adapt = new MySqlDataAdapter("SELECT nurse_id  FROM db_scheduler_system.tbl_nurse order by last_insert_id(nurse_id) DESC LIMIT 1;", db.OpenConnection());
                table = new DataTable(); adapt.Fill(table);
                if (table.Rows.Count > 0)
                { foreach (DataRow dr in table.Rows) { count_id2 = Convert.ToInt32(dr[0]) + 1; } }
                else { }
                count_id2++;
                //adapt = new MySqlDataAdapter("SELECT user_id  FROM db_scheduler_system.tbl_user WHERE user_username ='" + txtUsername.Text + "' and user_password ='" + txtPassword.Text + "';", db.OpenConnection());
                //table = new DataTable(); adapt.Fill(table);
                //if (table.Rows.Count > 0)
                //{
                //    foreach (DataRow dr in table.Rows)
                //    {
                //        userid = dr["user_id"].ToString();
                //    }
                //}
                //else { }
                cmd = new MySqlCommand("CreateNurseAccount", db.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    cmd.Parameters.Add(new MySqlParameter("?nurse_id", count_id2));
                    cmd.Parameters.Add(new MySqlParameter("?nurse_fullname", txtnursename.Text));
                    cmd.Parameters.Add(new MySqlParameter("?nurse_address", "NA"));
                    cmd.Parameters.Add(new MySqlParameter("?user_id", "0"));
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        public void foraddroom()
        {
            try
            {
                adapt = new MySqlDataAdapter("SELECT room_id  FROM db_scheduler_system.tbl_room order by last_insert_id(room_id) DESC LIMIT 1;", db.OpenConnection());
                table = new DataTable(); adapt.Fill(table);
                if (table.Rows.Count > 0)
                { foreach (DataRow dr in table.Rows) { count_id = Convert.ToInt32(dr[0]) + 1; } }
                else { }

                cmd = new MySqlCommand("CreateRoom", db.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    cmd.Parameters.Add(new MySqlParameter("?room_id", count_id));
                    cmd.Parameters.Add(new MySqlParameter("?room_code", txtroom.Text));
                    cmd.Parameters.Add(new MySqlParameter("?room_name", txtroom.Text));
                    cmd.Parameters.Add(new MySqlParameter("?room_description", "NA"));
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        public void foraddpatient()
        {
            try
            {
                adapt = new MySqlDataAdapter("SELECT patient_id  FROM db_scheduler_system.tbl_patient order by last_insert_id(patient_id) DESC LIMIT 1;", db.OpenConnection());
                table = new DataTable(); adapt.Fill(table);
                if (table.Rows.Count > 0)
                { foreach (DataRow dr in table.Rows) { count_id = Convert.ToInt32(dr[0]) + 1; } }
                else { }

                string room_id1 = "";
                table = db.QuerySelect("SELECT room_id  FROM db_scheduler_system.tbl_room WHERE room_name = '" + txtroom.Text + "' OR room_code = '" + txtroom.Text + "';");
                if (table.Rows.Count > 0)
                { foreach (DataRow dr in table.Rows) { room_id1 = dr[0].ToString(); } }
                else { room_id1 = "0"; }

                cmd = new MySqlCommand("CreatePatient", db.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    cmd.Parameters.Add(new MySqlParameter("?patient_id", count_id));
                    cmd.Parameters.Add(new MySqlParameter("?room_id", room_id1));
                    cmd.Parameters.Add(new MySqlParameter("?patient_fullname", txtpatientname.Text));
                    cmd.Parameters.Add(new MySqlParameter("?patient_address", "NA"));
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
 
            try
            {
                if (txttitle.Text.Trim().Length != 0 && txtdescription.Text.Trim().Length != 0 && txtnursename.Text.Trim().Length != 0 && txtpatientname.Text.Trim().Length != 0 && txtroom.Text.Trim().Length != 0)
                {
                    forsavingsched();
                    if (selecteddays.Count != 0) { fornotif(1, "Adding Schedule Success!."); }


                    string nurse_id = null; string patient_id = null; string room_id = null;

                    table = db.QuerySelect("SELECT nurse_id  FROM db_scheduler_system.tbl_nurse WHERE nurse_fullname = '" + txtnursename.Text + "';");
                    if (table.Rows.Count > 0)
                    { foreach (DataRow dr in table.Rows) { nurse_id = dr[0].ToString(); } }
                    else { nurse_id = "0"; }

                    table = db.QuerySelect("SELECT room_id  FROM db_scheduler_system.tbl_room WHERE room_name = '" + txtroom.Text + "' OR room_code = '" + txtroom.Text + "';");
                    if (table.Rows.Count > 0)
                    { foreach (DataRow dr in table.Rows) { room_id = dr[0].ToString(); } }
                    else { room_id = "0"; }

                    table = db.QuerySelect("SELECT patient_id  FROM db_scheduler_system.tbl_patient WHERE patient_fullname = '" + txtpatientname.Text + "';");
                    if (table.Rows.Count > 0)
                    { foreach (DataRow dr in table.Rows) { patient_id = dr[0].ToString(); } }
                    else { patient_id = "0"; }
                    

                    for (int s = 0; s < selecteddays.Count; s++)
                    {

                        table = db.QuerySelect("SELECT schedule_id  FROM db_scheduler_system.tbl_schedule order by last_insert_id(schedule_id) DESC LIMIT 1;");
                        if (table.Rows.Count > 0)
                        { foreach (DataRow dr in table.Rows) { count_id = Convert.ToInt32(dr[0]) + 1; } }
                        else { }

                        cmd = new MySqlCommand("CreateSchedule", db.OpenConnection());
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            if (nurse_id == "0")
                            {
                                foraddaccount();
                                table = db.QuerySelect("SELECT nurse_id  FROM db_scheduler_system.tbl_nurse WHERE nurse_fullname = '" + txtnursename.Text + "';");
                                if (table.Rows.Count > 0)
                                { foreach (DataRow dr in table.Rows) { nurse_id = dr[0].ToString(); } }
                                else { nurse_id = "0"; }
                            }
                            if (room_id == "0")
                            {
                                foraddroom();
                                table = db.QuerySelect("SELECT room_id  FROM db_scheduler_system.tbl_room WHERE room_name = '" + txtroom.Text + "' OR room_code = '" + txtroom.Text + "';");
                                if (table.Rows.Count > 0)
                                { foreach (DataRow dr in table.Rows) { room_id = dr[0].ToString(); } }
                                else { room_id = "0"; }
                            }
                            if (patient_id == "0")
                            {
                                foraddpatient();
                                table = db.QuerySelect("SELECT patient_id  FROM db_scheduler_system.tbl_patient WHERE patient_fullname = '" + txtpatientname.Text + "';");
                                if (table.Rows.Count > 0)
                                { foreach (DataRow dr in table.Rows) { patient_id = dr[0].ToString(); } }
                                else { patient_id = "0"; }

                            }
                            cmd.Parameters.Add(new MySqlParameter("?schedule_id", count_id));
                            cmd.Parameters.Add(new MySqlParameter("?nurse_id", nurse_id));
                            cmd.Parameters.Add(new MySqlParameter("?room_id", room_id));
                            cmd.Parameters.Add(new MySqlParameter("?patient_id", patient_id));
                            cmd.Parameters.Add(new MySqlParameter("?schedule_title", txttitle.Text));
                            cmd.Parameters.Add(new MySqlParameter("?schedule_description", txtdescription.Text));
                            cmd.Parameters.Add(new MySqlParameter("?schedule_time", selectedtime));
                            cmd.Parameters.Add(new MySqlParameter("?schedule_date", selecteddays[s].ToString()));
                            cmd.Parameters.Add(new MySqlParameter("?schedule_status", cmbstatus.selectedValue.ToLower()));
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        { }
                    }
                }
                else { fornotif(2, "Please Complete the Requirements!."); }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

           // for (int j = 0; j < selecteddays.Count; j++) { MessageBox.Show(selecteddays[j].ToString()); }
        }


        int countback = 0;
        private void tmnotif_Tick(object sender, EventArgs e)
        {
              countback++;
              if (countback == 5)
              {
                  pnlnotif.Visible = false;
                  tmnotif.Stop();
                  countback = 0;
                  pnlbuttom.BackColor = Color.DarkSlateGray;
              }
              
       
        }

        private void fornotif(int status, string title)
        {
            tmnotif.Enabled = true;
            tmnotif.Start();
            pnlnotif.Visible = true;
            lblnotif.Text = title;
            if (status == 1)
            {
                rsicon.BackgroundImage = imageList1.Images[0];
                pnlbuttom.BackColor = Color.FromArgb(0, 122, 204);

            }
            else if (status == 2)
            {
                rsicon.BackgroundImage = imageList1.Images[1];
                pnlbuttom.BackColor = Color.FromArgb(237, 28, 36);
            }
        }

    
    }
}
