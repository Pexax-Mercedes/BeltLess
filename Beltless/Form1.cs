using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.Threading;

namespace Beltless
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectDB_demo.ConnectAzure();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(() => showImage(100));
            th.Start();

            ConnectDB_demo c = new ConnectDB_demo();
            NName.Text = ConnectDB_demo.name;
            Weight.Text = ConnectDB_demo.weight;
            Speed.Text = ConnectDB_demo.speed;
            Car.Text = ConnectDB_demo.carModel;
            Position.Text = ConnectDB_demo.position;


        }
        
        public void showImage(int th)
        {
            for (int i = 1; i < 11; i++)
            {
                string myString = string.Format(@"C:\Users\HASAN NASER\Source\Repos\Beltless\Beltless\Resources\{0}.png", i);
                Thread.Sleep(th);
                pictureBox1.ImageLocation = myString;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
