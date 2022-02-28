using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Father
{
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();
        }

        private void button_done_Click(object sender, EventArgs e)
        {
            info.ActiveForm.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
