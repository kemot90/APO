namespace IMGProc {
    partial class ThresholdForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.modifiedPanel = new System.Windows.Forms.Panel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.originalPanel = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.containerPanel2 = new System.Windows.Forms.Panel();
            this.containerPanel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.containerPanel2.SuspendLayout();
            this.containerPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(338, 392);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // modifiedPanel
            // 
            this.modifiedPanel.Location = new System.Drawing.Point(53, 24);
            this.modifiedPanel.Name = "modifiedPanel";
            this.modifiedPanel.Size = new System.Drawing.Size(146, 100);
            this.modifiedPanel.TabIndex = 1;
            this.modifiedPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.modifiedPanel_Paint);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(218, 392);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "127";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // originalPanel
            // 
            this.originalPanel.Location = new System.Drawing.Point(16, 37);
            this.originalPanel.Name = "originalPanel";
            this.originalPanel.Size = new System.Drawing.Size(138, 100);
            this.originalPanel.TabIndex = 0;
            this.originalPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.originalPanel_Paint);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(10, 310);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(610, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Value = 127;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // containerPanel2
            // 
            this.containerPanel2.AutoScroll = true;
            this.containerPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.containerPanel2.Controls.Add(this.modifiedPanel);
            this.containerPanel2.Location = new System.Drawing.Point(342, 54);
            this.containerPanel2.Name = "containerPanel2";
            this.containerPanel2.Size = new System.Drawing.Size(236, 155);
            this.containerPanel2.TabIndex = 9;
            // 
            // containerPanel1
            // 
            this.containerPanel1.AutoScroll = true;
            this.containerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.containerPanel1.Controls.Add(this.originalPanel);
            this.containerPanel1.Location = new System.Drawing.Point(52, 54);
            this.containerPanel1.Name = "containerPanel1";
            this.containerPanel1.Size = new System.Drawing.Size(182, 180);
            this.containerPanel1.TabIndex = 8;
            // 
            // ThresholdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 446);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.containerPanel2);
            this.Controls.Add(this.containerPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThresholdForm";
            this.Text = "Threshold";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.containerPanel2.ResumeLayout(false);
            this.containerPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel modifiedPanel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel originalPanel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel containerPanel2;
        private System.Windows.Forms.Panel containerPanel1;
    }
}