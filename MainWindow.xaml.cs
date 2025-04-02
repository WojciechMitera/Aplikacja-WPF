using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    class Data
    {
        

        public int ID{ get ; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string  PESEL { get; set; }

        public Data()
        {
            ID = 0;
            Name = "Szymon";
            Surname = "Przeklasa";
            PESEL = "12345678901";
        }
        public void assign(int _ID, string _Name, string _Surname, string _PESEL)
        {
            ID = _ID;
            Name = _Name;
            Surname = _Name;
            PESEL = _PESEL;
        }
    }
        public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            //var person1 = new Data();
            //listview.Items.Add(person1);


            var win1 = new Window1();

            
            //this.Close();
            win1.ShowDialog();
           
            int id2 = win1.id2;
            string name2 = win1.name2;
            string surname2 = win1.surname2;
            string pesel2 = win1.pesel2;
            var item = new Data();
            item.assign(id2, name2, surname2, pesel2);
            listview.Items.Add(item);
        }
    }
}