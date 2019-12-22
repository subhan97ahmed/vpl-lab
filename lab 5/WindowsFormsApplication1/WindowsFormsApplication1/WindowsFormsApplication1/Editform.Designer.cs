namespace lab_5
{
    partial class Editform
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.edit_radioButton = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.del_radioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(93, 81);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(204, 160);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // edit_radioButton
            // 
            this.edit_radioButton.AutoSize = true;
            this.edit_radioButton.Location = new System.Drawing.Point(93, 289);
            this.edit_radioButton.Name = "edit_radioButton";
            this.edit_radioButton.Size = new System.Drawing.Size(43, 17);
            this.edit_radioButton.TabIndex = 1;
            this.edit_radioButton.TabStop = true;
            this.edit_radioButton.Text = "Edit";
            this.edit_radioButton.UseVisualStyleBackColor = true;
            this.edit_radioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // del_radioButton
            // 
            this.del_radioButton.AutoSize = true;
            this.del_radioButton.Location = new System.Drawing.Point(93, 312);
            this.del_radioButton.Name = "del_radioButton";
            this.del_radioButton.Size = new System.Drawing.Size(56, 17);
            this.del_radioButton.TabIndex = 1;
            this.del_radioButton.TabStop = true;
            this.del_radioButton.Text = "Delete";
            this.del_radioButton.UseVisualStyleBackColor = true;
            this.del_radioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "update data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Editform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.del_radioButton);
            this.Controls.Add(this.edit_radioButton);
            this.Controls.Add(this.listBox);
            this.Name = "Editform";
            this.Text = "Editform";
            this.Load += new System.EventHandler(this.Editform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.RadioButton edit_radioButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton del_radioButton;
        private System.Windows.Forms.Button button1;
    }
}