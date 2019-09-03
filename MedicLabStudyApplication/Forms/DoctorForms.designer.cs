namespace MedicLabStudyApplication
{
    partial class DoctorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorsForm));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonChoosePhoto = new System.Windows.Forms.Button();
            this.photoBox = new System.Windows.Forms.PictureBox();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.labelSpeciality = new System.Windows.Forms.Label();
            this.speciality = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(288, 442);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(105, 36);
            this.buttonDelete.TabIndex = 39;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(288, 377);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(105, 38);
            this.buttonUpdate.TabIndex = 38;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInsert.Location = new System.Drawing.Point(288, 318);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(105, 36);
            this.buttonInsert.TabIndex = 37;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.insertIntoDatabase);
            // 
            // buttonChoosePhoto
            // 
            this.buttonChoosePhoto.Location = new System.Drawing.Point(29, 497);
            this.buttonChoosePhoto.Name = "buttonChoosePhoto";
            this.buttonChoosePhoto.Size = new System.Drawing.Size(91, 23);
            this.buttonChoosePhoto.TabIndex = 36;
            this.buttonChoosePhoto.Text = "choose photo";
            this.buttonChoosePhoto.UseVisualStyleBackColor = true;
            this.buttonChoosePhoto.Click += new System.EventHandler(this.buttonChoosePhoto_Click);
            // 
            // photoBox
            // 
            this.photoBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.photoBox.Location = new System.Drawing.Point(20, 318);
            this.photoBox.Name = "photoBox";
            this.photoBox.Size = new System.Drawing.Size(226, 173);
            this.photoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoBox.TabIndex = 35;
            this.photoBox.TabStop = false;
            // 
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhoto.Location = new System.Drawing.Point(16, 291);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(59, 24);
            this.labelPhoto.TabIndex = 34;
            this.labelPhoto.Text = "Photo";
            // 
            // labelSpeciality
            // 
            this.labelSpeciality.AutoSize = true;
            this.labelSpeciality.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpeciality.Location = new System.Drawing.Point(16, 107);
            this.labelSpeciality.Name = "labelSpeciality";
            this.labelSpeciality.Size = new System.Drawing.Size(89, 24);
            this.labelSpeciality.TabIndex = 33;
            this.labelSpeciality.Text = "Speciality";
            // 
            // inputSpeciality
            // 
            this.speciality.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speciality.Location = new System.Drawing.Point(124, 107);
            this.speciality.Multiline = true;
            this.speciality.Name = "inputSpeciality";
            this.speciality.Size = new System.Drawing.Size(298, 71);
            this.speciality.TabIndex = 32;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.Location = new System.Drawing.Point(16, 64);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(99, 24);
            this.labelLastName.TabIndex = 31;
            this.labelLastName.Text = "Last Name";
            // 
            // inputLastName
            // 
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastName.Location = new System.Drawing.Point(124, 64);
            this.lastName.Multiline = true;
            this.lastName.Name = "inputLastName";
            this.lastName.Size = new System.Drawing.Size(298, 24);
            this.lastName.TabIndex = 30;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.Location = new System.Drawing.Point(16, 26);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(101, 24);
            this.labelFirstName.TabIndex = 29;
            this.labelFirstName.Text = "First Name";
            // 
            // inputFirstName
            // 
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstName.Location = new System.Drawing.Point(124, 26);
            this.firstName.Name = "inputFirstName";
            this.firstName.Size = new System.Drawing.Size(298, 29);
            this.firstName.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(442, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 494);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTelephone.Location = new System.Drawing.Point(16, 205);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(103, 24);
            this.labelTelephone.TabIndex = 40;
            this.labelTelephone.Text = "Telephone";
            // 
            // inputTelephone
            // 
            this.phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumber.Location = new System.Drawing.Point(124, 205);
            this.phoneNumber.Multiline = true;
            this.phoneNumber.Name = "inputTelephone";
            this.phoneNumber.Size = new System.Drawing.Size(298, 24);
            this.phoneNumber.TabIndex = 41;
            // 
            // DoctorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 546);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.labelTelephone);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonChoosePhoto);
            this.Controls.Add(this.photoBox);
            this.Controls.Add(this.labelPhoto);
            this.Controls.Add(this.labelSpeciality);
            this.Controls.Add(this.speciality);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DoctorsForm";
            this.Text = "Doctors";
            this.Load += new System.EventHandler(this.loadDoctorsForm);
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonChoosePhoto;
        private System.Windows.Forms.PictureBox photoBox;
        private System.Windows.Forms.Label labelPhoto;
        private System.Windows.Forms.Label labelSpeciality;
        private System.Windows.Forms.TextBox speciality;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.TextBox phoneNumber;
    }
}