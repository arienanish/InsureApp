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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TB_Username.Text))
            {
                MessageBox.Show("Please enter Username","Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                TB_Username.Focus();
                return;
            }
            try
            {
                using(InsureAppDBEntities ent = new InsureAppDBEntities())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }

        private void TB_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                TB_Password.Focus();
        }

        private void TB_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                Btn_Login.PerformClick();
        }
    }
}
