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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbSearch = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mButtonFind = new MetroFramework.Controls.MetroTile();
            this.mButtonAdd = new MetroFramework.Controls.MetroTile();
            this.mLeftSidePanel.SuspendLayout();
            this.mListDishes.SuspendLayout();
            this.SuspendLayout();
            // 
            // mLeftSidePanel
            // 
            this.mLeftSidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mLeftSidePanel.BackColor = System.Drawing.Color.White;
            this.mLeftSidePanel.Controls.Add(this.mButtonAdd);
            this.mLeftSidePanel.HorizontalScrollbarBarColor = true;
            this.mLeftSidePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mLeftSidePanel.HorizontalScrollbarSize = 10;
            this.mLeftSidePanel.Location = new System.Drawing.Point(2, 63);
            this.mLeftSidePanel.Name = "mLeftSidePanel";
            this.mLeftSidePanel.Size = new System.Drawing.Size(60, 394);
            this.mLeftSidePanel.TabIndex = 0;
            this.mLeftSidePanel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mLeftSidePanel.VerticalScrollbarBarColor = true;
            this.mLeftSidePanel.VerticalScrollbarHighlightOnWheel = false;
            this.mLeftSidePanel.VerticalScrollbarSize = 10;
            // 
            // mListDishes
            // 
            this.mListDishes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mListDishes.Controls.Add(this.label1);
            this.mListDishes.Controls.Add(this.flowLayoutPanel1);
            this.mListDishes.Controls.Add(this.mButtonFind);
            this.mListDishes.HorizontalScrollbarBarColor = true;
            this.mListDishes.HorizontalScrollbarHighlightOnWheel = false;
            this.mListDishes.HorizontalScrollbarSize = 10;
            this.mListDishes.Location = new System.Drawing.Point(68, 63);
            this.mListDishes.Margin = new System.Windows.Forms.Padding(10);
            this.mListDishes.Name = "mListDishes";
            this.mListDishes.Size = new System.Drawing.Size(683, 394);
            this.mListDishes.Style = MetroFramework.MetroColorStyle.Blue;
            this.mListDishes.TabIndex = 1;
            this.mListDishes.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mListDishes.VerticalScrollbarBarColor = true;
            this.mListDishes.VerticalScrollbarHighlightOnWheel = false;
            this.mListDishes.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 27);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(654, 364);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(198, 66);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(161, 23);
            this.tbSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поиск по названию:";
            // 
            // mButtonFind
            // 
            this.mButtonFind.ForeColor = System.Drawing.Color.White;
            this.mButtonFind.Location = new System.Drawing.Point(292, 3);
            this.mButtonFind.Name = "mButtonFind";
            this.mButtonFind.Size = new System.Drawing.Size(29, 23);
            this.mButtonFind.Style = MetroFramework.MetroColorStyle.Silver;
            this.mButtonFind.TabIndex = 2;
            this.mButtonFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mButtonFind.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mButtonFind.TileImage = global::CookbookApplication.Properties.Resources.Find;
            this.mButtonFind.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mButtonFind.UseTileImage = true;
            this.mButtonFind.Click += new System.EventHandler(this.mButtonFind_Click);
            // 
            // mButtonAdd
            // 
            this.mButtonAdd.ForeColor = System.Drawing.Color.White;
            this.mButtonAdd.Location = new System.Drawing.Point(5, 27);
            this.mButtonAdd.Name = "mButtonAdd";
            this.mButtonAdd.Size = new System.Drawing.Size(50, 50);
            this.mButtonAdd.Style = MetroFramework.MetroColorStyle.Silver;
            this.mButtonAdd.TabIndex = 2;
            this.mButtonAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mButtonAdd.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mButtonAdd.TileImage = global::CookbookApplication.Properties.Resources.Add1;
            this.mButtonAdd.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mButtonAdd.UseTileImage = true;
            this.mButtonAdd.Click += new System.EventHandler(this.mButtonAdd_Click);
            // 
            // MainApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(760, 480);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.mListDishes);
            this.Controls.Add(this.mLeftSidePanel);
            this.MinimumSize = new System.Drawing.Size(760, 480);
            this.Name = "MainApplicationForm";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Кулинарная книга";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.MainApplicationForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainApplicationForm_SizeChanged);
            this.mLeftSidePanel.ResumeLayout(false);
            this.mListDishes.ResumeLayout(false);
            this.mListDishes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mLeftSidePanel;
        private MetroFramework.Controls.MetroTile mButtonFind;
        private MetroFramework.Controls.MetroTile mButtonAdd;
        private MetroFramework.Controls.MetroPanel mListDishes;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroTextBox tbSearch;
        private System.Windows.Forms.Label label1;
    }
}

