namespace CookbookApplication
{
    partial class MainApplicationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mLeftSidePanel = new MetroFramework.Controls.MetroPanel();
            this.mListDishes = new MetroFramework.Controls.MetroPanel();
            this.mRecipesPanel = new MetroFramework.Controls.MetroPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mButtonFilter = new MetroFramework.Controls.MetroTile();
            this.mButtonFind = new MetroFramework.Controls.MetroTile();
            this.mButtonAdd = new MetroFramework.Controls.MetroTile();
            this.carts1 = new CookbookApplication.Carts();
            this.carts2 = new CookbookApplication.Carts();
            this.carts3 = new CookbookApplication.Carts();
            this.carts4 = new CookbookApplication.Carts();
            this.carts5 = new CookbookApplication.Carts();
            this.mLeftSidePanel.SuspendLayout();
            this.mListDishes.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mLeftSidePanel
            // 
            this.mLeftSidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mLeftSidePanel.BackColor = System.Drawing.Color.White;
            this.mLeftSidePanel.Controls.Add(this.mButtonFilter);
            this.mLeftSidePanel.Controls.Add(this.mButtonFind);
            this.mLeftSidePanel.Controls.Add(this.mButtonAdd);
            this.mLeftSidePanel.HorizontalScrollbarBarColor = true;
            this.mLeftSidePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mLeftSidePanel.HorizontalScrollbarSize = 10;
            this.mLeftSidePanel.Location = new System.Drawing.Point(2, 63);
            this.mLeftSidePanel.Name = "mLeftSidePanel";
            this.mLeftSidePanel.Size = new System.Drawing.Size(60, 394);
            this.mLeftSidePanel.TabIndex = 0;
            this.mLeftSidePanel.VerticalScrollbarBarColor = true;
            this.mLeftSidePanel.VerticalScrollbarHighlightOnWheel = false;
            this.mLeftSidePanel.VerticalScrollbarSize = 10;
            // 
            // mListDishes
            // 
            this.mListDishes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mListDishes.Controls.Add(this.flowLayoutPanel1);
            this.mListDishes.HorizontalScrollbarBarColor = true;
            this.mListDishes.HorizontalScrollbarHighlightOnWheel = false;
            this.mListDishes.HorizontalScrollbarSize = 10;
            this.mListDishes.Location = new System.Drawing.Point(68, 63);
            this.mListDishes.Margin = new System.Windows.Forms.Padding(10);
            this.mListDishes.Name = "mListDishes";
            this.mListDishes.Size = new System.Drawing.Size(361, 394);
            this.mListDishes.Style = MetroFramework.MetroColorStyle.Blue;
            this.mListDishes.TabIndex = 1;
            this.mListDishes.VerticalScrollbarBarColor = true;
            this.mListDishes.VerticalScrollbarHighlightOnWheel = false;
            this.mListDishes.VerticalScrollbarSize = 10;
            // 
            // mRecipesPanel
            // 
            this.mRecipesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mRecipesPanel.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.mRecipesPanel.HorizontalScrollbarBarColor = true;
            this.mRecipesPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mRecipesPanel.HorizontalScrollbarSize = 10;
            this.mRecipesPanel.Location = new System.Drawing.Point(435, 63);
            this.mRecipesPanel.Name = "mRecipesPanel";
            this.mRecipesPanel.Size = new System.Drawing.Size(316, 394);
            this.mRecipesPanel.Style = MetroFramework.MetroColorStyle.Blue;
            this.mRecipesPanel.TabIndex = 2;
            this.mRecipesPanel.VerticalScrollbarBarColor = true;
            this.mRecipesPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mRecipesPanel.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.carts4);
            this.flowLayoutPanel1.Controls.Add(this.carts1);
            this.flowLayoutPanel1.Controls.Add(this.carts2);
            this.flowLayoutPanel1.Controls.Add(this.carts3);
            this.flowLayoutPanel1.Controls.Add(this.carts5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 27);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(332, 364);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // mButtonFilter
            // 
            this.mButtonFilter.ForeColor = System.Drawing.Color.White;
            this.mButtonFilter.Location = new System.Drawing.Point(5, 139);
            this.mButtonFilter.Name = "mButtonFilter";
            this.mButtonFilter.Size = new System.Drawing.Size(50, 50);
            this.mButtonFilter.Style = MetroFramework.MetroColorStyle.Silver;
            this.mButtonFilter.TabIndex = 2;
            this.mButtonFilter.Text = "Filter";
            this.mButtonFilter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mButtonFilter.TileImage = global::CookbookApplication.Properties.Resources.Filter;
            this.mButtonFilter.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mButtonFilter.UseTileImage = true;
            // 
            // mButtonFind
            // 
            this.mButtonFind.ForeColor = System.Drawing.Color.White;
            this.mButtonFind.Location = new System.Drawing.Point(5, 83);
            this.mButtonFind.Name = "mButtonFind";
            this.mButtonFind.Size = new System.Drawing.Size(50, 50);
            this.mButtonFind.Style = MetroFramework.MetroColorStyle.Silver;
            this.mButtonFind.TabIndex = 2;
            this.mButtonFind.Text = "Find";
            this.mButtonFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mButtonFind.TileImage = global::CookbookApplication.Properties.Resources.Find;
            this.mButtonFind.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mButtonFind.UseTileImage = true;
            // 
            // mButtonAdd
            // 
            this.mButtonAdd.ForeColor = System.Drawing.Color.White;
            this.mButtonAdd.Location = new System.Drawing.Point(5, 27);
            this.mButtonAdd.Name = "mButtonAdd";
            this.mButtonAdd.Size = new System.Drawing.Size(50, 50);
            this.mButtonAdd.Style = MetroFramework.MetroColorStyle.Silver;
            this.mButtonAdd.TabIndex = 2;
            this.mButtonAdd.Text = "Add";
            this.mButtonAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mButtonAdd.TileImage = global::CookbookApplication.Properties.Resources.Add1;
            this.mButtonAdd.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mButtonAdd.UseTileImage = true;
            // 
            // carts1
            // 
            this.carts1.Location = new System.Drawing.Point(3, 139);
            this.carts1.Name = "carts1";
            this.carts1.Size = new System.Drawing.Size(300, 130);
            this.carts1.TabIndex = 0;
            // 
            // carts2
            // 
            this.carts2.Location = new System.Drawing.Point(3, 275);
            this.carts2.Name = "carts2";
            this.carts2.Size = new System.Drawing.Size(300, 130);
            this.carts2.TabIndex = 1;
            // 
            // carts3
            // 
            this.carts3.Location = new System.Drawing.Point(3, 411);
            this.carts3.Name = "carts3";
            this.carts3.Size = new System.Drawing.Size(300, 130);
            this.carts3.TabIndex = 1;
            // 
            // carts4
            // 
            this.carts4.Location = new System.Drawing.Point(3, 3);
            this.carts4.Name = "carts4";
            this.carts4.Size = new System.Drawing.Size(300, 130);
            this.carts4.TabIndex = 1;
            // 
            // carts5
            // 
            this.carts5.Location = new System.Drawing.Point(3, 547);
            this.carts5.Name = "carts5";
            this.carts5.Size = new System.Drawing.Size(300, 130);
            this.carts5.TabIndex = 1;
            // 
            // MainApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(760, 480);
            this.Controls.Add(this.mRecipesPanel);
            this.Controls.Add(this.mListDishes);
            this.Controls.Add(this.mLeftSidePanel);
            this.MinimumSize = new System.Drawing.Size(760, 480);
            this.Name = "MainApplicationForm";
            this.Text = "Cookbook";
            this.SizeChanged += new System.EventHandler(this.MainApplicationForm_SizeChanged);
            this.mLeftSidePanel.ResumeLayout(false);
            this.mListDishes.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mLeftSidePanel;
        private MetroFramework.Controls.MetroTile mButtonFilter;
        private MetroFramework.Controls.MetroTile mButtonFind;
        private MetroFramework.Controls.MetroTile mButtonAdd;
        private MetroFramework.Controls.MetroPanel mListDishes;
        private MetroFramework.Controls.MetroPanel mRecipesPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Carts carts1;
        private Carts carts2;
        private Carts carts3;
        private Carts carts4;
        private Carts carts5;
    }
}

