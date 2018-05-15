using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command_Suite
{
    public partial class Form1 : Form
    {



        Timer t = new Timer();
      
    


        public Form1()
        {
            InitializeComponent();

            // variable inits
            araOFF.Visible = true;
            araON.Visible = false;



        }

        
      



        // this t_Tick is for the digital timer 
        private void t_Tick(object sender, EventArgs e)
        {

            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            digitalclock.Text = hh + ":" + mm + ":" + ss; // this creates a digital clock.

        }


        private void saveIncidentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // --------------------digital time-----------------
            t.Interval = 1000; // timer interval
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
            // -------------------------------------------------



        }

        private void methane_Click(object sender, EventArgs e)
        {

        }

        private void incLocation_TextChanged(object sender, EventArgs e)
        {
            exactlocation.Text = incLocation.Text;
        }

        private void incType_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeofincident.Text = incType.Text;
        }

        private void turnARAReminderOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            araON.Visible = false;
            araOFF.Visible = true;
        }

        private void oN60minReminderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            araON.Visible = true;
            araOFF.Visible = false;
        }

        private void oN20minReminderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            araON.Visible = true;
            araOFF.Visible = false;
        }
    }
}
