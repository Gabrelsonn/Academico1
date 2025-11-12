using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academico.Migrations
{
    /// <inheritdoc />
    public partial class instituicaoid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InstituicaoId",
                table: "Departamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "InstituicaoOrigemInstituicaoId",
                table: "Departamentos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_InstituicaoOrigemInstituicaoId",
                table: "Departamentos",
                column: "InstituicaoOrigemInstituicaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Instituicao_InstituicaoOrigemInstituicaoId",
                table: "Departamentos",
                column: "InstituicaoOrigemInstituicaoId",
                principalTable: "Instituicao",
                principalColumn: "InstituicaoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Instituicao_InstituicaoOrigemInstituicaoId",
                table: "Departamentos");

            migrationBuilder.DropIndex(
                name: "IX_Departamentos_InstituicaoOrigemInstituicaoId",
                table: "Departamentos");

            migrationBuilder.DropColumn(
                name: "InstituicaoId",
                table: "Departamentos");

            migrationBuilder.DropColumn(
                name: "InstituicaoOrigemInstituicaoId",
                table: "Departamentos");
        }
    }
}
