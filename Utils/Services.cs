using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBiding.Utils
{
    // Lớp này hoạt động như một Service Locator/DI Container đơn giản
    public class Services
    {
        // Dùng một Dictionary để lưu các service đã được đăng ký
        // Key là tên của interface (ví dụ: "IRepository"), Value là đối tượng cụ thể (ví dụ: một instance của MockMobilePhoneRepository)
        private static Dictionary<string, object> _services = new();

        /// <summary>
        /// Đăng ký một lớp implement (Child) cho một interface (Parent)
        /// </summary>
        public static void Register<Parent, Child>()
        {
            Type parent = typeof(Parent);
            Type child = typeof(Child);
            _services.Add(parent.Name, Activator.CreateInstance(child)!);
        }

        /// <summary>
        /// Lấy ra đối tượng đã được đăng ký thông qua interface của nó
        /// </summary>
        public static Parent Get<Parent>()
        {
            Type type = typeof(Parent);
            return (Parent)_services[type.Name];
        }
    }
}
