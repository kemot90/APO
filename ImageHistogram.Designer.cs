namespace IMGProc
{
    partial class ImageHistogram
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
            this.histDiagram = new System.Windows.Forms.PictureBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelPixels = new System.Windows.Forms.Label();
            this.labelPixelsVal = new System.Windows.Forms.Label();
            this.labelValueVal = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelSumVal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMinVal = new System.Windows.Forms.Label();
            this.labelMaxVal = new System.Windows.Forms.Label();
            this.labelMedianVal = new System.Windows.Forms.Label();
            this.labelMeanVal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.histDiagram)).BeginInit();
            this.SuspendLayout();
            // 
            // histDiagram
            // 
            this.histDiagram.BackColor = System.Drawing.SystemColors.Control;
            this.histDiagram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.histDiagram.Cursor = System.Windows.Forms.Cursors.Cross;
            this.histDiagram.Location = new System.Drawing.Point(12, 12);
            this.histDiagram.Name = "histDiagram";
            this.histDiagram.Size = new System.Drawing.Size(258, 200);
            this.histDiagram.TabIndex = 0;
            this.histDiagram.TabStop = false;
            this.histDiagram.MouseMove += new System.Windows.Forms.MouseEventHandler(this.histDiagram_MouseMove);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(12, 251);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(53, 13);
            this.labelValue.TabIndex = 1;
            this.labelValue.Text = "Wartość: ";
            // 
            // labelPixels
            // 
            this.labelPixels.AutoSize = true;
            this.labelPixels.Location = new System.Drawing.Point(12, 273);
            this.labelPixels.Name = "labelPixels";
            this.labelPixels.Size = new System.Drawing.Size(43, 13);
            this.labelPixels.TabIndex = 2;
            this.labelPixels.Text = "Pikseli: ";
            // 
            // labelPixelsVal
            // 
            this.labelPixelsVal.AutoSize = true;
            this.labelPixelsVal.Location = new System.Drawing.Point(71, 273);
            this.labelPixelsVal.Name = "labelPixelsVal";
            this.labelPixelsVal.Size = new System.Drawing.Size(0, 13);
            this.labelPixelsVal.TabIndex = 4;
            // 
            // labelValueVal
            // 
            this.labelValueVal.AutoSize = true;
            this.labelValueVal.Location = new System.Drawing.Point(71, 251);
            this.labelValueVal.Name = "labelValueVal";
            this.labelValueVal.Size = new System.Drawing.Size(0, 13);
            this.labelValueVal.TabIndex = 3;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(12, 295);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(51, 13);
            this.labelSum.TabIndex = 5;
            this.labelSum.Text = "Łącznie: ";
            // 
            // labelSumVal
            // 
            this.labelSumVal.AutoSize = true;
            this.labelSumVal.Location = new System.Drawing.Point(71, 295);
            this.labelSumVal.Name = "labelSumVal";
            this.labelSumVal.Size = new System.Drawing.Size(0, 13);
            this.labelSumVal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Max: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mediana: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Średnia: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Min: ";
            // 
            // labelMinVal
            // 
            this.labelMinVal.AutoSize = true;
            this.labelMinVal.Location = new System.Drawing.Point(211, 317);
            this.labelMinVal.Name = "labelMinVal";
            this.labelMinVal.Size = new System.Drawing.Size(0, 13);
            this.labelMinVal.TabIndex = 14;
            // 
            // labelMaxVal
            // 
            this.labelMaxVal.AutoSize = true;
            this.labelMaxVal.Location = new System.Drawing.Point(211, 295);
            this.labelMaxVal.Name = "labelMaxVal";
            this.labelMaxVal.Size = new System.Drawing.Size(0, 13);
            this.labelMaxVal.TabIndex = 13;
            // 
            // labelMedianVal
            // 
            this.labelMedianVal.AutoSize = true;
            this.labelMedianVal.Location = new System.Drawing.Point(211, 273);
            this.labelMedianVal.Name = "labelMedianVal";
            this.labelMedianVal.Size = new System.Drawing.Size(0, 13);
            this.labelMedianVal.TabIndex = 12;
            // 
            // labelMeanVal
            // 
            this.labelMeanVal.AutoSize = true;
            this.labelMeanVal.Location = new System.Drawing.Point(211, 251);
            this.labelMeanVal.Name = "labelMeanVal";
            this.labelMeanVal.Size = new System.Drawing.Size(0, 13);
            this.labelMeanVal.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "255";
            // 
            // ImageHistogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 348);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelMinVal);
            this.Controls.Add(this.labelMaxVal);
            this.Controls.Add(this.labelMedianVal);
            this.Controls.Add(this.labelMeanVal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSumVal);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelPixelsVal);
            this.Controls.Add(this.labelValueVal);
            this.Controls.Add(this.labelPixels);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.histDiagram);
            this.Name = "ImageHistogram";
            this.Text = "Histogram";
            ((System.ComponentModel.ISupportInitialize)(this.histDiagram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox histDiagram;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelPixels;
        private System.Windows.Forms.Label labelPixelsVal;
        private System.Windows.Forms.Label labelValueVal;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelSumVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMinVal;
        private System.Windows.Forms.Label labelMaxVal;
        private System.Windows.Forms.Label labelMedianVal;
        private System.Windows.Forms.Label labelMeanVal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;


    }
}