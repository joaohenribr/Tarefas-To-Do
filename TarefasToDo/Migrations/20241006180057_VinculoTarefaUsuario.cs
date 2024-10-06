using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TarefasToDo.Migrations
{
    /// <inheritdoc />
    public partial class VinculoTarefaUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Tarefas");

            migrationBuilder.AddColumn<int>(
                name: "UsernameId",
                table: "Tarefas",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_UsernameId",
                table: "Tarefas",
                column: "UsernameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_Usuarios_UsernameId",
                table: "Tarefas",
                column: "UsernameId",
                principalTable: "Usuarios",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_Usuarios_UsernameId",
                table: "Tarefas");

            migrationBuilder.DropIndex(
                name: "IX_Tarefas_UsernameId",
                table: "Tarefas");

            migrationBuilder.DropColumn(
                name: "UsernameId",
                table: "Tarefas");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Tarefas",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
