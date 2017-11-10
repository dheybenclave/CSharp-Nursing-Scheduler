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

namespace Nurse_Scheduling_System
{
    public partial class ManageSchedule_Form : Form
    {

        Db_Utilities db = new Db_Utilities();
        Responsive res = new Responsive();
        DataTable table = new DataTable();
        MySqlDataAdapter adapt;
        MySqlCommand cmd;

        DateTime passselecteddate = Schedule_Form.selecteddatemanage;
        Point p;
        TextBox subtextbox = new TextBox();
        string searchval,combosearchval = "";
        string globalquery = "";

        string gettitle, getdate, getscheduleid, getnursefullname, getroomname, getpatientfullname,getdescription, gettime, getstatus; 

        public ManageSchedule_Form()
        {
            InitializeComponent();
            res.generateresponsive(this);
           
                rdselecteddate.Checked = true;
                dtdate.DateTime = dtdatesearch.DateTime = clndrdate.DateTime = passselecteddate;
                globalquery = "where (ts.schedule_id != 0) AND (ts.schedule_date = '" + Convert.ToDateTime(passselecteddate).ToString("yyyy-MM-dd") + "') ";
                LoadSchedule(globalquery);      
        }


        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlbody_Paint(object sender, PaintEventArgs e)
        {

        }


        public void LoadSchedule(string wherequery)
        {

            //SELECT * FROM tbl_schedule ts inner join tbl_nurse tn on tn.nurse_id = ts.nurse_id inner join 
            //tbl_room tr on tr.room_id = ts.nurse_id inner join tbl_patient tp on tp.patient_id = ts.patient_id order by ts.schedule_date DESC;
            lstschedule.Items.Clear();
            table = db.QuerySelect("SELECT * FROM tbl_schedule ts inner join tbl_nurse tn on tn.nurse_id = ts.nurse_id inner join tbl_room tr on tr.room_id = ts.nurse_id inner join tbl_patient tp on tp.patient_id = ts.patient_id " + wherequery);
 
            try
            {
                foreach (DataRow dr in table.Rows)
                {
                    ListViewItem itm = new ListViewItem(dr["schedule_title"].ToString());
                    itm.SubItems.Add(Convert.ToDateTime(dr["schedule_date"]).ToString("MMMM dd, yyyy"));
                    itm.SubItems.Add(dr["schedule_id"].ToString());
                    itm.SubItems.Add(dr["nurse_fullname"].ToString());
                    itm.SubItems.Add(dr["room_name"].ToString());
                    itm.SubItems.Add(dr["patient_fullname"].ToString());
                    itm.SubItems.Add(dr["schedule_description"].ToString());
                    itm.SubItems.Add(dr["schedule_time"].ToString());
                    itm.SubItems.Add(dr["schedule_status"].ToString());
                    lstschedule.Items.Add(itm);
                }
               
            }

            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }

        private void chkselectall_OnChange(object sender, EventArgs e)
        {
            for (int i = 0; i < lstschedule.Items.Count; i++)
            {
                if (chkselectall.Checked == true){lstschedule.Items[i].Checked = true;}
                else { lstschedule.Items[i].Checked = false; }
            }
        }

        private void rdallsched_CheckedChanged(object sender, EventArgs e)
        {
             globalquery = "order by ts.schedule_date DESC ";
             LoadSchedule(globalquery);
             dtdatesearch.Enabled = false;
        }

        private void rdselecteddate_CheckedChanged(object sender, EventArgs e)
        {
            globalquery = "where (ts.schedule_id != 0) AND (ts.schedule_date = '" + dtdatesearch.DateTime.ToString("yyyy-MM-dd") + "')  order by ts.schedule_date DESC";

            LoadSchedule(globalquery);
            dtdatesearch.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblclear_Click(object sender, EventArgs e)
        {
            txtsearch.Text = "";
        }

        private void txtsearch_OnValueChanged(object sender, EventArgs e)
        {
            searchval = txtsearch.Text.ToLower();
            if (rdselecteddate.Checked == true)
            {
                if (txtsearch.Text.Trim().Length != 0)
                {
                    globalquery = "WHERE ( ts.schedule_id != 0 AND ts.schedule_date ='" + Convert.ToDateTime(dtdatesearch.DateTime).ToString("yyyy-MM-dd") + "' ) " +
                               "AND ( tn.nurse_fullname  LIKE '%" + searchval + "%' OR  ts.schedule_title  LIKE '%" + searchval + "%' )  order by ts.schedule_date DESC LIMIT 10";
                }
                else { globalquery = "where (ts.schedule_id != 0) AND (ts.schedule_date = '" + dtdatesearch.DateTime.ToString("yyyy-MM-dd") + "') "; }

            }
            else if (rdallsched.Checked == true)
            {
                if (txtsearch.Text.Trim().Length != 0)
                {
                    globalquery = "WHERE ( ts.schedule_id != 0 ) AND (ts.schedule_date LIKE '%" + searchval + "%' OR tn.nurse_fullname  LIKE '%" + searchval + "%' OR " +
                               " ts.schedule_title  LIKE '%" + searchval + "%') order by ts.schedule_date DESC LIMIT 10";

                }
                else { globalquery = "order by ts.schedule_date DESC "; }
            }
            LoadSchedule(globalquery);
        }

        private void dtdatesearch_DateTimeChanged(object sender, EventArgs e)
        {
            try
            {
                globalquery = "where (ts.schedule_id != 0) AND (ts.schedule_date = '" + Convert.ToDateTime(dtdatesearch.DateTime).ToString("yyyy-MM-dd") + "') ";

                LoadSchedule(globalquery);
            }
            catch(StackOverflowException ex){}
        }

 
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbhoicesearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            forcombosearch();
        }

        public void forcombosearch()
        {  
            switch (cmbhoicesearch.Text)
            {

                case "All": combosearchval = ""; break;
                case "Title": combosearchval = "ts.schedule_title"; break;
                case "Description": combosearchval = "ts.schedule_description"; break;
                case "Nurse Name": combosearchval = "tn.nurse_fullname"; break;
                case "Patient Name": combosearchval = "tp.patient_fullname"; break;
                case "Room Name": combosearchval = "tr.room_code-tr.room_name"; break;
                case "Status": combosearchval = "ts.schedule_status"; break;
            }
        }


        public void getselectedsched()
        {
            try
            {
                gettitle = lstschedule.FocusedItem.SubItems[0].Text;
                getdate = lstschedule.FocusedItem.SubItems[1].Text;
                getscheduleid = lstschedule.FocusedItem.SubItems[2].Text;
                getnursefullname = lstschedule.FocusedItem.SubItems[3].Text;
                getroomname = lstschedule.FocusedItem.SubItems[4].Text;
                getpatientfullname = lstschedule.FocusedItem.SubItems[5].Text;
                getdescription = lstschedule.FocusedItem.SubItems[6].Text;
                gettime = lstschedule.FocusedItem.SubItems[7].Text;
                getstatus = lstschedule.FocusedItem.SubItems[7].Text;
            }
            catch { }
       
        }
        private void lstschedule_DoubleClick(object sender, EventArgs e)
        {
            getselectedsched();
            txtnursename.Text = getnursefullname;
            txtpatientname.Text = getpatientfullname;
            txtroom.Text = getroomname;
            txttitle.Text = gettitle;
            cmbstatus.SelectedText = getstatus;
            tmtime.EditValue = Convert.ToDateTime(gettime).ToString("hh:mm:ss");
            dtdate.DateTime = clndrdate.DateTime = Convert.ToDateTime(getdate);
            txtdescription.Text = getdescription;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
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

            try
            {
                string q = "UPDATE `db_scheduler_system`.`tbl_schedule` SET " +
                            "`nurse_id`='" + nurse_id + "', " +
                            "`room_id`='" + room_id + "', " +
                            "`patient_id`='" + patient_id + "', " +
                            "`schedule_title`='" + txttitle.Text + "', " +
                            "`schedule_description`='" + txtdescription.Text + "', " +
                            "`schedule_time`='" + Convert.ToDateTime(tmtime.Time).ToString("hh:mm:ss") + "', " +
                            "`schedule_date`='" + Convert.ToDateTime(dtdate.DateTime).ToString("yyyy-MM-dd") + "', " +
                              "`schedule_status`='" + cmbstatus.SelectedItem.ToString() + "' " +
                              " WHERE `schedule_id`='" + lstschedule.FocusedItem.SubItems[2].Text+"';";
      
                cmd = new MySqlCommand(q, db.OpenConnection());
                cmd.ExecuteNonQuery();
                fornotif(1, "Updating Schedule Success");
                
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

             getselectedsched();

                string q = "DELETE FROM `db_scheduler_system`.`tbl_schedule` WHERE `schedule_id`='"+getscheduleid+"';";
                 cmd = new MySqlCommand(q, db.OpenConnection());
                cmd.ExecuteNonQuery();
    
            fornotif(1,"Delete Schedule Success");
         }

        private void lstschedule_Click(object sender, EventArgs e)
        {
             getselectedsched();
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
            else if (status == 3)
            {
                rsicon.BackgroundImage = imageList1.Images[1];
                pnlbottom.BackColor = Color.FromArgb(237, 28, 36);
            }
        }

        private void lstschedule_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
