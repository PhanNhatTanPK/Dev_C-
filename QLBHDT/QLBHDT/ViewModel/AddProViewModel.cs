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
    public class AddProViewModel : BaseViewModel
    {
        //Tạo danh sách để chứa dữ liệu
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

        public ICommand AcceptCommand { get; set; }
        public ICommand ClearCommand { get; set; }
        
        public AddProViewModel()
        {
            //Nạp dữ liệu vào danh sách ProductList
            ProductList = new ObservableCollection<SanPham>(DataSource.Instance.DB.SanPhams);
            //Nút lệnh tạo sản phẩm mới
            AcceptCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(ProCode) && ProCost == 0 
                        && string.IsNullOrEmpty(ProName) 
                        && TextQuantity == 0 && string.IsNullOrEmpty(OrigiCountry))
                    return false;

                var product = DataSource.Instance.DB.SanPhams.Where(x => x.MaSP == ProCode);
                if (product != null && product.Count() != 0)
                    return false;

                return true;
            },
            (p) =>
            {
                var product = new SanPham() { MaSP = ProCode, Gia= ProCost, 
                                              NuocSX = OrigiCountry, SoLuong = TextQuantity, 
                                              TenSP = ProName };

                DataSource.Instance.DB.SanPhams.Add(product);
                DataSource.Instance.DB.SaveChanges();
                ProductList.Add(product);
            });
            //Nút lệnh làm mới 
            ClearCommand = new RelayCommand<object>((p) =>
            {

                return true;
            },
            (p) =>
            {
                ProCode = "";
                ProCost = 0;
                ProName = "";
                OrigiCountry = "";
                TextQuantity = 0;
            });
        }

        //Tạo thuộc tính selecteditem để chọn các đối tượng trong ListView
        private SanPham selecteditem;
        public SanPham SelectedItem
        {
            get => selecteditem;
            set
            {
                selecteditem = value;
                OnpPropertychanged();
                if (SelectedItem != null)
                {
                    ProCode = SelectedItem.MaSP;
                    ProCost = (double)SelectedItem.Gia;
                    ProName = SelectedItem.TenSP;
                    OrigiCountry = SelectedItem.NuocSX;
                    TextQuantity = (double)SelectedItem.SoLuong;
                }
            }
        }
        //Tạo các thuộc tính để các TextBox Binding tới
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

        private double procost;
        public double ProCost
        {
            get => procost;
            set
            {
                procost = value;
                OnpPropertychanged();
            }
        }

        private string proname;
        public string ProName
        {
            get => proname;
            set
            {
                proname = value;
                OnpPropertychanged();
            }
        }

        private string origicountry;
        public string OrigiCountry
        {
            get => origicountry;
            set
            {
                origicountry = value;
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
    }
}
