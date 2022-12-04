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
    public partial class AddMemberEvent : Form
    {
        public AddMemberEvent()
        {
            InitializeComponent();
        }

        private void tb_id_member__TextChanged(object sender, EventArgs e)
        {
            workWithDB workWithDB = new workWithDB();
            if (tb_id_member.Texts != "")
            {
                l_member.Text = workWithDB.getFIOPerson(tb_id_member.Texts);
            }
        }

        private void tb_id_event__TextChanged(object sender, EventArgs e)
        {
            workWithDB workWithDB = new workWithDB();
            if (tb_id_event.Texts != "")
            {
                l_event.Text = workWithDB.getNameEvent(tb_id_event.Texts);
            }
        }

        private void b_add_member_Click(object sender, EventArgs e)
        {
            workWithDB workWithDB = new workWithDB();
            if(workWithDB.addMemberEvent(Convert.ToInt32(tb_id_member.Texts), Convert.ToInt32(tb_id_event.Texts)))
            {
                MessageBox.Show($"Добавление участника пршло успешно");
            }
            tb_id_member.Texts = "";
            tb_id_event.Texts = "";
        }

        private void del_ev_member_Click(object sender, EventArgs e)
        {
            workWithDB workWithDB = new workWithDB();
            if(workWithDB.delMemberEvent(Convert.ToInt32(tb_id_member.Texts), Convert.ToInt32(tb_id_event.Texts))){
                MessageBox.Show($"Удаление участника пршло успешно");
            }
            tb_id_member.Texts = "";
            tb_id_event.Texts = "";

        }
    }
}
