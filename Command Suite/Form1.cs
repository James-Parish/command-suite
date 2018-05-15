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


            // cfrs appliance views
            label29.Text = null;
            label30.Text = null;
            label31.Text = null;
            label32.Text = null;
            label33.Text = null;
            label34.Text = null;
            label35.Text = null;
            label36.Text = null;
            label37.Text = null;
            label38.Text = null;
            label39.Text = null;
            label40.Text = null;
            label41.Text = null;
            label42.Text = null;
            label43.Text = null;
            label44.Text = null;
            label45.Text = null;
            label46.Text = null;
            label47.Text = null;
            label48.Text = null;
            label49.Text = null;
            label50.Text = null;
            label51.Text = null;
            label52.Text = null;
            label53.Text = null;
            label54.Text = null;
            label55.Text = null;
            label56.Text = null;
            label57.Text = null;
            label58.Text = null;
            label59.Text = null;
            label60.Text = null;
            label61.Text = null;
            label62.Text = null;
            label63.Text = null;
            label64.Text = null;
            label65.Text = null;
            label66.Text = null;
            label67.Text = null;
            label68.Text = null;
            label69.Text = null;
            label70.Text = null;
            label71.Text = null;
            label72.Text = null;
            label73.Text = null;
            label74.Text = null;
            label75.Text = null;
            label76.Text = null;
            label77.Text = null;
            label78.Text = null;
            label79.Text = null;
            label80.Text = null;
            label81.Text = null;
            label82.Text = null;
            label83.Text = null;
            label84.Text = null;
            label85.Text = null;
            label86.Text = null;
            label87.Text = null;
            label88.Text = null;
            label89.Text = null;
            label90.Text = null;
            label91.Text = null;
            label92.Text = null;

            // cfrs appliance views
            label93.Text = null;
            label94.Text = null;
            label99.Text = null;
            label100.Text = null;
            label101.Text = null;
            label102.Text = null;
            label109.Text = null;
            label110.Text = null;
            label111.Text = null;
            label112.Text = null;
            label113.Text = null;
            label114.Text = null;
            label115.Text = null;
            label116.Text = null;
            label117.Text = null;
            label118.Text = null;
            label119.Text = null;
            label120.Text = null;
            label121.Text = null;
            label122.Text = null;
            label123.Text = null;
            label124.Text = null;
            label125.Text = null;
            label126.Text = null;
            label127.Text = null;
            label128.Text = null;
            label129.Text = null;
            label130.Text = null;
            label131.Text = null;
            label132.Text = null;
            label133.Text = null;
            label134.Text = null;
            label135.Text = null;
            label136.Text = null;
            label137.Text = null;
            label138.Text = null;
            label139.Text = null;
            label140.Text = null;
            label141.Text = null;
            label142.Text = null;
            label143.Text = null;
            label144.Text = null;
            label145.Text = null;
            label146.Text = null;
            label147.Text = null;
            label148.Text = null;
            label149.Text = null;
            label150.Text = null;
            label151.Text = null;
            label152.Text = null;
            label153.Text = null;
            label154.Text = null;
            label155.Text = null;
            label156.Text = null;
            label157.Text = null;
            label158.Text = null;
            label159.Text = null;
            label160.Text = null;
            label161.Text = null;
            label162.Text = null;
            label163.Text = null;
            label164.Text = null;
            label165.Text = null;
            label166.Text = null;



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

        private void label55_Click(object sender, EventArgs e)
        {

        }
    }
}
