namespace Excel_Json
{
    partial class From1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.Convertbutton = new System.Windows.Forms.Button();
            this.ColtextBox = new System.Windows.Forms.TextBox();
            this.Colbutton = new System.Windows.Forms.Button();
            this.Rowbutton = new System.Windows.Forms.Button();
            this.RowtextBox = new System.Windows.Forms.TextBox();
            this.SavetextBox = new System.Windows.Forms.TextBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.ShowtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSelectFile.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSelectFile.Location = new System.Drawing.Point(1194, 68);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(200, 50);
            this.buttonSelectFile.TabIndex = 0;
            this.buttonSelectFile.Text = "打开文件";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxFilePath.Location = new System.Drawing.Point(107, 68);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(1055, 50);
            this.textBoxFilePath.TabIndex = 1;
            // 
            // Convertbutton
            // 
            this.Convertbutton.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Convertbutton.Location = new System.Drawing.Point(1194, 809);
            this.Convertbutton.Name = "Convertbutton";
            this.Convertbutton.Size = new System.Drawing.Size(200, 50);
            this.Convertbutton.TabIndex = 2;
            this.Convertbutton.Text = "转化";
            this.Convertbutton.UseVisualStyleBackColor = true;
            this.Convertbutton.Click += new System.EventHandler(this.Convertbutton_Click);
            // 
            // ColtextBox
            // 
            this.ColtextBox.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ColtextBox.Location = new System.Drawing.Point(107, 159);
            this.ColtextBox.Name = "ColtextBox";
            this.ColtextBox.Size = new System.Drawing.Size(425, 50);
            this.ColtextBox.TabIndex = 3;
            this.ColtextBox.Text = "变量名的列(如B请输入2)";
            // 
            // Colbutton
            // 
            this.Colbutton.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Colbutton.Location = new System.Drawing.Point(557, 159);
            this.Colbutton.Name = "Colbutton";
            this.Colbutton.Size = new System.Drawing.Size(167, 54);
            this.Colbutton.TabIndex = 4;
            this.Colbutton.Text = "确定COL";
            this.Colbutton.UseVisualStyleBackColor = true;
            this.Colbutton.Click += new System.EventHandler(this.Colbutton_Click);
            // 
            // Rowbutton
            // 
            this.Rowbutton.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Rowbutton.Location = new System.Drawing.Point(1194, 163);
            this.Rowbutton.Name = "Rowbutton";
            this.Rowbutton.Size = new System.Drawing.Size(200, 50);
            this.Rowbutton.TabIndex = 6;
            this.Rowbutton.Text = "确定ROW";
            this.Rowbutton.UseVisualStyleBackColor = true;
            this.Rowbutton.Click += new System.EventHandler(this.Rowbutton_Click);
            // 
            // RowtextBox
            // 
            this.RowtextBox.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RowtextBox.Location = new System.Drawing.Point(775, 163);
            this.RowtextBox.Name = "RowtextBox";
            this.RowtextBox.Size = new System.Drawing.Size(387, 50);
            this.RowtextBox.TabIndex = 5;
            this.RowtextBox.Text = "从第几行开始";
            // 
            // SavetextBox
            // 
            this.SavetextBox.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SavetextBox.Location = new System.Drawing.Point(107, 248);
            this.SavetextBox.Name = "SavetextBox";
            this.SavetextBox.Size = new System.Drawing.Size(1055, 50);
            this.SavetextBox.TabIndex = 7;
            // 
            // Savebutton
            // 
            this.Savebutton.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Savebutton.Location = new System.Drawing.Point(1194, 248);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(200, 50);
            this.Savebutton.TabIndex = 8;
            this.Savebutton.Text = "选择路径";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // ShowtextBox
            // 
            this.ShowtextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowtextBox.Location = new System.Drawing.Point(107, 344);
            this.ShowtextBox.Multiline = true;
            this.ShowtextBox.Name = "ShowtextBox";
            this.ShowtextBox.Size = new System.Drawing.Size(1055, 515);
            this.ShowtextBox.TabIndex = 9;
            // 
            // From1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 974);
            this.Controls.Add(this.ShowtextBox);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.SavetextBox);
            this.Controls.Add(this.Rowbutton);
            this.Controls.Add(this.RowtextBox);
            this.Controls.Add(this.Colbutton);
            this.Controls.Add(this.ColtextBox);
            this.Controls.Add(this.Convertbutton);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.buttonSelectFile);
            this.Name = "From1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button Convertbutton;
        private System.Windows.Forms.TextBox ColtextBox;
        private System.Windows.Forms.Button Colbutton;
        private System.Windows.Forms.Button Rowbutton;
        private System.Windows.Forms.TextBox RowtextBox;
        private System.Windows.Forms.TextBox SavetextBox;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.TextBox ShowtextBox;
    }
}

