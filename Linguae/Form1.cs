using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linguae
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxCamera_Click(object sender, EventArgs e)
        {

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {

            string userText = textBoxChat.Text;

            labelSubtitle.Text = userText;

            ShowSign(userText);

            textBoxChat.Clear();
        }
        private void ShowSign(string text)
        {
            string path = "";

            switch (text.ToLower())
            {
                case "hello":
                    path = "Signs/hello.gif";
                    break;

                case "help":
                    path = "Signs/help.gif";
                    break;

                default:
                    path = "Signs/default.gif";
                    break;
            }

            string fullPath = System.IO.Path.Combine(Application.StartupPath, path);
            if (System.IO.File.Exists(fullPath))
            {
                pictureBoxSign.Image = Image.FromFile(fullPath);
            }
            else
            {
                MessageBox.Show("File not found: " + fullPath);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxChat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
