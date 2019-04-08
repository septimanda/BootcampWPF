using BootcampWPF.Applications;
using BootcampWPF.Interface;
using System;
using System.Collections.Generic;
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

namespace BootcampWPF.UserControls
{
    /// <summary>
    /// Interaction logic for SupplierUserControl.xaml
    /// </summary>
    public partial class SupplierUserControl : UserControl
    {
        ISupplier iSupplier = new SupplierController();
        Supplier supplier = new Supplier();
        string SupplierId;

        public SupplierUserControl()
        {
            InitializeComponent();
        }

        private void DeleteSupplier_Btn_Click(object sender, RoutedEventArgs e)
        {
            SupplierId = SupplierId_Txt.Text;
            iSupplier.Delete(Convert.ToInt16(SupplierId));

            LoadSupplier();
            DeleteSupplier_Btn.IsEnabled = false;

        }

        private void SaveSupplier_Btn_Click(object sender, RoutedEventArgs e)
        {
            SupplierId = SupplierId_Txt.Text;
            if (SupplierId == null || SupplierId == "")
            {
                supplier.Name = SupplierName_Txt.Text;
                iSupplier.Insert(supplier);

                LoadSupplier();
            }
            else
            {
                if (iSupplier.Get(Convert.ToInt32(SupplierId)) != null)
                {
                    supplier.Name = SupplierName_Txt.Text;
                    iSupplier.Update(Convert.ToInt32(SupplierId), supplier);

                    LoadSupplier();
                }
            }
            SupplierId_Txt.Clear();
            SupplierName_Txt.Clear();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            LoadSupplier();
            DeleteSupplier_Btn.IsEnabled = false;
        }

        void LoadSupplier()
        {
            Supplier_DataGrid.ItemsSource = iSupplier.Get();
        }

        private void Supplier_DataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object selectedItem = Supplier_DataGrid.SelectedItem;
            if (selectedItem != null)
            {
                SupplierId_Txt.Text = (Supplier_DataGrid.SelectedCells[0].Column.GetCellContent(selectedItem) as TextBlock).Text;
                SupplierName_Txt.Text = (Supplier_DataGrid.SelectedCells[1].Column.GetCellContent(selectedItem) as TextBlock).Text;
            }
            DeleteSupplier_Btn.IsEnabled = true;
        }
    }
}
