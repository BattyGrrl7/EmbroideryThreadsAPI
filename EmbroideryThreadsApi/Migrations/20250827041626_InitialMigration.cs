using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmbroideryThreadsApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HexCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.ColorId);
                });

            migrationBuilder.CreateTable(
                name: "Anchor",
                columns: table => new
                {
                    AnchorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnchorNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnchorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anchor", x => x.AnchorId);
                    table.ForeignKey(
                        name: "FK_Anchor_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "ColorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dimensions",
                columns: table => new
                {
                    DimensionsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DimensionsNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DimensionsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensions", x => x.DimensionsId);
                    table.ForeignKey(
                        name: "FK_Dimensions_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "ColorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DMCs",
                columns: table => new
                {
                    DMCId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DMCNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DMCName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMCs", x => x.DMCId);
                    table.ForeignKey(
                        name: "FK_DMCs_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "ColorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Presencia",
                columns: table => new
                {
                    PresenciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PresenciaNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PresenciaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presencia", x => x.PresenciaId);
                    table.ForeignKey(
                        name: "FK_Presencia_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "ColorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorId", "ColorName", "HexCode" },
                values: new object[,]
                {
                    { 1, "Fuschia", "9C599C" },
                    { 2, "White", "FFFFFF" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anchor_ColorId",
                table: "Anchor",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Dimensions_ColorId",
                table: "Dimensions",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_DMCs_ColorId",
                table: "DMCs",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Presencia_ColorId",
                table: "Presencia",
                column: "ColorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anchor");

            migrationBuilder.DropTable(
                name: "Dimensions");

            migrationBuilder.DropTable(
                name: "DMCs");

            migrationBuilder.DropTable(
                name: "Presencia");

            migrationBuilder.DropTable(
                name: "Colors");
        }
    }
}
