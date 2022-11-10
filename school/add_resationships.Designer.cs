
namespace school
{
    partial class add_resationships
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
            this.id_parrent_tb = new CustomControls.RJControls.RJTextBox();
            this.id_child_tb = new CustomControls.RJControls.RJTextBox();
            this.parrent_l = new System.Windows.Forms.Label();
            this.child_l = new System.Windows.Forms.Label();
            this.set_relationships_b = new CustomControls.RJControls.RJButton();
            this.cansel_b = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // id_parrent_tb
            // 
            this.id_parrent_tb.BackColor = System.Drawing.SystemColors.Window;
            this.id_parrent_tb.BorderColor = System.Drawing.Color.Green;
            this.id_parrent_tb.BorderFocusColor = System.Drawing.Color.Lime;
            this.id_parrent_tb.BorderRadius = 0;
            this.id_parrent_tb.BorderSize = 2;
            this.id_parrent_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id_parrent_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.id_parrent_tb.Location = new System.Drawing.Point(13, 23);
            this.id_parrent_tb.Margin = new System.Windows.Forms.Padding(4);
            this.id_parrent_tb.Multiline = false;
            this.id_parrent_tb.Name = "id_parrent_tb";
            this.id_parrent_tb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.id_parrent_tb.PasswordChar = false;
            this.id_parrent_tb.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.id_parrent_tb.PlaceholderText = "Id родителя";
            this.id_parrent_tb.Size = new System.Drawing.Size(177, 35);
            this.id_parrent_tb.TabIndex = 5;
            this.id_parrent_tb.Texts = "";
            this.id_parrent_tb.UnderlinedStyle = false;
            // 
            // id_child_tb
            // 
            this.id_child_tb.BackColor = System.Drawing.SystemColors.Window;
            this.id_child_tb.BorderColor = System.Drawing.Color.Green;
            this.id_child_tb.BorderFocusColor = System.Drawing.Color.Lime;
            this.id_child_tb.BorderRadius = 0;
            this.id_child_tb.BorderSize = 2;
            this.id_child_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id_child_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.id_child_tb.Location = new System.Drawing.Point(13, 81);
            this.id_child_tb.Margin = new System.Windows.Forms.Padding(4);
            this.id_child_tb.Multiline = false;
            this.id_child_tb.Name = "id_child_tb";
            this.id_child_tb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.id_child_tb.PasswordChar = false;
            this.id_child_tb.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.id_child_tb.PlaceholderText = "Id ребенка";
            this.id_child_tb.Size = new System.Drawing.Size(177, 35);
            this.id_child_tb.TabIndex = 6;
            this.id_child_tb.Texts = "";
            this.id_child_tb.UnderlinedStyle = false;
            // 
            // parrent_l
            // 
            this.parrent_l.AutoSize = true;
            this.parrent_l.Location = new System.Drawing.Point(12, 62);
            this.parrent_l.Name = "parrent_l";
            this.parrent_l.Size = new System.Drawing.Size(58, 15);
            this.parrent_l.TabIndex = 7;
            this.parrent_l.Text = "Родитель";
            // 
            // child_l
            // 
            this.child_l.AutoSize = true;
            this.child_l.Location = new System.Drawing.Point(13, 120);
            this.child_l.Name = "child_l";
            this.child_l.Size = new System.Drawing.Size(53, 15);
            this.child_l.TabIndex = 8;
            this.child_l.Text = "Ребенок";
            // 
            // set_relationships_b
            // 
            this.set_relationships_b.BackColor = System.Drawing.Color.Green;
            this.set_relationships_b.BackgroundColor = System.Drawing.Color.Green;
            this.set_relationships_b.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.set_relationships_b.BorderRadius = 10;
            this.set_relationships_b.BorderSize = 0;
            this.set_relationships_b.FlatAppearance.BorderSize = 0;
            this.set_relationships_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_relationships_b.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.set_relationships_b.ForeColor = System.Drawing.Color.White;
            this.set_relationships_b.Location = new System.Drawing.Point(14, 148);
            this.set_relationships_b.Name = "set_relationships_b";
            this.set_relationships_b.Size = new System.Drawing.Size(177, 57);
            this.set_relationships_b.TabIndex = 18;
            this.set_relationships_b.Text = "Установить родтсвенную связь";
            this.set_relationships_b.TextColor = System.Drawing.Color.White;
            this.set_relationships_b.UseVisualStyleBackColor = false;
            // 
            // cansel_b
            // 
            this.cansel_b.BackColor = System.Drawing.Color.Green;
            this.cansel_b.BackgroundColor = System.Drawing.Color.Green;
            this.cansel_b.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cansel_b.BorderRadius = 10;
            this.cansel_b.BorderSize = 0;
            this.cansel_b.FlatAppearance.BorderSize = 0;
            this.cansel_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cansel_b.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cansel_b.ForeColor = System.Drawing.Color.White;
            this.cansel_b.Location = new System.Drawing.Point(13, 211);
            this.cansel_b.Name = "cansel_b";
            this.cansel_b.Size = new System.Drawing.Size(177, 34);
            this.cansel_b.TabIndex = 19;
            this.cansel_b.Text = "Отмена";
            this.cansel_b.TextColor = System.Drawing.Color.White;
            this.cansel_b.UseVisualStyleBackColor = false;
            // 
            // add_resationships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 257);
            this.Controls.Add(this.cansel_b);
            this.Controls.Add(this.set_relationships_b);
            this.Controls.Add(this.child_l);
            this.Controls.Add(this.parrent_l);
            this.Controls.Add(this.id_child_tb);
            this.Controls.Add(this.id_parrent_tb);
            this.Name = "add_resationships";
            this.Text = "add_resationships";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJTextBox id_parrent_tb;
        private CustomControls.RJControls.RJTextBox id_child_tb;
        private System.Windows.Forms.Label parrent_l;
        private System.Windows.Forms.Label child_l;
        private CustomControls.RJControls.RJButton set_relationships_b;
        private CustomControls.RJControls.RJButton cansel_b;
    }
}