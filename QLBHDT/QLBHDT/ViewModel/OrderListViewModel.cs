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
    class OrderListViewModel : BaseViewModel
    {   
        //Khởi tạo danh sách chứa dữ liệu từ bảng HoaDon
        private ObservableCollection<HoaDon> orderlist;
        public ObservableCollection<HoaDon> OrderList
        {
            get => orderlist;
            set
            {
                orderlist = value;
                OnpPropertychanged();
            }
        }


        public ICommand EditCommand { get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand PrintCommand { get; set; }
        public OrderListViewModel()
        {
            //Đưa dữ liệu vào danh sách OrderList
            OrderList = new ObservableCollection<HoaDon>(DataSource.Instance.DB.HoaDons);
            //Nút lệnh để sửa thông tin của hóa đơn
            EditCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(OrCode) && string.IsNullOrEmpty(CusCode) 
                    && string.IsNullOrEmpty(ProCode) && TextQuantity == 0 && Total == 0 && CreatDate == null)
                    return false;
                var list = DataSource.Instance.DB.HoaDons.Where(x => x.MaHD == SelectedItem.MaHD).SingleOrDefault();
                if (list == null)
                    return false;
                return true;
            },
            (p) =>
            {
                var order = DataSource.Instance.DB.HoaDons.Where(x => x.MaHD == SelectedItem.MaHD).SingleOrDefault();

                order.MaHD = OrCode;
                order.MaKH = CusCode;
                order.MaSP = ProCode;
                order.NgayHD = CreatDate;
                order.SoLuong = TextQuantity;
                order.TriGia = Total;
                DataSource.Instance.DB.SaveChanges();

                SelectedItem.MaHD = OrCode;
                SelectedItem.MaKH = CusCode;
                SelectedItem.MaSP = ProCode;
                SelectedItem.NgayHD = CreatDate;
                SelectedItem.SoLuong = TextQuantity;
                SelectedItem.TriGia = Total;
            });
            //Nút lệnh tìm kiếm thông tin của hóa đơn
            SearchCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedCode == null)
                    return false;
                return true;
            },
            (p) =>
            {
                var order = DataSource.Instance.DB.HoaDons.Where(x => x.MaHD == SelectedCode.MaHD).SingleOrDefault();
                if (order != null)
                {
                    OrCode = SelectedCode.MaHD;
                    CusCode = SelectedCode.MaKH;
                    ProCode = SelectedCode.MaSP;
                    CreatDate = SelectedCode.NgayHD;
                    TextQuantity = (double)SelectedCode.SoLuong;
                    Total = (double)SelectedCode.TriGia;
                    SelectedItem = SelectedCode;
                }
            });
            //Nút lệnh mở của sổ Report để in hóa đơn
            PrintCommand = new RelayCommand<object>((p) =>
            {
                return true;
            },
           (p) =>
           {
               Report rp = new Report();
               rp.WindowStartupLocation = WindowStartupLocation.CenterScreen;
               rp.ShowDialog();
           });

        }

        //Khởi tạo selecteditem để thực hiện việc chọn đối tượng trong ListView
        private HoaDon selecteditem;
        public HoaDon SelectedItem
        {
            get => selecteditem;
            set
            {
                selecteditem = value;
                OnpPropertychanged();
                if (SelectedItem != null)
                {
                    SelectedCode = SelectedItem;
                    OrCode = SelectedItem.MaHD;
                    CusCode = SelectedItem.MaKH;
                    ProCode = SelectedItem.MaSP;
                    CreatDate = SelectedItem.NgayHD;
                    TextQuantity = (double)SelectedItem.SoLuong;
                    Total = (double)SelectedItem.TriGia;
                }
            }
        }
        //Khởi tạo selectedcode để thực hiện việc chọn  đối tượngtrong ComboBox
        private HoaDon selectedcode;
        public HoaDon SelectedCode
        {
            get => selectedcode;
            set
            {
                selectedcode = value;
                OnpPropertychanged();
            }
        }

        //Khởi tạo các thuộc tính để TextBox có thể Binding tới
        private string procode;
        public string ProCode
        {
            get => procode;
            set
            {
                procode = value;
                OnpPropertychanged();
            }
        }

        private string orcode;
        public string OrCode
        {
            get => orcode;
            set
            {
                orcode = value;
                OnpPropertychanged();
            }
        }

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

        private double textquantity;
        public double TextQuantity
        {
            get => textquantity;
            set
            {
                textquantity = value;
                OnpPropertychanged();
            }
        }

        private double total;
        public double Total
        {
            get => total;
            set
            {
                total = value;
                OnpPropertychanged();
            }
        }

        private DateTime? creatdate;
        public DateTime? CreatDate
        {
            get => creatdate;
            set
            {
                creatdate = value;
                OnpPropertychanged();
            }
        }

    }
}
