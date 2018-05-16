using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Command_Suite
{
    public partial class Form1 : Form
    {

        

        Timer t = new Timer();
        System.Diagnostics.Stopwatch _sw = new System.Diagnostics.Stopwatch();


        public Form1()
        {
            InitializeComponent();

            // variable inits
            araOFF.Visible = true;
            araON.Visible = false;
            //------------------------------------------------------------------------------------------------------------------------------------
            //------------------------------------------------------------------------------------------------------------------------------------
            //------------------------------------------------------------------------------------------------------------------------------------
            //
            //  MAKE SURE TO UNCOMMENT THE TABCONTROL VISIBILITY BELOW BEFORE DEPLOYING TO PRODUCTION.
            //
            //
            //
            //------------------------------------------------------------------------------------------------------------------------------------
            //------------------------------------------------------------------------------------------------------------------------------------
            //------------------------------------------------------------------------------------------------------------------------------------

            //  tabControl1.TabPages.Remove(Calculations);

            


            // cfrs appliance views
            cfrspos1.Text = null;
            cfrspos2.Text = null;
            cfrspos3.Text = null;
            cfrspos4.Text = null;
            cfrspos5.Text = null;
            cfrspos6.Text = null;
            cfrspos7.Text = null;
            cfrspos8.Text = null;
            cfrspos9.Text = null;
            cfrspos10.Text = null;
            cfrspos11.Text = null;
            cfrspos12.Text = null;
            cfrspos13.Text = null;
            cfrspos14.Text = null;
            cfrspos15.Text = null;
            cfrspos16.Text = null;
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

            // -- calculation nulls
            // cfrs appliance one
            textBox6.Text = "0";
            textBox5.Text = "0";
            textBox4.Text = "0";
            textBox3.Text = "0";
            textBox2.Text = "0";
            textBox1.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox40.Text = "0";
            textBox39.Text = "0";
            textBox38.Text = "0";
            textBox37.Text = "0";
            textBox36.Text = "0";
            textBox35.Text = "0";
            textBox46.Text = "0";
            textBox45.Text = "0";
            textBox44.Text = "0";
            textBox43.Text = "0";
            textBox42.Text = "0";
            textBox41.Text = "0";
// appliance 2
            textBox58.Text = "0";
            textBox57.Text = "0";
            textBox56.Text = "0";
            textBox55.Text = "0";
            textBox54.Text = "0";
            textBox53.Text = "0";
            textBox52.Text = "0";
            textBox51.Text = "0";
            textBox50.Text = "0";
            textBox49.Text = "0";
            textBox48.Text = "0";
            textBox47.Text = "0";
            textBox34.Text = "0";
            textBox33.Text = "0";
            textBox16.Text = "0";
            textBox15.Text = "0";
            textBox14.Text = "0";
            textBox13.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";

           




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
           //-- here will save the incident
        }


        



        private void Form1_Load(object sender, EventArgs e)
        {
            // --------------------digital time-----------------
            t.Interval = 1000; // timer interval
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();

            // -------------------------------------------------


            datenow.Text = DateTime.Now.ToString("dd/MM/yyy");




            // this will make the program go full screen on the device.
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;


         



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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void digitalclock_Click(object sender, EventArgs e)
        {

        }

        private void label179_Click(object sender, EventArgs e)
        {

        }

     


        private void app1oic_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // CFRS appliance 1 calculations.
            //oic
            if (app1oic.Text.Contains ("FF") == true)
            {
                textBox6.Text = "1";
                textBox40.Text = "0";
                textBox46.Text = "0";

            }
            else if (app1oic.Text.Contains("CC") == true)
            {
                textBox40.Text = "1";
                textBox46.Text = "0";
                textBox6.Text = "0";

            }
            else if (app1oic.Text.Contains("WC") == true)
            {
                textBox46.Text = "1";
                textBox6.Text = "0";
                textBox40.Text = "0";

            }
            //driver
            if (app1driver.Text.Contains("FF") == true)
            {
                textBox5.Text = "1";
                textBox39.Text = "0";
                textBox45.Text = "0";

            }
            else if (app1driver.Text.Contains("CC") == true)
            {
                textBox39.Text = "1";
                textBox5.Text = "0";
                textBox45.Text = "0";

            }
            else if (app1driver.Text.Contains("WC") == true)
            {
                textBox45.Text = "1";
                textBox39.Text = "0";
                textBox5.Text = "0"; 


            }
            //ba1
            if (app1ba1.Text.Contains("FF") == true)
            {
                textBox4.Text = "1";
                textBox38.Text = "0";
                textBox44.Text = "0";

            }
            else if (app1ba1.Text.Contains("CC") == true)
            {
                textBox38.Text = "1";
                textBox44.Text = "0";
                textBox4.Text = "0";

            }
            else if (app1ba1.Text.Contains("WC") == true)
            {
                textBox44.Text = "1";
                textBox4.Text = "0";
                textBox38.Text = "0";

            }
            //ba2
            if (app1ba2.Text.Contains("FF") == true)
            {
                textBox3.Text = "1";
                textBox37.Text = "0";
                textBox43.Text = "0";

            }
            else if (app1ba2.Text.Contains("CC") == true)
            {
                textBox37.Text = "1";
                textBox43.Text = "0";
                textBox3.Text = "0";

            }
            else if (app1ba2.Text.Contains("WC") == true)
            {
                textBox43.Text = "1";
                textBox3.Text = "0";
                textBox37.Text = "0";

            }
            //eco
            if (app1eco.Text.Contains("FF") == true)
            {
                textBox2.Text = "1";
                textBox36.Text = "0";
                textBox42.Text = "0";

            }
            else if (app1eco.Text.Contains("CC") == true)
            {
                textBox36.Text = "1";
                textBox42.Text = "0";
                textBox2.Text = "0";

            }
            else if (app1eco.Text.Contains("WC") == true)
            {
                textBox42.Text = "1";
                textBox2.Text = "0";
                textBox36.Text = "0";

            }
            //6
            if (app16.Text.Contains("FF") == true)
            {
                textBox1.Text = "1";
                textBox35.Text = "0";
                textBox41.Text = "0";

            }
            else if (app16.Text.Contains("CC") == true)
            {
                textBox35.Text = "1";
                textBox41.Text = "0";
                textBox1.Text = "0";

            }
            else if (app16.Text.Contains("WC") == true)
            {
                textBox41.Text = "1";
                textBox1.Text = "0";
                textBox35.Text = "0";

            }
            // -- additions
            int oic1ff = Int32.Parse(textBox6.Text);
            int driver1ff = Int32.Parse(textBox5.Text);
            int ba11ff = Int32.Parse(textBox4.Text);
            int ba21ff = Int32.Parse(textBox3.Text);
            int eco1ff = Int32.Parse(textBox2.Text);
            int pos1ff = Int32.Parse(textBox1.Text);
            int oic1cc = Int32.Parse(textBox40.Text);
            int driver1cc = Int32.Parse(textBox39.Text);
            int ba11cc = Int32.Parse(textBox38.Text);
            int ba21cc = Int32.Parse(textBox37.Text);
            int eco1cc = Int32.Parse(textBox36.Text);
            int pos1cc = Int32.Parse(textBox35.Text);
            int oic1wc = Int32.Parse(textBox46.Text);
            int driver1wc = Int32.Parse(textBox45.Text);
            int ba11wc = Int32.Parse(textBox44.Text);
            int ba21wc = Int32.Parse(textBox43.Text);
            int eco1wc = Int32.Parse(textBox42.Text);
            int pos1wc = Int32.Parse(textBox41.Text);

            textBox9.Text = (oic1ff + driver1ff + ba11ff + ba21ff + eco1ff + pos1ff).ToString();
            textBox8.Text = (oic1cc + driver1cc + ba11cc + ba21cc + eco1cc + pos1cc).ToString();
            textBox7.Text = (oic1wc + driver1wc + ba11wc + ba21wc + eco1wc + pos1wc).ToString();


            // ---------------------------------------------------------------------------------------

            // CFRS appliance 2 calculations.
            //oic
            if (app2oic.Text.Contains("FF") == true)
            {
                textBox58.Text = "1";
                textBox34.Text = "0";
                textBox52.Text = "0";

            }
            else if (app2oic.Text.Contains("CC") == true)
            {
                textBox52.Text = "1";
                textBox58.Text = "0";
                textBox34.Text = "0";

            }
            else if (app2oic.Text.Contains("WC") == true)
            {
                textBox34.Text = "1";
                textBox52.Text = "0";
                textBox58.Text = "0";

            }
            //driver
            if (app2driver.Text.Contains("FF") == true)
            {
                textBox57.Text = "1";
                textBox51.Text = "0";
                textBox33.Text = "0";

            }
            else if (app2driver.Text.Contains("CC") == true)
            {
                textBox51.Text = "1";
                textBox33.Text = "0";
                textBox57.Text = "0";

            }
            else if (app2driver.Text.Contains("WC") == true)
            {
                textBox33.Text = "1";
                textBox57.Text = "0";
                textBox51.Text = "0";

            }
            //ba1
            if (app2ba1.Text.Contains("FF") == true)
            {
                textBox56.Text = "1";
                textBox50.Text = "0";
                textBox16.Text = "0";

            }
            else if (app2ba1.Text.Contains("CC") == true)
            {
                textBox50.Text = "1";
                textBox16.Text = "0";
                textBox56.Text = "0";

            }
            else if (app2ba1.Text.Contains("WC") == true)
            {
                textBox16.Text = "1";
                textBox56.Text = "0";
                textBox50.Text = "0";

            }
            //ba2
            if (app2ba2.Text.Contains("FF") == true)
            {
                textBox55.Text = "1";
                textBox49.Text = "0";
                textBox15.Text = "0";

            }
            else if (app2ba2.Text.Contains("CC") == true)
            {
                textBox49.Text = "1";
                textBox15.Text = "0";
                textBox55.Text = "0";

            }
            else if (app2ba2.Text.Contains("WC") == true)
            {
                textBox15.Text = "1";
                textBox55.Text = "0";
                textBox49.Text = "0";

            }
            //eco
            if (app2eco.Text.Contains("FF") == true)
            {
                textBox54.Text = "1";
                textBox48.Text = "0";
                textBox14.Text = "0";

            }
            else if (app2eco.Text.Contains("CC") == true)
            {
                textBox48.Text = "1";
                textBox14.Text = "0";
                textBox54.Text = "0";

            }
            else if (app2eco.Text.Contains("WC") == true)
            {
                textBox14.Text = "1";
                textBox54.Text = "0";
                textBox48.Text = "0";

            }
            //6
            if (app26.Text.Contains("FF") == true)
            {
                textBox53.Text = "1";
                textBox47.Text = "0";
                textBox13.Text = "0";

            }
            else if (app26.Text.Contains("CC") == true)
            {
                textBox47.Text = "1";
                textBox13.Text = "0";
                textBox53.Text = "0";

            }
            else if (app26.Text.Contains("WC") == true)
            {
                textBox13.Text = "1";
                textBox53.Text = "0";
                textBox13.Text = "0";

            }
            // -- additions
            int oic2 = Int32.Parse(textBox58.Text);
            int driver2 = Int32.Parse(textBox57.Text);
            int ba12 = Int32.Parse(textBox56.Text);
            int ba22 = Int32.Parse(textBox55.Text);
            int eco2 = Int32.Parse(textBox54.Text);
            int pos2 = Int32.Parse(textBox53.Text);
            int oic2cc = Int32.Parse(textBox52.Text);
            int driver2cc = Int32.Parse(textBox51.Text);
            int ba12cc = Int32.Parse(textBox50.Text);
            int ba22cc = Int32.Parse(textBox49.Text);
            int eco2cc = Int32.Parse(textBox48.Text);
            int pos2cc = Int32.Parse(textBox47.Text);
            int oic2wc = Int32.Parse(textBox34.Text);
            int driver2wc = Int32.Parse(textBox33.Text);
            int ba12wc = Int32.Parse(textBox16.Text);
            int ba22wc = Int32.Parse(textBox15.Text);
            int eco2wc = Int32.Parse(textBox14.Text);
            int pos2wc = Int32.Parse(textBox13.Text);

            textBox12.Text = (oic2 + driver2 + ba12 + ba22 + eco2 + pos2).ToString();
            textBox11.Text = (oic2cc + driver2cc + ba12cc + ba22cc + eco2cc + pos2cc).ToString();
            textBox10.Text = (oic2wc + driver2wc + ba12wc + ba22wc + eco2wc + pos2cc).ToString();


            // ---------------------------------------------------------------------------------------

            cfrspos1.Text = app1.Text;
            cfrspos2.Text = app2.Text;
            cfrspos3.Text = app3.Text;
            cfrspos4.Text = app4.Text;
            cfrspos5.Text = app5.Text;
            cfrspos6.Text = app6.Text;
            cfrspos7.Text = app7.Text;
            cfrspos8.Text = app8.Text;
            cfrspos9.Text = "";                 // ADD THESE AS AND WHEN MORE APPLIANCE POSITIONS HAVE BEEN CREATED!!!
            cfrspos10.Text = "";
            cfrspos11.Text = "";
            cfrspos12.Text = "";
            cfrspos13.Text = "";
            cfrspos14.Text = "";
            cfrspos15.Text = "";
            cfrspos16.Text = "";





         


            // ---  END OF UPDATE SECTION ---- \\
        }

        private void label434_Click(object sender, EventArgs e)
        {

        }

        private void textBox194_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
