using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;

using System.Collections.Generic; // Cần cho List<T>

using DataBiding.Model;
using DataBiding.DataAccess;
using DataBiding.Utils;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DataBiding
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        // === PHẦN 1: TẠO LỚP VIEWMODEL LỒNG BÊN TRONG ===
        // Lớp này chịu trách nhiệm chuẩn bị dữ liệu cho UI
        public class MainViewModel
        {
            // Một thuộc tính public để chứa danh sách điện thoại.
            // UI sẽ binding vào thuộc tính này.
            public List<MobilePhone> MobilePhones { get; set; } = new();

            // Lấy repository thông qua Dependency Injection
            private IRepository<MobilePhone> _repo =
                Services.Get<IRepository<MobilePhone>>();

            // Hàm khởi tạo của ViewModel
            public MainViewModel()
            {
                // Nạp dữ liệu từ repository vào danh sách
                MobilePhones = _repo.GetAll();
            }
        }

        // === PHẦN 2: TẠO MỘT INSTANCE CỦA VIEWMODEL ===
        // MainWindow sẽ sở hữu một đối tượng ViewModel.
        // XAML sẽ truy cập vào đây để lấy dữ liệu.
        public MainViewModel ViewModel { get; set; } = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Activated(object sender, WindowActivatedEventArgs args)
        {

        }
    }
}
