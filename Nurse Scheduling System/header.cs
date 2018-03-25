using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nurse_Scheduling_System
{
    public partial class header : UserControl
    {
        public header()
        {
            InitializeComponent();
            
        }
        Responsive res = new Responsive();
        private void btnclose_Click(object sender, EventArgs e)
        {
            mainform.Close();
        }
        private void btnmaxmin_Click(object sender, EventArgs e)
        {
            res.adjustpanel(mainform);
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            mainform.WindowState = FormWindowState.Minimized;
        }
        public void generateheader(Form frms)
        { mainform = frms; }

        public Form mainform { get; set; }

      
    }
}
