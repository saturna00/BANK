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

namespace WpfApp30
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void REG_Click(object sender, RoutedEventArgs e)
        {
            if (log.Text.Length > 0)
            {
                if (par.Text.Length > 0)
                {
                    if (par2.Text.Length > 0)
                    {
                        if (par2.Text == par.Text)
                        {


                            MainWindow qqq = new MainWindow();
                            qqq.Show();
                            this.Close();
                            MessageBox.Show("НЕТ ПРОБЛЕМ И ЕСТЬ ДВА ЛЯМА В БАНКЕ");
                        }
                        else
                        {
                            MessageBox.Show("Неверный повтор пароля", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Повторите пароль", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Stop);
                    }
                }
                else
                {

                    MessageBox.Show("Введите пароль", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Stop);
                }
                }
                else {
                    MessageBox.Show("введите логин", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Stop);
                }
            }
            }
        }
    

