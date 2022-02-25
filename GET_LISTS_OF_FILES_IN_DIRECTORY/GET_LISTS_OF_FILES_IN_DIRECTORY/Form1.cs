using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //Описание и инициализация 

        #region Блок инициализации 
        
        public Form1()
        {
            InitializeComponent();
        }

        #endregion


        #region Событие: Получить адресс каталога

        private void GetPathOfDirectoryButton_Click_1(object sender, EventArgs e)
        {
            switch (folderBrowserDialog.ShowDialog())
            {
                case DialogResult.OK: PathFolderBox.Text = folderBrowserDialog.SelectedPath;
                    break;
            }
        }

        #endregion 

        #region Событие:

        private void GetListsOfFiles_Click(object sender, EventArgs e)
        {
            try
            {
                string[] filePaths = Directory.GetFiles(PathFolderBox.Text.Trim());
                ListOfFIles.Clear();
                if (filePaths.Length>0)
                {
                    for (int i = 0; i < filePaths.Length; i++)
                    {
                        ListOfFIles.AppendText(Path.GetFileName(filePaths[i])+"\r\n");
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            
        }


        #endregion

     
        
    }
}
