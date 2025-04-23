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

        public string secondname2 = "";
        public string city2 = "";
        public string adress2 = "";
        public string zipcode2 = "";
        public string phonenumber2 = "";
        public string dateofbirth2 = "";
        public string First(string n)
        {
            
            string fd = n[0].ToString().ToUpper();
            string rest = n.Substring(1).ToLower();
            string newn = fd + rest;
            return newn;
        }
        public bool checkpesel(string n)
        {
            if(n.Length != 11)
            {
                return false;
            }
            int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }; 
            for (int i = 0; i < n.Length; i++)
            {
                if (!tab.Contains(n[i]))
                {
                    return false;
                }
            }
            int z = int.Parse(n[0].ToString()) * 1 + int.Parse(n[1].ToString()) * 3 + int.Parse(n[2].ToString()) * 7 + int.Parse(n[3].ToString()) * 9 + int.Parse(n[4].ToString()) * 1 + int.Parse(n[5].ToString()) * 3 + int.Parse(n[6].ToString()) * 7 + int.Parse(n[7].ToString()) * 9 + int.Parse(n[8].ToString()) * 1 + int.Parse(n[9].ToString()) * 3;
            int k = (10 - (z % 10)) % 10;
            if(k != int.Parse(n[10].ToString()))
            {
                return false;
            }
            return true;

        }
        public Window1()
        {
            InitializeComponent();
        }

        private void goback_Click(object sender, RoutedEventArgs e)
        {

            
            name2 = nameAdd.Text;
            surname2 = surnameAdd.Text;
            pesel2 = peselAdd.Text;
            secondname2 = secondnameAdd.Text;
            city2 = cityAdd.Text;
            adress2 = adressAdd.Text;
            zipcode2 = zipcodeAdd.Text;
            phonenumber2 = phonenumberAdd.Text;
            dateofbirth2 = dateofbirthAdd.Text;
            nameAdd.Background = Brushes.White;
            surnameAdd.Background = Brushes.White;
            cityAdd.Background = Brushes.White;
            peselAdd.Background = Brushes.White;
            adressAdd.Background = Brushes.White;
            dateofbirthAdd.Background = Brushes.White;
            zipcodeAdd.Background = Brushes.White;
            if(secondname2 != "")
            {
                secondname2 = First(secondname2);
            }
            
            int count = 0;
            //var mainwin = new MainWindow();
            if (name2 == "")
            {
                nameAdd.Background = Brushes.Red;
            }
            else
            {
                name2 = First(name2);
                count += 1;
            }
            if (surname2 == "")
            {
                surnameAdd.Background = Brushes.Red;
            }
            else
            {
                surname2 = First(surname2);
                count += 1;
            }
            if (pesel2 == "")
            {
                peselAdd.Background = Brushes.Red;
            }
            else
            {
                if(checkpesel(pesel2) != true)
                {
                    peselAdd.Background = Brushes.Red;
                    
                }
                else
                {
                    count += 1;
                }
                
            }
            if (city2 == "")
            {
                cityAdd.Background = Brushes.Red;
            }
            else
            {
                city2 = First(city2);
                count += 1;
            }
            if (adress2 == "")
            {
                adressAdd.Background = Brushes.Red;
            }
            else
            {
                adress2 = First(adress2);
                count += 1;
            }
            if (zipcode2 == "")
            {
                zipcodeAdd.Background = Brushes.Red;
            }
            else
            {
                count += 1;
            }
            if (dateofbirth2 == "")
            {
                dateofbirthAdd.Background = Brushes.Red;
            }
            else
            {
                count += 1;
            }
            if (count == 7)
            {
                this.Close();
            }

        }

        private void goback_cancel_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("Czy napewno chcesz zamkąć to okno?", " ", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }


    }
}
