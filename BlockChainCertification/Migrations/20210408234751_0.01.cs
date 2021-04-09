using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlockChainCertification.Migrations
{
    public partial class _001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Certification",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CertificateTitle = table.Column<string>(nullable: false),
                    Notes = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AwardeCrtificate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Recipient = table.Column<string>(nullable: false),
                    provider = table.Column<string>(nullable: false),
                    Notes = table.Column<string>(nullable: false),
                    PreviousId = table.Column<int>(nullable: true),
                    CrtificateNumber = table.Column<string>(nullable: false),
                    Moyen = table.Column<decimal>(nullable: false),
                    TransactionDate = table.Column<DateTimeOffset>(nullable: false),
                    Hash = table.Column<string>(nullable: false),
                    CertificationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwardeCrtificate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AwardeCrtificate_Certification_CertificationId",
                        column: x => x.CertificationId,
                        principalTable: "Certification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AwardeCrtificate_AwardeCrtificate_PreviousId",
                        column: x => x.PreviousId,
                        principalTable: "AwardeCrtificate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AwardeCrtificate_CertificationId",
                table: "AwardeCrtificate",
                column: "CertificationId");

            migrationBuilder.CreateIndex(
                name: "IX_AwardeCrtificate_PreviousId",
                table: "AwardeCrtificate",
                column: "PreviousId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AwardeCrtificate");

            migrationBuilder.DropTable(
                name: "Certification");
        }
    }
}
