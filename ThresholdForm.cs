using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IMGProc {
    public partial class ThresholdForm : Form {
        private FastBitmap bmpOriginal;
        private FastBitmap bmpModified;
        private Graphics graphicsOriginal;
        private Graphics graphicsModified;

        public FastBitmap Image {
            get { return bmpModified; }
            set { bmpModified = value; }
        }

        public ThresholdForm(FastBitmap bmp) {
            InitializeComponent();

            bmpOriginal = bmp;
            bmpModified = new FastBitmap((Bitmap)bmp.Bitmap.Clone());

            originalPanel.Size = bmp.Size;
            originalPanel.Left = 0;
            originalPanel.Top = 0;
            containerPanel1.Size = new Size(300, 300);
            containerPanel1.Left = 10;
            containerPanel1.Top = 10;
            graphicsOriginal = originalPanel.CreateGraphics();

            modifiedPanel.Size = bmp.Size;
            modifiedPanel.Left = 0;
            modifiedPanel.Top = 0;
            containerPanel2.Size = new Size(300, 300);
            containerPanel2.Left = 320;
            containerPanel2.Top = 10;
            graphicsModified = modifiedPanel.CreateGraphics();

            ApplyThreshold((byte)127);
        }

        public void Redraw() {
            bmpOriginal.Draw(graphicsOriginal, 0, 0);
            bmpModified.Draw(graphicsModified, 0, 0);
        }

        public void RedrawOriginal() {
            bmpOriginal.Draw(graphicsOriginal, 0, 0);
        }

        public void RedrawModified() {
            bmpModified.Draw(graphicsModified, 0, 0);
        }

        private void containerPanel1_Scroll(object sender, ScrollEventArgs e) {
            RedrawOriginal();
        }

        private void trackBar1_Scroll(object sender, EventArgs e) {
            int value = trackBar1.Value;
            label1.Text = value.ToString();
            ApplyThreshold((byte)value);
            RedrawModified();
        }

        private void ApplyThreshold(byte value) {
            for (int i = 0; i < bmpOriginal.Size.Width; ++i) {
                for (int j = 0; j < bmpOriginal.Size.Height; ++j) {
                    byte newColor = bmpOriginal[i, j].R > value ? (byte)255 : (byte)0;
                    bmpModified[i, j] = Color.FromArgb(255, newColor, newColor, newColor);
                }
            }
        }

        private void originalPanel_Paint(object sender, PaintEventArgs e) {
            RedrawOriginal();
        }

        private void modifiedPanel_Paint(object sender, PaintEventArgs e) {
            RedrawModified();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ImagePreview imagePrev = new ImagePreview(bmpModified);
            imagePrev.MdiParent = this.MdiParent;
            imagePrev.Show();
        }
    }
}
