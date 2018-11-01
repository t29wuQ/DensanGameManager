namespace DensanGameManager
{
    partial class Top
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.GameList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GamePicture = new System.Windows.Forms.PictureBox();
            this.GameInfo = new System.Windows.Forms.TextBox();
            this.GamePlay = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // GameList
            // 
            this.GameList.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GameList.FormattingEnabled = true;
            this.GameList.ItemHeight = 97;
            this.GameList.Location = new System.Drawing.Point(0, 48);
            this.GameList.Name = "GameList";
            this.GameList.Size = new System.Drawing.Size(960, 1265);
            this.GameList.TabIndex = 0;
            this.GameList.SelectedIndexChanged += new System.EventHandler(this.GameList_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reloadToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1782, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(70, 36);
            this.fileToolStripMenuItem.Text = "Add";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(100, 36);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(73, 36);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // GamePicture
            // 
            this.GamePicture.Location = new System.Drawing.Point(966, 48);
            this.GamePicture.Name = "GamePicture";
            this.GamePicture.Size = new System.Drawing.Size(804, 604);
            this.GamePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GamePicture.TabIndex = 2;
            this.GamePicture.TabStop = false;
            // 
            // GameInfo
            // 
            this.GameInfo.Font = new System.Drawing.Font("MS UI Gothic", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GameInfo.Location = new System.Drawing.Point(966, 658);
            this.GameInfo.Multiline = true;
            this.GameInfo.Name = "GameInfo";
            this.GameInfo.ReadOnly = true;
            this.GameInfo.Size = new System.Drawing.Size(804, 586);
            this.GameInfo.TabIndex = 3;
            // 
            // GamePlay
            // 
            this.GamePlay.Location = new System.Drawing.Point(966, 1250);
            this.GamePlay.Name = "GamePlay";
            this.GamePlay.Size = new System.Drawing.Size(165, 76);
            this.GamePlay.TabIndex = 4;
            this.GamePlay.Text = "Play";
            this.GamePlay.UseVisualStyleBackColor = true;
            this.GamePlay.Click += new System.EventHandler(this.GamePlay_Click);
            // 
            // Top
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1782, 1338);
            this.Controls.Add(this.GamePlay);
            this.Controls.Add(this.GameInfo);
            this.Controls.Add(this.GamePicture);
            this.Controls.Add(this.GameList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Top";
            this.Text = "Kindai Univ Csg Game Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox GameList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.PictureBox GamePicture;
        private System.Windows.Forms.TextBox GameInfo;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.Button GamePlay;
    }
}

