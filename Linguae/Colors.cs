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
    public partial class Colors : Form
    {
        public Colors()
        {
            InitializeComponent();
        }

        private void Colors_Load(object sender, EventArgs e)
        {

        }

        private void Red_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            panelMenu1.Visible = false;
            panelBlack.Visible = false;
            panelBrown.Visible = false;
            panelWhite.Visible = false;
            panelPink.Visible = false;
            panelPurple.Visible = false;
            panelBlue.Visible = false;
            panelGreen.Visible = false;
            panelYellow.Visible = false;
            panelOrange.Visible = false;
            panelRed.Visible = true;
        }

        private void Orange_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            panelMenu1.Visible = false;
            panelBlack.Visible = false;
            panelBrown.Visible = false;
            panelWhite.Visible = false; 
            panelPink.Visible = false;
            panelPurple.Visible = false;
            panelBlue.Visible = false;
            panelGreen.Visible = false;
            panelYellow.Visible = false;
            panelOrange.Visible = true;
            panelRed.Visible = false;
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            panelMenu1.Visible = false;
            panelBlack.Visible = false;
            panelBrown.Visible = false;
            panelWhite.Visible = false;
            panelPink.Visible = false;
            panelPurple.Visible = false;
            panelBlue.Visible = false;
            panelGreen.Visible = false;
            panelYellow.Visible = true;
            panelOrange.Visible = false;
            panelRed.Visible = false;
        }

        private void Green_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            panelMenu1.Visible = false;
            panelBlack.Visible = false;
            panelBrown.Visible = false;
            panelWhite.Visible = false;
            panelPink.Visible = false;
            panelPurple.Visible = false;
            panelBlue.Visible = false;
            panelGreen.Visible = true;
            panelYellow.Visible = false;
            panelOrange.Visible = false;
            panelRed.Visible = false;
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            panelMenu1.Visible = false;
            panelBlack.Visible = false;
            panelBrown.Visible = false;
            panelWhite.Visible = false;
            panelPink.Visible = false;
            panelPurple.Visible = false;
            panelBlue.Visible = true;
            panelGreen.Visible = false;
            panelYellow.Visible = false;
            panelOrange.Visible = false;
            panelRed.Visible = false;
        }

        private void Purple_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            panelMenu1.Visible = false;
            panelBlack.Visible = false;
            panelBrown.Visible = false;
            panelWhite.Visible = false;
            panelPink.Visible = false;
            panelPurple.Visible = true;
            panelBlue.Visible = false;
            panelGreen.Visible = false;
            panelYellow.Visible = false;
            panelOrange.Visible = false;
            panelRed.Visible = false;
        }

        private void Pink_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            panelMenu1.Visible = false;
            panelBlack.Visible = false;
            panelBrown.Visible = false;
            panelWhite.Visible = false;
            panelPink.Visible = true;
            panelPurple.Visible = false;
            panelBlue.Visible = false;
            panelGreen.Visible = false;
            panelYellow.Visible = false;
            panelOrange.Visible = false;
            panelRed.Visible = false;
        }

        private void White_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            panelMenu1.Visible = false;
            panelBlack.Visible = false;
            panelBrown.Visible = false;
            panelWhite.Visible = true;
            panelPink.Visible = false;
            panelPurple.Visible = false;
            panelBlue.Visible = false;
            panelGreen.Visible = false;
            panelYellow.Visible = false;
            panelOrange.Visible = false;
            panelRed.Visible = false;
        }

        private void Brown_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            panelMenu1.Visible = false;
            panelBlack.Visible = false;
            panelBrown.Visible = true;
            panelWhite.Visible = false;
            panelPink.Visible = false;
            panelPurple.Visible = false;
            panelBlue.Visible = false;
            panelGreen.Visible = false;
            panelYellow.Visible = false;
            panelOrange.Visible = false;
            panelRed.Visible = false;
        }

        private void Black_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            panelMenu1.Visible = false;
            panelBlack.Visible = true;
            panelBrown.Visible = false;
            panelWhite.Visible = false;
            panelPink.Visible = false;
            panelPurple.Visible = false;
            panelBlue.Visible = false;
            panelGreen.Visible = false;
            panelYellow.Visible = false;
            panelOrange.Visible = false;
            panelRed.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://youtu.be/p__6YpkPvk0",
                UseShellExecute = true
            });
        }

        private void RedBackButton_Click(object sender, EventArgs e)
        {
            panelRed.Visible = false;
            panelOrange.Visible = false;
            panelYellow.Visible = false;
            panelGreen.Visible = false;
            panelBlue.Visible = false;
            panelPurple.Visible = false;
            panelPink.Visible = false;
            panelWhite.Visible = false;
            panelBrown.Visible = false;
            panelBlack.Visible = false;
            panelMenu1.Visible = true;
            panelMenu.Visible = true;
        }

        private void OrangeBackButton_Click(object sender, EventArgs e)
        {
            panelRed.Visible = false;
            panelOrange.Visible = false;
            panelYellow.Visible = false;
            panelGreen.Visible = false;
            panelBlue.Visible = false;
            panelPurple.Visible = false;
            panelPink.Visible = false;
            panelWhite.Visible = false;
            panelBrown.Visible = false;
            panelBlack.Visible = false;
            panelMenu1.Visible = true;
            panelMenu.Visible = true;
        }

        private void OrangeThumbnail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.youtube.com/watch?v=sSI8DRLMh18",
                UseShellExecute = true
            });
        }

        private void YellowThumbnail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.youtube.com/watch?v=CrJXNPNRbEo",
                UseShellExecute = true
            });
        }

        private void YellowBackButton_Click(object sender, EventArgs e)
        {
            panelRed.Visible = false;
            panelOrange.Visible = false;
            panelYellow.Visible = false;
            panelGreen.Visible = false;
            panelBlue.Visible = false;
            panelPurple.Visible = false;
            panelPink.Visible = false;
            panelWhite.Visible = false;
            panelBrown.Visible = false;
            panelBlack.Visible = false;
            panelMenu1.Visible = true;
            panelMenu.Visible = true;
        }

        private void GreenBackButton_Click(object sender, EventArgs e)
        {
            panelRed.Visible = false;
            panelOrange.Visible = false;
            panelYellow.Visible = false;
            panelGreen.Visible = false;
            panelBlue.Visible = false;
            panelPurple.Visible = false;
            panelPink.Visible = false;
            panelWhite.Visible = false;
            panelBrown.Visible = false;
            panelBlack.Visible = false;
            panelMenu1.Visible = true;
            panelMenu.Visible = true;
        }

        private void GreenThumbnail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.youtube.com/watch?v=G4dI1hHQZww",
                UseShellExecute = true
            });
        }

        private void BlueThumbnail_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.youtube.com/watch?v=IOtWeZj0a4M&t=2s",
                UseShellExecute = true
            });
        }

        private void BlueBackButton_Click(object sender, EventArgs e)
        {
            panelRed.Visible = false;
            panelOrange.Visible = false;
            panelYellow.Visible = false;
            panelGreen.Visible = false;
            panelBlue.Visible = false;
            panelPurple.Visible = false;
            panelPink.Visible = false;
            panelWhite.Visible = false;
            panelBrown.Visible = false;
            panelBlack.Visible = false;
            panelMenu1.Visible = true;
            panelMenu.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.youtube.com/watch?v=Gcz2Lr56tek",
                UseShellExecute = true
            });
        }

        private void VioletBackButton_Click(object sender, EventArgs e)
        {
            panelRed.Visible = false;
            panelOrange.Visible = false;
            panelYellow.Visible = false;
            panelGreen.Visible = false;
            panelBlue.Visible = false;
            panelPurple.Visible = false;
            panelPink.Visible = false;
            panelWhite.Visible = false;
            panelBrown.Visible = false;
            panelBlack.Visible = false;
            panelMenu1.Visible = true;
            panelMenu.Visible = true;
        }

        private void PinkThumbnail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.youtube.com/watch?v=UC1r9EzdcI8",
                UseShellExecute = true
            });
        }

        private void PinkBackButton_Click(object sender, EventArgs e)
        {
            panelRed.Visible = false;
            panelOrange.Visible = false;
            panelYellow.Visible = false;
            panelGreen.Visible = false;
            panelBlue.Visible = false;
            panelPurple.Visible = false;
            panelPink.Visible = false;
            panelWhite.Visible = false;
            panelBrown.Visible = false;
            panelBlack.Visible = false;
            panelMenu1.Visible = true;
            panelMenu.Visible = true;
        }

        private void WhiteThumbnail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.youtube.com/watch?v=oTUcwQXeGFI",
                UseShellExecute = true
            });
        }

        private void WhiteBackButton_Click(object sender, EventArgs e)
        {
            panelRed.Visible = false;
            panelOrange.Visible = false;
            panelYellow.Visible = false;
            panelGreen.Visible = false;
            panelBlue.Visible = false;
            panelPurple.Visible = false;
            panelPink.Visible = false;
            panelWhite.Visible = false;
            panelBrown.Visible = false;
            panelBlack.Visible = false;
            panelMenu1.Visible = true;
            panelMenu.Visible = true;
        }

        private void BrownThumbnail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.youtube.com/watch?v=dpZTG4kYZSY",
                UseShellExecute = true
            });
        }

        private void BrownBackButton_Click(object sender, EventArgs e)
        {
            panelRed.Visible = false;
            panelOrange.Visible = false;
            panelYellow.Visible = false;
            panelGreen.Visible = false;
            panelBlue.Visible = false;
            panelPurple.Visible = false;
            panelPink.Visible = false;
            panelWhite.Visible = false;
            panelBrown.Visible = false;
            panelBlack.Visible = false;
            panelMenu1.Visible = true;
            panelMenu.Visible = true;
        }

        private void BlackThumbnail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.youtube.com/watch?v=FpCrud8UnVc",
                UseShellExecute = true
            });
        }

        private void BlackBackButton_Click(object sender, EventArgs e)
        {
            panelRed.Visible = false;
            panelOrange.Visible = false;
            panelYellow.Visible = false;
            panelGreen.Visible = false;
            panelBlue.Visible = false;
            panelPurple.Visible = false;
            panelPink.Visible = false;
            panelWhite.Visible = false;
            panelBrown.Visible = false;
            panelBlack.Visible = false;
            panelMenu1.Visible = true;
            panelMenu.Visible = true;
        }
    }
}
