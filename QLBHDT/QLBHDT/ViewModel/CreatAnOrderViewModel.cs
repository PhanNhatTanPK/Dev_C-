using QLBHDT.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QLBHDT.ViewModel 
{
    
    public class CreatAnOrderViewModel : BaseViewModel
    {
        //Tạo danh sách chưa dữ liệu từ bảng SanPham
        private ObservableCollection<SanPham> productlist;
        public ObservableCollection<SanPham> ProductList
        {
            get => productlist;
            set
            {
                productlist = value;
                OnpPropertychanged();
            }
        }
        //Tạo danh sách chưa dữ liệu từ bảng KhachHang
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

        public ICommand AddOrderCommand { get; set; }
        public ICommand ClearOrderCommand { get; set; }
        public ICommand OrderListCommand { get; set; }
    
        public CreatAnOrderViewModel()
        {
            // Đưa dữ liệu vào hai danh sách ProductList và CustomerList
            ProductList = new ObservableCollection<SanPham>(DataSource.Instance.DB.SanPhams);
            CustomerList = new ObservableCollection<KhachHang>(DataSource.Instance.DB.KhachHangs);
            //Nút lệnh thêm hóa đơn
            AddOrderCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(OrderCode) && SelectedProCode == null && Quantity == 0 
                    && SelectedCusCode == null && Total == null && Date == null && Change == null)
                    return false;

                var list = DataSource.Instance.DB.HoaDons.Where(x => x.MaHD == OrderCode);
                if (list == null || list.Count() != 0)
                    return false;
                return true;
            },
            (p) =>
            {
                var order = new HoaDon() { MaHD = OrderCode, MaKH = SelectedCusCode.MaKH, 
                                           MaSP = SelectedProCode.MaSP, TriGia = Total, 
                                           NgayHD = Date, SoLuong = Quantity };
                DataSource.Instance.DB.HoaDons.Add(order);
                DataSource.Instance.DB.SaveChanges();
                System.Windows.MessageBox.Show("Order creation successful");

            });
            //Nút lệnh làm mới hóa đơn
            ClearOrderCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedCusCode == null && SelectedProCode == null)
                    return false;
                return true;
            },
            (p) =>
            {
                Address = "";
                PhoneNumber = "";
                Quantity = 0;
                Date = null;
                SelectedCusCode = null;
                SelectedProCode = null;
                Total = null;
                Change = null;
                Cash = null;
                OrderCode = "";

            });
            //Nút lệnh mở danh sách hóa đơn
            OrderListCommand = new RelayCommand<object>((p) =>
            {
                
                return true;
            },
            (p) =>
            {
                OrderList orlist = new OrderList();
                orlist.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                orlist.ShowDialog();
            });
        }

        // Khởi tạo thuộc tính selectedprocode để thực hiện chọn đối tượng trong ComboBox
        private SanPham selectedprocode;
        public SanPham SelectedProCode
        {
            get => selectedprocode;
            set
            {
                selectedprocode = value;
                OnpPropertychanged();
                if(SelectedProCode != null)
                {
                    ProCost = SelectedProCode.Gia;
                    Total = Multiplication();
                    Change = Subtraction();
                }
            }
        }
        // Khởi tạo thuộc tính selectedcuscode để thực hiện chọn đối tượng trong ComboBox
        private KhachHang selectedcuscode;
        public KhachHang SelectedCusCode
        {
            get => selectedcuscode;
            set
            {
                selectedcuscode = value;
                OnpPropertychanged();
                if (SelectedCusCode != null)
                {
                    Address = SelectedCusCode.DiaChi;
                    PhoneNumber = SelectedCusCode.SDT;
                }
            }
        }
        //Khởi tạo các thuộc tính để TextBox có thể Binding tới
        private string ordercode;
        public string OrderCode
        {
            get => ordercode;
            set
            {
                ordercode = value;
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

        private double? procost;
        public double? ProCost
        {
            get => procost;
            set
            {
                procost = value;
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

        private double quantity;
        public double Quantity
        {
            get => quantity;
            set
            {
                quantity = value; 
                OnpPropertychanged();
            }
        }

        private double? total;
        public double? Total
        {
            get => total;
            set
            {
                total = value;         
                OnpPropertychanged();
         
            }
        }

        private double? cash;
        public double? Cash
        {
            get => cash;
            set
            {
                cash = value;
                OnpPropertychanged();
            }
        }

        private double? change;
        public double? Change
        {
            get => change;
            set
            {
                change = value;
                OnpPropertychanged();  
            }
        }

        private DateTime? date;
        public DateTime? Date
        {
            get => date;
            set
            {   
                date = value;
                OnpPropertychanged();
            }
        }

        public double? Multiplication()
        {
            double? mul = 0;
            mul = ProCost * Quantity;
            return mul;
        }

        public double? Subtraction()
        {
            double? sub = 0;
            sub = Cash - Total;
            return sub;
        }
    }
}
