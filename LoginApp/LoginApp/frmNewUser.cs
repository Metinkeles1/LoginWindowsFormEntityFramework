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
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
        }
        loginRegisterEntities db = new loginRegisterEntities();     

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            csharp_user t = new csharp_user();
            t.username = txtUserName.Text;
            t.password = txtPassword.Text;
            db.csharp_user.Add(t);
            db.SaveChanges();
            MessageBox.Show("Add User");
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
    }
}
