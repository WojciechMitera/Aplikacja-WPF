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

namespace WpfApp1
{
    class Data
    {


        
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public string DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string ZIPCode { get; set; }
        public string PESEL { get; set; }



        public Data()
        {

        }



        
        public void assign(string _Name, string _SecondName, string _SurName, string _DateOfBirth, string _PhoneNumber, string _Adress, string _City, string _ZIPCode, string _PESEL)
        {
            
            Name = _Name;
            Surname = _SurName;
            PESEL = _PESEL;
            SecondName = _SecondName;
            DateOfBirth = _DateOfBirth;
            PhoneNumber = _PhoneNumber;
            City = _City;
            Adress = _Adress;
            ZIPCode = _ZIPCode;
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

            

            string name2 = win1.name2;
            string surname2 = win1.surname2;
            string pesel2 = win1.pesel2;
            string secondname2 = win1.secondname2;
            string city2 = win1.city2;
            string adress2 = win1.adress2;
            string zipcode2 = win1.zipcode2;
            string phonenumber2 = win1.phonenumber2;
            string dateofbirth2 = win1.dateofbirth2;

            var item = new Data();
            item.assign(name2, secondname2, surname2, dateofbirth2, phonenumber2, adress2, city2, zipcode2, pesel2);
            listview.Items.Add(item);
        }
    }
}