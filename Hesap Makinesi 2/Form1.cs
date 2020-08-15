using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        string girilensayi,islem="", yeniislem = "";
        double sayiislem, hesap;

        public string sayi(string s1)
        {
            
            string sonuc;
            sonuc = s1.ToString();
            if (textBox1.Text=="0" || girilensayi=="")
            {
                textBox1.Text = sonuc;
                girilensayi = sonuc;                
                btnCarp.Enabled = true;
                btnArti.Enabled = true;
                btnEksi.Enabled = true;
                btnBol.Enabled = true;
                btnEsittir.Enabled = true;
            }
            else
            {
                girilensayi += sonuc;
                textBox1.Text += sonuc;
                
            }
            return sonuc;

        }

        //Sayı girişi
        private void btn0_Click(object sender, EventArgs e)
        {
            sayi("0");
            sayiislem = Convert.ToDouble(textBox1.Text);
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            sayi("1");
            sayiislem = Convert.ToDouble(textBox1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            sayi("2");
            sayiislem = Convert.ToDouble(textBox1.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            sayi("3");
            sayiislem = Convert.ToDouble(textBox1.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            sayi("4");
            sayiislem = Convert.ToDouble(textBox1.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            sayi("5");
            sayiislem = Convert.ToDouble(textBox1.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            sayi("6");
            sayiislem = Convert.ToDouble(textBox1.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            sayi("7");
            sayiislem = Convert.ToDouble(textBox1.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            sayi("8");
            sayiislem = Convert.ToDouble(textBox1.Text);
        }

        

        private void btn9_Click(object sender, EventArgs e)
        {
            sayi("9");
            sayiislem = Convert.ToDouble(textBox1.Text);
        }

        private void btnArti_Click(object sender, EventArgs e)
        {
            
            if (girilensayi!="")
            {
                yeniislem = "+";
                switch (islem)
                {
                    case "":
                        hesap = sayiislem;
                        textBox1.Text = hesap.ToString();
                        textBox2.Text += girilensayi + " + ";
                        girilensayi = "";

                        break;
                    case "+":
                        hesap += sayiislem;
                        textBox1.Text = hesap.ToString();
                        textBox2.Text += girilensayi + " + ";
                        girilensayi = ""; break;
                    case "-":
                        hesap -= sayiislem;
                        textBox1.Text = hesap.ToString();
                        textBox2.Text += girilensayi + " + ";
                        girilensayi = ""; break;
                    case "x":
                        hesap = hesap * sayiislem;
                        textBox1.Text = hesap.ToString();
                        textBox2.Text += girilensayi + " + ";
                        girilensayi = ""; break;
                    case "/":
                        hesap = hesap / sayiislem;
                        textBox1.Text = hesap.ToString();
                        textBox2.Text += girilensayi + " + ";
                        girilensayi = ""; break;                    
                }
                islem = yeniislem;                         
                
            }
            

        }


        private void btnEksi_Click(object sender, EventArgs e)
        {

            if (girilensayi != "")
            {
                yeniislem = "-";
                switch (islem)
                {
                    case "":
                        hesap = sayiislem;
                        textBox1.Text = hesap.ToString();
                        textBox2.Text += girilensayi + " - ";
                        girilensayi = "";

                        break;
                    case "+":
                        hesap += sayiislem;
                        textBox1.Text = hesap.ToString();
                        textBox2.Text += girilensayi + " - ";
                        girilensayi = ""; break;
                    case "-":
                        hesap -= sayiislem;
                        textBox1.Text = hesap.ToString();
                        textBox2.Text += girilensayi + " - ";
                        girilensayi = ""; break;
                    case "x":
                        hesap = hesap * sayiislem;
                        textBox1.Text = hesap.ToString();
                        textBox2.Text += girilensayi + " - ";
                        girilensayi = ""; break;
                    case "/":
                        hesap = hesap / sayiislem;
                        textBox1.Text = hesap.ToString();
                        textBox2.Text += girilensayi + " - ";
                        girilensayi = ""; break;

                }
                islem = yeniislem;

            }

        }


        private void btnCarp_Click(object sender, EventArgs e)
        {
            if (girilensayi != "")
            {
                yeniislem = "x";
                switch (islem)
                {
                    case "":
                        hesap = sayiislem;
                        textBox1.Text = hesap.ToString();
                        textBox2.Text += girilensayi + " x ";
                        girilensayi = "";

                        break;
                    case "+":
                        hesap += sayiislem;
                        textBox1.Text = hesap.ToString();
                        textBox2.Text += girilensayi + " x ";
                        girilensayi = ""; break;
                    case "-":
                        hesap -= sayiislem;
                        textBox1.Text = hesap.ToString();
                        textBox2.Text += girilensayi + " x ";
                        girilensayi = ""; break;
                    case "x":
                        hesap = hesap * sayiislem;
                        textBox1.Text = hesap.ToString();
                        textBox2.Text += girilensayi + " x ";
                        girilensayi = ""; break;
                    case "/":
                        hesap = hesap / sayiislem;
                        textBox1.Text = hesap.ToString();
                        textBox2.Text += girilensayi + " x ";
                        girilensayi = ""; break;
                }
                islem = yeniislem;

            }
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            if (girilensayi != "")
            {
                yeniislem = "/";
                switch (islem)
                {
                    case "":
                        hesap = sayiislem;
                        textBox1.Text = hesap.ToString();
                        textBox2.Text += girilensayi + " / ";
                        girilensayi = "";

                        break;
                    case "+":
                        hesap += sayiislem;
                        textBox1.Text = hesap.ToString();
                        textBox2.Text += girilensayi + " / ";
                        girilensayi = ""; break;
                    case "-":
                        hesap -= sayiislem;
                        textBox1.Text = hesap.ToString();
                        textBox2.Text += girilensayi + " / ";
                        girilensayi = ""; break;
                    case "x":
                        hesap = hesap * sayiislem;
                        textBox1.Text = hesap.ToString();
                        textBox2.Text += girilensayi + " / ";
                        girilensayi = ""; break;
                    case "/":
                        hesap = hesap / sayiislem;
                        textBox1.Text = hesap.ToString();
                        textBox2.Text += girilensayi + " / ";
                        girilensayi = ""; break;
                }
                islem = yeniislem;

            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            if (textBox2.Text=="")
            {
                textBox1.Text = "0";
                textBox2.Text = "";
                girilensayi = "";
                btnCarp.Enabled = true;
                btnArti.Enabled = true;
                btnEksi.Enabled = true;
                btnBol.Enabled = true;
                btnEsittir.Enabled = true;
            }
            else
            {
                textBox1.Text = "0";
                girilensayi = "";
                
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            girilensayi = "";
            btnCarp.Enabled = true;
            btnArti.Enabled = true;
            btnEksi.Enabled = true;
            btnBol.Enabled = true;
            btnEsittir.Enabled = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (hesap!= Convert.ToDouble(textBox1.Text) || girilensayi!="")
            { 
                string sil = textBox1.Text;
                textBox1.Text = sil.Substring(0, sil.Length - 1);
                if (sayiislem.ToString().Length>1)
                {
                    sayiislem = Convert.ToDouble(textBox1.Text);
                }
                else
                {
                    sayiislem = 0;
                }
                
                girilensayi = textBox1.Text;
            }
            
            
        }

        private void btndegistir_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf("-")==-1)
            {
                
                textBox1.Text = "-" + textBox1.Text;
                sayiislem = Convert.ToDouble(textBox1.Text);
                girilensayi = textBox1.Text;
            }
            else
	        {
                
                textBox1.Text = textBox1.Text.Substring(1,textBox1.Text.Length-1);
                sayiislem = Convert.ToDouble(textBox1.Text);
                girilensayi = textBox1.Text;
            }

           

           


            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            if (girilensayi != "")
            {
                
                switch (islem)
                {
                    case "":
                        hesap = sayiislem;
                        textBox1.Text = hesap.ToString();
                        textBox2.Text += girilensayi + "=";
                        girilensayi = "";

                        break;
                    case "+":
                        hesap += sayiislem;
                        textBox1.Text = hesap.ToString();
                        textBox2.Text += girilensayi + "=";
                        girilensayi = ""; break;
                    case "-":
                        hesap -= sayiislem;
                        textBox1.Text = hesap.ToString();
                        textBox2.Text += girilensayi + "=";
                        girilensayi = ""; break;
                    case "x":
                        hesap = hesap * sayiislem;
                        textBox1.Text = hesap.ToString();
                        textBox2.Text += girilensayi + "=";
                        girilensayi = ""; break;
                    case "/":
                        hesap = hesap / sayiislem;
                        textBox1.Text = hesap.ToString();
                        textBox2.Text += girilensayi + "=";
                        girilensayi = ""; break;
                    case "=":

                        textBox1.Text = hesap.ToString();
                        textBox2.Text = hesap + girilensayi + "=";
                        girilensayi = hesap.ToString() + "+"; break;

                }
                islem = "";
                girilensayi = "";
                textBox2.Text = "";
                btnCarp.Enabled = false;
                btnArti.Enabled = false;
                btnEksi.Enabled = false;
                btnBol.Enabled = false;
                btnEsittir.Enabled = false;
            }
        }



        private void btnVirgul_Click(object sender, EventArgs e)
        {
            
            string[] vrgl=textBox1.Text.Split(',');
            if (vrgl.Length<=1)
            {
                textBox1.Text += ",";
                girilensayi += ",";
            }
            
            
        }






        // form sonu
    }
}
