namespace MedicLabStudyApplication
{
    partial class F_Medicines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Medicines));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonChoosePhoto = new System.Windows.Forms.Button();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.labelContens = new System.Windows.Forms.Label();
            this.textBoxContens = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelProducer = new System.Windows.Forms.Label();
            this.textBoxProducer = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(303, 440);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(105, 36);
            this.buttonDelete.TabIndex = 26;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(303, 375);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(105, 38);
            this.buttonUpdate.TabIndex = 25;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInsert.Location = new System.Drawing.Point(303, 316);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(105, 36);
            this.buttonInsert.TabIndex = 24;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonChoosePhoto
            // 
            this.buttonChoosePhoto.Location = new System.Drawing.Point(44, 495);
            this.buttonChoosePhoto.Name = "buttonChoosePhoto";
            this.buttonChoosePhoto.Size = new System.Drawing.Size(91, 23);
            this.buttonChoosePhoto.TabIndex = 23;
            this.buttonChoosePhoto.Text = "choose photo";
            this.buttonChoosePhoto.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(35, 316);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(226, 173);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 22;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhoto.Location = new System.Drawing.Point(31, 289);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(59, 24);
            this.labelPhoto.TabIndex = 21;
            this.labelPhoto.Text = "Photo";
            // 
            // labelContens
            // 
            this.labelContens.AutoSize = true;
            this.labelContens.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelContens.Location = new System.Drawing.Point(31, 192);
            this.labelContens.Name = "labelContens";
            this.labelContens.Size = new System.Drawing.Size(80, 24);
            this.labelContens.TabIndex = 20;
            this.labelContens.Text = "Contens";
            // 
            // textBoxContens
            // 
            this.textBoxContens.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxContens.Location = new System.Drawing.Point(139, 192);
            this.textBoxContens.Multiline = true;
            this.textBoxContens.Name = "textBoxContens";
            this.textBoxContens.Size = new System.Drawing.Size(298, 91);
            this.textBoxContens.TabIndex = 19;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(31, 59);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(104, 24);
            this.labelDescription.TabIndex = 18;
            this.labelDescription.Text = "Description";
            // 
            // labelProducer
            // 
            this.labelProducer.AutoSize = true;
            this.labelProducer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProducer.Location = new System.Drawing.Point(31, 24);
            this.labelProducer.Name = "labelProducer";
            this.labelProducer.Size = new System.Drawing.Size(88, 24);
            this.labelProducer.TabIndex = 16;
            this.labelProducer.Text = "Producer";
            // 
            // textBoxProducer
            // 
            this.textBoxProducer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxProducer.Location = new System.Drawing.Point(139, 24);
            this.textBoxProducer.Name = "textBoxProducer";
            this.textBoxProducer.Size = new System.Drawing.Size(298, 29);
            this.textBoxProducer.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(477, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 490);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDescription.Location = new System.Drawing.Point(139, 59);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(298, 127);
            this.textBoxDescription.TabIndex = 17;
            // 
            // F_Medicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1083, 534);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonChoosePhoto);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.labelPhoto);
            this.Controls.Add(this.labelContens);
            this.Controls.Add(this.textBoxContens);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelProducer);
            this.Controls.Add(this.textBoxProducer);
            this.Controls.Add(this.dataGridView1);
            this.Name = "F_Medicines";
            this.Text = "F_Medicines";
            this.Load += new System.EventHandler(this.F_Medicines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonChoosePhoto;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Label labelPhoto;
        private System.Windows.Forms.Label labelContens;
        private System.Windows.Forms.TextBox textBoxContens;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelProducer;
        private System.Windows.Forms.TextBox textBoxProducer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxDescription;
    }
}