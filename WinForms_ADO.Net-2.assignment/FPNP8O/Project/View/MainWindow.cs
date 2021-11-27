using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Controller;
using Project.Model;

namespace Project.View
{
    public partial class MainWindow : Form
    {
        private readonly GameController controller;

        public MainWindow()
        {
            InitializeComponent();
            this.toolStripMenuItem1.Click += AddGameMenuItem_Click;
            this.toolStripMenuItem2.Click += ListGameMenuItem_Click;

            controller = new GameController(new DAO.GameDAOImp());
        }

        private void ListGameMenuItem_Click(object sender, EventArgs e)
        {
            var games = controller.GetGames();
            List<GameView> gameView = new List<GameView>();

            foreach(var item in games)
            {
                gameView.Add(new GameView
                {
                    ID = item.ID,
                    HomeClubName = item.HomeClubName,
                    AwayClubName = item.AwayClubName,
                    HomeFinalScore = item.HomeFinalScore,
                    AwayFinalScore = item.AwayFinalScore,
                    Week = item.Week,
                    Year = item.Year
                });
            }

            var s = from g in gameView
                    orderby g.Week descending
                    orderby g.Year descending
                    select g;

            List<GameView> resultList = new List<GameView>();

            foreach (var item in s)
            {
                resultList.Add(item);
            }


            gamesDataGridView.DataSource = null;
            gamesDataGridView.DataSource = resultList;
            gamesDataGridView.Visible = true;
        }

        private void AddGameMenuItem_Click(object sender, EventArgs e)
        {
            using var addGameForm = new AddGame(controller);
            addGameForm.ShowDialog();
        }

        private void itemClicked(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!(gamesDataGridView.CurrentRow.DataBoundItem is GameView gameView))
                return;

            using var addGameForm = new AddGame(controller, gameView);
            addGameForm.ShowDialog();
        }
    }
}
