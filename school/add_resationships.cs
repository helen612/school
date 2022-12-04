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
    public partial class add_resationships : Form
    {
        public add_resationships()
        {
            InitializeComponent();
        }
        public add_resationships(int idParent, int idStudier)
        {
            InitializeComponent();
            tb_id_child.Texts = idStudier == -1 ? "" : idStudier.ToString();
            tb_id_parrent.Texts = idParent == -1 ? "" : idParent.ToString();
        }

        private void set_relationships_b_Click(object sender, EventArgs e)
        {
            workWithDB w = new workWithDB();
            if (!w.addRelationships(tb_id_parrent.Texts, tb_id_child.Texts)) MessageBox.Show("Не удалось установить родственную связь!");
            else { MessageBox.Show("Родтсвенная связь установлена!"); }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            workWithDB w = new workWithDB();
            w.removeConnection(tb_id_parrent.Texts, tb_id_child.Texts);
        }

        private void tb_id_parrent__TextChanged(object sender, EventArgs e)
        {
            workWithDB workWithDB = new workWithDB();
            if (tb_id_parrent.Texts != "")
            {
                l_rs_p.Text = workWithDB.getFIOPerson(tb_id_parrent.Texts);
            }
        }

        private void tb_id_child__TextChanged(object sender, EventArgs e)
        {
            workWithDB workWithDB = new workWithDB();
            if (tb_id_child.Texts != "")
            {
                l_rs_s.Text = workWithDB.getFIOPerson(tb_id_child.Texts);
            }
        }
    }
}
