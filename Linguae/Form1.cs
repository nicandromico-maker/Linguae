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
using System.Net;

namespace Linguae
{


    public partial class Form1 : Form

    {
        int waveOffset = 0;
        bool waveUp = true;
        Timer animationTimer = new Timer();
        string connStr = "Data Source=.;Initial Catalog=LinguaeDB;Integrated Security=True";
        string currentGesture = "idle";
        Timer apiTimer = new Timer();
        public Form1()
        {
            InitializeComponent();
            panelStickman.Invalidate();
            animationTimer.Interval = 100; // speed
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start();
            apiTimer.Interval = 500;
            apiTimer.Tick += ApiTimer_Tick;
            apiTimer.Start();

        }

        private void pictureBoxCamera_Click(object sender, EventArgs e)
        {

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string userText = textBoxChat.Text.ToLower();

            currentGesture = userText;   // set the pose
            panelStickman.Invalidate();  // redraw stickman

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

        private void panelStickman_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.White, 3);

            if (currentGesture == "hello")
            {
                // head
                g.DrawEllipse(pen, 120, 20, 60, 60);

                // body
                g.DrawLine(pen, 150, 80, 150, 170);

                // left arm waving
                g.DrawLine(pen, 150, 100, 90, 120 + waveOffset);

                // right arm normal
                g.DrawLine(pen, 150, 100, 200, 140);

                // legs
                g.DrawLine(pen, 150, 170, 110, 230);
                g.DrawLine(pen, 150, 170, 190, 230);
            }
            else if (currentGesture == "help")
            {
                // head
                g.DrawEllipse(pen, 120, 20, 60, 60);

                // body
                g.DrawLine(pen, 150, 80, 150, 170);

                // arms raised
                g.DrawLine(pen, 150, 100, 100, 60);
                g.DrawLine(pen, 150, 100, 200, 60);

                // legs
                g.DrawLine(pen, 150, 170, 110, 230);
                g.DrawLine(pen, 150, 170, 190, 230);
            }
            else
            {
                // default pose
                g.DrawEllipse(pen, 120, 20, 60, 60);
                g.DrawLine(pen, 150, 80, 150, 170);
                g.DrawLine(pen, 150, 100, 100, 140);
                g.DrawLine(pen, 150, 100, 200, 140);
                g.DrawLine(pen, 150, 170, 110, 230);
                g.DrawLine(pen, 150, 170, 190, 230);
            }
        }
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (currentGesture == "hello")
            {
                if (waveUp)
                {
                    waveOffset += 5;
                    if (waveOffset >= 20) waveUp = false;
                }
                else
                {
                    waveOffset -= 5;
                    if (waveOffset <= -20) waveUp = true;
                }

                panelStickman.Invalidate();
            }
        }

        private void ApiTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    string gesture = wc.DownloadString("http://127.0.0.1:5000/gesture").Trim();

                    currentGesture = gesture;
                    panelStickman.Invalidate();
                }
            }
            catch
            {
            }
        }

    }
}
