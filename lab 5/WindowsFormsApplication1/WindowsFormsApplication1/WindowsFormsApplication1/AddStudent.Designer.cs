namespace lab_5
{
    partial class AddStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpa_box = new System.Windows.Forms.TextBox();
            this.age_box = new System.Windows.Forms.TextBox();
            this.Gender_combobox = new System.Windows.Forms.ComboBox();
            this.add_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(231, 133);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(121, 20);
            this.name_box.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gpa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gender";
            // 
            // gpa_box
            // 
            this.gpa_box.Location = new System.Drawing.Point(231, 189);
            this.gpa_box.Name = "gpa_box";
            this.gpa_box.Size = new System.Drawing.Size(121, 20);
            this.gpa_box.TabIndex = 3;
            // 
            // age_box
            // 
            this.age_box.Location = new System.Drawing.Point(231, 161);
            this.age_box.Name = "age_box";
            this.age_box.Size = new System.Drawing.Size(121, 20);
            this.age_box.TabIndex = 2;
            // 
            // Gender_combobox
            // 
            this.Gender_combobox.FormattingEnabled = true;
            this.Gender_combobox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "None"});
            this.Gender_combobox.Location = new System.Drawing.Point(231, 221);
            this.Gender_combobox.Name = "Gender_combobox";
            this.Gender_combobox.Size = new System.Drawing.Size(121, 21);
            this.Gender_combobox.TabIndex = 4;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(192, 282);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 5;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.Add_button);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 438);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.Gender_combobox);
            this.Controls.Add(this.age_box);
            this.Controls.Add(this.gpa_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gpa_box;
        private System.Windows.Forms.TextBox age_box;
        private System.Windows.Forms.ComboBox Gender_combobox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button button2;
    }
}