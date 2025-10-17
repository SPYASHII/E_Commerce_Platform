using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NavigationValueForCharacteristicsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CharacteristicType",
                table: "Сharacteristics",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CharacteristicType",
                table: "Сharacteristics");
        }
    }
}
