
namespace school
{
    partial class TimeTable
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
            this.cb_day = new System.Windows.Forms.ComboBox();
            this.tb_idMark = new CustomControls.RJControls.RJTextBox();
            this.сb_ring = new System.Windows.Forms.ComboBox();
            this.cb_class = new System.Windows.Forms.ComboBox();
            this.cb_item = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.b_add_or_change = new CustomControls.RJControls.RJButton();
            this.tb_idTeach = new CustomControls.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // cb_day
            // 
            this.cb_day.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cb_day.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_day.FormattingEnabled = true;
            this.cb_day.Items.AddRange(new object[] {
            "Не выбрано",
            "Мужской",
            "Женский"});
            this.cb_day.Location = new System.Drawing.Point(13, 53);
            this.cb_day.Name = "cb_day";
            this.cb_day.Size = new System.Drawing.Size(120, 28);
            this.cb_day.TabIndex = 19;
            this.cb_day.Text = "День";
            // 
            // tb_idMark
            // 
            this.tb_idMark.BackColor = System.Drawing.SystemColors.Window;
            this.tb_idMark.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.tb_idMark.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.tb_idMark.BorderRadius = 0;
            this.tb_idMark.BorderSize = 2;
            this.tb_idMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_idMark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_idMark.Location = new System.Drawing.Point(13, 13);
            this.tb_idMark.Margin = new System.Windows.Forms.Padding(4);
            this.tb_idMark.Multiline = false;
            this.tb_idMark.Name = "tb_idMark";
            this.tb_idMark.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_idMark.PasswordChar = false;
            this.tb_idMark.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_idMark.PlaceholderText = "id расписания";
            this.tb_idMark.Size = new System.Drawing.Size(258, 33);
            this.tb_idMark.TabIndex = 20;
            this.tb_idMark.Texts = "";
            this.tb_idMark.UnderlinedStyle = false;
            // 
            // сb_ring
            // 
            this.сb_ring.BackColor = System.Drawing.Color.CornflowerBlue;
            this.сb_ring.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.сb_ring.FormattingEnabled = true;
            this.сb_ring.Items.AddRange(new object[] {
            "Не выбрано",
            "Мужской",
            "Женский"});
            this.сb_ring.Location = new System.Drawing.Point(13, 92);
            this.сb_ring.Name = "сb_ring";
            this.сb_ring.Size = new System.Drawing.Size(120, 28);
            this.сb_ring.TabIndex = 21;
            this.сb_ring.Text = "Урок";
            // 
            // cb_class
            // 
            this.cb_class.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cb_class.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_class.FormattingEnabled = true;
            this.cb_class.Items.AddRange(new object[] {
            "Не выбрано",
            "Мужской",
            "Женский"});
            this.cb_class.Location = new System.Drawing.Point(13, 131);
            this.cb_class.Name = "cb_class";
            this.cb_class.Size = new System.Drawing.Size(120, 28);
            this.cb_class.TabIndex = 22;
            this.cb_class.Text = "Класс";
            // 
            // cb_item
            // 
            this.cb_item.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cb_item.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_item.FormattingEnabled = true;
            this.cb_item.Items.AddRange(new object[] {
            "Не выбрано",
            "Мужской",
            "Женский"});
            this.cb_item.Location = new System.Drawing.Point(151, 52);
            this.cb_item.Name = "cb_item";
            this.cb_item.Size = new System.Drawing.Size(120, 28);
            this.cb_item.TabIndex = 23;
            this.cb_item.Text = "Предмет";
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.comboBox5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Не выбрано",
            "Мужской",
            "Женский"});
            this.comboBox5.Location = new System.Drawing.Point(151, 131);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(120, 28);
            this.comboBox5.TabIndex = 25;
            this.comboBox5.Text = "Кабинет";
            // 
            // b_add_or_change
            // 
            this.b_add_or_change.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.b_add_or_change.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.b_add_or_change.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.b_add_or_change.BorderRadius = 0;
            this.b_add_or_change.BorderSize = 0;
            this.b_add_or_change.FlatAppearance.BorderSize = 0;
            this.b_add_or_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_add_or_change.ForeColor = System.Drawing.Color.White;
            this.b_add_or_change.Location = new System.Drawing.Point(13, 175);
            this.b_add_or_change.Name = "b_add_or_change";
            this.b_add_or_change.Size = new System.Drawing.Size(258, 40);
            this.b_add_or_change.TabIndex = 26;
            this.b_add_or_change.Text = "Добавить";
            this.b_add_or_change.TextColor = System.Drawing.Color.White;
            this.b_add_or_change.UseVisualStyleBackColor = false;
            // 
            // tb_idTeach
            // 
            this.tb_idTeach.BackColor = System.Drawing.SystemColors.Window;
            this.tb_idTeach.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.tb_idTeach.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.tb_idTeach.BorderRadius = 0;
            this.tb_idTeach.BorderSize = 2;
            this.tb_idTeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_idTeach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_idTeach.Location = new System.Drawing.Point(151, 90);
            this.tb_idTeach.Margin = new System.Windows.Forms.Padding(4);
            this.tb_idTeach.Multiline = false;
            this.tb_idTeach.Name = "tb_idTeach";
            this.tb_idTeach.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_idTeach.PasswordChar = false;
            this.tb_idTeach.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_idTeach.PlaceholderText = "id учителя";
            this.tb_idTeach.Size = new System.Drawing.Size(120, 30);
            this.tb_idTeach.TabIndex = 27;
            this.tb_idTeach.Texts = "";
            this.tb_idTeach.UnderlinedStyle = false;
            // 
            // TimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 231);
            this.Controls.Add(this.tb_idTeach);
            this.Controls.Add(this.b_add_or_change);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.cb_item);
            this.Controls.Add(this.cb_class);
            this.Controls.Add(this.сb_ring);
            this.Controls.Add(this.tb_idMark);
            this.Controls.Add(this.cb_day);
            this.Name = "TimeTable";
            this.Text = "Расписание";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_day;
        private CustomControls.RJControls.RJTextBox tb_idMark;
        private System.Windows.Forms.ComboBox сb_ring;
        private System.Windows.Forms.ComboBox cb_class;
        private System.Windows.Forms.ComboBox cb_item;
        private System.Windows.Forms.ComboBox comboBox5;
        private CustomControls.RJControls.RJButton b_add_or_change;
        private CustomControls.RJControls.RJTextBox tb_idTeach;
    }
}