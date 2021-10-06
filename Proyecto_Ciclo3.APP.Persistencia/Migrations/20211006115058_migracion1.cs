using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_Ciclo3.APP.Persistencia.Migrations
{
    public partial class migracion1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "Aviones");

            migrationBuilder.RenameColumn(
                name: "tipo",
                table: "Aviones",
                newName: "modelo");

            migrationBuilder.RenameColumn(
                name: "presentacion",
                table: "Aviones",
                newName: "marca");

            migrationBuilder.RenameColumn(
                name: "peso",
                table: "Aviones",
                newName: "numero_baños");

            migrationBuilder.AddColumn<int>(
                name: "max_peso",
                table: "Aviones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "numero_asientos",
                table: "Aviones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Aeropuertos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coord_x = table.Column<double>(type: "float", nullable: false),
                    coord_y = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aeropuertos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Rutas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    origen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    destino = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiempo_estimado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutas", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aeropuertos");

            migrationBuilder.DropTable(
                name: "Rutas");

            migrationBuilder.DropColumn(
                name: "max_peso",
                table: "Aviones");

            migrationBuilder.DropColumn(
                name: "numero_asientos",
                table: "Aviones");

            migrationBuilder.RenameColumn(
                name: "numero_baños",
                table: "Aviones",
                newName: "peso");

            migrationBuilder.RenameColumn(
                name: "modelo",
                table: "Aviones",
                newName: "tipo");

            migrationBuilder.RenameColumn(
                name: "marca",
                table: "Aviones",
                newName: "presentacion");

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "Aviones",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
