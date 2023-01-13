using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoubleVPartnersAPI.Migrations
{
    public partial class firstMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TKS_TICKETS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USUARIO = table.Column<string>(nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(nullable: false),
                    ESTADO = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TKS_TICKETS", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TKS_TICKETS");
        }
    }
}
