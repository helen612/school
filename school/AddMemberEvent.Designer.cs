
namespace school
{
    partial class AddMemberEvent
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
            this.tb_id_member = new CustomControls.RJControls.RJTextBox();
            this.l_member = new System.Windows.Forms.Label();
            this.tb_id_event = new CustomControls.RJControls.RJTextBox();
            this.l_event = new System.Windows.Forms.Label();
            this.b_add_member = new CustomControls.RJControls.RJButton();
            this.del_ev_member = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // tb_id_member
            // 
            this.tb_id_member.BackColor = System.Drawing.SystemColors.Window;
            this.tb_id_member.BorderColor = System.Drawing.Color.Green;
            this.tb_id_member.BorderFocusColor = System.Drawing.Color.Lime;
            this.tb_id_member.BorderRadius = 0;
            this.tb_id_member.BorderSize = 2;
            this.tb_id_member.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_id_member.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_id_member.Location = new System.Drawing.Point(13, 13);
            this.tb_id_member.Margin = new System.Windows.Forms.Padding(4);
            this.tb_id_member.Multiline = false;
            this.tb_id_member.Name = "tb_id_member";
            this.tb_id_member.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_id_member.PasswordChar = false;
            this.tb_id_member.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_id_member.PlaceholderText = "id участника";
            this.tb_id_member.Size = new System.Drawing.Size(177, 35);
            this.tb_id_member.TabIndex = 6;
            this.tb_id_member.Texts = "";
            this.tb_id_member.UnderlinedStyle = false;
            this.tb_id_member._TextChanged += new System.EventHandler(this.tb_id_member__TextChanged);
            // 
            // l_member
            // 
            this.l_member.AutoSize = true;
            this.l_member.Location = new System.Drawing.Point(13, 52);
            this.l_member.Name = "l_member";
            this.l_member.Size = new System.Drawing.Size(58, 15);
            this.l_member.TabIndex = 7;
            this.l_member.Text = "Участник";
            // 
            // tb_id_event
            // 
            this.tb_id_event.BackColor = System.Drawing.SystemColors.Window;
            this.tb_id_event.BorderColor = System.Drawing.Color.Green;
            this.tb_id_event.BorderFocusColor = System.Drawing.Color.Lime;
            this.tb_id_event.BorderRadius = 0;
            this.tb_id_event.BorderSize = 2;
            this.tb_id_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_id_event.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_id_event.Location = new System.Drawing.Point(13, 71);
            this.tb_id_event.Margin = new System.Windows.Forms.Padding(4);
            this.tb_id_event.Multiline = false;
            this.tb_id_event.Name = "tb_id_event";
            this.tb_id_event.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_id_event.PasswordChar = false;
            this.tb_id_event.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_id_event.PlaceholderText = "id меропритяия";
            this.tb_id_event.Size = new System.Drawing.Size(177, 35);
            this.tb_id_event.TabIndex = 8;
            this.tb_id_event.Texts = "";
            this.tb_id_event.UnderlinedStyle = false;
            this.tb_id_event._TextChanged += new System.EventHandler(this.tb_id_event__TextChanged);
            // 
            // l_event
            // 
            this.l_event.AutoSize = true;
            this.l_event.Location = new System.Drawing.Point(12, 110);
            this.l_event.Name = "l_event";
            this.l_event.Size = new System.Drawing.Size(83, 15);
            this.l_event.TabIndex = 9;
            this.l_event.Text = "Мероприятие";
            // 
            // b_add_member
            // 
            this.b_add_member.BackColor = System.Drawing.Color.Green;
            this.b_add_member.BackgroundColor = System.Drawing.Color.Green;
            this.b_add_member.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.b_add_member.BorderRadius = 10;
            this.b_add_member.BorderSize = 0;
            this.b_add_member.FlatAppearance.BorderSize = 0;
            this.b_add_member.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_add_member.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_add_member.ForeColor = System.Drawing.Color.White;
            this.b_add_member.Location = new System.Drawing.Point(12, 132);
            this.b_add_member.Name = "b_add_member";
            this.b_add_member.Size = new System.Drawing.Size(177, 33);
            this.b_add_member.TabIndex = 19;
            this.b_add_member.Text = "Добавить участника";
            this.b_add_member.TextColor = System.Drawing.Color.White;
            this.b_add_member.UseVisualStyleBackColor = false;
            this.b_add_member.Click += new System.EventHandler(this.b_add_member_Click);
            // 
            // del_ev_member
            // 
            this.del_ev_member.BackColor = System.Drawing.Color.Green;
            this.del_ev_member.BackgroundColor = System.Drawing.Color.Green;
            this.del_ev_member.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.del_ev_member.BorderRadius = 10;
            this.del_ev_member.BorderSize = 0;
            this.del_ev_member.FlatAppearance.BorderSize = 0;
            this.del_ev_member.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_ev_member.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.del_ev_member.ForeColor = System.Drawing.Color.White;
            this.del_ev_member.Location = new System.Drawing.Point(13, 171);
            this.del_ev_member.Name = "del_ev_member";
            this.del_ev_member.Size = new System.Drawing.Size(177, 33);
            this.del_ev_member.TabIndex = 20;
            this.del_ev_member.Text = "Удалить участника";
            this.del_ev_member.TextColor = System.Drawing.Color.White;
            this.del_ev_member.UseVisualStyleBackColor = false;
            this.del_ev_member.Click += new System.EventHandler(this.del_ev_member_Click);
            // 
            // AddMemberEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 213);
            this.Controls.Add(this.del_ev_member);
            this.Controls.Add(this.b_add_member);
            this.Controls.Add(this.l_event);
            this.Controls.Add(this.tb_id_event);
            this.Controls.Add(this.l_member);
            this.Controls.Add(this.tb_id_member);
            this.Name = "AddMemberEvent";
            this.Text = "AddMemberEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJTextBox tb_id_member;
        private System.Windows.Forms.Label l_member;
        private CustomControls.RJControls.RJTextBox tb_id_event;
        private System.Windows.Forms.Label l_event;
        private CustomControls.RJControls.RJButton b_add_member;
        private CustomControls.RJControls.RJButton del_ev_member;
    }
}