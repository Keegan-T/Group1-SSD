using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment2.Migrations
{
    public partial class Export : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category_name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    description = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.category_id);
                });

            migrationBuilder.CreateTable(
                name: "customer_demographics",
                columns: table => new
                {
                    customer_type_id = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    customer_desc = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_demographics", x => x.customer_type_id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    customer_id = table.Column<string>(type: "nchar(5)", fixedLength: true, maxLength: 5, nullable: false),
                    company_name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    contact_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    contact_title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    address = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    city = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    region = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    postal_code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    country = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    phone = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true),
                    fax = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.customer_id);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    employee_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    last_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    title_of_courtesy = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    birth_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    hire_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    address = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    city = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    region = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    postal_code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    country = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    home_phone = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true),
                    extension = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    notes = table.Column<string>(type: "ntext", nullable: true),
                    reports_to = table.Column<int>(type: "int", nullable: true),
                    photo_path = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.employee_id);
                    table.ForeignKey(
                        name: "FK_employees_employees",
                        column: x => x.reports_to,
                        principalTable: "employees",
                        principalColumn: "employee_id");
                });

            migrationBuilder.CreateTable(
                name: "region",
                columns: table => new
                {
                    region_id = table.Column<int>(type: "int", nullable: false),
                    region_description = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_region", x => x.region_id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "shippers",
                columns: table => new
                {
                    shipper_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    company_name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    phone = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shippers", x => x.shipper_id);
                });

            migrationBuilder.CreateTable(
                name: "suppliers",
                columns: table => new
                {
                    supplier_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    company_name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    contact_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    contact_title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    address = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    city = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    region = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    postal_code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    country = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    phone = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true),
                    fax = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true),
                    home_page = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suppliers", x => x.supplier_id);
                });

            migrationBuilder.CreateTable(
                name: "customer_customer_demo",
                columns: table => new
                {
                    customer_id = table.Column<string>(type: "nchar(5)", fixedLength: true, maxLength: 5, nullable: false),
                    customer_type_id = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_customer_demo", x => new { x.customer_id, x.customer_type_id })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_customer_customer_demo",
                        column: x => x.customer_type_id,
                        principalTable: "customer_demographics",
                        principalColumn: "customer_type_id");
                    table.ForeignKey(
                        name: "FK_customer_customer_demo_customers",
                        column: x => x.customer_id,
                        principalTable: "customers",
                        principalColumn: "customer_id");
                });

            migrationBuilder.CreateTable(
                name: "territories",
                columns: table => new
                {
                    territory_id = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    territory_description = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    region_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_territories", x => x.territory_id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_territories_region",
                        column: x => x.region_id,
                        principalTable: "region",
                        principalColumn: "region_id");
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_id = table.Column<string>(type: "nchar(5)", fixedLength: true, maxLength: 5, nullable: true),
                    employee_id = table.Column<int>(type: "int", nullable: true),
                    order_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    required_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    shipped_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    ship_via = table.Column<int>(type: "int", nullable: true),
                    freight = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    ship_name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ship_address = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ship_city = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    ship_region = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    ship_postal_code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ship_country = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.order_id);
                    table.ForeignKey(
                        name: "FK_orders_customers",
                        column: x => x.customer_id,
                        principalTable: "customers",
                        principalColumn: "customer_id");
                    table.ForeignKey(
                        name: "FK_orders_employees",
                        column: x => x.employee_id,
                        principalTable: "employees",
                        principalColumn: "employee_id");
                    table.ForeignKey(
                        name: "FK_orders_shippers",
                        column: x => x.ship_via,
                        principalTable: "shippers",
                        principalColumn: "shipper_id");
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    supplier_id = table.Column<int>(type: "int", nullable: true),
                    category_id = table.Column<int>(type: "int", nullable: true),
                    quantity_per_unit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    unit_price = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    units_in_stock = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    units_on_order = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    reorder_level = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    discontinued = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.product_id);
                    table.ForeignKey(
                        name: "FK_products_categories",
                        column: x => x.category_id,
                        principalTable: "categories",
                        principalColumn: "category_id");
                    table.ForeignKey(
                        name: "FK_products_suppliers",
                        column: x => x.supplier_id,
                        principalTable: "suppliers",
                        principalColumn: "supplier_id");
                });

            migrationBuilder.CreateTable(
                name: "employee_territories",
                columns: table => new
                {
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    territory_id = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee_territories", x => new { x.employee_id, x.territory_id })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_employee_territories_employees",
                        column: x => x.employee_id,
                        principalTable: "employees",
                        principalColumn: "employee_id");
                    table.ForeignKey(
                        name: "FK_employee_territories_territories",
                        column: x => x.territory_id,
                        principalTable: "territories",
                        principalColumn: "territory_id");
                });

            migrationBuilder.CreateTable(
                name: "order_details",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "int", nullable: false),
                    product_id = table.Column<int>(type: "int", nullable: false),
                    unit_price = table.Column<decimal>(type: "money", nullable: false),
                    quantity = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    discount = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_details", x => new { x.order_id, x.product_id });
                    table.ForeignKey(
                        name: "FK_order_details_orders",
                        column: x => x.order_id,
                        principalTable: "orders",
                        principalColumn: "order_id");
                    table.ForeignKey(
                        name: "FK_order_details_products",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "product_id");
                });

            migrationBuilder.CreateIndex(
                name: "category_name",
                table: "categories",
                column: "category_name");

            migrationBuilder.CreateIndex(
                name: "IX_customer_customer_demo_customer_type_id",
                table: "customer_customer_demo",
                column: "customer_type_id");

            migrationBuilder.CreateIndex(
                name: "city",
                table: "customers",
                column: "city");

            migrationBuilder.CreateIndex(
                name: "company_name",
                table: "customers",
                column: "company_name");

            migrationBuilder.CreateIndex(
                name: "postal_code",
                table: "customers",
                column: "postal_code");

            migrationBuilder.CreateIndex(
                name: "region",
                table: "customers",
                column: "region");

            migrationBuilder.CreateIndex(
                name: "IX_employee_territories_territory_id",
                table: "employee_territories",
                column: "territory_id");

            migrationBuilder.CreateIndex(
                name: "IX_employees_reports_to",
                table: "employees",
                column: "reports_to");

            migrationBuilder.CreateIndex(
                name: "last_name",
                table: "employees",
                column: "last_name");

            migrationBuilder.CreateIndex(
                name: "postal_code1",
                table: "employees",
                column: "postal_code");

            migrationBuilder.CreateIndex(
                name: "order_id",
                table: "order_details",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "orders_order_details",
                table: "order_details",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "product_id",
                table: "order_details",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "products_order_details",
                table: "order_details",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "customer_id",
                table: "orders",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "customers_orders",
                table: "orders",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "employee_id",
                table: "orders",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "employees_orders",
                table: "orders",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "order_date",
                table: "orders",
                column: "order_date");

            migrationBuilder.CreateIndex(
                name: "ship_postal_code",
                table: "orders",
                column: "ship_postal_code");

            migrationBuilder.CreateIndex(
                name: "shipped_date",
                table: "orders",
                column: "shipped_date");

            migrationBuilder.CreateIndex(
                name: "shippers_orders",
                table: "orders",
                column: "ship_via");

            migrationBuilder.CreateIndex(
                name: "categories_products",
                table: "products",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "category_id",
                table: "products",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "product_name",
                table: "products",
                column: "product_name");

            migrationBuilder.CreateIndex(
                name: "supplier_id",
                table: "products",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "suppliers_products",
                table: "products",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "company_name1",
                table: "suppliers",
                column: "company_name");

            migrationBuilder.CreateIndex(
                name: "postal_code2",
                table: "suppliers",
                column: "postal_code");

            migrationBuilder.CreateIndex(
                name: "IX_territories_region_id",
                table: "territories",
                column: "region_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customer_customer_demo");

            migrationBuilder.DropTable(
                name: "employee_territories");

            migrationBuilder.DropTable(
                name: "order_details");

            migrationBuilder.DropTable(
                name: "customer_demographics");

            migrationBuilder.DropTable(
                name: "territories");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "region");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "shippers");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "suppliers");
        }
    }
}
