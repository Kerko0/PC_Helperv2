using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PCHelper_backend.Migrations
{
    /// <inheritdoc />
    public partial class ChangePK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Motherboards",
                table: "Motherboards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GPUs",
                table: "GPUs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CPUs",
                table: "CPUs");

            migrationBuilder.AlterColumn<int>(
                name: "Tier",
                table: "Motherboards",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Tier",
                table: "GPUs",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Tier",
                table: "CPUs",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Motherboards",
                table: "Motherboards",
                column: "Tier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GPUs",
                table: "GPUs",
                column: "Tier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CPUs",
                table: "CPUs",
                column: "Tier");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Motherboards",
                table: "Motherboards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GPUs",
                table: "GPUs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CPUs",
                table: "CPUs");

            migrationBuilder.AlterColumn<int>(
                name: "Tier",
                table: "Motherboards",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Tier",
                table: "GPUs",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Tier",
                table: "CPUs",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Motherboards",
                table: "Motherboards",
                column: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GPUs",
                table: "GPUs",
                column: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CPUs",
                table: "CPUs",
                column: "Name");
        }
    }
}
