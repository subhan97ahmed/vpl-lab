namespace lab_5
{
    partial class search
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
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.sea_button = new System.Windows.Forms.Button();
            this.age_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.gender_label = new System.Windows.Forms.Label();
            this.gpa_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // search_textBox
            // 
            this.search_textBox.Location = new System.Drawing.Point(121, 87);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(100, 20);
            this.search_textBox.TabIndex = 0;
            // 
            // sea_button
            // 
            this.sea_button.Location = new System.Drawing.Point(146, 113);
            this.sea_button.Name = "sea_button";
            this.sea_button.Size = new System.Drawing.Size(75, 23);
            this.sea_button.TabIndex = 1;
            this.sea_button.Text = "search";
            this.sea_button.UseVisualStyleBackColor = true;
            this.sea_button.Click += new System.EventHandler(this.Sea_button_Click);
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Location = new System.Drawing.Point(26, 62);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(0, 13);
            this.age_label.TabIndex = 2;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(26, 39);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(0, 13);
            this.name_label.TabIndex = 2;
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.Location = new System.Drawing.Point(26, 103);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(0, 13);
            this.gender_label.TabIndex = 2;
            // 
            // gpa_label
            // 
            this.gpa_label.AutoSize = true;
            this.gpa_label.Location = new System.Drawing.Point(26, 82);
            this.gpa_label.Name = "gpa_label";
            this.gpa_label.Size = new System.Drawing.Size(0, 13);
            this.gpa_label.TabIndex = 2;
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 223);
            this.Controls.Add(this.gpa_label);
            this.Controls.Add(this.gender_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.sea_button);
            this.Controls.Add(this.search_textBox);
            this.Name = "search";
            this.Text = "search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Button sea_button;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label gender_label;
        private System.Windows.Forms.Label gpa_label;
    }
}