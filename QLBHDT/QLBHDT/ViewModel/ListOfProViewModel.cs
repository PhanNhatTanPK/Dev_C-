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
    public class ListOfProViewModel : BaseViewModel
    {
        // Tạo danh sách chứa dữ liệu từ bảng SanPham.
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
 
        public ICommand EditCommand { get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ListOfProViewModel()
        {
            ProductList = new ObservableCollection<SanPham>(DataSource.Instance.DB.SanPhams);
            //Nút lệnh Edit
            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedCode == null && ProCost == 0 && string.IsNullOrEmpty(ProName) 
                    && TextQuantity == 0 && string.IsNullOrEmpty(OrigiCountry))
                        return false;

                var list = DataSource.Instance.DB.SanPhams. Where(x => x.MaSP == SelectedItem.MaSP).SingleOrDefault();
                if (list == null)
                       return false;

                return true;
            },(p) =>
            {
                var product = DataSource.Instance.DB.SanPhams.Where(x => x.MaSP == SelectedItem.MaSP).SingleOrDefault();

                product.MaSP = SelectedCode.MaSP;
                product.Gia = ProCost;
                product.NuocSX = OrigiCountry;
                product.TenSP = ProName;
                product.SoLuong = TextQuantity;
                DataSource.Instance.DB.SaveChanges();

                SelectedItem = SelectedCode;
                SelectedItem.TenSP = ProName;
                SelectedItem.Gia = ProCost;
                SelectedItem.NuocSX = OrigiCountry;
                SelectedItem.SoLuong = TextQuantity;

            });
            //Nút lệnh Search
            SearchCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedCode == null)
                    return false;
                return true;
            },
            (p) =>
            {
                var product = DataSource.Instance.DB.SanPhams.Where(x => x.MaSP == SelectedCode.MaSP).SingleOrDefault();
                if (product != null)
                {
                    SelectedItem = SelectedCode;
                    SelectedItem.TenSP = SelectedCode.TenSP;
                    SelectedItem.Gia = SelectedCode.Gia;
                    SelectedItem.NuocSX = SelectedCode.NuocSX;
                    SelectedItem.SoLuong = SelectedCode.SoLuong;

                    ProCost = (double)SelectedCode.Gia;
                    ProName = SelectedCode.TenSP;
                    TextQuantity = (double)SelectedCode.SoLuong;
                    OrigiCountry = SelectedCode.NuocSX;
                }
            });
            //Nút lệnh Delete
            DeleteCommand = new RelayCommand<AddProduct>((p) =>
            {
                if (SelectedCode == null && ProCost == 0 && string.IsNullOrEmpty(ProName) 
                                         && TextQuantity == 0 && string.IsNullOrEmpty(OrigiCountry))
                    return false;

                var list = DataSource.Instance.DB.SanPhams.Where(x => x.MaSP == SelectedItem.MaSP);
                if (list == null )
                    return false;

                return true;
            },
            (p) =>
            {
                var product = DataSource.Instance.DB.SanPhams.Where(x => x.MaSP == SelectedItem.MaSP).SingleOrDefault();
                ProductList.Remove(product);
                MessageBox.Show("Delete product success");
            });

        }

        // Tạo thuộc tính selecteditem để chọn các phần tử trong ListView    
        private SanPham selecteditem;
        public SanPham SelectedItem 
        { 
            get => selecteditem; 
            set 
            {
                selecteditem = value;
                OnpPropertychanged();
                if(SelectedItem != null)
                {
                    SelectedCode = SelectedItem;
                    ProCost = (double)SelectedItem.Gia;
                    ProName = SelectedItem.TenSP;
                    OrigiCountry = SelectedItem.NuocSX;
                    TextQuantity = (double)SelectedItem.SoLuong;
                }
            }
        }

        // Tạo thuộc tính selectedcode để chọn các phần tử trong ComboBox
        private SanPham selectedcode;
        public SanPham SelectedCode
        {
            get => selectedcode;
            set
            {
                selectedcode = value;
                OnpPropertychanged();  
            }
        }

        // Tạo các thuộc tính để các TextBox Binding tới
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
