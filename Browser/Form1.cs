using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class Browser : Form
    {
        string searchsystem;

        public Browser()
        {
            InitializeComponent();
            searchsystem = "https://www.google.com/search?q=";
            chromiumWebBrowser1.Load("https://www.google.com/");
        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load(searchsystem + textBox1.Text);

            if (textBox1.Text.Contains("http://"))
            {
                chromiumWebBrowser1.Load(textBox1.Text);
            }
            else if (textBox1.Text.Contains("https://"))
            {
                chromiumWebBrowser1.Load(textBox1.Text);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            searchsystem = "https://www.google.com/search?q=";
            chromiumWebBrowser1.Load(searchsystem);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            searchsystem = "https://yandex.by/search/?text=";
            chromiumWebBrowser1.Load(searchsystem);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            searchsystem = "https://duckduckgo.com/?q=";
            chromiumWebBrowser1.Load(searchsystem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
