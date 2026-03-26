using BussnisLayer_Clinic;
using Clinic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLayer_Clinic1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


       

        private void frmLogin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsBussnisLogin.LoginData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            
        }
    }
}
