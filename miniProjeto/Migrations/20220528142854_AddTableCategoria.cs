using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace miniProjeto.Migrations
{
    public partial class AddTableCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome_categoria = table.Column<string>(type: "varchar(80) CHARACTER SET utf8mb4", maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Nome_categoria" },
                values: new object[,]
                {
                    { 1, "Acessorios" },
                    { 2, "TVs" },
                    { 3, "SmartPhones" },
                    { 4, "Desktops" },
                    { 5, "LapTop" }
                });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nome",
                value: "Celular Samsung");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nome",
                value: "TV Samsung");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nome",
                value: "Celular Motorola");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Nome",
                value: "Phone de Ouvido");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Nome",
                value: "Carregador");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nome",
                value: "Caderno");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nome",
                value: "Borracha");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nome",
                value: "Estojo");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Nome",
                value: "Lapseira");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Nome",
                value: "Caneta");
        }
    }
}
