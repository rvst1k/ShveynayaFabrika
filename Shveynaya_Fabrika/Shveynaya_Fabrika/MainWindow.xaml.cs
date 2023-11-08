using Microsoft.SqlServer.Server;
using Shveynaya_Fabrika;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
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

namespace ShveynayaFabrika
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text == String.Empty || Password.Password == String.Empty)
            {
                MessageBox.Show("Заполните все поля!");            
            }
            else
            {
                using (SFabricaEntities1 sFabricaEntities1 = new SFabricaEntities1())
                {
                    AppUser user = sFabricaEntities1.AppUser.FirstOrDefault(u => u.Login == Login.Text && u.Password == Password.Password);

                    if (user == null)
                    {
                        MessageBox.Show("Проверьте правильность набранных данных!");
                    }
                    else
                    {
                        if(user.Role == 1)
                        {
                            var NewForm = new Customer();
                            NewForm.Show();
                            this.Close();
                        }
                        else if(user.Role == 2)
                        {
                            var NewForm = new Manager();
                            NewForm.Show();
                            this.Close();
                        }
                        else if(user.Role == 3)
                        {
                            var NewForm = new StoreKeeper();
                            NewForm.Show();
                            this.Close();
                        }
                        else if(user.Role == 4)
                        {
                            var NewForm = new Director();
                            NewForm.Show();
                            this.Close();
                        }
                    
                    
                    }
                }
            }
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            var NewForm = new Reg();
            NewForm.Show();
            this.Close();
        }
    }
}