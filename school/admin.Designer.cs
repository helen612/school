
namespace school
{
    partial class admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.students_dgv = new System.Windows.Forms.DataGridView();
            this._tab = new System.Windows.Forms.TabControl();
            this.students = new System.Windows.Forms.TabPage();
            this.data_tab = new System.Windows.Forms.TabControl();
            this.filtr_tab = new System.Windows.Forms.TabPage();
            this.filter_b = new CustomControls.RJControls.RJButton();
            this.rjToggleButton2 = new CustomControls.RJControls.RJToggleButton();
            this.rjToggleButton1 = new CustomControls.RJControls.RJToggleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.student_adress_tb = new CustomControls.RJControls.RJTextBox();
            this.student_classs_tb = new CustomControls.RJControls.RJTextBox();
            this.students_id_tb = new CustomControls.RJControls.RJTextBox();
            this.dop_tab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Ctrl = new System.Windows.Forms.GroupBox();
            this.students_del_b = new CustomControls.RJControls.RJButton();
            this.students_edit_b = new CustomControls.RJControls.RJButton();
            this.student_add_b = new CustomControls.RJControls.RJButton();
            this.parrents = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rjButton4 = new CustomControls.RJControls.RJButton();
            this.parrentCon_chb = new CustomControls.RJControls.RJToggleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.parrent_job_tb = new CustomControls.RJControls.RJTextBox();
            this.parrent_id_tb = new CustomControls.RJControls.RJTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Ctrl_Par = new System.Windows.Forms.GroupBox();
            this.purrents_delete_b = new CustomControls.RJControls.RJButton();
            this.parrents_edit_b = new CustomControls.RJControls.RJButton();
            this.parrents_add_b = new CustomControls.RJControls.RJButton();
            this.Parrent_dgv = new System.Windows.Forms.DataGridView();
            this.large_famile_b = new CustomControls.RJControls.RJButton();
            this.activists_b = new CustomControls.RJControls.RJButton();
            this.best_students_b = new CustomControls.RJControls.RJButton();
            this.bed_marks_p_b = new CustomControls.RJControls.RJButton();
            this.parCom_b = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.students_dgv)).BeginInit();
            this._tab.SuspendLayout();
            this.students.SuspendLayout();
            this.data_tab.SuspendLayout();
            this.filtr_tab.SuspendLayout();
            this.dop_tab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Ctrl.SuspendLayout();
            this.parrents.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Ctrl_Par.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Parrent_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // students_dgv
            // 
            this.students_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.students_dgv.GridColor = System.Drawing.SystemColors.Info;
            this.students_dgv.Location = new System.Drawing.Point(0, 0);
            this.students_dgv.Name = "students_dgv";
            this.students_dgv.RowTemplate.Height = 25;
            this.students_dgv.Size = new System.Drawing.Size(570, 439);
            this.students_dgv.TabIndex = 0;
            // 
            // _tab
            // 
            this._tab.Controls.Add(this.students);
            this._tab.Controls.Add(this.parrents);
            this._tab.Location = new System.Drawing.Point(12, 12);
            this._tab.Name = "_tab";
            this._tab.SelectedIndex = 0;
            this._tab.Size = new System.Drawing.Size(791, 467);
            this._tab.TabIndex = 3;
            // 
            // students
            // 
            this.students.Controls.Add(this.data_tab);
            this.students.Controls.Add(this.Ctrl);
            this.students.Controls.Add(this.students_dgv);
            this.students.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.students.Location = new System.Drawing.Point(4, 24);
            this.students.Name = "students";
            this.students.Padding = new System.Windows.Forms.Padding(3);
            this.students.Size = new System.Drawing.Size(783, 439);
            this.students.TabIndex = 0;
            this.students.Text = "Учащиеся";
            this.students.UseVisualStyleBackColor = true;
            // 
            // data_tab
            // 
            this.data_tab.Controls.Add(this.filtr_tab);
            this.data_tab.Controls.Add(this.dop_tab);
            this.data_tab.Location = new System.Drawing.Point(577, 160);
            this.data_tab.Name = "data_tab";
            this.data_tab.SelectedIndex = 0;
            this.data_tab.Size = new System.Drawing.Size(200, 276);
            this.data_tab.TabIndex = 2;
            // 
            // filtr_tab
            // 
            this.filtr_tab.BackColor = System.Drawing.SystemColors.Control;
            this.filtr_tab.Controls.Add(this.filter_b);
            this.filtr_tab.Controls.Add(this.rjToggleButton2);
            this.filtr_tab.Controls.Add(this.rjToggleButton1);
            this.filtr_tab.Controls.Add(this.label4);
            this.filtr_tab.Controls.Add(this.label3);
            this.filtr_tab.Controls.Add(this.student_adress_tb);
            this.filtr_tab.Controls.Add(this.student_classs_tb);
            this.filtr_tab.Controls.Add(this.students_id_tb);
            this.filtr_tab.Location = new System.Drawing.Point(4, 24);
            this.filtr_tab.Name = "filtr_tab";
            this.filtr_tab.Padding = new System.Windows.Forms.Padding(3);
            this.filtr_tab.Size = new System.Drawing.Size(192, 248);
            this.filtr_tab.TabIndex = 0;
            this.filtr_tab.Text = "Фильтр";
            // 
            // filter_b
            // 
            this.filter_b.BackColor = System.Drawing.Color.Green;
            this.filter_b.BackgroundColor = System.Drawing.Color.Green;
            this.filter_b.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.filter_b.BorderRadius = 10;
            this.filter_b.BorderSize = 0;
            this.filter_b.FlatAppearance.BorderSize = 0;
            this.filter_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter_b.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filter_b.ForeColor = System.Drawing.Color.White;
            this.filter_b.Location = new System.Drawing.Point(6, 208);
            this.filter_b.Name = "filter_b";
            this.filter_b.Size = new System.Drawing.Size(179, 34);
            this.filter_b.TabIndex = 17;
            this.filter_b.Text = "Выполнить";
            this.filter_b.TextColor = System.Drawing.Color.White;
            this.filter_b.UseVisualStyleBackColor = false;
            // 
            // rjToggleButton2
            // 
            this.rjToggleButton2.AutoSize = true;
            this.rjToggleButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rjToggleButton2.Location = new System.Drawing.Point(140, 134);
            this.rjToggleButton2.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton2.Name = "rjToggleButton2";
            this.rjToggleButton2.OffBackColor = System.Drawing.Color.SlateGray;
            this.rjToggleButton2.OffToggleColor = System.Drawing.Color.White;
            this.rjToggleButton2.OnBackColor = System.Drawing.Color.Green;
            this.rjToggleButton2.OnToggleColor = System.Drawing.Color.White;
            this.rjToggleButton2.Size = new System.Drawing.Size(45, 22);
            this.rjToggleButton2.TabIndex = 16;
            this.rjToggleButton2.UseVisualStyleBackColor = true;
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.AutoSize = true;
            this.rjToggleButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rjToggleButton1.Location = new System.Drawing.Point(140, 165);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.OffBackColor = System.Drawing.Color.SlateGray;
            this.rjToggleButton1.OffToggleColor = System.Drawing.Color.White;
            this.rjToggleButton1.OnBackColor = System.Drawing.Color.Green;
            this.rjToggleButton1.OnToggleColor = System.Drawing.Color.White;
            this.rjToggleButton1.Size = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.TabIndex = 13;
            this.rjToggleButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "СОП";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Староста";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // student_adress_tb
            // 
            this.student_adress_tb.BackColor = System.Drawing.SystemColors.Window;
            this.student_adress_tb.BorderColor = System.Drawing.Color.Green;
            this.student_adress_tb.BorderFocusColor = System.Drawing.Color.Lime;
            this.student_adress_tb.BorderRadius = 0;
            this.student_adress_tb.BorderSize = 2;
            this.student_adress_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.student_adress_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.student_adress_tb.Location = new System.Drawing.Point(7, 85);
            this.student_adress_tb.Margin = new System.Windows.Forms.Padding(4);
            this.student_adress_tb.Multiline = false;
            this.student_adress_tb.Name = "student_adress_tb";
            this.student_adress_tb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.student_adress_tb.PasswordChar = false;
            this.student_adress_tb.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.student_adress_tb.PlaceholderText = "Адрес";
            this.student_adress_tb.Size = new System.Drawing.Size(178, 31);
            this.student_adress_tb.TabIndex = 5;
            this.student_adress_tb.Texts = "";
            this.student_adress_tb.UnderlinedStyle = false;
            // 
            // student_classs_tb
            // 
            this.student_classs_tb.BackColor = System.Drawing.SystemColors.Window;
            this.student_classs_tb.BorderColor = System.Drawing.Color.Green;
            this.student_classs_tb.BorderFocusColor = System.Drawing.Color.Lime;
            this.student_classs_tb.BorderRadius = 0;
            this.student_classs_tb.BorderSize = 2;
            this.student_classs_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.student_classs_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.student_classs_tb.Location = new System.Drawing.Point(7, 46);
            this.student_classs_tb.Margin = new System.Windows.Forms.Padding(4);
            this.student_classs_tb.Multiline = false;
            this.student_classs_tb.Name = "student_classs_tb";
            this.student_classs_tb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.student_classs_tb.PasswordChar = false;
            this.student_classs_tb.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.student_classs_tb.PlaceholderText = "Класс";
            this.student_classs_tb.Size = new System.Drawing.Size(178, 31);
            this.student_classs_tb.TabIndex = 4;
            this.student_classs_tb.Texts = "";
            this.student_classs_tb.UnderlinedStyle = false;
            // 
            // students_id_tb
            // 
            this.students_id_tb.BackColor = System.Drawing.SystemColors.Window;
            this.students_id_tb.BorderColor = System.Drawing.Color.Green;
            this.students_id_tb.BorderFocusColor = System.Drawing.Color.Lime;
            this.students_id_tb.BorderRadius = 0;
            this.students_id_tb.BorderSize = 2;
            this.students_id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.students_id_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.students_id_tb.Location = new System.Drawing.Point(7, 7);
            this.students_id_tb.Margin = new System.Windows.Forms.Padding(4);
            this.students_id_tb.Multiline = false;
            this.students_id_tb.Name = "students_id_tb";
            this.students_id_tb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.students_id_tb.PasswordChar = false;
            this.students_id_tb.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.students_id_tb.PlaceholderText = "Id";
            this.students_id_tb.Size = new System.Drawing.Size(178, 31);
            this.students_id_tb.TabIndex = 3;
            this.students_id_tb.Texts = "";
            this.students_id_tb.UnderlinedStyle = false;
            // 
            // dop_tab
            // 
            this.dop_tab.Controls.Add(this.best_students_b);
            this.dop_tab.Controls.Add(this.activists_b);
            this.dop_tab.Controls.Add(this.groupBox1);
            this.dop_tab.Location = new System.Drawing.Point(4, 24);
            this.dop_tab.Name = "dop_tab";
            this.dop_tab.Padding = new System.Windows.Forms.Padding(3);
            this.dop_tab.Size = new System.Drawing.Size(192, 248);
            this.dop_tab.TabIndex = 1;
            this.dop_tab.Text = "Доп. возможности";
            this.dop_tab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bed_marks_p_b);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(6, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 160);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 81);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(166, 23);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Начиная с :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Заканчивая по:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(166, 23);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // Ctrl
            // 
            this.Ctrl.Controls.Add(this.students_del_b);
            this.Ctrl.Controls.Add(this.students_edit_b);
            this.Ctrl.Controls.Add(this.student_add_b);
            this.Ctrl.Location = new System.Drawing.Point(577, 7);
            this.Ctrl.Name = "Ctrl";
            this.Ctrl.Size = new System.Drawing.Size(200, 146);
            this.Ctrl.TabIndex = 1;
            this.Ctrl.TabStop = false;
            this.Ctrl.Text = "Управление";
            // 
            // students_del_b
            // 
            this.students_del_b.BackColor = System.Drawing.Color.Green;
            this.students_del_b.BackgroundColor = System.Drawing.Color.Green;
            this.students_del_b.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.students_del_b.BorderRadius = 10;
            this.students_del_b.BorderSize = 0;
            this.students_del_b.FlatAppearance.BorderSize = 0;
            this.students_del_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.students_del_b.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.students_del_b.ForeColor = System.Drawing.Color.White;
            this.students_del_b.Location = new System.Drawing.Point(6, 102);
            this.students_del_b.Name = "students_del_b";
            this.students_del_b.Size = new System.Drawing.Size(188, 34);
            this.students_del_b.TabIndex = 11;
            this.students_del_b.Text = "Удалить";
            this.students_del_b.TextColor = System.Drawing.Color.White;
            this.students_del_b.UseVisualStyleBackColor = false;
            // 
            // students_edit_b
            // 
            this.students_edit_b.BackColor = System.Drawing.Color.Green;
            this.students_edit_b.BackgroundColor = System.Drawing.Color.Green;
            this.students_edit_b.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.students_edit_b.BorderRadius = 10;
            this.students_edit_b.BorderSize = 0;
            this.students_edit_b.FlatAppearance.BorderSize = 0;
            this.students_edit_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.students_edit_b.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.students_edit_b.ForeColor = System.Drawing.Color.White;
            this.students_edit_b.Location = new System.Drawing.Point(6, 62);
            this.students_edit_b.Name = "students_edit_b";
            this.students_edit_b.Size = new System.Drawing.Size(188, 34);
            this.students_edit_b.TabIndex = 10;
            this.students_edit_b.Text = "Редактировать";
            this.students_edit_b.TextColor = System.Drawing.Color.White;
            this.students_edit_b.UseVisualStyleBackColor = false;
            // 
            // student_add_b
            // 
            this.student_add_b.BackColor = System.Drawing.Color.Green;
            this.student_add_b.BackgroundColor = System.Drawing.Color.Green;
            this.student_add_b.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.student_add_b.BorderRadius = 10;
            this.student_add_b.BorderSize = 0;
            this.student_add_b.FlatAppearance.BorderSize = 0;
            this.student_add_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_add_b.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.student_add_b.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.student_add_b.Location = new System.Drawing.Point(6, 22);
            this.student_add_b.Name = "student_add_b";
            this.student_add_b.Size = new System.Drawing.Size(188, 34);
            this.student_add_b.TabIndex = 9;
            this.student_add_b.Text = "Добавить";
            this.student_add_b.TextColor = System.Drawing.Color.WhiteSmoke;
            this.student_add_b.UseVisualStyleBackColor = false;
            // 
            // parrents
            // 
            this.parrents.Controls.Add(this.tabControl1);
            this.parrents.Controls.Add(this.Ctrl_Par);
            this.parrents.Controls.Add(this.Parrent_dgv);
            this.parrents.Location = new System.Drawing.Point(4, 24);
            this.parrents.Name = "parrents";
            this.parrents.Padding = new System.Windows.Forms.Padding(3);
            this.parrents.Size = new System.Drawing.Size(783, 439);
            this.parrents.TabIndex = 1;
            this.parrents.Text = "Родители";
            this.parrents.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(576, 160);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 276);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.rjButton4);
            this.tabPage1.Controls.Add(this.parrentCon_chb);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.parrent_job_tb);
            this.tabPage1.Controls.Add(this.parrent_id_tb);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Фильтр";
            // 
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.Green;
            this.rjButton4.BackgroundColor = System.Drawing.Color.Green;
            this.rjButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton4.BorderRadius = 10;
            this.rjButton4.BorderSize = 0;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjButton4.ForeColor = System.Drawing.Color.White;
            this.rjButton4.Location = new System.Drawing.Point(6, 208);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(179, 34);
            this.rjButton4.TabIndex = 17;
            this.rjButton4.Text = "Выполнить";
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.UseVisualStyleBackColor = false;
            // 
            // parrentCon_chb
            // 
            this.parrentCon_chb.AutoSize = true;
            this.parrentCon_chb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.parrentCon_chb.Location = new System.Drawing.Point(72, 141);
            this.parrentCon_chb.MinimumSize = new System.Drawing.Size(45, 22);
            this.parrentCon_chb.Name = "parrentCon_chb";
            this.parrentCon_chb.OffBackColor = System.Drawing.Color.SlateGray;
            this.parrentCon_chb.OffToggleColor = System.Drawing.Color.White;
            this.parrentCon_chb.OnBackColor = System.Drawing.Color.Green;
            this.parrentCon_chb.OnToggleColor = System.Drawing.Color.White;
            this.parrentCon_chb.Size = new System.Drawing.Size(45, 22);
            this.parrentCon_chb.TabIndex = 16;
            this.parrentCon_chb.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(7, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Родительский коммитет";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // parrent_job_tb
            // 
            this.parrent_job_tb.BackColor = System.Drawing.SystemColors.Window;
            this.parrent_job_tb.BorderColor = System.Drawing.Color.Green;
            this.parrent_job_tb.BorderFocusColor = System.Drawing.Color.Lime;
            this.parrent_job_tb.BorderRadius = 0;
            this.parrent_job_tb.BorderSize = 2;
            this.parrent_job_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.parrent_job_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parrent_job_tb.Location = new System.Drawing.Point(7, 46);
            this.parrent_job_tb.Margin = new System.Windows.Forms.Padding(4);
            this.parrent_job_tb.Multiline = false;
            this.parrent_job_tb.Name = "parrent_job_tb";
            this.parrent_job_tb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.parrent_job_tb.PasswordChar = false;
            this.parrent_job_tb.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.parrent_job_tb.PlaceholderText = "Место работы";
            this.parrent_job_tb.Size = new System.Drawing.Size(178, 31);
            this.parrent_job_tb.TabIndex = 4;
            this.parrent_job_tb.Texts = "";
            this.parrent_job_tb.UnderlinedStyle = false;
            // 
            // parrent_id_tb
            // 
            this.parrent_id_tb.BackColor = System.Drawing.SystemColors.Window;
            this.parrent_id_tb.BorderColor = System.Drawing.Color.Green;
            this.parrent_id_tb.BorderFocusColor = System.Drawing.Color.Lime;
            this.parrent_id_tb.BorderRadius = 0;
            this.parrent_id_tb.BorderSize = 2;
            this.parrent_id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.parrent_id_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parrent_id_tb.Location = new System.Drawing.Point(7, 7);
            this.parrent_id_tb.Margin = new System.Windows.Forms.Padding(4);
            this.parrent_id_tb.Multiline = false;
            this.parrent_id_tb.Name = "parrent_id_tb";
            this.parrent_id_tb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.parrent_id_tb.PasswordChar = false;
            this.parrent_id_tb.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.parrent_id_tb.PlaceholderText = "Id";
            this.parrent_id_tb.Size = new System.Drawing.Size(178, 31);
            this.parrent_id_tb.TabIndex = 3;
            this.parrent_id_tb.Texts = "";
            this.parrent_id_tb.UnderlinedStyle = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.parCom_b);
            this.tabPage2.Controls.Add(this.large_famile_b);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 248);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Доп. возможности";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Ctrl_Par
            // 
            this.Ctrl_Par.Controls.Add(this.purrents_delete_b);
            this.Ctrl_Par.Controls.Add(this.parrents_edit_b);
            this.Ctrl_Par.Controls.Add(this.parrents_add_b);
            this.Ctrl_Par.Location = new System.Drawing.Point(576, 6);
            this.Ctrl_Par.Name = "Ctrl_Par";
            this.Ctrl_Par.Size = new System.Drawing.Size(200, 146);
            this.Ctrl_Par.TabIndex = 2;
            this.Ctrl_Par.TabStop = false;
            this.Ctrl_Par.Text = "Управление";
            // 
            // purrents_delete_b
            // 
            this.purrents_delete_b.BackColor = System.Drawing.Color.Green;
            this.purrents_delete_b.BackgroundColor = System.Drawing.Color.Green;
            this.purrents_delete_b.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.purrents_delete_b.BorderRadius = 10;
            this.purrents_delete_b.BorderSize = 0;
            this.purrents_delete_b.FlatAppearance.BorderSize = 0;
            this.purrents_delete_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purrents_delete_b.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.purrents_delete_b.ForeColor = System.Drawing.Color.White;
            this.purrents_delete_b.Location = new System.Drawing.Point(6, 102);
            this.purrents_delete_b.Name = "purrents_delete_b";
            this.purrents_delete_b.Size = new System.Drawing.Size(188, 34);
            this.purrents_delete_b.TabIndex = 11;
            this.purrents_delete_b.Text = "Удалить";
            this.purrents_delete_b.TextColor = System.Drawing.Color.White;
            this.purrents_delete_b.UseVisualStyleBackColor = false;
            // 
            // parrents_edit_b
            // 
            this.parrents_edit_b.BackColor = System.Drawing.Color.Green;
            this.parrents_edit_b.BackgroundColor = System.Drawing.Color.Green;
            this.parrents_edit_b.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.parrents_edit_b.BorderRadius = 10;
            this.parrents_edit_b.BorderSize = 0;
            this.parrents_edit_b.FlatAppearance.BorderSize = 0;
            this.parrents_edit_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parrents_edit_b.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.parrents_edit_b.ForeColor = System.Drawing.Color.White;
            this.parrents_edit_b.Location = new System.Drawing.Point(6, 62);
            this.parrents_edit_b.Name = "parrents_edit_b";
            this.parrents_edit_b.Size = new System.Drawing.Size(188, 34);
            this.parrents_edit_b.TabIndex = 10;
            this.parrents_edit_b.Text = "Редактировать";
            this.parrents_edit_b.TextColor = System.Drawing.Color.White;
            this.parrents_edit_b.UseVisualStyleBackColor = false;
            // 
            // parrents_add_b
            // 
            this.parrents_add_b.BackColor = System.Drawing.Color.Green;
            this.parrents_add_b.BackgroundColor = System.Drawing.Color.Green;
            this.parrents_add_b.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.parrents_add_b.BorderRadius = 10;
            this.parrents_add_b.BorderSize = 0;
            this.parrents_add_b.FlatAppearance.BorderSize = 0;
            this.parrents_add_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parrents_add_b.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.parrents_add_b.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.parrents_add_b.Location = new System.Drawing.Point(6, 22);
            this.parrents_add_b.Name = "parrents_add_b";
            this.parrents_add_b.Size = new System.Drawing.Size(188, 34);
            this.parrents_add_b.TabIndex = 9;
            this.parrents_add_b.Text = "Добавить";
            this.parrents_add_b.TextColor = System.Drawing.Color.WhiteSmoke;
            this.parrents_add_b.UseVisualStyleBackColor = false;
            // 
            // Parrent_dgv
            // 
            this.Parrent_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Parrent_dgv.GridColor = System.Drawing.SystemColors.Info;
            this.Parrent_dgv.Location = new System.Drawing.Point(0, 0);
            this.Parrent_dgv.Name = "Parrent_dgv";
            this.Parrent_dgv.RowTemplate.Height = 25;
            this.Parrent_dgv.Size = new System.Drawing.Size(570, 432);
            this.Parrent_dgv.TabIndex = 1;
            // 
            // large_famile_b
            // 
            this.large_famile_b.BackColor = System.Drawing.Color.Green;
            this.large_famile_b.BackgroundColor = System.Drawing.Color.Green;
            this.large_famile_b.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.large_famile_b.BorderRadius = 10;
            this.large_famile_b.BorderSize = 0;
            this.large_famile_b.FlatAppearance.BorderSize = 0;
            this.large_famile_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.large_famile_b.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.large_famile_b.ForeColor = System.Drawing.Color.White;
            this.large_famile_b.Location = new System.Drawing.Point(6, 6);
            this.large_famile_b.Name = "large_famile_b";
            this.large_famile_b.Size = new System.Drawing.Size(180, 34);
            this.large_famile_b.TabIndex = 12;
            this.large_famile_b.Text = "Многодетные";
            this.large_famile_b.TextColor = System.Drawing.Color.White;
            this.large_famile_b.UseVisualStyleBackColor = false;
            // 
            // activists_b
            // 
            this.activists_b.BackColor = System.Drawing.Color.Green;
            this.activists_b.BackgroundColor = System.Drawing.Color.Green;
            this.activists_b.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.activists_b.BorderRadius = 10;
            this.activists_b.BorderSize = 0;
            this.activists_b.FlatAppearance.BorderSize = 0;
            this.activists_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activists_b.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.activists_b.ForeColor = System.Drawing.Color.White;
            this.activists_b.Location = new System.Drawing.Point(6, 6);
            this.activists_b.Name = "activists_b";
            this.activists_b.Size = new System.Drawing.Size(178, 34);
            this.activists_b.TabIndex = 12;
            this.activists_b.Text = "Активист";
            this.activists_b.TextColor = System.Drawing.Color.White;
            this.activists_b.UseVisualStyleBackColor = false;
            // 
            // best_students_b
            // 
            this.best_students_b.BackColor = System.Drawing.Color.Green;
            this.best_students_b.BackgroundColor = System.Drawing.Color.Green;
            this.best_students_b.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.best_students_b.BorderRadius = 10;
            this.best_students_b.BorderSize = 0;
            this.best_students_b.FlatAppearance.BorderSize = 0;
            this.best_students_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.best_students_b.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.best_students_b.ForeColor = System.Drawing.Color.White;
            this.best_students_b.Location = new System.Drawing.Point(6, 46);
            this.best_students_b.Name = "best_students_b";
            this.best_students_b.Size = new System.Drawing.Size(178, 34);
            this.best_students_b.TabIndex = 13;
            this.best_students_b.Text = "Отличники";
            this.best_students_b.TextColor = System.Drawing.Color.White;
            this.best_students_b.UseVisualStyleBackColor = false;
            // 
            // bed_marks_p_b
            // 
            this.bed_marks_p_b.BackColor = System.Drawing.Color.Green;
            this.bed_marks_p_b.BackgroundColor = System.Drawing.Color.Green;
            this.bed_marks_p_b.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bed_marks_p_b.BorderRadius = 10;
            this.bed_marks_p_b.BorderSize = 0;
            this.bed_marks_p_b.FlatAppearance.BorderSize = 0;
            this.bed_marks_p_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bed_marks_p_b.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bed_marks_p_b.ForeColor = System.Drawing.Color.White;
            this.bed_marks_p_b.Location = new System.Drawing.Point(0, 110);
            this.bed_marks_p_b.Name = "bed_marks_p_b";
            this.bed_marks_p_b.Size = new System.Drawing.Size(178, 41);
            this.bed_marks_p_b.TabIndex = 16;
            this.bed_marks_p_b.Text = "Отстающие за период";
            this.bed_marks_p_b.TextColor = System.Drawing.Color.White;
            this.bed_marks_p_b.UseVisualStyleBackColor = false;
            // 
            // parCom_b
            // 
            this.parCom_b.BackColor = System.Drawing.Color.Green;
            this.parCom_b.BackgroundColor = System.Drawing.Color.Green;
            this.parCom_b.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.parCom_b.BorderRadius = 10;
            this.parCom_b.BorderSize = 0;
            this.parCom_b.FlatAppearance.BorderSize = 0;
            this.parCom_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parCom_b.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.parCom_b.ForeColor = System.Drawing.Color.White;
            this.parCom_b.Location = new System.Drawing.Point(6, 46);
            this.parCom_b.Name = "parCom_b";
            this.parCom_b.Size = new System.Drawing.Size(180, 83);
            this.parCom_b.TabIndex = 13;
            this.parCom_b.Text = "Родительский коммитет старших классов";
            this.parCom_b.TextColor = System.Drawing.Color.White;
            this.parCom_b.UseVisualStyleBackColor = false;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 485);
            this.Controls.Add(this._tab);
            this.Name = "admin";
            this.Text = "admin";
            ((System.ComponentModel.ISupportInitialize)(this.students_dgv)).EndInit();
            this._tab.ResumeLayout(false);
            this.students.ResumeLayout(false);
            this.data_tab.ResumeLayout(false);
            this.filtr_tab.ResumeLayout(false);
            this.filtr_tab.PerformLayout();
            this.dop_tab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Ctrl.ResumeLayout(false);
            this.parrents.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.Ctrl_Par.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Parrent_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView students_dgv;
        private System.Windows.Forms.TabControl _tab;
        private System.Windows.Forms.TabPage students;
        private System.Windows.Forms.TabPage parrents;
        private System.Windows.Forms.GroupBox Ctrl;
        private System.Windows.Forms.TabControl data_tab;
        private System.Windows.Forms.TabPage filtr_tab;
        private System.Windows.Forms.TabPage dop_tab;
        private CustomControls.RJControls.RJTextBox students_id_tb;
        private CustomControls.RJControls.RJTextBox student_classs_tb;
        private CustomControls.RJControls.RJTextBox student_adress_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomControls.RJControls.RJToggleButton rjToggleButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJToggleButton rjToggleButton2;
        private System.Windows.Forms.DataGridView Parrent_dgv;
        private CustomControls.RJControls.RJButton student_add_b;
        private CustomControls.RJControls.RJButton students_del_b;
        private CustomControls.RJControls.RJButton students_edit_b;
        private CustomControls.RJControls.RJButton filter_b;
        private System.Windows.Forms.GroupBox Ctrl_Par;
        private CustomControls.RJControls.RJButton purrents_delete_b;
        private CustomControls.RJControls.RJButton parrents_edit_b;
        private CustomControls.RJControls.RJButton parrents_add_b;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private CustomControls.RJControls.RJButton rjButton4;
        private CustomControls.RJControls.RJToggleButton parrentCon_chb;
        private System.Windows.Forms.Label label6;
        private CustomControls.RJControls.RJTextBox parrent_job_tb;
        private CustomControls.RJControls.RJTextBox parrent_id_tb;
        private System.Windows.Forms.TabPage tabPage2;
        private CustomControls.RJControls.RJButton large_famile_b;
        private CustomControls.RJControls.RJButton activists_b;
        private CustomControls.RJControls.RJButton best_students_b;
        private CustomControls.RJControls.RJButton bed_marks_p_b;
        private CustomControls.RJControls.RJButton parCom_b;
    }
}