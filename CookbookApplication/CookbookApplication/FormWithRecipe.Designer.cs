namespace CookbookApplication
{
    partial class FormWithRecipe
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.rtbIngedients = new System.Windows.Forms.RichTextBox();
            this.rtbSteps = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(329, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(125, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Ингредиенты:";
            // 
            // rtbIngedients
            // 
            this.rtbIngedients.AutoWordSelection = true;
            this.rtbIngedients.BackColor = System.Drawing.Color.White;
            this.rtbIngedients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbIngedients.Location = new System.Drawing.Point(329, 88);
            this.rtbIngedients.Name = "rtbIngedients";
            this.rtbIngedients.ReadOnly = true;
            this.rtbIngedients.ShowSelectionMargin = true;
            this.rtbIngedients.Size = new System.Drawing.Size(309, 125);
            this.rtbIngedients.TabIndex = 3;
            this.rtbIngedients.Text = "";
            // 
            // rtbSteps
            // 
            this.rtbSteps.BackColor = System.Drawing.Color.White;
            this.rtbSteps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSteps.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbSteps.Location = new System.Drawing.Point(23, 256);
            this.rtbSteps.Name = "rtbSteps";
            this.rtbSteps.ReadOnly = true;
            this.rtbSteps.Size = new System.Drawing.Size(615, 201);
            this.rtbSteps.TabIndex = 2;
            this.rtbSteps.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(23, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 150);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 216);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(121, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Как готовить:";
            // 
            // FormWithRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 480);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rtbSteps);
            this.Controls.Add(this.rtbIngedients);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(660, 480);
            this.MinimumSize = new System.Drawing.Size(660, 480);
            this.Name = "FormWithRecipe";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Name";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.RichTextBox rtbIngedients;
        public System.Windows.Forms.RichTextBox rtbSteps;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}