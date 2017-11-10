using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MySql.Data.MySqlClient;
using MySql.Data;
using Microsoft.Win32;
using System.Speech.Synthesis;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Globalization;

namespace Nurse_Scheduling_System
{
    public partial class Schedule_Form : Form
    {
        public enum ShowCommands : int
        {
            SW_HIDE = 0,
            SW_SHOWNORMAL = 1,
            SW_NORMAL = 1,
            SW_SHOWMINIMIZED = 2,
            SW_SHOWMAXIMIZED = 3,
            SW_MAXIMIZE = 3,
            SW_SHOWNOACTIVATE = 4,
            SW_SHOW = 5,
            SW_MINIMIZE = 6,
            SW_SHOWMINNOACTIVE = 7,
            SW_SHOWNA = 8,
            SW_RESTORE = 9,
            SW_SHOWDEFAULT = 10,
            SW_FORCEMINIMIZE = 11,
            SW_MAX = 11
        }

        [DllImport("shell32.dll")]
        static extern IntPtr ShellExecute(
            IntPtr hwnd,
            string lpOperation,
            string lpFile,
            string lpParameters,
            string lpDirectory,
            ShowCommands nShowCmd);
        public static int medid;
        Db_Utilities db = new Db_Utilities();
        Responsive res = new Responsive();
        DataTable table = new DataTable();
        MySqlDataAdapter adapt;
        MySqlCommand cmd;
        public string nurseid, userid;
        public int nurseid1;
        public int roomid;
        public static string medicineid;
        public static string suppliesid;
        public string unit;
        public int medicinestocks;
        public int transactionid, transactionstocks, transactionquantity;
        int count = 1;
        public int patientid;
        public string userpass;
        public int count_id2, count_idnew;
        public string fullname, address, username, password, confirmpas;
        public static string selecteddate = "";
        public static DateTime selecteddatemanage;



        Point p;
        TextBox subtextbox = new TextBox();

        int TMove, MX, MY = 0;
        string max, showpassword = "on";

        string idshow, position, user_id = "";
        bool fadenow, editconnection, editdone = false;
        public static bool onshow, ifeditconnection, ifcreateaccount = false;
        private int count_id;
        private int done = 0;

        private static readonly string StartupKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        private static readonly string StartupValue = "NursingScehduler";
        public static string getpos;
        public  static string getid;
        string queryload = "";

        public Schedule_Form()
        {
            InitializeComponent();
            forresponsive();
            clndrsched.Focus();
            PopulateSupplies();
            PopulateMedicineNew();
            PopulateSuppliesNew();
            PopulateMedicine();
            clndrsched.TodayDate = DateTime.Now;
            clndrsched.DateTime = DateTime.Now;
            btnpnlschedleftclose.Text = "on";
            tmreactive.Start();

            
            switch (getpos)
                    {                   
                        case "Admin":
                            queryload = "SELECT * FROM tbl_schedule ts inner join tbl_nurse tn on tn.nurse_id = ts.nurse_id inner join " +
                            "tbl_room tr on tr.room_id = ts.nurse_id inner join tbl_patient tp on tp.patient_id = ts.patient_id where ts.schedule_id != 0  order by ts.schedule_date DESC;";
                            break;
                        case "Head Nurse": queryload = "SELECT * FROM tbl_schedule ts inner join tbl_nurse tn on tn.nurse_id = ts.nurse_id inner join " +
                          "tbl_room tr on tr.room_id = ts.nurse_id inner join tbl_patient tp on tp.patient_id = ts.patient_id where ts.schedule_id != 0  AND tn.nurse_id = "+getid+" order by ts.schedule_date DESC;";
                            break;
                        case "Nurse": queryload = "SELECT * FROM tbl_schedule ts inner join tbl_nurse tn on tn.nurse_id = ts.nurse_id inner join " +
                            "tbl_room tr on tr.room_id = ts.nurse_id inner join tbl_patient tp on tp.patient_id = ts.patient_id where ts.schedule_id != 0  AND tn.nurse_id = " + getid + " order by ts.schedule_date DESC;";
                            break;
                    }

                LoadSchedule(queryload);
          

        }
        private void pnlheader_MouseMove(object sender, MouseEventArgs e)
        {
            if (TMove == 1) this.SetDesktopLocation(MousePosition.X - MX, MousePosition.Y - MY);

            if (MousePosition.Y - MY <= 1)
            { max = "off"; this.WindowState = FormWindowState.Maximized; }
        }

        private void pnlheader_MouseUp(object sender, MouseEventArgs e)
        { TMove = 0; }

        private void pnlheader_MouseDown(object sender, MouseEventArgs e)
        { TMove = 1; MX = e.X; MY = e.Y; }

        private void btnclose_Click(object sender, EventArgs e)
        {
            //   Alert_Dialog ad = new Alert_Dialog(); ad.ShowDialog();
            Application.ExitThread();

        }

        private void btnmaxmin_Click(object sender, EventArgs e)
        { res.adjustpanel(this); }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            SetBalloonTip();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(30000);
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void pnlheader_DoubleClick(object sender, EventArgs e)
        {
            res.adjustpanel(this);
        }

        public void forresponsive()
        {
            res.generateresponsive(this);

        }
        private static void SetStartup()
        {
            //Set the application to run at startup
            RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
            key.SetValue(StartupValue, Application.ExecutablePath.ToString());
        }

        private void speech(string speak) // defining the function which will accept a string parameter
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult); // to change VoiceGender and VoiceAge check out those links below
            synthesizer.Volume = 100;  // (0 - 100)
            synthesizer.Rate = 0;     // (-10 - 10)       
            synthesizer.SpeakAsync(speak); // here args = pran
        }

        private void Schedule_Form_Load(object sender, EventArgs e)
        {

                   
        }
        public void LoadSchedule(string query){

            //SELECT * FROM tbl_schedule ts inner join tbl_nurse tn on tn.nurse_id = ts.nurse_id inner join 
            //tbl_room tr on tr.room_id = ts.nurse_id inner join tbl_patient tp on tp.patient_id = ts.patient_id order by ts.schedule_date DESC;
            gridschedules.DataBindings.Clear();
            gridschedules.DataSource = null;
            table = db.QuerySelect(query);
            try
            {
                gridschedules.DataSource = table;
            }

            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(lsvRoom.FocusedItem.SubItems[0].Text + " " + lsvRoom.FocusedItem.SubItems[1].Text.Trim());
            }
            catch { MessageBox.Show(lsvRoom.FocusedItem.SubItems[0].Text); }
        }

       
        private void clndrsched_MouseMove(object sender, MouseEventArgs e)
        {
            lbldateselected.Text = clndrsched.HotDate.GetValueOrDefault().ToLongDateString();

        }


        public void navopen()
        {
            while (!(pnlschedleft.Width == 210))
            {
                pnlschedleft.Width += 10;
                if (pnlschedleft.Width == 210)
                {
                    btnschedule.Text = "               Schedule";
                    btnnurse.Text = "               Nurse";
                    btnpatient.Text = "               Patient";
                    btnroom.Text = "               Room";
                    btninvetory.Text = "               Inventory";
                }
            }
        }
        public void navclose()
        {
            while (!(pnlschedleft.Width == 70)) {
                pnlschedleft.Width -= 10;
                if (pnlschedleft.Width == 70){ btnschedule.Text = btnnurse.Text = btnpatient.Text = btnroom.Text = ""; }
            }
        }

        private void Schedule_Form_Resize(object sender, EventArgs e)
        {
            if (pnlschedleft.Width != 0)
            {
                if (this.WindowState == FormWindowState.Maximized) { clndrsched.CellPadding = new Padding(60, 40, 60, 40); }
                else { clndrsched.CellPadding = new Padding(20, 10, 20, 27); }
            }
            else{
                if (this.WindowState == FormWindowState.Maximized){clndrsched.CellPadding = new Padding(75, 40, 75, 40);}
                else { clndrsched.CellPadding = new Padding(35, 10, 35, 27); btnpnlschedleftclose.Enabled = false; }
            }

            res.autocenterobjects_XY(pnlbodynurse1.Width, pnlbodynurse.Width, pnlbodynurse1.Height, pnlbodynurse.Height);
            res.autocenterobjects_XY(pnlpatient1.Width, pnlpatient.Width, pnlpatient1.Height, pnlpatient.Height);
        }
         
        private void btnpnlschedleftclose_Click(object sender, EventArgs e)
        {
        
            if (btnpnlschedleftclose.Text == "on")
            {
                navopen();
                btnpnlschedleftclose.Text ="off";
            }
            else
            {
                navclose();
                btnpnlschedleftclose.Text = "on";
            }
        
        }

        private void clndrsched_DateTimeChanged(object sender, EventArgs e)
        {
            if (clndrsched.DateTime.ToString() != "")
            {
                dtdate.Value = clndrsched.DateTime;
                lbldateselected.Text = clndrsched.DateTime.ToLongDateString();
            }


        }

        private void lbldateselected_TextChanged(object sender, EventArgs e)
        {
            if (lbldateselected.Text != "Monday, January 01, 0001" && lbldateselected.Text != "")
            {
                toolTip1.AutoPopDelay = 5000;
                toolTip1.InitialDelay = 5000;
                toolTip1.AutomaticDelay = 5000;
                toolTip1.SetToolTip(clndrsched, lbldateselected.Text);
            }
            else { lbldateselected.Text = ""; }

           
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnschedule_Click(object sender, EventArgs e)
        {
            tabbody.SelectedTabPageIndex = 0;

        }

        private void btnnurse_Click(object sender, EventArgs e)
        {
            tabbody.SelectedTabPageIndex = 1;
            PopulateNurse();
        }

        private void btnpatient_Click(object sender, EventArgs e)
        {
            tabbody.SelectedTabPageIndex = 2;
            PopulatePatient();
            PopulateRoom();
        }

        private void btnroom_Click(object sender, EventArgs e)
        {
            tabbody.SelectedTabPageIndex = 3;
            PopulateRoom();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabbody_Click(object sender, EventArgs e)
        {

        }

    
        private void btnaddsched_Click(object sender, EventArgs e)
        {
            AddSchedule_Form af = new AddSchedule_Form();
            af.ShowDialog();
        }

        private void tmreactive_Tick(object sender, EventArgs e)
        {
            lblcurrenttime.Text = DateTime.Now.ToLongTimeString();
            lblcurrentdate.Text = DateTime.Now.ToLongDateString();
        }

        private void gridschedules_Click(object sender, EventArgs e)
        {
          // MessageBox.Show(gridschedules.ViewCollection.ToString());
           

        }

        private void txtsearch_OnValueChanged(object sender, EventArgs e)
        {
            string searchval = txtsearch.Text.ToLower();
             string query= "";
             if (searchval.Length != 0)
             {
                 query = "SELECT * FROM tbl_schedule ts inner join tbl_nurse tn on tn.nurse_id = ts.nurse_id inner join " +
                                 "tbl_room tr on tr.room_id = ts.nurse_id inner join tbl_patient tp on tp.patient_id = ts.patient_id " +
                                 "WHERE ( ts.schedule_id != 0 ) AND (ts.schedule_date LIKE '%" + searchval + "%' OR tn.nurse_fullname  LIKE '%" + searchval + "%' OR " +
                                 " ts.schedule_title  LIKE '%" + searchval + "%') order by ts.schedule_date DESC LIMIT 5";

             }
             else {
                  
                query = "SELECT * FROM tbl_schedule ts inner join tbl_nurse tn on tn.nurse_id = ts.nurse_id inner join " +
                              "tbl_room tr on tr.room_id = ts.nurse_id inner join tbl_patient tp on tp.patient_id = ts.patient_id where ts.schedule_id != 0  order by ts.schedule_date DESC;";
             }

            LoadSchedule(query);
        }


        private void dtdate_ValueChanged(object sender, EventArgs e)
        {
            clndrsched.DateTime = dtdate.Value;

        }

        private void clndrsched_Click(object sender, EventArgs e)
        {
          
        }

        private void manageScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbldateselected.Text != "Monday, January 01, 0001" && lbldateselected.Text != "")
            {

                selecteddatemanage = Convert.ToDateTime(lbldateselected.Text);
                ManageSchedule_Form mf = new ManageSchedule_Form();
                mf.ShowDialog();
            }
            else { lbldateselected.Text = ""; }

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
                pnlbottom.BackColor = Color.DarkSlateGray;
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
                pnlbottom.BackColor = Color.FromArgb(0, 122, 204);

            }
            else if (status == 2)
            {
                rsicon.BackgroundImage = imageList1.Images[1];
                pnlbottom.BackColor = Color.FromArgb(237, 28, 36);
            }
        }

        private void gridschedules_DoubleClick(object sender, EventArgs e)
        {
          //  gridView2.FocusedRowHandle > 
        }


        private void clndrsched_DoubleClick(object sender, EventArgs e)
        {
            if (lbldateselected.Text != "Monday, January 01, 0001" && lbldateselected.Text != "")
            {

                string query = "SELECT * FROM tbl_schedule ts inner join tbl_nurse tn on tn.nurse_id = ts.nurse_id inner join tbl_room tr on tr.room_id = ts.nurse_id " +
                    "inner join tbl_patient tp on tp.patient_id = ts.patient_id where (ts.schedule_id != 0) AND (ts.schedule_date = '" + Convert.ToDateTime(lbldateselected.Text).ToString("yyyy-MM-dd") + "')  order by ts.schedule_date DESC;";
                txtsearch.Text = Convert.ToDateTime(lbldateselected.Text).ToString("yyyy-MM-dd");

                LoadSchedule(query);
            }
            else { lbldateselected.Text = ""; }
        }

        private void lblallsched_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tbl_schedule ts inner join tbl_nurse tn on tn.nurse_id = ts.nurse_id inner join tbl_room tr on tr.room_id = ts.nurse_id " +
              "inner join tbl_patient tp on tp.patient_id = ts.patient_id where ts.schedule_id != 0 order by ts.schedule_date DESC;";

            LoadSchedule(query); 
        }

        private void lblclear_Click(object sender, EventArgs e)
        {
            txtsearch.Text = "";
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(gridView2.FocusedRowHandle.ToString());
            string getrow = gridView2.GetGroupRowValue(gridView2.FocusedRowHandle, col_schedule_id).ToString();
            
            MessageBox.Show(getrow);
            int[] rows = gridView2.GetSelectedRows();

            int childrowindex = 0;

           // DataRow row = gridView2.GetSelectedRows()[0];
            for (int i = 0; i < rows.Length; i++)
            {
                if(gridView2.IsGroupRow(rows[i]))
                {

                    MessageBox.Show(gridView2.GetParentRowHandle(i).ToString());

                    int childcount = gridView2.GetChildRowCount(rows[i]);
                    for (int j = 0; j < childcount; j++)
                    {
                        childrowindex = gridView2.GetChildRowHandle(rows[i],i);
                    }
                }
            }
        }

        private void tlsdeleteselected_Click(object sender, EventArgs e)
        {
            DataRowView r = (DataRowView)gridView2.GetFocusedRow();
            if (gridView2.FocusedColumn == col_schedule_date)
                MessageBox.Show("Date");
            else if (gridView2.FocusedColumn == col_schedule_nursefullname)
                MessageBox.Show("Name");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                string query = "SELECT * FROM db_scheduler_system.tbl_user WHERE user_username ='" + txtUsername.Text + "';";
                adapt = new MySqlDataAdapter(query, db.OpenConnection());
                table = new DataTable();
                adapt.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Username is already taken.");
                }
                else if (txtPassword.Text != "")
                {
                    if (txtFullname.Text != "")
                    {
                        MessageBox.Show("A");
                        foraddaccountuser();
                        foraddaccount();
                        MessageBox.Show("Account Succussfly added.");
                        clearfields();
                        PopulateNurse();
                    }
                }
            }
            else if (btnSave.Text == "Update")
            {
                string password = "";
                string query2 = "SELECT * FROM db_scheduler_system.tbl_user WHERE user_id ='" + userid + "';";
                adapt = new MySqlDataAdapter(query2, db.OpenConnection());
                table = new DataTable();
                adapt.Fill(table);
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        password = dr["user_password"].ToString();
                    }
                }
                
                if (userid.ToString() != "0")
                {
                    string query3 = "UPDATE tbl_user SET user_username = '" + txtUsername.Text + "', user_password = '" + txtPassword.Text + "', user_position = '" + cmbPosition.selectedValue + "', user_recovery_password = '" + txtRecovery.Text + "' WHERE user_id = '" + userid + "';";
                    cmd = new MySqlCommand(query3, db.OpenConnection()); ;
                    cmd.ExecuteNonQuery();
                    db.CloseConnection();
                    string query = "UPDATE tbl_nurse SET nurse_fullname ='" + txtFullname.Text + "', nurse_address = '" + txtAddress.Text + "' WHERE nurse_id = '" + nurseid + "';";
                    cmd = new MySqlCommand(query, db.OpenConnection());
                    cmd.ExecuteNonQuery();
                    db.CloseConnection();
                    MessageBox.Show("Successfully Updated!");
                    PopulateNurse();
                    clearfields();
                    btnSave.Text = "Save";
                }
                else
                {
                    int id = 0;
                    foraddaccountuser();
                    string query23 = "SELECT user_id  FROM db_scheduler_system.tbl_user order by last_insert_id(user_id) DESC LIMIT 1;";
                    MySqlDataAdapter adapt1 = new MySqlDataAdapter(query23, db.OpenConnection());
                    DataTable table1 = new DataTable();
                    adapt1.Fill(table1);
                    if (table1.Rows.Count > 0)
                    {
                        foreach (DataRow dr2 in table1.Rows)
                        {
                            id = Convert.ToInt32(dr2["user_id"]);
                        }
                    }
                    MessageBox.Show(id.ToString());
                    string query = "UPDATE tbl_nurse SET nurse_fullname ='" + txtFullname.Text + "', nurse_address = '" + txtAddress.Text + "', user_id = '" + id + "' WHERE nurse_id = '" + nurseid + "';";
                    cmd = new MySqlCommand(query, db.OpenConnection());
                    cmd.ExecuteNonQuery();
                    db.CloseConnection();
                    
                    PopulateNurse();
                    clearfields();
                    MessageBox.Show("Successfully Updated!");
                    btnSave.Text = "Save";
                }
            }

        }
        public void PopulateNurse()
        {
            lsvMedicine.Items.Clear();
            adapt = new MySqlDataAdapter("SELECT * FROM tbl_nurse", db.OpenConnection());
            table = new DataTable(); adapt.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow dr in table.Rows)
                {
                    ListViewItem itm = new ListViewItem(dr["nurse_id"].ToString());
                    if (dr["nurse_fullname"].ToString() != "undefined")
                    {
                        itm.SubItems.Add(dr["nurse_fullname"].ToString());
                        itm.SubItems.Add(dr["nurse_address"].ToString());

                        if (dr["user_id"].ToString() != "0")
                        {

                            MySqlDataAdapter adapt1 = new MySqlDataAdapter("SELECT * FROM tbl_user WHERE user_id = '" + dr["user_id"].ToString() + "';", db.OpenConnection());
                            DataTable table1 = new DataTable(); adapt1.Fill(table1);
                            foreach (DataRow dr1 in table1.Rows)
                            {
                                itm.SubItems.Add(dr1["user_position"].ToString());
                                itm.SubItems.Add(dr1["user_username"].ToString());
                                itm.SubItems.Add(dr1["user_id"].ToString());
                            }
                        }
                        else
                            itm.SubItems.Add("NA");
                        itm.SubItems.Add("NA");
                        itm.SubItems.Add("0");

                        lsvMedicine.Items.Add(itm);
                    }
                    
                    
                }
            }
            else { }
        }
        public void foraddaccountuser()
        {
            //try
            //{
                adapt = new MySqlDataAdapter("SELECT user_id  FROM db_scheduler_system.tbl_user order by last_insert_id(user_id) DESC LIMIT 1;", db.OpenConnection());
                table = new DataTable(); adapt.Fill(table);
                if (table.Rows.Count > 0)
                { foreach (DataRow dr in table.Rows) { count_idnew = Convert.ToInt32(dr[0]); } }
                else { }
                count_idnew++;

                cmd = new MySqlCommand("CreateAccount", db.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                //try
                //{
                    cmd.Parameters.Add(new MySqlParameter("?user_id", count_idnew));
                    cmd.Parameters.Add(new MySqlParameter("?user_position", cmbPosition.selectedValue));
                    cmd.Parameters.Add(new MySqlParameter("?user_username1", txtUsername.Text.ToLower()));
                    cmd.Parameters.Add(new MySqlParameter("?user_password", txtPassword.Text.ToLower()));
                    cmd.Parameters.Add(new MySqlParameter("?user_recovery_password", txtRecovery.Text.ToLower()));
                    cmd.ExecuteNonQuery();
                //}
                //catch (Exception ex)
                //{ MessageBox.Show(ex.Message); }

            //}
            //catch (Exception ex)
            //{ MessageBox.Show(ex.Message); }
        }
        public void clearfields()
        {
            txtAddress.Text = "";
            txtConfirm.Text = "";
            txtFullname.Text = "";
            txtPassword.Text = "";
            cmbPosition.Text = "";
            txtRecovery.Text = "";
            txtUsername.Text = "";
        }
        public void foraddaccount()
        {
            try
            {
                string userid = "";
                adapt = new MySqlDataAdapter("SELECT nurse_id  FROM db_scheduler_system.tbl_nurse order by last_insert_id(nurse_id) DESC LIMIT 1;", db.OpenConnection());
                table = new DataTable(); adapt.Fill(table);
                if (table.Rows.Count > 0)
                { foreach (DataRow dr in table.Rows) { count_id2 = Convert.ToInt32(dr[0]) + 1; } }
                else { }
                count_id2++;
                adapt = new MySqlDataAdapter("SELECT user_id  FROM db_scheduler_system.tbl_user WHERE user_username ='" + txtUsername.Text + "' and user_password ='" + txtPassword.Text + "';", db.OpenConnection());
                table = new DataTable(); adapt.Fill(table);
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        userid = dr["user_id"].ToString();
                    }
                }
                else { }
                cmd = new MySqlCommand("CreateNurseAccount", db.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    cmd.Parameters.Add(new MySqlParameter("?nurse_id", count_id2));
                    cmd.Parameters.Add(new MySqlParameter("?nurse_fullname", txtFullname.Text.ToLower()));
                    cmd.Parameters.Add(new MySqlParameter("?nurse_address", txtAddress.Text.ToLower()));
                    cmd.Parameters.Add(new MySqlParameter("?user_id", userid));
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void lsvMedicine_DoubleClick(object sender, EventArgs e)
        {
            //try
            //{
                nurseid = lsvMedicine.SelectedItems[0].SubItems[0].Text;
                userid = lsvMedicine.SelectedItems[0].SubItems[5].Text;
                txtFullname.Text = lsvMedicine.SelectedItems[0].SubItems[1].Text;
                txtAddress.Text = lsvMedicine.SelectedItems[0].SubItems[2].Text;
                txtUsername.Text = lsvMedicine.SelectedItems[0].SubItems[4].Text;
                btnSave.Text = "Update";
            //}
            //catch (Exception ex) { }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (btnPatientSave.Text == "Save")
            {
                string query = "SELECT * FROM db_scheduler_system.tbl_patient WHERE patient_fullname ='" + txtPatientName.Text + "' AND patient_address ='" + txtPatientAddress.Text + "';";
                adapt = new MySqlDataAdapter(query, db.OpenConnection());
                table = new DataTable();
                adapt.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Patient already assigned.");
                }

                else if (txtPatientName.Text != "" && txtPatientAddress.Text != "")
                {
                    foraddpatient();
                    MessageBox.Show("Patient successfully assigned.");
                    txtPatientName.Text = "";
                    txtPatientAddress.Text = "";
                    PopulatePatient();
                }

            }
            else if (btnPatientSave.Text == "Update")
            {

                string query = "UPDATE tbl_patient SET patient_fullname ='" + txtPatientName.Text + "', patient_address ='" + txtPatientAddress.Text + "', room_id ='" + findRoomid(cmbRooms.selectedValue) + "' WHERE patient_id ='" + patientid + "';";
                MySqlCommand cmd = new MySqlCommand(query, db.OpenConnection());
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                MessageBox.Show("Successfully Updated!");
                PopulatePatient();
                btnPatientSave.Text = "Save";
                txtPatientName.Text = "";
                txtPatientAddress.Text = "";
            }
        }
        public void PopulatePatient()
        {
            lsvPatient.Items.Clear();
            adapt = new MySqlDataAdapter("SELECT p.patient_id, p.patient_fullname, p.patient_address,r.room_name,r.room_code from tbl_patient p INNER JOIN tbl_room r WHERE p.room_id = r.room_id;", db.OpenConnection());
            table = new DataTable(); adapt.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow dr in table.Rows)
                {
                    ListViewItem itm = new ListViewItem(dr["patient_id"].ToString());
                    itm.SubItems.Add(dr["patient_fullname"].ToString());
                    itm.SubItems.Add(dr["patient_address"].ToString());
                    itm.SubItems.Add(dr["room_name"].ToString());
                    itm.SubItems.Add(dr["room_code"].ToString());
                    lsvPatient.Items.Add(itm);
                }
            }
            else { }
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

                cmd = new MySqlCommand("CreatePatient", db.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    cmd.Parameters.Add(new MySqlParameter("?patient_id", count_id));
                    cmd.Parameters.Add(new MySqlParameter("?room_id", findRoomid(cmbRooms.selectedValue)));
                    cmd.Parameters.Add(new MySqlParameter("?patient_fullname", txtPatientName.Text));
                    cmd.Parameters.Add(new MySqlParameter("?patient_address", txtPatientAddress.Text));
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void lsvPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                patientid = Convert.ToInt32(lsvPatient.SelectedItems[0].SubItems[0].Text);
            }
            catch (Exception ex) { }
        }

        private void lsvPatient_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                patientid = Convert.ToInt32(lsvPatient.SelectedItems[0].SubItems[0].Text);
                txtPatientName.Text = lsvPatient.SelectedItems[0].SubItems[1].Text;
                txtPatientAddress.Text = lsvPatient.SelectedItems[0].SubItems[2].Text;
                cmbRooms.Text = lsvPatient.SelectedItems[0].SubItems[3].Text;
                btnPatientSave.Text = "Update";
                PopulateRoom();
            }
            catch (Exception ex) { }
        }

        private void btnPatientDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM tbl_patient WHERE patient_id ='" + patientid + "';";
                MySqlCommand cmd1 = new MySqlCommand(query, db.OpenConnection());
                cmd1.ExecuteNonQuery();
                db.CloseConnection();
                PopulatePatient();
                txtPatientAddress.Text = "";
                txtPatientName.Text = "";
                btnPatientSave.Text = "Save";
            }
            catch (Exception ex) { }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnRoomSave_Click(object sender, EventArgs e)
        {
            if (btnRoomSave.Text == "Save")
            {
                string query = "SELECT * FROM db_scheduler_system.tbl_room WHERE room_name ='" + txtRoomName.Text + "' AND room_code ='" + txtRoomNumber.Text + "';";
                adapt = new MySqlDataAdapter(query, db.OpenConnection());
                table = new DataTable();
                adapt.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Room already assigned.");
                }

                else if (txtRoomName.Text != "" && txtRoomNumber.Text != "")
                {
                    foraddroom();
                    MessageBox.Show("Room successfully assigned.");
                    txtRoomName.Text = "";
                    txtRoomNumber.Text = "";
                    txtDescription.Text = "";
                    PopulateRoom();
                }

            }
            else if (btnRoomSave.Text == "Update")
            {

                string query = "UPDATE tbl_room SET room_name ='" + txtRoomName.Text + "', room_code ='" + txtRoomNumber.Text + "', room_description ='" + txtDescription.Text + "' WHERE room_id ='" + roomid + "';";
                MySqlCommand cmd = new MySqlCommand(query, db.OpenConnection());
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                MessageBox.Show("Successfully Updated!");
                PopulateRoom();
                btnRoomSave.Text = "Save";
                txtRoomName.Text = "";
                txtRoomNumber.Text = "";
                txtDescription.Text = "";
            }
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
                    cmd.Parameters.Add(new MySqlParameter("?room_code", txtRoomNumber.Text));
                    cmd.Parameters.Add(new MySqlParameter("?room_name", txtRoomName.Text));
                    cmd.Parameters.Add(new MySqlParameter("?room_description", txtDescription.Text));
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        public void PopulateRoom()
        {
            lsvRoom.Items.Clear();
            cmbRooms.Clear();
            adapt = new MySqlDataAdapter("SELECT * from tbl_room", db.OpenConnection());
            table = new DataTable(); adapt.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow dr in table.Rows)
                {
                    ListViewItem itm = new ListViewItem(dr["room_id"].ToString());
                    itm.SubItems.Add(dr["room_name"].ToString());
                    itm.SubItems.Add(dr["room_code"].ToString());
                    itm.SubItems.Add(dr["room_description"].ToString());
                    cmbRooms.AddItem(dr["room_name"].ToString());
                    lsvRoom.Items.Add(itm);
                }
            }
            else { }
        }
        public string findRoomid(string roomname)
        {
            string roomidnew = "";
            adapt = new MySqlDataAdapter("SELECT * from tbl_room WHERE room_name ='" + roomname + "';", db.OpenConnection());
            table = new DataTable(); adapt.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow dr in table.Rows)
                {
                    roomidnew = dr["room_id"].ToString();
                }
            }
            else { }
            return roomidnew;
        }

        private void lsvRoom_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                roomid = Convert.ToInt32(lsvRoom.SelectedItems[0].SubItems[0].Text);
                txtRoomName.Text = lsvRoom.SelectedItems[0].SubItems[1].Text;
                txtRoomNumber.Text = lsvRoom.SelectedItems[0].SubItems[2].Text;
                txtDescription.Text = lsvRoom.SelectedItems[0].SubItems[3].Text;
                btnRoomSave.Text = "Update";
            }
            catch (Exception ex) { }
        }

        private void lsvRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                roomid = Convert.ToInt32(lsvRoom.SelectedItems[0].SubItems[0].Text);
            }
            catch (Exception ex) { }
        }

        private void btnRoomDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM tbl_room WHERE room_id ='" + roomid + "';";
                MySqlCommand cmd1 = new MySqlCommand(query, db.OpenConnection());
                cmd1.ExecuteNonQuery();
                db.CloseConnection();
                PopulateRoom();
                txtDescription.Text = "";
                txtRoomName.Text = "";
                txtRoomNumber.Text = "";
                btnRoomSave.Text = "Save";
            }
            catch (Exception ex) { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtQuantity.Text) <= medicinestocks)
                {
                    int stocksleft = medicinestocks - Convert.ToInt32(txtQuantity.Text);
                    ListViewItem itm = new ListViewItem(medid.ToString());
                    itm.SubItems.Add(txtSupplyName.Text);
                    itm.SubItems.Add(txtQuantity.Text);
                    itm.SubItems.Add(DateTime.Now.ToString("yyyy-MM-dd"));
                    itm.SubItems.Add(stocksleft.ToString());
                    itm.SubItems.Add(dtpExpiry.Text);
                    lsvTransaction.Items.Add(itm);
                    string query = "UPDATE tbl_supplies SET supplies_stocks = '" + stocksleft + "' WHERE supplies_id = '" + medid + "';";
                    cmd = new MySqlCommand(query, db.OpenConnection());
                    cmd.ExecuteNonQuery();
                    PopulateSupplies();
                }
            }catch{MessageBox.Show("Please Insert Quantity Value!");}
        }

        private void btnInventorySave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsvTransaction.Items.Count; i++)
            {
                adapt = new MySqlDataAdapter("SELECT supplies_transaction_id  FROM db_scheduler_system.tbl_supplies_transaction order by last_insert_id(supplies_transaction_id) DESC LIMIT 1;", db.OpenConnection());
                table = new DataTable(); adapt.Fill(table);
                if (table.Rows.Count > 0)
                { foreach (DataRow dr in table.Rows) { count_idnew = Convert.ToInt32(dr[0]) + 1; } }
                else { }

                cmd = new MySqlCommand("CreateSuppliesTransaction", db.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                DateTime dtpcreated = Convert.ToDateTime(dtpManufactured.Text);
                string newdatecreatedformat = dtpcreated.ToString("yyyy-MM-dd");
                DateTime dtpexpiry = Convert.ToDateTime(dtpExpiry.Text);
                string newdateexpiryformat = dtpexpiry.ToString("yyyy-MM-dd");
                cmd.Parameters.Add(new MySqlParameter("?supplies_transaction_id", count_idnew));
                cmd.Parameters.Add(new MySqlParameter("?supplies_id", lsvTransaction.Items[i].SubItems[0].Text));
                cmd.Parameters.Add(new MySqlParameter("?supplies_transaction_quantity", lsvTransaction.Items[i].SubItems[2].Text));
                cmd.Parameters.Add(new MySqlParameter("?supplies_transaction_date", lsvTransaction.Items[i].SubItems[3].Text));
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Successful Inventory");
            PrintReportToExcel();
            lsvTransaction.Items.Clear();
        }
        private void PrintReportToExcel()
        {
            Excel.Application oXL;
            Excel.Workbook oWB;
            Excel.Worksheet oSheet;
            Excel.Range oRng;
            object oMissing = Missing.Value;

            //try
            //{

                oXL = new Excel.Application();
                oXL.Visible = true;

                //Get a new workbook.
                oWB = oXL.Workbooks._Open(Application.StartupPath + @"\reports\report.xlsx", oMissing, oMissing, oMissing,
                                          oMissing, oMissing, oMissing, oMissing, oMissing, oMissing,
                                          oMissing, oMissing, oMissing);

                oSheet = (Excel.Worksheet)oWB.ActiveSheet;
                //oSheet.Cells[row,col] = " data "
                oSheet.Cells[4, 5] = DateTime.Now.ToLongDateString(); //Print Date on excel row 4, column F (6)

                int counter = 8;
                for (int i = 0; i < lsvTransaction.Items.Count; i++)
                {
                    oSheet.Cells[counter, 1] = lsvTransaction.Items[i].SubItems[1].Text;
                    oSheet.Cells[counter, 2] = lsvTransaction.Items[i].SubItems[5].Text;
                    oSheet.Cells[counter, 3] = lsvTransaction.Items[i].SubItems[2].Text;
                    counter++;
                }
                int sum = 0;
                for (int i = 0; i < lsvTransaction.Items.Count; i++)
                {
                    sum += Convert.ToInt32(lsvTransaction.Items[i].SubItems[2].Text);
                }
                oSheet.Cells[counter + 2, 3] = sum;

                    //oWB.SaveAs(Application.StartupPath + @"\reports\supplyreport_" + DateTime.Now.Second + ".xlsx", oMissing, oMissing, oMissing, oMissing,
                    //          oMissing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                    //          oMissing, oMissing, oMissing, oMissing, oMissing);

            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message);
            //}
        }
        private void PrintSupplyToExcel()
        {
            Excel.Application oXL;
            Excel.Workbook oWB;
            Excel.Worksheet oSheet;
            Excel.Range oRng;
            object oMissing = Missing.Value;

            //try
            //{

            oXL = new Excel.Application();
            oXL.Visible = true;

            //Get a new workbook.
            oWB = oXL.Workbooks._Open(Application.StartupPath + @"\reports\report.xlsx", oMissing, oMissing, oMissing,
                                      oMissing, oMissing, oMissing, oMissing, oMissing, oMissing,
                                      oMissing, oMissing, oMissing);

            oSheet = (Excel.Worksheet)oWB.ActiveSheet;
            //oSheet.Cells[row,col] = " data "
            oSheet.Cells[4, 5] = DateTime.Now.ToLongDateString(); //Print Date on excel row 4, column F (6)

            int counter = 8;
            for (int i = 0; i < lsvMedicineTransaction.Items.Count; i++)
            {
                oSheet.Cells[counter, 1] = lsvMedicineTransaction.Items[i].SubItems[1].Text;
                oSheet.Cells[counter, 2] = lsvMedicineTransaction.Items[i].SubItems[7].Text;
                oSheet.Cells[counter, 3] = lsvMedicineTransaction.Items[i].SubItems[4].Text;
                counter++;
            }
            int sum = 0;
            for (int i = 0; i < lsvMedicineTransaction.Items.Count; i++)
            {
                sum += Convert.ToInt32(lsvMedicineTransaction.Items[i].SubItems[4].Text);
            }
            oSheet.Cells[counter + 2, 3] = sum;

            oWB.SaveAs(Application.StartupPath + @"\reports\medicinereport_" + DateTime.Now.Second + ".xlsx", oMissing, oMissing, oMissing, oMissing,
                      oMissing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                      oMissing, oMissing, oMissing, oMissing, oMissing);

            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message);
            //}
        }
        public void PopulateSupplies()
        {
            lsvSupplies.Items.Clear();
            adapt = new MySqlDataAdapter("SELECT * from tbl_supplies GROUP BY supplies_name ORDER BY supplies_batch_delivered ASC", db.OpenConnection());
            table = new DataTable(); adapt.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow dr in table.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["supplies_id"].ToString());
                    item.SubItems.Add(dr["supplies_name"].ToString());
                    item.SubItems.Add(dr["supplies_stocks"].ToString());
                    item.SubItems.Add(dr["supplies_batch_delivered"].ToString());
                    item.SubItems.Add(dr["supplies_date_purchase"].ToString());
                    item.SubItems.Add(dr["supplies_expiry"].ToString());
                    lsvSupplies.Items.Add(item);

                }
            }
            else { }
        }
        public void PopulateNew()
        {
            lsvSupplies.Items.Clear();
            adapt = new MySqlDataAdapter("SELECT * from tbl_supplies GROUP BY supplies_name ORDER BY supplies_batch_delivered ASC", db.OpenConnection());
            table = new DataTable(); adapt.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow dr in table.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["supplies_id"].ToString());
                    item.SubItems.Add(dr["supplies_name"].ToString());
                    item.SubItems.Add(dr["supplies_stocks"].ToString());
                    item.SubItems.Add(dr["supplies_batch_delivered"].ToString());
                    item.SubItems.Add(dr["supplies_date_purchase"].ToString());
                    item.SubItems.Add(dr["supplies_expiry"].ToString());
                    lsvSupplies.Items.Add(item);
                }
            }
            else { }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            int stocks = 0;
            int selectedindex = lsvTransaction.SelectedIndices[0];
            adapt = new MySqlDataAdapter("SELECT * from tbl_supplies WHERE supplies_id ='" + transactionid + "';", db.OpenConnection());
            table = new DataTable(); adapt.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow dr in table.Rows)
                {
                    stocks = Convert.ToInt32(dr["supplies_stocks"].ToString());
                }
            }
            int newstocks = stocks + transactionstocks;
            string query = "UPDATE tbl_supplies SET supplies_stocks = '" + newstocks + "' WHERE supplies_id ='" + transactionid + "';";
            cmd = new MySqlCommand(query, db.OpenConnection());
            lsvTransaction.Items.RemoveAt(selectedindex);
            cmd.ExecuteNonQuery();
            PopulateSupplies();
        }

        private void lsvSupplies_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                medid = Convert.ToInt32(lsvSupplies.SelectedItems[0].SubItems[0].Text);
                txtSupplyName.Text = lsvSupplies.SelectedItems[0].SubItems[1].Text;
                dtpManufactured.Text = lsvSupplies.SelectedItems[0].SubItems[4].Text;
                dtpExpiry.Text = lsvSupplies.SelectedItems[0].SubItems[5].Text;
                medicinestocks = Convert.ToInt32(lsvSupplies.SelectedItems[0].SubItems[2].Text);
            }
            catch (Exception ex) { }
        }

        private void lsvSupplies_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                medicinestocks = Convert.ToInt32(lsvSupplies.SelectedItems[0].SubItems[2].Text);
            }
            catch (Exception ex) { }
        }

        private void lsvTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                transactionid = Convert.ToInt32(lsvTransaction.SelectedItems[0].SubItems[0].Text);
                transactionstocks = Convert.ToInt32(lsvTransaction.SelectedItems[0].SubItems[2].Text);
            }
            catch (Exception ex) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabbody.SelectedTabPageIndex = 4;
            PopulateRoom();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtMedicineQuantity.Text) <= medicinestocks)
            {
                int stocksleft = medicinestocks - Convert.ToInt32(txtMedicineQuantity.Text);
                ListViewItem itm = new ListViewItem(medid.ToString());
                itm.SubItems.Add(txtMedicineName.Text);
                itm.SubItems.Add(txtType.Text);
                itm.SubItems.Add(unit);
                itm.SubItems.Add(txtMedicineQuantity.Text);
                itm.SubItems.Add(DateTime.Now.ToString("yyyy-MM-dd"));
                itm.SubItems.Add(stocksleft.ToString());
                itm.SubItems.Add(dateTimePicker1.Text);
                lsvMedicineTransaction.Items.Add(itm);
                string query = "UPDATE tbl_medicine SET medicine_stocks = '" + stocksleft + "' WHERE medicine_id = '" + medid + "';";
                cmd = new MySqlCommand(query, db.OpenConnection());
                cmd.ExecuteNonQuery();
                PopulateMedicine();
            }
        }
        public void PopulateMedicine()
        {
            lsvMedicineInventory.Items.Clear();
            adapt = new MySqlDataAdapter("SELECT * from db_scheduler_system.tbl_medicine GROUP BY medicine_name ORDER BY medicine_batch_delivered ASC", db.OpenConnection());
            table = new DataTable(); adapt.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow dr in table.Rows)
                {
                    ListViewItem itm = new ListViewItem(dr["medicine_id"].ToString());
                    itm.SubItems.Add(dr["medicine_name"].ToString());
                    itm.SubItems.Add(dr["medicine_type"].ToString());
                    itm.SubItems.Add(dr["medicine_stocks"].ToString());
                    itm.SubItems.Add(dr["medicine_batch_delivered"].ToString());
                    itm.SubItems.Add(dr["medicine_date_recieved"].ToString());
                    itm.SubItems.Add(dr["medicine_date_expiry"].ToString());
                    lsvMedicineInventory.Items.Add(itm);
                    count++;

                }
            }
            else { }
        }

        private void lsvMedicineInventory_DoubleClick(object sender, EventArgs e)
        {
            medid = Convert.ToInt32(lsvMedicineInventory.SelectedItems[0].SubItems[0].Text);
            txtMedicineName.Text = lsvMedicineInventory.SelectedItems[0].SubItems[1].Text;
            txtType.Text = lsvMedicineInventory.SelectedItems[0].SubItems[2].Text;
            dtpManufactured.Text = lsvMedicineInventory.SelectedItems[0].SubItems[5].Text;
            dtpExpiry.Text = lsvMedicineInventory.SelectedItems[0].SubItems[6].Text;
            medicinestocks = Convert.ToInt32(lsvMedicineInventory.SelectedItems[0].SubItems[3].Text);
            unit = lsvMedicineInventory.SelectedItems[0].SubItems[3].Text;
        }

        private void lsvMedicineTransaction_DoubleClick(object sender, EventArgs e)
        {
            medid = Convert.ToInt32(lsvMedicineInventory.SelectedItems[0].SubItems[0].Text);
            txtMedicineName.Text = lsvMedicineInventory.SelectedItems[0].SubItems[1].Text;
            txtType.Text = lsvMedicineInventory.SelectedItems[0].SubItems[2].Text;
            dtpManufactured.Text = lsvMedicineInventory.SelectedItems[0].SubItems[6].Text;
            dtpExpiry.Text = lsvMedicineInventory.SelectedItems[0].SubItems[7].Text;
            medicinestocks = Convert.ToInt32(lsvMedicineInventory.SelectedItems[0].SubItems[4].Text);
            unit = lsvMedicineInventory.SelectedItems[0].SubItems[3].Text;
        }

        private void lsvMedicineTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                transactionid = Convert.ToInt32(lsvMedicineTransaction.SelectedItems[0].SubItems[0].Text);
                transactionstocks = Convert.ToInt32(lsvMedicineTransaction.SelectedItems[0].SubItems[4].Text);
                MessageBox.Show(transactionstocks.ToString());
            }
            catch (Exception ex) { }
        }

        private void btnMedicineCancel_Click(object sender, EventArgs e)
        {
            try
            {
                int stocks = 0;
                int selectedindex = lsvMedicineTransaction.SelectedIndices[0];
                adapt = new MySqlDataAdapter("SELECT * from tbl_medicine WHERE medicine_id ='" + transactionid + "';", db.OpenConnection());
                table = new DataTable(); adapt.Fill(table);
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        stocks = Convert.ToInt32(dr["medicine_stocks"].ToString());
                    }
                }
                MessageBox.Show(stocks.ToString());
                int newstocks = stocks + transactionstocks;
                MessageBox.Show(newstocks.ToString());
                string query = "UPDATE tbl_medicine SET medicine_stocks = '" + newstocks + "' WHERE medicine_id ='" + transactionid + "';";
                cmd = new MySqlCommand(query, db.OpenConnection());
                lsvMedicineTransaction.Items.RemoveAt(selectedindex);
                cmd.ExecuteNonQuery();
                PopulateMedicine();
            }
            catch { MessageBox.Show("Please Select item before delete!"); }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsvMedicineTransaction.Items.Count; i++)
            {
                adapt = new MySqlDataAdapter("SELECT medicine_transaction_id  FROM db_scheduler_system.tbl_medicine_transaction order by last_insert_id(medicine_transaction_id) DESC LIMIT 1;", db.OpenConnection());
                table = new DataTable(); adapt.Fill(table);
                if (table.Rows.Count > 0)
                { foreach (DataRow dr in table.Rows) { count_idnew = Convert.ToInt32(dr[0]) + 1; } }
                else { }

                cmd = new MySqlCommand("CreateMedicineTransaction", db.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                DateTime dtpcreated = Convert.ToDateTime(dtpManufactured.Text);
                string newdatecreatedformat = dtpcreated.ToString("yyyy-MM-dd");
                DateTime dtpexpiry = Convert.ToDateTime(dtpExpiry.Text);
                string newdateexpiryformat = dtpexpiry.ToString("yyyy-MM-dd");
                cmd.Parameters.Add(new MySqlParameter("?medicine_transaction_id", count_idnew));
                cmd.Parameters.Add(new MySqlParameter("?medicine_id", lsvMedicineTransaction.Items[i].SubItems[0].Text));
                cmd.Parameters.Add(new MySqlParameter("?medicine_transaction_type", lsvMedicineTransaction.Items[i].SubItems[2].Text));
                cmd.Parameters.Add(new MySqlParameter("?medicine_transaction_quantity", lsvMedicineTransaction.Items[i].SubItems[4].Text));
                cmd.Parameters.Add(new MySqlParameter("?medicine_transaction_date", lsvMedicineTransaction.Items[i].SubItems[5].Text));
                cmd.ExecuteNonQuery();
                PrintSupplyToExcel();
            }
            MessageBox.Show("Successful Inventory");
            lsvMedicineTransaction.Items.Clear();
        }

        private void btnMedicineInventorySave_Click(object sender, EventArgs e)
        {
            if (btnMedicineInventorySave.Text == "Save")
            {
                if (txtMedicineInventoryName.Text != "" && txtMedicineType.Text != "" && txtStock.Text != "" && txtBatch.Text != "" && isDateOk() > 0)
                {
                    foraddaccountuserNew();
                    MessageBox.Show("Successfully Added!");
                    ClearFields();
                    PopulateMedicineNew();

                }
                else
                    MessageBox.Show("Please fill up all the above information.");
            }
            else if (btnMedicineInventorySave.Text == "Update")
            {
                DateTime dtpexpiry = Convert.ToDateTime(dtpMedicineExpiry.Text);
                string newdateexpiryformat = dtpexpiry.ToString("yyyy-MM-dd HHH:MM:ss");
                string query = "UPDATE tbl_medicine SET medicine_name = '" + txtMedicineInventoryName.Text + "', medicine_type= '" + txtMedicineType.Text + "', medicine_stocks ='" + txtStock.Text + "', medicine_batch_delivered = '" + txtBatch.Text + "', medicine_date_recieved ='" + DateTime.Now.ToString("yyyy-MM-dd HHH:MM:ss")+  "', medicine_date_expiry ='" + newdateexpiryformat + "' WHERE medicine_id = '" + medicineid + "';";
                cmd = new MySqlCommand(query, db.OpenConnection());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated!");
                ClearFields();
                PopulateMedicineNew();
                btnMedicineInventorySave.Text = "Save";
            }
        }
        public int isDateOk()
        {
            DateTime dateCreated = Convert.ToDateTime(dtpMedicineManufactured.Text);
            DateTime dateExpiry = Convert.ToDateTime(dtpMedicineExpiry.Text);
            int totaldate = dateExpiry.Subtract(dateCreated).Days;
            return totaldate;
        }
        public int isDateOk1()
        {
            DateTime dateCreated = Convert.ToDateTime(dtpSupplyManufacture.Text);
            DateTime dateExpiry = Convert.ToDateTime(dtpSupplyExpiry.Text);
            int totaldate = dateExpiry.Subtract(dateCreated).Days;
            return totaldate;
        }
        public string getbatchdelivered()
        {
            string datenow = DateTime.Now.ToString("yyyy-MM-dd");
            string[] arraydate = datenow.Split('-');
            string batchconstruct = arraydate[0] + arraydate[1] + arraydate[2];
            return batchconstruct;
        }
        public void ClearFields()
        {
            txtMedicineInventoryName.Text = "";
            txtMedicineType.Text = "";
            txtStock.Text = "";
            txtBatch.Text = "";
        }
        public void foraddaccountuserNew()
        {
            //try
            //{
            adapt = new MySqlDataAdapter("SELECT medicine_id  FROM db_scheduler_system.tbl_medicine order by last_insert_id(medicine_id) DESC LIMIT 1;", db.OpenConnection());
            table = new DataTable(); adapt.Fill(table);
            if (table.Rows.Count > 0)
            { foreach (DataRow dr in table.Rows) { count_idnew = Convert.ToInt32(dr[0]) + 1; } }
            else { }
            //count_idnew++;

            cmd = new MySqlCommand("CreateMedicine", db.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            //try
            //{
            DateTime dtpcreated = Convert.ToDateTime(dtpMedicineManufactured.Text);
            string newdatecreatedformat = dtpcreated.ToString("yyyy-MM-dd");
            DateTime dtpexpiry = Convert.ToDateTime(dtpMedicineExpiry.Text);
            string newdateexpiryformat = dtpexpiry.ToString("yyyy-MM-dd");
            cmd.Parameters.Add(new MySqlParameter("?medicine_id", count_idnew));
            cmd.Parameters.Add(new MySqlParameter("?medicine_name", txtMedicineInventoryName.Text));
            cmd.Parameters.Add(new MySqlParameter("?medicine_type", txtMedicineType.Text));
            cmd.Parameters.Add(new MySqlParameter("?medicine_batch_delivered", txtBatch.Text));
            cmd.Parameters.Add(new MySqlParameter("?medicine_stocks", txtStock.Text));
            cmd.Parameters.Add(new MySqlParameter("?medicine_date_delivered", newdatecreatedformat));
            cmd.Parameters.Add(new MySqlParameter("?medicine_date_recieved", DateTime.Now.ToString("yyyy-MM-dd HHH:MM:ss")));
            cmd.Parameters.Add(new MySqlParameter("?medicine_date_expiry", newdateexpiryformat));
            cmd.ExecuteNonQuery();
            //    }
            //    catch (Exception ex)
            //    { MessageBox.Show(ex.Message); }

            //}
            //catch (Exception ex)
            //{ MessageBox.Show(ex.Message); }
        }
        public void PopulateMedicineNew()
        {
            lsvMedInventory.Items.Clear();
            adapt = new MySqlDataAdapter("SELECT * from tbl_medicine", db.OpenConnection());
            table = new DataTable(); adapt.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow dr in table.Rows)
                {
                    ListViewItem itm = new ListViewItem(dr["medicine_id"].ToString());
                    itm.SubItems.Add(dr["medicine_name"].ToString());
                    itm.SubItems.Add(dr["medicine_type"].ToString());
                    itm.SubItems.Add(dr["medicine_stocks"].ToString());
                    itm.SubItems.Add(dr["medicine_batch_delivered"].ToString());
                    itm.SubItems.Add(dr["medicine_date_recieved"].ToString());
                    itm.SubItems.Add(dr["medicine_date_expiry"].ToString());
                    lsvMedInventory.Items.Add(itm);
                }
            }
            else { }
        }

        private void btnSuppliesDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSuppliesSave_Click(object sender, EventArgs e)
        {

        }

        private void btnSuppliesSave_Click_1(object sender, EventArgs e)
        {
            if (btnSuppliesSave.Text == "Save")
            {
                if (txtSuppliesName.Text != "" && txtSuppliesStocks.Text != "" && txtStatus.Text != "" && isDateOk1() > 0)
                {
                    foraddsupplies();
                    ClearFields1();
                    PopulateSupplies();

                }
            }
            else if (btnSuppliesSave.Text == "Update")
            {
                string query = "UPDATE tbl_supplies SET supplies_name = '" + txtSuppliesName.Text + "', supplies_stocks ='" + txtSuppliesStocks.Text + "', supplies_batch_delivered = '" + txtSupplyBatch.Text + "', supplies_remarks = '" + txtRemarks.Text + "' WHERE supplies_id = '" + suppliesid + "';";
                cmd = new MySqlCommand(query, db.OpenConnection());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated!");
                ClearFields1();
                PopulateSuppliesNew();
            }
        }
        public void ClearFields1()
        {
            txtSuppliesName.Text = "";
            txtStatus.Text = "";
            txtSuppliesStocks.Text = "";
            txtRemarks.Text = "";
        }
        public void PopulateSuppliesNew()
        {
            lsvSupplyInventory.Items.Clear();
            adapt = new MySqlDataAdapter("SELECT * from tbl_supplies", db.OpenConnection());
            table = new DataTable(); adapt.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow dr in table.Rows)
                {
                    ListViewItem itm = new ListViewItem(dr["supplies_id"].ToString());
                    itm.SubItems.Add(dr["supplies_name"].ToString());
                    itm.SubItems.Add(dr["supplies_stocks"].ToString());
                    itm.SubItems.Add(dr["supplies_status"].ToString());
                    itm.SubItems.Add(dr["supplies_batch_delivered"].ToString());
                    itm.SubItems.Add(dr["supplies_date_purchase"].ToString());
                    itm.SubItems.Add(dr["supplies_expiry"].ToString());
                    itm.SubItems.Add(dr["supplies_remarks"].ToString());
                    lsvSupplyInventory.Items.Add(itm);
                }
            }
            else { }
        }
        public void foraddsupplies()
        {
            //try
            //{
            adapt = new MySqlDataAdapter("SELECT supplies_id  FROM db_scheduler_system.tbl_supplies order by last_insert_id(supplies_id) DESC LIMIT 1;", db.OpenConnection());
            table = new DataTable(); adapt.Fill(table);
            if (table.Rows.Count > 0)
            { foreach (DataRow dr in table.Rows) { count_idnew = Convert.ToInt32(dr[0]) + 1; } }
            else { }
            //count_idnew++;

            cmd = new MySqlCommand("CreateSupplies", db.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            //try
            //{
            DateTime dtpcreated = Convert.ToDateTime(dtpSupplyManufacture.Text);
            string newdatecreatedformat = dtpcreated.ToString("yyyy-MM-dd");
            DateTime dtpexpiry = Convert.ToDateTime(dtpSupplyExpiry.Text);
            string newdateexpiryformat = dtpexpiry.ToString("yyyy-MM-dd");
            cmd.Parameters.Add(new MySqlParameter("?supplies_id", count_idnew));
            cmd.Parameters.Add(new MySqlParameter("?supplies_name", txtSuppliesName.Text));
            cmd.Parameters.Add(new MySqlParameter("?supplies_batch_delivered", txtSupplyBatch.Text));
            cmd.Parameters.Add(new MySqlParameter("?supplies_expiry", newdateexpiryformat));
            cmd.Parameters.Add(new MySqlParameter("?supplies_date_purchase", newdatecreatedformat));
            cmd.Parameters.Add(new MySqlParameter("?supplies_stocks", txtSuppliesStocks.Text));
            cmd.Parameters.Add(new MySqlParameter("?supplies_status", txtStatus.Text));
            cmd.Parameters.Add(new MySqlParameter("?supplies_remarks", txtRemarks.Text));
            cmd.ExecuteNonQuery();
            //    }
            //    catch (Exception ex)
            //    { MessageBox.Show(ex.Message); }

            //}
            //catch (Exception ex)
            //{ MessageBox.Show(ex.Message); }
        }

        private void lsvSupplyInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                suppliesid = lsvSupplyInventory.SelectedItems[0].SubItems[0].Text;
            }
            catch (Exception ex) { }
        }

        private void lsvSupplyInventory_DoubleClick(object sender, EventArgs e)
        {
            suppliesid = lsvSupplyInventory.SelectedItems[0].SubItems[0].Text;
            txtSuppliesName.Text = lsvSupplyInventory.SelectedItems[0].SubItems[1].Text;
            txtSuppliesStocks.Text = lsvSupplyInventory.SelectedItems[0].SubItems[2].Text;
            txtStatus.Text = lsvSupplyInventory.SelectedItems[0].SubItems[3].Text;
            txtSupplyBatch.Text = lsvSupplyInventory.SelectedItems[0].SubItems[4].Text;
            txtRemarks.Text = lsvSupplyInventory.SelectedItems[0].SubItems[7].Text;
            btnSuppliesSave.Text = "Update";
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void lsvMedInventory_DoubleClick(object sender, EventArgs e)
        {
            medicineid = lsvMedInventory.SelectedItems[0].SubItems[0].Text;
            txtMedicineInventoryName.Text = lsvMedInventory.SelectedItems[0].SubItems[1].Text;
            txtMedicineType.Text = lsvMedInventory.SelectedItems[0].SubItems[2].Text;
            txtStock.Text = lsvMedInventory.SelectedItems[0].SubItems[3].Text;
            txtBatch.Text = lsvMedInventory.SelectedItems[0].SubItems[4].Text;
            btnMedicineInventorySave.Text = "Update";

        }

        private void lsvMedInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                medicineid = lsvMedInventory.SelectedItems[0].SubItems[0].Text;
            }
            catch (Exception ex) { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE from tbl_medicine WHERE medicine_id = '" + medicineid + "';";
                cmd = new MySqlCommand(query, db.OpenConnection());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted!");
                ClearFields();
            }
            catch (Exception ex) { }
        }

        private void btnSuppliesDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE from tbl_supplies WHERE supplies_id = '" + medicineid + "';";
                cmd = new MySqlCommand(query, db.OpenConnection());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted!");
                ClearFields();
            }
            catch (Exception ex) { }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        private void SetBalloonTip()
        {
            notifyIcon1.Icon = SystemIcons.Exclamation;
            notifyIcon1.BalloonTipTitle = "Scheduler";
            notifyIcon1.BalloonTipText = "Your Scheduler is running.";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel13_Click(object sender, EventArgs e)
        {

        }

        private void clndrsched_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
         //   MessageBox.Show("d");
        }

        private void gridschedules_MouseUp(object sender, MouseEventArgs e)
        {
            //if (e.Button == System.Windows.Forms.MouseButtons.Right)
            //{
            //    var content = (object) sender;
            //    MessageBox.Show(content.ToString());
            //    var myGrid = (DevExpress.XtraGrid.GridControl)sender;

            //    MessageBox.Show(myGrid.ToString());

            //}
        }

        private void forposition_Tick(object sender, EventArgs e)
        {
           // example selected october 31,2017
            int getselectedmonthcount =  (int)CultureInfo.CurrentUICulture.Calendar.GetMonth(clndrsched.DateTime); // kukunin  yung key value  example : january = 1 

            int countdate = (int)DateTime.DaysInMonth(clndrsched.DateTime.Year, getselectedmonthcount); // kunin naman yung bilang ng araw sa slected date mo
           
           
        }


    }
}
