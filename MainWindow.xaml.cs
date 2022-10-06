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

namespace WpfApp1_УП_02._02_ПР_2_Самостоятельная
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void mnuNew_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Гуляева Кристина");
        }

        private void mnuNew1_Click(object sender, RoutedEventArgs e)
        {
            Grid1.Background = Brushes.Red;
        }
                
    }
    }
    

