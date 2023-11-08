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
    public partial class Reg : Window
    {
        public Reg()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            var NewForm = new MainWindow();
            NewForm.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text == String.Empty || Password.Password == String.Empty || Password1.Password == String.Empty || Name.Text == String.Empty)
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                if (Password.Password.Length < 6 || Password1.Password.Length < 6)
                {
                    MessageBox.Show("Минимальная длина пароля 6 символов!");
                }
                else
                {
                    if (Login.Text.Length < 4)
                    {
                        MessageBox.Show("Минимальная длина логина 4 символа!");
                    }
                    else
                    {
                        if (Password.Password.ToString() != Password1.Password.ToString())
                        {
                            MessageBox.Show("Пароли не совпадают!");
                        }
                        else
                        {
                            using (SFabricaEntities1 sFabricaEntities1 = new SFabricaEntities1())
                            {
                                AppUser user = sFabricaEntities1.AppUser.FirstOrDefault(u => u.Login == Login.Text);

                                if (user == null)
                                {
                                    AppUser appuser = new AppUser
                                    {
                                        Login = Login.Text,
                                        Password = Password.Password,
                                        Name = Name.Text,
                                        Role = 1
                                    };
                                    sFabricaEntities1.AppUser.Add(appuser);
                                    sFabricaEntities1.SaveChanges();
                                    MessageBox.Show("Вы успешно зарегистрировались!");
                                    Login.Clear();
                                    Password.Clear();
                                    Password1.Clear();
                                    Name.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("Пользователь с таким логином уже существует!");
                                }
                            }
                        }
                    }
                }
            }
        
        
        }
    }
}
