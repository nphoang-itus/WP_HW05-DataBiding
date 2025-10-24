using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBiding.Model
{
    public class MobilePhone
    {
        // Khóa chính để định danh
        public int Id { get; set; }

        // Tên của điện thoại, ví dụ: "iPhone 15 Pro Max"
        public string? Name { get; set; }

        // Đường dẫn tới file ảnh trong thư mục Assets
        // Ví dụ: "Assets/Images/iphone15.jpg"
        public string? Image { get; set; }

        // Tên nhà sản xuất, ví dụ: "Apple"
        public string? Manufacturer { get; set; }

        // Giá của sản phẩm
        public double Price { get; set; }

    }
}
