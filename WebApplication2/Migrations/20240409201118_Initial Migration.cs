using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Album2",
                columns: table => new
                {
                    Album_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Album_No = table.Column<int>(type: "int", nullable: false),
                    Album_Tur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sanatci_Bilgi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Album_Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Album_Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Yerli = table.Column<bool>(type: "bit", nullable: false),
                    Menajer_Bilgi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Album2", x => x.Album_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Album2");
        }
    }
}
