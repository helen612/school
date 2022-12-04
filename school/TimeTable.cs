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
    public partial class TimeTable : Form
    {
        private List<string> days;
        private List<string> rings;
        private List<string> classes;
        private List<string> ScObject;
        private List<string> Cabinet;
        public TimeTable(DataGridViewRow d)
        {
            InitializeComponent();
            workWithDB w = new workWithDB();
            days = w.getDays().Keys.ToList();
            rings = w.getRings().Keys.ToList();
            ScObject = w.getScObjects().Keys.ToList();
            Cabinet = w.getCabinets().Keys.ToList();
            classes = w.getClasses().Tables[0].AsEnumerable().Select(dataRow => dataRow.Field<string>("Название")).ToList();
            cb_day.DataSource = days;
            cb_ring.DataSource = rings;
            cb_class.DataSource = classes;
            cb_item.DataSource = ScObject;
            cb_cabinet.DataSource = Cabinet;
            tb_idTT.Enabled = true;
            tb_idTT.Texts = d.Cells["Код"].Value.ToString();
            
        }
        public TimeTable()
        {
            InitializeComponent();
            workWithDB w = new workWithDB();
            days = w.getDays().Keys.ToList();
            rings = w.getRings().Keys.ToList();
            ScObject = w.getScObjects().Keys.ToList();
            Cabinet = w.getCabinets().Keys.ToList();
            classes = w.getClasses().Tables[0].AsEnumerable().Select(dataRow => dataRow.Field<string>("Название")).ToList();
            cb_day.DataSource = days;
            cb_ring.DataSource = rings;
            cb_class.DataSource = classes;
            cb_item.DataSource = ScObject;
            cb_cabinet.DataSource = Cabinet;
            tb_idTT.Enabled = false;
        }

        private void b_add_or_change_Click(object sender, EventArgs e)
        {
            if (!tb_idTT.Enabled)
            {
                string idDay = (cb_day.SelectedIndex + 1).ToString();
                string idRing = (cb_ring.SelectedItem.ToString());
                string idClass = cb_class.SelectedIndex.ToString();
                string idScObj = (cb_item.SelectedIndex + 1).ToString();
                string cabinet = (cb_cabinet.SelectedIndex + 1).ToString();
                workWithDB w = new workWithDB();
                if (w.addTimeTable(idDay, idRing, idClass, idScObj, tb_idTeach.Texts, cabinet)) MessageBox.Show("Добавлено в расписание!");
            }
            else
            {
                string idDay = (cb_day.SelectedIndex + 1).ToString();
                string idRing = (cb_ring.SelectedItem.ToString());
                string idClass = cb_class.SelectedIndex.ToString();
                string idScObj = (cb_item.SelectedIndex + 1).ToString();
                string cabinet = (cb_cabinet.SelectedIndex + 1).ToString();
                workWithDB w = new workWithDB();
                if (w.updateTimeTable(tb_idTT.Texts,idDay, idRing, idClass, idScObj, tb_idTeach.Texts, cabinet)) MessageBox.Show("Расписание изменино!");
            }
        }
    }
}
