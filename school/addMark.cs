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
    public partial class addMark : Form
    {
        private int idTeacher;
        public addMark(int idTeacher)
        {
            InitializeComponent();
            workWithDB workWithDB = new workWithDB();
            cb_scObj.DataSource = workWithDB.getScObjects().Keys.ToList<string>();
            this.idTeacher = idTeacher;
        }

        private void b_addMark_Click(object sender, EventArgs e)
        {
            string r = "";
            
            workWithDB w = new workWithDB();
            w.getScObjects().TryGetValue(cb_scObj.SelectedItem.ToString(), out r);
            if (w.addMark(tb_idStudier.Texts, r, tb_newMark.Texts, idTeacher.ToString())) MessageBox.Show("Оценка выставлена!");
        }
    }
}
