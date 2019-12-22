namespace lab_5
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.del_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(283, 188);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(99, 23);
            this.edit_button.TabIndex = 0;
            this.edit_button.Text = "Edit student";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // del_button
            // 
            this.del_button.Location = new System.Drawing.Point(283, 217);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(99, 23);
            this.del_button.TabIndex = 0;
            this.del_button.Text = "Delete student";
            this.del_button.UseVisualStyleBackColor = true;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(283, 246);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(99, 23);
            this.search_button.TabIndex = 0;
            this.search_button.Text = "Search student";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Database";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 458);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.del_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label label1;
    }
}

