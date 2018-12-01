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
        int num = 1;

        private void button1_Click(object sender, EventArgs e)
        {
             ConnectionToAzure.ConnectAzure(listBox1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(() => showImage(100));
            th.Start();
        }
        
        public void showImage(int th)
        {
            for (int i = 1; i < 11; i++)
            {
                string myString = string.Format(@"D:\Documents\Visual Studio 2017\Projets\Beltless\Beltless\Resources\{0}.png", i);
                Thread.Sleep(th);
                pictureBox1.ImageLocation = myString;
            }
        }
    }
}
