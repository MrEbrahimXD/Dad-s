using System;
using System.Net;
using System.Net.Mail;
using Father.Properties;

namespace Father
{
    public partial class Form1 : Form
    {

        


        public static List<String> amounts = new List<String>();

        public static BindingSource amountsBindingSource = new BindingSource();



        public Form1()
        {
            InitializeComponent();

        }

        private void button_calculations_Click(object sender, EventArgs e)
        {
            calculations form = new calculations();
            form.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button_database_Click(object sender, EventArgs e)
        {
            amount form_amount = new amount();
            form_amount.ShowDialog();
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            info form_info = new info();
            form_info.ShowDialog();
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            settings form_settings = new settings();
            form_settings.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (settings.SendEmail == true)
            {
                SmtpClient client = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,

                    Credentials = new NetworkCredential()
                    {
                        UserName = "pharmacy.alquaa@gmail.com",
                        Password = "SUDObash#1234"
                    }
                };
                MailAddress FromEmail = new MailAddress("pharmacy.alquaa@gmail.com", "Medicine Tracker Report");
                MailAddress ToEmail = new MailAddress(settings.email, "Pharmacy Balance Report");
                MailMessage Message = new MailMessage()
                {
                    From = FromEmail,
                    Subject = "Pharmacy Report",
                    Body = med_list.ToString(),

                };
                Message.To.Add(ToEmail);
                try
                {
                    client.Send(Message);
                    MessageBox.Show("Message Sent successfully", "Done");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something wrong with the connection\n\n" + ex.Message + "Error");
                }
            }
            else
            {

            }
            

        }
        
        public void med_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            amountsBindingSource.DataSource = amounts;

            med_list.DataSource = amountsBindingSource;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}