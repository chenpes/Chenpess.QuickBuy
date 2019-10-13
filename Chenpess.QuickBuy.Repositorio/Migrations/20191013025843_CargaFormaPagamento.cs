using Microsoft.EntityFrameworkCore.Migrations;

namespace Chenpess.QuickBuy.Repositorio.Migrations
{
    public partial class CargaFormaPagamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FormaPagamento",
                columns: new[] { "id", "descricao", "nome" },
                values: new object[] { 1, "Forma de pagamento Boleto", "Boleto" });

            migrationBuilder.InsertData(
                table: "FormaPagamento",
                columns: new[] { "id", "descricao", "nome" },
                values: new object[] { 2, "Forma de pagamento cartão", "Cartao" });

            migrationBuilder.InsertData(
                table: "FormaPagamento",
                columns: new[] { "id", "descricao", "nome" },
                values: new object[] { 3, "Forma de pagamento Deposito", "Deposito" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FormaPagamento",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FormaPagamento",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FormaPagamento",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
