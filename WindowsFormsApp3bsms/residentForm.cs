using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3bsms
{
    public partial class residentForm : Form
    {
        public residentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
            form.Close();
        }

        private void residentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
       
        }
    }
}
