using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _03_04_05.Migrations
{
    /// <inheritdoc />
    public partial class SalesAddDateDefault : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
            name: "Time",
            table: "Sales",
            nullable: false,
            defaultValueSql: "GETDATE()");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Sales",
                newName: "DateTime");
        }
    }
}
