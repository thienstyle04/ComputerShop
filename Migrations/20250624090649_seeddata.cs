using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComputerShop.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Detail", "ImageUrl", "IsTrendingProduct", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Đây là dòng máy rất phù hợp với ae văn phòng, với thiết kế mọng và nhẹ rất phù hợp đẻ cầm.", "https://s.yimg.com/os/creatr-uploaded-images/2023-01/fb0dce50-8a31-11ed-b3ff-b8d61a9c0194", false, "Laptop Asus Zenbook 14", 21990000m },
                    { 2, "Đây là dòng máy gaming đến từ nhà Asus với thiết kế hầm hồ và hiệu năng cao từ đó mang lại trải nghiệm tốt nhất khi học tập và làm việc", "https://s.yimg.com/os/creatr-uploaded-images/2023-01/fb0dce50-8a31-11ed-b3ff-b8d61a9c0194", false, "Asus Gaming F15", 20990000m },
                    { 3, "Được tạo ra dựa trên chip M4, M4 Pro cho bạn hiệu năng mạnh mẽ hơn nữa và bộ nhớ thống nhất tăng cường để làm việc với những ứng dụng và luồng công việc đỏi hỏi cao, và Neural Engine giúp bạn xử lý nhanh chóng các quy trình làm việc chuyên nghiệp trên AI", "https://s.yimg.com/os/creatr-uploaded-images/2023-01/fb0dce50-8a31-11ed-b3ff-b8d61a9c0194", false, "Macbook 16 Pro", 32990000m },
                    { 4, "Đây là mẫu chuột phổ thông phù hợp với tất cả mọi người, mang đến nhưng trải nghiệm tuyệt vời trong tứng cú click chuột", "https://vn-test-11.slatic.net/p/25207546e24e317300760acff295d10d.png", false, "Chuột không dây Logitech M650", 599000m },
                    { 5, "Dễ dàng sắp xếp trong không gian làm việc, tiết kiệm diện tích và đáp ứng tốt nhu cầu sử dụng văn phòng như soạn thảo văn bản, lướt web, và sử dụng phần mềm chuyên dụng", "https://thuthuatnhanh.com/wp-content/uploads/2021/06/Hinh-anh-may-tinh-xin-nhat-585x390.jpg", false, "Pc văn phòng", 15000000m },
                    { 6, "Đúng như tên gọi của nó thì đây là dòng máy chuyên dùng để chơi các thể loại game với cấu hình và hiệu năng cáo giúp trải nhiệm về game hiệu quả", "https://thuthuatnhanh.com/wp-content/uploads/2021/06/Hinh-anh-may-tinh-xin-nhat-585x390.jpg", false, "Pc chuyên game", 22200000m },
                    { 7, "Đây là sự kết hợp giữa Pc văn phòng và PC chơi game không chỉ nhỏ gọn, tiết kiệm diện tích và đáp ứng tốt nhu cầu sử dụng văn phòng như soạn thảo văn bản, lướt web, và sử dụng phần mềm chuyên dụng mà còn đem lại hiệu năng cáo giúp trải nhiệm về game hiệu quả ", "/images/", false, "Pc hiệu năng cao", 30000000m },
                    { 8, "Đây là dòng phím Gaming mới nhất đến từ nhà logitech với thiết kế gọn gàng, tích kiểm diẹn tích ", "https://hanoicomputercdn.com/media/lib/49500_ban-phim-co-Logitech-G-Pro-X-RGB-Lightsync-Mechanical-GX-Blue-Switch-3.jpg", false, "Phím cơ Logitech Pro", 2500000m },
                    { 9, "Đây là dòng phím Gaming mới nhất đến từ nhà logitech với thiết kế gọn gàng, tích kiểm diẹn tích ", "https://hanoicomputercdn.com/media/lib/49500_ban-phim-co-Logitech-G-Pro-X-RGB-Lightsync-Mechanical-GX-Blue-Switch-3.jpg", false, "Phím cơ Logitech", 1800000m },
                    { 10, "Đây là dòng phím Gaming mới nhất đến từ nhà logitech với thiết kế gọn gàng, tích kiểm diẹn tích ", "https://hanoicomputercdn.com/media/lib/49500_ban-phim-co-Logitech-G-Pro-X-RGB-Lightsync-Mechanical-GX-Blue-Switch-3.jpg", false, "Phím bản giới hạn", 3500000m },
                    { 11, "Đây là thanh RAM thế hệ thứ 4 của nhà Kingston có hiệu năng cao", "https://th.bing.com/th/id/R.e2e9fe4a4d48d42c3831293df3303b6b?rik=HHHl706DT2o%2f4Q&riu=http%3a%2f%2fs3.amazonaws.com%2fdigitaltrends-uploads-prod%2f2017%2f05%2fHyperX-Predator-DDR4.jpg&ehk=p0pVo6Lm2g2MO%2fh8AzisdtHf3szuzXiUoOiKZBboXe8%3d&risl=&pid=ImgRaw&r=0", false, "Ram Kingston DDR4", 1500000m },
                    { 12, "Đây là thanh RAM thế hệ thứ 5 của nhà Kingston có hiệu năng cao", "https://th.bing.com/th/id/R.e2e9fe4a4d48d42c3831293df3303b6b?rik=HHHl706DT2o%2f4Q&riu=http%3a%2f%2fs3.amazonaws.com%2fdigitaltrends-uploads-prod%2f2017%2f05%2fHyperX-Predator-DDR4.jpg&ehk=p0pVo6Lm2g2MO%2fh8AzisdtHf3szuzXiUoOiKZBboXe8%3d&risl=&pid=ImgRaw&r=0", false, "Ram Kingston DDR5", 3000000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
