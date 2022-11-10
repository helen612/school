using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school
{
    public partial class admin : Form
    {
        private bool getTrueTime(string str)
        {
            var regex = Regex.Match(rjTextBox1.Texts, @"\A(?:[01][0-9]|2[0-3]):[0-5][0-9]\z");
            return regex.Success;
        }
        public admin()
        {
            InitializeComponent();
        }

        private void filtr_tab_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
            
            if (getTrueTime(rjTextBox1.Texts))
            {
                rjTextBox1.ForeColor = Color.Red;
            }
            else
                rjTextBox1.ForeColor = Color.Green;
        }

        private void admin_del_b_Click(object sender, EventArgs e)
        {

        }

        private void more_one_stavka_b_Click(object sender, EventArgs e)
        {
            
        }
    }
}
