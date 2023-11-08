using ShveynayaFabrika;
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
using System.Windows.Shapes;

namespace Shveynaya_Fabrika
{
    public partial class Furniture : Window
    {
        public Furniture()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            SFabricaEntities1 db = new SFabricaEntities1();
            FurnitureGrid.ItemsSource = db.Furnitura.ToList();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            StoreKeeper storeKeeper = new StoreKeeper();
            storeKeeper.Show();
            this.Close();
        }
    }
}
