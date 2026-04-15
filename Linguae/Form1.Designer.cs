namespace Linguae
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxCamera = new System.Windows.Forms.PictureBox();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.textBoxChat = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.pictureBoxSign = new System.Windows.Forms.PictureBox();
            this.pictureBoxInfo = new System.Windows.Forms.PictureBox();
            this.panelStickman = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCamera
            // 
            this.pictureBoxCamera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxCamera.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCamera.Name = "pictureBoxCamera";
            this.pictureBoxCamera.Size = new System.Drawing.Size(1690, 418);
            this.pictureBoxCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCamera.TabIndex = 0;
            this.pictureBoxCamera.TabStop = false;
            this.pictureBoxCamera.Click += new System.EventHandler(this.pictureBoxCamera_Click);
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.BackColor = System.Drawing.Color.Black;
            this.labelSubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtitle.ForeColor = System.Drawing.Color.White;
            this.labelSubtitle.Location = new System.Drawing.Point(0, 418);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(453, 36);
            this.labelSubtitle.TabIndex = 1;
            this.labelSubtitle.Text = "Detected sign will appear here.";
            // 
            // textBoxChat
            // 
            this.textBoxChat.Location = new System.Drawing.Point(6, 476);
            this.textBoxChat.Name = "textBoxChat";
            this.textBoxChat.Size = new System.Drawing.Size(420, 22);
            this.textBoxChat.TabIndex = 2;
            this.textBoxChat.TextChanged += new System.EventHandler(this.textBoxChat_TextChanged);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(6, 515);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // pictureBoxSign
            // 
            this.pictureBoxSign.Location = new System.Drawing.Point(1496, 424);
            this.pictureBoxSign.Name = "pictureBoxSign";
            this.pictureBoxSign.Size = new System.Drawing.Size(194, 146);
            this.pictureBoxSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSign.TabIndex = 4;
            this.pictureBoxSign.TabStop = false;
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.Location = new System.Drawing.Point(1300, 424);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(190, 146);
            this.pictureBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInfo.TabIndex = 5;
            this.pictureBoxInfo.TabStop = false;
            // 
            // panelStickman
            // 
            this.panelStickman.Location = new System.Drawing.Point(994, 424);
            this.panelStickman.Name = "panelStickman";
            this.panelStickman.Size = new System.Drawing.Size(300, 300);
            this.panelStickman.TabIndex = 6;
            this.panelStickman.Paint += new System.Windows.Forms.PaintEventHandler(this.panelStickman_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1690, 821);
            this.Controls.Add(this.panelStickman);
            this.Controls.Add(this.pictureBoxInfo);
            this.Controls.Add(this.pictureBoxSign);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxChat);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.pictureBoxCamera);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCamera;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.TextBox textBoxChat;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.PictureBox pictureBoxSign;
        private System.Windows.Forms.PictureBox pictureBoxInfo;
        private System.Windows.Forms.Panel panelStickman;
    }
}

