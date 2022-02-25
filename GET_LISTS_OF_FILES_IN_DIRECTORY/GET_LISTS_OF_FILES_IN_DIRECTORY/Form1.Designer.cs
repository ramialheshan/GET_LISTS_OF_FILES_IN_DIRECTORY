namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetListsOfFiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PathFolderBox = new System.Windows.Forms.TextBox();
            this.GetPathOfDirectoryButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ListOfFIles = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // GetListsOfFiles
            // 
            this.GetListsOfFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetListsOfFiles.Location = new System.Drawing.Point(455, 12);
            this.GetListsOfFiles.Name = "GetListsOfFiles";
            this.GetListsOfFiles.Size = new System.Drawing.Size(89, 31);
            this.GetListsOfFiles.TabIndex = 0;
            this.GetListsOfFiles.Text = "ПОЛУЧИТЬ";
            this.GetListsOfFiles.UseVisualStyleBackColor = true;
            this.GetListsOfFiles.Click += new System.EventHandler(this.GetListsOfFiles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "АДРЕС КАТАЛОГА:";
            // 
            // PathFolderBox
            // 
            this.PathFolderBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PathFolderBox.Location = new System.Drawing.Point(140, 18);
            this.PathFolderBox.Name = "PathFolderBox";
            this.PathFolderBox.Size = new System.Drawing.Size(276, 20);
            this.PathFolderBox.TabIndex = 2;
            // 
            // GetPathOfDirectoryButton
            // 
            this.GetPathOfDirectoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetPathOfDirectoryButton.Location = new System.Drawing.Point(416, 17);
            this.GetPathOfDirectoryButton.Name = "GetPathOfDirectoryButton";
            this.GetPathOfDirectoryButton.Size = new System.Drawing.Size(25, 21);
            this.GetPathOfDirectoryButton.TabIndex = 0;
            this.GetPathOfDirectoryButton.Text = "...";
            this.GetPathOfDirectoryButton.UseVisualStyleBackColor = true;
            this.GetPathOfDirectoryButton.Click += new System.EventHandler(this.GetPathOfDirectoryButton_Click_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "СПИСОК ФАЙЛОВ КАТАЛОГА:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ListOfFIles
            // 
            this.ListOfFIles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ListOfFIles.Location = new System.Drawing.Point(140, 49);
            this.ListOfFIles.Name = "ListOfFIles";
            this.ListOfFIles.Size = new System.Drawing.Size(404, 148);
            this.ListOfFIles.TabIndex = 3;
            this.ListOfFIles.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 209);
            this.Controls.Add(this.ListOfFIles);
            this.Controls.Add(this.PathFolderBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetPathOfDirectoryButton);
            this.Controls.Add(this.GetListsOfFiles);
            this.MinimumSize = new System.Drawing.Size(564, 243);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "СПИСОК ФАЙЛОВ В КАТАЛОГЕ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetListsOfFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PathFolderBox;
        private System.Windows.Forms.Button GetPathOfDirectoryButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox ListOfFIles;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

