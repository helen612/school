
namespace school
{
    partial class addMark
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
            this.tb_idStudier = new CustomControls.RJControls.RJTextBox();
            this.b_addMark = new CustomControls.RJControls.RJButton();
            this.cb_scObj = new System.Windows.Forms.ComboBox();
            this.tb_newMark = new CustomControls.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // tb_idStudier
            // 
            this.tb_idStudier.BackColor = System.Drawing.SystemColors.Window;
            this.tb_idStudier.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tb_idStudier.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_idStudier.BorderRadius = 0;
            this.tb_idStudier.BorderSize = 2;
            this.tb_idStudier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_idStudier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_idStudier.Location = new System.Drawing.Point(4, 13);
            this.tb_idStudier.Margin = new System.Windows.Forms.Padding(4);
            this.tb_idStudier.Multiline = false;
            this.tb_idStudier.Name = "tb_idStudier";
            this.tb_idStudier.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_idStudier.PasswordChar = false;
            this.tb_idStudier.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_idStudier.PlaceholderText = "id ученика";
            this.tb_idStudier.Size = new System.Drawing.Size(168, 31);
            this.tb_idStudier.TabIndex = 0;
            this.tb_idStudier.Texts = "";
            this.tb_idStudier.UnderlinedStyle = false;
            // 
            // b_addMark
            // 
            this.b_addMark.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.b_addMark.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.b_addMark.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.b_addMark.BorderRadius = 0;
            this.b_addMark.BorderSize = 0;
            this.b_addMark.FlatAppearance.BorderSize = 0;
            this.b_addMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_addMark.ForeColor = System.Drawing.Color.White;
            this.b_addMark.Location = new System.Drawing.Point(4, 121);
            this.b_addMark.Name = "b_addMark";
            this.b_addMark.Size = new System.Drawing.Size(168, 32);
            this.b_addMark.TabIndex = 1;
            this.b_addMark.Text = "Выставить";
            this.b_addMark.TextColor = System.Drawing.Color.White;
            this.b_addMark.UseVisualStyleBackColor = false;
            this.b_addMark.Click += new System.EventHandler(this.b_addMark_Click);
            // 
            // cb_scObj
            // 
            this.cb_scObj.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cb_scObj.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_scObj.FormattingEnabled = true;
            this.cb_scObj.Location = new System.Drawing.Point(4, 90);
            this.cb_scObj.Name = "cb_scObj";
            this.cb_scObj.Size = new System.Drawing.Size(168, 25);
            this.cb_scObj.TabIndex = 19;
            // 
            // tb_newMark
            // 
            this.tb_newMark.BackColor = System.Drawing.SystemColors.Window;
            this.tb_newMark.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tb_newMark.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_newMark.BorderRadius = 0;
            this.tb_newMark.BorderSize = 2;
            this.tb_newMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_newMark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_newMark.Location = new System.Drawing.Point(4, 52);
            this.tb_newMark.Margin = new System.Windows.Forms.Padding(4);
            this.tb_newMark.Multiline = false;
            this.tb_newMark.Name = "tb_newMark";
            this.tb_newMark.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_newMark.PasswordChar = false;
            this.tb_newMark.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_newMark.PlaceholderText = "Новая оценка";
            this.tb_newMark.Size = new System.Drawing.Size(168, 31);
            this.tb_newMark.TabIndex = 20;
            this.tb_newMark.Texts = "";
            this.tb_newMark.UnderlinedStyle = false;
            // 
            // addMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 173);
            this.Controls.Add(this.tb_newMark);
            this.Controls.Add(this.cb_scObj);
            this.Controls.Add(this.b_addMark);
            this.Controls.Add(this.tb_idStudier);
            this.Name = "addMark";
            this.Text = "Выставление оценки";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJTextBox tb_idStudier;
        private CustomControls.RJControls.RJButton b_addMark;
        private System.Windows.Forms.ComboBox cb_scObj;
        private CustomControls.RJControls.RJTextBox tb_newMark;
    }
}