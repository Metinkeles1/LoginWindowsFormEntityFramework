using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            loginRegisterEntities db = new loginRegisterEntities();
            var query = from x in db.csharp_user where x.username == txtUserName.Text && x.password == txtPassword.Text select x;
            if (query.Any())
            {
                frmAboutUser frm = new frmAboutUser();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
      

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            frmNewUser frm = new frmNewUser();
            frm.Show();
            this.Hide();
        }
       
    }
}
