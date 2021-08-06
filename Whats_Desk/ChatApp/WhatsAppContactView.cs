using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class WhatsAppContactView : UserControl
    {
        public Label contactName;
        public Label lastMessage;
        public Label lastMessageTime;
        public PictureBox contactImage;

        public WhatsAppContactView()
        {
            InitializeComponent();
            contactImage = contactImageBox;
            contactName = contactNameLabel;
            lastMessage = firstMessage;
            lastMessageTime = lastMsgTimeLabel;
            
        }
    }
}
