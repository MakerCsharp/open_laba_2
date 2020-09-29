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

namespace LABA_KYROPATKINA_2
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Frame_Loaded(object sender, RoutedEventArgs e)
        {
            Frame_1.Content = new Page2();
        }

        private void Button_Loaded(object sender, RoutedEventArgs e)
        {
            Push_up.Visibility = Visibility.Hidden;
        }

        private void Allerts_MouseEnter(object sender, MouseEventArgs e)
        {
            Push_up.Visibility = Visibility.Visible;
        }
    }
}
