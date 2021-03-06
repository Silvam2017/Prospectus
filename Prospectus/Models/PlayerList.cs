using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Prospectus.Models
{
    // IQueryable Doc
    // https://docs.microsoft.com/en-us/dotnet/api/system.collections.IQueryable?view=net-5.0
    // This is not an instance of a statList
    // Not a super, just a container
    // Keep DB logic out of model to remain SOLID
    public class PlayerListModel
    {
        // Constructor passing IQueryable of Player from DB called Players and Year
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-constructors
        public PlayerListModel(IQueryable<Player> Players, int Year)
        {
            // Instantiate each list
            List<PlayerDetailStatModel> detailedStatList = new List<PlayerDetailStatModel>();
            List<PlayerBasicStatModel> basicStatList = new List<PlayerBasicStatModel>();
            // Populate the lists
            foreach(var Player in Players)
            {
                // temporarily store each stat
                var DetailedStat = new PlayerDetailStatModel(Player);
                var BasicStat = new PlayerBasicStatModel(Player);
                // add stats to lists
                detailedStatList.Add(DetailedStat);
                basicStatList.Add(BasicStat);
            }
            // Store the Lists
            this.DetailedStatList = detailedStatList;
            this.BasicStatList = basicStatList;
            this.Year = Year;
        }

        // Children do not need Year
        [Range(1950,2021)]
        public int Year { get; set; }
        public List<PlayerDetailStatModel> DetailedStatList { get; set; }
        // LIST is the type for IQueryable
        // Does not extend PlayerListModel
        public List<PlayerBasicStatModel> BasicStatList { get; set; }
    }

    public class PlayerDetailStatModel
    {
        // Constructor
        // initializes itself with attributes from database model
        public PlayerDetailStatModel(Player databaseModel)
        {
            PlayerName = databaseModel.player;
            TeamName = databaseModel.team_name;
            AverageDepthOfTarget = databaseModel.avg_depth_of_target;
            AverageTimeToThrow = databaseModel.avg_time_to_throw;
            Drops = databaseModel.drops;
            DropRate = databaseModel.drop_rate;
            TurnoverWorthyPlays = databaseModel.turnover_worthy_plays;
            TurnoverWorthyPlayRate = databaseModel.twp_rate;
            PassGrade = databaseModel.grades_pass;
        }

        public string PlayerName { get; set; }
        public string TeamName { get; set; }
        public decimal AverageDepthOfTarget { get; set; }
        public decimal AverageTimeToThrow { get; set; }
        public int Drops { get; set; }
        public decimal DropRate { get; set; }
        public int TurnoverWorthyPlays { get; set; }
        public decimal TurnoverWorthyPlayRate { get; set; }
        public decimal PassGrade { get; set; }
    }

    public class PlayerBasicStatModel
    {
        // Constructor
        // initializes itself with attributes from database model
        public PlayerBasicStatModel(Player databaseModel)
        {
            PlayerName = databaseModel.player;
            TeamName = databaseModel.team_name;
            completions = databaseModel.completions;
            attempts = databaseModel.attempts;
            completion_percent = databaseModel.completion_percent;
            yards = databaseModel.yards;
            ypa = databaseModel.ypa;
            touchdowns = databaseModel.touchdowns;
            interceptions = databaseModel.interceptions;
        }
        // Implement a class for the basic stats found in the first grid on the page here!
        // Can have attributed replicated in each Model (PlayerName + TeamName)
        [Required]
        [StringLength(40, ErrorMessage = "Player Name cannot exceed 40 characters.")]
        public string PlayerName { get; set; }
        [Required]
        [RegularExpression(@"/^[a-z ,.'-]+$/i",
            ErrorMessage = "Team Name Invalid.")]
        [StringLength(4, ErrorMessage ="Team Name cannot exceed 4 characters.")]
        public string TeamName { get; set; }
        // Completions
        [Required]
        [Range(0, 800)]
        public int completions { get; set; }
        // Attempts
        [Required]
        [Range(0, 1000)]
        public int attempts { get; set; }
        // Completion %
        [Required]
        [Range(0, 1)]
        public decimal completion_percent { get; set; }
        // Yards
        [Required]
        [Range(0, 6000)]
        public int yards { get; set; }
        // Yards Per Attempt
        [Required]
        [Range(0, 25)]
        public decimal ypa { get; set; }
        // Touchdowns
        [Required]
        [Range(0, 60)]
        public int touchdowns { get; set; }
        // Interceptions
        [Required]
        [Range(0, 40)]
        public int interceptions { get; set; }
    }

}
