using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nurse_Scheduling_System
{

    // DEFAULI WINDOWS SIZE 1000,666
    // CUSTOMIZE RESPONSIVE CLASS 
    // REQUIRMENTS FOR THIS CLASS : PANEL ONLY FOR THE BASE OF YOUR RESPONSIVE OBJECTS
    // DHEO BENSURTO CLAVERIA (BSCS 2014- 2018) - NAVOTAS POLYTECHNIC COLLEGE
    // CONTACT: dheybenclave@gmail.com || dheo_claveria@yahoo.com || dheybenclave
    //475, 598

    class Responsive
    {
        Point p;
        string max = "on";
        public static bool onshow = false;


        public void adjustpanel(Form frm)//MINIMIZE AND MAXIMIZE BUTTONS
        {
            if (max == "on") { max = "off"; frm.WindowState = FormWindowState.Maximized; }
            else { max = "on"; frm.WindowState = FormWindowState.Normal; }
            generateresponsive(frm);

        }

        public void generateresponsive(Form frm)//MANUAL CENTER FOR ALL RESOLUTION IN COMPUTER, REQUIREMENTS : START POSITION(FORM) = MANUAL
        {
            p.X = (Screen.PrimaryScreen.Bounds.Width / 2) - (frm.Size.Width / 2);
            p.Y = (Screen.PrimaryScreen.Bounds.Height / 2) - (frm.Size.Height / 2);
            frm.Location = p;
        }


        public int autocenterobjects_X(int width, int basewidth)// AUTO X CENTER  OBJECTS , REQUIREMENTS : PANEL FOR BASE 
        {
            int retval = 0;
            int cur = width;
            try
            {
                int ccur = basewidth / 2 - cur / 2;
                retval = ccur;
            }
            catch { }
            return retval;
        }

        public int autocenterobjects_Y(int height, int baseheight)// AUTO Y CENTER  OBJECTS , REQUIREMENTS : PANEL FOR BASE 
        {
            int retval = 0;
            int cur = height;
            try
            {
                int ccur = baseheight / 2 - cur / 2;
                retval = ccur;
            }
            catch { }
            return retval;
        }

        public Point autocenterobjects_XY(int width, int basewidth, int height, int baseheight)// AUTO X AND Y CENTER  OBJECTS , REQUIREMENTS : PANEL FOR BASE 
        {
            // width and height = width/ height of your object that you want to center ex : buttons, groupbox, listview etc
            // basewidth and baseheight = the basement of your object that you want center ex: form, panel, groupbox 

            Point retval = new Point(width, height);
            int curx = width; int cury = height;
            try
            {
                Point newpoint = new Point(basewidth / 2 - curx / 2, baseheight / 2 - cury / 2);
                retval = newpoint;
            }
            catch { }
            return retval;
        }


        public void hoverborder(Button b)// MANUAL HOVER FOR BUTTONS, REQUIREMETNS CALL THIS FUNCTION IN WHEN FORM IS STARTED
        {
            if (b.Focus() == true)
            {
                b.FlatAppearance.BorderColor = b.BackColor;
            }
            else { b.FlatAppearance.BorderSize = 0; }
            b.FlatAppearance.BorderSize = 2;
        }

        public void resizepanelbutton_W(Button b, Panel p, int divided)//AUTO WIDTH RESIZE GROUP BUTTONS, REQUIREMENTS : PANEL FOR THE BASE , BUTTONS , DIVISOR FOR EQUAL VALUE
        {

            double sup = p.Width / divided;
            b.Width = Convert.ToInt32(sup);
        }

        public void resizepanelbutton_Y(Button b, Panel p, int divided)//AUTO HEIGHT RESIZE GROUP BUTTONS, REQUIREMENTS : PANEL FOR THE BASE , BUTTONS , DIVISOR FOR EQUAL VALUE
        {

            double sup = p.Height / divided;
            b.Height = Convert.ToInt32(sup);
        }

        public Form frm { get; set; }
    }
}