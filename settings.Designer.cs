namespace Father
{
    partial class settings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-7, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 555);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(826, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(211, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 507);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(416, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.Silver;
            this.checkBox1.Location = new System.Drawing.Point(32, 503);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 29);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Send Email";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings :";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 548);
            this.Controls.Add(this.panel1);
            this.Name = "settings";
            this.Text = "settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.settings_FormClosing);
            this.Load += new System.EventHandler(this.settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private CheckBox checkBox1;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
    }
}