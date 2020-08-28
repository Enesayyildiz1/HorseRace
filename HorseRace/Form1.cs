using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatinsolauzaklik;
        int ikinciatinsolauzaklik;
        int ücüncüatinsolauzaklik;
        int dördüncüatinsolauzaklik;
        int besinciatinsolauzaklik;

        Random rastgele = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            birinciatinsolauzaklik = pictureBox1.Left;
            ikinciatinsolauzaklik = pictureBox2.Left;
            ücüncüatinsolauzaklik = pictureBox3.Left;
            dördüncüatinsolauzaklik = pictureBox4.Left;
            besinciatinsolauzaklik = pictureBox5.Left;

            int birinciatingenisligi = pictureBox1.Width;
            int ikinciatingenisligi = pictureBox2.Width;
            int ücüncüatingenisligi = pictureBox3.Width;
            int dorduncuatingenisligi = pictureBox4.Width;
            int besinciatingenisligi = pictureBox5.Width;

            pictureBox1.Left =pictureBox1 .Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);
            pictureBox4.Left = pictureBox4.Left + rastgele.Next(5, 15);
            pictureBox5.Left = pictureBox5.Left + rastgele.Next(5, 15);
            if ((birinciatinsolauzaklik >ikinciatinsolauzaklik +5 )&& (birinciatinsolauzaklik > ücüncüatinsolauzaklik  + 5) && (birinciatinsolauzaklik > dördüncüatinsolauzaklik  + 5) && (birinciatinsolauzaklik > besinciatinsolauzaklik  + 5))
            {
                label8.Text = "Liderlik birinci atta";
            }
            if ((ikinciatinsolauzaklik  < birinciatinsolauzaklik  + 5) && (ikinciatinsolauzaklik  > ücüncüatinsolauzaklik + 5) && (ikinciatinsolauzaklik  > dördüncüatinsolauzaklik + 5) && (ikinciatinsolauzaklik  > besinciatinsolauzaklik + 5))
            {
                label8.Text = "İkinci at liderliği ele geçirdi";
            }
            if ((ücüncüatinsolauzaklik  > ikinciatinsolauzaklik + 5) && (ücüncüatinsolauzaklik  > birinciatinsolauzaklik  + 5) && (ücüncüatinsolauzaklik  > dördüncüatinsolauzaklik + 5) && (ücüncüatinsolauzaklik  > besinciatinsolauzaklik + 5))
            {
                label8.Text = "Üçüncü at lider konumda";
            }
            if ((dördüncüatinsolauzaklik  > ikinciatinsolauzaklik + 5) && (dördüncüatinsolauzaklik  > ücüncüatinsolauzaklik + 5) && (dördüncüatinsolauzaklik  > birinciatinsolauzaklik  + 5) && (dördüncüatinsolauzaklik  > besinciatinsolauzaklik + 5))
            {
                label8.Text = "Dördüncü at hızlı bir atak ile öne geçti";
            }
            if ((besinciatinsolauzaklik  > ikinciatinsolauzaklik + 5) && (besinciatinsolauzaklik  > ücüncüatinsolauzaklik + 5) && (besinciatinsolauzaklik  > dördüncüatinsolauzaklik + 5) && (besinciatinsolauzaklik  > birinciatinsolauzaklik  + 5))
            {
                label8.Text = "Beşinci at iç kısımdan bir kartal gibi sıyrıldı";
            }

            if (pictureBox1 .Left +birinciatingenisligi >=label7.Left )
            {
                timer1.Enabled = false;
                label8 .Text ="Birinci At Yarışı Kazandı!!";
            }
            if (pictureBox2 .Left +ikinciatingenisligi >=label7 .Left )
            {
                timer1.Enabled = false;
                label8.Text = "İkinci At Yarışı Kazandı!!";
            }
            if (pictureBox3.Left +ücüncüatingenisligi >= label7.Left)
            {
                timer1.Enabled = false;
                label8.Text = "Ücüncü At Yarışı Kazandı!!";
            }
            if (pictureBox4 .Left  +dorduncuatingenisligi   >= label7.Left)
            {
                timer1.Enabled = false;
                label8.Text = "Dördüncü At Yarışı Kazandı!!";
            }
            if (pictureBox5 .Left +besinciatingenisligi   >= label7.Left)
            {
                timer1.Enabled = false;
                label8.Text = "Besinci At Yarışı Kazandı!!";
            }







        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatinsolauzaklik = pictureBox1.Left;
            ikinciatinsolauzaklik = pictureBox2.Left; 
            ücüncüatinsolauzaklik = pictureBox3.Left; 
            dördüncüatinsolauzaklik = pictureBox4.Left; 
            besinciatinsolauzaklik = pictureBox5.Left; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
          pictureBox1.Left= 0 ;
            pictureBox2.Left =0 ;
             pictureBox3.Left=0 ;
            pictureBox4.Left= 0 ;
             pictureBox5.Left=0 ;
            label8.Text = "";
        }
    }
}
