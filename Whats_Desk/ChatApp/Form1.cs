using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class Form1 : Form
    {
        public List<WhatsAppContactView> contacts = new List<WhatsAppContactView>();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WhatsAppContactView contact1 = new WhatsAppContactView();
            WhatsAppContactView contact2 = new WhatsAppContactView();
            WhatsAppContactView contact3 = new WhatsAppContactView();
            WhatsAppContactView contact4 = new WhatsAppContactView();
            WhatsAppContactView contact5 = new WhatsAppContactView();
            WhatsAppContactView contact6 = new WhatsAppContactView();
            WhatsAppContactView contact7 = new WhatsAppContactView();
            WhatsAppContactView contact8 = new WhatsAppContactView();
            WhatsAppContactView contact9 = new WhatsAppContactView();
            WhatsAppContactView contact10 = new WhatsAppContactView();

            contact1.contactImage.Image = Image.FromFile(@"E:\Eid Pics 2k20\Friends(IBA)\IMG20200124150207.jpg");
            contact1.contactName.Text = "Zeeshan SIBAU";
            contact1.lastMessage.Text = "He has already applied";
            contact1.lastMessageTime.Text = "9:12PM";

            contact2.contactImage.Image = Image.FromFile(@"E:\Eid Pics 2k20\Friends(IBA)\IMG20191116202653.jpg");
            contact2.contactName.Text = "Noman Aijaz";
            contact2.lastMessage.Text = "I can do in Android";
            contact2.lastMessageTime.Text = "8:09PM";

//            contact3.contactImage.Image = Image.FromFile(@"");
            contact3.contactName.Text = "Zahid Hussain";
            contact3.lastMessage.Text = "I am about to leave";
            contact3.lastMessageTime.Text = "7:12PM";
            
            contact4.contactImage.Image = Image.FromFile(@"E:\Eid Pics 2k20\Friends(IBA)\IMG20191117133203.jpg");
            contact4.contactName.Text = "Rizwan";
            contact4.lastMessage.Text = "Hans is outside bro";
            contact4.lastMessageTime.Text = "7:05PM";

            //contact5.contactImage.Image = Image.FromFile(@"C:\Users\nadir\Downloads\Malook.jpeg");
            //contact5.contactName.Text = "Malook";
            //contact5.lastMessage.Text = "Ha Uho natho hale anja";
            //contact5.lastMessageTime.Text = "6:45PM";

            //contact6.contactImage.Image = Image.FromFile(@"C:\Users\nadir\Downloads\IMG20191003172614.jpg");
            //contact6.contactName.Text = "Hans Raj";
            //contact6.lastMessage.Text = "Send kayae tho check kr";
            //contact6.lastMessageTime.Text = "6:30PM";
            
            //contact7.contactImage.Image = Image.FromFile(@"C:\Users\nadir\Downloads\Faizan.jpeg");
            //contact7.contactName.Text = "M Faizan";
            //contact7.lastMessage.Text = "Yar Hostel ka kya karain?";
            //contact7.lastMessageTime.Text = "6:02PM";
            
            //contact8.contactImage.Image = Image.FromFile(@"C:\Users\nadir\Downloads\Dheera.jpeg");
            //contact8.contactName.Text = "Dheeraj";
            //contact8.lastMessage.Text = "Jaani Machine learning thi";
            //contact8.lastMessageTime.Text = "5:15PM";
            
            contact9.contactImage.Image = Image.FromFile(@"E:\Eid Pics 2k20\Friends(IBA)\IMG20191116202155.jpg");
            contact9.contactName.Text = "Abidullah";
            contact9.lastMessage.Text = "Boss VP ki lab to send karo";
            contact9.lastMessageTime.Text = "4:47PM";

//            contact10.contactImage.Image = Image.FromFile(@"");
            contact10.contactName.Text = "Parvez";
            contact10.lastMessage.Text = "Bhai 300 Jazzcash kiye hain";
            contact10.lastMessageTime.Text = "4:00PM";



            contacts.Add(contact1);
            contacts.Add(contact2);
            contacts.Add(contact3);
            contacts.Add(contact4);
            contacts.Add(contact5);
            contacts.Add(contact6);
            contacts.Add(contact7);
            contacts.Add(contact8);
            contacts.Add(contact9);
            contacts.Add(contact10);

            int x_axis = 4, y_axis = 109;
            
            foreach (WhatsAppContactView c in contacts) {
                c.SetBounds(x_axis,y_axis,c.Width,c.Height);
                y_axis += c.Height+5;
                this.WidgetHolder.Controls.Add(c);
            }
        }

        #region More options
        private void moreOptionsBtn_Click(object sender, EventArgs e)
        {
            
        }
        #endregion
    }
}
