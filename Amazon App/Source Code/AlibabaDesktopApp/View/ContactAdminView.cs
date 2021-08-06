using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace AlibabaDesktopApp.View
{
    public partial class ContactAdminView : UserControl
    {
        string path = "";
        public ComboBox admins;
        public ContactAdminView()
        {
            InitializeComponent();
            admins = this.adminsBox;
        }

        private void backToHomeBtn_Click(object sender, EventArgs e)
        {
            VendorView.contactAdmin.Visible = false;
            VendorView.OptionContainer.Visible = true;

            Validator.CleanUpAll(this.bodyBox, this.subjectBox, this.vendorEmailBox, this.vendorPassBox);
            this.adminsBox.Text = "Select Admin";
            this.adminsBox.Items.Clear();
        }


        private void sendBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                NetworkCredential login = new NetworkCredential(vendorEmailBox.Text, vendorPassBox.Text); ;
                SmtpClient client = new SmtpClient("smtp.gmail.com");

                client.Port = Convert.ToInt32(587);
                client.EnableSsl = true;
                client.Credentials = login;

                MailMessage msg = new MailMessage { From = new MailAddress(vendorEmailBox.Text, "Amazon Vendor", Encoding.UTF8) };

                msg.To.Add(new MailAddress(this.adminsBox.SelectedItem.ToString()));
                msg.Subject = subjectBox.Text;
                msg.Body = bodyBox.Text;

                if (path.Length > 0)
                {
                    msg.Attachments.Add(new Attachment(path));
                }
                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;

                msg.Priority = MailPriority.Normal;
                msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallBack);
                string currentState = "Transferring";
                client.SendAsync(msg, currentState);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Allow Less secure apps From Your Gmail Setting\nIf receivers mail not exists then\nmail will not be delivered");
            }

        }

        private void attachBtn_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            if (opd.ShowDialog() == DialogResult.OK)
            {
                path = opd.FileName.ToString();
            }
        }

        private static void SendCompletedCallBack(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Mail sent Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
