using QLBHDT.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QLBHDT.ViewModel
{
    class LoginViewModel : BaseViewModel
    {  
        public ICommand LoginCommand { get; set; }
        public bool IsLogin { get; set; }
        public ICommand PasswordCommand { get; set; }
        public ICommand ExitCommand { get; set; }
       // Khai báo thuộc tính username, lấy giá trị và đặt lại giá trị khi có sự thay đổi
        private string username;
        public string UserName 
        {   get => username;
            set 
            {
                username = value;
                OnpPropertychanged();
            } 
        }
        // Khai báo thuộc tính password, lấy giá trị và đặt lại giá trị khi có sự thay đổi
        private string password;
        public string Password
        {
            get => password;
            set
            {
                password = value;
                OnpPropertychanged();
            }
        }
        public LoginViewModel()
            {
                IsLogin = false;
                // Nút lệnh Login
                LoginCommand = new RelayCommand<Window>((p) => 
                { 
                    return true;
                }, (p) => 
                { 
                    Login(p); 
                });
                // Nút lệnh Exit
                ExitCommand = new RelayCommand<Window>((p) => 
                { 
                    return true; 
                }, (p) => 
                { 
                    p.Close(); 
                });
                // Lệnh để lấy Password trong PasswordBox
                PasswordCommand = new RelayCommand<PasswordBox>((p) => 
                {
                    return true;
                }, (p) => 
                { 
                    Password = p.Password; 
                });
            }
            //Phương thức Login
            void Login(Window p)
            {
                // Tạo đối tượng chứa dữ liệu từ QLND để kiểm tra tài khoản và mật khẩu
                var count = DataSource.Instance.DB.QLNDs.Where(ob => ob.TaiKhoan == UserName 
                                                               && ob.MatKhau == Password).Count();
                if (p == null)
                    return;
                if(count > 0)
                {
                    IsLogin = true; 
                    p.Close();
                }   
                else
                {
                    MessageBox.Show("Vui lòng nhập hoặc kiểm tra lại tài khoản và mật khẩu");
                }
            }
    }
}
