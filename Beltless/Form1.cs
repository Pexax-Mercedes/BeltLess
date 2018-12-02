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
using hakaton;

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
           string k = ConnectionToAzure.ConnectAzure();
            textBox1.Text = k;
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

        public void getSpeed()
        {
            int[] d = Conected.ConnectAzure();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            getSpeed();
            getİnfo();
        }

        private void getİnfo(int[]array)
        {
            LinearMotion car = new LinearMotion();
            LinearMotion armchairLinearMotion = new LinearMotion();
            Circular_Motion armchairCircularMotion = new Circular_Motion();

            for (int i = 0; i < array.Length; i++)
            {
                double acceleration_car = car.acceleration(0, array[i], 1);
                double speed_armchair = car.final_speed(acceleration_car, 0, 0.15);
                double circleAccelerationArmchair = armchairCircularMotion.acceleration(speed_armchair, 15);
                double dete = armchairCircularMotion.angel(speed_armchair, 0.2);
            }
            
            
            
            

        }
    }
}
