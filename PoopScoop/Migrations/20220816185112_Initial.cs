using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PoopScoop.Solution.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Poops",
                columns: table => new
                {
                    PoopId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Consistency = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Volume = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Color = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Content = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Coating = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Frequency = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Grade = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Problem = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Solution = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poops", x => x.PoopId);
                });

            migrationBuilder.InsertData(
                table: "Poops",
                columns: new[] { "PoopId", "Coating", "Color", "Consistency", "Content", "Frequency", "Grade", "Problem", "Solution", "Volume" },
                values: new object[,]
                {
                    { 1, "None", "Brown", "Soft", "None", "Average", "A", "No Problems this is a healthy poop.", "NA", "Average" },
                    { 2, "None", "Brown", "Liquid", "None", "Average", "B", "Excessive scratching and inflamed paws sign of grain allergy", "24 hours fasting, plain food and probiotics", "Average" },
                    { 3, "None", "Brown", "Soft", "None", "Average", "A-", "A sudden change may mean your dog is digesting food differently, change in diet, gut inflamation.", "Monitor for discomfort and speak with your vet if this continues.", "Above Average" },
                    { 4, "None", "Brown", "Soft", "None", "Average", "A-", "A sudden change may mean your dog is digesting food differently, change in diet, gut inflamation, or obstruction.", "Monitor for discomfort and speak with your vet if this continues", "Below Average" },
                    { 5, "None", "Brown", "Hard", "None", "Average", "B +", "Dehydration or lack of fibre.", "Go for a walk with your dog, ensure access to plenty of fresh water", "Average" },
                    { 6, "None", "Pink or Purple", "Soft", "None", "Average", "F", "Could indicate HGE or hemorrhagic gastroenteritis.", "Get an emergency vet appointment", "Average" },
                    { 7, "None", "Orange or yellow", "Soft", "None", "Average", "D", "This color can point to an underlying biliary or liver issue", "Call the vet", "Average" },
                    { 8, "None", "Green", "Soft", "None", "Average", "C", "Could be your dog has eaten too much grass, has a gallbladder issue, or has parasites.", "Monitor for discomfort and speak with a vet if severe or persistent", "Average" },
                    { 9, "Greasy", "Grey", "Soft", "None", "Average", "B-", "Could indicate biliary or pancreatic problem.", "Could be a sign you're feeding too much fat, and may need to switch up their diet", "Average" },
                    { 10, "None", "Black", "Soft", "None", "Average", "D-", "Can be a sign of bleeding in the upper GI tract", "Poop is black because blood has been digested- a sign you should get your dog to a vet.", "Average" },
                    { 11, "None", "White", "Soft", "None", "Average", "B", "Maybe a result of diet.", "Maybe a result of diet, food high in calcium or recent switch to raw food.", "Average" },
                    { 12, "None", "Brown", "Soft", "Rice-Like Polka-Dots", "Average", "C-", "Keep an eye out for critters.", "At the sign of skinny roundworms, or little-rice-shaped tapeworm segments, reach for the dewormer.", "Average" },
                    { 13, "None", "Brown", "Soft", "Red Streaks", "Average", "D", "Could indicate presence of blood and needs investigating.", "If poop is normal in consistency it is likely caused by a tear or trauma in their bottom.", "Average" },
                    { 14, "None", "Brown", "Soft", "Grass and Random Stuff", "Average", "C", "Poop including grass or bits of clothing, plastic, and other unusual items.", "If you items are stuck in their digestive tract get an x-ray pronto", "Average" },
                    { 15, "None", "Brown", "Soft", "Fur", "Average", "C", "A sign of over grooming, a dogs way of coping with everything from allergies to stress and anxiety.", "Reduce stressors and ease them into any changes gradually.", "Average" },
                    { 16, "Mucus", "Brown", "Soft", "None", "Average", "C-", "Mucus is a sign of inflamation which can be caused by things such as parasites, food intolerances, and bacterial infections.", "Food intolerance can require dietary changes and probiotics, in serious cases antibiotics and steroids may be required.", "Average" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Poops");
        }
    }
}
