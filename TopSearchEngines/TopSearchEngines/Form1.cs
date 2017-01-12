using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopSearchEngines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://www.google.com/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://www.bing.com/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://www.yahoo.com/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("http://www.baidu.com/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("http://www.aol.com/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("http://www.ask.com/");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("http://www.excite.com/");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://duckduckgo.com/");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://www.wolframalpha.com/");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://www.yandex.com/");
        }
    }
}
