using System.Windows;
using System.Windows.Input;

namespace QLBHDT.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public bool Isloaded = false;
        public ICommand LoadedWindownCommand { get; set; }
        public ICommand ChangePasswordCommand { get; set; }
        public ICommand LogoutCommand { get; set; }
        public ICommand ListOfProductCommand { get; set; }
        public ICommand AddProductCommand { get; set; }
        public ICommand CreatAnOrderCommand { get; set; }
        public ICommand UserManagerCommand { get; set; }

        public MainViewModel()
        {
            Login lg = new Login();
            
            // Tải màn hình chính lên sau màn hình Login
            LoadedWindownCommand = new RelayCommand<MainWindow>((p) => { return true; }, (p) =>
             {
                 var loginvm = lg.DataContext as LoginViewModel;
                
                 if (lg.DataContext == null)
                     return;
                 
                 p.Hide();
                 lg.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                 lg.ShowDialog();
                 if (loginvm.IsLogin)
                 {
                     p.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                     p.ShowDialog();  
                 }
                 else
                 {
                     p.Close();
                 }
             }
            );
            // Nút lệnh đổi mật khẩu
            ChangePasswordCommand = new RelayCommand<object>((p) => 
            { 
                return true; 
            }, (p) => 
            { 
                ChangePassword chp = new ChangePassword();
                chp.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                chp.ShowDialog();
            });
            // Nút lệnh quay lại màn hình đăng nhập
            LogoutCommand = new RelayCommand<object>((p) => 
            { 
                return true; 
            }, (p) => 
            {
                Login lgvm = new Login();
                lgvm.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                lgvm.ShowDialog(); 
            });
            // Nút lệnh xem danh sách sản phẩm
            ListOfProductCommand = new RelayCommand<object>((p) => 
            { 
                return true; 
            }, (p) => 
            { 
                ListOfProduct lop = new ListOfProduct();
                lop.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                lop.ShowDialog(); 
            });
            //Nút lệnh tạo sản phẩm mới
            AddProductCommand = new RelayCommand<object>((p) => 
            {  
                if(lg.txtUserName.Text.Equals("admin"))
                    return true; 
                return false; 
            }, (p) => 
            { 
                AddProduct ap = new AddProduct();
                ap.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                ap.ShowDialog(); 
            });
            //Nút lệnh tạo hóa đơn mới
            CreatAnOrderCommand = new RelayCommand<object>((p) => 
            { 
                return true; 
            }, (p) => 
            { 
                CreatAnOrder co = new CreatAnOrder();
                co.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                co.ShowDialog(); 
            });
            // Nút lệnh quản lý người dùng
            UserManagerCommand = new RelayCommand<object>((p) => 
            { 
                if(lg.txtUserName.Text.Equals("admin"))
                    return true;
                return false; 
            }, (p) => 
            { 
                UserManager um = new UserManager();
                um.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                um.ShowDialog(); 
            });
        }
    }
}
