
namespace school
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.ErrEnter = new System.Windows.Forms.Label();
            this.login_tb = new CustomControls.RJControls.RJTextBox();
            this.password_tb = new CustomControls.RJControls.RJTextBox();
            this.enter_b = new CustomControls.RJControls.RJButton();
            this.showPsw_chb = new CustomControls.RJControls.RJToggleButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(72, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Авторизация";
            // 
            // ErrEnter
            // 
            this.ErrEnter.AutoSize = true;
            this.ErrEnter.BackColor = System.Drawing.SystemColors.Control;
            this.ErrEnter.Location = new System.Drawing.Point(13, 203);
            this.ErrEnter.Name = "ErrEnter";
            this.ErrEnter.Size = new System.Drawing.Size(87, 15);
            this.ErrEnter.TabIndex = 7;
            this.ErrEnter.Text = "Ошибка входа";
            // 
            // login_tb
            // 
            this.login_tb.BackColor = System.Drawing.SystemColors.Window;
            this.login_tb.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.login_tb.BorderFocusColor = System.Drawing.Color.Green;
            this.login_tb.BorderRadius = 0;
            this.login_tb.BorderSize = 2;
            this.login_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_tb.Location = new System.Drawing.Point(13, 90);
            this.login_tb.Margin = new System.Windows.Forms.Padding(4);
            this.login_tb.Multiline = false;
            this.login_tb.Name = "login_tb";
            this.login_tb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.login_tb.PasswordChar = false;
            this.login_tb.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.login_tb.PlaceholderText = "Username";
            this.login_tb.Size = new System.Drawing.Size(282, 39);
            this.login_tb.TabIndex = 8;
            this.login_tb.Texts = "";
            this.login_tb.UnderlinedStyle = false;
            // 
            // password_tb
            // 
            this.password_tb.BackColor = System.Drawing.SystemColors.Window;
            this.password_tb.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.password_tb.BorderFocusColor = System.Drawing.Color.Green;
            this.password_tb.BorderRadius = 0;
            this.password_tb.BorderSize = 2;
            this.password_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password_tb.Location = new System.Drawing.Point(13, 149);
            this.password_tb.Margin = new System.Windows.Forms.Padding(4);
            this.password_tb.Multiline = false;
            this.password_tb.Name = "password_tb";
            this.password_tb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.password_tb.PasswordChar = false;
            this.password_tb.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.password_tb.PlaceholderText = "Пароль";
            this.password_tb.Size = new System.Drawing.Size(230, 39);
            this.password_tb.TabIndex = 9;
            this.password_tb.Texts = "";
            this.password_tb.UnderlinedStyle = false;
            // 
            // enter_b
            // 
            this.enter_b.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.enter_b.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.enter_b.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.enter_b.BorderRadius = 0;
            this.enter_b.BorderSize = 0;
            this.enter_b.FlatAppearance.BorderSize = 0;
            this.enter_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter_b.ForeColor = System.Drawing.Color.White;
            this.enter_b.Location = new System.Drawing.Point(67, 239);
            this.enter_b.Name = "enter_b";
            this.enter_b.Size = new System.Drawing.Size(178, 32);
            this.enter_b.TabIndex = 10;
            this.enter_b.Text = "Войти";
            this.enter_b.TextColor = System.Drawing.Color.White;
            this.enter_b.UseVisualStyleBackColor = false;
            this.enter_b.Click += new System.EventHandler(this.enter_b_Click);
            // 
            // showPsw_chb
            // 
            this.showPsw_chb.AutoSize = true;
            this.showPsw_chb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showPsw_chb.Location = new System.Drawing.Point(250, 157);
            this.showPsw_chb.MinimumSize = new System.Drawing.Size(45, 22);
            this.showPsw_chb.Name = "showPsw_chb";
            this.showPsw_chb.OffBackColor = System.Drawing.Color.Gray;
            this.showPsw_chb.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.showPsw_chb.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.showPsw_chb.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.showPsw_chb.Size = new System.Drawing.Size(45, 22);
            this.showPsw_chb.TabIndex = 11;
            this.showPsw_chb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 301);
            this.Controls.Add(this.showPsw_chb);
            this.Controls.Add(this.enter_b);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.login_tb);
            this.Controls.Add(this.ErrEnter);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ErrEnter;
        private CustomControls.RJControls.RJTextBox login_tb;
        private CustomControls.RJControls.RJTextBox password_tb;
        private CustomControls.RJControls.RJButton enter_b;
        private CustomControls.RJControls.RJToggleButton showPsw_chb;
    }
}

