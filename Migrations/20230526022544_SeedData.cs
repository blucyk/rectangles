using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Rectangles.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rectangles",
                columns: new[] { "Id", "X1", "X2", "Y1", "Y2" },
                values: new object[,]
                {
                    { 1, 0, 5, 0, 5 },
                    { 2, 10, 15, 10, 15 },
                    { 3, 20, 25, 20, 25 },
                    { 4, 30, 35, 30, 35 },
                    { 5, 40, 45, 40, 45 },
                    { 6, 50, 55, 50, 55 },
                    { 7, 60, 65, 60, 65 },
                    { 8, 70, 75, 70, 75 },
                    { 9, 80, 85, 80, 85 },
                    { 10, 90, 95, 90, 95 },
                    { 11, 100, 105, 100, 105 },
                    { 12, 110, 115, 110, 115 },
                    { 13, 120, 125, 120, 125 },
                    { 14, 130, 135, 130, 135 },
                    { 15, 140, 145, 140, 145 },
                    { 16, 150, 155, 150, 155 },
                    { 17, 160, 165, 160, 165 },
                    { 18, 170, 175, 170, 175 },
                    { 19, 180, 185, 180, 185 },
                    { 20, 190, 195, 190, 195 },
                    { 21, 200, 205, 200, 205 },
                    { 22, 210, 215, 210, 215 },
                    { 23, 220, 225, 220, 225 },
                    { 24, 230, 235, 230, 235 },
                    { 25, 240, 245, 240, 245 },
                    { 26, 250, 255, 250, 255 },
                    { 27, 260, 265, 260, 265 },
                    { 28, 270, 275, 270, 275 },
                    { 29, 280, 285, 280, 285 },
                    { 30, 290, 295, 290, 295 },
                    { 31, 300, 305, 300, 305 },
                    { 32, 310, 315, 310, 315 },
                    { 33, 320, 325, 320, 325 },
                    { 34, 330, 335, 330, 335 },
                    { 35, 340, 345, 340, 345 },
                    { 36, 350, 355, 350, 355 },
                    { 37, 360, 365, 360, 365 },
                    { 38, 370, 375, 370, 375 },
                    { 39, 380, 385, 380, 385 },
                    { 40, 390, 395, 390, 395 },
                    { 41, 400, 405, 400, 405 },
                    { 42, 410, 415, 410, 415 },
                    { 43, 420, 425, 420, 425 },
                    { 44, 430, 435, 430, 435 },
                    { 45, 440, 445, 440, 445 },
                    { 46, 450, 455, 450, 455 },
                    { 47, 460, 465, 460, 465 },
                    { 48, 470, 475, 470, 475 },
                    { 49, 480, 485, 480, 485 },
                    { 50, 490, 495, 490, 495 },
                    { 51, 500, 505, 500, 505 },
                    { 52, 510, 515, 510, 515 },
                    { 53, 520, 525, 520, 525 },
                    { 54, 530, 535, 530, 535 },
                    { 55, 540, 545, 540, 545 },
                    { 56, 550, 555, 550, 555 },
                    { 57, 560, 565, 560, 565 },
                    { 58, 570, 575, 570, 575 },
                    { 59, 580, 585, 580, 585 },
                    { 60, 590, 595, 590, 595 },
                    { 61, 600, 605, 600, 605 },
                    { 62, 610, 615, 610, 615 },
                    { 63, 620, 625, 620, 625 },
                    { 64, 630, 635, 630, 635 },
                    { 65, 640, 645, 640, 645 },
                    { 66, 650, 655, 650, 655 },
                    { 67, 660, 665, 660, 665 },
                    { 68, 670, 675, 670, 675 },
                    { 69, 680, 685, 680, 685 },
                    { 70, 690, 695, 690, 695 },
                    { 71, 700, 705, 700, 705 },
                    { 72, 710, 715, 710, 715 },
                    { 73, 720, 725, 720, 725 },
                    { 74, 730, 735, 730, 735 },
                    { 75, 740, 745, 740, 745 },
                    { 76, 750, 755, 750, 755 },
                    { 77, 760, 765, 760, 765 },
                    { 78, 770, 775, 770, 775 },
                    { 79, 780, 785, 780, 785 },
                    { 80, 790, 795, 790, 795 },
                    { 81, 800, 805, 800, 805 },
                    { 82, 810, 815, 810, 815 },
                    { 83, 820, 825, 820, 825 },
                    { 84, 830, 835, 830, 835 },
                    { 85, 840, 845, 840, 845 },
                    { 86, 850, 855, 850, 855 },
                    { 87, 860, 865, 860, 865 },
                    { 88, 870, 875, 870, 875 },
                    { 89, 880, 885, 880, 885 },
                    { 90, 890, 895, 890, 895 },
                    { 91, 900, 905, 900, 905 },
                    { 92, 910, 915, 910, 915 },
                    { 93, 920, 925, 920, 925 },
                    { 94, 930, 935, 930, 935 },
                    { 95, 940, 945, 940, 945 },
                    { 96, 950, 955, 950, 955 },
                    { 97, 960, 965, 960, 965 },
                    { 98, 970, 975, 970, 975 },
                    { 99, 980, 985, 980, 985 },
                    { 100, 990, 995, 990, 995 },
                    { 101, 0, 6, 0, 6 },
                    { 102, 10, 16, 10, 16 },
                    { 103, 20, 26, 20, 26 },
                    { 104, 30, 36, 30, 36 },
                    { 105, 40, 46, 40, 46 },
                    { 106, 50, 56, 50, 56 },
                    { 107, 60, 66, 60, 66 },
                    { 108, 70, 76, 70, 76 },
                    { 109, 80, 86, 80, 86 },
                    { 110, 90, 96, 90, 96 },
                    { 111, 100, 106, 100, 106 },
                    { 112, 110, 116, 110, 116 },
                    { 113, 120, 126, 120, 126 },
                    { 114, 130, 136, 130, 136 },
                    { 115, 140, 146, 140, 146 },
                    { 116, 150, 156, 150, 156 },
                    { 117, 160, 166, 160, 166 },
                    { 118, 170, 176, 170, 176 },
                    { 119, 180, 186, 180, 186 },
                    { 120, 190, 196, 190, 196 },
                    { 121, 200, 206, 200, 206 },
                    { 122, 210, 216, 210, 216 },
                    { 123, 220, 226, 220, 226 },
                    { 124, 230, 236, 230, 236 },
                    { 125, 240, 246, 240, 246 },
                    { 126, 250, 256, 250, 256 },
                    { 127, 260, 266, 260, 266 },
                    { 128, 270, 276, 270, 276 },
                    { 129, 280, 286, 280, 286 },
                    { 130, 290, 296, 290, 296 },
                    { 131, 300, 306, 300, 306 },
                    { 132, 310, 316, 310, 316 },
                    { 133, 320, 326, 320, 326 },
                    { 134, 330, 336, 330, 336 },
                    { 135, 340, 346, 340, 346 },
                    { 136, 350, 356, 350, 356 },
                    { 137, 360, 366, 360, 366 },
                    { 138, 370, 376, 370, 376 },
                    { 139, 380, 386, 380, 386 },
                    { 140, 390, 396, 390, 396 },
                    { 141, 400, 406, 400, 406 },
                    { 142, 410, 416, 410, 416 },
                    { 143, 420, 426, 420, 426 },
                    { 144, 430, 436, 430, 436 },
                    { 145, 440, 446, 440, 446 },
                    { 146, 450, 456, 450, 456 },
                    { 147, 460, 466, 460, 466 },
                    { 148, 470, 476, 470, 476 },
                    { 149, 480, 486, 480, 486 },
                    { 150, 490, 496, 490, 496 },
                    { 151, 500, 506, 500, 506 },
                    { 152, 510, 516, 510, 516 },
                    { 153, 520, 526, 520, 526 },
                    { 154, 530, 536, 530, 536 },
                    { 155, 540, 546, 540, 546 },
                    { 156, 550, 556, 550, 556 },
                    { 157, 560, 566, 560, 566 },
                    { 158, 570, 576, 570, 576 },
                    { 159, 580, 586, 580, 586 },
                    { 160, 590, 596, 590, 596 },
                    { 161, 600, 606, 600, 606 },
                    { 162, 610, 616, 610, 616 },
                    { 163, 620, 626, 620, 626 },
                    { 164, 630, 636, 630, 636 },
                    { 165, 640, 646, 640, 646 },
                    { 166, 650, 656, 650, 656 },
                    { 167, 660, 666, 660, 666 },
                    { 168, 670, 676, 670, 676 },
                    { 169, 680, 686, 680, 686 },
                    { 170, 690, 696, 690, 696 },
                    { 171, 700, 706, 700, 706 },
                    { 172, 710, 716, 710, 716 },
                    { 173, 720, 726, 720, 726 },
                    { 174, 730, 736, 730, 736 },
                    { 175, 740, 746, 740, 746 },
                    { 176, 750, 756, 750, 756 },
                    { 177, 760, 766, 760, 766 },
                    { 178, 770, 776, 770, 776 },
                    { 179, 780, 786, 780, 786 },
                    { 180, 790, 796, 790, 796 },
                    { 181, 800, 806, 800, 806 },
                    { 182, 810, 816, 810, 816 },
                    { 183, 820, 826, 820, 826 },
                    { 184, 830, 836, 830, 836 },
                    { 185, 840, 846, 840, 846 },
                    { 186, 850, 856, 850, 856 },
                    { 187, 860, 866, 860, 866 },
                    { 188, 870, 876, 870, 876 },
                    { 189, 880, 886, 880, 886 },
                    { 190, 890, 896, 890, 896 },
                    { 191, 900, 906, 900, 906 },
                    { 192, 910, 916, 910, 916 },
                    { 193, 920, 926, 920, 926 },
                    { 194, 930, 936, 930, 936 },
                    { 195, 940, 946, 940, 946 },
                    { 196, 950, 956, 950, 956 },
                    { 197, 960, 966, 960, 966 },
                    { 198, 970, 976, 970, 976 },
                    { 199, 980, 986, 980, 986 },
                    { 200, 990, 996, 990, 996 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 200);
        }
    }
}
