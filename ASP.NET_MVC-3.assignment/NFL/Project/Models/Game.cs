using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Game
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string HomeClubName { get; set; }
        [Required]
        public string AwayClubName { get; set; }
        [Required]
        public int HomeFinalScore { get; set; }
        [Required]
        public int AwayFinalScore { get; set; }
        [Required]
        public int HomeNumberOfTD { get; set; }
        [Required]
        public int AwayNumberOfTD { get; set; }
        [Required]
        public int Week { get; set; }
        [Required]
        public int Year { get; set; }
    }
}
