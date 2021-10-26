/*****************************************************************************************************************************************************************************
**                                                  SAKARYA ÜNİVERSİTESİ
**                                         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                                             BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                                            NESNEYE DAYALI PROGRAMLAMA DERSİ
**                                                2020-2021 BAHAR DÖNEMİ
**
**                                           ÖDEV NUMARASI...........: PROJE
**                                           ÖĞRENCİ ADI.............: İLAYDA YILMAZ
**                                           ÖĞRENCİ NUMARASI........: B201210057
**                                           DERSİ ALDIĞI GRUP.......: 1 C GRUBU
**
****************************************************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meyve_oyunu_ndp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 60;
        private void timer1_tick(object sender, EventArgs e)
        {
            if(sayac>0)
            {
                timer1.Interval = 1000;
                sayac--;
                label1.Text = sayac.ToString();
                button1.Enabled = false;
            }
            else
            {
                timer1.Stop();
                button1.Enabled =true;
                button2.Enabled = false;
                button3.Enabled = false;
                timer1.Stop();
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop(); //Program açıldığında yeni oyuna basmadan her şey disable başlar.
            button2.Enabled = false;
            button3.Enabled = false;
            
        }
        int a;
        Random random = new Random();
        private void button1_click(object sender, EventArgs e)
        {
            timer1.Start();
            a = random.Next(0, 5);
            pictureBox1.Image = ımageList1.Images[a]; //pictureboxa random bir resim atadım.
        }
        private void button2_click(object sender, EventArgs e) //narenciye butonu
        {
            
            if (a==3) //resim greyfurtsa çalışır
            {
                Greyfurt greyfurt = new Greyfurt();
                greyfurt.VitaminA();  //VitaminA metodunu çağırdım.
                listBox1.Items.Add(" greyfurt vitamin a değeri:" + greyfurt.VitaminA()); //Listboxa yazdırdım.
                greyfurt.VitaminC();
                listBox1.Items.Add(" greyfurt vitamin c değeri:" + greyfurt.VitaminC()); //Listboxa yazdırdım.
                greyfurt.Pure();
                listBox2.Items.Add("greyfurt pure değeri:" + greyfurt.Pure());
            }
            if(a==4 ) //resim mandalinaysa çalışır
            {

                Mandalina mandalina = new Mandalina();
                mandalina.VitaminA();  //VitaminA metodunu çağırdım.
                listBox1.Items.Add(" mandalina vitamin a değeri:" + mandalina.VitaminA()); //Listboxa yazdırdım.
                mandalina.VitaminC();  //VitaminC metodunu çağırdım.
                listBox1.Items.Add(" mandalina vitamin c değeri:" + mandalina.VitaminC()); //Listboxa yazdırdım.
                mandalina.Pure();
                listBox2.Items.Add("mandalina püre değeri:" + mandalina.Pure());
              
            }
            if(a==5) //resim portakalsa çalışır
            {
               
                Portakal portakal = new Portakal();
                portakal.VitaminA();  //VitaminA metodunu çağırdım.
                listBox1.Items.Add(" portakal vitamin a değeri:" + portakal.VitaminA()); //Listboxa yazdırdım.
                portakal.VitaminC();  //VitaminC metodunu çağırdım.
                listBox1.Items.Add(" portakalvitamin c değeri:" + portakal.VitaminC()); //Listboxa yazdırdım.
                portakal.Pure();
                listBox2.Items.Add("portakal püre değeri:" + portakal.Pure());
                
            }
            if(a==3 || a==4||a==5) // resim greyfurt mandalina ya da portakal ise çalışır.
            {
                a = random.Next(0, 5);
                pictureBox1.Image = ımageList1.Images[a];
            }
        }
        private void button3_click(object sender, EventArgs e) //katı meyve butonu
        {
            if (a==0)//resim armutsa çalışır
            {
                Armut armut = new Armut(); // Armut classından armut isimli nesne oluşturdum.
                armut.VitaminA(); //VitaminA metodunu çağırdım.
                listBox1.Items.Add(" armut vitamin a değeri:" + armut.VitaminA()); //Listboxa yazdırdım.
                armut.VitaminC(); //VitaminC metodunu çağırdım.
                listBox1.Items.Add(" armut vitamin c değeri:" +armut.VitaminC()); //Listboxa yazdırdım.
                armut.Pure();
                listBox2.Items.Add("armut püre değeri:" + armut.Pure());
           
            }
            if(a==1)//resim çilekse çalışır
            {
                Çilek çilek = new Çilek();
                çilek.VitaminA();  //VitaminA metodunu çağırdım.
                listBox1.Items.Add(" çilek vitamin a değeri:" + çilek.VitaminA()); //Listboxa yazdırdım.
                çilek.VitaminC();  //VitaminC metodunu çağırdım.
                listBox1.Items.Add(" çilek vitamin c değeri:" + çilek.VitaminA()); //Listboxa yazdırdım.
                çilek.Pure();
                listBox2.Items.Add("çilek püre değeri:" + çilek.Pure());
               
            }
            if(a==2)//resim elmaysa çalışır.
            {
               
                Elma elma = new Elma();
                elma.VitaminA();  //VitaminA metodunu çağırdım.
                listBox1.Items.Add(" elma vitamin a değeri:" + elma.VitaminA()); //Listboxa yazdırdım.
                elma.VitaminC();  //VitaminC metodunu çağırdım.
                listBox1.Items.Add(" elma vitamin c değeri:" + elma.VitaminA()); //Listboxa yazdırdım.
                elma.Pure();
                listBox2.Items.Add("elma püre değeri:" + elma.Pure());
            }
            if (a==0||a==1||a==2) // resim armut elma ya da çilek ise çalışır
            {
                a = random.Next(0, 5);
                pictureBox1.Image = ımageList1.Images[a];
            }
        }

        private void button4_click(object sender, EventArgs e) //yeni oyun butonu
        {
            if(sayac>=0) // süre 0dan büyükse buton çalışmaz
            {
                button4.Enabled = false;
            }
            else //yeni oyunu başlatır.
            {
                listBox1.Items.Clear(); //listboxlar temizlenir.
                listBox2.Items.Clear();

                timer1.Start();  //süreyi başlatır.
                a = random.Next(0, 5);
                pictureBox1.Image = ımageList1.Images[a]; //random resim atar.
                button2.Enabled = true;  //butonlar aktif olur.
                button3.Enabled = true;
            }
          
        }
    }
}
