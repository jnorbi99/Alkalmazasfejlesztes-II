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
    public partial class AddGame : Form
    {
        private readonly GameController controller;
        private readonly int gameID;
        private readonly bool isModification = false;

        public AddGame(GameController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        public AddGame(GameController controller, GameView gameView) : this(controller)
        {
            isModification = true;
            gameID = gameView.ID;
            var games = controller.GetGames();
            Game selectedGame = null;

            foreach(var item in games)
            {
                if(item.ID == gameID)
                {
                    selectedGame = item;
                }
            }
            
            homeClubTextBox.Text = selectedGame.HomeClubName;
            homeClubTextBox.ReadOnly = true;
            awayClubTextBox.Text = selectedGame.AwayClubName;
            awayClubTextBox.ReadOnly = true;
            homeScoreTextBox.Text = selectedGame.HomeFinalScore.ToString();
            awayScoreTextBox.Text = selectedGame.AwayFinalScore.ToString();
            homeTDTextBox.Text = selectedGame.HomeNumberOfTD.ToString();
            awayTDTextBox.Text = selectedGame.AwayNumberOfTD.ToString();
            weekUpDown.Value = selectedGame.Week;
            weekUpDown.ReadOnly = true;
            yearUpDown.Value = selectedGame.Year;
            yearUpDown.ReadOnly = true;
            submit.Text = "Modifyed";
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string homeClubName = homeClubTextBox.Text;
            string awayClubName = awayClubTextBox.Text;
            string homeScore = homeScoreTextBox.Text;
            string awayScore = awayScoreTextBox.Text;
            string homeTD = homeTDTextBox.Text;
            string awayTD = awayTDTextBox.Text;
            int week = (int)weekUpDown.Value;
            int year = (int)yearUpDown.Value;

            if(homeClubName == string.Empty || awayClubName == string.Empty || homeScore == string.Empty || awayScore == string.Empty || homeTD == string.Empty || awayTD == string.Empty)
            {
                MessageBox.Show("Kötelező minden értéket megadni!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
                return;
            }

            int homeScoreINT, awayScoreINT, homeTDINT, awayTDINT;

            if (!(Int32.TryParse(homeScore, out homeScoreINT)) || !(Int32.TryParse(awayScore, out awayScoreINT)) || !(Int32.TryParse(homeTD, out homeTDINT)) || !(Int32.TryParse(awayTD, out awayTDINT)))
            {
                MessageBox.Show("A Score és a TouchDown csak pozitív szám lehet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
                return;
            }

            if(homeScoreINT < 0 || awayScoreINT < 0 || homeTDINT < 0 || awayTDINT < 0)
            {
                MessageBox.Show("A Score és a TouchDown csak POZITÍV szám lehet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
                return;
            }

            Game game = new Game
            {
                HomeClubName = homeClubName,
                AwayClubName = awayClubName,
                HomeFinalScore = homeScoreINT,
                AwayFinalScore = awayScoreINT,
                HomeNumberOfTD = homeTDINT,
                AwayNumberOfTD = awayTDINT,
                Week = week,
                Year = year
            };

            bool result = false;
            if(isModification)
            {
                game.ID = gameID;
                result = controller.ModifyGame(game);
            } else
            {
                result = controller.AddGame(game);
            }

            if(!result)
            {
                MessageBox.Show("Valami nem oké..");
                DialogResult = DialogResult.Abort;
            } else
            {
                MessageBox.Show("Minden oké!");
                DialogResult = DialogResult.Abort;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
