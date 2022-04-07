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

namespace lab1wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DatePicker1.SelectedDate = DateTime.Today.AddDays(-1);
            BirthText.Text = "Pick a date!";
        }

        private void DateButtonClicked(object sender, RoutedEventArgs e)
        {
            /*
            //Creating a person
            var person = new Person(DatePicker1.SelectedDate.Value);
            //Invalid date of birth check
            if (person.birth > DateTime.Today || person.birth.Year < 1900)
            {
                MessageBox.Show("Invalid date");
                BirthText.Text = "";
            }
            //Checking for birthday
            else if (person.birth.Day == DateTime.Today.Day && person.birth.Month == DateTime.Today.Month)
            {
                BirthText.Text = "Happy Birthday!\nYou are " + person.CalculateYears().ToString() +
                                 " years old\nYour Chinese sign is " + person.chineseSign + "\nYour Western sign is " +
                                 person.westernSign;
            }
            //Ordinary text
            else
            {
                BirthText.Text = "You are " + person.CalculateYears().ToString() + " years old\nYour Chinese sign is " +
                                 person.chineseSign + "\nYour Western sign is " + person.westernSign;
            }
            */
        }
    }
}