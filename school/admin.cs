using CustomControls.RJControls;
using school.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        Form1 aunt;
        //private List<List<int>> Levels;
        private bool getTrueTime(string str)
        {
            var regex = Regex.Match(rjTextBox1.Texts, @"\A(?:[01][0-9]|2[0-3]):[0-5][0-9]\z");
            return regex.Success;
        }
        public admin(Form1 form1, int level, int id)
        {
            InitializeComponent();
            aunt = form1;
            //_tab.SelectedTab = Journal;
            Access(level, id);
            fillThePeoples(null, null);
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

        private void admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            aunt.Show();
        }
        private void Access(int lvl, int id)
        {
            workWithDB workWithDB = new workWithDB();
            switch (lvl)
            {
                case 1:
                    {
                       
                        _tab.TabPages.Remove(students);
                        _tab.TabPages.Remove(parrents);
                        _tab.TabPages.Remove(employers);
                        _tab.TabPages.Remove(Events);
                        _tab.TabPages.Remove(admin_tab);
                        j_class_f_tb.Texts = workWithDB.getClassOfStudent(id);
                        j_class_f_tb.Enabled = false;
                        j_gb.Enabled = false;
                        tt_gb.Enabled = false;
                        break;
                    }
                case 2:
                    {
                        _tab.TabPages.Remove(students);
                        _tab.TabPages.Remove(parrents);
                        _tab.TabPages.Remove(Events);
                        _tab.TabPages.Remove(admin_tab);
                        j_gb.Enabled = false;
                        tt_gb.Enabled = false;
                        e_gp.Enabled = false;
                        List<string> classes = new List<string>();
                        classes = workWithDB.getClassForParrent(id);
                        foreach (var v in classes)
                        {
                            j_class_f_tb.Texts = string.Join(" ", classes.ToArray());
                        }
                        j_class_f_tb.Enabled = false;
                        break;
                    }
                case 3:
                    {
                        _tab.TabPages.Remove(admin_tab);
                        s_gb.Enabled = false;
                        p_gp.Enabled = false;
                        e_gp.Enabled = false;
                        j_gb.Enabled = false;
                        tt_gb.Enabled = false;
                        ev_gp.Enabled = false;
                        enter_rel_b.Enabled = false;
                        break;
                    }
                case 4:
                    {
                        _tab.TabPages.Remove(admin_tab);
                        s_gb.Enabled = false;
                        p_gp.Enabled = false;
                        e_gp.Enabled = false;
                        j_gb.Enabled = false;
                        ev_gp.Enabled = false;
                        enter_rel_b.Enabled = false;
                        break;
                    }
                case 5:
                    {
                        _tab.TabPages.Remove(admin_tab);
                        s_gb.Enabled = false;
                        p_gp.Enabled = false;
                        e_gp.Enabled = false;
                        j_gb.Enabled = false;
                        tt_gb.Enabled = false;
                        enter_rel_b.Enabled = false;
                        break;
                    }
                case 6:
                    {
                        _tab.TabPages.Remove(admin_tab);
                        s_gb.Enabled = false;
                        p_gp.Enabled = false;
                        e_gp.Enabled = false;
                        break;
                    }
                case 7:
                    {
                        _tab.TabPages.Remove(admin_tab);
                        break;
                    }
            }
            }
        private void fillThePeoples(object sender, EventArgs e)
        {
            workWithDB workWithDB = new workWithDB();
            DataSet peoples = workWithDB.GetPeoples(students_id_tb.Texts, student_classs_tb.Texts, student_fio_tb.Texts, 
                GetStateOfBoolFilter(students_starosta_chb, rjToggleButton2), GetStateOfBoolFilter(students_SOP_chb, rjToggleButton1));
            if(peoples != null)
                students_dgv.DataSource = peoples.Tables[0];
        }
        private int GetStateOfBoolFilter(CheckBox On, RJToggleButton state)
        {
            if (On.Checked == false) return 2;
            else
            {
                if (state.Checked == false) return 0;
                else return 1;
            }
        }
        private void _tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_tab.SelectedTab.Equals(admin_tab))
            {
                workWithDB workWithDB = new workWithDB();
                choose_table_cb.Items.Clear();
                choose_table_cb.DataSource = workWithDB.getListTables();
            }
        }
        
        #region admin tools
        private void choose_table_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            workWithDB workWithDB = new workWithDB();
            DataSet ds = workWithDB.getTable($"[{choose_table_cb.SelectedItem.ToString()}]");

            if (ds != null)
                admin_dgv.DataSource = ds.Tables[0];
            else
                MessageBox.Show("Такой таблицы нет!");
        }

        private void B_runSqlReauest_Click(object sender, EventArgs e)
        {
            admin_dgv.DataSource = null;
            workWithDB workWithDB = new workWithDB();
            DataSet ds = workWithDB.getSQLReauest(tb_SQLrequest.Texts);
            if (ds != null)
                admin_dgv.DataSource = ds.Tables[0];
            else
                MessageBox.Show("Ваш запрос невозможно выполнить!");

        }
        #endregion
        private void activists_b_Click(object sender, EventArgs e)
        {
            workWithDB workWithDB = new workWithDB();
            DataSet activ = workWithDB.getActivist();
            if (activ != null)
                students_dgv.DataSource = activ.Tables[0];
        }
        private void best_students_b_Click(object sender, EventArgs e)
        {
            workWithDB workWithDB = new workWithDB();
            DataSet bestPeoples = workWithDB.getBestPeoples();
            if (bestPeoples != null)
                students_dgv.DataSource = bestPeoples.Tables[0];
        }
        private void bed_marks_p_b_Click(object sender, EventArgs e)
        {
            workWithDB workWithDB = new workWithDB();
            DataSet laggingPeoples = workWithDB.getLaggingPeoples(rjDatePicker1.Value, rjDatePicker2.Value);
            if (laggingPeoples != null)
                students_dgv.DataSource = laggingPeoples.Tables[0];
        }
        private void student_add_b_Click(object sender, EventArgs e)
        {

        }

        private void tt_filter_b_Click(object sender, EventArgs e)
        {
            workWithDB workWithDB = new workWithDB();
            DataSet timeTable = workWithDB.getTimeTable(tt_id_tb.Texts, tt_class_tb.Texts, tt_kab_tb.Texts,
                tt_day_tb.Texts, tt_bring_tb.Texts, tt_bring_do_tb.Texts, tt_sub_tb.Texts, tt_teacher_tb.Texts);
            if (timeTable != null)
                tt_dgv.DataSource = timeTable.Tables[0];
        }
    }
}
