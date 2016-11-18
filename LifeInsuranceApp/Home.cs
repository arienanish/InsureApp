using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeInsuranceApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Btn_Client_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Client Admin Button clicked");
        }
    }
}
