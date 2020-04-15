using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace gratisWPF
{
    /// <summary>
    /// Interaction logic for Hakkimizda.xaml
    /// </summary>
    public partial class Hakkimizda : Window
    {
        public Hakkimizda()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Anasayfa(object sender, RoutedEventArgs e)
        {
            MainWindow anasayfa = new MainWindow();
            this.Close();
            anasayfa.Show();
        }

        
    }
}
