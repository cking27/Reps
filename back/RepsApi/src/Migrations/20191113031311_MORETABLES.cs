using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RepsApi.Migrations
{
    public partial class MORETABLES : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    WorkoutId = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    WorkoutDayFK = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.WorkoutId);
                });

            migrationBuilder.CreateTable(
                name: "StationSets",
                columns: table => new
                {
                    StationSetId = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    StationFK = table.Column<long>(nullable: false),
                    WorkoutId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationSets", x => x.StationSetId);
                    table.ForeignKey(
                        name: "FK_StationSets_Workouts_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workouts",
                        principalColumn: "WorkoutId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sets",
                columns: table => new
                {
                    SetId = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Weight = table.Column<int>(nullable: false),
                    Reps = table.Column<int>(nullable: false),
                    StationSetId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sets", x => x.SetId);
                    table.ForeignKey(
                        name: "FK_Sets_StationSets_StationSetId",
                        column: x => x.StationSetId,
                        principalTable: "StationSets",
                        principalColumn: "StationSetId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sets_StationSetId",
                table: "Sets",
                column: "StationSetId");

            migrationBuilder.CreateIndex(
                name: "IX_StationSets_WorkoutId",
                table: "StationSets",
                column: "WorkoutId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sets");

            migrationBuilder.DropTable(
                name: "Stations");

            migrationBuilder.DropTable(
                name: "StationSets");

            migrationBuilder.DropTable(
                name: "Workouts");
        }
    }
}
