using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;

namespace DensanGameManager
{
    public partial class Top : Form
    {
        Dictionary<string, Game> gameDetail;
        string currentSelectGamePath;
        public Top()
        {
            InitializeComponent();
            currentSelectGamePath = "";
            gameDetail = new Dictionary<string, Game>();
            List<Game> gameList = DataEdit.LoadGameList();
            if (gameList != null)
            {
                foreach (var game in gameList)
                {
                    GameList.Items.Add(game.Title);
                    gameDetail[game.Title] = game;
                }
            }
        }

        /// <summary>
        /// Close Game Manager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Open "Add Game"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
        }


        /// <summary>
        /// Application restart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /// <summary>
        /// Show Game Info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GameList.SelectedItem.ToString() == null)
                return;
            Game game = gameDetail[GameList.SelectedItem.ToString()];
            GameInfo.Text = game.Info.Replace("<br>", Environment.NewLine);
            GamePicture.ImageLocation = game.ImagePath;
            Debug.WriteLine(game.Path);
            currentSelectGamePath = game.Path;
        }

        private void GamePlay_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(currentSelectGamePath);
            Process.Start(currentSelectGamePath);
        }
    }
}
