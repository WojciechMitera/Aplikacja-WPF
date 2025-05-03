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
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Linq;

namespace listview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
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

        

        private void New_Click(object sender, RoutedEventArgs e)
        {
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
            if (win1.isset == true)
            {
                var item = new Data();
                item.assign(name2, secondname2, surname2, dateofbirth2, phonenumber2, adress2, city2, zipcode2, pesel2);
                listview.Items.Add(item);
            }
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            while (listview.SelectedItems.Count > 0)
            {
                listview.Items.Remove(listview.SelectedItems[0]);
            }
        }

        private void open_Click(object sender, RoutedEventArgs e)
        {
            var OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "Pliki CSV z separatorem (,) |*.csv|Pliki CSV z separatorem (;) |*.csv";
            OpenFileDialog.Title = "Otwórz plik CSV";

            if(OpenFileDialog.ShowDialog() == true)
            {
                listview.Items.Clear();
                string filePath = OpenFileDialog.FileName;
                int SelectedFilterIndex = OpenFileDialog.FilterIndex;
                string delimiter = ";";
                if(SelectedFilterIndex == 1)
                {
                    delimiter = ",";
                }
                Encoding encoding = Encoding.UTF8;
                if (File.Exists(filePath))
                {
                    var lines = File.ReadAllLines(filePath, encoding);
                    foreach ( string line in lines )
                    {
                        string[] columns = line.Split(delimiter);
                        if(columns != null)
                        {
                            var item2 = new Data();
                            item2.assign(
                                columns.ElementAtOrDefault(0),
                                columns.ElementAtOrDefault(1),
                                columns.ElementAtOrDefault(2),
                                columns.ElementAtOrDefault(3),
                                columns.ElementAtOrDefault(4),
                                columns.ElementAtOrDefault(5),
                                columns.ElementAtOrDefault(6),
                                columns.ElementAtOrDefault(7),
                                columns.ElementAtOrDefault(8));
                            listview.Items.Add(item2);

                        }
                    }
                }
            }
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            var SaveFileDialog = new SaveFileDialog();
            SaveFileDialog.Filter = "Pliki CSV z separatorem (,) |*.csv|Pliki CSV z separatorem (;) |*.csv";
            SaveFileDialog.Title = "Zapisz jako plik CSV";

            if(SaveFileDialog.ShowDialog() == true)
            {
                string FilePath = SaveFileDialog.FileName;
                string delimiter = ";";
                if (SaveFileDialog.FilterIndex == 1)
                {
                    delimiter = ",";
                }
                using (var writer = new StreamWriter(FilePath))
                {
                    foreach (Data item in listview.Items)
                    {
                        var row = $"{item.Name}{delimiter}{item.SecondName}{delimiter}{item.Surname}{delimiter}{item.DateOfBirth}{delimiter}{item.PhoneNumber}{delimiter}{item.Adress}{delimiter}{item.City}{delimiter}{item.ZIPCode}{delimiter}{item.PESEL}";
                        writer.WriteLine(row);

                    }
                }

            }
        }
    }
}