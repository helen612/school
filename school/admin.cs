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
        int idOfPerson = 0;
        Form1 aunt;
        //private List<List<int>> Levels;
        private bool getTrueTime(string str)
        {
            var regex = Regex.Match(rjTextBox1.Texts, @"\A(?:[01][0-9]|2[0-3]):[0-5][0-9]\z");
            return regex.Success;
        }
        private List<DataGridViewRow> getSelectedRows(object sender)
        {
            List<DataGridViewRow> result = new List<DataGridViewRow>();
            try
            {
                DataGridView dgv = sender as DataGridView;
                Int32 selectedRowCount = dgv.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        result.Add(dgv.Rows[dgv.SelectedRows[i].Index]);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Не могу понять какие строки выбраны!\nПодробнее: " + ex.Message, "Удаление");
                result = new List<DataGridViewRow>();
            }
            return result;
        }
        private List<int> getSelectedId(object sender, string nameColumn)
        {
            List<int> sb = new List<int>();
            
            try
            {
                DataGridView dgv = sender as DataGridView;
                Int32 selectedRowCount = dgv.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        sb.Add(Convert.ToInt32(dgv.Rows[dgv.SelectedRows[i].Index].Cells[nameColumn].Value.ToString()));
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Не могу понять какие строки выбраны!\nПодробнее: " + ex.Message, "Удаление");
                sb = new List<int>();
            }
            return sb;
        }
        public admin(Form1 form1, int level, int id)
        {
            InitializeComponent();
            
            aunt = form1;
            idOfPerson = id;
            //_tab.SelectedTab = Journal;
            Access(level, id);
            fillThePeoples(null, null);
            tt_filter_b_Click(null, null);
            journal_b_go_Click(null, null);
            eml_filttr_b_Click(null, null);
            parent_b_go_Click(null, null);
        }

        #region учащийся
        private void students_edit_b_Click(object sender, EventArgs e)
        {
            foreach (var v in getSelectedRows(students_dgv))
            {
                try
                {
                    workWithDB w = new workWithDB();
                    People p = new People();
                    p.id = Convert.ToInt32(v.Cells["id"].Value.ToString());
                    p.nameClass = v.Cells["Класс"].Value.ToString();
                    p.LastName = v.Cells["Фамилия"].Value.ToString();
                    p.Name = v.Cells["Имя"].Value.ToString();
                    p.FatherName = v.Cells["Отчество"].Value.ToString();
                    p.address = v.Cells["Адрес"].Value.ToString();
                    p.starosta = Convert.ToBoolean(v.Cells["Староста"].Value.ToString());
                    p.SOP = Convert.ToBoolean(v.Cells["СОП"].Value.ToString());
                    if (w.editStudent(p)) MessageBox.Show($"Учащийся {p.id} изменен!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                fillThePeoples(null, null);
            }
        }
        private void student_add_b_Click(object sender, EventArgs e)
        {
            addStudent add_s = new addStudent();
            add_s.ShowDialog();
        }
        private void fillThePeoples(object sender, EventArgs e)
        {
            workWithDB workWithDB = new workWithDB();
            DataSet peoples = workWithDB.GetPeoples(students_id_tb.Texts, student_classs_tb.Texts, student_fio_tb.Texts,
                GetStateOfBoolFilter(students_starosta_chb, rjToggleButton2), GetStateOfBoolFilter(students_SOP_chb, rjToggleButton1));
            if (peoples != null)
            {
                students_dgv.DataSource = peoples.Tables[0];
                students_dgv.Columns[0].ReadOnly = true;
            }
        }
        private void students_starosta_chb_CheckedChanged(object sender, EventArgs e)
        {
            if (students_starosta_chb.Checked) rjToggleButton2.Enabled = true;
            else rjToggleButton2.Enabled = false;
        }

        private void students_SOP_chb_CheckedChanged(object sender, EventArgs e)
        {
            if (students_SOP_chb.Checked) rjToggleButton1.Enabled = true;
            else rjToggleButton1.Enabled = false;
        }
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
        #endregion


        #region admin tools
        private void choose_table_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            workWithDB workWithDB = new workWithDB();
            DataSet ds = workWithDB.getTable($"[{choose_table_cb.SelectedItem.ToString()}]");

            if (ds != null)
            {
                admin_dgv.DataSource = ds.Tables[0];
                admin_dgv.Columns[0].ReadOnly = true;
            }

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

        #region delete buttons
        private void purrents_delete_b_Click(object sender, EventArgs e)
        {
            foreach (var v in getSelectedId(Parrent_dgv, Parrent_dgv.Columns[0].HeaderText))
            {
                workWithDB w = new workWithDB();
                w.removeSomethink(v, "LogIn", "Id");
            }
            parent_b_go_Click(null, null);
        }
        private void students_del_b_Click(object sender, EventArgs e)
        {
            foreach (var v in getSelectedId(students_dgv, "id"))
            {
                workWithDB w = new workWithDB();
                w.removeUser(v);
            }
            fillThePeoples(null, null);
        }
        private void employers_del_b_Click(object sender, EventArgs e)
        {
            foreach (var v in getSelectedId(emplyers_dgv, "id"))
            {
                workWithDB w = new workWithDB();
                w.removeUser(v);
            }
            eml_filttr_b_Click(null, null);
        }
        private void tt_del_b_Click(object sender, EventArgs e)
        {
            foreach (var v in getSelectedId(tt_dgv, "Код"))
            {
                workWithDB w = new workWithDB();
                w.removeUser(v);
            }
            tt_filter_b_Click(null, null);
        }
        private void j_del_b_Click(object sender, EventArgs e)
        {
            foreach (var v in getSelectedId(J_DGV, "Код"))
            {
                workWithDB w = new workWithDB();
                w.removeUser(v);
            }
            journal_b_go_Click(null, null);
        }
        private void admin_del_b_Click(object sender, EventArgs e)
        {

            foreach (var v in getSelectedId(admin_dgv, admin_dgv.Columns[0].HeaderText))
            {
                workWithDB w = new workWithDB();
                w.removeSomethink(v, choose_table_cb.SelectedValue.ToString(), admin_dgv.Columns[0].HeaderText);
            }
            choose_table_cb_SelectedIndexChanged(null, null);
        }
        #endregion

        #region Родители
        private void parrents_add_b_Click(object sender, EventArgs e)
        {
            AddParent ap = new AddParent();
            ap.ShowDialog();
        }
        private void enter_rel_b_Click(object sender, EventArgs e)
        {
            add_resationships ar = new add_resationships();
            ar.ShowDialog();
        }

        private void parent_b_go_Click(object sender, EventArgs e)
        {
            workWithDB workWithDB = new workWithDB();
            DataSet parents = workWithDB.getParents(parrent_tb_id.Texts, parrent_tb_job.Texts, parrent_tb_class.Texts,
                parrent_tb_children.Texts, people_tb_children.Texts);
            if (parents != null)
                Parrent_dgv.DataSource = parents.Tables[0];
        }
        private void parent_b_pwoc_Click(object sender, EventArgs e)
        {
            workWithDB w = new workWithDB();
            DataSet parents = w.getParentsWitoutConnection();
            if (parents != null)
                Parrent_dgv.DataSource = parents.Tables[0];
        }

        private void large_famile_b_Click(object sender, EventArgs e)
        {
            workWithDB w = new workWithDB();
            DataSet parents = w.getLargeFamily();
            if (parents != null)
                Parrent_dgv.DataSource = parents.Tables[0];
        }
        private void parrents_edit_b_Click(object sender, EventArgs e)
        {
            foreach (var v in getSelectedRows(Parrent_dgv))
            {
                try
                {
                    Parents p = new Parents();
                    p.id = Convert.ToInt32(v.Cells["id родителя"].Value.ToString());
                    p.LastName = v.Cells["Фамилия"].Value.ToString();
                    p.Name = v.Cells["Имя"].Value.ToString();
                    p.FatherName = v.Cells["Отчество"].Value.ToString();
                    p.work = v.Cells["Место работы"].Value.ToString();
                    p.Number = v.Cells["Телефон"].Value.ToString();
                    p.Mail = v.Cells["Почта"].Value.ToString();
                    workWithDB w = new workWithDB();
                    
                    if (w.editParent(p)) MessageBox.Show($"Родитель {p.id} изменен!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                fillThePeoples(null, null);
            }
        }

        #endregion

        private void filtr_tab_Click(object sender, EventArgs e)
        {
            
        }

        private void rjTextBox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void journal_b_go_Click(object sender, EventArgs e)
        {
            workWithDB workWithDB = new workWithDB();
            
            List<People> children = new List<People>();
            children = workWithDB.getClassForParrent(idOfPerson);
            if(children.Count >= 1)
            {
                List<DataTable> tables = new List<DataTable>();
                DataTable result = new DataTable();
                foreach (var v in children)
                {
                    DataSet Journal = workWithDB.getJournal(j_id_tb.Texts, v.nameClass, j_sub_tb.Texts,
                    j_people_tb.Texts, j_teacher_tb.Texts, dateFrom.Value, dateTo.Value,
                    j_mark_from_tb.Texts, j_mark_to_tb.Texts, idOfPerson.ToString());
                    tables.Add(Journal.Tables[0]);
                }
                foreach (var v in tables)
                {
                    result.Merge(v);
                }
                J_DGV.DataSource = result;
            }
            else
            {
                J_DGV.DataSource = workWithDB.getJournal(j_id_tb.Texts, j_class_f_tb.Texts, j_sub_tb.Texts,
                    j_people_tb.Texts, j_teacher_tb.Texts, dateFrom.Value, dateTo.Value,
                    j_mark_from_tb.Texts, j_mark_to_tb.Texts, idOfPerson.ToString()).Tables[0];
            }
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

        

        private void more_one_stavka_b_Click(object sender, EventArgs e)
        {
            workWithDB workWithDB = new workWithDB();
            DataSet ds = workWithDB.GetMonfeeders();
            if (ds != null) emplyers_dgv.DataSource = ds.Tables[0];
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
                        j_people_tb.Texts = workWithDB.getStudent(id);
                        j_class_f_tb.Enabled = false;
                        j_people_tb.Enabled = false;
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
                choose_table_cb.DataSource = workWithDB.getListTables();
            }
        }

        


        private void tt_filter_b_Click(object sender, EventArgs e)
        {
            workWithDB workWithDB = new workWithDB();
            DataSet timeTable = workWithDB.getTimeTable(tt_id_tb.Texts, tt_class_tb.Texts, tt_kab_tb.Texts,
                tt_day_tb.Texts, tt_bring_tb.Texts, tt_bring_do_tb.Texts, tt_sub_tb.Texts, tt_teacher_tb.Texts);
            if (timeTable != null)
                tt_dgv.DataSource = timeTable.Tables[0];
        }
        private void j_from_chb_CheckedChanged(object sender, EventArgs e)
        {
            if (!j_from_chb.Checked)
            {
                dateFrom.Value = new DateTime(1753, 1, 1);
                dateFrom.Enabled = false;
            }
            else
            {
                dateFrom.Value = new DateTime(DateTime.Now.Year - 3, DateTime.Now.Month, DateTime.Now.Day);
                dateFrom.Enabled = true;
            }
        }
        private void j_to_chb_CheckedChanged(object sender, EventArgs e)
        {
            if (!j_to_chb.Checked) dateTo.Value = DateTime.Now;
        }

        private void eml_filttr_b_Click(object sender, EventArgs e)
        {
            workWithDB workWithDB = new workWithDB();
            DataSet employer = workWithDB.getEmployers(empl_tb.Texts, FIO_tb.Texts, position_tb.Texts, dataEmplyer.Value
                , GetStateOfBoolFilter(prof_filtr_chb, stateOfProfM_cb));
            if (employer != null)
                emplyers_dgv.DataSource = employer.Tables[0];
        }

        private void empl_date_filter_CheckedChanged(object sender, EventArgs e)
        {
            if (!empl_date_filter.Checked) dataEmplyer.Value = new DateTime(1753, 1, 1);
            else dataEmplyer.Value = new DateTime(DateTime.Now.Year - 3, DateTime.Now.Month, DateTime.Now.Day);
        }
        private void much_ex_b_Click(object sender, EventArgs e)
        {
            workWithDB workWithDB = new workWithDB();
            DataSet BigExpP = workWithDB.GetExpEmpl();
            if (BigExpP != null) emplyers_dgv.DataSource = BigExpP.Tables[0];
        }

        private void ClassRuk_b_Click(object sender, EventArgs e)
        {
            workWithDB workWithDB = new workWithDB();
            DataSet ds = workWithDB.getCLassRuk();
            if (ds != null) emplyers_dgv.DataSource = ds.Tables[0];
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            PostControl pc = new PostControl();
            pc.ShowDialog();
        }

        private void employers_add_b_Click(object sender, EventArgs e)
        {
            addEmployer ae = new addEmployer();
            ae.ShowDialog();
        }
    }
}
