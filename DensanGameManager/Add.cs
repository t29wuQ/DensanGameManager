using System;
using System.Windows.Forms;

namespace DensanGameManager
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        /// <summary>
        /// write setting file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameAdd_Click(object sender, EventArgs e)
        {
            DataEdit.AddGame(new Game()
            {
                Title = GameTitle.Text,
                Path = GamePath.Text,
                ImagePath = GameImagePath.Text,
                Info = GameInfo.Text.Replace(Environment.NewLine, "<br>")
            });
            Application.Restart();
        }


        /// <summary>
        /// Get game file path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenDialogGame_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select game file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                GamePath.Text = dialog.FileName;
            }
        }

        /// <summary>
        /// Get game picture path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenDialogImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select game image file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                GameImagePath.Text = dialog.FileName;
            }
        }
    }
}
