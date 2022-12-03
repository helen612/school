
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
            this.tb_id_parrent = new CustomControls.RJControls.RJTextBox();
            this.tb_id_child = new CustomControls.RJControls.RJTextBox();
            this.set_relationships_b = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // tb_id_parrent
            // 
            this.tb_id_parrent.BackColor = System.Drawing.SystemColors.Window;
            this.tb_id_parrent.BorderColor = System.Drawing.Color.Green;
            this.tb_id_parrent.BorderFocusColor = System.Drawing.Color.Lime;
            this.tb_id_parrent.BorderRadius = 0;
            this.tb_id_parrent.BorderSize = 2;
            this.tb_id_parrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_id_parrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_id_parrent.Location = new System.Drawing.Point(13, 13);
            this.tb_id_parrent.Margin = new System.Windows.Forms.Padding(4);
            this.tb_id_parrent.Multiline = false;
            this.tb_id_parrent.Name = "tb_id_parrent";
            this.tb_id_parrent.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_id_parrent.PasswordChar = false;
            this.tb_id_parrent.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_id_parrent.PlaceholderText = "Id родителя";
            this.tb_id_parrent.Size = new System.Drawing.Size(177, 35);
            this.tb_id_parrent.TabIndex = 5;
            this.tb_id_parrent.Texts = "";
            this.tb_id_parrent.UnderlinedStyle = false;
            // 
            // tb_id_child
            // 
            this.tb_id_child.BackColor = System.Drawing.SystemColors.Window;
            this.tb_id_child.BorderColor = System.Drawing.Color.Green;
            this.tb_id_child.BorderFocusColor = System.Drawing.Color.Lime;
            this.tb_id_child.BorderRadius = 0;
            this.tb_id_child.BorderSize = 2;
            this.tb_id_child.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_id_child.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_id_child.Location = new System.Drawing.Point(13, 56);
            this.tb_id_child.Margin = new System.Windows.Forms.Padding(4);
            this.tb_id_child.Multiline = false;
            this.tb_id_child.Name = "tb_id_child";
            this.tb_id_child.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_id_child.PasswordChar = false;
            this.tb_id_child.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_id_child.PlaceholderText = "Id ребенка";
            this.tb_id_child.Size = new System.Drawing.Size(177, 35);
            this.tb_id_child.TabIndex = 6;
            this.tb_id_child.Texts = "";
            this.tb_id_child.UnderlinedStyle = false;
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
            this.set_relationships_b.Location = new System.Drawing.Point(14, 98);
            this.set_relationships_b.Name = "set_relationships_b";
            this.set_relationships_b.Size = new System.Drawing.Size(177, 57);
            this.set_relationships_b.TabIndex = 18;
            this.set_relationships_b.Text = "Установить родтсвенную связь";
            this.set_relationships_b.TextColor = System.Drawing.Color.White;
            this.set_relationships_b.UseVisualStyleBackColor = false;
            this.set_relationships_b.Click += new System.EventHandler(this.set_relationships_b_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Green;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Green;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(14, 161);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(177, 57);
            this.rjButton1.TabIndex = 19;
            this.rjButton1.Text = "Удалить родтсвенную связь";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // add_resationships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 226);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.set_relationships_b);
            this.Controls.Add(this.tb_id_child);
            this.Controls.Add(this.tb_id_parrent);
            this.Name = "add_resationships";
            this.Text = "add_resationships";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJTextBox tb_id_parrent;
        private CustomControls.RJControls.RJTextBox tb_id_child;
        private CustomControls.RJControls.RJButton set_relationships_b;
        private CustomControls.RJControls.RJButton rjButton1;
    }
}