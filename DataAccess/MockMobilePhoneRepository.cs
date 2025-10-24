using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBiding.Model;

namespace DataBiding.DataAccess
{
    public class MockMobilePhoneRepository : IRepository<MobilePhone>
    {
        public List<MobilePhone> GetAll()
        {
            return new List<MobilePhone>
            {
                new MobilePhone
                {
                    Id = 1,
                    Name = "iPhone 15 Pro Max",
                    Image = "Assets/Images/iphone15.png",
                    Manufacturer = "Apple",
                    Price = 1199.99
                },
                new MobilePhone
                {
                    Id = 2,
                    Name = "Samsung Galaxy S23 Ultra",
                    Image = "Assets/Images/galaxys23.jpg",
                    Manufacturer = "Samsung",
                    Price = 1099.99
                },
                new MobilePhone
                {
                    Id = 3,
                    Name = "Google Pixel 8 Pro",
                    Image = "Assets/Images/pixel8.jpg",
                    Manufacturer = "Google",
                    Price = 899.99
                },
                new MobilePhone
                {
                    Id = 4,
                    Name = "OnePlus 12 Pro",
                    Image = "Assets/Images/oneplus12.png",
                    Manufacturer = "OnePlus",
                    Price = 799.99
                },
                new MobilePhone
                {
                    Id = 5,
                    Name = "Xiaomi 14 Pro",
                    Image = "Assets/Images/xiaomi14.jpg",
                    Manufacturer = "Xiaomi",
                    Price = 749.99
                },
                new MobilePhone
                {
                    Id = 6,
                    Name = "Oppo Find X7 Pro",
                    Image = "Assets/Images/oppo_findx7.jpg",
                    Manufacturer = "Oppo",
                    Price = 699.99
                },
                new MobilePhone
                {
                    Id = 7,
                    Name = "Vivo X100 Pro",
                    Image = "Assets/Images/vivo_x100.jpg",
                    Manufacturer = "Vivo",
                    Price = 679.99
                },
                new MobilePhone
                {
                    Id = 8,
                    Name = "Sony Xperia 1 V",
                    Image = "Assets/Images/xperia1v.jpg",
                    Manufacturer = "Sony",
                    Price = 999.99
                },
                new MobilePhone
                {
                    Id = 9,
                    Name = "Motorola Edge 50 Pro",
                    Image = "Assets/Images/moto_edge50.jpg",
                    Manufacturer = "Motorola",
                    Price = 549.99
                },
                new MobilePhone
                {
                    Id = 10,
                    Name = "Nokia XR21",
                    Image = "Assets/Images/nokia_xr21.jpg",
                    Manufacturer = "Nokia",
                    Price = 429.99
                },
                new MobilePhone
                {
                    Id = 11,
                    Name = "Huawei P60 Pro",
                    Image = "Assets/Images/huawei_p60.jpg",
                    Manufacturer = "Huawei",
                    Price = 899.99
                },
                new MobilePhone
                {
                    Id = 12,
                    Name = "Asus ROG Phone 8",
                    Image = "Assets/Images/rog8.png",
                    Manufacturer = "Asus",
                    Price = 1099.00
                },
                new MobilePhone
                {
                    Id = 13,
                    Name = "Realme GT 6",
                    Image = "Assets/Images/realme_gt6.jpg",
                    Manufacturer = "Realme",
                    Price = 499.99
                },
                new MobilePhone
                {
                    Id = 14,
                    Name = "Google Pixel 8a",
                    Image = "Assets/Images/pixel8a.jpg",
                    Manufacturer = "Google",
                    Price = 499.00
                },
                new MobilePhone
                {
                    Id = 15,
                    Name = "Samsung Galaxy A55",
                    Image = "Assets/Images/galaxya55.jpg",
                    Manufacturer = "Samsung",
                    Price = 399.99
                },
                new MobilePhone
                {
                    Id = 16,
                    Name = "iPhone SE (3rd Gen)",
                    Image = "Assets/Images/iphonese3.jpg",
                    Manufacturer = "Apple",
                    Price = 429.00
                },
                new MobilePhone
                {
                    Id = 17,
                    Name = "Samsung Galaxy Z Fold5",
                    Image = "Assets/Images/galaxyzfold5.jpg",
                    Manufacturer = "Samsung",
                    Price = 1799.99
                },
                new MobilePhone
                {
                    Id = 18,
                    Name = "Samsung Galaxy Z Flip5",
                    Image = "Assets/Images/galaxyzflip5.jpeg",
                    Manufacturer = "Samsung",
                    Price = 999.99
                },
                new MobilePhone
                {
                    Id = 19,
                    Name = "Xiaomi Redmi Note 13 Pro",
                    Image = "Assets/Images/redmi_note13.jpg",
                    Manufacturer = "Xiaomi",
                    Price = 299.99
                },
                new MobilePhone
                {
                    Id = 20,
                    Name = "Honor Magic6 Pro",
                    Image = "Assets/Images/honor_magic6.jpg",
                    Manufacturer = "Honor",
                    Price = 799.00
                },
                new MobilePhone
                {
                    Id = 21,
                    Name = "Poco F6 Pro",
                    Image = "Assets/Images/poco_f6.jpg",
                    Manufacturer = "Poco",
                    Price = 429.99
                },
                new MobilePhone
                {
                    Id = 22,
                    Name = "LG Velvet 2 Pro",
                    Image = "Assets/Images/lg_velvet2.jpg",
                    Manufacturer = "LG",
                    Price = 449.99
                }
            };
        }
    }
}
