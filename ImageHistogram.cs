using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IMGProc
{
    public partial class ImageHistogram : Form
    {
        private Bitmap diagramBmp;
        //private FastBitmap image; //obraz z aktywnego okna Mdi
        private Graphics diagram;
        private Pen pen = new Pen(Color.Black);
        //tablica zawierająca wartości histogramu
        private int[] HistogramTable = new int[256];
        //dane statystyczne histogramu
        private int suma;
        private int maxv;
        private int minv;
        private double sred;
        private double med;
        
        public int sum
        {
            get
            {
                return this.suma;
            }
        }
        public int max
        {
            get
            {
                return this.maxv;
            }
        }
        public int min
        {
            get
            {
                return this.minv;
            }
        }
        public double average
        {
            get
            {
                return this.sred;
            }
        }
        public double median
        {
            get
            {
                return this.med;
            }
        }
        public int[] table
        {
            get
            {
                return this.HistogramTable;
            }
        }

        public ImageHistogram(FastBitmap fastBitmap)
        {
            InitializeComponent();

            diagramBmp = new Bitmap(histDiagram.Size.Width, histDiagram.Size.Height);
            histDiagram.Image = diagramBmp;

            //utworzenie tablicy histogramu dla Grayscale
            createHistTableGray(fastBitmap);

            suma = HistogramTable.Sum();
            maxv = HistogramTable.Max();
            sred = HistogramTable.Average();
            med = (((double)HistogramTable[127] + (double)HistogramTable[128]) / 2.0);
            minv = HistogramTable.Min();

            labelSumVal.Text = suma.ToString();
            labelMaxVal.Text = maxv.ToString();
            labelMeanVal.Text = sred.ToString();
            labelMedianVal.Text = med.ToString();
            labelMinVal.Text = minv.ToString();

            diagram = Graphics.FromImage(diagramBmp);

            for (int i = 0; i < 256; i++)
            {
                Point start = new Point(i, 200);
                Point end = new Point(i, 200 - (HistogramTable[i]*200)/HistogramTable.Max());
                diagram.DrawLine(pen, start, end);
            }
            histDiagram.Image = diagramBmp;

            diagram.Dispose();
            //diagram.DrawLine(pen, 0, 0, histDiagram.Size.Width, histDiagram.Size.Height);
            //MessageBox.Show("Max: " + histogramTable.Max());
            //MessageBox.Show("Średnia: " + histogramTable.Average());

        }
        private void createHistTableGray(FastBitmap bmp)
        {
            HistogramTable = new int[256];
            for (int i = 0; i < bmp.Size.Width; ++i)
            {
                for (int j = 0; j < bmp.Size.Height; ++j)
                {
                    HistogramTable[bmp[i, j].R]++;
                }
            }
        }

        private void histDiagram_MouseMove(object sender, MouseEventArgs e)
        {
            labelPixelsVal.Text = HistogramTable[e.X].ToString();
            labelValueVal.Text = e.X.ToString();
        }
    }
}
