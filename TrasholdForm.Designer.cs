namespace IMGProc
{
    partial class TrasholdForm
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
            this.oryginal = new System.Windows.Forms.Panel();
            this.trasholded = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trasholdVal = new System.Windows.Forms.TrackBar();
            this.trasholdText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trasholdVal)).BeginInit();
            this.SuspendLayout();
            // 
            // oryginal
            // 
            this.oryginal.Location = new System.Drawing.Point(15, 32);
            this.oryginal.Name = "oryginal";
            this.oryginal.Size = new System.Drawing.Size(300, 300);
            this.oryginal.TabIndex = 0;
            // 
            // trasholded
            // 
            this.trasholded.Location = new System.Drawing.Point(321, 32);
            this.trasholded.Name = "trasholded";
            this.trasholded.Size = new System.Drawing.Size(300, 300);
            this.trasholded.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Oryginalny";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Po progowaniu";
            // 
            // trasholdVal
            // 
            this.trasholdVal.LargeChange = 1;
            this.trasholdVal.Location = new System.Drawing.Point(15, 364);
            this.trasholdVal.Maximum = 255;
            this.trasholdVal.Name = "trasholdVal";
            this.trasholdVal.Size = new System.Drawing.Size(606, 45);
            this.trasholdVal.TabIndex = 4;
            this.trasholdVal.Value = 127;
            this.trasholdVal.Scroll += new System.EventHandler(this.trasholdVal_Scroll);
            // 
            // trasholdText
            // 
            this.trasholdText.Location = new System.Drawing.Point(269, 338);
            this.trasholdText.Name = "trasholdText";
            this.trasholdText.Size = new System.Drawing.Size(100, 20);
            this.trasholdText.TabIndex = 5;
            // 
            // TrasholdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 446);
            this.Controls.Add(this.trasholdText);
            this.Controls.Add(this.trasholdVal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trasholded);
            this.Controls.Add(this.oryginal);
            this.Name = "TrasholdForm";
            this.Text = "Progowanie";
            ((System.ComponentModel.ISupportInitialize)(this.trasholdVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel oryginal;
        private System.Windows.Forms.Panel trasholded;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trasholdVal;
        private System.Windows.Forms.TextBox trasholdText;
    }
}