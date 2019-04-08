using BootcampWPF.Applications;
using BootcampWPF.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for ItemUserControl.xaml
    /// </summary>
    public partial class ItemUserControl : UserControl
    {
        static ISupplier iSupplier = new SupplierController();

        IItem iItem = new ItemController();
        Item item = new Item();

        List<Supplier> SupplierList = iSupplier.Get();

        public ItemUserControl()
        {
            InitializeComponent();
        }

        private void Item_DataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object selectedItem = Item_DataGrid.SelectedItem;
            if (selectedItem != null)
            {
                ItemId_Txt.Text = (Item_DataGrid.SelectedCells[0].Column.GetCellContent(selectedItem) as TextBlock).Text;
                ItemName_Txt.Text = (Item_DataGrid.SelectedCells[1].Column.GetCellContent(selectedItem) as TextBlock).Text;
                ItemStock_Txt.Text = (Item_DataGrid.SelectedCells[2].Column.GetCellContent(selectedItem) as TextBlock).Text;
                ItemPrice_Txt.Text = (Item_DataGrid.SelectedCells[3].Column.GetCellContent(selectedItem) as TextBlock).Text;
                Supplier_comboBox.Text = (Item_DataGrid.SelectedCells[4].Column.GetCellContent(selectedItem) as TextBlock).Text;
            }
            DeleteItem_Btn.IsEnabled = true;

        }

        private void SaveItem_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (ItemName_Txt.Text == "" || ItemStock_Txt.Text == "" || ItemPrice_Txt.Text == "")
            {
                MessageBox.Show(" Error ");
                return;
            }

            if (Convert.ToInt32(Supplier_comboBox.SelectedIndex) == -1)
            {
                Supplier_comboBox.SelectedIndex = 0;
            }
                        
            item.Name = ItemName_Txt.Text;
            item.Stock = Convert.ToInt32(ItemStock_Txt.Text);
            item.Price = Convert.ToInt32(ItemPrice_Txt.Text);
            item.Suppliers = iSupplier.Get(Convert.ToInt32(Supplier_comboBox.SelectedValue));

            if (ItemId_Txt.Text == "")
            {
                iItem.Insert(item);
            }
            else
            {
                iItem.Update(Convert.ToInt32(ItemId_Txt.Text), item);
            }

            LoadItem();
            clearfield();            
        }

        private void Item_Txt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }

        void LoadItem()
        {
            Item_DataGrid.ItemsSource = iItem.Get();
        }

        void LoadComboBox()
        {
            Supplier_comboBox.ItemsSource = SupplierList;
        }

        void clearfield()
        {
            ItemId_Txt.Clear();
            ItemName_Txt.Clear();
            ItemStock_Txt.Clear();
            ItemPrice_Txt.Clear();
            Supplier_comboBox.SelectedIndex = -1;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            LoadItem();
            LoadComboBox();
            DeleteItem_Btn.IsEnabled = false;
        }
    }
}
