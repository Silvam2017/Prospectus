using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// This allows us to use Data Annotations
using System.ComponentModel.DataAnnotations;

namespace Prospectus.Models
// Use decimal data type for any numerical data with decimal values
// Use string for data with text values
// Use Int data type for numerical data with no decimal places
{
    public class Player
    {
        [Display(Name = "Name")]
        // Add requirement for player name within the model
        [Required(ErrorMessage = "Full Player Name is required.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "You must provide first and last name.")]
        public string player { get; set; }
        // Data Annotations modify the model
        // Player ID is easier to read for the end user than player_id
        [Key]
        [Display(Name = "Player ID")]
        // Limit player id to a range of all three, four, and five digit numbers
        [Range(1, 99999, ErrorMessage = "player_id must be between 1 and 100,000.")]
        public int player_id { get; set; }
        [Display(Name = "Position")]
        public string position { get; set; }
        [Display(Name = "Team Name")]
        public string team_name { get; set; }
        [Display(Name = "Games Played")]
        public int player_game_count { get; set; }
        [Display(Name = "Accuracy Percent")]
        public decimal accuracy_percent { get; set; }
        [Display(Name = "Aimed Passes")]
        public int aimed_passes { get; set; }
        [Display(Name = "Attempts")]
        public int attempts { get; set; }
        [Display(Name = "Average Depth of Target")]
        public decimal avg_depth_of_target { get; set; }
        [Display(Name = "Average Time to Throw")]
        public decimal avg_time_to_throw { get; set; }
        [Display(Name = "Bats")]
        public int bats { get; set; }
        [Display(Name = "Big Time Throws")]
        public int big_time_throws { get; set; }
        [Display(Name = "Big Time Throw Rate")]
        public decimal btt_rate { get; set; }
        [Display(Name = "Completion Percent")]
        public decimal completion_percent { get; set; }
        [Display(Name = "Completions")]
        public int completions { get; set; }
        [Display(Name = "Declined Penalties")]
        public int declined_penalties { get; set; }
        [Display(Name = "Defensive Generated Pressures")]
        public int def_gen_pressures { get; set; }
        [Display(Name = "Drop Rate")]
        public decimal drop_rate { get; set; }
        [Display(Name = "Dropbacks")]
        public int dropbacks { get; set; }
        [Display(Name = "Drops")]
        public int drops { get; set; }
        [Display(Name = "First Downs")]
        public int first_downs { get; set; }
        [Display(Name = "Franchise ID")]
        public int franchise_id { get; set; }
        [Display(Name = "Fumble Grade")]
        public decimal grades_hands_fumble { get; set; }
        [Display(Name = "Offensive Grade")]
        public decimal grades_offense { get; set; }
        [Display(Name = "Passing Grade")]
        public decimal grades_pass { get; set; }
        [Display(Name = "Running Grade")]
        public decimal grades_run { get; set; }
        [Display(Name = "Hit as Threw")]
        public int hit_as_threw { get; set; }
        [Display(Name = "Interceptions")]
        public int interceptions { get; set; }
        [Display(Name = "Passing Snaps")]
        public int passing_snaps { get; set; }
        [Display(Name = "Penalties")]
        public int penalties { get; set; }
        [Display(Name = "Pressure to Sack Rate")]
        public decimal pressure_to_sack_rate { get; set; }
        [Display(Name = "QB Rating")]
        public decimal qb_rating { get; set; }
        [Display(Name = "Sack Percent")]
        public decimal sack_percent { get; set; }
        [Display(Name = "Sacks")]
        public int sacks { get; set; }
        [Display(Name = "Scrambles")]
        public int scrambles { get; set; }
        [Display(Name = "Spikes")]
        public int spikes { get; set; }
        [Display(Name = "Thrown Aways")]
        public int thrown_aways { get; set; }
        [Display(Name = "Touchdowns")]
        public int touchdowns { get; set; }
        [Display(Name = "Turnover Worthy Plays")]
        public int turnover_worthy_plays { get; set; }
        [Display(Name = "Turnover Worthy Play Rate")]
        public decimal twp_rate { get; set; }
        [Display(Name = "Yards")]
        public int yards { get; set; }
        [Display(Name = "Yards Per Attempt")]
        public decimal ypa { get; set; }
    }
}
