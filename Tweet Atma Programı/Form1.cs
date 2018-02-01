using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tweet_Atma_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;//sayacımız 0
        private void BtnTweetAt_Click(object sender, EventArgs e)//Button1 Tıklandığı zaman aşağıdaki olaylar gerçekleşsin
        {
            if (checkBox1.Checked == false)//checkBox1'in gürünürlüğü pasif olsun
            {
                foreach (HtmlElement element in webBrowser1.Document.All)//burada webBrowser1'içindeki bütün dökümanları tek tek döndür elemanları ata dedik
                {
                    if (element.GetAttribute("classname") == "t1-form tweet-form condensed")//Eğer class'ı eşitse buna "t1-form tweet-form condensed yani açılmadıysa sonra burayı nereden alıyoruz ("t1-form tweet-form condensed) Twitterin yazı yazdığımız yerin içine tıklamıyoruz üstüne boş bir yere tıklıyoruz FormClass tan alıyoruz sonra
                    {
                        element.SetAttribute("classname", "t1-form tweet-form");//Burada classname'yi SetAttribute ile değiştiriyoruz burayı ise "t1-form tweet-form"
                    }
                    if (element.Id == "tweet-box-home-timeline")//1. Sırası ile eğer elementin İd'si bu ise burayı nereden alıyoruz twitterin yazı yazma yerinde öğeyi incele diyoruz Oradan İd'yi alıyoruz istersekde Class'ı alırız genelde İd alınıyor
                    {
                        element.InnerText = RichMetin.Text;//Elementin İçine richTextBox1'İN tEXT'İNİ YAZ
                    }
                    if (element.GetAttribute("classname") == "button-text tweeting-text")//Eğer element.GetAttributesi eşit ise butonun class'ına Burası Twitterin yazma yerine  Tweetle bölümüne sağ tış kaynağı görüntüle diyoruz ve "tweet-box-home-timeline alıyoruz 
                    {
                        element.InvokeMember("click");//Burası tıkla demek
                    }

                }
            
            }
            else
            {
                RichMetin.Enabled = false;//sayaç çalıştığı sürece öğelerimin aktifliği pasif olsun
                TxtZaman.Enabled = false;
                BtnTweetAt.Enabled = false;
                checkBox1.Enabled = false;


                sayac = int.Parse(TxtZaman.Text);//Sayaç burada inte çeviriyoruz
                timer1.Start();//Timer çalışsın

            }
     }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)//Eğer checkBox1.Checked'i seçili ise görünümü aktif olsun 
            {
                TxtZaman.Visible = true;//Texbox'ımızda aktif olsun
            }
            else//eğer değil ise
            {
                TxtZaman.Visible = false;//TekxBox'ımız kapalı olsun
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;//sayaç -- azalsın
            TxtZaman.Text = sayac + "Kaldı";//TeBox'ta sayaçın ne kadar kaldığını göstersin yani3kaldı,2 kaldı,1kaldı gibi + "Kaldı";
            if (sayac == 0)//sayaç 0 olduğunda ise 
            {
                foreach (HtmlElement element in webBrowser1.Document.All)
                {
                    if (element.GetAttribute("classname") == "t1-form tweet-form condensed")
                    {
                        element.SetAttribute("classname", "t1-form tweet-form");
                    }
                    if (element.Id == "tweet-box-home-timeline")
                    {
                        element.InnerText = RichMetin.Text;
                    }
                    if (element.GetAttribute("classname") == "button-text tweeting-text")
                    {
                        element.InvokeMember("click");
                    }

                }
                RichMetin.Enabled = true;
                TxtZaman.Enabled = true;
                BtnTweetAt.Enabled = true;
                checkBox1.Enabled = true;

                timer1.Stop();
            }
        }
    }
}
//İlk önce Twitter Url Adresimizi WbBrowser'in Url kısmına yazıyoruz 
//Manage Nuget Packes Bölümünden search arama bölümünden Tweet Sharp aratıyoruz ve ekliyoruz eklemelerde Mange nuget Packages bölümünden yapılıyor