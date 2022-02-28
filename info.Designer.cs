namespace Father
{
    partial class info
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
            this.button_done = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button_done);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-7, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 559);
            this.panel1.TabIndex = 0;
            // 
            // button_done
            // 
            this.button_done.BackColor = System.Drawing.Color.Transparent;
            this.button_done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_done.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_done.ForeColor = System.Drawing.SystemColors.Control;
            this.button_done.Location = new System.Drawing.Point(787, 455);
            this.button_done.Name = "button_done";
            this.button_done.Size = new System.Drawing.Size(195, 63);
            this.button_done.TabIndex = 5;
            this.button_done.Text = "Done";
            this.button_done.UseVisualStyleBackColor = false;
            this.button_done.Click += new System.EventHandler(this.button_done_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Father.Properties.Resources.LLLLLL1;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.InitialImage = global::Father.Properties.Resources.Medicine_Tracker_Fixed;
            this.pictureBox1.Location = new System.Drawing.Point(168, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(717, 257);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(28, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(530, 248);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medicine Tracker Inc.\r\n\r\nBuilt by Dr.Ahmed Abdullaziz \r\n\r\nVersion 0.0.1 \r\nUpdates" +
    " coming along the way\r\nInitial release to save alot of time calculating meds\r\n\" " +
    "Work smarter not harder \"\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Info :";
            // 
            // info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 548);
            this.Controls.Add(this.panel1);
            this.Name = "info";
            this.Text = "info";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Button button_done;
    }
}