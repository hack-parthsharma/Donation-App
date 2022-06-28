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

namespace Lab4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            aeTextblock.Text = "";
            trTextblock.Text = "";
            msgTextblock.Text = "";
        }

        private decimal totalRaised = 0;

        private void donateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Calculate();
                msgTextblock.Text = "Thanks " + nameTextBox.Text + "!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a decimal number.", "Error!");
                daTextbox.Text = "";
                msgTextblock.Text = "";
            }
        }

        private void Calculate()
        {
            decimal donation = decimal.Parse(daTextbox.Text);

            decimal expenses = 0.17m * donation;
            decimal afterExpenses = donation - expenses;
            aeTextblock.Text = afterExpenses.ToString("C");

            totalRaised += afterExpenses;
            trTextblock.Text = totalRaised.ToString("C");

        }
    }
}