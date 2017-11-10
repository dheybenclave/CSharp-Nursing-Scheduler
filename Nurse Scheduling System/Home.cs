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


namespace Nurse_Scheduling_System
{
    public partial class Home : Form
    {
        Db_Utilities db = new Db_Utilities();
        Responsive res = new Responsive();
        DataTable table = new DataTable();
        MySqlDataAdapter adapt;
        MySqlCommand cmd;


        Point p;
        TextBox subtextbox = new TextBox();
        int TMove, MX, MY = 0;
        string max, showpassword = "on";
        string idshow, position, user_id = "";
        bool fadenow, editconnection, editdone = false;
        public static bool onshow, ifeditconnection, ifcreateaccount = false;
        private int count_id;

        public static string forposition;


        public Home()
        {
            InitializeComponent();
           
            forresponsive();
            forconnection();
        }

        private void pnlheader_MouseMove(object sender, MouseEventArgs e)
        {
            if (TMove == 1) this.SetDesktopLocation(MousePosition.X - MX, MousePosition.Y - MY);

            //if (MousePosition.Y - MY <= 1)
            //{ max = "off"; this.WindowState = FormWindowState.Maximized; }
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
            this.WindowState = FormWindowState.Minimized;
        }
        private void lbladdaccount_Click(object sender, EventArgs e)
        {
            pnllogin.Location = new Point(1000, 1000);
            pnladdaccount.Location = res.autocenterobjects_XY(pnllogin.Width, pnlbody.Width, pnllogin.Height, pnlbody.Height);
            subtextbox = txtaddaccountpassword;
           
        }

        private void btnaddaccountback_Click(object sender, EventArgs e)
        {
            pnladdaccount.Location = new Point(1000, 1000);
            pnllogin.Location = res.autocenterobjects_XY(pnllogin.Width, pnlbody.Width, pnllogin.Height, pnlbody.Height);
            txtaddaccountpassword.Text = txtaddaccountrecoverypassword.Text = txtaddaccountusername.Text = cmbposition.Text = "";

        }

        private void btnconnectback_Click(object sender, EventArgs e)
        {
            pnlsettings.Location = new Point(1000, 1000);
            txtconnectpassword.Text = txtconnectsusername.Text = "";
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            pnlsettings.Location = res.autocenterobjects_XY(pnlsettings.Width, pnlbody.Width, pnlsettings.Height, pnlbody.Height);
            pnlsettings.BringToFront();
          
        }

        public void forresponsive() {

            res.generateresponsive(this);
            bunifuSeparator1.Location = new Point(res.autocenterobjects_X(bunifuSeparator1.Width, pnllogin.Width), bunifuSeparator1.Location.Y);
            bunifuSeparator4.Location = new Point(res.autocenterobjects_X(bunifuSeparator4.Width, pnllogin.Width), bunifuSeparator4.Location.Y);
            lblnotifllogin.Location = new Point(res.autocenterobjects_X(lblnotifllogin.Width, pnllogin.Width), lblnotifllogin.Location.Y);
        }

        public void forconnection()
        {
            db.OpenConnection();
            if (db.GetReadRegistryKey() == null || db.OpenConnection() == null )
            {

                pnlsettings.Location = res.autocenterobjects_XY(pnlsettings.Width, pnlbody.Width, pnlsettings.Height, pnlbody.Height);
                lblnoitfconnect.Location = new Point(res.autocenterobjects_X(lblnoitfconnect.Width, pnlbody.Width), this.lblnoitfconnect.Bounds.Y);
                btnconnectback.Enabled = false;
            }
            else
            {
                pnllogin.Location = new Point(res.autocenterobjects_X(pnllogin.Width, pnlbody.Width), 25);
                btnconnectback.Enabled = true;
            }
            db.CloseConnection();
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            if (txtconnectserver.Text.Trim().Length == 0 || txtconnectport.Text.Trim().Length == 0 || txtconnectdatabase.Text.Trim().Length == 0
                || txtconnectsusername.Text.Trim().Length == 0 )
            {
                lblnoitfconnect.Text = "PLEASE COMPLETE THE SET-UP!.";
            }
            else
            {
                db.server = txtconnectserver.Text;
                db.port = txtconnectport.Text;
                db.database = txtconnectdatabase.Text;
                db.username = txtconnectsusername.Text;
                db.password = txtconnectpassword.Text;

                try
                {
                    db.SaveSettings();
                    db.OpenConnection();

                    if (db.OpenConnection() != null)
                    {
                        lblnoitfconnect.Text = lblnotifllogin.Text = "YOUR DATABASE CONNECTION IS SUCCESS.";
                        txtconnectpasswordback.Text = txtconnectport.Text = txtconnectserver.Text = txtconnectsusername.Text = "";

                        pnlsettings.Location = new Point(1000, 1000);
                        btnconnectback.Enabled = true;
                        pnllogin.Location = res.autocenterobjects_XY(pnllogin.Width, pnlbody.Width, pnllogin.Height, pnlbody.Height);

                    }
                    else { lblnoitfconnect.Text = "YOUR DATABASE CONNECTION IS NOT VALID"; btnconnectback.Enabled = false; }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    lblnoitfconnect.Text = "YOUR DATABASE CONNECTION IS NOT VALID";
                    btnconnectback.Enabled = false;
                }
            }
            lblnoitfconnect.Location = new Point(res.autocenterobjects_X(lblnoitfconnect.Width, pnlsettings.Width), this.lblnoitfconnect.Bounds.Y);
            lblnoitfconnect.Visible = true;
        }

        public static string getposs ;
        public static string getids;
        public void forlogin() {
            try
            {
                if (txtloginusername.Text.Trim().Length != 0 && txtloignpassword.Text.Trim().Length != 0)
                {
                    string query1 = "SELECT * FROM db_scheduler_system.tbl_user WHERE user_username ='" + txtloginusername.Text +
                                    "' AND user_password = '" + txtloignpassword.Text + "';";
                    table = db.QuerySelect(query1);
                    string id = "";
                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            getposs = dr[1].ToString();
                            getids = dr[0].ToString();
                        }
                        this.Visible = false;
                        Schedule_Form.getpos = getposs;
                        Schedule_Form.getid = getids;
                        Schedule_Form sf = new Schedule_Form();
                        sf.Show();
                       

                    }
                    else { lblnotifllogin.Text = "NO ACCOUNT FOUND!."; }
                 
                    

                
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            lblnotifllogin.Visible = true;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            forlogin();
        }

        public void foraddaccount() {
            try
            {
                table = db.QuerySelect("SELECT user_id  FROM deb_scheduler_system.tbl_user order by last_insert_id(user_id) DESC LIMIT 1;");
                if (table.Rows.Count > 0)
                { foreach (DataRow dr in table.Rows) { count_id = Convert.ToInt32(dr[0]) + 1; } }
                else { }


                cmd = new MySqlCommand("CreateAccount", db.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    cmd.Parameters.Add(new MySqlParameter("?user_id", count_id));
                    cmd.Parameters.Add(new MySqlParameter("?user_position", "_" + cmbposition.Text.ToLower()));
                    cmd.Parameters.Add(new MySqlParameter("?user_username1", txtaddaccountusername.Text.ToLower()));
                    cmd.Parameters.Add(new MySqlParameter("?user_password", txtaddaccountpassword.Text.ToLower()));
                    cmd.Parameters.Add(new MySqlParameter("?user_recovery_password", txtaddaccountrecoverypassword.Text.ToLower()));
                    cmd.Parameters.Add(new MySqlParameter("?user_last_insert_data", DateTime.Now.ToString("yyyy-MM-dd HHH:MM:ss")));
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btncreateaccount_Click(object sender, EventArgs e)
        {
             if (txtaddaccountusername.Text.Trim().Length != 0 && txtaddaccountpassword.Text.Trim().Length != 0 && txtaddaccountrecoverypassword.Text.Trim().Length != 0 
                                                                                                                                   && cmbposition.Text !="")
            {
                string query = "SELECT * FROM db_scheduler_system.tbl_user WHERE user_username ='" + txtaddaccountusername.Text + "';";
                table = db.QuerySelect(query);
                adapt.Fill(table);

                if (table.Rows.Count > 0)
                {

                    lblnotificationaddaccount.Text = txtaddaccountusername.Text.ToUpper() + " HAS ALREADY EXIST!.";
                    lblnotificationaddaccount.ForeColor = Color.OrangeRed;
                }
                else
                {
                    foraddaccount();
                    lblnotificationaddaccount.Text = "ADD ACCOUNT SUCCESS!.";
                    lblnotificationaddaccount.ForeColor = Color.SeaGreen;
                }
            }
            else
            { lblnotificationaddaccount.Text = "PLEASE FILL ALL THE REQUIREMENTS!."; lblnotificationaddaccount.ForeColor = Color.OrangeRed; }
     
            lblnotificationaddaccount.Visible = true;
        
        }

        private void lbladdaccountcheck_Click(object sender, EventArgs e)
        {
            if (txtaddaccountusername.Text.Trim().Length != 0)
            {
                string query = "SELECT user_username FROM db_scheduler_system.tbl_user WHERE user_username ='" + txtaddaccountusername.Text + "';";
                table = db.QuerySelect(query);
                adapt.Fill(table);
                if (table.Rows.Count > 0)
                {
                    lblnotificationaddaccount.Text = txtaddaccountusername.Text.ToUpper() + " HAS ALREADY EXIST!.";
                    lblnotificationaddaccount.ForeColor = Color.OrangeRed;
                }
                else
                {
                    lblnotificationaddaccount.Text = "USERNAME ARE AVAILABLE";
                    lblnotificationaddaccount.ForeColor = Color.SeaGreen;
                }
            }
            else { }
             lblnotificationaddaccount.Visible = true;

        }
        private void lbladdaccontshow_Click(object sender, EventArgs e)
        {
            if (showpassword == "on")
            {
                showpassword = "off";
                subtextbox.UseSystemPasswordChar = false;
            }
            else
            {
                showpassword = "on";
                subtextbox.UseSystemPasswordChar = true;
            }
        }

        private void txtaddaccountpasswordback_Click(object sender, EventArgs e)
        {
           
        }

      
        private void txtaddaccountpasswordback_OnValueChanged(object sender, EventArgs e)
        {
                txtaddaccountpassword.BringToFront();
                txtaddaccountpassword.Focus();
                txtaddaccountpasswordback.SendToBack();
        }

        private void txtaddaccountpassword_TextChanged(object sender, EventArgs e)
        {
            subtextbox = txtaddaccountpassword;
            lblnotificationaddaccount.Visible = false;
            if (txtaddaccountpassword.Text.Trim().Length == 0)
            {
                txtaddaccountpassword.SendToBack();
            }
            else { txtaddaccountpassword.BringToFront(); }     
        }

        private void txtloignpasswordback_OnValueChanged(object sender, EventArgs e)
        {
                txtloignpassword.BringToFront();
                txtloignpassword.Focus();
                txtloignpasswordback.SendToBack();
        }

        private void txtloignpassword_TextChanged(object sender, EventArgs e)
        {
            subtextbox = txtloignpassword;
            lblnotifllogin.Visible = false;
            if (txtloignpassword.Text.Trim().Length == 0)
            {
                txtloignpassword.SendToBack();

            }
            else { txtloignpassword.BringToFront(); }     
       }

        private void txtconnectpasswordback_OnValueChanged(object sender, EventArgs e)
        {
                txtconnectpassword.BringToFront();
                txtconnectpassword.Focus();
                txtconnectpasswordback.SendToBack();
        }

        private void txtconnectpassword_TextChanged(object sender, EventArgs e)
        {
            subtextbox = txtconnectpassword;
            lblnoitfconnect.Visible = false;
            if (txtconnectpassword.Text.Trim().Length == 0)
            {
                 txtconnectpassword.SendToBack();
            }
            else { txtconnectpassword.BringToFront(); }     
        }

        private void txtconnectsusername_OnValueChanged(object sender, EventArgs e)
        {
            lblnoitfconnect.Visible = false;
        }

        private void txtloginusername_OnValueChanged(object sender, EventArgs e)
        {
            lblnotifllogin.Visible = false;
        }

        private void txtaddaccountusername_OnValueChanged(object sender, EventArgs e)
        {
            lblnotificationaddaccount.Visible = false;
        }

        private void txtloignpasswordback_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtloignpassword.Text.Trim().Length != 0)
            {
                txtloignpassword.BringToFront();
                txtloignpassword.Focus();
                txtloignpasswordback.SendToBack();
            }

        }

        private void txtconnectpasswordback_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtconnectpassword.Text.Trim().Length != 0)
            {
                txtconnectpassword.BringToFront();
                txtconnectpassword.Focus();
                txtconnectpasswordback.SendToBack();
            }
        }

        private void txtaddaccountpasswordback_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtaddaccountpassword.Text.Trim().Length != 0)
            {
                txtaddaccountpassword.BringToFront();
                txtaddaccountpassword.Focus();
                txtaddaccountpasswordback.SendToBack();
            }
        }

        private void txtloignpassword_Enter(object sender, EventArgs e)
        {

        }

        private void pnlbody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlheader_Paint(object sender, PaintEventArgs e)
        {

        }
   
    }
}
