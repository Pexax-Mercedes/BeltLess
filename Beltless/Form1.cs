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

        String carmodel = "";
        int speed = 0;
        String name = "";
        double weight = 0.0;

        /// <summary>
        /// Dataları database'den form hazır olunca çekmesi olması lazım. Bu nedenle anakodların başlangıcını buradan başlattık.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Persons obje = new Persons();
            obje.Call_MyModel();
            groupBox1.Hide();
            groupBox2.Hide();
            carmodel = obje.Cars_List[0].Name.ToString();
            speed = obje.Situations_List[1].Speed;
            name = obje.person_List[1].Name;
            weight = obje.person_List[1].Weight;


        }

        /// <summary>
        /// Uygulamamnın çalışması için url kısmına ekli olan fotoğrafların dosya yolu eklenmesi lazım.
        /// </summary>
        /// <param name="th"></param>
        public void showImage(int th)
        {
            for (int i = 1; i < 11; i++)
            {
                string myString = string.Format(@"D:\Documents\Visual Studio 2017\Projets\Beltless\Beltless\Resources\{0}.png", i);
                Thread.Sleep(th);
                pictureBox1.ImageLocation = myString;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            Thread th = new Thread(() => showImage(100));
            th.Start();
            label7.Text = carmodel;
            label9.Text = speed.ToString() + "Km/s";
            label11.Text = name;
            Weight.Text = weight.ToString() + "Kg";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Show();
            getİnfo(speed);
            lbl_ivme.Text = acceleration_car.ToString() + "m/s^2";
            lbl_Koltukhızı.Text = speed_armchair.ToString() + "M/s";
            lbl_Dairesel.Text = circleAccelerationArmchair.ToString() + "m/s^2";
            lbl_DonmeHizi.Text = dete.ToString() + "M/s";
            Thread th = new Thread(() => showImage(200));
            th.Start();
        }

        double acceleration_car;
        double speed_armchair;
        double circleAccelerationArmchair;
        double dete;

        private void getİnfo(int array)
        {
            LinearMotion car = new LinearMotion();
            LinearMotion armchairLinearMotion = new LinearMotion();
            Circular_Motion armchairCircularMotion = new Circular_Motion();
            
                 acceleration_car = car.acceleration(0, array, 1);//arabanın ivmesi
                 speed_armchair = car.final_speed(acceleration_car, 0, 0.15);//koltuk track sonunda hız
                 circleAccelerationArmchair = armchairCircularMotion.acceleration(speed_armchair, 0.15);//dairesel ivme
                 dete = armchairCircularMotion.angel(speed_armchair, 0.2);//açma hesaplama
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        //public int[] getSpeed()
        //{
        //    int[] d = Conected.ConnectAzure();
        //    return d;
        //}


        //int[] d = getSpeed();
        //getİnfo(100);
    }
}