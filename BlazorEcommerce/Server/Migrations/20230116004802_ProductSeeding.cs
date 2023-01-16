using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "O romance distópico O conto da aia, de Margaret Atwood, se passa num futuro muito próximo e tem como cenário uma república onde não existem mais jornais, revistas, livros nem filmes. As universidades foram extintas. Também já não há advogados, porque ninguém tem direito a defesa. Os cidadãos considerados criminosos são fuzilados e pendurados mortos no Muro, em praça pública, para servir de exemplo enquanto seus corpos apodrecem à vista de todos.", "https://images-na.ssl-images-amazon.com/images/I/51X40Du9otL._SX331_BO1,204,203,200_.jpg", 9.99m, "O conto da aiaaaa" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Nesta emocionante história ambientada no Sul dos Estados Unidos da década de 1930, região envenenada pela violência do preconceito racial, vemos um mundo de grande beleza e ferozes desigualdades através dos olhos de uma menina de inteligência viva e questionadora, enquanto seu pai, um advogado local, arrisca tudo para defender um homem negro injustamente acusado de cometer um terrível crime.", "https://images-na.ssl-images-amazon.com/images/I/51wdOrz6uNL._SX340_BO1,204,203,200_.jpg", 5.99m, "O sol é para todos" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Guy Montag é um bombeiro. Sua profissão é atear fogo nos livros. Em um mundo onde as pessoas vivem em função das telas e a literatura está ameaçada de extinção, os livros são objetos proibidos, e seus portadores são considerados criminosos. Montag nunca questionou seu trabalho; vive uma vida comum, cumpre o expediente e retorna ao final do dia para sua esposa e para a rotina do lar.", "https://images-na.ssl-images-amazon.com/images/I/41PVVpQf-sL._SX322_BO1,204,203,200_.jpg", 3.99m, "Fahrenheit 451" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
