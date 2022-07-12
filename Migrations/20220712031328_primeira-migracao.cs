using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arthes_2022.Migrations
{
    public partial class primeiramigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "REVISTA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tema = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    NumeroEdicao = table.Column<int>(type: "int", nullable: false),
                    MesEdicao = table.Column<int>(type: "int", nullable: false),
                    AnoEdicao = table.Column<int>(type: "int", nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(512)", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REVISTA", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "REVISTA");
        }
    }
}
