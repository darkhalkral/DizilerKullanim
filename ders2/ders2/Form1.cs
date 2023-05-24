using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] notlar = { "a", "z", "30", "b", "35", "1", "b" };
            for(int i = 0; i < notlar.Length; i++)
            {
                listBox1.Items.Add(notlar[i].ToString());
            }
            Array.Sort(notlar);
            for (int k =0; k<notlar.Length; k++)
            {
                listBox2.Items.Add(notlar[k].ToString());
            }
        }//Array.Sort kullanımını gösterir.

        private void button2_Click(object sender, EventArgs e)
        {
            int[,,] dizi = new int[10, 20, 30];
            MessageBox.Show(dizi.Rank.ToString());
        }//dizi.Rank komutununun kullanımını gösteririr.

        private void button3_Click(object sender, EventArgs e)
        {
            string[] harfler = { "a", "b", "c" };
            Array.Reverse(harfler);
            MessageBox.Show(harfler[2]);
        }//Reverse kullanımını gösterir.

        private void button4_Click(object sender, EventArgs e)
        {
            string[] harfler = { "a", "b", "c", "d"};
            Array.Reverse(harfler, 1, 2);
            for (int i = 0; i < harfler.Length; i++)
            {
                listBox1.Items.Add(harfler[i].ToString());
            }
        }//Reverse'in diğer kullanımını gösterir

        private void button5_Click(object sender, EventArgs e)
        {
            int[,] dizi = {{Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("1.Değer Giriniz")), Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("2.Değer Giriniz")) } };
            MessageBox.Show(dizi[0,0].ToString()+" , "+ dizi[0, 1].ToString());
        }//boyutlu dizilerde eleman göstermek.

        private void button6_Click(object sender, EventArgs e)
        {
            string[] sehir = { "izmir", "istanbul", "Ankara", "Adana", "Antalya", "Bursa", "Isparta" };
            string[] ogretmen = { "ali", "beyhan", "ceyhun", "deniz", "emre", "firdevs", "gözde" };
            Random rastgele = new Random();
            for (int i = sehir.Length-1; i >= 0; i--)
            {
                a:
                int sayi = rastgele.Next(0, 7);
                if (sehir[sayi] != null)
                {
                    listBox1.Items.Add(ogretmen[i] + " " + sehir[sayi]);
                    Array.Clear(sehir, sayi, 1);
                }
                else
                {
                    goto a;
                }
            }
        }//2 dizinin elemanlarının rastgele şekilde tekrarsız eşlenmesini gösterir.
    }
}
