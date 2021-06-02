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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window1_Loaded(object sender, RoutedEventArgs e)
        {

            WpfApp30.ClientiDataSet clientiDataSet = ((WpfApp30.ClientiDataSet)(this.FindResource("clientiDataSet")));
            // Загрузить данные в таблицу clienti. Можно изменить этот код как требуется.
            WpfApp30.ClientiDataSetTableAdapters.clientiTableAdapter clientiDataSetclientiTableAdapter = new WpfApp30.ClientiDataSetTableAdapters.clientiTableAdapter();
            clientiDataSetclientiTableAdapter.Fill(clientiDataSet.clienti);
            System.Windows.Data.CollectionViewSource clientiViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("clientiViewSource")));
            clientiViewSource.View.MoveCurrentToFirst();
        }
    }
    }

