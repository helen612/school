using school.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school
{
    public partial class addEmployer : Form
    {
        private Employer employer;
        List<string> classes;
        List<string> sexs;
        private int mode;
        public addEmployer()
        {
            InitializeComponent();
            sexs =new List<string>();
            sexs.Add("Мужской");
            sexs.Add("Женский");
            mode = 1;
            employer = new Employer();
            workWithDB w = new workWithDB();
            DataSet ds = new DataSet();
            ds = w.getClasses();
            classes = ds.Tables[0].AsEnumerable().Select(dataRow => dataRow.Field<string>("Название")).ToList();
            update();
        }

        #region buttons
        private void b_back_Click(object sender, EventArgs e)
        {
            if (mode == 5) this.Close();
            else if (mode > 1)
            {
                mode--;
                update();
                pb_data.Value -= 28;
            }

        }
        private void b_next_Click(object sender, EventArgs e)
        {
            bool next = false;
            int addedValue = 0;
            switch (mode)
            {
                case 1:
                    {
                        if (tb_1.BorderColor.Equals(Color.Green) && tb_2.BorderColor.Equals(Color.Green) &&
                            tb_3.BorderColor.Equals(Color.Green) && cb_1.BackColor.Equals(Color.Green))
                        {
                            next = true;
                            addedValue = 28;
                            employer.LastName = tb_1.Texts;
                            employer.Name = tb_2.Texts;
                            employer.FatherName = tb_3.Texts;
                            employer.Sex = cb_1.SelectedItem.ToString();
                        }
                        break;
                    }
                case 2:
                    {
                        if (tb_1.BorderColor.Equals(Color.Green) && tb_2.BorderColor.Equals(Color.Green) &&
                       tb_3.BorderColor.Equals(Color.Green) && tb_4.BorderColor.Equals(Color.Green))
                        {
                            next = true;
                            addedValue = 28;
                            try
                            {
                                employer.Birthday = DateTime.Parse(tb_1.Texts);

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Дата не может быть обработана! Подробнее: {ex.Message}", "Ошибка ввода даты");
                                next = false;
                                tb_1.BorderColor = Color.Red;
                                tb_1.ForeColor = Color.Red;
                            }

                            employer.Number = tb_2.Texts;
                            employer.Mail = tb_3.Texts;
                            employer.SecretWord = tb_4.Texts;
                        }
                        break;
                    }
                case 3:
                    {
                        if (tb_1.BorderColor.Equals(Color.Green)&&
                            ((togb_classruk.Checked && cb_1.BackColor == Color.Green)||(!togb_classruk.Checked)))
                        {
                            next = true;
                            addedValue = 28;
                            try
                            {
                                employer.dateOfEmpl = DateTime.Parse(tb_1.Texts);

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Дата не может быть обработана! Подробнее: {ex.Message}", "Ошибка ввода даты");
                                next = false;
                                tb_1.BorderColor = Color.Red;
                                tb_1.ForeColor = Color.Red;
                            }
                            employer.profs = togb_prof.Checked;
                            employer.idclass = togb_classruk.Checked ? cb_1.SelectedIndex : -1;
                        }
                        break;
                    }
                case 4:
                    {
                        if (tb_2.BorderColor.Equals(Color.Green) && tb_3.BorderColor.Equals(Color.Green))
                        {
                            next = true;
                            addedValue = 16;
                            employer.username = tb_2.Texts;
                            employer.password = tb_3.Texts;
                            employer.Position = "Сотрудник";

                        }
                        break;
                    }
                case 5:
                    {
                        PostControl pc = new PostControl(employer.id.ToString());
                        pc.ShowDialog();
                        this.Close();
                        return;
                    }
            }
            if (next)
            {
                mode++;

                pb_data.Value += addedValue;
                if (mode == 5)
                {
                    workWithDB w = new workWithDB();
                    employer.id = w.addEmployer(employer);
                }
                update();
            }
            else
            {
                MessageBox.Show("Поля заполнены некорректно!", "Регистрация");
            }

        }
        #endregion

        #region interface
        private void update()
        {
            switch (mode)
            {
                case 1:
                    {
                        l_final.Visible = false;
                        l_comment.Text = "Ввод персональных данных";
                        tb_1.Visible = true;
                        tb_1.PlaceholderText = "Фамилия";
                        tb_1.Texts = employer.LastName;

                        tb_1.BorderColor = Color.CornflowerBlue;

                        tb_2.Visible = true;
                        tb_2.PlaceholderText = "Имя";
                        tb_2.Texts = employer.Name;
                        tb_2.BorderColor = Color.CornflowerBlue;
                        l_prof.Visible = false;
                        togb_prof.Visible = false;

                        tb_3.Visible = true;
                        tb_3.PlaceholderText = "Отчество";
                        tb_3.Texts = employer.FatherName;
                        tb_3.BorderColor = Color.CornflowerBlue;
                        l_clasruk.Visible = false;
                        togb_classruk.Visible = false;

                        cb_1.Visible = true;
                        cb_1.Items.Clear();
                        cb_1.DataSource = sexs;
                        cb_1.BackColor = Color.CornflowerBlue;
                        tb_4.Visible = false;
                        break;
                    }
                case 2:
                    {
                        l_comment.Text = "Ввод дополнительных данных";
                        tb_1.Visible = true;
                        tb_1.Texts = "";
                        tb_1.PlaceholderText = "д.рождения (ДД-ММ-ГГГГ)";
                        tb_1.BorderColor = Color.CornflowerBlue;

                        tb_2.Visible = true;
                        tb_2.Texts = "";
                        tb_2.PlaceholderText = "+375(YY)XXX-XX-XX";
                        tb_2.BorderColor = Color.CornflowerBlue;
                        l_prof.Visible = false;
                        togb_prof.Visible = false;

                        tb_3.Visible = true;
                        tb_3.Texts = "";
                        tb_3.PlaceholderText = "E-mail";
                        tb_3.BorderColor = Color.Green;
                        l_clasruk.Visible = false;
                        togb_classruk.Visible = false;

                        tb_4.Visible = true;
                        tb_4.Texts = "";
                        tb_4.PlaceholderText = "Секретное слово";
                        tb_4.BorderColor = Color.CornflowerBlue;
                        cb_1.Visible = false;
                        break;
                    }
                case 3:
                    {
                        l_comment.Text = "Укажите подробные данные";

                        tb_1.Visible = true;
                        tb_1.PlaceholderText = "Дата трудоустройства";
                        tb_1.Texts = "";
                        tb_1.BorderColor = Color.Green;

                        tb_2.Visible = false;
                        l_prof.Visible = true;
                        togb_prof.Visible = true;
                        togb_prof.Checked = employer.profs;

                        tb_3.Visible = false;
                        l_clasruk.Visible = true;
                        togb_classruk.Visible = true;

                        tb_4.Visible = false;
                        cb_1.Visible = true;
                        cb_1.DataSource = classes;
                        cb_1.BackColor = Color.CornflowerBlue;
                        l_final.Visible = false;

                        break;
                    }
                case 4:
                    {
                        l_comment.Text = "Придумайте данные для входа";
                        tb_1.Visible = false;

                        l_prof.Visible = false;
                        togb_prof.Visible = false;
                        tb_2.Visible = true;
                        tb_2.PlaceholderText = "username";
                        tb_2.Texts = "";
                        tb_2.BorderColor = Color.CornflowerBlue;

                        l_clasruk.Visible = false;
                        togb_classruk.Visible = false;
                        tb_3.Visible = true;
                        tb_3.PlaceholderText = "password";
                        tb_3.Texts = "";
                        tb_3.BorderColor = Color.CornflowerBlue;

                        cb_1.Visible = false;
                        tb_4.Visible = false;
                        b_next.Enabled = true;
                        l_final.Visible = false;

                        break;
                    }
                case 5:
                    {
                        if (employer.id > 0)
                        {
                            l_comment.Visible = false;
                            tb_1.Visible = false;
                            tb_2.Visible = false;
                            l_prof.Visible = false;
                            togb_prof.Visible = false;
                            l_clasruk.Visible = false;
                            togb_classruk.Visible = false;
                            tb_3.Visible = false;
                            tb_4.Visible = false;
                            cb_1.Visible = false;



                            b_back.Text = "Закрыть";
                            b_next.Text = "Установить должность";
                            l_final.Visible = true;
                            l_final.Text = $"Вы только что завершили регистрацию сотрудника {employer.LastName} {employer.Name[0]}. {employer.FatherName[0]}. " +
                                $"На текущий момент ему установлена должность \"Сотрудник не относящийся к уч части\"." +
                                $"Если вы хотите изменить ему должность нажмимте на кнопку установка должностей. Если вы не хотиите менять должность " +
                                $"просто закройте форму";
                        }
                        else
                        {
                            l_comment.Visible = false;
                            tb_1.Visible = false;
                            tb_2.Visible = false;
                            l_prof.Visible = false;
                            togb_prof.Visible = false;
                            l_clasruk.Visible = false;
                            togb_classruk.Visible = false;
                            tb_3.Visible = false;
                            tb_4.Visible = false;
                            cb_1.Visible = false;
                            b_next.Enabled = false;
                            l_final.Visible = true;
                            l_final.Text = $"Нам неудалось зарегестрировать {employer.LastName} {employer.Name[0]}. {employer.FatherName[0]}. " +
                                $"Попробуйте снова или попросите помощи у инженера-программиста учреждения!";
                            mode--;
                        }
                        break;
                    }
            }
        }

        private void cb_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_1.BackColor = Color.Green;
        }

        private void tb_1__TextChanged(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 1:
                    {
                        var r = Regex.Match(tb_1.Texts, @"^[А-Я]{1}[а-я]{1,}$|^[А-Я]{1}[а-я]{1,} - [А-я]{2,}$");
                        if (r.Success)
                        {
                            tb_1.BorderColor = Color.Green;
                            tb_1.ForeColor = Color.Green;
                        }
                        else
                        {
                            tb_1.BorderColor = Color.Red;
                            tb_1.ForeColor = Color.Red;
                        }
                        break;
                    }
                //Дата рождения
                case 2:
                    {
                        var r = Regex.Match(tb_1.Texts, @"^((0[1-9])|([1-2][0-9])|(3[0-1]))-((0[1-9])|(1[0-2]))-((19[4-9][0-9])|(20[0-2][0-2]))$");
                        if (r.Success)
                        {
                            tb_1.BorderColor = Color.Green;
                            tb_1.ForeColor = Color.Green;
                        }
                        else
                        {
                            tb_1.BorderColor = Color.Red;
                            tb_1.ForeColor = Color.Red;
                        }
                        break;
                    }
                case 3:
                    {
                        var r = Regex.Match(tb_1.Texts, @"^((0[1-9])|([1-2][0-9])|(3[0-1]))-((0[1-9])|(1[0-2]))-((19[4-9][0-9])|(20[0-2][0-2]))$");
                        if (r.Success)
                        {
                            tb_1.BorderColor = Color.Green;
                            tb_1.ForeColor = Color.Green;
                        }
                        else
                        {
                            tb_1.BorderColor = Color.Red;
                            tb_1.ForeColor = Color.Red;
                        }
                        break;
                    }
            }
        }

        private void tb_2__TextChanged(object sender, EventArgs e)
        {
            switch (mode)
            {
                //имя
                case 1:
                    {
                        var r = Regex.Match(tb_2.Texts, @"^[А-Я]{1}[а-я]{1,}$");
                        if (r.Success)
                        {
                            tb_2.BorderColor = Color.Green;
                            tb_2.ForeColor = Color.Green;
                        }
                        else
                        {
                            tb_2.BorderColor = Color.Red;
                            tb_2.ForeColor = Color.Red;
                        }
                        break;
                    }
                //номер телефона
                case 2:
                    {
                        var r = Regex.Match(tb_2.Texts, @"^\+375\([0-9]{2}\)[0-9]{3}-[0-9]{2}-[0-9]{2}$");
                        if (r.Success)
                        {
                            tb_2.BorderColor = Color.Green;
                            tb_2.ForeColor = Color.Green;
                        }
                        else
                        {
                            tb_2.BorderColor = Color.Red;
                            tb_2.ForeColor = Color.Red;
                        }
                        break;
                    }
                case 4:
                    {
                        var r = Regex.Match(tb_2.Texts, @"^[A-z0-9]{3,}$");
                        if (r.Success)
                        {
                            tb_2.BorderColor = Color.Green;
                            tb_2.ForeColor = Color.Green;
                        }
                        else
                        {
                            tb_2.BorderColor = Color.Red;
                            tb_2.ForeColor = Color.Red;
                        }
                        break;
                    }
            }
        }

        private void tb_3__TextChanged(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 1:
                    {
                        var r = Regex.Match(tb_3.Texts, @"^[А-Я]{1}[а-я]{2,}$|^$");
                        if (r.Success)
                        {
                            tb_3.BorderColor = Color.Green;
                            tb_3.ForeColor = Color.Green;
                        }
                        else
                        {
                            tb_3.BorderColor = Color.Red;
                            tb_3.ForeColor = Color.Red;
                        }
                        break;
                    }
                case 2:
                    {
                        var r = Regex.Match(tb_3.Texts, @"^((?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$)|^$");
                        if (r.Success)
                        {
                            tb_3.BorderColor = Color.Green;
                            tb_3.ForeColor = Color.Green;
                        }
                        else
                        {
                            tb_3.BorderColor = Color.Red;
                            tb_3.ForeColor = Color.Red;
                        }
                        break;
                    }
                case 4:
                    {
                        var r = Regex.Match(tb_3.Texts, @"^[A-z0-9]{8,}$");
                        if (r.Success)
                        {
                            tb_3.BorderColor = Color.Green;
                            tb_3.ForeColor = Color.Green;
                        }
                        else
                        {
                            tb_3.BorderColor = Color.Red;
                            tb_3.ForeColor = Color.Red;
                        }
                        break;
                    }
            }

        }

        private void tb_4__TextChanged(object sender, EventArgs e)
        {
            var r = Regex.Match(tb_4.Texts, @"^[А-я]{3,}$");
            if (r.Success)
            {
                tb_4.BorderColor = Color.Green;
                tb_4.ForeColor = Color.Green;
            }
            else
            {
                tb_4.BorderColor = Color.Red;
                tb_4.ForeColor = Color.Red;
            }
        }
        #endregion

        private void togb_classruk_CheckedChanged(object sender, EventArgs e)
        {
            if (togb_classruk.Checked) cb_1.Enabled = true;
            else cb_1.Enabled = false;
        }
    }
}
