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
    class ChangePassViewModel : BaseViewModel
    {
        public ICommand AcceptCommand { get; set; }
        public ICommand ClearCommand { get; set; }
        //Khởi tạo các thuộc tính để TextBox Binding tới
        private string username;
        public string UserName
        {
            get => username;
            set
            {
                username = value;
                OnpPropertychanged();
            }
        }
        private string oldpassword;
        public string OldPassword
        {
            get => oldpassword;
            set
            {
                oldpassword = value;
                OnpPropertychanged();
            }
        }
        private string newpassword;
        public string NewPassword
        {
            get => newpassword;
            set
            {
                newpassword = value;
                OnpPropertychanged();
            }
        }
        public ChangePassViewModel()
        {
            //Nút lệnh làm mới
            ClearCommand = new RelayCommand<Window>((p) => 
            {
                if (string.IsNullOrEmpty(UserName) 
                    && string.IsNullOrEmpty(NewPassword)
                    && string.IsNullOrEmpty(OldPassword))
                    return false;
                return true; 
            }, (p) => 
            {
                UserName = "";
                OldPassword = "";
                NewPassword = "";
            }); 
            //Nút lệnh chấp nhận đổi mật khẩu
            AcceptCommand = new RelayCommand<object>((p) => 
            {
                if (string.IsNullOrEmpty(UserName) 
                    && string.IsNullOrEmpty(NewPassword) && string.IsNullOrEmpty(OldPassword))
                    return false;
                var account = DataSource.Instance.DB.QLNDs.Where(ob => ob.TaiKhoan == UserName 
                                                                 && ob.MatKhau == OldPassword).SingleOrDefault();
                if (account == null)
                   return false;
                return true;
            }, (p) => 
            {
                var user = DataSource.Instance.DB.QLNDs.Where(ob => ob.TaiKhoan == UserName 
                                                              && ob.MatKhau == OldPassword).SingleOrDefault();
                user.MatKhau = NewPassword;
                DataSource.Instance.DB.SaveChanges();
                MessageBox.Show("Change password successfully");  
            });
            
        }
    }
}
