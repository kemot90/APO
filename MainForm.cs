using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Imaging;

namespace IMGProc
{
    public partial class MainForm : Form
    {
        //metody wyrównywania histogramu
        public enum EqualizationMethod { Averages, Random, Neighborhood4, Neighborhood8, Own };

        public MainForm()
        {
            InitializeComponent();
            //ustawienie głównego formularza jako kontenera na inne okna programu
            this.IsMdiContainer = true;
            //ustawienie filtru formatów plików możliwych do otworzenia w programie
            openImg.Filter = "Image files |*.jpg; *.jpeg; *.png; *.gif; *.tiff; *.bmp|All files (*.*)|*.*";
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //wyświetl okno wyboru obrazu do otworzenia
            openImg.ShowDialog();

            try
            {
                ImagePreview imageForm = new ImagePreview(openImg.FileName);
                imageForm.MdiParent = this;
                imageForm.Show();
            }
            catch
            {
            }
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImagePreview imageForm = (ImagePreview)this.ActiveMdiChild;
            ImageHistogram imageHistogram = new ImageHistogram(imageForm.Image);
            imageHistogram.MdiParent = this;
            imageHistogram.Show();
            /*HistogramWindow imageHistogram = new HistogramWindow();
            imageHistogram.GatherStatistics(bitmap);
            imageHistogram.Show();
            imageHistogram.MdiParent = this;*/
        }

        private void topMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                histogramItemMenu.Enabled = true;
            }
            else
            {
                histogramItemMenu.Enabled = false;
            }
        }

        private void EqualizeHistogram(EqualizationMethod method)
        {
            FastBitmap bmp = ((ImagePreview)ActiveMdiChild).Image;
            EqualizeHistogram(bmp, method);
            ((ImagePreview)ActiveMdiChild).Refresh();
        }

        public static void EqualizeHistogram(FastBitmap bmp, EqualizationMethod method)
        {
            ImageHistogram hist = new ImageHistogram(bmp);
            int R = 0;
            double hInt = 0.0;
            double[] left = new double[256];
            double[] right = new double[256];
            int[] newValue = new int[256];

            for (int i = 0; i < 256; ++i)
            {
                left[i] = R;
                hInt += hist.table[i];
                while (hInt > hist.average)
                {
                    hInt -= hist.average;
                    if (R < 255)
                        R++;
                }

                right[i] = R;
                switch (method)
                {
                    case EqualizationMethod.Averages:
                        newValue[i] = (int)((left[i] + right[i]) / 2.0);
                        break;
                    case EqualizationMethod.Random:
                        newValue[i] = (int)(right[i] - left[i]);
                        break;
                    case EqualizationMethod.Own:
                        newValue[i] = (int)((left[i] + right[i]) / 2.0);
                        break;
                }
            }

            for (int i = 0; i < bmp.Size.Width; ++i)
            {
                for (int j = 0; j < bmp.Size.Height; ++j)
                {
                    Color color = bmp[i, j];
                    if (left[color.R] == right[color.R])
                        bmp[i, j] = Color.FromArgb(color.A, (int)left[color.R], (int)left[color.R], (int)left[color.R]);
                    else
                    {
                        switch (method)
                        {
                            case EqualizationMethod.Averages:
                                bmp[i, j] = Color.FromArgb(color.A, (int)newValue[color.R], (int)newValue[color.R], (int)newValue[color.R]);
                                break;
                            case EqualizationMethod.Random:
                                Random rnd = new Random();
                                int value = (int)left[color.R] + rnd.Next(newValue[color.R] + 1);
                                bmp[i, j] = Color.FromArgb(color.A, value, value, value);
                                break;
                            case EqualizationMethod.Neighborhood8:
                                double average = 0;
                                int count = 0;
                                foreach (Point offset in new Point[] { new Point(1, 0), new Point(-1, 0), new Point(0, 1), new Point(0, -1), new Point(1, 1), new Point(-1, -1), new Point(-1, 1), new Point(1, -1) })
                                {
                                    if (i + offset.X >= 0 && i + offset.X < bmp.Width && j + offset.Y >= 0 && j + offset.Y < bmp.Height)
                                    {
                                        average += bmp[i + offset.X, j + offset.Y].R;
                                        ++count;
                                    }
                                }
                                average /= count;
                                if (average > right[color.R])
                                    bmp[i, j] = Color.FromArgb(color.A, (int)right[color.R], (int)right[color.R], (int)right[color.R]);
                                else if (average < left[color.R])
                                    bmp[i, j] = Color.FromArgb(color.A, (int)left[color.R], (int)left[color.R], (int)left[color.R]);
                                else
                                    bmp[i, j] = Color.FromArgb(color.A, (int)average, (int)average, (int)average);
                                break;
                            case EqualizationMethod.Own:
                                bmp[i, j] = Color.FromArgb(color.A, (int)newValue[color.R], (int)newValue[color.R], (int)newValue[color.R]);
                                break;
                        }
                    }
                }
            }
        }

        public static void Invert(FastBitmap bmp)
        {
            for (int i = 0; i < bmp.Size.Width; i++)
            {
                for (int j = 0; j < bmp.Size.Height; j++)
                {
                    bmp[i, j] = Color.FromArgb(255 - bmp[i, j].R, 255 - bmp[i, j].G, 255 - bmp[i, j].B);
                }
            }
        }

        private void sredMenuItem_Click(object sender, EventArgs e)
        {
            EqualizeHistogram(EqualizationMethod.Averages);
        }

        private void losowaItemMenu_Click(object sender, EventArgs e)
        {
            EqualizeHistogram(EqualizationMethod.Random);
        }

        private void neighItemMenu_Click(object sender, EventArgs e)
        {
            EqualizeHistogram(EqualizationMethod.Neighborhood8);
        }

        private void ownItemMenu_Click(object sender, EventArgs e)
        {
            EqualizeHistogram(EqualizationMethod.Own);
        }

        private void negacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastBitmap bmp = ((ImagePreview)ActiveMdiChild).Image;
            Invert(bmp);
            ((ImagePreview)ActiveMdiChild).Refresh();
        }

        private void duplikujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImagePreview imageForm = new ImagePreview(((ImagePreview)ActiveMdiChild).Image);
            imageForm.MdiParent = this;
            imageForm.Show();
        }

        private void progowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThresholdForm trasholdForm = new ThresholdForm(((ImagePreview)ActiveMdiChild).Image);
            trasholdForm.MdiParent = this;
            trasholdForm.Show();
        }
    }
}
