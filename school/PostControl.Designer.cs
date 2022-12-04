
namespace school
{
    partial class PostControl
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
            this.tb_id_emp = new CustomControls.RJControls.RJTextBox();
            this.b_add = new CustomControls.RJControls.RJButton();
            this.b_remove = new CustomControls.RJControls.RJButton();
            this.cb_choosePost = new System.Windows.Forms.ComboBox();
            this.l_post_empl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_id_emp
            // 
            this.tb_id_emp.BackColor = System.Drawing.SystemColors.Window;
            this.tb_id_emp.BorderColor = System.Drawing.Color.Green;
            this.tb_id_emp.BorderFocusColor = System.Drawing.Color.Lime;
            this.tb_id_emp.BorderRadius = 0;
            this.tb_id_emp.BorderSize = 2;
            this.tb_id_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_id_emp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_id_emp.Location = new System.Drawing.Point(13, 13);
            this.tb_id_emp.Margin = new System.Windows.Forms.Padding(4);
            this.tb_id_emp.Multiline = false;
            this.tb_id_emp.Name = "tb_id_emp";
            this.tb_id_emp.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_id_emp.PasswordChar = false;
            this.tb_id_emp.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_id_emp.PlaceholderText = "id сотрудника";
            this.tb_id_emp.Size = new System.Drawing.Size(177, 35);
            this.tb_id_emp.TabIndex = 5;
            this.tb_id_emp.Texts = "";
            this.tb_id_emp.UnderlinedStyle = false;
            this.tb_id_emp._TextChanged += new System.EventHandler(this.tb_id_emp__TextChanged);
            // 
            // b_add
            // 
            this.b_add.BackColor = System.Drawing.Color.Green;
            this.b_add.BackgroundColor = System.Drawing.Color.Green;
            this.b_add.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.b_add.BorderRadius = 10;
            this.b_add.BorderSize = 0;
            this.b_add.FlatAppearance.BorderSize = 0;
            this.b_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_add.ForeColor = System.Drawing.Color.White;
            this.b_add.Location = new System.Drawing.Point(14, 125);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(177, 57);
            this.b_add.TabIndex = 18;
            this.b_add.Text = "Добавить эту должность";
            this.b_add.TextColor = System.Drawing.Color.White;
            this.b_add.UseVisualStyleBackColor = false;
            this.b_add.Click += new System.EventHandler(this.set_relationships_b_Click);
            // 
            // b_remove
            // 
            this.b_remove.BackColor = System.Drawing.Color.Green;
            this.b_remove.BackgroundColor = System.Drawing.Color.Green;
            this.b_remove.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.b_remove.BorderRadius = 10;
            this.b_remove.BorderSize = 0;
            this.b_remove.FlatAppearance.BorderSize = 0;
            this.b_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_remove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_remove.ForeColor = System.Drawing.Color.White;
            this.b_remove.Location = new System.Drawing.Point(14, 188);
            this.b_remove.Name = "b_remove";
            this.b_remove.Size = new System.Drawing.Size(177, 57);
            this.b_remove.TabIndex = 19;
            this.b_remove.Text = "Удалить эту должность";
            this.b_remove.TextColor = System.Drawing.Color.White;
            this.b_remove.UseVisualStyleBackColor = false;
            this.b_remove.Click += new System.EventHandler(this.delete_Click);
            // 
            // cb_choosePost
            // 
            this.cb_choosePost.BackColor = System.Drawing.Color.Green;
            this.cb_choosePost.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_choosePost.FormattingEnabled = true;
            this.cb_choosePost.Location = new System.Drawing.Point(12, 82);
            this.cb_choosePost.Name = "cb_choosePost";
            this.cb_choosePost.Size = new System.Drawing.Size(178, 33);
            this.cb_choosePost.TabIndex = 20;
            this.cb_choosePost.Text = "Должность";
            // 
            // l_post_empl
            // 
            this.l_post_empl.AutoSize = true;
            this.l_post_empl.Location = new System.Drawing.Point(13, 56);
            this.l_post_empl.Name = "l_post_empl";
            this.l_post_empl.Size = new System.Drawing.Size(66, 15);
            this.l_post_empl.TabIndex = 21;
            this.l_post_empl.Text = "Сотрудник";
            // 
            // PostControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 258);
            this.Controls.Add(this.l_post_empl);
            this.Controls.Add(this.cb_choosePost);
            this.Controls.Add(this.b_remove);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.tb_id_emp);
            this.Name = "PostControl";
            this.Text = "Управление должностями";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJTextBox tb_id_emp;
        private CustomControls.RJControls.RJButton b_add;
        private CustomControls.RJControls.RJButton b_remove;
        private System.Windows.Forms.ComboBox cb_choosePost;
        private System.Windows.Forms.Label l_post_empl;
    }
}