namespace MedicLabStudyApplication
{
    partial class AboutUsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUsForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usPhoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // usPhoto
            // 
            this.usPhoto.BackColor = System.Drawing.Color.Transparent;
            this.usPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usPhoto.BackgroundImage")));
            this.usPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.usPhoto.Image = ((System.Drawing.Image)(resources.GetObject("usPhoto.Image")));
            this.usPhoto.Location = new System.Drawing.Point(761, 220);
            this.usPhoto.Name = "usPhoto";
            this.usPhoto.Size = new System.Drawing.Size(460, 345);
            this.usPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.usPhoto.TabIndex = 1;
            this.usPhoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 98);
            this.label1.TabIndex = 2;
            this.label1.Text = "ABOUT US";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(67, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "Przykładowy text";
            // 
            // AboutUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usPhoto);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AboutUsForm";
            this.Text = "About Us";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox usPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}