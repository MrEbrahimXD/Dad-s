using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Father.Properties;


namespace Father
{
    
    public partial class settings : Form
    {
        public static string email;
        public static bool SendEmail;
        public settings()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            email = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            settings.ActiveForm.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendEmail = true;
   
            }
            else
            {
                SendEmail = false;
            }

        }
        

        private void settings_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = Settings.Default.SendEmail;
            textBox1.Text = Settings.Default.Email;

        }

        private void settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Email = textBox1.Text;
            Settings.Default.SendEmail = checkBox1.Checked;
            Settings.Default.Save();

        }
    }
}
