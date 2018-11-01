namespace DensanGameManager
{
    partial class Add
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
            this.label1 = new System.Windows.Forms.Label();
            this.GameTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GamePath = new System.Windows.Forms.TextBox();
            this.OpenDialogGame = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.GameImagePath = new System.Windows.Forms.TextBox();
            this.OpenDialogImage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.GameInfo = new System.Windows.Forms.TextBox();
            this.GameAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // GameTitle
            // 
            this.GameTitle.Location = new System.Drawing.Point(18, 64);
            this.GameTitle.Name = "GameTitle";
            this.GameTitle.Size = new System.Drawing.Size(770, 31);
            this.GameTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Open File";
            // 
            // GamePath
            // 
            this.GamePath.Location = new System.Drawing.Point(12, 175);
            this.GamePath.Name = "GamePath";
            this.GamePath.Size = new System.Drawing.Size(644, 31);
            this.GamePath.TabIndex = 3;
            // 
            // OpenDialogGame
            // 
            this.OpenDialogGame.Font = new System.Drawing.Font("MS UI Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OpenDialogGame.Location = new System.Drawing.Point(675, 169);
            this.OpenDialogGame.Name = "OpenDialogGame";
            this.OpenDialogGame.Size = new System.Drawing.Size(113, 43);
            this.OpenDialogGame.TabIndex = 4;
            this.OpenDialogGame.Text = "Open";
            this.OpenDialogGame.UseVisualStyleBackColor = true;
            this.OpenDialogGame.Click += new System.EventHandler(this.OpenDialogGame_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Game Image";
            // 
            // GameImagePath
            // 
            this.GameImagePath.Location = new System.Drawing.Point(12, 279);
            this.GameImagePath.Name = "GameImagePath";
            this.GameImagePath.Size = new System.Drawing.Size(644, 31);
            this.GameImagePath.TabIndex = 6;
            // 
            // OpenDialogImage
            // 
            this.OpenDialogImage.Font = new System.Drawing.Font("MS UI Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OpenDialogImage.Location = new System.Drawing.Point(675, 273);
            this.OpenDialogImage.Name = "OpenDialogImage";
            this.OpenDialogImage.Size = new System.Drawing.Size(113, 43);
            this.OpenDialogImage.TabIndex = 7;
            this.OpenDialogImage.Text = "Open";
            this.OpenDialogImage.UseVisualStyleBackColor = true;
            this.OpenDialogImage.Click += new System.EventHandler(this.OpenDialogImage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(6, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Game Info";
            // 
            // GameInfo
            // 
            this.GameInfo.Location = new System.Drawing.Point(12, 385);
            this.GameInfo.Multiline = true;
            this.GameInfo.Name = "GameInfo";
            this.GameInfo.Size = new System.Drawing.Size(776, 351);
            this.GameInfo.TabIndex = 9;
            // 
            // GameAdd
            // 
            this.GameAdd.Location = new System.Drawing.Point(12, 774);
            this.GameAdd.Name = "GameAdd";
            this.GameAdd.Size = new System.Drawing.Size(105, 49);
            this.GameAdd.TabIndex = 10;
            this.GameAdd.Text = "Add";
            this.GameAdd.UseVisualStyleBackColor = true;
            this.GameAdd.Click += new System.EventHandler(this.GameAdd_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 846);
            this.Controls.Add(this.GameAdd);
            this.Controls.Add(this.GameInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OpenDialogImage);
            this.Controls.Add(this.GameImagePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OpenDialogGame);
            this.Controls.Add(this.GamePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GameTitle);
            this.Controls.Add(this.label1);
            this.Name = "Add";
            this.Text = "Add Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GameTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GamePath;
        private System.Windows.Forms.Button OpenDialogGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GameImagePath;
        private System.Windows.Forms.Button OpenDialogImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GameInfo;
        private System.Windows.Forms.Button GameAdd;
    }
}