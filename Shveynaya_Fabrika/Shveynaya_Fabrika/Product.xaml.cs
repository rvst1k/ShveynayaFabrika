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
    public partial class Product : Window
    {
        public int Value { get; set; }
    
        SFabricaEntities1 db = new SFabricaEntities1();
        public Product(int value)
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            ProductGrid.ItemsSource = db.Izdeliya.ToList();
            Value = value;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if(Value == 3)
            {
                Manager manager = new Manager();
                manager.Show();
                this.Close();
            }
            if(Value == 4)
            {
                Director director = new Director();
                director.Show();
                this.Close();
            }
        }
    }
}
