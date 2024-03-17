using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickett.Data.Migrations
{
    public partial class InitialCreate18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Obras");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Obras");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Obras");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Obras",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Obras",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Obras",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 1,
                columns: new[] { "Description", "Gender", "Title" },
                values: new object[] { "The play 'Don Juan' is a timeless classic that explores the mischief and charm of the legendary seducer Don Juan. This iconic theatrical piece examines human nature, desire, morality, and the consequences of our actions. Through a captivating narrative, the story follows Don Juan, a charismatic and seductive character who defies social norms. His irresistible magnetism leads him to interact with a variety of characters, each reflecting different aspects of society and morality of the time. 'Don Juan' invites reflection on the duality of human beings, morality, love, and freedom, wrapped in a plot full of intrigue and intense emotions.", "Romance", "Don Juan" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 2,
                columns: new[] { "Description", "Gender", "Title" },
                values: new object[] { "'The Celestine' is a masterpiece of Spanish literature written by Fernando de Rojas in the 15th century. This tragicomedy tells the love story between Calisto and Melibea, within a context filled with deceit, passions, and betrayals. The plot revolves around the intervention of the go-between Celestina, a cunning and manipulative woman who acts as an intermediary in the romance. As the story unfolds, intrigues intertwine, revealing the complexities of human relationships and critiquing the society of the time. The Celestine is recognized for its psychological depth in character construction and its sharp social critique, exploring themes such as love, greed, power, and morality in a captivating literary style.", "Romance", "The Celestine" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 3,
                columns: new[] { "Description", "Gender", "Title" },
                values: new object[] { "Doble o nada is an emotional thriller set in the hostile environment of high-level corporate circles. It's a story about unrequited love, betrayal, and deceit, but above all, about power and ambition. This thrilling suspense will keep you on the edge of your seat until the very last minute.", "Thriller", "Doble o nada" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 4,
                columns: new[] { "Description", "Gender", "Title" },
                values: new object[] { "Gloria and Josete have just become independent under Claudia's guardianship. Faced with the need to find a job to be able to earn a salary to sustain themselves, Claudia suggests they try to pursue something they truly enjoy. They want to be artists. To do this, they should find a manager. This hilarious comedy follows the adventures of this trio in their quest for fame and the audience's laughter.", "Comedy", "Campeones" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 5,
                columns: new[] { "Description", "Gender", "Title" },
                values: new object[] { "The Mago Pop is the stage name of Antonio Díaz, a Spanish illusionist renowned for his impressive magic tricks and illusion shows. Known for combining magic, technology, and storytelling in his performances, The Mago Pop has captivated audiences with his innovative and astonishing shows. His performances often incorporate stunning visual effects, audience interaction, and amazing illusions that defy logic and perception. Antonio Díaz, as The Mago Pop, has succeeded in bringing magic to a modern and captivating level, becoming one of the most recognized illusionists internationally.", "Monologue", "El mago Pop" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 6,
                columns: new[] { "Description", "Gender", "Title" },
                values: new object[] { "The Lion King is a spectacular musical inspired by the Disney movie that has captivated audiences worldwide. With music by Elton John and lyrics by Tim Rice, this theatrical production transports the audience to the majestic African savanna. The story follows the journey of Simba, a young lion destined to become king, through his adventures, challenges, and the learning of valuable lessons about honor, courage, and love. The show stands out for its impressive staging, colorful costumes, dazzling visual effects, and spectacular choreography. 'The Lion King' is an exciting and moving theatrical experience that combines the magic of cinema with the energy and emotion of live theater.", "Musical", "The Lion King" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 7,
                columns: new[] { "Description", "Gender", "Title" },
                values: new object[] { "Mud is a theatrical play that addresses complex and profound themes related to the human condition, internal struggle, redemption, and interpersonal relationships. This play delves into the complexity of the characters and their conflicts, exploring human nature through intense dialogues and emotional situations. Often, Mud offers a reflection on society and its injustices, showing individuals' struggle to find meaning and redemption in a world full of challenges and adversities.", "Monologue", "Fango" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 8,
                columns: new[] { "Description", "Gender", "Title" },
                values: new object[] { "La función que sale mal is a comedic theatrical production that revolves around a group of amateur actors attempting to stage a play, but everything that can go wrong does go wrong! The plot unfolds with a succession of comic disasters, from technical problems to acting mishaps and misunderstandings among the characters. The play is a comedy filled with hilarious and chaotic situations that keep the audience laughing out loud. 'The Play That Goes Wrong' is known for its physical humor, wit, and ability to turn mistakes into entertaining and unforgettable moments for the audience.", "Thriller", "La Funcion que Sale Mal" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 9,
                columns: new[] { "Description", "Gender", "Title" },
                values: new object[] { "Illuminate is an exciting theatrical production that blends illusionism, magic, and drama into a unique theatrical experience. This captivating play transports the audience to a world of surprises, illusions, and emotions. With a talented cast and stunning visual effects, Illuminate combines the magic of theater with incredible tricks and narratives that keep the viewer absorbed in a journey full of mystery and wonder. This theatrical production is an opportunity to immerse oneself in a universe of illusions and enjoy a show that challenges the imagination and perception.", "Monologue", "Ilusionate" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 10,
                columns: new[] { "Description", "Gender", "Title" },
                values: new object[] { "Jose the dreamer is a biblical tale that recounts the life of Joseph, son of Jacob, sold into slavery by his brothers. The story follows Joseph's life from his youth to becoming a prominent official in Egypt. Known for its narrative filled with intrigue, betrayal, and redemption, the story showcases Joseph's ability to interpret dreams, which leads him to gain favor with the pharaoh and play a crucial role in Egypt's history. 'Joseph the Dreamer' is an exciting narrative that explores themes of faith, perseverance, and forgiveness, and has been a source of inspiration for many people throughout the centuries.", "Drama", "Jose the dreamer" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 11,
                columns: new[] { "Description", "Gender", "Title" },
                values: new object[] { "Lapland is a region located in northern Europe that spans parts of Norway, Sweden, Finland, and Russia. Known for its natural beauty and Arctic landscape, Lapland is famous for being home to the Sami people, their unique culture, and the Northern Lights that can be observed during the winter season. This region offers a wide range of activities such as dog sledding safaris, reindeer spotting excursions, skiing, hiking, and the opportunity to experience Sami culture through their traditions such as craftsmanship, music, and local cuisine. Lapland is a popular destination for those seeking unforgettable adventures in a spectacular natural environment.", "Thriller", "Lapland" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 12,
                columns: new[] { "Description", "Gender", "Title" },
                values: new object[] { "Arabian Nights is a collection of tales and fables of Arabic origin that dates back several centuries. The main story follows Scheherazade, who tells stories to King Shahriar to avoid her execution. These stories include magical tales, adventures, moral fables, and popular tales that span a wide spectrum of genres and themes. Among the most well-known tales are 'Aladdin and the Magic Lamp', 'Sinbad the Sailor', and 'Ali Baba and the Forty Thieves'. 'The Thousand and One Nights' has captivated readers for generations with its narrative richness, boundless imagination, and ability to weave charming and thrilling stories together.", "Comedy", "Arabian Nights" });
        }
    }
}
