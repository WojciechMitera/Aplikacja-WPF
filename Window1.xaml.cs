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

namespace listview
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public string name2;
        public string surname2;
        public string pesel2;

        public string secondname2;
        public string city2;
        public string adress2;
        public string zipcode2;
        public string phonenumber2;
        public string dateofbirth2;
        public bool isset = true;
        public string First(string n)
        {
            n = n.Replace(" ", "");
            string fd = n[0].ToString().ToUpper();
            string rest = n.Substring(1).ToLower();
            string newn = fd + rest;
            return newn;
        }
        public bool checkdate(string n)
        {
            n = n.Trim().Replace(" ", "");

            string[] tab = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            string newdate = "";
            for (int i = 0; i < n.Length; i++)
            {
                if (tab.Contains(n[i].ToString()))
                {
                    newdate += n[i];
                }

            }
            if(newdate.Length != 8)
            {
                return false;
            }

            int day = int.Parse(newdate[0].ToString() + newdate[1].ToString());
            int month = int.Parse(newdate[2].ToString() + newdate[3].ToString());
            int year = int.Parse(newdate[4].ToString() + newdate[5].ToString() + newdate[6].ToString() + newdate[7].ToString());
            if(month > 12 || month < 1)
            {
                MessageBoxResult result = MessageBox.Show("Źle wprowadzony miesiąc.", " ", MessageBoxButton.OK);
                return false;   
            }
            if((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) && (day > 31 || day < 1))
            {
                MessageBoxResult result = MessageBox.Show("Źle wprowadzony dzień.", " ", MessageBoxButton.OK);
                return false;
            }
            if((month == 4 || month == 6 || month == 9 || month == 11) && (day > 30 || day < 1))
            {
                MessageBoxResult result = MessageBox.Show("Źle wprowadzony dzień.", " ", MessageBoxButton.OK);
                return false;
            }
            if(month == 2 && year % 4 == 0 && (day > 29 || day < 1))
            {
                MessageBoxResult result = MessageBox.Show("Źle wprowadzony dzień.", " ", MessageBoxButton.OK);
                return false;
            }
            if(month == 2 && year % 4 != 0 && (day > 28 || day < 1))
            {
                MessageBoxResult result = MessageBox.Show("Źle wprowadzony dzień.", " ", MessageBoxButton.OK);
                return false;
            }
            return true;
        }
        public bool checkpesel(string n)
        {
            if (n.Length != 11)
            {
                return false;
            }
            int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            for (int i = 0; i < n.Length; i++)
            {
                if (!tab.Contains(int.Parse(n[i].ToString())))
                {
                    
                    return false;
                }
            }
            int z = int.Parse(n[0].ToString()) * 1 + int.Parse(n[1].ToString()) * 3 + int.Parse(n[2].ToString()) * 7 + int.Parse(n[3].ToString()) * 9 + int.Parse(n[4].ToString()) * 1 + int.Parse(n[5].ToString()) * 3 + int.Parse(n[6].ToString()) * 7 + int.Parse(n[7].ToString()) * 9 + int.Parse(n[8].ToString()) * 1 + int.Parse(n[9].ToString()) * 3;
            int k = (10 - (z % 10)) % 10;
            if (k != int.Parse(n[10].ToString()))
            {
                return false;
            }
            return true;

        }
        public bool checkpeselwithdate(string n, string m)
        {
            if(m != "")
            {
            string[] tab = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            string newdate = "";
            for (int i = 0; i < m.Length; i++)
            {
                if (tab.Contains(m[i].ToString()))
                {
                    newdate += m[i];
                }
                
            }
            int day = int.Parse(newdate[0].ToString() + newdate[1].ToString());
            int month = int.Parse(newdate[2].ToString() + newdate[3].ToString());
            int year = int.Parse(newdate[4].ToString() + newdate[5].ToString() + newdate[6].ToString() +newdate[7].ToString());
                string year2 = newdate[6].ToString() + newdate[7].ToString();
            int monthp = int.Parse(n[2].ToString() + n[3].ToString());
            
            int month80 =  month + 80;
            int month0 = month;
            int month20 = month + 20;
            int month40 = month + 40;
            int month60 = month + 60;
                //MessageBoxResult result = MessageBox.Show(day + " " + month + " " + year, " ", MessageBoxButton.OK);
                if (year2 != n[0].ToString() + n[1].ToString())
                {
                    return false;
                }
            if ((year >= 1800 && year <= 1899) && month != month80)
            {
                return false;
                
            }
            else if ((year >= 1900 && year <= 1999) && monthp != month0)
            {
                return false;
            }
            else if ((year >= 2000 && year <= 2099) && monthp != month20)
            {
                return false;

            }
            else if ((year >= 2100 && year <= 2199) && monthp != month40)
            {
                return false;
            }
            else if ((year >= 2200 && year <= 2299) && monthp != month60)
            {
                return false;
            }

            if(day != int.Parse(n[4].ToString() + n[5].ToString()))
            {
                return false;
            }
            return true;
            }
            return false;
            
        }
        public string phone_number(string n)
        {
            bool istrue = false;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == '+')
                {
                    istrue = true;
                }
                
                
            }
            if (istrue == false)
            {
                return "+48 " + n;
            }
            return n;
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
            if (secondname2 != "")
            {
                secondname2 = First(secondname2);
            }
            if(phonenumber2 != " " && phonenumber2 != "")
            {
                phonenumber2 = phone_number(phonenumber2);
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
                if (checkpesel(pesel2) != true)
                {
                    peselAdd.Background = Brushes.Red;

                }
                else
                {
                    if(checkpeselwithdate(pesel2, dateofbirth2) != true)
                    {

                        MessageBoxResult result = MessageBox.Show("Pesel niezgodny z datą urodzenia", " ", MessageBoxButton.OK);
                        peselAdd.Background = Brushes.Red;
                    }
                    else
                    {
                        count += 1;
                    }
                        
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
                if(checkdate(dateofbirth2) != true)
                {
                    dateofbirthAdd.Background = Brushes.Red;
                }
                else
                {
                    count += 1;
                }
                    
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
                isset = false;
                this.Close();
            }
            else
            {

            }
        }


    }

}
