using System;
using System.Windows.Forms;

namespace WindowsFormsApp3bsms
{
    public partial class Form1 : Form
    {
        dashboard maindash;
        brgyindency brgyin;
        resident rsdent;
        brgyClearance clearance;
        brgyCertification certification;
        brgyresidency residency;
        Financial finance;
        household househl;
        housemapping housemap;
        eventscheduling eventsched;
        kpreport kpreps;
        monthlyreport monthreps;
        weeklyreport weekreps;
        roadreport roadreps;
        blotterrecord blotterecs;
        kprecord kprecs;

        public Form1()
        {
            InitializeComponent();
        }
        bool sidebar = false;
        private void sideTransition_Tick(object sender, EventArgs e)
        {
            if (sidebar) {
                panel2.Width -= 10;
                if (panel2.Width <=61) {
                    sidebar = false;
                    sideTransition.Stop();

                }
            } else {
                panel2.Width += 10;
                if (panel2.Width >= 236) {
                    sidebar = true;
                    sideTransition.Stop();
                
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sideTransition.Start();
        }
        bool cerExpand = false;
        private void cerTransition_Tick(object sender, EventArgs e)
        {
            if (cerExpand == false)
            {
                cercontainer.Height += 5;
                if (cercontainer.Height >= 275)
                {
                    cerTransition.Stop();
                    cerExpand = true;
                }

            }
            else {
                cercontainer.Height -= 5;
                if (cercontainer.Height <= 55) {
                    cerTransition.Stop();
                    cerExpand = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cerTransition.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void brgyindegency_Click(object sender, EventArgs e)
        {
            if (brgyin == null)
            {
                brgyin = new brgyindency();
                brgyin.FormClosed += Brgyin_FormClosed;
                brgyin.MdiParent = this;
                brgyin.Dock = DockStyle.Fill;
                brgyin.Show();
            }
            else
            {
                brgyin.Activate();

            }
        }

        private void Brgyin_FormClosed(object sender, FormClosedEventArgs e)
        {
            brgyin = null;
        }

        private void brgyresidency_Click(object sender, EventArgs e)
        {
            if (residency == null)
            {
                residency = new brgyresidency();
                residency.FormClosed += Residency_FormClosed;
                residency.MdiParent = this;
                residency.Dock = DockStyle.Fill;
                residency.Show();
            }
            else
            {
                residency.Activate();

            }
        }

        private void Residency_FormClosed(object sender, FormClosedEventArgs e)
        {
            residency = null;
        }

        private void cercontainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnresident_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (maindash == null)
            {
                maindash = new dashboard();
                maindash.FormClosed += Dashboard_FormClosed;
                maindash.MdiParent = this;
                maindash.Dock = DockStyle.Fill;
                maindash.Show(); 
            }
            else {
                maindash.Activate();
            
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {

            maindash = null;
        }

        private void btnresident_Click_1(object sender, EventArgs e)
        {
            if (rsdent == null)
            {
                rsdent = new resident();
                rsdent.FormClosed += Resident_FormClosed;
                rsdent.MdiParent = this;
                rsdent.Dock = DockStyle.Fill;
                rsdent.Show();
            }
            else
            {
                rsdent.Activate();

            }
        }

        private void Resident_FormClosed(object sender, FormClosedEventArgs e)
        {
            rsdent = null;
        }

        private void brgyclearance_Click(object sender, EventArgs e)
        {
            if (clearance == null)
            {
                clearance = new brgyClearance();
                clearance.FormClosed += Clearance_FormClosed;
                clearance.MdiParent = this;
                clearance.Dock = DockStyle.Fill;
                clearance.Show();
            }
            else
            {
                clearance.Activate();

            }
        }

        private void Clearance_FormClosed(object sender, FormClosedEventArgs e)
        {
            clearance = null;
        }

        private void brgycetifcation_Click(object sender, EventArgs e)
        {
            if (certification == null)
            {
                certification = new brgyCertification();
                certification.FormClosed += Certification_FormClosed;
                certification.MdiParent = this;
                certification.Dock = DockStyle.Fill;
                certification.Show();
            }
            else
            {
                certification.Activate();

            }
        }

        private void Certification_FormClosed(object sender, FormClosedEventArgs e)
        {
            certification = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (housemap == null)
            {
                housemap = new housemapping();
                housemap.FormClosed += Housemap_FormClosed;
                housemap.MdiParent = this;
                housemap.Dock = DockStyle.Fill;
                housemap.Show();
            }
            else
            {
                housemap.Activate();

            }

        }

        private void Housemap_FormClosed(object sender, FormClosedEventArgs e)
        {
            housemap = null;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (blotterecs == null)
            {
                blotterecs = new blotterrecord();
                blotterecs.FormClosed += Blotterecs_FormClosed;
                blotterecs.MdiParent = this;
                blotterecs.Dock = DockStyle.Fill;
                blotterecs.Show();
            }
            else
            {
                blotterecs.Activate();

            }
        }

        private void Blotterecs_FormClosed(object sender, FormClosedEventArgs e)
        {
            blotterecs = null;
        }

        bool  blotterExpand = false;
        private void blotterTransition_Tick(object sender, EventArgs e)
        {
            if (blotterExpand == false)
            {
                blottercontainer.Height += 5;
                if (blottercontainer.Height >= 164)
                {
                    blotterTransition.Stop();
                    blotterExpand = true;
                }

            }
            else
            {
                blottercontainer.Height -= 5;
                if (blottercontainer.Height <= 55)
                {
                    blotterTransition.Stop();
                    blotterExpand = false;
                }
            }
        }

        private void btnbotter_Click(object sender, EventArgs e)
        {
            blotterTransition.Start();
        }
        bool reportExpand = false;
        private void reportTransition_Tick(object sender, EventArgs e)
        {
            if (reportExpand == false)
            {
               reportcontainer.Height += 5;
                if (reportcontainer.Height >= 284)
                {
                    reportTransition.Stop();
                    reportExpand = true;
                }

            }
            else
            {
                reportcontainer.Height -= 5;
                if (reportcontainer.Height <= 55)
                {
                    reportTransition.Stop();
                    reportExpand = false;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            reportTransition.Start();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (finance == null)
            {
                finance = new Financial();
                finance.FormClosed += Finance_FormClosed;
                finance.MdiParent = this;
                finance.Dock = DockStyle.Fill;
                finance.Show();
            }
            else
            {
                finance.Activate();

            }
        }

        private void Finance_FormClosed(object sender, FormClosedEventArgs e)
        {
            finance = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (househl == null)
            {
                househl = new household();
                househl.FormClosed += Househl_FormClosed;
                househl.MdiParent = this;
                househl.Dock = DockStyle.Fill;
                househl.Show();
            }
            else
            {
                househl.Activate();

            }
        }

        private void Househl_FormClosed(object sender, FormClosedEventArgs e)
        {
            househl = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (eventsched == null)
            {
                eventsched = new eventscheduling();
                eventsched.FormClosed += Eventsched_FormClosed;
                eventsched.MdiParent = this;
                eventsched.Dock = DockStyle.Fill;
                eventsched.Show();
            }
            else
            {
                eventsched.Activate();

            }
        }

        private void Eventsched_FormClosed(object sender, FormClosedEventArgs e)
        {
            eventsched = null;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (kpreps == null)
            {
                kpreps = new kpreport();
                kpreps.FormClosed += Kpreps_FormClosed;
                kpreps.MdiParent = this;
                kpreps.Dock = DockStyle.Fill;
                kpreps.Show();
            }
            else
            {
                kpreps.Activate();

            }
        }

        private void Kpreps_FormClosed(object sender, FormClosedEventArgs e)
        {
            kpreps = null;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (monthreps == null)
            {
                monthreps = new monthlyreport();
                monthreps.FormClosed += Monthreps_FormClosed;
                monthreps.MdiParent = this;
                monthreps.Dock = DockStyle.Fill;
                monthreps.Show();
            }
            else
            {
                monthreps.Activate();

            }
        }

        private void Monthreps_FormClosed(object sender, FormClosedEventArgs e)
        {
            monthreps = null;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (weekreps == null)
            {
                weekreps = new weeklyreport();
                weekreps.FormClosed += Weekreps_FormClosed;
                weekreps.MdiParent = this;
                weekreps.Dock = DockStyle.Fill;
                weekreps.Show();
            }
            else
            {
                weekreps.Activate();

            }
        }

        private void Weekreps_FormClosed(object sender, FormClosedEventArgs e)
        {
            weekreps = null;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (roadreps == null)
            {
                roadreps = new roadreport();
                roadreps.FormClosed += Roadreps_FormClosed;
                roadreps.MdiParent = this;
                roadreps.Dock = DockStyle.Fill;
                roadreps.Show();
            }
            else
            {
                roadreps.Activate();

            }
        }

        private void Roadreps_FormClosed(object sender, FormClosedEventArgs e)
        {
            roadreps = null;
        }

        private void btnkp_Click(object sender, EventArgs e)
        {
            if (kprecs == null)
            {
                kprecs = new kprecord();
                kprecs.FormClosed += Kprecs_FormClosed;
                kprecs.MdiParent = this;
                kprecs.Dock = DockStyle.Fill;
                kprecs.Show();
            }
            else
            {
                kprecs.Activate();

            }
        }

        private void Kprecs_FormClosed(object sender, FormClosedEventArgs e)
        {
            kprecs = null; 
        }

        private void button12_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
    }

