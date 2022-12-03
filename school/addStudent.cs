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
    public partial class addStudent : Form
    {
        private RegStudier newStudier;
        List<string> classes;
        private int mode;
        public addStudent()
        {
            InitializeComponent();
            mode = 1;
            newStudier = new RegStudier();
            update();
           
            workWithDB w = new workWithDB();
            DataSet ds = new DataSet();
            ds = w.getClasses();
            classes = ds.Tables[0].AsEnumerable().Select(dataRow=>dataRow.Field<string>("Название")).ToList();
        }

        #region buttons
        private void b_back_Click(object sender, EventArgs e)
        {
            if (mode == 5) this.Close();
            else if(mode > 1)
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
                        newStudier.LastName = tb_1.Texts;
                        newStudier.Name = tb_2.Texts;
                        newStudier.FatherName = tb_3.Texts;
                        newStudier.Sex = cb_1.SelectedItem.ToString();
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
                                newStudier.Birthday = DateTime.Parse(tb_1.Texts);

                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show($"Дата не может быть обработана! Подробнее: {ex.Message}", "Ошибка ввода даты");
                                next = false;
                                tb_1.BorderColor = Color.Red;
                                tb_1.ForeColor = Color.Red;
                            }
                            
                            newStudier.Number = tb_2.Texts;
                            newStudier.Mail = tb_3.Texts;
                            newStudier.SecretWord = tb_4.Texts;
                        }
                        break;
                    }
                case 3:
                    {
                        if (tb_1.BorderColor.Equals(Color.Green) && cb_1.BackColor.Equals(Color.Green))
                        {
                            next = true;
                            addedValue = 28;
                            newStudier.adress = tb_1.Texts;
                            newStudier.starosta = togb_starosta.Checked;
                            newStudier.SOP = togb_SOP.Checked;
                            newStudier.idclass = cb_1.SelectedIndex;
                        }
                        break;
                    }
                case 4:
                    {
                        if (tb_2.BorderColor.Equals(Color.Green) && tb_3.BorderColor.Equals(Color.Green) )
                        {
                            next = true;
                            addedValue = 16;
                            newStudier.username = tb_2.Texts;
                            newStudier.password = tb_3.Texts;
                            newStudier.Position = "Учащийся";

                        }
                        break;
                    }
                case 5:
                    {
                        add_resationships ar = new add_resationships(-1,newStudier.id);
                        ar.ShowDialog();
                        this.Close();
                        return;
                    }
            }
            if (next)
            {
                mode++;
                
                pb_data.Value += addedValue;
                if(mode == 5)
                {
                    workWithDB w = new workWithDB();
                    newStudier.id = w.addStudier(newStudier);
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
                        tb_1.Texts = newStudier.LastName;
                       
                        tb_1.BorderColor = Color.CornflowerBlue;

                        tb_2.Visible = true;
                        tb_2.PlaceholderText = "Имя";
                        tb_2.Texts = newStudier.Name;
                        tb_2.BorderColor = Color.CornflowerBlue;
                        l_starosta.Visible = false;
                        togb_starosta.Visible = false;

                        tb_3.Visible = true;
                        tb_3.PlaceholderText = "Отчество";
                        tb_3.Texts = newStudier.FatherName;
                        tb_3.BorderColor = Color.CornflowerBlue;
                        l_SOP.Visible = false;
                        togb_SOP.Visible = false;

                        cb_1.Visible = true;
                        cb_1.Items.Clear();
                        cb_1.Items.Add("Мужской");
                        cb_1.Items.Add("Женский");
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
                        l_starosta.Visible = false;
                        togb_starosta.Visible = false;

                        tb_3.Visible = true;
                        tb_3.Texts = "";
                        tb_3.PlaceholderText = "E-mail";
                        tb_3.BorderColor = Color.Green;
                        l_SOP.Visible = false;
                        togb_SOP.Visible = false;

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
                        tb_1.PlaceholderText = "Адрес";
                        tb_1.Texts = newStudier.adress;
                        tb_1.BorderColor = Color.Green;

                        tb_2.Visible = false;
                        l_starosta.Visible = true;
                        togb_starosta.Visible = true;
                        togb_starosta.Checked = newStudier.starosta;

                        tb_3.Visible = false;
                        l_SOP.Visible = true;
                        togb_SOP.Visible = true;
                        togb_SOP.Checked = newStudier.SOP;

                        tb_4.Visible = false;
                        cb_1.Visible = true;
                        cb_1.Items.Clear();
                        cb_1.DataSource = classes;
                        cb_1.BackColor = Color.CornflowerBlue;

                        break; 
                    }
                case 4:
                    {
                        l_comment.Text = "Придумайте данные для входа";
                        tb_1.Visible = false;

                        l_starosta.Visible = false;
                        togb_starosta.Visible = false;
                        tb_2.Visible = true;
                        tb_2.PlaceholderText = "username";
                        tb_2.Texts = "";
                        tb_2.BorderColor = Color.CornflowerBlue;

                        l_SOP.Visible = false;
                        togb_SOP.Visible = false;
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
                        if (newStudier.id > 0)
                        {
                            l_comment.Visible = false;
                            tb_1.Visible = false;
                            tb_2.Visible = false;
                            l_starosta.Visible = false;
                            togb_starosta.Visible = false;
                            l_SOP.Visible = false;
                            togb_SOP.Visible = false;
                            tb_3.Visible = false;
                            tb_4.Visible = false;
                            cb_1.Visible = false;



                            b_back.Text = "Закрыть";
                            b_next.Text = "Связать";
                            l_final.Visible = true;
                            l_final.Text = $"Вы только что завершили регистрацию учащегося {newStudier.LastName} {newStudier.Name[0]}. {newStudier.FatherName[0]}. " +
                                $"и занесли его в список установленного класса. Теперь необходимо создать аккаунт его родителю, а затем установить " +
                                $"им родственные связи. Если вы можете уже это сделать то нажмите на кнопку связать. Если вы не можете пока что " +
                                $"установить родственную связь просто закройте форму";
                        }
                        else
                        {
                            l_comment.Visible = false;
                            tb_1.Visible = false;
                            tb_2.Visible = false;
                            l_starosta.Visible = false;
                            togb_starosta.Visible = false;
                            l_SOP.Visible = false;
                            togb_SOP.Visible = false;
                            tb_3.Visible = false;
                            tb_4.Visible = false;
                            cb_1.Visible = false;
                            b_next.Enabled = false;
                            l_final.Visible = true;
                            l_final.Text = $"Нам неудалось зарегестрировать {newStudier.LastName} {newStudier.Name[0]}. {newStudier.FatherName[0]}. " +
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
                        var r = Regex.Match(tb_1.Texts, @"^((0[1-9])|([1-2][0-9])|(3[0-1]))-((0[1-9])|(1[0-2]))-((19[4-9][1-9])|(20[0-2][0-2]))$");
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
                        var r = Regex.Match(tb_1.Texts, @"^$|^\S{2,}\s\S{1,}");
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

        
    }
}
