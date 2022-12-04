
namespace school
{
    partial class addEvent
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
            this.tb_name = new CustomControls.RJControls.RJTextBox();
            this.dtp_date = new school.RJDatePicker();
            this.tb_time = new CustomControls.RJControls.RJTextBox();
            this.tb_len = new CustomControls.RJControls.RJTextBox();
            this.tb_place = new CustomControls.RJControls.RJTextBox();
            this.b_add = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.SystemColors.Window;
            this.tb_name.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tb_name.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_name.BorderRadius = 0;
            this.tb_name.BorderSize = 2;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_name.Location = new System.Drawing.Point(13, 13);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_name.Multiline = false;
            this.tb_name.Name = "tb_name";
            this.tb_name.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_name.PasswordChar = false;
            this.tb_name.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_name.PlaceholderText = "Название";
            this.tb_name.Size = new System.Drawing.Size(200, 31);
            this.tb_name.TabIndex = 0;
            this.tb_name.Texts = "";
            this.tb_name.UnderlinedStyle = false;
            // 
            // dtp_date
            // 
            this.dtp_date.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtp_date.BorderSize = 0;
            this.dtp_date.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_date.Location = new System.Drawing.Point(13, 51);
            this.dtp_date.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 35);
            this.dtp_date.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dtp_date.TabIndex = 1;
            this.dtp_date.TextColor = System.Drawing.Color.White;
            // 
            // tb_time
            // 
            this.tb_time.BackColor = System.Drawing.SystemColors.Window;
            this.tb_time.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tb_time.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_time.BorderRadius = 0;
            this.tb_time.BorderSize = 2;
            this.tb_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_time.Location = new System.Drawing.Point(13, 93);
            this.tb_time.Margin = new System.Windows.Forms.Padding(4);
            this.tb_time.Multiline = false;
            this.tb_time.Name = "tb_time";
            this.tb_time.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_time.PasswordChar = false;
            this.tb_time.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_time.PlaceholderText = "Время (23:59)";
            this.tb_time.Size = new System.Drawing.Size(200, 31);
            this.tb_time.TabIndex = 2;
            this.tb_time.Texts = "";
            this.tb_time.UnderlinedStyle = false;
            // 
            // tb_len
            // 
            this.tb_len.BackColor = System.Drawing.SystemColors.Window;
            this.tb_len.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tb_len.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_len.BorderRadius = 0;
            this.tb_len.BorderSize = 2;
            this.tb_len.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_len.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_len.Location = new System.Drawing.Point(13, 132);
            this.tb_len.Margin = new System.Windows.Forms.Padding(4);
            this.tb_len.Multiline = false;
            this.tb_len.Name = "tb_len";
            this.tb_len.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_len.PasswordChar = false;
            this.tb_len.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_len.PlaceholderText = "Продолжительность (23:59)";
            this.tb_len.Size = new System.Drawing.Size(200, 31);
            this.tb_len.TabIndex = 3;
            this.tb_len.Texts = "";
            this.tb_len.UnderlinedStyle = false;
            // 
            // tb_place
            // 
            this.tb_place.BackColor = System.Drawing.SystemColors.Window;
            this.tb_place.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tb_place.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_place.BorderRadius = 0;
            this.tb_place.BorderSize = 2;
            this.tb_place.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_place.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_place.Location = new System.Drawing.Point(13, 171);
            this.tb_place.Margin = new System.Windows.Forms.Padding(4);
            this.tb_place.Multiline = false;
            this.tb_place.Name = "tb_place";
            this.tb_place.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_place.PasswordChar = false;
            this.tb_place.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_place.PlaceholderText = "Место";
            this.tb_place.Size = new System.Drawing.Size(200, 31);
            this.tb_place.TabIndex = 4;
            this.tb_place.Texts = "";
            this.tb_place.UnderlinedStyle = false;
            // 
            // b_add
            // 
            this.b_add.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.b_add.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.b_add.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.b_add.BorderRadius = 0;
            this.b_add.BorderSize = 0;
            this.b_add.FlatAppearance.BorderSize = 0;
            this.b_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_add.ForeColor = System.Drawing.Color.White;
            this.b_add.Location = new System.Drawing.Point(13, 210);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(200, 34);
            this.b_add.TabIndex = 5;
            this.b_add.Text = "Добавить";
            this.b_add.TextColor = System.Drawing.Color.White;
            this.b_add.UseVisualStyleBackColor = false;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // addEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 265);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.tb_place);
            this.Controls.Add(this.tb_len);
            this.Controls.Add(this.tb_time);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.tb_name);
            this.Name = "addEvent";
            this.Text = "Мероприятия";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJTextBox tb_name;
        private RJDatePicker dtp_date;
        private CustomControls.RJControls.RJTextBox tb_time;
        private CustomControls.RJControls.RJTextBox tb_len;
        private CustomControls.RJControls.RJTextBox tb_place;
        private CustomControls.RJControls.RJButton b_add;
    }
}