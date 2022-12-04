using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school
{
    public partial class addEvent : Form
    {
        public addEvent()
        {
            InitializeComponent();
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            workWithDB w = new workWithDB();
            if (w.addEvent(tb_name.Texts, dtp_date.Value, tb_time.Texts, tb_len.Texts, tb_place.Texts))
            {
                MessageBox.Show("Мероприятие добавлено!");
                this.Close();
            }
        }
    }
}
