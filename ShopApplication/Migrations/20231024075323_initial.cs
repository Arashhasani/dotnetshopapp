using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopApplication.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("143c2e08-8788-42bc-bc29-504d0cdaefbf"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("479e22e2-890b-4e03-91a2-cd754994b2b6"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("4d6f9270-d122-4d6d-9054-80dcb0937afc"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5659daf5-5581-41ea-82e7-0e61e1a7eca2"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("6ca27be8-72ff-4f7a-bdc1-e83b19f8e14f"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("90f890ba-a0dd-4303-b64a-927fb2693501"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("a04ac38f-0eae-443d-86c1-e7752d56ba31"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("bbe3b310-b07e-4c82-9b6f-46c30e6dc53a"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("c9540b47-f694-44e8-ac29-683056e166f8"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("ffac3f22-89ca-4d7d-aa7c-16db1f5722ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("06f7c837-ee67-4ee3-bd80-acc6d3e77c7b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e6ef6ee-5eee-4d4f-b2fc-80945bf11a15"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1fd0952e-308c-4eea-b85d-766c77607120"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("213e0078-76d6-474d-884c-8b364c45c79f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("25418b7b-de0c-4dc7-8958-f9b062b63d54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("537edf76-ee7d-40f5-ae8b-722e5330b9c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5bd9a1ed-388f-4288-b485-4a3375790bd3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7db5f5ab-e468-4df9-b782-c2eb147579be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8c95ed9d-fb22-41aa-8770-7da23f5b6fac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("97a7cfa5-59a4-4560-9943-2aa686d8e881"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a10e45e3-e13b-475d-a129-c1db742a1d11"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a48a1001-b1ef-4387-9060-1683b3ff4c45"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7824c04-d992-4227-ae8e-377c91d24da0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd591cfd-6d0b-4dbc-90f2-849765545b2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be17d6df-6fb6-4aae-b6a1-68fa45ccbe6e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bfb758a7-8f48-4a18-a99c-f660c89eee85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df8f3b0d-c20c-4870-a83c-405c8b552839"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dff1d42d-3681-4aa4-aad8-313c17763866"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ec930129-218f-45d0-beac-397d2fb24f2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f69932df-b325-4070-ae3a-2def5ba43af9"));

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Name", "categorycode" },
                values: new object[,]
                {
                    { new Guid("03e59e58-ba5f-4074-a625-4bee423d7e29"), "HU89", "OLOEQBTL" },
                    { new Guid("0d217c74-f27b-409b-9d75-a394e901f4cf"), "V7SM", "MCLULXRP" },
                    { new Guid("369517c8-8caa-4e68-89d7-6736d1e0ea08"), "I7WR", "JHDN3HCZ" },
                    { new Guid("3a3feed4-b72a-4a67-9d05-fb0b0ae56301"), "CKTX", "EDS38DZ4" },
                    { new Guid("5b70c998-93a5-4420-afaf-a9ab9ac912e9"), "514Z", "OYRYXGY1" },
                    { new Guid("ad13b95b-4dc2-45d5-a54e-67975e838dad"), "32WM", "0GDVYHNZ" },
                    { new Guid("ae036a8a-761a-4a81-9f17-ea6eba567581"), "B0VZ", "M2DOYTTS" },
                    { new Guid("ca077b7a-1535-4612-be36-a132a48e796e"), "ZOIJ", "LOSKVF11" },
                    { new Guid("f8671dd0-6fcc-4dbe-98df-6e5159575e98"), "PCR7", "HLMTM4LS" },
                    { new Guid("f9a2ccc6-10e1-4931-8604-5721ca60bf7c"), "Y8TY", "I0XTAP9C" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("03622de5-3275-4cde-bb98-8de03a2ba24b"), "QFECWW7K@gmail.com", "VWGO", "XJGETXMIHV" },
                    { new Guid("086b534a-b46b-4fed-9fb6-ae51676077bb"), "9JWYIU98@gmail.com", "ZFTU", "HPQQZ1F1JG" },
                    { new Guid("1c3b79d1-4e21-4868-a40d-c2e3d94a4495"), "7IIQR3H6@gmail.com", "5ZAN", "AEAWVG13F3" },
                    { new Guid("2a1bea2e-7083-44a9-962e-fcd1b2e68c97"), "PTEEWS07@gmail.com", "OW3X", "9T7248AY37" },
                    { new Guid("325a6afc-fbb8-4cac-912c-34125837fc3f"), "NM6HVUSE@gmail.com", "BBRC", "AHP3DTQPX1" },
                    { new Guid("3685e699-90dd-4c5f-be43-413141210f4f"), "N6E66PUM@gmail.com", "ZOJW", "KML645DESM" },
                    { new Guid("3aeea810-c170-441d-8c23-1fc066f2164f"), "2XA9BT7P@gmail.com", "F9AL", "4A0GQX4MO9" },
                    { new Guid("3e49f704-207f-423a-9d68-a788f396af75"), "V3XIMAS7@gmail.com", "P9LR", "IL5G8OY37O" },
                    { new Guid("474887d0-2c9b-49bb-999a-22a8e9581c52"), "7G11XZCT@gmail.com", "67ET", "RE7XOJJ8W0" },
                    { new Guid("669e9354-b5f9-439f-b5e7-c9ab7124cfad"), "CSGR4UHX@gmail.com", "LOYZ", "5ZZICRWITT" },
                    { new Guid("68eb1dd9-4eb9-49d5-b05e-e0c481205a3f"), "F3V74YAD@gmail.com", "YJNC", "Y8K17E8R13" },
                    { new Guid("84d3abcc-0e31-4eb7-bb89-eb8b59e9bfdd"), "1FA4MPHS@gmail.com", "TS47", "RWZ8922AP1" },
                    { new Guid("92522f59-42f4-4aad-9514-7be68006e8e0"), "EF2EF0EG@gmail.com", "HNCR", "E3SYU43JZD" },
                    { new Guid("991499b9-54e7-45a8-83fd-5ceeee665d9e"), "55MU3XB2@gmail.com", "KY1B", "2JJ1MGTP77" },
                    { new Guid("ad13aaaa-413e-43e1-9e67-de0fb92d8b9e"), "WJQOJ8XK@gmail.com", "YF0D", "71V9GCEWFY" },
                    { new Guid("b90f56e9-d6b6-4f8d-a466-c51925d50fa6"), "NDL6L8DF@gmail.com", "W0GA", "VCWMQD03RK" },
                    { new Guid("c0604966-bf0d-4acc-ba69-da7a6910502c"), "0N8PUHI0@gmail.com", "VL3D", "27SC8GU6QH" },
                    { new Guid("d652ad43-b32f-4cab-a296-08086a5ea99f"), "IYS18HG9@gmail.com", "UT0Z", "DR7PIK9A1P" },
                    { new Guid("d7e6fd7d-a2e2-43d1-b149-ffc2bc614353"), "2VS7YSLN@gmail.com", "ZPZX", "JJ288ZCM1F" },
                    { new Guid("e97888bc-49e1-4031-92b8-d7ff795ee963"), "9Y56OXY7@gmail.com", "5P2H", "FPK0YX7YF2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("03e59e58-ba5f-4074-a625-4bee423d7e29"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("0d217c74-f27b-409b-9d75-a394e901f4cf"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("369517c8-8caa-4e68-89d7-6736d1e0ea08"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("3a3feed4-b72a-4a67-9d05-fb0b0ae56301"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5b70c998-93a5-4420-afaf-a9ab9ac912e9"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("ad13b95b-4dc2-45d5-a54e-67975e838dad"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("ae036a8a-761a-4a81-9f17-ea6eba567581"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("ca077b7a-1535-4612-be36-a132a48e796e"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("f8671dd0-6fcc-4dbe-98df-6e5159575e98"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("f9a2ccc6-10e1-4931-8604-5721ca60bf7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("03622de5-3275-4cde-bb98-8de03a2ba24b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("086b534a-b46b-4fed-9fb6-ae51676077bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c3b79d1-4e21-4868-a40d-c2e3d94a4495"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a1bea2e-7083-44a9-962e-fcd1b2e68c97"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("325a6afc-fbb8-4cac-912c-34125837fc3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3685e699-90dd-4c5f-be43-413141210f4f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3aeea810-c170-441d-8c23-1fc066f2164f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e49f704-207f-423a-9d68-a788f396af75"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("474887d0-2c9b-49bb-999a-22a8e9581c52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("669e9354-b5f9-439f-b5e7-c9ab7124cfad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68eb1dd9-4eb9-49d5-b05e-e0c481205a3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84d3abcc-0e31-4eb7-bb89-eb8b59e9bfdd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("92522f59-42f4-4aad-9514-7be68006e8e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("991499b9-54e7-45a8-83fd-5ceeee665d9e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad13aaaa-413e-43e1-9e67-de0fb92d8b9e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b90f56e9-d6b6-4f8d-a466-c51925d50fa6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c0604966-bf0d-4acc-ba69-da7a6910502c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d652ad43-b32f-4cab-a296-08086a5ea99f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7e6fd7d-a2e2-43d1-b149-ffc2bc614353"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e97888bc-49e1-4031-92b8-d7ff795ee963"));

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Name", "categorycode" },
                values: new object[,]
                {
                    { new Guid("143c2e08-8788-42bc-bc29-504d0cdaefbf"), "HN2U", "4LDAK6KV" },
                    { new Guid("479e22e2-890b-4e03-91a2-cd754994b2b6"), "SFFB", "UPAPYIJ6" },
                    { new Guid("4d6f9270-d122-4d6d-9054-80dcb0937afc"), "8Y8P", "8N35M8JJ" },
                    { new Guid("5659daf5-5581-41ea-82e7-0e61e1a7eca2"), "YU31", "3YWZAMQM" },
                    { new Guid("6ca27be8-72ff-4f7a-bdc1-e83b19f8e14f"), "EXMB", "51EIMKN6" },
                    { new Guid("90f890ba-a0dd-4303-b64a-927fb2693501"), "4PN4", "NN9P0QNI" },
                    { new Guid("a04ac38f-0eae-443d-86c1-e7752d56ba31"), "36OG", "9MA76TF6" },
                    { new Guid("bbe3b310-b07e-4c82-9b6f-46c30e6dc53a"), "50BS", "Y7L7LRV3" },
                    { new Guid("c9540b47-f694-44e8-ac29-683056e166f8"), "9Z7Z", "Q66RL6MA" },
                    { new Guid("ffac3f22-89ca-4d7d-aa7c-16db1f5722ee"), "WIV2", "NGNVJVQI" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("06f7c837-ee67-4ee3-bd80-acc6d3e77c7b"), "QCFKQM6B@gmail.com", "4SOQ", "RD8UJ0IR7M" },
                    { new Guid("1e6ef6ee-5eee-4d4f-b2fc-80945bf11a15"), "JT0HWONN@gmail.com", "RBJA", "ZPAKBE72DC" },
                    { new Guid("1fd0952e-308c-4eea-b85d-766c77607120"), "ODBZDO77@gmail.com", "43GI", "GLSHCB64NO" },
                    { new Guid("213e0078-76d6-474d-884c-8b364c45c79f"), "HZ0LJ54K@gmail.com", "K2IA", "DER06R6WXI" },
                    { new Guid("25418b7b-de0c-4dc7-8958-f9b062b63d54"), "XWEN3MIH@gmail.com", "DUUM", "8ZV4F4SAYU" },
                    { new Guid("537edf76-ee7d-40f5-ae8b-722e5330b9c3"), "49OEEU5A@gmail.com", "DWZ5", "XW39SMJEVE" },
                    { new Guid("5bd9a1ed-388f-4288-b485-4a3375790bd3"), "1QPKCA5V@gmail.com", "VSSY", "TMVXVSHVSF" },
                    { new Guid("7db5f5ab-e468-4df9-b782-c2eb147579be"), "5O2XNP3W@gmail.com", "V7IV", "8N929HO6G2" },
                    { new Guid("8c95ed9d-fb22-41aa-8770-7da23f5b6fac"), "YFS5THQ5@gmail.com", "H4MM", "NRCTQLNI70" },
                    { new Guid("97a7cfa5-59a4-4560-9943-2aa686d8e881"), "6868GMPO@gmail.com", "6BAO", "DS1148UQZA" },
                    { new Guid("a10e45e3-e13b-475d-a129-c1db742a1d11"), "CPHBQXGE@gmail.com", "T8I4", "WJYLEQU35Q" },
                    { new Guid("a48a1001-b1ef-4387-9060-1683b3ff4c45"), "SYA87UAA@gmail.com", "ICYZ", "DRRQNNOPW8" },
                    { new Guid("b7824c04-d992-4227-ae8e-377c91d24da0"), "C1GWY5PZ@gmail.com", "N9OB", "NX6YZTQ83I" },
                    { new Guid("bd591cfd-6d0b-4dbc-90f2-849765545b2a"), "EOJWI57F@gmail.com", "9B7V", "QE86A77GZW" },
                    { new Guid("be17d6df-6fb6-4aae-b6a1-68fa45ccbe6e"), "WW0J5LA4@gmail.com", "T0XR", "Y87QDGWOSK" },
                    { new Guid("bfb758a7-8f48-4a18-a99c-f660c89eee85"), "BZBKTRHJ@gmail.com", "J01R", "RY7EGYZURE" },
                    { new Guid("df8f3b0d-c20c-4870-a83c-405c8b552839"), "BS5SOBMC@gmail.com", "K5TG", "RV3BLPSAOU" },
                    { new Guid("dff1d42d-3681-4aa4-aad8-313c17763866"), "XGHGX44L@gmail.com", "H6OV", "YN38M6AUD8" },
                    { new Guid("ec930129-218f-45d0-beac-397d2fb24f2b"), "X4Y67XUM@gmail.com", "0BBF", "OH69BJXPYE" },
                    { new Guid("f69932df-b325-4070-ae3a-2def5ba43af9"), "TJNHBQ6X@gmail.com", "ADF6", "KOMV5XHM0X" }
                });
        }
    }
}
