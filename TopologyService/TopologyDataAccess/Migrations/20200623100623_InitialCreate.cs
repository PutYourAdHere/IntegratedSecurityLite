using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.SqlServer.Types;
using NetTopologySuite.Geometries;

namespace TopologyDataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Topology");

            migrationBuilder.CreateTable(
                name: "Places",
                schema: "Topology",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    Location = table.Column<Geometry>(type: "Geometry", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlaceSets",
                schema: "Topology",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    Location = table.Column<Geometry>(type: "Geometry", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceSets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SortedPlaces",
                schema: "Topology",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    PlaceId = table.Column<Guid>(nullable: false),
                    PlaceSetId = table.Column<Guid>(nullable: false),
                    Level = table.Column<SqlHierarchyId>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SortedPlaces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SortedPlaces_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalSchema: "Topology",
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SortedPlaces_PlaceSets_PlaceSetId",
                        column: x => x.PlaceSetId,
                        principalSchema: "Topology",
                        principalTable: "PlaceSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "Places_NameIX",
                schema: "Topology",
                table: "Places",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "PlaceSets_NameIX",
                schema: "Topology",
                table: "PlaceSets",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_SortedPlaces_PlaceId",
                schema: "Topology",
                table: "SortedPlaces",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_SortedPlaces_PlaceSetId",
                schema: "Topology",
                table: "SortedPlaces",
                column: "PlaceSetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SortedPlaces",
                schema: "Topology");

            migrationBuilder.DropTable(
                name: "Places",
                schema: "Topology");

            migrationBuilder.DropTable(
                name: "PlaceSets",
                schema: "Topology");
        }
    }
}
