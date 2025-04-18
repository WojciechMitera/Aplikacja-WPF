﻿using System;
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
    public partial class Window1 : Window
    {
        public int id2;
        public string name2 = "";
        public string surname2 = "";
        public string pesel2 = "";

        public string secondname2 = "";
        public string city2 = "";
        public string adress2 = "";
        public string zipcode2 = "";
        public string phonenumber2 = "";
        public string dateofbirth2 = "";
        /*public string First(string n)
        {

            string fd = n[0].ToString().ToUpper();
            string rest = n.Substring(1).ToLower();
            string newn = fd + rest;
            return newn;
        }*/
        public Window1()
        {
            InitializeComponent();
        }

        private void goback_Click(object sender, RoutedEventArgs e)
        {

            id2 = int.Parse(idAdd.Text);
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
            int count = 0;
            //var mainwin = new MainWindow();
            if(name2 == "")
            {
                nameAdd.Background = Brushes.Red;
            }
            else
            {
                count += 1;
            }
            if (surname2 == "")
            {
                surnameAdd.Background = Brushes.Red;
            }
            else
            {
                count += 1;
            }
            if (pesel2 == "")
            {
                peselAdd.Background = Brushes.Red;
            }
            else
            {
                count += 1;
            }
            if (city2 == "")
            {
                cityAdd.Background = Brushes.Red;
            }
            else
            {
                count += 1;
            }
            if (adress2 == "")
            {
                adressAdd.Background = Brushes.Red;
            }
            else
            {
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
            switch (result)
            {
                case MessageBoxResult.Yes:
                    this.Close();
                    break;
                case MessageBoxResult.No:
                    break;

            }
        }


    }
}
