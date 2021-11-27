using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class GameView
    {
        public int ID { get; set; }
        public string HomeClubName { get; set; }
        public string AwayClubName { get; set; }
        public int HomeFinalScore { get; set; }
        public int AwayFinalScore { get; set; }
        public int Week { get; set; }
        public int Year { get; set; }
    }
}
