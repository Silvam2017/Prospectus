using Microsoft.EntityFrameworkCore.Migrations;

namespace Prospectus.Migrations
{
    public partial class addPlayerTableToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    player_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    player = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    team_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    player_game_count = table.Column<int>(type: "int", nullable: false),
                    accuracy_percent = table.Column<int>(type: "int", nullable: false),
                    aimed_passes = table.Column<int>(type: "int", nullable: false),
                    attempts = table.Column<int>(type: "int", nullable: false),
                    avg_depth_of_target = table.Column<int>(type: "int", nullable: false),
                    avg_time_to_throw = table.Column<int>(type: "int", nullable: false),
                    bats = table.Column<int>(type: "int", nullable: false),
                    big_time_throws = table.Column<int>(type: "int", nullable: false),
                    btt_rate = table.Column<int>(type: "int", nullable: false),
                    completion_percent = table.Column<int>(type: "int", nullable: false),
                    completions = table.Column<int>(type: "int", nullable: false),
                    declined_penalties = table.Column<int>(type: "int", nullable: false),
                    def_gen_pressures = table.Column<int>(type: "int", nullable: false),
                    drop_rate = table.Column<int>(type: "int", nullable: false),
                    dropbacks = table.Column<int>(type: "int", nullable: false),
                    drops = table.Column<int>(type: "int", nullable: false),
                    first_downs = table.Column<int>(type: "int", nullable: false),
                    franchise_id = table.Column<int>(type: "int", nullable: false),
                    grades_hands_fumble = table.Column<int>(type: "int", nullable: false),
                    grades_offense = table.Column<int>(type: "int", nullable: false),
                    grades_pass = table.Column<int>(type: "int", nullable: false),
                    grades_run = table.Column<int>(type: "int", nullable: false),
                    hit_as_threw = table.Column<int>(type: "int", nullable: false),
                    interceptions = table.Column<int>(type: "int", nullable: false),
                    passing_snaps = table.Column<int>(type: "int", nullable: false),
                    penalties = table.Column<int>(type: "int", nullable: false),
                    pressure_to_sack_rate = table.Column<int>(type: "int", nullable: false),
                    qb_rating = table.Column<int>(type: "int", nullable: false),
                    sack_percent = table.Column<int>(type: "int", nullable: false),
                    sacks = table.Column<int>(type: "int", nullable: false),
                    scrambles = table.Column<int>(type: "int", nullable: false),
                    spikes = table.Column<int>(type: "int", nullable: false),
                    thrown_aways = table.Column<int>(type: "int", nullable: false),
                    touchdowns = table.Column<int>(type: "int", nullable: false),
                    turnover_worthy_plays = table.Column<int>(type: "int", nullable: false),
                    twp_rate = table.Column<int>(type: "int", nullable: false),
                    yards = table.Column<int>(type: "int", nullable: false),
                    ypa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.player_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player");
        }
    }
}
