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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == false)
            {//tweet-box-home-timeline
                foreach (HtmlElement element in webBrowser1.Document.All)
                {
                    if (element.GetAttribute("classname") == "t1-form tweet-form condensed")
                    {
                        element.SetAttribute("classname", "tweet-action EdgeButton EdgeButton--primary js-tweet-btn disabled");
                    }
                    if (element.Id == "tweet-box-home-timeline")
                    {
                        element.InnerText = richTextBox1.Text;
                    }
                    if (element.GetAttribute("classname") == "tweet-action EdgeButton EdgeButton--primary js-tweet-btn")
                    {
                        element.InvokeMember("click");
                    }

                }

            }
            else
            {
                richTextBox1.Enabled = false;
                TxtSaniye.Enabled = false;
                button1.Enabled = false;
                checkBox1.Enabled = false;


                sayac = int.Parse(TxtSaniye.Text);
                timer1.Start();

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                TxtSaniye.Visible = true;
            }
            else
            {
                TxtSaniye.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            TxtSaniye.Text = sayac + "Kaldı";
            if (sayac == 0)
            {
                foreach (HtmlElement element in webBrowser1.Document.All)
                {
                    if (element.GetAttribute("classname") == "t1-form tweet-form condensed")
                    {
                        element.SetAttribute("classname", "t1-form tweet-form");
                    }
                    if (element.Id == "tweet-box-home-timeline")
                    {
                        element.InnerText = richTextBox1.Text;
                    }
                    if (element.GetAttribute("classname") == "button-text tweeting-text")
                    {
                        element.InvokeMember("click");
                    }

                }
                richTextBox1.Enabled = true;
                TxtSaniye.Enabled = true;
                button1.Enabled = true;
                checkBox1.Enabled = true;

                timer1.Stop();
            }
        }
    }
}
