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
using WPFTry1.Models;

namespace WPFTry1.Views
{
    /// <summary>
    /// Interaction logic for DashBoard.xaml
    /// </summary>
    public partial class DashBoard : Window
    {
        private List<Person> people;
        public DashBoard()
        {
            InitializeComponent();
            people = new List<Person>();
            people.Add(new Person { FirstName = "Marko", LastName = "Lazic", Age = 33, Adresss = "Prizrenska 16" });
            people.Add(new Person { FirstName = "Vuk", LastName = "Lazic", Age = 4, Adresss = "Palmoticeva 2" });
            people.Add(new Person { FirstName = "Stefan", LastName = "Lazic", Age = 2, Adresss = "Palmoticeva 2" });
            people.Add(new Person { FirstName = "Vasilije", LastName = "Lazic", Age = 1, Adresss = "Palmoticeva 2" });
            people.Add(new Person { FirstName = "Tamara", LastName = "Lazic", Age = 33, Adresss = "Prizrenska 16" });
        }

        public List<Person> People 
        {
            get
            {
                return people;
            }
        }
    }
}
