using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace IMGProc {
    public partial class ImagePreview : Form {
        private FastBitmap bmp;
        private Graphics graphics;
        private String path;
        private int count;
        private bool changed = false;
        private bool grayscale = false;

        public bool Grayscale {
            get { return grayscale; }
            set { grayscale = value; }
        }

        public string FileName {
            get { return Path.GetFileName(path);}
        }

        public bool Changed {
            get { return changed; }
            set { 
                changed = value;
                UpdateText();
            }
        }

        public FastBitmap Image {
            get { return bmp; }
            set { bmp = value; }
        }

        public String FilePath {
            get { return path; }
            set { path = value; }
        }

        public int Count {
            get { return count; }
            set { 
                count = value;
                UpdateText();
            }
        }

        public ImagePreview(String path) {
            InitializeComponent();

            this.path = path;

            StreamReader reader = new StreamReader(path);
            Bitmap bmpTemp = (Bitmap)Bitmap.FromStream(reader.BaseStream);
            Bitmap bmpTemp2 = new Bitmap(bmpTemp.Size.Width, bmpTemp.Size.Height);
            bmpTemp2.SetResolution(bmpTemp.HorizontalResolution, bmpTemp.VerticalResolution);
            Graphics gr = Graphics.FromImage(bmpTemp2);
            gr.DrawImage(bmpTemp, new Point());
            bmpTemp.Dispose();
            reader.Close();

            bmp = new FastBitmap(bmpTemp2);
            bmp.Bitmap.SetResolution(96, 96);

            Text = path;
            ClientSize = bmp.Size;
            graphicsPanel.Left = 0;
            graphicsPanel.Top = 0;
            graphicsPanel.Size = bmp.Size;
            graphics = this.graphicsPanel.CreateGraphics();
        }

        public ImagePreview(FastBitmap tempBmp) {
            InitializeComponent();

            FastBitmap newBmp = new FastBitmap(tempBmp.Size.Width, tempBmp.Size.Height);

            for (int i = 0; i < tempBmp.Size.Width; i++)
            {
                for (int j = 0; j < tempBmp.Size.Height; j++)
                {
                    newBmp[i, j] = tempBmp[i, j];
                }
            }

            //this.path = path;
            this.bmp = newBmp;
            Text = "Nowy";
            ClientSize = tempBmp.Size;
            graphicsPanel.Left = 0;
            graphicsPanel.Top = 0;
            graphicsPanel.Size = tempBmp.Size;
            graphics = this.graphicsPanel.CreateGraphics();
        }

        public void Redraw() {
            //graphics.DrawImage(bmp, new Point());
            bmp.Draw(graphics, 0, 0);
        }

        private void graphicsPanel_Paint(object sender, PaintEventArgs e) {
            Redraw();
        }

        public void Save() {
            Save(path);
        }

        public void Save(string filePath) {
            StreamWriter writer = new StreamWriter(filePath);
            ImageFormat format;
            switch (Path.GetExtension(filePath).ToLower()) {
                case ".jpg":
                case ".jpeg":
                    format = ImageFormat.Jpeg;
                    break;
                case ".gif":
                    format = ImageFormat.Gif;
                    break;
                case ".png":
                    format = ImageFormat.Png;
                    break;
                case ".tiff":
                    format = ImageFormat.Tiff;
                    break;
                default:
                    format = ImageFormat.Bmp;
                    break;
            }
            bmp.Save(writer.BaseStream, format);
            writer.Close();
        }

        public void UpdateText() {
            Text = Path.GetFileName(path) + ((count > 0) ? ("(" + count.ToString() + ")") : "") + (changed ? " *" : "");
        }

        private void ImageForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (changed) {
                switch (MessageBox.Show("Image \"" + Path.GetFileName(path) + "\" was changed. Save changes?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)) {
                    case DialogResult.Yes:
                        Save();
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
