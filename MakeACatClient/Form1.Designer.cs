namespace MakeACatClient
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbBreed = new System.Windows.Forms.ComboBox();
            this.lblBreed = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lstCats = new System.Windows.Forms.ListBox();
            this.btnMakeACat = new System.Windows.Forms.Button();
            this.btnMakeCats = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.picCat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Chocolate;
            this.lblTitle.Location = new System.Drawing.Point(153, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(203, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Make a Cat";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(48, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // cmbBreed
            // 
            this.cmbBreed.FormattingEnabled = true;
            this.cmbBreed.Items.AddRange(new object[] {
            "Abyssinian",
            "American_Shorthair",
            "Bengal",
            "British_Longhair",
            "Maine_Coon"});
            this.cmbBreed.Location = new System.Drawing.Point(134, 132);
            this.cmbBreed.Name = "cmbBreed";
            this.cmbBreed.Size = new System.Drawing.Size(222, 32);
            this.cmbBreed.TabIndex = 2;
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(48, 132);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(64, 25);
            this.lblBreed.TabIndex = 3;
            this.lblBreed.Text = "Breed";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(134, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 29);
            this.txtName.TabIndex = 4;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(35, 191);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(77, 25);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(134, 191);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(222, 32);
            this.cmbGender.TabIndex = 6;
            // 
            // lstCats
            // 
            this.lstCats.FormattingEnabled = true;
            this.lstCats.ItemHeight = 24;
            this.lstCats.Location = new System.Drawing.Point(40, 353);
            this.lstCats.Name = "lstCats";
            this.lstCats.Size = new System.Drawing.Size(316, 148);
            this.lstCats.TabIndex = 7;
            this.lstCats.SelectedIndexChanged += new System.EventHandler(this.lstCats_SelectedIndexChanged);
            // 
            // btnMakeACat
            // 
            this.btnMakeACat.Location = new System.Drawing.Point(40, 296);
            this.btnMakeACat.Name = "btnMakeACat";
            this.btnMakeACat.Size = new System.Drawing.Size(130, 36);
            this.btnMakeACat.TabIndex = 8;
            this.btnMakeACat.Text = "Make a Cat";
            this.btnMakeACat.UseVisualStyleBackColor = true;
            this.btnMakeACat.Click += new System.EventHandler(this.btnMakeACat_Click);
            // 
            // btnMakeCats
            // 
            this.btnMakeCats.Location = new System.Drawing.Point(191, 296);
            this.btnMakeCats.Name = "btnMakeCats";
            this.btnMakeCats.Size = new System.Drawing.Size(165, 36);
            this.btnMakeCats.TabIndex = 9;
            this.btnMakeCats.Text = "Make 5 Cats!";
            this.btnMakeCats.UseVisualStyleBackColor = true;
            this.btnMakeCats.Click += new System.EventHandler(this.btnMakeCats_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(172, 245);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(48, 25);
            this.lblAge.TabIndex = 10;
            this.lblAge.Text = "Age";
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(236, 245);
            this.numAge.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(120, 29);
            this.numAge.TabIndex = 11;
            this.numAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // picCat
            // 
            this.picCat.Image = ((System.Drawing.Image)(resources.GetObject("picCat.Image")));
            this.picCat.InitialImage = ((System.Drawing.Image)(resources.GetObject("picCat.InitialImage")));
            this.picCat.Location = new System.Drawing.Point(376, 54);
            this.picCat.Name = "picCat";
            this.picCat.Size = new System.Drawing.Size(159, 277);
            this.picCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCat.TabIndex = 12;
            this.picCat.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(544, 532);
            this.Controls.Add(this.picCat);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.btnMakeCats);
            this.Controls.Add(this.btnMakeACat);
            this.Controls.Add(this.lstCats);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.cmbBreed);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMain";
            this.Text = "Make a Cat Client Tester";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbBreed;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ListBox lstCats;
        private System.Windows.Forms.Button btnMakeACat;
        private System.Windows.Forms.Button btnMakeCats;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.PictureBox picCat;
    }
}

