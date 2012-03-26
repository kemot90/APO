using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IMGProc
{
    public partial class TrasholdForm : Form
    {
        public TrasholdForm(FastBitmap bmp)
        {
            InitializeComponent();
            FastBitmap newBmp = new FastBitmap(bmp.Size.Width, bmp.Size.Height);

            for (int i = 0; i < bmp.Size.Width; i++)
            {
                for (int j = 0; j < bmp.Size.Height; j++)
                {
                    newBmp[i, j] = bmp[i, j];
                }
            }
            trasholdText.Text = "127";
        }

        private void trasholdVal_Scroll(object sender, EventArgs e)
        {
            trasholdText.Text = trasholdVal.Value.ToString();
        }
    }
}
