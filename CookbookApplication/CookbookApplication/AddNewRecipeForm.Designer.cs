namespace CookbookApplication
{
    partial class AddNewRecipeForm
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.rtbSteps = new System.Windows.Forms.TextBox();
            this.rtbIngredients = new System.Windows.Forms.TextBox();
            this.rtbName = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(538, 425);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(93, 25);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Добавить";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 276);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(115, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Название блюда:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 327);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(94, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Ингредиенты:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(329, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Как готовить:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(206, 276);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Цена:";
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(23, 425);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(93, 25);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile2.TabIndex = 0;
            this.metroTile2.Text = "Отмена";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 60);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(98, 19);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Изображение:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(23, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // metroTile3
            // 
            this.metroTile3.Location = new System.Drawing.Point(23, 241);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(300, 25);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile3.TabIndex = 0;
            this.metroTile3.Text = "Выбрать изображение";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // rtbSteps
            // 
            this.rtbSteps.Location = new System.Drawing.Point(329, 85);
            this.rtbSteps.Multiline = true;
            this.rtbSteps.Name = "rtbSteps";
            this.rtbSteps.Size = new System.Drawing.Size(302, 334);
            this.rtbSteps.TabIndex = 5;
            // 
            // rtbIngredients
            // 
            this.rtbIngredients.Location = new System.Drawing.Point(23, 349);
            this.rtbIngredients.Multiline = true;
            this.rtbIngredients.Name = "rtbIngredients";
            this.rtbIngredients.Size = new System.Drawing.Size(300, 70);
            this.rtbIngredients.TabIndex = 5;
            // 
            // rtbName
            // 
            this.rtbName.Location = new System.Drawing.Point(24, 299);
            this.rtbName.Name = "rtbName";
            this.rtbName.Size = new System.Drawing.Size(176, 20);
            this.rtbName.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(206, 298);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(117, 20);
            this.textBox4.TabIndex = 6;
            // 
            // AddNewRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 473);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.rtbName);
            this.Controls.Add(this.rtbIngredients);
            this.Controls.Add(this.rtbSteps);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.MaximizeBox = false;
            this.Name = "AddNewRecipeForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Добавление нового рецепта";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile metroTile3;
        private System.Windows.Forms.TextBox rtbSteps;
        private System.Windows.Forms.TextBox rtbIngredients;
        private System.Windows.Forms.TextBox rtbName;
        private System.Windows.Forms.TextBox textBox4;
    }
}