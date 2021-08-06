using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Parking_System
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-G40JEGJ;Initial Catalog=Parking_DB;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
            MainPanel.Height = button1.Height;

            twitter1.SendToBack();
            faceBook1.SendToBack();
            instagram1.SendToBack();

            homePage1.BringToFront();
            parkedCar1.SendToBack();
            parkNewCar1.SendToBack();
            unParkCar1.SendToBack();

        }
        //For dragging borderless frame
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "Parked Cars";
            sidePanel.Height = button3.Height;
            sidePanel.Top = button3.Top;

            twitter1.SendToBack();
            faceBook1.SendToBack();
            instagram1.SendToBack();

            parkedCar1.BringToFront();
            homePage1.SendToBack();
            parkNewCar1.SendToBack();
            unParkCar1.SendToBack();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //            System.Windows.Forms.Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Home";
            sidePanel.Height = button1.Height;
            sidePanel.Top = button1.Top;

            twitter1.SendToBack();
            faceBook1.SendToBack();
            instagram1.SendToBack();

            homePage1.BringToFront();
            parkedCar1.SendToBack();
            parkNewCar1.SendToBack();
            unParkCar1.SendToBack();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label3.Text = "System Developed by Nadir Hussain";
            sidePanel.Height = 0;

            twitter1.SendToBack();
            faceBook1.SendToBack();
            instagram1.SendToBack();

            homePage1.BringToFront();
            parkedCar1.SendToBack();
            parkNewCar1.SendToBack();
            unParkCar1.SendToBack();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "Park New Car";
            sidePanel.Height = button2.Height;
            sidePanel.Top = button2.Top;

            twitter1.SendToBack();
            faceBook1.SendToBack();
            instagram1.SendToBack();

            homePage1.SendToBack();
            parkedCar1.SendToBack();
            parkNewCar1.BringToFront();
            unParkCar1.SendToBack();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "UnPark Car";
            sidePanel.Height = button4.Height;
            sidePanel.Top = button4.Top;

            twitter1.SendToBack();
            faceBook1.SendToBack();
            instagram1.SendToBack();

            homePage1.SendToBack();
            parkedCar1.SendToBack();
            parkNewCar1.SendToBack();
            unParkCar1.BringToFront();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = "Facebook";
            sidePanel.Height = 0;

            twitter1.SendToBack();
            faceBook1.BringToFront();
            instagram1.SendToBack();

            homePage1.SendToBack();
            parkedCar1.SendToBack();
            parkNewCar1.SendToBack();
            unParkCar1.SendToBack();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Text = "Instagram";
            sidePanel.Height = 0;

            twitter1.SendToBack();
            faceBook1.SendToBack();
            instagram1.BringToFront();

            homePage1.SendToBack();
            parkedCar1.SendToBack();
            parkNewCar1.SendToBack();
            unParkCar1.SendToBack();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label3.Text = "Twitter";
            sidePanel.Height = 0;

            twitter1.BringToFront();
            faceBook1.SendToBack();
            instagram1.SendToBack();
            homePage1.SendToBack();
            parkedCar1.SendToBack();
            parkNewCar1.SendToBack();
            unParkCar1.SendToBack();


        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void faceBook1_Load(object sender, EventArgs e)
        {

        }

        private void Toggle_CheckedChanged(object sender, EventArgs e)
        {
            if (Toggle.Checked)
            {
                this.BackColor = Color.DarkCyan;
                homePage1.BackColor = Color.DarkCyan;
                faceBook1.BackColor = Color.DarkCyan;
                instagram1.BackColor = Color.DarkCyan;
                parkedCar1.BackColor = Color.DarkCyan;
                parkNewCar1.BackColor = Color.DarkCyan;
                twitter1.BackColor = Color.DarkCyan;
                unParkCar1.BackColor = Color.DarkCyan;

                darkLabel.Text = "Turn Light";
                
            }
            else {
                this.BackColor = DefaultBackColor;
                homePage1.BackColor = DefaultBackColor;
                faceBook1.BackColor = DefaultBackColor;
                instagram1.BackColor = DefaultBackColor;
                parkedCar1.BackColor = DefaultBackColor;
                parkNewCar1.BackColor = DefaultBackColor;
                twitter1.BackColor = DefaultBackColor;
                unParkCar1.BackColor = DefaultBackColor;
                darkLabel.Text = "Revert Color";


            }
        }
    }     
    }