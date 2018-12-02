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
             Thread th = new Thread(() => showImage(100));
             th.Start();
            CarModel.Text = carmodel;
            Speed.Text = speed.ToString();
            Name1.Text = name;
            Weight.Text = weight.ToString();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
