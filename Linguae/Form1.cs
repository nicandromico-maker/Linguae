using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Linguae
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connStr = "Data Source=.;Initial Catalog=LinguaeDB;Integrated Security=True";
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

            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT FilePath FROM Animations WHERE Text = @text", con);

                cmd.Parameters.AddWithValue("@text", text.ToLower());

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    path = result.ToString();
                }
                else
                {
                    // fallback to default
                    SqlCommand defaultCmd = new SqlCommand(
                        "SELECT FilePath FROM Animations WHERE Text = 'default'", con);

                    path = defaultCmd.ExecuteScalar().ToString();
                }

                con.Close();
            }

            string fullPath = System.IO.Path.Combine(Application.StartupPath, path);

            if (System.IO.File.Exists(fullPath))
            {
                pictureBoxSign.Image = Image.FromFile(fullPath);
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
