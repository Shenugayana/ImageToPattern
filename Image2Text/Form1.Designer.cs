namespace Image2Text
{
    partial class Shenugayana
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
            this.InitialImage = new System.Windows.Forms.PictureBox();
            this.BtnUpload = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.InitialImage)).BeginInit();
            this.SuspendLayout();
            // 
            // InitialImage
            // 
            this.InitialImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InitialImage.Location = new System.Drawing.Point(1, 59);
            this.InitialImage.Name = "InitialImage";
            this.InitialImage.Size = new System.Drawing.Size(449, 615);
            this.InitialImage.TabIndex = 0;
            this.InitialImage.TabStop = false;
            // 
            // BtnUpload
            // 
            this.BtnUpload.BackColor = System.Drawing.Color.MediumOrchid;
            this.BtnUpload.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpload.ForeColor = System.Drawing.Color.White;
            this.BtnUpload.Location = new System.Drawing.Point(282, 12);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(168, 41);
            this.BtnUpload.TabIndex = 1;
            this.BtnUpload.Text = "Upload Image";
            this.BtnUpload.UseVisualStyleBackColor = false;
            this.BtnUpload.Click += new System.EventHandler(this.Upload);
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.MediumOrchid;
            this.BtnPrint.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.ForeColor = System.Drawing.Color.White;
            this.BtnPrint.Location = new System.Drawing.Point(1082, 12);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(168, 41);
            this.BtnPrint.TabIndex = 2;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.printFile);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(456, 59);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(801, 615);
            this.txtOutput.TabIndex = 3;
            this.txtOutput.Text = "";
            this.txtOutput.ZoomFactor = 0.1F;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(457, 13);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(622, 40);
            this.hScrollBar1.TabIndex = 5;
            this.hScrollBar1.Value = 80;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Threshold);
            // 
            // Shenugayana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.BtnUpload);
            this.Controls.Add(this.InitialImage);
            this.Name = "Shenugayana";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.InitialImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox InitialImage;
        private System.Windows.Forms.Button BtnUpload;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}

