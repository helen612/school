using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using school.Tables;


namespace school
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        
        private void enter_b_Click(object sender, EventArgs e)
        {
            workWithDB workWithDB = new workWithDB();
            LogIn somePerson = workWithDB.getLogIn(login_tb.Texts, password_tb.Texts);
            password_tb.Texts = "";
            if (somePerson.lvl == 0)
                ErrEnter.Visible = true;
            else
            {
                admin a = new admin(this,somePerson.lvl, somePerson.id);
                a.Show();
                this.Hide();
            }

        }

        private void login_tb__TextChanged(object sender, EventArgs e)
        {
            ErrEnter.Visible = false;
        }

        private void password_tb__TextChanged(object sender, EventArgs e)
        {
            ErrEnter.Visible = false;
        }

        private void showPsw_chb_CheckedChanged(object sender, EventArgs e)
        {
            if (showPsw_chb.Checked) password_tb.PasswordChar = false;
            else password_tb.PasswordChar = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            admin a = new admin(this, 8, 1);
            a.Show();
            this.Hide();
        }
    }
}

