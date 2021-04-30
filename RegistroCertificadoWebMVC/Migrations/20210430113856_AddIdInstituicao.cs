using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistroCertificadoWebMVC.Migrations
{
    public partial class AddIdInstituicao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certificado_Instituicao_InstituicaoId",
                table: "Certificado");

            migrationBuilder.AlterColumn<int>(
                name: "InstituicaoId",
                table: "Certificado",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Certificado_Instituicao_InstituicaoId",
                table: "Certificado",
                column: "InstituicaoId",
                principalTable: "Instituicao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certificado_Instituicao_InstituicaoId",
                table: "Certificado");

            migrationBuilder.AlterColumn<int>(
                name: "InstituicaoId",
                table: "Certificado",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Certificado_Instituicao_InstituicaoId",
                table: "Certificado",
                column: "InstituicaoId",
                principalTable: "Instituicao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
