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

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    
    public partial class Window1 : Window
         
    {
        public string name2 = "";
        public string surname2 = "";
        public string pesel2 = "";
        public int id2 = 0;
        public Window1()
        {
            InitializeComponent();
        }

        private void goback_Click(object sender, RoutedEventArgs e)
        {
            
            name2 = nameAdd.Text;
            surname2 = surnameAdd.Text;
            pesel2 = peselAdd.Text;
            
            
            //var mainwin = new MainWindow();
            this.Close();
            //mainwin.ShowDialog();
        }
    }
}
