using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TextToSpeech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WebBrowser web = new WebBrowser();
        private void Form1_Load(object sender, EventArgs e)
        {
            web.Navigate("https://www.bing.com/translator");
            web.ScriptErrorsSuppressed = true;
            web.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            timer2.Start();
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            web.Document.GetElementById("tta_input_ta").InnerText = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            web.Document.GetElementById("tta_playiconsrc").InvokeMember("Click");
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.bing.com/translator");
        }
    }
}
