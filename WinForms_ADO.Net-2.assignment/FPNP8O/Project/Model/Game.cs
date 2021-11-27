using System;

namespace Project.Model
{
    public class Game
    {
        public int ID { get; set; }
        public string HomeClubName { get; set; }
        public string AwayClubName { get; set; }
        public int HomeFinalScore { get; set; }
        public int AwayFinalScore { get; set; }
        public int HomeNumberOfTD { get; set; }
        public int AwayNumberOfTD { get; set; }
        public int Week { get; set; }
        public int Year { get; set; }
    }
}