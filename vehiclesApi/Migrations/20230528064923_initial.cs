using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace vehiclesApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VehiclesType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiclesType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false),
                    VehicleTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_VehiclesType_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehiclesType",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "VehiclesType",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("150c81c6-2458-466e-907a-2df11325e2b8"), "Camionetas" });

            migrationBuilder.InsertData(
                table: "VehiclesType",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("6ebc3dbe-2e7b-4132-8c33-e089d47694cd"), "Motocicletas" });

            migrationBuilder.InsertData(
                table: "VehiclesType",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("90d10994-3bdd-4ca2-a178-6a35fd653c59"), "Automóviles" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Available", "Description", "Price", "VehicleTypeId" },
                values: new object[,]
                {
                    { new Guid("2d099aff-a8ab-4a5c-9551-6fc74952b4e8"), true, "Suzuki Grand Vitara GLX MOD 2019.", 480000f, new Guid("150c81c6-2458-466e-907a-2df11325e2b8") },
                    { new Guid("98474b8e-d713-401e-8aee-acb7353f97bb"), true, "AUDI Q5 ELITE S TRONIC QUATTRO 2.0T STD/AUT 5PTAS MOD 2015.", 300000f, new Guid("90d10994-3bdd-4ca2-a178-6a35fd653c59") },
                    { new Guid("9d42967b-e48b-4b38-ba76-5cb12d8b18cb"), true, "Harley Davidson Street 750 Black Motorcycle Model Bike 1/12 by Maisto MOD 2015.", 355959f, new Guid("6ebc3dbe-2e7b-4132-8c33-e089d47694cd") },
                    { new Guid("bd9f66d9-38db-40dd-bf52-cab3f73ed926"), true, "Vento Screamer Sportivo MOD 2024.", 48999f, new Guid("6ebc3dbe-2e7b-4132-8c33-e089d47694cd") },
                    { new Guid("bfe902af-3cf0-4a1c-8a83-66be60b028ba"), true, "NISSAN INFINITI M37 PREMIUM VP QC DVD GPS RA-18 AU MOD 2017. ", 190000f, new Guid("90d10994-3bdd-4ca2-a178-6a35fd653c59") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleTypeId",
                table: "Vehicles",
                column: "VehicleTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "VehiclesType");
        }
    }
}
