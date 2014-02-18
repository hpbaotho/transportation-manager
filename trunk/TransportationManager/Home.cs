using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TransportationManager
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            Form LoginForm = new LoginForm();
            LoginForm.Close();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
