using QLBHDT.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QLBHDT.ViewModel
{
    public class UserManagerViewModel : BaseViewModel
    {
        // Tạo danh sách để chưa dữ liệu từ bảng KhachHang
        private ObservableCollection<KhachHang> customerlist;
        public ObservableCollection<KhachHang> CustomerList
        {
            get => customerlist;
            set
            {
                customerlist = value;
                OnpPropertychanged();
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SearchCommand { get; set; }
        public UserManagerViewModel()
        {
            // Nạp dữ liệu cho danh sách CustomerList
            CustomerList = new ObservableCollection<KhachHang>(DataSource.Instance.DB.KhachHangs);
            // Nút lệnh thêm khách hàng mới
            AddCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(CusCode) && string.IsNullOrEmpty(CusName) 
                    && string.IsNullOrEmpty(Address) && string.IsNullOrEmpty(PhoneNumber))
                    return false;
                var customer = DataSource.Instance.DB.KhachHangs.Where(x => x.MaKH == CusCode);
                if (customer != null && customer.Count() != 0)
                    return false;
                return true;
            },
            (p) =>
            {
                var customer = new KhachHang() { MaKH = CusCode, HoTen = CusName, 
                                                 DiaChi = Address, SDT = PhoneNumber };
                var account = new QLND() { TaiKhoan = PhoneNumber, MatKhau = PhoneNumber, 
                                           MaKH = CusCode };
                DataSource.Instance.DB.KhachHangs.Add(customer);
                DataSource.Instance.DB.QLNDs.Add(account);
                DataSource.Instance.DB.SaveChanges();
                CustomerList.Add(customer);  
                MessageBox.Show("Creat successful customer");
            });
            // Nút lệnh sửa thông tin khách hàng
            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedCode == null && string.IsNullOrEmpty(CusName) 
                    && string.IsNullOrEmpty(Address) &&  string.IsNullOrEmpty(PhoneNumber))
                    return false;

                var list = DataSource.Instance.DB.KhachHangs.Where(x=>x.MaKH == SelectedItem.MaKH).SingleOrDefault();
                if (list == null)
                    return false;

                return true;
            },
            (p) =>
            {
                var customer = DataSource.Instance.DB.KhachHangs.Where(x=>x.MaKH == SelectedItem.MaKH).SingleOrDefault();

                customer.MaKH = CusCode;
                customer.HoTen = CusName;
                customer.DiaChi = Address;
                customer.SDT = PhoneNumber;

                DataSource.Instance.DB.SaveChanges();

                SelectedItem.MaKH = CusCode;
                SelectedItem.HoTen = CusName;
                SelectedItem.SDT = PhoneNumber;
                SelectedItem.DiaChi = Address;

            });
            //Nút lệnh xóa thông tin của khách hàng
            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedCode == null && string.IsNullOrEmpty(CusName) 
                                         && string.IsNullOrEmpty(Address) 
                                         && string.IsNullOrEmpty(PhoneNumber))
                    return false;

                var list = DataSource.Instance.DB.KhachHangs.Where(x => x.MaKH == SelectedItem.MaKH).SingleOrDefault();
                if (list == null)
                    return false;

                return true;
            },
           (p) =>
           {
               var customer = DataSource.Instance.DB.KhachHangs.Where(x => x.MaKH == SelectedItem.MaKH).SingleOrDefault();
               CustomerList.Remove(customer);
               MessageBox.Show("Delete customer success");
           });
            //Nút lệnh tìm kiếm thông tin của khách hàng
            SearchCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedCode == null)
                    return false;
                return true;
            },
            (p) =>
            {
                var customer = DataSource.Instance.DB.KhachHangs.Where(x => x.MaKH == SelectedCode.MaKH);
                if (customer != null)
                {
                    SelectedItem = SelectedCode;
                    SelectedItem.HoTen = SelectedCode.HoTen;
                    SelectedItem.SDT = SelectedCode.SDT;
                    SelectedItem.DiaChi = SelectedCode.DiaChi;

                    CusCode = SelectedCode.MaKH;
                    CusName = SelectedCode.HoTen;
                    Address = SelectedCode.DiaChi;
                    PhoneNumber = SelectedCode.SDT;
                    
                }
            });
        }

        // Tạo thuộc tính selecteditem để chọn phần tử cho ListView
        private KhachHang selecteditem;
        public KhachHang SelectedItem
        {
            get => selecteditem;
            set
            {
                selecteditem = value;
                OnpPropertychanged();
                if (SelectedItem != null)
                {
                    SelectedCode = SelectedItem;
                    CusCode = SelectedItem.MaKH;
                    PhoneNumber = SelectedItem.SDT;
                    Address = SelectedItem.DiaChi;
                    CusName = SelectedItem.HoTen;
                    
                }
            }
        }
        // Tạo thuộc tính selectedcode để chọn phần tử cho ComboBox
        private KhachHang selectedcode;
        public KhachHang SelectedCode
        {
            get => selectedcode;
            set
            {
                selectedcode = value;
                OnpPropertychanged();
            }
        }
        // Tạo các thuộc tính để TextBox Binding tới
        private string cuscode;
        public string CusCode
        {
            get => cuscode;
            set
            {
                cuscode = value;
                OnpPropertychanged();
            }
        }

        private string address;
        public string Address
        {
            get => address;
            set
            {
                address = value;
                OnpPropertychanged();
            }
        }

        private string cusname;
        public string CusName
        {
            get => cusname;
            set
            {
                cusname = value;
                OnpPropertychanged();
            }
        }

        private string phonenumber;
        public string PhoneNumber
        {
            get => phonenumber;
            set
            {
                phonenumber = value;
                OnpPropertychanged();
            }
        }

    }
}
