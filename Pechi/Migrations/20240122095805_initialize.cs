using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pechi.Migrations
{
    /// <inheritdoc />
    public partial class initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ответственные_лица",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Фамилия = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Имя = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Отчество = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ответственные_лица", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Простои",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Агрегата = table.Column<int>(type: "int", nullable: false),
                    ID_Типа = table.Column<int>(type: "int", nullable: false),
                    Дата_начала_простоя = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Дата_окончания_простоя = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Время_простоя_план = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Время_простоя_факт = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Описание = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID_Лица = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Простои", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Регистрация",
                columns: table => new
                {
                    Login = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Регистрация", x => x.Login);
                });

            migrationBuilder.CreateTable(
                name: "Технологические_агрегаты",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Название_агрегата = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Тип = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Технологические_агрегаты", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Типы_простоев",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Название_простоя = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Описание = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Типы_простоев", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ответственные_лица");

            migrationBuilder.DropTable(
                name: "Простои");

            migrationBuilder.DropTable(
                name: "Регистрация");

            migrationBuilder.DropTable(
                name: "Технологические_агрегаты");

            migrationBuilder.DropTable(
                name: "Типы_простоев");
        }
    }
}
