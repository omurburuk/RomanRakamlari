using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] sayısaldeger = { 1000, 500, 100, 50, 10, 5, 1 };
        char[] romansaldeger = { 'M', 'D', 'C', 'L', 'X', 'V', 'I' };
        private void button1_Click(object sender, EventArgs e)
        {
            string textekisayi = textBox1.Text;
            int kontrol=0;
            for (int p = 0; p < romansaldeger.Length; p++)
            {
                if (textekisayi[1] == romansaldeger[p])
                    kontrol = 1;// Bu karşılaştırma sayının roman sayısı mı yoksa 10 tabanında sayımı 
                // olduğunu kontrol eder
                // işlemleri buna göre yapıcaz
            }
            if(kontrol==1)
                textBox2.Text = Convert.ToString(Romanisayiya(textekisayi));
            else
                Sayiyiromana(Convert.ToInt32(textekisayi));
        }
        public int Romanisayiya(string roman)
        {
            textBox2.Text = "";
            int[] romaninsayiya = new int[roman.Length] ;
            int sayi = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                for (int j = 0; j < romansaldeger.Length; j++)
                {
                    if (roman[i] == romansaldeger[j])// gelen roman sayı değerleri ile roman sayı
                    {//dizimizdeki değerler karşılaştırılıp sayısal karşılıkları aynı indis değeri
                        romaninsayiya[i] = sayısaldeger[j];//ile sayısaldeger dizisinden alınır.
                    }// ve değerlendirilmek üzere dizimize ayrı ayrı atılır.
                }
            }
            for (int k = 0; k < romaninsayiya.Length; k++)
            {
                if (k != romaninsayiya.Length-1)
                {
                    if (romaninsayiya[k] < romaninsayiya[k + 1])
                        sayi -= romaninsayiya[k];//dizimiz değerlendirmeye tabi tutulur sıralı bir 
                    else// karşılaştırma yaptığımız için bize kolaylık sağlar 
                        sayi += romaninsayiya[k]; // değerlerin büyüklük küçüklüğüne göre toplanır
                }// yada çıkarılır .
                else sayi += romaninsayiya[k];
            }
            return sayi;
        }
        public  void  Sayiyiromana(int sayi)
        {
            textBox2.Text = "";
            int enuzunromansayisiuzunlugu = 15;
            for (int u = 0; u < enuzunromansayisiuzunlugu; u++)
            {// en fazla 15 kez döner döngümüz en uzun roman sayısı ...
                if (sayi >= 1000)
                {
                    sayi -= 1000;
                    textBox2.Text+= "M";
                }
                else if (sayi >= 900)
                {
                    sayi -= 900; ;
                    textBox2.Text += "CM";
                }
                else if (sayi >= 500)
                {
                    sayi -= 500;
                    textBox2.Text += "D";
                }
                else if (sayi >= 400)
                {
                    sayi -= 400;
                    textBox2.Text += "CD";
                }
                else if (sayi >= 100)
                {
                    sayi -= 100;
                    textBox2.Text += "C";
                }
                else if (sayi >= 90)
                {
                    sayi -= 90;
                    textBox2.Text += "XC";
                }
                else if (sayi >= 50)
                {
                    sayi -= 50;
                    textBox2.Text += "L";
                }
                else if (sayi >= 40)
                {
                    sayi -= 40;
                    textBox2.Text += "XL";
                }
                else if (sayi >= 10)
                {
                    sayi -= 10;
                    textBox2.Text += "X";
                }
                else if (sayi >= 9)
                {
                    sayi -= 9;
                    textBox2.Text += "IX";
                }
                else if (sayi >= 5)
                {
                    sayi -= 5;
                    textBox2.Text += "V";
                }
                else if (sayi >= 4)
                {
                    sayi -= 4;
                    textBox2.Text += "IV";
                }
                else if (sayi >= 1)
                {
                    sayi -= 1;
                    textBox2.Text += "I";
                }
                if (sayi == 0)// sayıdan çıkarılacak bişey kalmadığında döngüden çıkar
                {
                    break;
                }
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
      
    }
}
