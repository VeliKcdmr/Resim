using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string resim;
        Color renk;
        Bitmap bmp;
        private void BtnResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            resim = openFileDialog1.FileName;
        }

        private void BtnRenk_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;
        }

        private void BtnYazdır_Click(object sender, EventArgs e)
        {
            bmp=new Bitmap(resim);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawString(TxtMetin.Text, new Font("segoe UI", Convert.ToInt32(TxtBoyut.Text), FontStyle.Bold), new SolidBrush(renk), 20, 30);
            pictureBox1.Image = bmp;

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Resim | .jpg";
            saveFileDialog1.ShowDialog();
            bmp.Save(saveFileDialog1.FileName);
        }
    }
}
